using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Packing
{
    public partial class frmSubLote : Form
    {
        E_Recepcionado_sublote recepcionDetalleSublote = new E_Recepcionado_sublote();
        N_SubLote recepcionSublote = new N_SubLote();
        private E_Usuario sesion { set; get; }

        public frmSubLote(E_Usuario usuario)
        {
            InitializeComponent();
            sesion = usuario;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            LimpiarCampos();
            txtFolio.Focus();

        }

        void LimpiarCampos()
        {
            txtFolio.Text = "";
            txtFolioNuevo.Text = "";
            txtKilos.Text = "";

            lblDescarga.Text = "";
            lblDestino.Text = "";
            lblEspecie.Text = "";
            lblExportador.Text = "";
            lblGuia.Text = "";
            lblProductor.Text = "";
                        
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmSubLote_Load(object sender, EventArgs e)
        {

        }

        private void txtFolio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFolio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtFolio.Text.Trim() == "")
                {
                   MessageBox.Show ("Ingrese Folio","Folio");
                    return;
                }

               // N_Recepcion recepcion1 = new N_Recepcion();
              
              
                
                recepcionDetalleSublote.Folio = txtFolio.Text;
                if (recepcionSublote.Existe_Pallet_recepcion(recepcionDetalleSublote) == true) //pallet se utiliza para asignarle datos
                {
                    if (recepcionDetalleSublote.Estado == "0")
                    {
                        MessageBox .Show ( "Pallet no ha sido asignado","Folio");
                        return;
                    }

                    lblExportador.Text = recepcionDetalleSublote.Cliente;
                    lblProductor.Text = recepcionDetalleSublote.Productor;
                    lblEspecie.Text = recepcionDetalleSublote.Especie;
                    lblDestino.Text = recepcionDetalleSublote.Destino;
                    lblDescarga.Text = recepcionDetalleSublote.Descarga;
                    lblGuia.Text = recepcionDetalleSublote.Guia;
                    txtKilos.Focus();
                    
                }
                else
                {
                    MessageBox.Show ("Pallet no Existe");                    
                }

            }
        }

        private void txtKilos_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '.')
            {
                if (e.KeyChar == '.' && txtKilos.Text.Contains("."))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
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
    }
}
