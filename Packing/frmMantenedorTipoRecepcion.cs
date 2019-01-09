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
    public partial class frmMantenedorTipoRecepcion : frmMantenedorAMB
    {
        private E_Usuario sesion { set; get; }
        public frmMantenedorTipoRecepcion(E_Usuario usuario)
        {
            InitializeComponent();
            sesion = usuario;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Ingrese Descripcion", "Agregar");
                return;
            }

            switch (lblTipoAccion.Text)
            {
                case "Agregar":
                    AgregarTipoRecepcion();
                    break;
                case "Modificar":
                    ModificarTipoRecepcion();
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

        private void frmMantenedorTipoRecepcion_Load(object sender, EventArgs e)
        {
            N_Tipo_Recepcion tipo1 = new N_Tipo_Recepcion();
            dgvLista.DataSource = tipo1.Lista();
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

        void AgregarTipoRecepcion()
        {
            N_Tipo_Recepcion tipo1 = new N_Tipo_Recepcion();
            E_Tipo_Recepcion tipo2 = new E_Tipo_Recepcion();
            tipo2.ID = "0";
            tipo2.Descripcion = txtDescripcion.Text;
            if (tipo1.Agregar(tipo2) == true)
            {
                dgvLista.DataSource = tipo1.Lista();
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
                lblIDTipoRecepcion.Text = dgvLista.Rows[pos].Cells["id"].Value.ToString();

            }
            else
            {
                MessageBox.Show("Seleccione Item", "Modificar");
            }


        }

        void ModificarTipoRecepcion()
        {
            N_Tipo_Recepcion tipo1 = new N_Tipo_Recepcion();
            E_Tipo_Recepcion tipo2 = new E_Tipo_Recepcion();

            tipo2.ID = lblIDTipoRecepcion.Text;
            tipo2.Descripcion = txtDescripcion.Text;
            if (tipo1.Modificar(tipo2) == true)
            {
                dgvLista.DataSource = tipo1.Lista();
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
                ID = dgvLista.Rows[pos].Cells["id"].Value.ToString();
                if (MessageBox.Show("¿Borrar Registro Seleccionado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }

                N_Tipo_Recepcion tipo1 = new N_Tipo_Recepcion();
                if (tipo1.Borrar(ID) == true)
                {
                    dgvLista.DataSource = tipo1.Lista();
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
