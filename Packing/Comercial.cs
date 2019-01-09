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
using Clases.Impresion;
using System.Drawing.Printing;

namespace Packing
{
    public partial class Comercial : Form
    {
        private E_Usuario sesion { set; get; }
        public Comercial(E_Usuario usuario)
        {
            InitializeComponent();
            sesion = usuario;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        N_Cliente cliente1 = new N_Cliente();
        N_Productor producto1 = new N_Productor();
        N_Especie especie1 = new N_Especie();
        N_Bandeja bandeja1 = new N_Bandeja();
        N_Pallet pallet1 = new N_Pallet();
        N_Comercial comercial1 = new N_Comercial();
        N_TipoComercial tipoComercial1 = new N_TipoComercial();
       
        private void Comercial_Load(object sender, EventArgs e)
        {
            
            cmbCliente.DataSource = cliente1.Lista();
            cmbCliente.DisplayMember = "cliente";
            cmbCliente.ValueMember = "codigo";
            cmbCliente.SelectedIndex = -1;
            cmbCliente.MaxDropDownItems = 10;

            cmbEspecie.DataSource = especie1.Lista();
            cmbEspecie.DisplayMember = "descripcion";
            cmbEspecie.ValueMember = "codigo";
            cmbEspecie.SelectedIndex = -1;

            cmbTipo.DataSource = tipoComercial1.Lista();
            cmbTipo.DisplayMember = "descripcion";
            cmbTipo.ValueMember = "ID";
            cmbTipo.SelectedIndex = -1;

            lblUsuario.Text = "Usuario Activo: " + sesion.Usuario;

            LlenarCombosGenericos();
        }

        void LlenarCombosGenericos()
        {

            cmbBandeja.DataSource = bandeja1.Lista();
            cmbBandeja.DisplayMember = "descripcion";
            cmbBandeja.ValueMember = "codigo";
            cmbBandeja.SelectedIndex = -1;

            cmbTipoPallet.DataSource = pallet1.Lista();
            cmbTipoPallet.DisplayMember = "descripcion";
            cmbTipoPallet.ValueMember = "codigo";
            cmbTipoPallet.SelectedIndex = -1;

        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedIndex == -1)
                return;
            cmbProductor.DataSource = producto1.Lista(cmbCliente.SelectedValue.ToString());
            cmbProductor.DisplayMember = "descripcion";
            cmbProductor.ValueMember = "codigo";
            cmbProductor.SelectedIndex = -1;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToString("s");

            //    T Format Specifier      de-DE Culture                                 17:04:32
            //    T Format Specifier      en-US Culture                               5:04:32 PM
            //    T Format Specifier      es-ES Culture                                 17:04:32
            //    T Format Specifier      fr-FR Culture                                 17:04:32
            string hora = DateTime.Now.ToString("T");

            double pesoBandeja = 0;
            double pesoPallet = 0;
            double tara,pesoNeto,peso_promedio;

            N_Bandeja bandeja1 = new N_Bandeja();
            N_Pallet pallet1 = new N_Pallet();

            pesoBandeja = bandeja1.Peso(cmbBandeja.SelectedValue.ToString());
            pesoPallet = pallet1.Peso(cmbTipoPallet.SelectedValue.ToString());
            tara = (pesoBandeja * Convert.ToInt32(txtCantidadBandejas.Text)) + pesoPallet;
            pesoNeto = Convert.ToDouble(txtKilos.Text) - tara;
            peso_promedio = pesoNeto / Convert.ToInt32(txtCantidadBandejas.Text);

            comercial1.Detalle = new E_Comercial();
            comercial1.Detalle.ID_Cliente = cmbCliente.SelectedValue.ToString();
            comercial1.Detalle.Cliente = cmbCliente.Text.ToString();
            comercial1.Detalle.ID_Productor = cmbProductor.SelectedValue.ToString();
            comercial1.Detalle.Productor = cmbProductor.Text.ToString();
            comercial1.Detalle.ID_Tipo = cmbTipo.SelectedValue.ToString();
            comercial1.Detalle.Tipo = cmbTipo.Text.ToString();
            comercial1.Detalle.Total_Pallet = Convert.ToInt32(txtTotalPallet.Text);
            comercial1.Detalle.ID_Bandeja = cmbBandeja.SelectedValue.ToString();
            comercial1.Detalle.Bandeja = cmbBandeja.Text.ToString();
            comercial1.Detalle.ID_Pallet = cmbTipoPallet.SelectedValue.ToString();
            comercial1.Detalle.Pallet = cmbTipoPallet.Text.ToString();
            comercial1.Detalle.Fecha = fecha;
            comercial1.Detalle.ID_Especie = cmbEspecie.SelectedValue.ToString();
            comercial1.Detalle.Especie = cmbEspecie.Text.ToString();
            comercial1.Detalle.Kilos_Brutos = Convert.ToDouble(txtKilos.Text);
            comercial1.Detalle.Cantidad_Bandejas = Convert.ToInt32(txtCantidadBandejas.Text);
            comercial1.Detalle.Folio = txtFolio.Text;
            comercial1.Detalle.Tara = tara;
            comercial1.Detalle.Kilos_Netos = pesoNeto;

            if (!comercial1.Validacion_Folio())
            {
                bool estado = comercial1.Agregar();
                if (estado == true)
                {
                    Imprimir_Comercial(comercial1.Detalle, hora, pesoPallet.ToString(), peso_promedio.ToString(), pesoBandeja.ToString());
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Error al Guardar Datos " + comercial1.Mensaje);
                    Limpiar();
                }
            }
            else
            {
                MessageBox.Show(comercial1.Mensaje);
                txtFolio.Text = string.Empty;
                txtFolio.Focus();
            }

        }

