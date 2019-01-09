using Entity;
using Negocio;
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
    public partial class frmLogin : Form
    {

        public E_Usuario Usuario { get; set; }
        public bool Login { get; set; }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Login = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            N_Usuario usuario1 = new N_Usuario();
            Usuario = usuario1.ObtenerUsuario(txtUsuario.Text);

            if (Usuario!=null)
            {
                if(Usuario.Contrasenia != txtPassword.Text)
                {
                    MessageBox.Show("Contraseña invalida", "Usuario");
                    Login = false;
                }
                else
                {
                    Login = true;
                    this.Close();
                    // MessageBox.Show("LOGIN");
                }
            }
            else
            {
                MessageBox.Show("Usuario invalido", "Usuario");
                Login = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
