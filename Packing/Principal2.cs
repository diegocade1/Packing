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
    public partial class Principal2 : Form
    {
        public Principal2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Recepcion4 frmObj = new Recepcion4();
            frmObj.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            //Exportacion frmObj = new Exportacion();
            //frmObj.ShowDialog();
            this.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Reportes frmObj = new Reportes();
            frmObj.ShowDialog();
            this.Visible = true;
        }
    }
}
