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
    public partial class MDIContenedorPrincipal : Form
    {
        private int childFormNumber = 0;

        public E_Usuario Usuario { get; set; }

        public MDIContenedorPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void viewMenu_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenedorCliente frmobj = new frmMantenedorCliente(Usuario);
            frmobj.MdiParent = this;
            frmobj.Show(); 
        }

        private void recepcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recepcion4 frmobj = new Recepcion4();
            //frmobj.MdiParent = this;
            frmobj.Show();
        }

        private void especieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenedorEspecie frmobj = new MantenedorEspecie(Usuario);
            frmobj.MdiParent = this;
            frmobj.Show();
        }

        private void MDIContenedorPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + " " + Usuario.Usuario;
            N_Impresora.Nombre = "Microsoft Print to PDF";
            //N_Impresora.Nombre = "OKI DATA CORP ML320/1TURBO";
        }

        private void exportacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Exportacion frmObj = new Exportacion(Usuario);
            frmObj.ShowDialog();
            this.Visible = true;
        }

        private void maquilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Maquila frmObj = new Maquila(Usuario);
            frmObj.ShowDialog();
            this.Visible = true;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Recepcion5 frmObj = new Recepcion5(Usuario);
            frmObj.ShowDialog();
            this.Visible = true;
        }

        private void procesosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Exportacion frmObj = new Exportacion(Usuario);
            frmObj.ShowDialog();
            this.Visible = true;
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Maquila frmObj = new Maquila(Usuario);
            frmObj.ShowDialog();
            this.Visible = true;
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Comercial frmObj = new Comercial(Usuario);
            frmObj.ShowDialog();
            this.Visible = true;
        }

        private void tipoComercialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenedorTipoComercial frmObj = new frmMantenedorTipoComercial(Usuario);
            frmObj.MdiParent = this;
            frmObj.Show();
        }

        private void subloteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubLote frmobj = new frmSubLote(Usuario);
            frmobj.ShowDialog();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenedorUsuario frmObj = new frmMantenedorUsuario(Usuario);
            frmObj.MdiParent = this;
            frmObj.Show();
        }

        private void descargaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMantenedorDescarga frmObj = new frmMantenedorDescarga(Usuario);
            frmObj.MdiParent = this;
            frmObj.Show();
        }

        private void destinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenedorDestino frmObj = new frmMantenedorDestino(Usuario);
            frmObj.MdiParent = this;
            frmObj.Show();
        }

        private void bandejasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenedorBandeja frmObj = new frmMantenedorBandeja(Usuario);
            frmObj.MdiParent = this;
            frmObj.Show();
        }

        private void palletsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenedorPallet frmObj = new frmMantenedorPallet(Usuario);
            frmObj.MdiParent = this;
            frmObj.Show();
        }

        private void tipoDeRecepcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenedorTipoRecepcion frmObj = new frmMantenedorTipoRecepcion(Usuario);
            frmObj.MdiParent = this;
            frmObj.Show();
        }

        private void cajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenedorEmbalaje frmObj = new frmMantenedorEmbalaje(Usuario);
            frmObj.MdiParent = this;
            frmObj.Show();
        }

        private void etiquetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenedorEtiqueta frmObj = new frmMantenedorEtiqueta(Usuario);
            frmObj.MdiParent = this;
            frmObj.Show();
        }

        private void productorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenedorProductor frmObj = new frmMantenedorProductor(Usuario);
            frmObj.MdiParent = this;
            frmObj.Show();
        }

        private void mercadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenedorTipoMercado frmObj = new frmMantenedorTipoMercado(Usuario);
            frmObj.MdiParent = this;
            frmObj.Show();
        }

        private void tipoDeArmadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenedorTipoArmado frmObj = new frmMantenedorTipoArmado(Usuario);
            frmObj.MdiParent = this;
            frmObj.Show();
        }

        private void embalajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenedorEmbalaje frmObj = new frmMantenedorEmbalaje(Usuario);

        }

        private void windowsMenu_Click(object sender, EventArgs e)
        {

        }

        private void variedadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenedorVariedad frmObj = new frmMantenedorVariedad(Usuario);
            frmObj.MdiParent = this;
            frmObj.Show();
        }
    }
}
