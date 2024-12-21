using System;
using System.Windows.Forms;

namespace travelApp1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Khởi tạo và hiển thị trang Home
            Application.Run(new TourManagerForm());

        }
    }
}