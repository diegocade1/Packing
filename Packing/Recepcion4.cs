using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entity;
using Clases.Impresion;


namespace Packing
{
    public partial class Recepcion4 : Form
    {
        string Mensaje { get; set; }

        public Recepcion4()
        {
            InitializeComponent();
        }

        N_Cliente cliente1 = new N_Cliente();
        N_Productor producto1 = new N_Productor();
        N_Especie especie1 = new N_Especie();
        N_Recepcion recepcion1 = new N_Recepcion();
        N_Bandeja bandeja1 = new N_Bandeja();
        N_Pallet pallet1 = new N_Pallet();

        private void Recepcion4_Load(object sender, EventArgs e)
        {

            cmbCliente.DataSource = cliente1.Lista();
            cmbCliente.DisplayMember = "cliente";
            cmbCliente.ValueMember = "codigo";
            cmbCliente.SelectedIndex = -1;

            cmbEspecie.DataSource = especie1.Lista();
            cmbEspecie.DisplayMember = "descripcion";
            cmbEspecie.ValueMember = "codigo";
            cmbEspecie.SelectedIndex = -1;

            //dgvLista.Columns.Add("item", "Item");
            //dgvLista.Columns.Add ("kilos_Brutos","Kilos Brutos");
            //dgvLista.Columns.Add("ID_Bandeja", "ID Bandeja");
            //dgvLista.Columns.Add("tipo_Bandeja", "Tipo Bandeja");
            //dgvLista.Columns.Add("peso_Bandeja", "Peso Bandeja");
            //dgvLista .Columns.Add ("cantidad_bandejas","Cantidad Bandejas");
            //dgvLista.Columns.Add("tara", "Tara");
            //dgvLista.Columns.Add("folio", "Folio");
            //dgvLista.Columns.Add("ID_Pallet", "ID Pallet");            
            //dgvLista.Columns.Add("tipo_Pallet", "Tipo Pallet");
            //dgvLista.Columns.Add("peso_Pallet", "Peso Pallet");
            //dgvLista.Columns.Add("kilos_netos", "Kilos Netos");
                                                     
            LlenarCombosGenericos();

        }

        void LlenarCombosGenericos()
        {
            
            cmbDescarga.DataSource = recepcion1.Lista_Descarga();
            cmbDescarga.DisplayMember = "descripcion";
            cmbDescarga.ValueMember = "codigo";
            cmbDescarga.SelectedIndex = -1;

            cmbDestino.DataSource = recepcion1.Lista_Destino();
            cmbDestino.DisplayMember = "descripcion";
            cmbDestino.ValueMember = "codigo";
            cmbDestino.SelectedIndex = -1;           
                        
            cmbBandeja.DataSource = bandeja1.Lista();
            cmbBandeja.DisplayMember = "descripcion";
            cmbBandeja.ValueMember = "codigo";
            cmbBandeja.SelectedIndex = -1;

            cmbTipoPallet.DataSource = pallet1.Lista();
            cmbTipoPallet.DisplayMember = "descripcion";
            cmbTipoPallet.ValueMember = "codigo";
            cmbTipoPallet.SelectedIndex = -1;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtKilos.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Kilos", "");
                txtKilos.Focus();
                return;
            }
            if (txtCantidadBandejas.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Cantidad Bandejas", "");
                txtCantidadBandejas.Focus();
                return;
            }
            if (cmbTipoPallet.Text.Trim() == "")
            {
                MessageBox.Show("Seleccione Tipo Pallet", "");
                cmbTipoPallet.Focus();
                return;
            }

            double pesoBandeja = 0;
            double pesoPallet = 0;
            double tara, pesoNeto;

            N_Bandeja bandeja1 = new N_Bandeja();
            N_Pallet pallet1 = new N_Pallet();

            pesoBandeja = bandeja1.Peso(cmbBandeja.SelectedValue.ToString());
            pesoPallet = pallet1.Peso(cmbTipoPallet.SelectedValue.ToString());
            tara = (pesoBandeja * Convert.ToInt32(txtCantidadBandejas.Text)) + pesoPallet;
            pesoNeto = Convert.ToDouble(txtKilos.Text) - tara;
            //    G Format Specifier      de-DE Culture                      01.10.2008 17:04:32
            //    G Format Specifier      en-US Culture                     10/1/2008 5:04:32 PM
            //    G Format Specifier      es-ES Culture                      01/10/2008 17:04:32
            //    G Format Specifier      fr-FR Culture                      01/10/2008 17:04:32
            //    s Format Specifier      de-DE Culture                      2008-10-01T17:04:32
            //    s Format Specifier      en-US Culture                      2008-10-01T17:04:32
            //    s Format Specifier      es-ES Culture                      2008-10-01T17:04:32
            //    s Format Specifier      fr-FR Culture                      2008-10-01T17:04:32
            //string fecha = DateTime.Now.ToString("G");
            string fecha = DateTime.Now.ToString("s");

