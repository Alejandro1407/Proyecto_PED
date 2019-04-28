using System;
using System.Windows.Forms;
using AdministradorOrtopediaVelásquez;

namespace AdministradorOrtopediaVelásquez
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm lf = new LoginForm();
            lf.Show();
            Application.Run();
        }
    }
}
