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
    public partial class frmMantenedorBandeja : frmMantenedorAMB
    {
        private E_Usuario sesion { set; get; }
        public frmMantenedorBandeja(E_Usuario usuario)
        {
            InitializeComponent();
            sesion = usuario;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcionBandeja.Text) || string.IsNullOrWhiteSpace(txtDescripcionBandeja.Text))
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
                    AgregarBandeja();
                    break;
                case "Modificar":
                    ModificarBandeja();
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

        private void frmMantenedorBandeja_Load(object sender, EventArgs e)
        {
            N_Bandeja bandeja1 = new N_Bandeja();
            dgvLista.DataSource = bandeja1.Lista();
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

        void AgregarBandeja()
        {
            N_Bandeja bandeja1 = new N_Bandeja();
            E_Bandeja bandeja2 = new E_Bandeja();

            bandeja2.Codigo = "0";
            bandeja2.Descripcion = txtDescripcionBandeja.Text;
            bandeja2.Peso = Convert.ToDouble(txtPeso.Text.Replace(".",","));
            if (bandeja1.Agregar(bandeja2) == true)
            {
                dgvLista.DataSource = bandeja1.Lista();
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

                txtDescripcionBandeja.Text = dgvLista.Rows[pos].Cells["descripcion"].Value.ToString();
                txtPeso.Text = dgvLista.Rows[pos].Cells["peso"].Value.ToString();
                lblIDBandeja.Text = dgvLista.Rows[pos].Cells["codigo"].Value.ToString();

            }

        }

        void ModificarBandeja()
        {
            N_Bandeja bandeja1 = new N_Bandeja();
            E_Bandeja bandeja2 = new E_Bandeja();

            bandeja2.Codigo = lblIDBandeja.Text;
            bandeja2.Descripcion = txtDescripcionBandeja.Text;
            bandeja2.Peso = Convert.ToDouble(txtPeso.Text.Replace(".",","));
            if (bandeja1.Modificar(bandeja2) == true)
            {
                dgvLista.DataSource = bandeja1.Lista();
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

                N_Bandeja bandeja1 = new N_Bandeja();
                if (bandeja1.Borrar(ID) == true)
                {
                    dgvLista.DataSource = bandeja1.Lista();
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
            Limpiar();
            panelCampos.Visible = false;
        }

        #endregion

        private void Limpiar()
        {
            txtDescripcionBandeja.Text = string.Empty;
            txtPeso.Text = string.Empty;
        }
    }
}
