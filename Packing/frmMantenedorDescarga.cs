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
using Entity;

namespace Packing
{
    public partial class frmMantenedorDescarga : frmMantenedorAMB
    {
        private E_Usuario sesion { set; get; }
        public frmMantenedorDescarga(E_Usuario usuario)
        {
            InitializeComponent();
            sesion = usuario;
        }

        private void frmMantenedorDescarga_Load(object sender, EventArgs e)
        {
            N_Recepcion descarga1 = new N_Recepcion();
            dgvLista.DataSource = descarga1.Lista_Descarga();
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
            if (string.IsNullOrEmpty(txtDescripcionDescarga.Text) || string.IsNullOrWhiteSpace(txtDescripcionDescarga.Text))
            {
                MessageBox.Show("Ingrese Descripcion", "Agregar");
                return;
            }

            switch (lblTipoAccion.Text)
            {
                case "Agregar":
                    AgregarDescarga();
                    break;
                case "Modificar":
                    ModificarDescarga();
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

        #region Metodos virtuales
        public override void Agregar()
        {
            panelCampos.Top = 0;
            panelCampos.Left = 0;
            panelCampos.Visible = true;
            lblTipoAccion.Text = "Agregar";
            btnAceptar.Text = lblTipoAccion.Text;

        }

        void AgregarDescarga()
        {
            N_Recepcion descarga1 = new N_Recepcion();
            E_Descarga descarga2 = new E_Descarga();
            descarga2.Codigo = "0";
            descarga2.Descripcion = txtDescripcionDescarga.Text;
            if (descarga1.Agregar_Descarga(descarga2) == true)
            {
                dgvLista.DataSource = descarga1.Lista_Descarga();
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

                txtDescripcionDescarga.Text = dgvLista.Rows[pos].Cells["descripcion"].Value.ToString();
                lblIDDescarga.Text = dgvLista.Rows[pos].Cells["codigo"].Value.ToString();

            }



        }

        void ModificarDescarga()
        {
            N_Recepcion descarga1 = new N_Recepcion();
            E_Descarga descarga2 = new E_Descarga();

            descarga2.Codigo = lblIDDescarga.Text;
            descarga2.Descripcion = txtDescripcionDescarga.Text;
            if (descarga1.Modificar_Descarga(descarga2) == true)
            {
                dgvLista.DataSource = descarga1.Lista_Descarga();
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

                N_Recepcion descarga1 = new N_Recepcion();
                if (descarga1.Borrar_Descarga(ID) == true)
                {
                    dgvLista.DataSource = descarga1.Lista_Descarga();
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
            txtDescripcionDescarga.Text = string.Empty;
            panelCampos.Visible = false;
        }
        #endregion
    }
}
