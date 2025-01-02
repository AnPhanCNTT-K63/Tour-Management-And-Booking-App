namespace travelApp1.PageForm
{
    partial class Payment
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
            titleLabel = new Label();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            cardNumberLabel = new Label();
            cardNumberTextBox = new TextBox();
            expiryDateLabel = new Label();
            expiryDateTextBox = new TextBox();
            cvvLabel = new Label();
            cvvTextBox = new TextBox();
            noteLabel = new Label();
            noteTextBox = new TextBox();
            payButton = new Button();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Font = new Font("Arial", 16F, FontStyle.Bold);
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(367, 50);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Payment Information";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(30, 70);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(130, 20);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Cardholder Name:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(30, 100);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(300, 27);
            nameTextBox.TabIndex = 2;
            // 
            // cardNumberLabel
            // 
            cardNumberLabel.AutoSize = true;
            cardNumberLabel.Location = new Point(30, 140);
            cardNumberLabel.Name = "cardNumberLabel";
            cardNumberLabel.Size = new Size(101, 20);
            cardNumberLabel.TabIndex = 3;
            cardNumberLabel.Text = "Card Number:";
            // 
            // cardNumberTextBox
            // 
            cardNumberTextBox.Location = new Point(30, 170);
            cardNumberTextBox.Name = "cardNumberTextBox";
            cardNumberTextBox.Size = new Size(300, 27);
            cardNumberTextBox.TabIndex = 4;
            // 
            // expiryDateLabel
            // 
            expiryDateLabel.Location = new Point(0, 0);
            expiryDateLabel.Name = "expiryDateLabel";
            expiryDateLabel.Size = new Size(100, 23);
            expiryDateLabel.TabIndex = 5;
            // 
            // expiryDateTextBox
            // 
            expiryDateTextBox.Location = new Point(0, 0);
            expiryDateTextBox.Name = "expiryDateTextBox";
            expiryDateTextBox.Size = new Size(100, 27);
            expiryDateTextBox.TabIndex = 6;
            // 
            // cvvLabel
            // 
            cvvLabel.AutoSize = true;
            cvvLabel.Location = new Point(200, 210);
            cvvLabel.Name = "cvvLabel";
            cvvLabel.Size = new Size(39, 20);
            cvvLabel.TabIndex = 7;
            cvvLabel.Text = "CVV:";
            // 
            // cvvTextBox
            // 
            cvvTextBox.Location = new Point(200, 240);
            cvvTextBox.MaxLength = 3;
            cvvTextBox.Name = "cvvTextBox";
            cvvTextBox.Size = new Size(70, 27);
            cvvTextBox.TabIndex = 8;
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Location = new Point(30, 280);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new Size(39, 20);
            noteLabel.TabIndex = 9;
            noteLabel.Text = "note";
            // 
            // noteTextBox
            // 
            noteTextBox.Location = new Point(30, 310);
            noteTextBox.Multiline = true;
            noteTextBox.Name = "noteTextBox";
            noteTextBox.Size = new Size(300, 60);
            noteTextBox.TabIndex = 10;
            // 
            // payButton
            // 
            payButton.Location = new Point(150, 400);
            payButton.Name = "payButton";
            payButton.Size = new Size(100, 40);
            payButton.TabIndex = 11;
            payButton.Text = "Pay";
            payButton.Click += PayButton_Click;
            // 
            // Payment
            // 
            AutoSize = true;
            ClientSize = new Size(367, 487);
            Controls.Add(titleLabel);
            Controls.Add(nameLabel);
            Controls.Add(nameTextBox);
            Controls.Add(cardNumberLabel);
            Controls.Add(cardNumberTextBox);
            Controls.Add(expiryDateLabel);
            Controls.Add(expiryDateTextBox);
            Controls.Add(cvvLabel);
            Controls.Add(cvvTextBox);
            Controls.Add(noteLabel);
            Controls.Add(noteTextBox);
            Controls.Add(payButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Location = new Point(30, 240);
            Name = "Payment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Expiry Date (MM/YY):";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label titleLabel;
        private Label nameLabel;
        private TextBox nameTextBox;
        private Label cardNumberLabel;
        private TextBox cardNumberTextBox;
        private Label expiryDateLabel;
        private TextBox expiryDateTextBox;
        private Label cvvLabel;
        private TextBox cvvTextBox;
        private Label noteLabel;
        private TextBox noteTextBox;
        private Button payButton;
    }
}