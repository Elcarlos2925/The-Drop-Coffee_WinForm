using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheDropCoffee.Formas;

namespace TheDropCoffee
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
            //Application.Run(new Menú());
            //Application.Run(new Login_Empleados());
            //Application.Run(new RegistroEmpleados());
            Application.Run(new Menú_Principal());
        }
    }
}