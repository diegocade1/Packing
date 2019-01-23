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
    public partial class frmMantenedorProductor : frmMantenedorAMB
    {
        private E_Usuario sesion { set; get; }
        public frmMantenedorProductor(E_Usuario usuario)
        {
            InitializeComponent();
            sesion = usuario;
        }

        private void frmMantenedorProductor_Load(object sender, EventArgs e)
        {
            N_Productor productor1 = new N_Productor();
            N_Cliente cliente1 = new N_Cliente();

            dgvLista.DataSource = productor1.ListaCompleta();
            dgvLista.Columns["Codigo"].DisplayIndex = 0;
            dgvLista.Columns["Descripcion"].DisplayIndex = 1;
            dgvLista.Columns["Codigo_cliente"].DisplayIndex = 2;
            dgvLista.Columns["Codigo_productor"].DisplayIndex = 3;

            cbCliente.DataSource = cliente1.Lista();
            cbCliente.ValueMember = "id";
            cbCliente.DisplayMember = "cliente";
            cbCliente.SelectedIndex = -1;

        }

        private void CargarLista()
        {
            N_Productor productor1 = new N_Productor();

            dgvLista.DataSource = productor1.ListaCompleta();
            dgvLista.Columns["Codigo"].DisplayIndex = 0;
            dgvLista.Columns["Descripcion"].DisplayIndex = 1;
            dgvLista.Columns["Codigo_cliente"].DisplayIndex = 2;
            dgvLista.Columns["Codigo_productor"].DisplayIndex = 3;
            dgvLista.Refresh();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcionProductor.Text) || string.IsNullOrWhiteSpace(txtDescripcionProductor.Text))
            {
                MessageBox.Show("Ingrese Descripcion", "Agregar");
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
                    AgregarProductor();
                    break;
                case "Modificar":
                    ModificarProductor();
                    break;
                    //  default:
                    //     Console.WriteLine("Default case");
                    //    break;
            }
            Limpiar();
            panelCampos.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelCampos.Visible = false;
        }

        private void Limpiar()
        {
            txtDescripcionProductor.Text = string.Empty;
            cbCliente.SelectedIndex = -1;
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

        void AgregarProductor()
        {
            N_Productor productor1 = new N_Productor();
            E_Productor productor2 = new E_Productor();

            productor2.Codigo = "0";
            productor2.Descripcion = txtDescripcionProductor.Text;
            productor2.Codigo_Cliente = Convert.ToString(cbCliente.SelectedValue);
            productor2.Codigo_Productor = txtCodigoProductor.Text;

            if (productor1.Agregar(productor2) == true)
            {
                CargarLista();
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

                txtDescripcionProductor.Text = dgvLista.Rows[pos].Cells["descripcion"].Value.ToString();
                cbCliente.SelectedValue = dgvLista.Rows[pos].Cells["codigo_cliente"].Value.ToString();
                txtCodigoProductor.Text = dgvLista.Rows[pos].Cells["codigo_productor"].Value.ToString();
                lblIDProductor.Text = dgvLista.Rows[pos].Cells["codigo"].Value.ToString();
            }



        }

        void ModificarProductor()
        {
            N_Productor productor1 = new N_Productor();
            E_Productor productor2 = new E_Productor();

            productor2.Codigo = lblIDProductor.Text;
            productor2.Descripcion = txtDescripcionProductor.Text;
            productor2.Codigo_Cliente = Convert.ToString(cbCliente.SelectedValue);
            productor2.Codigo_Productor = txtCodigoProductor.Text;

            if (productor1.Modificar(productor2) == true)
            {
                CargarLista();
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
                ID = dgvLista.Rows[pos].Cells["codigo"].Value.ToString();
                if (MessageBox.Show("¿Borrar Registro Seleccionado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }

                N_Productor productor1 = new N_Productor();

                if (productor1.Borrar(ID) == true)
                {
                    CargarLista();
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
            N_Productor productor1 = new N_Productor();
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Archivo Excel|*.xlsx";
                openFileDialog1.Title = "Seleccione Archivo";

                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    excel1.CargaPlanillaProductor(openFileDialog1.FileName);
                    CargarLista();

                    if (excel1.Detalle != "")
                    {
                        MessageBox.Show(excel1.Mensaje + "\n"+ "_________________________________________________________________________"+ "\n\n" + "Detalles: \n" + excel1.Detalle, "Carga de Datos");
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
