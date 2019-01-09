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
    public partial class Recepcion2 : Form
    {
        public Recepcion2()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Recepcion4 frmobj = new Recepcion4();
            frmobj.ShowDialog();
        }
    }
}
