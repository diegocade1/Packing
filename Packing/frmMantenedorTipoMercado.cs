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
    public partial class frmMantenedorTipoMercado : frmMantenedorAMB
    {
        private E_Usuario sesion { set; get; }
        public frmMantenedorTipoMercado(E_Usuario usuario)
        {
            InitializeComponent();
            sesion = usuario;
        }

        private void frmMantenedorTipoMercado_Load(object sender, EventArgs e)
        {
            N_TipoMercado mercado1 = new N_TipoMercado();
            dgvLista.DataSource = mercado1.Lista();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Ingrese Descripcion del Tipo de mercado", "Agregar");
                return;
            }

            switch (lblTipoAccion.Text)
            {
                case "Agregar":
                    AgregarMercado();
                    break;
                case "Modificar":
                    ModificarMercado();
                    break;
                    //  default:
                    //     Console.WriteLine("Default case");
                    //    break;
            }
            panelCampos.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelCampos.Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnImportar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        #region Metodos virtuales
        public override void Agregar()
        {
            panelCampos.Top = 0;
            panelCampos.Left = 0;
            panelCampos.Visible = true;
            lblTipoAccion.Text = "Agregar";
            btnAceptar.Text = lblTipoAccion.Text;

        }

        void AgregarMercado()
        {
            N_TipoMercado mercado1 = new N_TipoMercado();
            E_TipoMercado mercado2 = new E_TipoMercado();
            mercado2.Codigo = "0";
            mercado2.Descripcion = txtDescripcion.Text;
            if (mercado1.Agregar(mercado2) == true)
            {
                dgvLista.DataSource = mercado1.Lista();
            }
            else
            {
                MessageBox.Show("Error: No se pudo agregar el registro", "Agregar");
            }
        }

        public override void Modificar()
        {

            if (dgvLista.SelectedRows.Count != 0)
            {
                panelCampos.Top = 0;
                panelCampos.Left = 0;
                panelCampos.Visible = true;
                lblTipoAccion.Text = "Modificar";
                btnAceptar.Text = lblTipoAccion.Text;

                int pos = dgvLista.CurrentRow.Index;

                txtDescripcion.Text = dgvLista.Rows[pos].Cells["descripcion"].Value.ToString();
                lblIDTipoMercado.Text = dgvLista.Rows[pos].Cells["codigo"].Value.ToString();

            }
            else
            {
                MessageBox.Show("Seleccione Item", "Modificar");
            }


        }

        void ModificarMercado()
        {
            N_TipoMercado mercado1 = new N_TipoMercado();
            E_TipoMercado mercado2 = new E_TipoMercado();

            mercado2.Codigo = lblIDTipoMercado.Text;
            mercado2.Descripcion = txtDescripcion.Text;
            if (mercado1.Modificar(mercado2) == true)
            {
                dgvLista.DataSource = mercado1.Lista();
            }
            else
            {
                MessageBox.Show("Error: No se pudo modificar el registro", "Modificar");
            }
        }





        public override void Borrar()
        {
            if (dgvLista.SelectedRows.Count != 0)
            {

                int pos = dgvLista.CurrentRow.Index;
                string ID;
                ID = dgvLista.Rows[pos].Cells["codigo"].Value.ToString();
                if (MessageBox.Show("¿Borrar Registro Seleccionado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }

                N_TipoMercado mercado1 = new N_TipoMercado();
                if (mercado1.Borrar(ID) == true)
                {
                    dgvLista.DataSource = mercado1.Lista();
                }

            }
            else
            {
                MessageBox.Show("Seleccione Item", "Borrar");
            }

        }

        #endregion
    }
}
