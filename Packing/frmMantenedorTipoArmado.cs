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
    public partial class frmMantenedorTipoArmado : frmMantenedorAMB
    {
        private E_Usuario sesion { set; get; }
        public frmMantenedorTipoArmado(E_Usuario usuario)
        {
            InitializeComponent();
            sesion = usuario;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Ingrese Descripcion del Tipo de armado", "Agregar");
                return;
            }

            switch (lblTipoAccion.Text)
            {
                case "Agregar":
                    AgregarArmado();
                    break;
                case "Modificar":
                    ModificarArmado();
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

        private void frmMantenedorTipoArmado_Load(object sender, EventArgs e)
        {
            N_TipoArmado armado1 = new N_TipoArmado();
            dgvLista.DataSource = armado1.Lista();
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

        void AgregarArmado()
        {
            N_TipoArmado armado1 = new N_TipoArmado();
            E_TipoArmado armado2 = new E_TipoArmado();
            armado2.Codigo = "0";
            armado2.Descripcion = txtDescripcion.Text;
            if (armado1.Agregar(armado2) == true)
            {
                dgvLista.DataSource = armado1.Lista();
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
                lblIDTipoArmado.Text = dgvLista.Rows[pos].Cells["codigo"].Value.ToString();

            }
            else
            {
                MessageBox.Show("Seleccione Item", "Modificar");
            }


        }

        void ModificarArmado()
        {
            N_TipoArmado armado1 = new N_TipoArmado();
            E_TipoArmado armado2 = new E_TipoArmado();

            armado2.Codigo = lblIDTipoArmado.Text;
            armado2.Descripcion = txtDescripcion.Text;
            if (armado1.Modificar(armado2) == true)
            {
                dgvLista.DataSource = armado1.Lista();
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

                N_TipoArmado armado1 = new N_TipoArmado();
                if (armado1.Borrar(ID) == true)
                {
                    dgvLista.DataSource = armado1.Lista();
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
