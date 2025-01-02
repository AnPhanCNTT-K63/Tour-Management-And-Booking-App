namespace travelApp1.PageForm
{
    partial class Billing
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
            lblCardNumber = new Label();
            txtCardNumber = new TextBox();
            lblCardName = new Label();
            txtCardName = new TextBox();
            lblCVV = new Label();
            txtCVV = new TextBox();
            btnPay = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numGuests).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(126, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(220, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Billing Information";
            // 
            // lblCustomerInfo
            // 
            lblCustomerInfo.Location = new Point(20, 60);
            lblCustomerInfo.Name = "lblCustomerInfo";
            lblCustomerInfo.Size = new Size(150, 23);
            lblCustomerInfo.TabIndex = 1;
            lblCustomerInfo.Text = "Customer Info";
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
            txtTourName.Location = new Point(150, 260);
            txtTourName.Name = "txtTourName";
            txtTourName.Size = new Size(300, 27);
            txtTourName.TabIndex = 10;
            // 
            // lblGuests
            // 
            lblGuests.Location = new Point(20, 300);
            lblGuests.Name = "lblGuests";
            lblGuests.Size = new Size(100, 23);
            lblGuests.TabIndex = 11;
            lblGuests.Text = "No. of Guests:";
            // 
            // numGuests
            // 
            numGuests.Location = new Point(150, 300);
            numGuests.Name = "numGuests";
            numGuests.Size = new Size(100, 27);
            numGuests.TabIndex = 12;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.Location = new Point(20, 340);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(100, 23);
            lblTotalPrice.TabIndex = 13;
            lblTotalPrice.Text = "Total Price:";
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(150, 340);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Size = new Size(300, 27);
            txtTotalPrice.TabIndex = 14;
            // 
            // lblPaymentInfo
            // 
            lblPaymentInfo.Location = new Point(20, 380);
            lblPaymentInfo.Name = "lblPaymentInfo";
            lblPaymentInfo.Size = new Size(150, 23);
            lblPaymentInfo.TabIndex = 15;
            lblPaymentInfo.Text = "Payment Info";
            // 
            // rbtnCreditCard
            // 
            rbtnCreditCard.Location = new Point(150, 420);
            rbtnCreditCard.Name = "rbtnCreditCard";
            rbtnCreditCard.Size = new Size(100, 24);
            rbtnCreditCard.TabIndex = 16;
            rbtnCreditCard.Text = "Credit Card";
            // 
            // rbtnEwallet
            // 
            rbtnEwallet.Location = new Point(150, 450);
            rbtnEwallet.Name = "rbtnEwallet";
            rbtnEwallet.Size = new Size(100, 24);
            rbtnEwallet.TabIndex = 17;
            rbtnEwallet.Text = "E-Wallet";
            // 
            // rbtnBankTransfer
            // 
            rbtnBankTransfer.Location = new Point(150, 480);
            rbtnBankTransfer.Name = "rbtnBankTransfer";
            rbtnBankTransfer.Size = new Size(120, 24);
            rbtnBankTransfer.TabIndex = 18;
            rbtnBankTransfer.Text = "Bank Transfer";
            // 
            // lblCardNumber
            // 
            lblCardNumber.Location = new Point(20, 520);
            lblCardNumber.Name = "lblCardNumber";
            lblCardNumber.Size = new Size(120, 23);
            lblCardNumber.TabIndex = 19;
            lblCardNumber.Text = "Card/Account No.:";
            // 
            // txtCardNumber
            // 
            txtCardNumber.Location = new Point(150, 520);
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.Size = new Size(300, 27);
            txtCardNumber.TabIndex = 20;
            // 
            // lblCardName
            // 
            lblCardName.Location = new Point(20, 560);
            lblCardName.Name = "lblCardName";
            lblCardName.Size = new Size(100, 23);
            lblCardName.TabIndex = 21;
            lblCardName.Text = "Card Holder:";
            // 
            // txtCardName
            // 
            txtCardName.Location = new Point(150, 560);
            txtCardName.Name = "txtCardName";
            txtCardName.Size = new Size(300, 27);
            txtCardName.TabIndex = 22;
            // 
            // lblCVV
            // 
            lblCVV.Location = new Point(20, 600);
            lblCVV.Name = "lblCVV";
            lblCVV.Size = new Size(120, 23);
            lblCVV.TabIndex = 23;
            lblCVV.Text = "CVV (if applicable):";
            // 
            // txtCVV
            // 
            txtCVV.Location = new Point(150, 600);
            txtCVV.Name = "txtCVV";
            txtCVV.Size = new Size(100, 27);
            txtCVV.TabIndex = 24;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.LightGreen;
            btnPay.Location = new Point(150, 640);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(100, 35);
            btnPay.TabIndex = 25;
            btnPay.Text = "Pay";
            btnPay.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.LightCoral;
            btnCancel.Location = new Point(270, 640);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 35);
            btnCancel.TabIndex = 26;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // Billing
            // 
            ClientSize = new Size(482, 678);
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
            Controls.Add(lblCardNumber);
            Controls.Add(txtCardNumber);
            Controls.Add(lblCardName);
            Controls.Add(txtCardName);
            Controls.Add(lblCVV);
            Controls.Add(txtCVV);
            Controls.Add(btnPay);
            Controls.Add(btnCancel);
            Name = "Billing";
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
        private Label lblCardNumber;
        private TextBox txtCardNumber;
        private Label lblCardName;
        private TextBox txtCardName;
        private Label lblCVV;
        private TextBox txtCVV;
        private Button btnPay;
        private Button btnCancel;
    }
}