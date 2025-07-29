using static CakesAndDelightsPos.Cake;
using Microsoft.Data.SqlClient;

namespace CakesAndDelightsPos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }
        private List<Cake> GetCakesFromDatabase()
        {
            List<Cake> cakes = new List<Cake>();

            string connectionString = "Server=localhost;Database=CakesAndDelights;Integrated Security=True;Trusted_Connection=True;TrustServerCertificate=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("usp_GetAllCakes", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Cake cake = new Cake()
                    {
                        CakeId = Convert.ToInt32(reader["CakeId"]),
                        Name = reader["Name"].ToString(),
                        Price = Convert.ToDecimal(reader["Price"]),
                        Description = reader["Description"].ToString()
                    };
                    cakes.Add(cake);
                }

                reader.Close();
            }

            return cakes;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            List<Cake> cakeList = GetCakesFromDatabase();
            dataGridViewCakes.DataSource = cakeList;

        }
    }
}

