namespace CakesAndDelightsPos
{
    partial class Viewordersummary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            gridviewOrderID = new DataGridViewTextBoxColumn();
            gridviewName = new DataGridViewTextBoxColumn();
            gridviewemail = new DataGridViewTextBoxColumn();
            gridviewPhoneNumber = new DataGridViewTextBoxColumn();
            gridviewcustomermessage = new DataGridViewTextBoxColumn();
            gridviewtotalamount = new DataGridViewTextBoxColumn();
            btnback = new Button();
            btnplaceorder = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { gridviewOrderID, gridviewName, gridviewemail, gridviewPhoneNumber, gridviewcustomermessage, gridviewtotalamount });
            dataGridView1.Location = new Point(12, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(784, 188);
            dataGridView1.TabIndex = 0;
            // 
            // gridviewOrderID
            // 
            gridviewOrderID.HeaderText = "OrderId";
            gridviewOrderID.MinimumWidth = 6;
            gridviewOrderID.Name = "gridviewOrderID";
            gridviewOrderID.Width = 125;
            // 
            // gridviewName
            // 
            gridviewName.HeaderText = "Name";
            gridviewName.MinimumWidth = 6;
            gridviewName.Name = "gridviewName";
            gridviewName.Width = 125;
            // 
            // gridviewemail
            // 
            gridviewemail.HeaderText = "Email";
            gridviewemail.MinimumWidth = 6;
            gridviewemail.Name = "gridviewemail";
            gridviewemail.Width = 125;
            // 
            // gridviewPhoneNumber
            // 
            gridviewPhoneNumber.HeaderText = "PhoneNumber";
            gridviewPhoneNumber.MinimumWidth = 6;
            gridviewPhoneNumber.Name = "gridviewPhoneNumber";
            gridviewPhoneNumber.Width = 125;
            // 
            // gridviewcustomermessage
            // 
            gridviewcustomermessage.HeaderText = "CustomerMessage";
            gridviewcustomermessage.MinimumWidth = 6;
            gridviewcustomermessage.Name = "gridviewcustomermessage";
            gridviewcustomermessage.Width = 125;
            // 
            // gridviewtotalamount
            // 
            gridviewtotalamount.HeaderText = "Total amount";
            gridviewtotalamount.MinimumWidth = 6;
            gridviewtotalamount.Name = "gridviewtotalamount";
            gridviewtotalamount.Width = 125;
            // 
            // btnback
            // 
            btnback.Location = new Point(190, 361);
            btnback.Name = "btnback";
            btnback.Size = new Size(94, 29);
            btnback.TabIndex = 1;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // btnplaceorder
            // 
            btnplaceorder.Location = new Point(505, 362);
            btnplaceorder.Name = "btnplaceorder";
            btnplaceorder.Size = new Size(94, 29);
            btnplaceorder.TabIndex = 2;
            btnplaceorder.Text = "PlaceOrder";
            btnplaceorder.UseVisualStyleBackColor = true;
            btnplaceorder.Click += btnplaceorder_Click;
            // 
            // Viewordersummary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnplaceorder);
            Controls.Add(btnback);
            Controls.Add(dataGridView1);
            Name = "Viewordersummary";
            Text = "Viewordersummary";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn gridviewOrderID;
        private DataGridViewTextBoxColumn gridviewName;
        private DataGridViewTextBoxColumn gridviewemail;
        private DataGridViewTextBoxColumn gridviewPhoneNumber;
        private DataGridViewTextBoxColumn gridviewcustomermessage;
        private DataGridViewTextBoxColumn gridviewtotalamount;
        private Button btnback;
        private Button btnplaceorder;
    }
}