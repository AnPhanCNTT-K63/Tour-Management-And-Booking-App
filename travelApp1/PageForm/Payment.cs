using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace travelApp1.PageForm
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }
        private void PayButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
