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
    public partial class frmMantenedorCliente : frmMantenedorAMB 
    {
        private E_Usuario sesion { set; get; }
        public frmMantenedorCliente(E_Usuario usuario)
        {
            InitializeComponent();
            sesion = usuario;
        }

        private void frmMantenedorCliente_Load(object sender, EventArgs e)
        {
            N_Cliente cliente1 = new N_Cliente();
            dgvLista.DataSource = cliente1.Lista();
             
        }
        private void btnImportar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
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

        void AgregarCliente()
        {
            N_Cliente cliente1 = new N_Cliente();
            E_Cliente cliente2 = new E_Cliente();
            cliente2.ID = "0";
            cliente2.Codigo = txtCodigoCliente.Text;
            cliente2.Cliente = txtDescripcionCliente.Text;                
            if (cliente1.Agregar(cliente2) == true)
            {
                dgvLista.DataSource = cliente1.Lista();
            }
            else
            {
                MessageBox.Show("Error: No se pudo agregar el registro", "Agregar");
            }
        }

        public override void Modificar()
        {

            if(dgvLista.SelectedRows.Count != 0)
            {
                panelCampos.Top = 0;
                panelCampos.Left = 0;
                panelCampos.Visible = true;
                lblTipoAccion.Text = "Modificar";                
                btnAceptar.Text = lblTipoAccion.Text;

                int pos = dgvLista.CurrentRow.Index;

                txtCodigoCliente.Text = dgvLista.Rows[pos].Cells["Codigo"].Value.ToString();
                txtDescripcionCliente.Text = dgvLista.Rows[pos].Cells["Cliente"].Value.ToString();
                lblIDCliente.Text = dgvLista.Rows[pos].Cells["ID"].Value.ToString();

            }

           

        }

        void ModificarCliente()
        {
            N_Cliente cliente1 = new N_Cliente();
            E_Cliente cliente2 = new E_Cliente();

            cliente2.ID = lblIDCliente.Text;
            cliente2.Codigo = txtCodigoCliente.Text;
            cliente2.Cliente = txtDescripcionCliente.Text;
            if (cliente1.Modificar(cliente2) == true)
            {
                dgvLista.DataSource = cliente1.Lista();
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
                if(MessageBox.Show ("¿Borrar Registro Seleccionado?","Eliminar",MessageBoxButtons.YesNo,MessageBoxIcon.Question ,MessageBoxDefaultButton .Button2 ) == DialogResult.No)
                {
                    return;
                }
                
                N_Cliente cliente1 = new N_Cliente();
                if (cliente1.Borrar(ID) == true)
                {
                    dgvLista.DataSource = cliente1.Lista();
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
                MessageBox.Show ("Excel " + ex.Message);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelCampos.Visible = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoCliente.Text) || string.IsNullOrWhiteSpace(txtCodigoCliente .Text))
            {
                MessageBox.Show ("Ingrese Codigo","Agregar");
                return;
            }

            if (string.IsNullOrEmpty(txtDescripcionCliente.Text) || string.IsNullOrWhiteSpace(txtDescripcionCliente.Text))
            {                
                MessageBox.Show("Ingrese Descripcion Cliente", "Agregar");
                return;
            }

            switch (lblTipoAccion.Text)
            {
                case "Agregar":
                    AgregarCliente();
                    break;
                case "Modificar":
                    ModificarCliente();
                    break;               
                    //  default:
                    //     Console.WriteLine("Default case");
                    //    break;
            }
            panelCampos.Visible = false;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            txtCodigoCliente.Text = string.Empty;
            txtDescripcionCliente.Text = string.Empty;
        }
    }
}
