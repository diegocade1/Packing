using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Packing
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        enum Pantallas { pantalla1, pantalla2, pantalla3 };

        Pantallas ListaPantallas;

        private void Principal_Load(object sender, EventArgs e)
        {
            ListaPantallas = Pantallas.pantalla1;
            AbrirFormHija(new Recepcion());
           
        }

       
               


                

        private void AbrirFormHija(object formHija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formHija as Form;
            fh.TopLevel = false; //le decimos que sera un formulario de nivel secundado no se primer nivel
            fh.Dock = DockStyle.Fill; //se acopla a todo el panel
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            switch (ListaPantallas)
            {
                case Pantallas.pantalla3:
                    ListaPantallas = Pantallas.pantalla2;
                    Recepcion2 frmObj = new Recepcion2();
                        
                    AbrirFormHija( new Recepcion2());
                    btnAceptar.Enabled = true;
                    break;
                case Pantallas.pantalla2:
                    ListaPantallas = Pantallas.pantalla1;
                    AbrirFormHija(new Recepcion());                   
                    btnCancelar.Text = "Cancelar";
                    break;
                case Pantallas.pantalla1:
                    this.Dispose();
                    break;
                    //  default:
                    //     Console.WriteLine("Default case");
                    //    break;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (ListaPantallas)
            {
                case Pantallas.pantalla1 :
                    ListaPantallas = Pantallas.pantalla2;
                    AbrirFormHija(new Recepcion2());
                    btnCancelar.Enabled = true;
                    btnCancelar.Text = "Atrás";
                    break;
                case Pantallas.pantalla2 :
                    ListaPantallas = Pantallas.pantalla3;
                    AbrirFormHija(new Recepcion4());
                    btnAceptar.Enabled = false;
                    break;
              //  default:
               //     Console.WriteLine("Default case");
                //    break;
            }
        }
    }
}