            //    T Format Specifier      de-DE Culture                                 17:04:32
            //    T Format Specifier      en-US Culture                               5:04:32 PM
            //    T Format Specifier      es-ES Culture                                 17:04:32
            //    T Format Specifier      fr-FR Culture                                 17:04:32
            string hora = DateTime.Now.ToString("T");
            Random rnd = new Random();

            int lote = rnd.Next(1, 99999);
            recepcion1.Encabezado = new E_Recepcion_Encabezado();
            recepcion1.Encabezado.Cliente = cmbCliente.Text.ToString();
            recepcion1.Encabezado.ID_Cliente = cmbCliente.SelectedValue.ToString();
            recepcion1.Encabezado.Productor = cmbProductor.Text.ToString();
            recepcion1.Encabezado.Codigo_Productor = cmbProductor.SelectedValue.ToString();
            recepcion1.Encabezado.Chofer = txtChofer.Text;
            recepcion1.Encabezado.Guia = txtGuia.Text;
            recepcion1.Encabezado.ID_Especie = cmbEspecie.SelectedValue.ToString();
            recepcion1.Encabezado.Especie = cmbEspecie.Text.ToString();
            recepcion1.Encabezado.ID_Descarga = cmbDescarga.SelectedValue.ToString();
            recepcion1.Encabezado.Descarga = cmbDescarga.Text.ToString();
            recepcion1.Encabezado.Temperatura = txtTemperatura.Text;
            recepcion1.Encabezado.ID_Destino = cmbDestino.SelectedValue.ToString();
            recepcion1.Encabezado.Destino = cmbDestino.Text.ToString();

            recepcion1.Encabezado.Fecha = fecha;
            recepcion1.Encabezado.Hora = hora;
            recepcion1.Encabezado.Lote = lote.ToString();

            bool estado = recepcion1.Agregar_Encabezado();


            if (estado == true)
            {
                int ID = recepcion1.UltimoID;

                //DataGridViewRow row = dgvLista.Rows[i];
                recepcion1.Detalle = new E_Recepcion_Detalle();
                recepcion1.Detalle.ID_Recepcion = ID.ToString();
                //recepcion1.Detalle.Item = row.Cells["item"].Value.ToString();
                recepcion1.Detalle.ID_bandeja = cmbBandeja.SelectedValue.ToString();
                recepcion1.Detalle.Bandeja = cmbBandeja.Text.ToString();
                recepcion1.Detalle.Peso_Bandeja = pesoBandeja.ToString();
                recepcion1.Detalle.Cantidad_Bandejas = txtCantidadBandejas.Text;
                recepcion1.Detalle.Folio = txtFolio.Text;
                recepcion1.Detalle.Kilos_Brutos = txtKilos.Text;
                recepcion1.Detalle.Tara = tara.ToString();
                recepcion1.Detalle.Kilos_Netos = pesoNeto.ToString();
                recepcion1.Detalle.ID_Pallet = cmbTipoPallet.SelectedValue.ToString();
                recepcion1.Detalle.Tipo_Pallet = cmbTipoPallet.Text;
                recepcion1.Detalle.Peso_Pallet = pesoPallet.ToString();

                recepcion1.Agregar_Detalle("recepcion");
                Imprimir_Recepcion(recepcion1.Encabezado, recepcion1.Detalle);

            }

            //AgregarGrilla2();
            txtKilos.Text = "";
            txtCantidadBandejas.Text = "";
            cmbBandeja.Focus();
            cmbBandeja.SelectedIndex = -1;
            cmbTipoPallet.SelectedIndex = -1;
            txtFolio.Text = "";
        }


        //private void AgregarGrilla2()
        //{
        //    int rowNuevo;
        //    double pesoBandeja=0;
        //    double pesoPallet = 0;
        //    double tara,pesoNeto;

        //    N_Bandeja bandeja1 = new N_Bandeja();
        //    N_Pallet pallet1 = new N_Pallet();

        //    pesoBandeja = bandeja1.Peso(cmbBandeja.SelectedValue.ToString());
        //    pesoPallet = pallet1.Peso(cmbTipoPallet.SelectedValue.ToString());

        //    rowNuevo = 0; //dgvLista.Rows.Count;


