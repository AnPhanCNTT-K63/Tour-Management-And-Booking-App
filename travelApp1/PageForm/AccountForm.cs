using System;
using System.Windows.Forms;

namespace travelApp1
{
    public partial class AccountForm : Form
    {
        public AccountForm()
        {

            this.Text = "Account";
            this.Size = new System.Drawing.Size(500, 400);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label lblAccount = new Label();
            lblAccount.Text = "Account Management";
            lblAccount.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold);
            lblAccount.AutoSize = true;
            lblAccount.Location = new System.Drawing.Point(150, 50);
            this.Controls.Add(lblAccount);
        }
    }
}
