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
    public partial class frmVentanaModificar : Form
    {
        E_Usuario sesion { set; get; }
        N_Recepcion recepcion1 { set; get; }
        public frmVentanaModificar(E_Usuario usuario, N_Recepcion recepcion)
        {
            InitializeComponent();
            sesion = usuario;
            recepcion1 = recepcion;
        }

        private void frmVentaModificar_Load(object sender, EventArgs e)
        {

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            recepcion1.Encabezado.Cantidad_Pallets = txtCantidad.Text;
            if (recepcion1.ModificarCantidadPallets_Encabezado())
            {
                MessageBox.Show("Cantidad de pallets modificada.","Modificacion");
                Close();
            }
            else
            {
                MessageBox.Show(recepcion1.Mensaje, "Modificacion");
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
