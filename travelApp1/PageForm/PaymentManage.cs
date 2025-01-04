using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using travelApp1.Models;
using travelApp1.Services;

namespace travelApp1.PageForm
{
    public partial class PaymentManage : Form
    {
        private readonly ApiService _service;
        public PaymentManage()
        {
            InitializeComponent();
            _service = new ApiService();
        }

        public async void InitData()
        {
            try
            {
                var res = await _service.GetAsync("/payment/request");

                if (res.IsSuccessStatusCode)
                {
                    var data = await res.Content.ReadAsStringAsync();
                    var payments = JsonConvert.DeserializeObject<List<PaymentDTO>>(data);

                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = payments;
                }
                else
                {
                    MessageBox.Show(await res.Content.ReadAsStringAsync(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
