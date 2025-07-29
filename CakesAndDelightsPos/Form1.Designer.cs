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
            ((System.ComponentModel.ISupportInitialize)dataGridViewCakes).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCakes
            // 
            dataGridViewCakes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCakes.Location = new Point(103, 96);
            dataGridViewCakes.Name = "dataGridViewCakes";
            dataGridViewCakes.RowHeadersWidth = 51;
            dataGridViewCakes.Size = new Size(609, 188);
            dataGridViewCakes.TabIndex = 0;
            dataGridViewCakes.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewCakes);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCakes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewCakes;
    }
}
