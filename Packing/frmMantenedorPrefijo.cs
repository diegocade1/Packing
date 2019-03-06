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
    public partial class frmMantenedorPrefijo : frmMantenedorAMB
    {
        private E_Usuario sesion { set; get; }
        public frmMantenedorPrefijo(E_Usuario usuario)
        {
            InitializeComponent();
            sesion = usuario;
        }

        private void frmMantenedorPrefijo_Load(object sender, EventArgs e)
        {
            N_Prefijo prefijo1 = new N_Prefijo();
            dgvLista.DataSource = prefijo1.Lista();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            if (dgvLista.SelectedRows.Count != 0)
            {
                int pos = dgvLista.CurrentRow.Index;
                string ID;
                ID = dgvLista.Rows[pos].Cells["id"].Value.ToString();
                N_Prefijo prefijo1 = new N_Prefijo();
                E_Prefijo prefijo2 = prefijo1.ObtenerPrefijoActivo(ID);
                prefijo2.Estado = true;
                prefijo1.ActualizarPrefijoActivo(prefijo2);
                dgvLista.DataSource = prefijo1.Lista();
            }
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            if (dgvLista.SelectedRows.Count != 0)
            {
                int pos = dgvLista.CurrentRow.Index;
                string ID;
                ID = dgvLista.Rows[pos].Cells["id"].Value.ToString();
                N_Prefijo prefijo1 = new N_Prefijo();
                E_Prefijo prefijo2 = prefijo1.ObtenerPrefijoActivo(ID);
                prefijo2.Estado = false;
                prefijo1.ActualizarPrefijoActivo(prefijo2);
                dgvLista.DataSource = prefijo1.Lista();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcionPrefijo.Text) || string.IsNullOrWhiteSpace(txtDescripcionPrefijo.Text))
            {
                MessageBox.Show("Ingrese Descripcion", "Agregar");
                return;
            }

            switch (lblTipoAccion.Text)
            {
                case "Agregar":
                    AgregarPallet();
                    break;
                case "Modificar":
                    ModificarPallet();
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

        void AgregarPallet()
        {
            N_Prefijo prefijo1 = new N_Prefijo();
            E_Prefijo prefijo2 = new E_Prefijo();

            prefijo2.ID = "0";
            prefijo2.Prefijo = txtDescripcionPrefijo.Text;

            if (prefijo1.AgregarPrefijoActivo(prefijo2) == true)
            {
                dgvLista.DataSource = prefijo1.Lista();
            }
            else
            {
                MessageBox.Show("Error: No se pudo crear el registro", "Agregar");
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

                txtDescripcionPrefijo.Text = dgvLista.Rows[pos].Cells["prefijo"].Value.ToString();
                lblIDPrefijo.Text = dgvLista.Rows[pos].Cells["id"].Value.ToString();

            }

        }

        void ModificarPallet()
        {
            N_Prefijo prefijo1 = new N_Prefijo();
            E_Prefijo prefijo2 = new E_Prefijo();

            prefijo2.ID = lblIDPrefijo.Text;
            prefijo2.Prefijo = txtDescripcionPrefijo.Text;

            if (prefijo1.ActualizarPrefijoActivo(prefijo2) == true)
            {
                dgvLista.DataSource = prefijo1.Lista();
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

                N_Prefijo prefijo1 = new N_Prefijo();
                if (prefijo1.BorrarPrefijoActivo(ID) == true)
                {
                    dgvLista.DataSource = prefijo1.Lista();
                }

            }
            else
            {
                MessageBox.Show("Seleccione Item", "Borrar");
            }

        }

        public override void Importar()
        {
            //Leer_ArchivoExcel excel1 = new Negocio.Leer_ArchivoExcel();
            //try
            //{
            //    OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //    openFileDialog1.Filter = "Archivo Excel|*.xlsx";
            //    openFileDialog1.Title = "Seleccione Archivo";

            //    if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //    {
            //        excel1.CargaPlanilla(openFileDialog1.FileName);

            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Excel " + ex.Message);
            //    return;
            //}

            //MessageBox.Show("Archivo Cargado");

        }
        public override void CellClick()
        {
            Limpiar();
            panelCampos.Visible = false;
        }
        #endregion

        private void Limpiar()
        {
            txtDescripcionPrefijo.Text = string.Empty;
        }
    }
}
