using Microsoft.Data.SqlClient;
using System.Data;

namespace CakesAndDelightsPos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }
        private void Form1_Load(object sender, EventArgs e)     // Event handler: runs when the form loads (window opens)
        {
            this.ordersHistoryGrid.Visible = false;          // Hide the orders grid initially (not needed until user clicks "View Orders")
            
            
            // Fetch cake data from database and show in the DataGridView
            List<Cake> cakeList = GetCakesFromDatabase();
            dataGridViewCakes.DataSource = cakeList;    // Bind the cake list to the grid so it displays

            // Optional: Format price column,// Format the price column to look like currency (e.g., $10.00)
            dataGridViewCakes.Columns["Price"].DefaultCellStyle.Format = "C2";

            // Add a "Quantity" column if it doesn't already exist
            if (!dataGridViewCakes.Columns.Contains("Quantity"))
            {
                // Create a new text box column for Quantity
                DataGridViewTextBoxColumn quantityCol = new()
                {
                    Name = "Quantity",
                    HeaderText = "Quantity",
                    ValueType = typeof(int),
                    DefaultCellStyle = { NullValue = "0" }
                };
                dataGridViewCakes.Columns.Add(quantityCol);     // Add to the grid
            }

            // Make all columns read-only except the Quantity column
            foreach (DataGridViewColumn col in dataGridViewCakes.Columns)
            {
                col.ReadOnly = col.Name != "Quantity";   // Only Quantity is editable
            }
        }



        // Function to get cakes from the database
        private List<Cake> GetCakesFromDatabase()
        {
            List<Cake> cakes = new List<Cake>();   // Create an empty list to store cakes


            // Get connection string from App.config file
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["cakesanddelightsdatabase"].ConnectionString;

            // Open a SQL connection inside 'using' so it closes automatically after use
            using (SqlConnection sqlConnection = new(connectionString))
            {
                // Prepare a command to call the stored procedure
                SqlCommand sqlCommand = new SqlCommand("usp_GetAllCakes", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;   // Tells SQL it's a stored procedure

                sqlConnection.Open();   //socket connection open,// Open the connection to the database (establish socket)

                using SqlDataReader reader = sqlCommand.ExecuteReader();     // Execute the stored procedure and get a reader (like a cursor that reads row by row)

                while (reader.Read())   // Loop through each record (row) returned by the reader
                {
                    Cake cake = new Cake()
                    {
                        CakeId = Convert.ToInt32(reader["CakeId"]),    //Read CakeId column
                        Name = reader["Name"].ToString(),
                        Price = Convert.ToDecimal(reader["Price"]),
                        Description = reader["Description"].ToString(),
                        IsAvailable = Convert.ToBoolean(reader["IsAvailable"])
                    };
                    cakes.Add(cake);      // Add each cake to the list
                }

            }

            return cakes;
        }


        // Event handler for "Add to Cart" button click
        private void button1_Click(object sender, EventArgs e)
        {
            List<Order_Summary> cakesAddedToCart = new List<Order_Summary>();   // New list to hold selected cakes

            // Loop through each row in the cakes DataGridView
            foreach (DataGridViewRow row in dataGridViewCakes.Rows)
            {
                // Check if quantity cell has a value (not null) and >= 0
                if (row.Cells["Quantity"].Value != null && Convert.ToInt32(row.Cells["Quantity"].Value) >= 0)
                {
                    int id = Convert.ToInt32(row.Cells["CakeId"].Value);

                    // Get cake details from the selected row,// Create a new Order_Summary object with details from the row
                    Order_Summary cake = new Order_Summary()
                    {
                        CakeId = Convert.ToInt32(row.Cells["CakeId"].Value),     // Cake ID
                        Name = row.Cells["Name"]?.Value.ToString(),              //Name
                        Price = Convert.ToDecimal(row.Cells["Price"].Value),             //Price
                        Quantity = Convert.ToInt32(row.Cells["Quantity"].Value),           //Quantity
                        Subtotal = Convert.ToDecimal(row.Cells["Price"].Value) * Convert.ToInt32(row.Cells["Quantity"].Value)          // Price * Quantity
                    };


                    cakesAddedToCart.Add(cake);       // Add selected cake to the list

                }
            }

            // Open a new form(OrdersSummary) to show the selected cakes
            OrdersSummary ordersSummary = new OrdersSummary(cakesAddedToCart);

            ordersSummary.Show();   // Display the new window
        }


        // Event handler for "View Orders" button click
        private void btnvieworders_Click(object sender, EventArgs e)
        {
            try
            {
                LoadHistoryOrders();     // Fetch past orders and display in grid
                this.ordersHistoryGrid.Visible = true;       // Show orders grid
                this.dataGridViewCakes.Visible = false;     // Hide cake list
                this.btnAddToCart.Visible = false;          // Hide Add to Cart button
                this.cakesMenu.BackColor = Color.White;            // Reset cakes menu button color
                this.btnvieworders.BackColor = Color.Green;      // Highlight view orders button
            }
            catch(Exception ex)
            {
                // Empty catch (not ideal – usually you would log or show an error)
            }

            finally
            {
                Cursor.Current = Cursors.Default;     // Reset mouse cursor
            }
        }


        // Function to load all history orders from DB and bind to grid
        private void LoadHistoryOrders()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;    // Change mouse cursor to loading

                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["cakesanddelightsdatabase"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_ViewOrders", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        conn.Open();

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);     // Adapter fills data
                        DataTable dt = new DataTable();                          // In-memory table
                        adapter.Fill(dt);                                  // Fill table with data

                        ordersHistoryGrid.DataSource = dt; // bind results,// Show results in grid
                        ordersHistoryGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;    // Auto size columns
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching orders: " + ex.Message);    // Show error to user
            }
        }



        // Event handler for "Cakes Menu" button click
        private void cakesMenu_Click(object sender, EventArgs e)
        {
            this.ordersHistoryGrid.Visible = false;    // Hide orders grid
            this.dataGridViewCakes.Visible = true;      // Show cakes grid
            this.btnAddToCart.Visible = true;            // Show Add to Cart button
            this.cakesMenu.BackColor = Color.Green;        // Highlight cakes menu button
            this.btnvieworders.BackColor = Color.White;     // Reset view orders button color
        }
    }
}
    


