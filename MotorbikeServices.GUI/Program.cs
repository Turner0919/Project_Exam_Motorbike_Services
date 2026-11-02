using MotorbikeServices.GUI.SETUP;

namespace MotorbikeServices.GUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /*[STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmlogin());
        }*/
        static void Main()
        {
            // Giữ nguyên dòng khởi tạo cấu hình giao diện của .NET
            ApplicationConfiguration.Initialize();

            // 1. Tạo luồng riêng (Thread) để mở FormLogin thứ 2
            System.Threading.Thread secondLoginThread = new System.Threading.Thread(() =>
            {
                Application.Run(new frmlogin());
            });

            secondLoginThread.SetApartmentState(System.Threading.ApartmentState.STA);
            secondLoginThread.Start(); // Bật luồng phụ

            // 2. Mở FormLogin thứ 1 trên luồng chính
            Application.Run(new frmlogin());
        }
    }
}