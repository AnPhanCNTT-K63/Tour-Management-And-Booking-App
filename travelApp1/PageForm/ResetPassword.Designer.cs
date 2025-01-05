namespace travelApp1.PageForm
{
    partial class ResetPassword
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
            txbCode = new TextBox();
            label1 = new Label();
            txbPassword = new TextBox();
            label2 = new Label();
            txbConfirm = new TextBox();
            label3 = new Label();
            btnRestore = new Button();
            SuspendLayout();
            // 
            // txbCode
            // 
            txbCode.Location = new Point(307, 91);
            txbCode.Name = "txbCode";
            txbCode.Size = new Size(242, 27);
            txbCode.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(163, 94);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 3;
            label1.Text = "Verification Code";
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(307, 155);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(242, 27);
            txbPassword.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 158);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 5;
            label2.Text = "New Password";
            // 
            // txbConfirm
            // 
            txbConfirm.Location = new Point(307, 219);
            txbConfirm.Name = "txbConfirm";
            txbConfirm.Size = new Size(242, 27);
            txbConfirm.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(159, 222);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 7;
            label3.Text = "Confirm Password";
            // 
            // btnRestore
            // 
            btnRestore.Location = new Point(307, 299);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(143, 29);
            btnRestore.TabIndex = 8;
            btnRestore.Text = "Restore Password";
            btnRestore.UseVisualStyleBackColor = true;
            btnRestore.Click += btnRestore_Click;
            // 
            // PasswordRecovery
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRestore);
            Controls.Add(label3);
            Controls.Add(txbConfirm);
            Controls.Add(label2);
            Controls.Add(txbPassword);
            Controls.Add(label1);
            Controls.Add(txbCode);
            Name = "PasswordRecovery";
            Text = "PasswordRecovery";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbCode;
        private Label label1;
        private TextBox txbPassword;
        private Label label2;
        private TextBox txbConfirm;
        private Label label3;
        private Button btnRestore;
    }
}