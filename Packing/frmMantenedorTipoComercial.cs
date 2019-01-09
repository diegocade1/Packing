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
    public partial class frmMantenedorTipoComercial : frmMantenedorAMB
    {
        private E_Usuario sesion { set; get; }
        public frmMantenedorTipoComercial(E_Usuario usuario)
        {
            InitializeComponent();
            sesion = usuario;
        }

        private void frmMantenedorTipoComercial_Load(object sender, EventArgs e)
        {
            N_TipoComercial tipo = new N_TipoComercial();
            dgvLista.DataSource = tipo.Lista();

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

        void AgregarComercial()
        {
            N_TipoComercial comercial1 = new N_TipoComercial();
            E_TipoComercial comercial2 = new E_TipoComercial();
            comercial2.ID = "0";
            comercial2.Descripcion = txtDescripcion.Text;
            if (comercial1.Agregar(comercial2) == true)
            {
                dgvLista.DataSource = comercial1.Lista();
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
                lblIDComercio.Text = dgvLista.Rows[pos].Cells["ID"].Value.ToString();

            }
            else
            {
                MessageBox.Show("Seleccione Item", "Modificar");
            }


        }

        void ModificarComercial()
        {
            N_TipoComercial comercial1 = new N_TipoComercial();
            E_TipoComercial comercial2 = new E_TipoComercial();

            comercial2.ID = lblIDComercio.Text;
            comercial2.Descripcion = txtDescripcion.Text;
            if (comercial1.Modificar(comercial2) == true)
            {
                dgvLista.DataSource = comercial1.Lista();
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

                N_TipoComercial comercial1 = new N_TipoComercial();
                if (comercial1.Borrar(ID) == true)
                {
                    dgvLista.DataSource = comercial1.Lista();
                }

            }
            else
            {
                MessageBox.Show("Seleccione Item", "Borrar");
            }

        }

        //public override void Importar()
        //{
        //    Leer_ArchivoExcel excel1 = new Negocio.Leer_ArchivoExcel();
        //    try
        //    {
        //        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        //        openFileDialog1.Filter = "Archivo Excel|*.xlsx";
        //        openFileDialog1.Title = "Seleccione Archivo";

        //        if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //        {
        //            excel1.CargaPlanilla(openFileDialog1.FileName);

        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Excel " + ex.Message);
        //        return;
        //    }

        //    MessageBox.Show("Archivo Cargado");

        //}

        #endregion

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Ingrese Descripcion del Tipo de Comercial", "Agregar");
                return;
            }

            switch (lblTipoAccion.Text)
            {
                case "Agregar":
                    AgregarComercial();
                    break;
                case "Modificar":
                    ModificarComercial();
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
    }
}
