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
    public partial class frmMantenedorPallet : frmMantenedorAMB
    {
        private E_Usuario sesion { set; get; }
        public frmMantenedorPallet(E_Usuario usuario)
        {
            InitializeComponent();
            sesion = usuario;
        }

        private void frmMantenedorPallet_Load(object sender, EventArgs e)
        {
            N_Pallet pallet1 = new N_Pallet();
            dgvLista.DataSource = pallet1.Lista();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcionPallet.Text) || string.IsNullOrWhiteSpace(txtDescripcionPallet.Text))
            {
                MessageBox.Show("Ingrese Descripcion", "Agregar");
                return;
            }

            if (string.IsNullOrEmpty(txtPeso.Text) || string.IsNullOrWhiteSpace(txtPeso.Text))
            {
                MessageBox.Show("Ingrese Peso", "Agregar");
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

        void AgregarPallet()
        {
            N_Pallet pallet1 = new N_Pallet();
            E_Pallet pallet2 = new E_Pallet();

            pallet2.Codigo = "0";
            pallet2.Descripcion = txtDescripcionPallet.Text;
            pallet2.Peso = Convert.ToDouble(txtPeso.Text.Replace(".",","));
            if (pallet1.Agregar(pallet2) == true)
            {
                dgvLista.DataSource = pallet1.Lista();
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

                txtDescripcionPallet.Text = dgvLista.Rows[pos].Cells["descripcion"].Value.ToString();
                txtPeso.Text = dgvLista.Rows[pos].Cells["peso"].Value.ToString();
                lblIDPallet.Text = dgvLista.Rows[pos].Cells["codigo"].Value.ToString();

            }

        }

        void ModificarPallet()
        {
            N_Pallet pallet1 = new N_Pallet();
            E_Pallet pallet2 = new E_Pallet();

            pallet2.Codigo = lblIDPallet.Text;
            pallet2.Descripcion = txtDescripcionPallet.Text;
            pallet2.Peso = Convert.ToDouble(txtPeso.Text.Replace(".", ","));
            if (pallet1.Modificar(pallet2) == true)
            {
                dgvLista.DataSource = pallet1.Lista();
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

                N_Pallet pallet1 = new N_Pallet();
                if (pallet1.Borrar(ID) == true)
                {
                    dgvLista.DataSource = pallet1.Lista();
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
                    excel1.CargaPlanilla(openFileDialog1.FileName);

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
            Limpiar();
            panelCampos.Visible = false;
        }
        #endregion
        private void Limpiar()
        {
            txtDescripcionPallet.Text = string.Empty;
            txtPeso.Text = string.Empty;
        }
    }
}