        //    dgvLista.Rows[rowNuevo].Cells["kilos_Brutos"].Value = txtKilos.Text;
        //    dgvLista.Rows[rowNuevo].Cells["ID_Bandeja"].Value = cmbBandeja.SelectedValue;
        //    dgvLista.Rows[rowNuevo].Cells["tipo_Bandeja"].Value = cmbBandeja.Text;
        //    dgvLista.Rows[rowNuevo].Cells["peso_bandeja"].Value = pesoBandeja;
        //    dgvLista.Rows[rowNuevo].Cells["cantidad_bandejas"].Value = txtCantidadBandejas.Text;
        //    tara = (pesoBandeja * Convert.ToInt32(txtCantidadBandejas.Text)) + pesoPallet;
        //    dgvLista.Rows[rowNuevo].Cells["tara"].Value = tara;
        //    dgvLista.Rows[rowNuevo].Cells["folio"].Value = txtFolio.Text;
        //    dgvLista.Rows[rowNuevo].Cells["ID_Pallet"].Value = cmbTipoPallet.SelectedValue;
        //    dgvLista.Rows[rowNuevo].Cells["tipo_Pallet"].Value = cmbTipoPallet.Text;
        //    dgvLista.Rows[rowNuevo].Cells["peso_Pallet"].Value = pesoPallet;
        //    pesoNeto = Convert.ToDouble(txtKilos.Text) - tara;
        //    dgvLista.Rows[rowNuevo].Cells["kilos_netos"].Value =pesoNeto;
        //  //  dgvLista.Rows[rowNuevo].Cells["numero_pallet"].Value = (dgvLista.Rows.Count);
        //    dgvLista.Rows [0].Selected = true;          


        //}

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
            double pesoBandeja = 0;
            double pesoPallet = 0;
            double tara, pesoNeto;

            N_Bandeja bandeja1 = new N_Bandeja();
            N_Pallet pallet1 = new N_Pallet();

            pesoBandeja = bandeja1.Peso(cmbBandeja.SelectedValue.ToString());
            pesoPallet = pallet1.Peso(cmbTipoPallet.SelectedValue.ToString());
            tara = (pesoBandeja * Convert.ToInt32(txtCantidadBandejas.Text)) + pesoPallet;
            pesoNeto = Convert.ToDouble(txtKilos.Text) - tara;
            //    G Format Specifier      de-DE Culture                      01.10.2008 17:04:32
            //    G Format Specifier      en-US Culture                     10/1/2008 5:04:32 PM
            //    G Format Specifier      es-ES Culture                      01/10/2008 17:04:32
            //    G Format Specifier      fr-FR Culture                      01/10/2008 17:04:32
            //    s Format Specifier      de-DE Culture                      2008-10-01T17:04:32
            //    s Format Specifier      en-US Culture                      2008-10-01T17:04:32
            //    s Format Specifier      es-ES Culture                      2008-10-01T17:04:32
            //    s Format Specifier      fr-FR Culture                      2008-10-01T17:04:32
            //string fecha = DateTime.Now.ToString("G");
            string fecha = DateTime.Now.ToString("s");

            //    T Format Specifier      de-DE Culture                                 17:04:32
            //    T Format Specifier      en-US Culture                               5:04:32 PM
            //    T Format Specifier      es-ES Culture                                 17:04:32
            //    T Format Specifier      fr-FR Culture                                 17:04:32
            string hora = DateTime.Now.ToString("T");
            Random rnd = new Random();

            int lote = rnd.Next(1, 99999);
            recepcion1.Encabezado = new E_Recepcion_Encabezado();
            recepcion1.Encabezado.Cliente = cmbCliente.Text.ToString();
            recepcion1.Encabezado.ID_Cliente = cmbCliente.SelectedValue.ToString();
            recepcion1.Encabezado.Productor = cmbProductor.Text.ToString();
            recepcion1.Encabezado.Codigo_Productor = cmbProductor.SelectedValue.ToString();
            recepcion1.Encabezado.Chofer = txtChofer.Text;
            recepcion1.Encabezado.Guia = txtGuia.Text;
            recepcion1.Encabezado.ID_Especie = cmbEspecie.SelectedValue.ToString();
            recepcion1.Encabezado.Especie = cmbEspecie.Text.ToString();
            recepcion1.Encabezado.ID_Descarga = cmbDescarga.SelectedValue.ToString();
            recepcion1.Encabezado.Descarga = cmbDescarga.Text.ToString();
            recepcion1.Encabezado.Temperatura = txtTemperatura.Text;
            recepcion1.Encabezado.ID_Destino = cmbDestino.SelectedValue.ToString();
            recepcion1.Encabezado.Destino = cmbDestino.Text.ToString();

