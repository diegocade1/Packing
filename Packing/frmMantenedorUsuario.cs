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
    public partial class frmMantenedorUsuario : frmMantenedorAMB
    {
        private E_Usuario sesion { set; get; }
        public frmMantenedorUsuario(E_Usuario usuario)
        {
            InitializeComponent();
            sesion = usuario;
        }

        private void frmMantenedorUsuario_Load(object sender, EventArgs e)
        {
            N_Usuario usuario1 = new N_Usuario();
            N_Tipo_Usuario tipo = new N_Tipo_Usuario();
            cbTipoUsuario.DataSource = tipo.Lista();
            cbTipoUsuario.ValueMember = "id";
            cbTipoUsuario.DisplayMember = "descripcion";
            dgvLista.DataSource = usuario1.Lista();
            cbTipoUsuario.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelCampos.Visible = false;
            btnAgregar.Visible = true;
            btnModificar.Visible = true;
            btnEliminar.Visible = true;
            btnImportar.Visible = true;
            txtUsuario.ReadOnly = false;
            Limpiar();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Ingrese Usuario", "Agregar");
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Ingrese contraseña del usuario", "Agregar");
                return;
            }

            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese nombre del usuario", "Agregar");
                return;
            }

            if (string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Ingrese apellido del usuario", "Agregar");
                return;
            }

            if (string.IsNullOrEmpty(cbTipoUsuario.Text) || string.IsNullOrWhiteSpace(cbTipoUsuario.Text))
            {
                MessageBox.Show("Seleccione el tipo de usuario", "Agregar");
                return;
            }

            switch (lblTipoAccion.Text)
            {
                case "Agregar":
                    AgregarUsuario();
                    break;
                case "Modificar":
                    ModificarUsuario();
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
            txtNombre.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtApellido.Text = string.Empty;
            cbTipoUsuario.SelectedIndex = -1;
        }

        #region Metodos virtuales
        public override void Agregar()
        {
            panelCampos.Top = 0;
            panelCampos.Left = 0;
            panelCampos.Visible = true;
            btnAgregar.Visible = false;
            btnModificar.Visible = false;
            btnEliminar.Visible = false;
            btnImportar.Visible = false;
            lblTipoAccion.Text = "Agregar";
            btnAceptar.Text = lblTipoAccion.Text;

        }

        void AgregarUsuario()
        {
            N_Usuario usuario1 = new N_Usuario();
            E_Usuario usuario2 = new E_Usuario();
            usuario2.Usuario = txtUsuario.Text;
            usuario2.Contrasenia = txtPassword.Text;
            usuario2.Nombre = txtNombre.Text;
            usuario2.Apellido = txtApellido.Text;
            usuario2.Tipo_usuario = Convert.ToString(cbTipoUsuario.SelectedValue);
            if(usuario1.ObtenerUsuario(usuario2.Usuario)!=null)
            {
                MessageBox.Show("Usuario ya existe", "Agregar");
            }
            else
            {               
                if (usuario1.Agregar(usuario2) == true)
                {
                    dgvLista.DataSource = usuario1.Lista();
                }
                else
                {
                    MessageBox.Show("Error: No se pudo agregar el registro", "Agregar");
                }
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

                txtUsuario.Text = dgvLista.Rows[pos].Cells["usuario"].Value.ToString();
                txtPassword.Text = dgvLista.Rows[pos].Cells["contrasenia"].Value.ToString();
                txtNombre.Text = dgvLista.Rows[pos].Cells["nombre"].Value.ToString();
                txtApellido.Text = dgvLista.Rows[pos].Cells["apellido"].Value.ToString();
                cbTipoUsuario.SelectedValue = Convert.ToInt32(dgvLista.Rows[pos].Cells["tipo_usuario"].Value.ToString());
                lblIDUsuario.Text = dgvLista.Rows[pos].Cells["usuario"].Value.ToString();
                txtUsuario.ReadOnly = true;
                btnAgregar.Visible = false;
                btnModificar.Visible = false;
                btnEliminar.Visible = false;
                btnImportar.Visible = false;
            }



        }

        void ModificarUsuario()
        {
            N_Usuario usuario1 = new N_Usuario();
            E_Usuario usuario2 = new E_Usuario();

            usuario2.Usuario = lblIDUsuario.Text;
            usuario2.Usuario = txtUsuario.Text;
            usuario2.Contrasenia = txtPassword.Text;
            usuario2.Nombre = txtNombre.Text;
            usuario2.Apellido = txtApellido.Text;
            usuario2.Tipo_usuario = Convert.ToString(cbTipoUsuario.SelectedValue);
            if (usuario1.Modificar(usuario2) == true)
            {
                dgvLista.DataSource = usuario1.Lista();
                txtUsuario.ReadOnly = false;
            }
            else
            {
                MessageBox.Show("Error: No se pudo modificar el registro","Modificar");
            }
        }





        public override void Borrar()
        {
            if (dgvLista.SelectedRows.Count != 0)
            {

                int pos = dgvLista.CurrentRow.Index;
                string ID;
                ID = dgvLista.Rows[pos].Cells["usuario"].Value.ToString();
                if (MessageBox.Show("¿Borrar Registro Seleccionado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }

                N_Usuario usuario1 = new N_Usuario();
                if (sesion.Usuario.Equals(ID))
                {
                    MessageBox.Show("Error al borrar, usuario en uso", "Borrar");
                }
                else
                {
                    if (usuario1.Borrar(ID) == true)
                    {
                        dgvLista.DataSource = usuario1.Lista();
                    }
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
