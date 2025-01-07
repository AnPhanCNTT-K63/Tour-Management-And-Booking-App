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
    public partial class Payment : Form
    {
        private readonly ApiService _apiService;
        private readonly BookingDTO _booking;
        private readonly float _totalPrice;
        private readonly int _bookingId;
        private readonly string _paymentMethod;
        public Payment(BookingDTO booking, float totalPrice, int bookingId, string paymentMethod)
        {
            InitializeComponent();
            _booking = booking;
            _apiService = new ApiService();
            _totalPrice = totalPrice;
            _bookingId = bookingId;
            _paymentMethod = paymentMethod;


        }

        private async void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                var data = new
                {
                    paymentDate = DateTime.Parse(_booking.bookingDate).ToString("yyyy-MM-ddTHH:mm:ss.fffZ"),
                    paymentMethod = _paymentMethod,
                    paymentAmount = _totalPrice,
                    bookingId = _bookingId
                };

                var res = await _apiService.PostAsync("payment/create", data);

                if (res.IsSuccessStatusCode)
                {
                    MessageBox.Show("Payment successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
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