            recepcion1.Encabezado.Fecha = fecha;
            recepcion1.Encabezado.Hora = hora;
            recepcion1.Encabezado.Lote = lote.ToString();           

           bool estado =  recepcion1.Agregar_Encabezado();

           
            if (estado == true)
            {
                int ID = recepcion1.UltimoID;

                    //DataGridViewRow row = dgvLista.Rows[i];
                    recepcion1.Detalle = new E_Recepcion_Detalle();
                    recepcion1.Detalle.ID_Recepcion = ID.ToString();
                    //recepcion1.Detalle.Item = row.Cells["item"].Value.ToString();
                    recepcion1.Detalle.ID_bandeja = cmbBandeja.SelectedValue.ToString();
                    recepcion1.Detalle.Bandeja = cmbBandeja.Text.ToString();
                    recepcion1.Detalle.Peso_Bandeja = pesoBandeja.ToString();
                    recepcion1.Detalle.Cantidad_Bandejas = txtCantidadBandejas.Text;
                    recepcion1.Detalle.Folio = txtFolio.Text;
                    recepcion1.Detalle.Kilos_Brutos = txtKilos.Text;
                    recepcion1.Detalle.Tara = tara.ToString();
                    recepcion1.Detalle.Kilos_Netos = pesoNeto.ToString();
                    recepcion1.Detalle.ID_Pallet = cmbTipoPallet.SelectedValue.ToString();
                    recepcion1.Detalle.Tipo_Pallet = cmbTipoPallet.Text;
                    recepcion1.Detalle.Peso_Pallet = pesoPallet.ToString();
                    
                    recepcion1.Agregar_Detalle("recepcion");
                    Imprimir_Recepcion(recepcion1.Encabezado, recepcion1.Detalle);
                           
            }
            
        }

        private void Imprimir_Recepcion(E_Recepcion_Encabezado encabezado_recepcion,E_Recepcion_Detalle detalle_recepcion)
        {
            N_Imprimir imprimir = new N_Imprimir();
            N_Recepcion_Encabezado  encabezado = new N_Recepcion_Encabezado()
            {
                Chofer = encabezado_recepcion.Chofer,
                Codigo_productor = encabezado_recepcion.Codigo_Productor,
                Correlativo = encabezado_recepcion.Lote,
                Exportador = encabezado_recepcion.Cliente,
                Fecha = encabezado_recepcion.Fecha,
                Guia_despacho = encabezado_recepcion.Guia,
                Hora = encabezado_recepcion.Hora,
                Productor = encabezado_recepcion.Productor,
                Especie = encabezado_recepcion.Especie,
                Responsable = encabezado_recepcion.Responsable

            };
            N_Recepcion_Detalle  detalle = new N_Recepcion_Detalle()
            {
                Cantidad = detalle_recepcion.Cantidad_Bandejas,
                Comentario = detalle_recepcion.Comentario,
                Descarga = encabezado_recepcion.Descarga,
                Destino = encabezado_recepcion.Destino,
                Folio = detalle_recepcion.Folio,
                Hora_recepcion = detalle_recepcion.Hora,
                Kilos_brutos = detalle_recepcion.Kilos_Brutos,
                Tara = detalle_recepcion.Tara,
                Kilos_netos = detalle_recepcion.Kilos_Netos,
                Numero_lote = encabezado_recepcion.Lote,
                Peso_pallet = detalle_recepcion.Peso_Pallet,
                Peso_promedio = "*promedio*",
                Peso_rejillas = detalle_recepcion.Peso_Bandeja,
                Responsable = encabezado_recepcion.Responsable,
                Sub_lote = "*sublote*",                
                Temperatura = encabezado_recepcion.Temperatura,
                Tipo_rejilla_bandeja = detalle_recepcion.Bandeja
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

            pd.PrintPage += new PrintPageEventHandler(imprimir.PrintTextFileHandlerRecepcion);
            pd.DefaultPageSettings.PrinterSettings.PrinterName = N_Impresora.Nombre;
            if (pd.PrinterSettings.IsValid)
            {
                pd.Print();
            }
            else
            {
                MessageBox.Show ("Impresora " + N_Impresora.Nombre + " no esta instalada");
                return;
            }
            //para utilizar con printdialog
            //printDialog1.Document = pd;
             //Llamar al printDialog 
            //if (printDialog1.ShowDialog() == DialogResult.OK) pd.Print();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmMantenedorCliente frmobj = new frmMantenedorCliente();
            //frmobj.ShowDialog();

        }

        private void mantenedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
