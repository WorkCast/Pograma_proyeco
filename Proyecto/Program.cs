using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
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
            Application.Run(new FormRegistro());
            //Application.Run(new FormBackOfficeUsr());
            //Application.Run(new FormIntereses());
            //Application.Run(new Login());
            //Application.Run(new Form1());

            //Application.Run(new Form2());
            //Application.Run(new FormBackoffice());
        }
    }
}
