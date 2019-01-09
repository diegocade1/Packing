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


namespace Packing
{
    public partial class Recepcion : Form
    {
        public Recepcion()
        {
            InitializeComponent();
        }
        N_Cliente cliente1 = new N_Cliente();
        N_Productor producto1 = new  N_Productor();


        private void Recepcion_Load(object sender, EventArgs e)
        {
           

            cmbCliente .DataSource = cliente1.Lista();
            cmbCliente.DisplayMember = "descripcion";
            cmbCliente.ValueMember = "codigo";

        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbProductor.DataSource = producto1.Lista2(cmbCliente .SelectedValue.ToString());
            cmbProductor.DisplayMember = "descripcion";
            cmbProductor.ValueMember = "codigo";
            cmbProductor.SelectedIndex = -1;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Recepcion2 frmObj = new Recepcion2();
            frmObj.ShowDialog();
        }
    }
}
