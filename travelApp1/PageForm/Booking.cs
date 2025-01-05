using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using travelApp1.Helpers;
using travelApp1.Models;
using travelApp1.Services;
using static Google.Apis.Requests.BatchRequest;

namespace travelApp1.PageForm
{
    public partial class Booking : Form
    {
        private readonly ApiService _apiService;
        private readonly PackageDTO _package;
        private readonly TourDTO _tour;
        private readonly string _schedule;
        private readonly string _voucher;
        private decimal _discount;
        private decimal _totalPrice;
        private int _bookingId;

        public Booking(PackageDTO package, TourDTO tour, string schedule, string voucher)
        {
            InitializeComponent();
            _package = package;
            _tour = tour;
            _schedule = schedule;
            _voucher = voucher;
            _apiService = new ApiService();
            InitData();
        }

        void InitData()
        {

            foreach (var voucher in _package.Vouchers)
            {
                if (voucher.Code == _voucher)
                {
                    _discount = voucher.Discount;
                }
            }

            numGuests.Minimum = 1;

            txtTourName.Text = _tour.Name;
            txtPackageName.Text = _package.Name;
            txtPrice.Text = _package.Price.ToString() + "$";
            txtSchedule.Text = _schedule;
            txtDiscount.Text = "-" + _discount.ToString() + "%" + " (-" + ((_package.Price * _discount / 100).GetValueOrDefault().ToString("F2")) + "$" + ")";

            UpdateTotalPrice();

            numGuests.ValueChanged += NumGuests_ValueChanged;

        }

        private void NumGuests_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            _totalPrice = numGuests.Value * (_package.Price.GetValueOrDefault() - (_package.Price.GetValueOrDefault() * _discount / 100));
            txtTotalPrice.Text = _totalPrice.ToString("F2") + "$";
        }

        private async void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                var contact = new
                {
                    email = txtEmail.Text,
                    name = txtFullName.Text,
                    phone = txtPhone.Text
                };

                var booking = new BookingDTO
                {
                    bookingDate = DateTime.Parse(_schedule).ToString("yyyy-MM-ddTHH:mm:ss.fffZ"),
                    status = "pending",
                    numOfPeople = int.Parse(numGuests.Value.ToString()),
                    tourPackageId = _package.Id,
                };

                var data = new
                {
                    contact = contact,
                    booking = booking,
                };

                Debug.WriteLine(System.Text.Json.JsonSerializer.Serialize(data));
                var res = await _apiService.PostAsync("booking/create", data);


                if (res.IsSuccessStatusCode)
                {
                    _bookingId = JsonConvert.DeserializeObject<int>(await res.Content.ReadAsStringAsync());
                    MessageBox.Show("Success", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    form.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(await res.Content.ReadAsStringAsync(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetSelectedPaymentMethod()
        {
            if (rbtnCreditCard.Checked) return "Credit Card";
            if (rbtnEwallet.Checked) return "E-wallet";
            if (rbtnBankTransfer.Checked) return "Bank Transfer";

            return null;
        }
    }
}
