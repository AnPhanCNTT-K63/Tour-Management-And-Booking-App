using System;
using System.Windows.Forms;
using travelApp1.PageForm;
using travelApp1.Services;
using DotNetEnv;

namespace travelApp1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new ForgotPassword());

        }
    }
}