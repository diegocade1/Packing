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

                N_Recepcion recepcion1 = new N_Recepcion();
                E_Pallet pallet1 = new E_Pallet();

                pallet1.Codigo = txtFolio.Text;
                if (recepcion1.Existe_Pallet(pallet1.Codigo,pallet1) == true) //pallet se utiliza para asignarle datos
                {
                    if (pallet1.Estado != "0")
                    {
                        MessageBox .Show ( "Pallet fue asignado no puede Modificar","Folio");
                        return;
                    }

                    //lblExportador.Text = pallet1.ID_Cliente;
                    //lblProductor.Text = pallet1.ID_Productor;
                    //lblEspecie.Text = pallet1.Descripcion;
                    //lblDescarga.Text = pallet1.id

                   // lblDescarga.Text = pallet1.desca;
                   
                  

                }
                else
                {
                    MessageBox.Show ("Pallet no Existe");                    
                }

            }
        }
    }
}
