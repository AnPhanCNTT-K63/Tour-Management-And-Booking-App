namespace travelApp1.PageForm
{
    partial class PaymentManage
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            BID = new DataGridViewTextBoxColumn();
            TPackage = new DataGridViewTextBoxColumn();
            TPName = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Payment = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(570, 40);
            label1.Name = "label1";
            label1.Size = new Size(283, 51);
            label1.TabIndex = 0;
            label1.Text = "Manage User Payment Requests";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Name, Date, BID, TPackage, TPName, Price, Payment, Status });
            dataGridView1.Location = new Point(2, 126);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1385, 360);
            dataGridView1.TabIndex = 1;
            // 
            // ID
            // 
            ID.HeaderText = "UserId";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.Width = 150;
            // 
            // Name
            // 
            Name.HeaderText = "UserName";
            Name.MinimumWidth = 8;
            Name.Name = "Name";
            Name.Width = 150;
            // 
            // Date
            // 
            Date.HeaderText = "Booking Date";
            Date.MinimumWidth = 8;
            Date.Name = "Date";
            Date.Width = 150;
            // 
            // BID
            // 
            BID.HeaderText = "BookingID";
            BID.MinimumWidth = 8;
            BID.Name = "BID";
            BID.Width = 150;
            // 
            // TPackage
            // 
            TPackage.HeaderText = "Tour Package ID";
            TPackage.MinimumWidth = 8;
            TPackage.Name = "TPackage";
            TPackage.Width = 150;
            // 
            // TPName
            // 
            TPName.HeaderText = "TourPackage Name";
            TPName.MinimumWidth = 8;
            TPName.Name = "TPName";
            TPName.Width = 150;
            // 
            // Price
            // 
            Price.HeaderText = "Total Price";
            Price.MinimumWidth = 8;
            Price.Name = "Price";
            Price.Width = 150;
            // 
            // Payment
            // 
            Payment.HeaderText = "Payment Menthod";
            Payment.MinimumWidth = 8;
            Payment.Name = "Payment";
            Payment.Width = 150;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.Width = 150;
            // 
            // PaymentManage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1385, 654);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "PaymentManage";
            Text = "PaymentManage";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn BID;
        private DataGridViewTextBoxColumn TPackage;
        private DataGridViewTextBoxColumn TPName;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Payment;
        private DataGridViewTextBoxColumn Status;
    }
}