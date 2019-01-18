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
    public partial class frmMantenedorEmbalaje : frmMantenedorAMB
    {
        private E_Usuario sesion { set; get; }
        public frmMantenedorEmbalaje(E_Usuario usuario)
        {
            InitializeComponent();
            sesion = usuario;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcionCaja.Text) || string.IsNullOrWhiteSpace(txtDescripcionCaja.Text))
            {
                MessageBox.Show("Ingrese Descripcion", "Agregar");
                return;
            }

            if (string.IsNullOrEmpty(txtPeso.Text) || string.IsNullOrWhiteSpace(txtPeso.Text))
            {
                MessageBox.Show("Ingrese Peso", "Agregar");
                return;
            }

            if (string.IsNullOrEmpty(txtCantidad_Potes.Text) || string.IsNullOrWhiteSpace(txtCantidad_Potes.Text))
            {
                MessageBox.Show("Ingrese Cantidad Potes", "Agregar");
                return;
            }

            switch (lblTipoAccion.Text)
            {
                case "Agregar":
                    AgregarCaja();
                    break;
                case "Modificar":
                    ModificarCaja();
                    break;
                    //  default:
                    //     Console.WriteLine("Default case");
                    //    break;
            }
            panelCampos.Visible = false;
        }

        private void frmMantenedorCaja_Load(object sender, EventArgs e)
        {
            N_Embalaje caja1 = new N_Embalaje();
            dgvLista.DataSource = caja1.Lista();

            N_Cliente cliente1 = new N_Cliente();

            cbCliente.DataSource = cliente1.Lista();
            cbCliente.ValueMember = "id";
            cbCliente.DisplayMember = "cliente";
            cbCliente.SelectedIndex = -1;
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

        void AgregarCaja()
        {
            N_Embalaje caja1 = new N_Embalaje();
            E_Embalaje caja2 = new E_Embalaje();

            caja2.ID = "0";
            caja2.Descripcion = txtDescripcionCaja.Text;
            caja2.Peso = Convert.ToDouble(txtPeso.Text.Replace(".", ","));
            caja2.Potes = Convert.ToInt32(txtCantidad_Potes.Text);
            caja2.ID_Cliente = Convert.ToInt32(cbCliente.SelectedValue);

            if (caja1.Agregar(caja2) == true)
            {
                dgvLista.DataSource = caja1.Lista();
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

                txtDescripcionCaja.Text = dgvLista.Rows[pos].Cells["descripcion"].Value.ToString();
                txtPeso.Text = dgvLista.Rows[pos].Cells["peso"].Value.ToString();
                txtCantidad_Potes.Text = dgvLista.Rows[pos].Cells["potes"].Value.ToString();
                cbCliente.SelectedValue = dgvLista.Rows[pos].Cells["id_cliente"].Value.ToString();
                lblIDCaja.Text = dgvLista.Rows[pos].Cells["ID"].Value.ToString();

            }

        }

        void ModificarCaja()
        {
            N_Embalaje caja1 = new N_Embalaje();
            E_Embalaje caja2 = new E_Embalaje();

            caja2.ID= lblIDCaja.Text;
            caja2.Descripcion = txtDescripcionCaja.Text;
            caja2.Peso = Convert.ToDouble(txtPeso.Text.Replace(".", ","));
            caja2.Potes = Convert.ToInt32(txtCantidad_Potes.Text);
            caja2.ID_Cliente = Convert.ToInt32(cbCliente.SelectedValue);

            if (caja1.Modificar(caja2) == true)
            {
                dgvLista.DataSource = caja1.Lista();
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
                ID = dgvLista.Rows[pos].Cells["ID"].Value.ToString();
                if (MessageBox.Show("¿Borrar Registro Seleccionado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }

                N_Embalaje caja1 = new N_Embalaje();
                if (caja1.Borrar(ID) == true)
                {
                    dgvLista.DataSource = caja1.Lista();
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
            txtDescripcionCaja.Text = string.Empty;
            txtCantidad_Potes.Text = string.Empty;
            txtPeso.Text = string.Empty;
            cbCliente.SelectedIndex = -1;
        }
    }
}
