using Entity;
using Negocio;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Packing
{
    public partial class frmImpresora : Form
    {
        private E_Usuario sesion { get; set; }
        public frmImpresora(E_Usuario usuario)
        {
            InitializeComponent();
            sesion = usuario;
        }

        private void frmImpresora_Load(object sender, EventArgs e)
        {
            string nombreImpresora= "";
            NameValueCollection settings = ConfigurationManager.GetSection("ImpresorasGroup/Impresora") as NameValueCollection;

            if (settings != null)
            {
                foreach (string key in settings.AllKeys)
                {
                    Console.Write(key + ": " + settings[key]);
                    nombreImpresora = key;
                }

                txtImpresora.Text = nombreImpresora;
            }


            cbImpresoras.DataSource = ListaImpresoras();
            cbImpresoras.SelectedIndex = -1;
        }

        private void btnCambiarImpresora_Click(object sender, EventArgs e)
        {
            if (cbImpresoras.Text.Trim() == "")
            {
                MessageBox.Show("Seleccione una impresora", "");
                cbImpresoras.Focus();
                return;
            }
            //DialogResult result = pdSeleccionImpresora.ShowDialog();
            NameValueCollection settings = ConfigurationManager.GetSection("ImpresorasGroup/Impresora") as NameValueCollection;

            string key = txtImpresora.Text;
            string nueva = cbImpresoras.Text;
            string value = "true";

            // Remove printer from app.config
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            XmlNode nodePrint = xmlDoc.SelectSingleNode("//ImpresorasGroup/Impresora/add[@key='" + key + "']");
            nodePrint.ParentNode.RemoveChild(nodePrint);

            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("ImpresorasGroup/Impresora");

            // Add printer to app.config
            var xmlDoc2 = new XmlDocument();
            xmlDoc2.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            // create new node <add key="" value="" />

            var nodeRegion = xmlDoc2.CreateElement("add");
            nodeRegion.SetAttribute("key", nueva);
            nodeRegion.SetAttribute("value", value);

            xmlDoc2.SelectSingleNode("//ImpresorasGroup/Impresora").AppendChild(nodeRegion);
            xmlDoc2.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            ConfigurationManager.RefreshSection("ImpresorasGroup/Impresora");

            frmImpresora_Load(sender, e);
        }

        private List<string> ListaImpresoras()
        {
            List<string> lista = new List<string>();
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                lista.Add(printer);
            }

            return lista;
        }
    }
}
