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
    public partial class frmMantenedorVariedad : frmMantenedorAMB
    {
        private E_Usuario sesion { set; get; }
        public frmMantenedorVariedad(E_Usuario usuario)
        {
            InitializeComponent();
            sesion = usuario;
        }

        private void frmMantenedorVariedad_Load(object sender, EventArgs e)
        {
            N_Variedad variedad1 = new N_Variedad();
            dgvLista.DataSource = variedad1.Lista();
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcionVariedad.Text) || string.IsNullOrWhiteSpace(txtDescripcionVariedad.Text))
            {
                MessageBox.Show("Ingrese Descripcion", "Agregar");
                return;
            }

            switch (lblTipoAccion.Text)
            {
                case "Agregar":
                    AgregarVariedad();
                    break;
                case "Modificar":
                    ModificarVariedad();
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
            txtDescripcionVariedad.Text = string.Empty;
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

        void AgregarVariedad()
        {
            N_Variedad variedad1 = new N_Variedad();
            E_Variedad variedad2 = new E_Variedad();

            variedad2.Codigo = "0";
            variedad2.Descripcion = txtDescripcionVariedad.Text;

            if (variedad1.Agregar(variedad2) == true)
            {
                dgvLista.DataSource = variedad1.Lista();
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

                txtDescripcionVariedad.Text = dgvLista.Rows[pos].Cells["descripcion"].Value.ToString();
                lblIDVariedad.Text = dgvLista.Rows[pos].Cells["codigo"].Value.ToString();

            }

        }

        void ModificarVariedad()
        {
            N_Variedad variedad1 = new N_Variedad();
            E_Variedad variedad2 = new E_Variedad();

            variedad2.Codigo = lblIDVariedad.Text;
            variedad2.Descripcion = txtDescripcionVariedad.Text;
            if (variedad1.Modificar(variedad2) == true)
            {
                dgvLista.DataSource = variedad1.Lista();
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

                N_Variedad variedad1 = new N_Variedad();
                if (variedad1.Borrar(ID) == true)
                {
                    dgvLista.DataSource = variedad1.Lista();
                }

            }
            else
            {
                MessageBox.Show("Seleccione Item", "Borrar");
            }

        }

        public override void Importar()
        {
            Leer_ArchivoExcel excel1 = new Negocio.Leer_ArchivoExcel();
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Archivo Excel|*.xlsx";
                openFileDialog1.Title = "Seleccione Archivo";

                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //excel1.CargaPlanilla(openFileDialog1.FileName);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Excel " + ex.Message);
                return;
            }

            MessageBox.Show("Archivo Cargado");

        }

        public override void CellClick()
        {
            txtDescripcionVariedad.Text = string.Empty;
            panelCampos.Visible = false;
        }

        #endregion

    }
}
