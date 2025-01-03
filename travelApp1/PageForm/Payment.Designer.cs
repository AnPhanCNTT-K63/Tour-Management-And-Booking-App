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
            expiryDateLabel = new Label();
            expiryDateTextBox = new TextBox();
            label1 = new Label();
            btnConfirm = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Font = new Font("Arial", 16F, FontStyle.Bold);
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(472, 50);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Payment";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 352);
            label1.Name = "label1";
            label1.Size = new Size(297, 20);
            label1.TabIndex = 7;
            label1.Text = "Please click here if you have completed pay";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(182, 387);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(94, 29);
            btnConfirm.TabIndex = 8;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(192, 80);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 9;
            label2.Text = "QR Code";
            // 
            // Payment
            // 
            AutoSize = true;
            ClientSize = new Size(472, 487);
            Controls.Add(label2);
            Controls.Add(btnConfirm);
            Controls.Add(label1);
            Controls.Add(titleLabel);
            Controls.Add(expiryDateLabel);
            Controls.Add(expiryDateTextBox);
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
        private Label expiryDateLabel;
        private TextBox expiryDateTextBox;
        private Label label1;
        private Button btnConfirm;
        private Label label2;
    }
}