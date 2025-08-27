namespace CakesAndDelightsPos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewCakes = new DataGridView();
            btnAddToCart = new Button();
            btnvieworders = new Button();
            cakesMenu = new Button();
            ordersHistoryGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCakes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ordersHistoryGrid).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCakes
            // 
            dataGridViewCakes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCakes.Location = new Point(12, 78);
            dataGridViewCakes.Name = "dataGridViewCakes";
            dataGridViewCakes.RowHeadersWidth = 51;
            dataGridViewCakes.Size = new Size(936, 321);
            dataGridViewCakes.TabIndex = 0;
            
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(688, 458);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(94, 29);
            btnAddToCart.TabIndex = 1;
            btnAddToCart.Text = "Continue";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += button1_Click;
            // 
            // btnvieworders
            // 
            btnvieworders.Location = new Point(12, 12);
            btnvieworders.Name = "btnvieworders";
            btnvieworders.Size = new Size(111, 29);
            btnvieworders.TabIndex = 2;
            btnvieworders.Text = "ViewOrders";
            btnvieworders.UseVisualStyleBackColor = true;
            btnvieworders.Click += btnvieworders_Click;
            // 
            // cakesMenu
            // 
            cakesMenu.Location = new Point(121, 12);
            cakesMenu.Name = "cakesMenu";
            cakesMenu.Size = new Size(134, 29);
            cakesMenu.TabIndex = 3;
            cakesMenu.Text = "Cakes Menu";
            cakesMenu.UseVisualStyleBackColor = true;
            cakesMenu.Click += cakesMenu_Click;
            // 
            // ordersHistoryGrid
            // 
            ordersHistoryGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersHistoryGrid.Location = new Point(11, 73);
            ordersHistoryGrid.Name = "ordersHistoryGrid";
            ordersHistoryGrid.ReadOnly = true;
            ordersHistoryGrid.RowHeadersWidth = 51;
            ordersHistoryGrid.Size = new Size(1057, 499);
            ordersHistoryGrid.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 687);
            Controls.Add(ordersHistoryGrid);
            Controls.Add(cakesMenu);
            Controls.Add(btnvieworders);
            Controls.Add(btnAddToCart);
            Controls.Add(dataGridViewCakes);
            Name = "Form1";
            Text = "Cakes Menu";
            Load += Form1_Load;
            EnabledChanged += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCakes).EndInit();
            ((System.ComponentModel.ISupportInitialize)ordersHistoryGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewCakes;
        private Button btnAddToCart;
        private Button btnvieworders;
        private Button cakesMenu;
        private DataGridView ordersHistoryGrid;
    }
}
