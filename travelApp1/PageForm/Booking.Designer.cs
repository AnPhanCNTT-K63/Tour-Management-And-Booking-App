namespace travelApp1.PageForm
{
    partial class Booking
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
            lblTitle = new Label();
            lblCustomerInfo = new Label();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblTourInfo = new Label();
            lblTourName = new Label();
            txtTourName = new TextBox();
            lblGuests = new Label();
            numGuests = new NumericUpDown();
            lblTotalPrice = new Label();
            txtTotalPrice = new TextBox();
            lblPaymentInfo = new Label();
            rbtnCreditCard = new RadioButton();
            rbtnEwallet = new RadioButton();
            rbtnBankTransfer = new RadioButton();
            btnPay = new Button();
            btnCancel = new Button();
            label1 = new Label();
            txtPackageName = new TextBox();
            txtSchedule = new TextBox();
            label2 = new Label();
            txtPrice = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtDiscount = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numGuests).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(143, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(220, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Booking Info";
            // 
            // lblCustomerInfo
            // 
            lblCustomerInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCustomerInfo.Location = new Point(12, 59);
            lblCustomerInfo.Name = "lblCustomerInfo";
            lblCustomerInfo.Size = new Size(150, 23);
            lblCustomerInfo.TabIndex = 1;
            lblCustomerInfo.Text = "Contact Info";
            // 
            // lblFullName
            // 
            lblFullName.Location = new Point(20, 100);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(100, 23);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "Full Name:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(150, 100);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(300, 27);
            txtFullName.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(20, 140);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 23);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(150, 140);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 27);
            txtEmail.TabIndex = 5;
            // 
            // lblPhone
            // 
            lblPhone.Location = new Point(20, 180);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(100, 23);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Phone:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(150, 180);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(300, 27);
            txtPhone.TabIndex = 7;
            // 
            // lblTourInfo
            // 
            lblTourInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTourInfo.Location = new Point(20, 220);
            lblTourInfo.Name = "lblTourInfo";
            lblTourInfo.Size = new Size(150, 23);
            lblTourInfo.TabIndex = 8;
            lblTourInfo.Text = "Tour Info";
            // 
            // lblTourName
            // 
            lblTourName.Location = new Point(20, 260);
            lblTourName.Name = "lblTourName";
            lblTourName.Size = new Size(100, 23);
            lblTourName.TabIndex = 9;
            lblTourName.Text = "Tour Name:";
            // 
            // txtTourName
            // 
            txtTourName.Cursor = Cursors.No;
            txtTourName.Enabled = false;
            txtTourName.Location = new Point(150, 260);
            txtTourName.Name = "txtTourName";
            txtTourName.ReadOnly = true;
            txtTourName.Size = new Size(300, 27);
            txtTourName.TabIndex = 10;
            // 
            // lblGuests
            // 
            lblGuests.Location = new Point(20, 511);
            lblGuests.Name = "lblGuests";
            lblGuests.Size = new Size(137, 23);
            lblGuests.TabIndex = 11;
            lblGuests.Text = "Num Of Guests";
            // 
            // numGuests
            // 
            numGuests.Location = new Point(163, 509);
            numGuests.Name = "numGuests";
            numGuests.Size = new Size(100, 27);
            numGuests.TabIndex = 12;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.Location = new Point(20, 550);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(100, 23);
            lblTotalPrice.TabIndex = 13;
            lblTotalPrice.Text = "Total Price:";
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Cursor = Cursors.No;
            txtTotalPrice.Location = new Point(150, 547);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Size = new Size(300, 27);
            txtTotalPrice.TabIndex = 14;
            // 
            // lblPaymentInfo
            // 
            lblPaymentInfo.Location = new Point(12, 609);
            lblPaymentInfo.Name = "lblPaymentInfo";
            lblPaymentInfo.Size = new Size(150, 23);
            lblPaymentInfo.TabIndex = 15;
            lblPaymentInfo.Text = "Payment Info";
            // 
            // rbtnCreditCard
            // 
            rbtnCreditCard.Location = new Point(279, 607);
            rbtnCreditCard.Name = "rbtnCreditCard";
            rbtnCreditCard.Size = new Size(100, 24);
            rbtnCreditCard.TabIndex = 16;
            rbtnCreditCard.Text = "Credit Card";
            // 
            // rbtnEwallet
            // 
            rbtnEwallet.Location = new Point(168, 607);
            rbtnEwallet.Name = "rbtnEwallet";
            rbtnEwallet.Size = new Size(100, 24);
            rbtnEwallet.TabIndex = 17;
            rbtnEwallet.Text = "E-Wallet";
            // 
            // rbtnBankTransfer
            // 
            rbtnBankTransfer.Location = new Point(385, 608);
            rbtnBankTransfer.Name = "rbtnBankTransfer";
            rbtnBankTransfer.Size = new Size(120, 24);
            rbtnBankTransfer.TabIndex = 18;
            rbtnBankTransfer.Text = "Bank Transfer";
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.LightGreen;
            btnPay.Location = new Point(57, 694);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(100, 35);
            btnPay.TabIndex = 25;
            btnPay.Text = "Pay";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.LightCoral;
            btnCancel.Location = new Point(279, 694);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 35);
            btnCancel.TabIndex = 26;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Location = new Point(20, 310);
            label1.Name = "label1";
            label1.Size = new Size(124, 23);
            label1.TabIndex = 27;
            label1.Text = "Package Name:";
            // 
            // txtPackageName
            // 
            txtPackageName.Cursor = Cursors.No;
            txtPackageName.Enabled = false;
            txtPackageName.Location = new Point(150, 310);
            txtPackageName.Name = "txtPackageName";
            txtPackageName.ReadOnly = true;
            txtPackageName.Size = new Size(300, 27);
            txtPackageName.TabIndex = 28;
            // 
            // txtSchedule
            // 
            txtSchedule.Cursor = Cursors.No;
            txtSchedule.Enabled = false;
            txtSchedule.Location = new Point(150, 363);
            txtSchedule.Name = "txtSchedule";
            txtSchedule.ReadOnly = true;
            txtSchedule.Size = new Size(300, 27);
            txtSchedule.TabIndex = 29;
            // 
            // label2
            // 
            label2.Location = new Point(20, 366);
            label2.Name = "label2";
            label2.Size = new Size(124, 23);
            label2.TabIndex = 30;
            label2.Text = "Schedule:";
            // 
            // txtPrice
            // 
            txtPrice.Cursor = Cursors.No;
            txtPrice.Enabled = false;
            txtPrice.Location = new Point(150, 410);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(300, 27);
            txtPrice.TabIndex = 31;
            // 
            // label3
            // 
            label3.Location = new Point(20, 457);
            label3.Name = "label3";
            label3.Size = new Size(124, 23);
            label3.TabIndex = 32;
            label3.Text = "Voucher";
            // 
            // label4
            // 
            label4.Location = new Point(20, 414);
            label4.Name = "label4";
            label4.Size = new Size(124, 23);
            label4.TabIndex = 33;
            label4.Text = "Price";
            // 
            // txtDiscount
            // 
            txtDiscount.Cursor = Cursors.No;
            txtDiscount.Enabled = false;
            txtDiscount.Location = new Point(150, 454);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.ReadOnly = true;
            txtDiscount.Size = new Size(300, 27);
            txtDiscount.TabIndex = 34;
            // 
            // Booking
            // 
            ClientSize = new Size(507, 790);
            Controls.Add(txtDiscount);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPrice);
            Controls.Add(label2);
            Controls.Add(txtSchedule);
            Controls.Add(txtPackageName);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(lblCustomerInfo);
            Controls.Add(lblFullName);
            Controls.Add(txtFullName);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblPhone);
            Controls.Add(txtPhone);
            Controls.Add(lblTourInfo);
            Controls.Add(lblTourName);
            Controls.Add(txtTourName);
            Controls.Add(lblGuests);
            Controls.Add(numGuests);
            Controls.Add(lblTotalPrice);
            Controls.Add(txtTotalPrice);
            Controls.Add(lblPaymentInfo);
            Controls.Add(rbtnCreditCard);
            Controls.Add(rbtnEwallet);
            Controls.Add(rbtnBankTransfer);
            Controls.Add(btnPay);
            Controls.Add(btnCancel);
            Name = "Booking";
            Text = "Billing Information";
            ((System.ComponentModel.ISupportInitialize)numGuests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblCustomerInfo;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblTourInfo;
        private Label lblTourName;
        private TextBox txtTourName;
        private Label lblGuests;
        private NumericUpDown numGuests;
        private Label lblTotalPrice;
        private TextBox txtTotalPrice;
        private Label lblPaymentInfo;
        private RadioButton rbtnCreditCard;
        private RadioButton rbtnEwallet;
        private RadioButton rbtnBankTransfer;
        private Button btnPay;
        private Button btnCancel;
        private Label label1;
        private TextBox txtPackageName;
        private TextBox txtSchedule;
        private Label label2;
        private TextBox txtPrice;
        private Label label3;
        private Label label4;
        private TextBox txtDiscount;
    }
}