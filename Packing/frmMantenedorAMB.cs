using Entity;
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
    public partial class frmMantenedorAMB : Form
    {
        public frmMantenedorAMB()
        {
            InitializeComponent();
        }

        private void frmMantenedorAMB_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            Importar();
        }


        #region Metodos virtuales
        public virtual void Agregar()
        {

        }

        public virtual void Modificar()
        {

        }

        public virtual void Borrar()
        {

        }

        public virtual void Importar()
        {

        }

        #endregion

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Borrar();
        }
    }
}
