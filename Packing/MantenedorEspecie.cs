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
    public partial class MantenedorEspecie : frmMantenedorAMB 
    {
        private E_Usuario sesion { set; get; }
        public MantenedorEspecie(E_Usuario usuario)
        {
            InitializeComponent();
            sesion = usuario;
        }

        private void MantenedorEspecie_Load(object sender, EventArgs e)
        {
            N_Especie especie1 = new N_Especie();
            dgvLista.DataSource = especie1.Lista();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
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
            txtDescripcion.Text = string.Empty;
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

        void AgregarEspecie()
        {
            N_Especie especie1 = new N_Especie();
            E_Especie especie2 = new E_Especie();
            especie2.Codigo = "0";
            especie2.Descripcion = txtDescripcion.Text;
            if (especie1.Agregar(especie2) == true)
            {
                dgvLista.DataSource = especie1.Lista();
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
                lblIDEspecie.Text = dgvLista.Rows[pos].Cells["codigo"].Value.ToString();

            }
            else
            {
                MessageBox.Show("Seleccione Item", "Modificar");
            }


        }

        void ModificarEspecie()
        {
            N_Especie especie1 = new N_Especie();
            E_Especie especie2 = new E_Especie();

            especie2.Codigo = lblIDEspecie.Text;
            especie2.Descripcion = txtDescripcion.Text;
            if (especie1.Modificar(especie2) == true)
            {
                dgvLista.DataSource = especie1.Lista();
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

                N_Especie especie1 = new N_Especie();
                if (especie1.Borrar(ID) == true)
                {
                    dgvLista.DataSource = especie1.Lista();
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
            N_Especie especie1 = new N_Especie();
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Archivo Excel|*.xlsx";
                openFileDialog1.Title = "Seleccione Archivo";

                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    excel1.CargaPlanillaEspecie(openFileDialog1.FileName);
                    dgvLista.DataSource = especie1.Lista();

                    if (excel1.Detalle != "")
                    {
                        MessageBox.Show(excel1.Mensaje + "\n" + "_________________________________________________________________________" + "\n\n" + "Detalles: \n" + excel1.Detalle, "Carga de Datos");
                    }
                    else
                    {
                        MessageBox.Show(excel1.Mensaje, "Carga de Datos");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Excel " + ex.Message);
                return;
            }
        }
        public override void CellClick()
        {
            Limpiar();
            panelCampos.Visible = false;
        }
        #endregion

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Ingrese Descripcion de la Especie", "Agregar");
                return;
            }

            switch (lblTipoAccion.Text)
            {
                case "Agregar":
                    AgregarEspecie();
                    break;
                case "Modificar":
                    ModificarEspecie();
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
