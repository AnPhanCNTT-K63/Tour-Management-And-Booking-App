namespace travelApp1.PageForm
{
    partial class EditAccountForm
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
            txtCurrentValue = new TextBox();
            txtNewValue = new TextBox();
            lblTitle = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPassword = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtCurrentValue
            // 
            txtCurrentValue.Enabled = false;
            txtCurrentValue.Location = new Point(340, 69);
            txtCurrentValue.Name = "txtCurrentValue";
            txtCurrentValue.Size = new Size(236, 27);
            txtCurrentValue.TabIndex = 0;
            // 
            // txtNewValue
            // 
            txtNewValue.Location = new Point(340, 117);
            txtNewValue.Name = "txtNewValue";
            txtNewValue.Size = new Size(236, 27);
            txtNewValue.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(189, 69);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(60, 20);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Current:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(221, 120);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 3;
            label2.Text = "New:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(168, 162);
            label3.Name = "label3";
            label3.Size = new Size(126, 20);
            label3.TabIndex = 4;
            label3.Text = "Mật khẩu hiện tại:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(340, 162);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(236, 27);
            txtPassword.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(355, 246);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // EditAccountForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblTitle);
            Controls.Add(txtNewValue);
            Controls.Add(txtCurrentValue);
            Name = "EditAccountForm";
            Text = "EditAccountForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCurrentValue;
        private TextBox txtNewValue;
        private Label lblTitle;
        private Label label2;
        private Label label3;
        private TextBox txtPassword;
        private Button btnSave;
    }
}