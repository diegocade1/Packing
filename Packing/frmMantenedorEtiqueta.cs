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
    public partial class frmMantenedorEtiqueta : frmMantenedorAMB
    {
        private E_Usuario sesion { set; get; }
        public frmMantenedorEtiqueta(E_Usuario etiqueta)
        {
            InitializeComponent();
            sesion = etiqueta;
        }

        private void frmMantenedorEtiqueta_Load(object sender, EventArgs e)
        {
            N_Etiqueta etiqueta1 = new N_Etiqueta();
            N_Cliente cliente1 = new N_Cliente();
            N_Especie especie1 = new N_Especie();

            dgvLista.DataSource = etiqueta1.Lista();

            cbCliente.DataSource = cliente1.Lista();
            cbCliente.ValueMember = "id";
            cbCliente.DisplayMember = "cliente";
            cbCliente.SelectedIndex = -1;

            cbEspecie.DataSource = especie1.Lista();
            cbEspecie.ValueMember = "codigo";
            cbEspecie.DisplayMember = "descripcion";
            cbEspecie.SelectedIndex = -1;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcionEtiqueta.Text) || string.IsNullOrWhiteSpace(txtDescripcionEtiqueta.Text))
            {
                MessageBox.Show("Ingrese Descripcion", "Agregar");
                return;
            }

            if (string.IsNullOrEmpty(cbEspecie.Text) || string.IsNullOrWhiteSpace(cbEspecie.Text))
            {
                MessageBox.Show("Seleccione Especie", "Agregar");
                return;
            }

            if (string.IsNullOrEmpty(cbCliente.Text) || string.IsNullOrWhiteSpace(cbCliente.Text))
            {
                MessageBox.Show("Seleccione Cliente", "Agregar");
                return;
            }

            switch (lblTipoAccion.Text)
            {
                case "Agregar":
                    AgregarEtiqueta();
                    break;
                case "Modificar":
                    ModificarEtiqueta();
                    break;
                    //  default:
                    //     Console.WriteLine("Default case");
                    //    break;
            }
            Limpiar();
            panelCampos.Visible = false;
            btnAgregar.Visible = true;
            btnModificar.Visible = true;
            btnEliminar.Visible = true;
            btnImportar.Visible = true;
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

        private void Limpiar()
        {
            txtDescripcionEtiqueta.Text = string.Empty;
            cbCliente.SelectedIndex = -1;
            cbEspecie.SelectedIndex = -1;
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

        void AgregarEtiqueta()
        {
            N_Etiqueta etiqueta1 = new N_Etiqueta();
            E_Etiqueta etiqueta2 = new E_Etiqueta();

            etiqueta2.Descripcion = txtDescripcionEtiqueta.Text;
            string especie = Convert.ToString(cbEspecie.SelectedValue);
            string cliente = Convert.ToString(cbCliente.SelectedValue);

                if (etiqueta1.Agregar(etiqueta2,especie,cliente) == true)
                {
                    dgvLista.DataSource = etiqueta1.Lista();
                Limpiar();
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

                N_Etiqueta etiqueta1 = new N_Etiqueta();
                E_Etiqueta_EC etiqueta2 = etiqueta1.ObtenerEtiqueta(dgvLista.Rows[pos].Cells["codigo"].Value.ToString());

                txtDescripcionEtiqueta.Text = etiqueta2.Descripcion;
                cbCliente.SelectedValue = etiqueta2.Cliente.ToString();
                cbEspecie.SelectedValue = etiqueta2.Especie.ToString();
                lblIDEtiqueta.Text = etiqueta2.Codigo;
            }



        }

        void ModificarEtiqueta()
        {
            N_Etiqueta etiqueta1 = new N_Etiqueta();
            E_Etiqueta etiqueta2 = new E_Etiqueta();

            etiqueta2.Codigo = lblIDEtiqueta.Text;
            etiqueta2.Descripcion = txtDescripcionEtiqueta.Text;
            string especie = Convert.ToString(cbEspecie.SelectedValue);
            string cliente = Convert.ToString(cbCliente.SelectedValue);
            if (etiqueta1.Modificar(etiqueta2,especie,cliente) == true)
            {
                dgvLista.DataSource = etiqueta1.Lista();
                Limpiar();
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
                ID = dgvLista.Rows[pos].Cells["etiqueta"].Value.ToString();
                if (MessageBox.Show("¿Borrar Registro Seleccionado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }

                N_Etiqueta etiqueta1 = new N_Etiqueta();

                    if (etiqueta1.Borrar(ID) == true)
                    {
                        dgvLista.DataSource = etiqueta1.Lista();
                    }
                    else
                    {
                    MessageBox.Show("Error: No se pudo eliminar el registro", "Eliminar");
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

        #endregion
    }
}
