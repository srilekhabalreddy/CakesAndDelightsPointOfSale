namespace CakesAndDelightsPos
{
    partial class OrdersSummary
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
            summaryGrid = new DataGridView();
            labelfirstnameordersummary = new Label();
            labelsecondnamesummary = new Label();
            labelphonenumbersummary = new Label();
            labelemailsummary = new Label();
            firstName = new TextBox();
            lastName = new TextBox();
            pnNumber = new TextBox();
            email = new TextBox();
            btnback = new Button();
            btnPlaceOrder = new Button();
            orderSummaryGroup = new GroupBox();
            btnviewordersummary = new Button();
            ordersPlaced = new GroupBox();
            cstmessage = new RichTextBox();
            CustomMessage = new Label();
            orderListView = new ListView();
            ((System.ComponentModel.ISupportInitialize)summaryGrid).BeginInit();
            orderSummaryGroup.SuspendLayout();
            ordersPlaced.SuspendLayout();
            SuspendLayout();
            // 
            // summaryGrid
            // 
            summaryGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            summaryGrid.Location = new Point(36, 38);
            summaryGrid.Name = "summaryGrid";
            summaryGrid.RowHeadersWidth = 51;
            summaryGrid.Size = new Size(632, 257);
            summaryGrid.TabIndex = 0;
            summaryGrid.UseWaitCursor = true;
            // 
            // labelfirstnameordersummary
            // 
            labelfirstnameordersummary.AutoSize = true;
            labelfirstnameordersummary.Location = new Point(833, 38);
            labelfirstnameordersummary.Name = "labelfirstnameordersummary";
            labelfirstnameordersummary.Size = new Size(76, 20);
            labelfirstnameordersummary.TabIndex = 2;
            labelfirstnameordersummary.Text = "FirstName";
            labelfirstnameordersummary.UseWaitCursor = true;
            // 
            // labelsecondnamesummary
            // 
            labelsecondnamesummary.AutoSize = true;
            labelsecondnamesummary.Location = new Point(833, 90);
            labelsecondnamesummary.Name = "labelsecondnamesummary";
            labelsecondnamesummary.Size = new Size(75, 20);
            labelsecondnamesummary.TabIndex = 3;
            labelsecondnamesummary.Text = "LastName";
            labelsecondnamesummary.UseWaitCursor = true;
            // 
            // labelphonenumbersummary
            // 
            labelphonenumbersummary.AutoSize = true;
            labelphonenumbersummary.Location = new Point(835, 138);
            labelphonenumbersummary.Name = "labelphonenumbersummary";
            labelphonenumbersummary.Size = new Size(104, 20);
            labelphonenumbersummary.TabIndex = 4;
            labelphonenumbersummary.Text = "PhoneNumber";
            labelphonenumbersummary.UseWaitCursor = true;
            // 
            // labelemailsummary
            // 
            labelemailsummary.AutoSize = true;
            labelemailsummary.Location = new Point(835, 189);
            labelemailsummary.Name = "labelemailsummary";
            labelemailsummary.Size = new Size(46, 20);
            labelemailsummary.TabIndex = 5;
            labelemailsummary.Text = "Email";
            labelemailsummary.UseWaitCursor = true;
            // 
            // firstName
            // 
            firstName.Location = new Point(961, 38);
            firstName.Name = "firstName";
            firstName.Size = new Size(298, 27);
            firstName.TabIndex = 6;
            firstName.UseWaitCursor = true;
            // 
            // lastName
            // 
            lastName.Location = new Point(961, 83);
            lastName.Name = "lastName";
            lastName.Size = new Size(298, 27);
            lastName.TabIndex = 7;
            lastName.UseWaitCursor = true;
            // 
            // pnNumber
            // 
            pnNumber.Location = new Point(961, 135);
            pnNumber.Name = "pnNumber";
            pnNumber.Size = new Size(298, 27);
            pnNumber.TabIndex = 8;
            pnNumber.UseWaitCursor = true;
            // 
            // email
            // 
            email.Location = new Point(961, 182);
            email.Name = "email";
            email.Size = new Size(298, 27);
            email.TabIndex = 9;
            email.UseWaitCursor = true;
            // 
            // btnback
            // 
            btnback.Location = new Point(800, 350);
            btnback.Name = "btnback";
            btnback.Size = new Size(94, 29);
            btnback.TabIndex = 11;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            btnback.UseWaitCursor = true;
            btnback.Click += btnback_Click;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new Point(700, 350);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(94, 29);
            btnPlaceOrder.TabIndex = 12;
            btnPlaceOrder.Text = "PlaceOrder";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.UseWaitCursor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // orderSummaryGroup
            // 
            orderSummaryGroup.Controls.Add(summaryGrid);
            orderSummaryGroup.Controls.Add(email);
            orderSummaryGroup.Controls.Add(btnviewordersummary);
            orderSummaryGroup.Controls.Add(labelfirstnameordersummary);
            orderSummaryGroup.Controls.Add(labelsecondnamesummary);
            orderSummaryGroup.Controls.Add(labelphonenumbersummary);
            orderSummaryGroup.Controls.Add(pnNumber);
            orderSummaryGroup.Controls.Add(labelemailsummary);
            orderSummaryGroup.Controls.Add(lastName);
            orderSummaryGroup.Controls.Add(firstName);
            orderSummaryGroup.Location = new Point(6, 33);
            orderSummaryGroup.Name = "orderSummaryGroup";
            orderSummaryGroup.Size = new Size(1358, 472);
            orderSummaryGroup.TabIndex = 13;
            orderSummaryGroup.TabStop = false;
            orderSummaryGroup.Text = "OrderSummary";
            orderSummaryGroup.UseWaitCursor = true;
            orderSummaryGroup.Visible = false;
            orderSummaryGroup.Enter += groupBox1_Enter;
            // 
            // btnviewordersummary
            // 
            btnviewordersummary.Location = new Point(1071, 266);
            btnviewordersummary.Name = "btnviewordersummary";
            btnviewordersummary.Size = new Size(200, 29);
            btnviewordersummary.TabIndex = 1;
            btnviewordersummary.Text = "View Order Summary";
            btnviewordersummary.UseVisualStyleBackColor = true;
            btnviewordersummary.UseWaitCursor = true;
            btnviewordersummary.Click += buttonviewordersummary_Click;
            // 
            // ordersPlaced
            // 
            ordersPlaced.Controls.Add(cstmessage);
            ordersPlaced.Controls.Add(CustomMessage);
            ordersPlaced.Controls.Add(orderListView);
            ordersPlaced.Controls.Add(btnPlaceOrder);
            ordersPlaced.Controls.Add(btnback);
            ordersPlaced.Location = new Point(12, 33);
            ordersPlaced.Name = "ordersPlaced";
            ordersPlaced.Size = new Size(1358, 472);
            ordersPlaced.TabIndex = 14;
            ordersPlaced.TabStop = false;
            ordersPlaced.Text = "Orders Placed";
            ordersPlaced.Visible = false;
            // 
            // cstmessage
            // 
            cstmessage.Location = new Point(150, 345);
            cstmessage.Name = "cstmessage";
            cstmessage.Size = new Size(500, 60);
            cstmessage.TabIndex = 15;
            cstmessage.Text = "";
            cstmessage.UseWaitCursor = true;
            // 
            // CustomMessage
            // 
            CustomMessage.AutoSize = true;
            CustomMessage.Location = new Point(20, 350);
            CustomMessage.Name = "CustomMessage";
            CustomMessage.Size = new Size(117, 20);
            CustomMessage.TabIndex = 14;
            CustomMessage.Text = "CustomMessage";
            CustomMessage.UseWaitCursor = true;
            // 
            // orderListView
            // 
            orderListView.FullRowSelect = true;
            orderListView.GridLines = true;
            orderListView.Location = new Point(20, 30);
            orderListView.Name = "orderListView";
            orderListView.Size = new Size(1000, 300);
            orderListView.TabIndex = 16;
            orderListView.UseCompatibleStateImageBehavior = false;
            orderListView.View = View.Details;
            // 
            // OrdersSummary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1738, 689);
            Controls.Add(orderSummaryGroup);
            Controls.Add(ordersPlaced);
            Name = "OrdersSummary";
            Text = "OrdersSummary";
            ((System.ComponentModel.ISupportInitialize)summaryGrid).EndInit();
            orderSummaryGroup.ResumeLayout(false);
            orderSummaryGroup.PerformLayout();
            ordersPlaced.ResumeLayout(false);
            ordersPlaced.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView summaryGrid;
        private Label labelfirstnameordersummary;
        private Label labelsecondnamesummary;
        private Label labelphonenumbersummary;
        private Label labelemailsummary;
        private TextBox firstName;
        private TextBox lastName;
        private TextBox pnNumber;
        private TextBox email;
        private Button btnback;
        private Button btnPlaceOrder;
        private GroupBox orderSummaryGroup;
        private GroupBox ordersPlaced;
        private Button btnviewordersummary;
        private ListView orderListView;
        private RichTextBox cstmessage;
        private Label CustomMessage;
    }
}