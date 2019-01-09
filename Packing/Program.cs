using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Packing
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
            // Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new Comercial());
            frmLogin frmobj = new frmLogin();
            Application.Run(frmobj);
            if (frmobj.Login == true)
            {
                MDIContenedorPrincipal frmMdi = new MDIContenedorPrincipal();
                frmMdi.Usuario = frmobj.Usuario;
                Application.Run(frmMdi);
            }

        }
    }
}
