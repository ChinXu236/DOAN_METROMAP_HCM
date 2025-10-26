using System;
using System.Windows.Forms;

namespace MetroMap_HCM
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmLogin login = new frmLogin();
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmMain(login.UserRole));
            }
        }
    }
}
