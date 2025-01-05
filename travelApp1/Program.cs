using System;
using System.Windows.Forms;
using travelApp1.PageForm;
using travelApp1.Services;
using DotNetEnv;
using Newtonsoft.Json;
using travelApp1.Models;
using System.Diagnostics;

namespace travelApp1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            InitUser();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new BookingManageForm());

        }

        public static void InitUser()
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.AccessToken))
            {
                var claims = JwtHelper.DecodeJwt(Properties.Settings.Default.AccessToken);

                if (claims != null)
                {
                    var claimsJson = JsonConvert.SerializeObject(claims, Formatting.Indented);
                    UserDTO.Username = claims["unique_name"].ToString();
                    UserDTO.Email = claims["email"].ToString();
                    UserDTO.Role = claims["role"].ToString();
                    UserDTO.Id = claims["nameid"].ToString();
                }
            }
        }
    }
}