using System;
using System.Windows.Forms;
using travelApp1.PageForm;

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
            Application.Run(new HomeForm());

        }
    }
}