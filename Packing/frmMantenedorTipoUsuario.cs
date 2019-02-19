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
    public partial class frmMantenedorTipoUsuario : frmMantenedorAMB
    {
        private E_Usuario sesion { get; set; }
        private string permisos { set; get; }
        public frmMantenedorTipoUsuario(E_Usuario usuario)
        {
            InitializeComponent();
            sesion = usuario;
        }
        private void frmTipoUsuario_Load_1(object sender, EventArgs e)
        {

        }

        private void frmMantenedorTipoUsuario_Load(object sender, EventArgs e)
        {
            N_Tipo_Usuario tipo1 = new N_Tipo_Usuario();
            dgvLista.DataSource = tipo1.Lista();
        }

        private void btnPermisos_Click(object sender, EventArgs e)
        {
            frmVentanaPermisos frm = new frmVentanaPermisos(sesion, lblIDTipoUsuario.Text);
            frm.ShowDialog();
            permisos = frm.permisosFrm;
        }

        private void Limpiar()
        {
            txtTipoUsuario.Text = string.Empty;
            permisos = string.Empty;
            lblIDTipoUsuario.Text = "lblIDTipoUsuario";
        }

        private void CargarLista()
        {
            N_Tipo_Usuario tipo1 = new N_Tipo_Usuario();
            dgvLista.DataSource = tipo1.Lista();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTipoUsuario.Text) || string.IsNullOrWhiteSpace(txtTipoUsuario.Text))
            {
                MessageBox.Show("Ingrese Descripcion del tipo de usuario", "Agregar");
                return;
            }

            if (string.IsNullOrEmpty(permisos) || string.IsNullOrWhiteSpace(permisos))
            {
                MessageBox.Show("Seleccione los permisos del tipo de usuario", "Agregar");
                return;
            }

            switch (lblTipoAccion.Text)
            {
                case "Agregar":
                    AgregarTipoUsuario();
                    break;
                case "Modificar":
                    ModificarTipoUsuario();
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
            Limpiar();
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

        void AgregarTipoUsuario()
        {
            N_Tipo_Usuario tipo1 = new N_Tipo_Usuario();
            E_Tipo_Usuario tipo2 = new E_Tipo_Usuario();

            N_Tipo_Usuario_Permiso permisos1 = new N_Tipo_Usuario_Permiso();
            E_Tipo_Usuario_Permiso permisos2 = new E_Tipo_Usuario_Permiso();

            string ultimoID="";

            tipo2.ID = 0;
            tipo2.Descripcion = txtTipoUsuario.Text;

            if (tipo1.Agregar(tipo2) == true)
            {
                ultimoID = tipo1.UltimoID;
                permisos2.ID_tipo_usuario = Convert.ToInt32(ultimoID);
                permisos2.Permisos = permisos;
                if(permisos1.Agregar(permisos2))
                {
                    CargarLista();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(permisos1.Mensaje);
                }
            }
            else
            {
                MessageBox.Show("Error: No se pudo agregar el registro"+"\n"+tipo1.Mensaje, "Agregar");
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

                N_Tipo_Usuario_Permiso tipo_usuario1 = new N_Tipo_Usuario_Permiso();                

                txtTipoUsuario.Text = dgvLista.Rows[pos].Cells["descripcion"].Value.ToString();
                lblIDTipoUsuario.Text = dgvLista.Rows[pos].Cells["id"].Value.ToString();
                E_Tipo_Usuario_Permiso obj = tipo_usuario1.ObtenerPermisos(lblIDTipoUsuario.Text);
                permisos = obj.Permisos;
            }
        }

        void ModificarTipoUsuario()
        {
            N_Tipo_Usuario tipo1 = new N_Tipo_Usuario();
            E_Tipo_Usuario tipo2 = new E_Tipo_Usuario();

            N_Tipo_Usuario_Permiso permisos1 = new N_Tipo_Usuario_Permiso();
            E_Tipo_Usuario_Permiso permisos2 = new E_Tipo_Usuario_Permiso();

            tipo2.ID = Convert.ToInt32(lblIDTipoUsuario.Text);
            tipo2.Descripcion = txtTipoUsuario.Text;

            if (tipo1.Modificar(tipo2) == true)
            {
                permisos2 = permisos1.ObtenerPermisos(lblIDTipoUsuario.Text);
                permisos2.Permisos = permisos;
                if (permisos1.Modificar(permisos2))
                {
                    CargarLista();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(permisos1.Mensaje);
                }
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

                N_Tipo_Usuario tipo1 = new N_Tipo_Usuario();

                N_Tipo_Usuario_Permiso permisos1 = new N_Tipo_Usuario_Permiso();
                E_Tipo_Usuario_Permiso permiso2 = permisos1.ObtenerPermisos(ID);
                if (tipo1.Borrar(ID) == true)
                {
                    permisos1.Borrar(permiso2.ID.ToString());

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
            //Leer_ArchivoExcel excel1 = new Negocio.Leer_ArchivoExcel();
            //N_Tipo_Usuario tipo1 = new N_Tipo_Usuario();
            //try
            //{
            //    OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //    openFileDialog1.Filter = "Archivo Excel|*.xlsx";
            //    openFileDialog1.Title = "Seleccione Archivo";

            //    if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //    {
            //        excel1.CargaPlanillaProductor(openFileDialog1.FileName);
            //        CargarLista();

            //        if (excel1.Detalle != "")
            //        {
            //            MessageBox.Show(excel1.Mensaje + "\n" + "_________________________________________________________________________" + "\n\n" + "Detalles: \n" + excel1.Detalle, "Carga de Datos");
            //        }
            //        else
            //        {
            //            MessageBox.Show(excel1.Mensaje, "Carga de Datos");
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Excel " + ex.Message);
            //    return;
            //}

        }

        public override void CellClick()
        {
            Limpiar();
            panelCampos.Visible = false;
        }
        #endregion
    }
}
