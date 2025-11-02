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

            while (true)
            {
                frmLogin loginForm = new frmLogin();
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    frmMain mainForm = new frmMain(loginForm.UserRole);
                    Application.Run(mainForm);

                    if (!mainForm.IsLogout)
                        break;  
                }
                else
                {
                    break; 
                }
            }
        }
    }
}