        private void Imprimir_Comercial(E_Comercial detalle_comercial,string hora,string pesopallet,string pesopromedio,string pesobandeja)
        {
            N_Imprimir imprimir = new N_Imprimir();
            N_Recepcion_Encabezado encabezado = new N_Recepcion_Encabezado()
            {
                Chofer = detalle_comercial.Tipo,
                Codigo_productor = detalle_comercial.ID_Productor,
                Correlativo = "",
                Exportador = detalle_comercial.Cliente,
                Fecha = DateTime.Now.ToString("dd/MM/yyyy"),
                Guia_despacho = "",
                Hora = DateTime.Now.ToString("h:mm:ss tt"),
                Productor = detalle_comercial.Productor,
                Especie = detalle_comercial.Especie,
                Responsable = sesion.Nombre + " " + sesion.Apellido
            };
            N_Recepcion_Detalle detalle = new N_Recepcion_Detalle()
            {
                Cantidad = detalle_comercial.Cantidad_Bandejas.ToString(),
                Comentario = "",
                Descarga = "",
                Destino = "",
                Folio = detalle_comercial.Folio,
                Hora_recepcion = hora,
                Kilos_brutos = detalle_comercial.Kilos_Brutos.ToString(),
                Tara = detalle_comercial.Tara.ToString(),
                Kilos_netos = detalle_comercial.Kilos_Netos.ToString(),
                Numero_lote = "",
                Peso_pallet = pesopallet,
                Peso_promedio = pesopromedio,
                Peso_rejillas = pesobandeja,
                Responsable = sesion.Nombre + " " + sesion.Apellido,
                Sub_lote = "",
                Temperatura = "",
                Tipo_rejilla_bandeja = detalle_comercial.Bandeja
            };
            N_Coordenadas_Impresion coordenadas = new N_Coordenadas_Impresion()
            {
                PosicionX = "-3",
                PosicionY = "0"
            };
            imprimir.Detalle = detalle;
            imprimir.Encabezado = encabezado;
            imprimir.Fuente = new Font("Verdana", 10);
            imprimir.Coordenadas_impresion = coordenadas;
            PrintDocument pd = new PrintDocument();

            pd.PrintPage += new PrintPageEventHandler(imprimir.PrintTextFileHandlerComercial);
            pd.DefaultPageSettings.PrinterSettings.PrinterName = N_Impresora.Nombre;
            if (pd.PrinterSettings.IsValid)
            {
                pd.Print();
            }
            else
            {
                MessageBox.Show("Impresora " + N_Impresora.Nombre + " no esta instalada");
                return;
            }
            //para utilizar con printdialog
            //printDialog1.Document = pd;
            //Llamar al printDialog 
            //if (printDialog1.ShowDialog() == DialogResult.OK) pd.Print();
        }

        private void Limpiar()
        {
            cmbBandeja.SelectedIndex = -1;
            cmbTipoPallet.SelectedIndex = -1;
            txtKilos.Text = string.Empty;
            txtCantidadBandejas.Text = string.Empty;
            txtFolio.Text = string.Empty;
            cmbBandeja.Focus();
        }

    }
}
