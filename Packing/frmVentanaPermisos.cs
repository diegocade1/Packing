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
    public partial class frmVentanaPermisos : Form
    {
        private E_Usuario sesion { set;get; }
        public string permisosFrm { set; get; }
        public frmVentanaPermisos(E_Usuario usuario, string permisos)
        {
            InitializeComponent();
            sesion = usuario;
            permisosFrm = permisos;
        }

        private void frmVentanaPermisos_Load(object sender, EventArgs e)
        {
            if(permisosFrm != "lblIDTipoUsuario")
            {
                N_Tipo_Usuario_Permiso tipo_usuario1 = new N_Tipo_Usuario_Permiso();
                E_Tipo_Usuario_Permiso obj = tipo_usuario1.ObtenerPermisos(permisosFrm);
                permisosFrm = obj.Permisos;
                LlenarLista();
                LlenarListaPermisosExistentes();
            }
            else
            {
                LlenarLista();
            }
            
        }

        private void LlenarLista()
        {
            int index = 0;
            N_Permiso permiso1 = new N_Permiso();
            foreach(E_Permiso obj in permiso1.Lista())
            {
                //clbPermisos.Items.Insert(0, new { Text = obj.Nombre, Value = obj.Llave });
                clbPermisos.Items.Insert(index, new { Text = obj.Nombre, Value = obj.Llave });
                index++;
            }

            clbPermisos.DisplayMember = "Text";
            clbPermisos.ValueMember = "Value";
            clbPermisos.Refresh();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string permisos="";
            for (int i = 0; i < clbPermisos.Items.Count; i++)
            {
                if (clbPermisos.GetItemCheckState(i) == CheckState.Checked)
                {
                    string tempName = clbPermisos.Items[i].ToString();
                    string [] array = tempName.Split(',');
                    string trim = array[1].Replace(" ", "").Replace("}",",");
                    string permiso = trim.Remove(0, 6);
                    permisos = permisos + permiso;
                }
            }
            if(permisos.Last().Equals(','))
            {
                permisos = permisos.Remove(permisos.Length - 1);
            }
            Console.WriteLine(permisos);
            permisosFrm = permisos;
            Close();
        }

        private void LlenarListaPermisosExistentes()
        {
            string[] array = permisosFrm.Split(',');
            for (int i = 0; i < clbPermisos.Items.Count; i++)
            {
                for(int j = 0; j < array.Length;j++)
                {
                    if (clbPermisos.Items[i].ToString().Contains(array[j]))
                    {
                        clbPermisos.SetItemChecked(i, true);
                    }
                }
            }
        }

        private void cbSeleccionarTodo_CheckedChanged(object sender, EventArgs e)
        {
            if(cbSeleccionarTodo.Checked!=false)
            {
                for (int i = 0; i < clbPermisos.Items.Count; i++)
                {
                        clbPermisos.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < clbPermisos.Items.Count; i++)
                {
                    clbPermisos.SetItemChecked(i, false);
                }
            }
        }
    }
}
