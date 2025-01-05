using System;
using System.Windows.Forms;
using travelApp1.PageForm;
using travelApp1.Services;
using DotNetEnv;
using Newtonsoft.Json;
using System.Diagnostics;
using travelApp1.Helpers;

namespace travelApp1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Init();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new SignUp());

        }

        public static void Init()
        {
            Properties.Settings.Default.CloudUri = "https://d1kr2sry6d4ekb.cloudfront.net/";
            CloudHelper.CloudUri = Properties.Settings.Default.CloudUri;

            if (!string.IsNullOrEmpty(Properties.Settings.Default.AccessToken))
            {
                var claims = JwtHelper.DecodeJwt(Properties.Settings.Default.AccessToken);

                if (claims != null)
                {
                    var claimsJson = JsonConvert.SerializeObject(claims, Formatting.Indented);
                    UserIndentity.Username = claims["unique_name"].ToString();
                    UserIndentity.Email = claims["email"].ToString();
                    UserIndentity.Role = claims["role"].ToString();
                    UserIndentity.Id = claims["nameid"].ToString();
                }
            }
        }
    }
}