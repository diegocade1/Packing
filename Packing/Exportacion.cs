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
    public partial class Exportacion : Form
    {
        private E_Usuario sesion { set; get; }
        public Exportacion(E_Usuario usuario)
        {
            InitializeComponent();
            sesion = usuario;
        }
        N_Cliente cliente1 = new N_Cliente();
        N_Productor productor1 = new N_Productor();
        N_Especie especie1 = new N_Especie();
        N_Embalaje embalaje1 = new N_Embalaje();
        N_TipoArmado armado1 = new N_TipoArmado();
        N_Variedad variedad1 = new N_Variedad();
        N_TipoMercado tipoMercado1 = new N_TipoMercado();
        N_Etiqueta etiqueta1 = new N_Etiqueta();
        N_Exportacion exportacion1 = new N_Exportacion();
        //------
        N_Recepcion recepcion1 = new N_Recepcion();
        N_Comercial comercial1 = new N_Comercial();

        private void Exportacion_Load(object sender, EventArgs e)
        {

            cmbCliente.DataSource = cliente1.Lista();
            cmbCliente.DisplayMember = "cliente";
            cmbCliente.ValueMember = "codigo";
            cmbCliente.SelectedIndex = -1;

            cmbEspecie.DataSource = especie1.Lista();
            cmbEspecie.DisplayMember = "descripcion";
            cmbEspecie.ValueMember = "codigo";
            cmbEspecie.SelectedIndex = -1;

            dgvLista.Columns.Add("item", "Item");
            dgvLista.Columns.Add("fecha", "Fecha");
            dgvLista.Columns.Add("ID_productor", "ID Productor");
            dgvLista.Columns.Add("productor", "Productor");
            dgvLista.Columns.Add("ID_variedad", "ID Variedad");
            dgvLista.Columns.Add("variedad", "Variedad");
            dgvLista.Columns.Add("cantidad_bandejas", "Cantidad Cajas");
            dgvLista.Columns.Add("documento", "Documento");
            

            LlenarCombosGenericos();

            lblUsuario.Text = "Usuario Activo: " + sesion.Usuario;

            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = "";
            
        }

        void LlenarCombosGenericos()
        {
                        
            cmbEmbalaje.DataSource = embalaje1.Lista();
            cmbEmbalaje.DisplayMember = "descripcion";
            cmbEmbalaje.ValueMember = "ID";
            cmbEmbalaje.SelectedIndex = -1;

            cmbTipoArmado.DataSource = armado1.Lista();
            cmbTipoArmado.DisplayMember = "descripcion";
            cmbTipoArmado.ValueMember = "codigo";
            cmbTipoArmado.SelectedIndex = -1;                               

            cmbTipoMercado.DataSource = tipoMercado1.Lista();
            cmbTipoMercado.DisplayMember = "descripcion";
            cmbTipoMercado.ValueMember = "codigo";
            cmbTipoMercado.SelectedIndex = -1;

            cmbEtiqueta.DataSource = etiqueta1.Lista();
            cmbEtiqueta.DisplayMember = "descripcion";
            cmbEtiqueta.ValueMember = "codigo";
            cmbEtiqueta.SelectedIndex = -1;
            
            cmbVariedad.DataSource = variedad1.Lista();
            cmbVariedad.DisplayMember = "descripcion";
            cmbVariedad.ValueMember = "codigo";
            cmbVariedad.SelectedIndex = -1;

            // cmbEtiqueta.Items.Insert(0, "Berry Fresh 1");
            // cmbEtiqueta.Items.Insert(1, "Berry Fresh 2");
            // cmbEtiqueta.Items.Insert(2, "Berry Fresh 3");

            // cmbVariedad.Items.Insert(0, "Emeral 01");
            //cmbVariedad.Items.Insert(1, "Emeral 02");
            //cmbVariedad.Items.Insert(2, "Emeral 03");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dtpFecha.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Fecha", "");
                dtpFecha.Focus();
                return;
            }
            if (cmbProductor.Text.Trim() == "")
            {
                MessageBox.Show("Seleccione Productor", "");
                cmbProductor.Focus();
                return;
            }
            if (cmbVariedad.Text.Trim() == "")
            {
                MessageBox.Show("Seleccione Variedad", "");
                cmbVariedad.Focus();
                return;
            }
            if (txtCantidadBandejas.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Cantidad Bandejas", "");
                txtCantidadBandejas.Focus();
                return;
            }
            if (txtFolio.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Folio", "");
                txtFolio.Focus();
                return;
            }

            recepcion1.Detalle = new E_Recepcion_Detalle();
            recepcion1.Detalle.Folio = txtFolio.Text;

            comercial1.Detalle = new E_Comercial();
            comercial1.Detalle.Folio = txtFolio.Text;

            if(Existe_Pallet_Lista(dgvLista, cmbVariedad.SelectedValue.ToString(), cmbProductor.SelectedValue.ToString()) != true)
            {
                if (!recepcion1.Validacion_Folio())
                {

                    if (!comercial1.Validacion_Folio())
                    {
                        exportacion1.Exportacion = new E_Exportacion();
                        exportacion1.Exportacion.Folio = txtFolio.Text;
                        exportacion1.Exportacion.ID_Variedad = cmbVariedad.SelectedValue.ToString();
                        exportacion1.Exportacion.ID_Productor = cmbProductor.SelectedValue.ToString();
                        if (!exportacion1.Validacion_Exportacion())
                        {
                            AgregarGrilla2();
                            dtpFecha.Text = "";
                            cmbProductor.SelectedIndex = -1;
                            cmbVariedad.SelectedIndex = -1;
                            txtCantidadBandejas.Text = "";
                            txtDocumento.Text = "";
                            dtpFecha.Focus();
                        }
                        else
                        {
                            MessageBox.Show(exportacion1.Mensaje);
                            //txtFolio.Text = string.Empty;
                            txtFolio.SelectionStart = 0;
                            txtFolio.SelectionLength = txtFolio.Text.Length;
                            txtFolio.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show(comercial1.Mensaje);
                        //txtFolio.Text = string.Empty;
                        txtFolio.SelectionStart = 0;
                        txtFolio.SelectionLength = txtFolio.Text.Length;
                        txtFolio.Focus();
                    }
                }
                else
                {
                    MessageBox.Show(recepcion1.Mensaje);
                    //txtFolio.Text = string.Empty;
                    txtFolio.SelectionStart = 0;
                    txtFolio.SelectionLength = txtFolio.Text.Length;
                    txtFolio.Focus();
                }
            }
            else
            {
                MessageBox.Show("Un registro con los mismos datos ya ha sido ingresado");
                cmbVariedad.SelectedIndex = -1;
                cmbProductor.SelectedIndex = -1;
                txtCantidadBandejas.Text = string.Empty;
                txtDocumento.Text = string.Empty;
                cmbProductor.Focus();
            }

        }

     
        private void AgregarGrilla2()
        {
            int rowNuevo;

            rowNuevo = 0; //dgvLista.Rows.Count;

            dgvLista.Rows.Insert(0, 1);//  .Add(1);
            dgvLista.Rows[rowNuevo].Cells["item"].Value = (dgvLista.Rows.Count);
            dgvLista.Rows[rowNuevo].Cells["fecha"].Value = dtpFecha.Text;
            dgvLista.Rows[rowNuevo].Cells["ID_productor"].Value = cmbProductor.SelectedValue.ToString();
            dgvLista.Rows[rowNuevo].Cells["productor"].Value = cmbProductor.Text ;
            dgvLista.Rows[rowNuevo].Cells["ID_variedad"].Value = cmbVariedad.SelectedValue.ToString();
            dgvLista.Rows[rowNuevo].Cells["variedad"].Value = cmbVariedad.Text;
            dgvLista.Rows[rowNuevo].Cells["cantidad_bandejas"].Value = txtCantidadBandejas.Text ;
            dgvLista.Rows[rowNuevo].Cells["documento"].Value = txtDocumento .Text;

         //   dgvLista.Rows[rowNuevo].Cells["numero_pallet"].Value = (dgvLista.Rows.Count);
            dgvLista.Rows[0].Selected = true;
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedIndex == -1)
                return;
            cmbProductor.DataSource = productor1.Lista(cmbCliente.SelectedValue.ToString());
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
            bool estado=false;
            List<E_Exportacion> lista_Exportacion = new List<E_Exportacion>();
                                  

            for (int i = dgvLista.Rows.Count - 1; i >= 0; i--)
            {

                DataGridViewRow row = dgvLista.Rows[i];

                exportacion1.Exportacion = new E_Exportacion
                {
                    ID_Cliente = cmbCliente.SelectedValue.ToString(),
                    Cliente = cmbCliente.Text.ToString(),
                    ID_Especie = cmbEspecie.SelectedValue.ToString(),
                    Especie = cmbEspecie.Text.ToString(),
                    ID_Embalaje = cmbEmbalaje.SelectedValue.ToString(),
                    Embalaje = cmbEmbalaje.Text.ToString(),
                    ID_Etiqueta = cmbEtiqueta.SelectedValue.ToString(),
                    Etiqueta = cmbEtiqueta.Text.ToString(),
                    ID_TipoArmado = cmbTipoArmado.SelectedValue.ToString(),
                    TipoArmado = cmbTipoArmado.Text.ToString(),
                    ID_TipoMercado = cmbTipoMercado.SelectedValue.ToString(),
                    TipoMercado = cmbTipoMercado.Text.ToString(),
                    Folio = txtFolio.Text,
                    ID_Productor = row.Cells["ID_productor"].Value.ToString(), //cmbProductor.SelectedValue.ToString(),
                    Productor = row.Cells["productor"].Value.ToString(),
                    ID_Variedad = row.Cells["ID_variedad"].Value.ToString(),
                    Variedad = row.Cells["variedad"].Value.ToString(),
                    Fecha = row.Cells["fecha"].Value.ToString(),
                    Cantidad_Cajas = row.Cells["cantidad_bandejas"].Value.ToString(),
                    Documento = row.Cells["documento"].Value.ToString()
                   
                };
                //dgvLista.Columns.Add("item", "Item");
                //dgvLista.Columns.Add("fecha", "Fecha");
                //dgvLista.Columns.Add("productor", "Productor");
                //dgvLista.Columns.Add("variedad", "Variedad");
                //dgvLista.Columns.Add("cantidad_bandejas", "cantidad_bandejas");
                //dgvLista.Columns.Add("documento", "Documento");
                estado = exportacion1.Agregar();
                lista_Exportacion.Add(exportacion1.Exportacion);
            }     
            if (estado == true)
            {                         
                    Imprimir_Exportacion(lista_Exportacion);               
            }
        }

        private void Imprimir_Exportacion(List<E_Exportacion> exportacion)
        {
            N_Imprimir imprimir = new N_Imprimir();
            N_Exportacion_Encabezado encabezado = new N_Exportacion_Encabezado();
            encabezado.Cliente = exportacion[0].Cliente;
            encabezado.Especie = exportacion[0].Especie;
            encabezado.Embalaje = exportacion[0].Embalaje;
            encabezado.Etiqueta = exportacion[0].Etiqueta;
            encabezado.Tipo_transporte  = exportacion[0].TipoArmado;
            encabezado.N_folio_repo = exportacion[0].Folio;

            N_Exportacion_Detalle detalle;
            List<N_Exportacion_Detalle> lista_detalle = new List<N_Exportacion_Detalle>();
            foreach (E_Exportacion exportacion2 in exportacion)
            {
                detalle = new N_Exportacion_Detalle();
                detalle.Codigo_productor = exportacion2.ID_Productor;
                detalle.Descripcion_productor  = exportacion2.Productor;
                detalle.Dia = exportacion2.Fecha.Substring (0,2);
                detalle.Mes = exportacion2.Fecha.Substring(3,2);
                detalle.Anio = exportacion2.Fecha.Substring(6,4);
                detalle.Guia_productor = exportacion2.Documento;
                detalle.Numero_caja = exportacion2.Cantidad_Cajas;
                detalle.Variedad = exportacion2.Variedad;
                lista_detalle.Add(detalle);
            }                       

            N_Coordenadas_Impresion coordenadas = new N_Coordenadas_Impresion()
            {
                PosicionX = "-2",
                PosicionY = "-3"
            };
            imprimir.Lista_exportacion_detalles  = lista_detalle;
            imprimir.Encabezado_exportacion  = encabezado;
            imprimir.Fuente = new Font("Verdana", 10);
            imprimir.Coordenadas_impresion = coordenadas;
            PrintDocument pd = new PrintDocument();

            pd.PrintPage += new PrintPageEventHandler(imprimir.PrintTextFileHandlerExportacion);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Existe_Pallet_Lista(DataGridView lista, string variedad, string productor)
        {
            foreach (DataGridViewRow Row in lista.Rows)
            {
                // int strFila = Row.Index.ToString();

                string variedad_l = Convert.ToString(Row.Cells["ID_Variedad"].Value);
                string productor_l = Convert.ToString(Row.Cells["ID_Productor"].Value);

                if (variedad_l.ToUpper() == variedad.ToUpper() && productor_l.ToUpper() == productor.ToUpper())
                {
                    //   dgvListaRecepcion.Rows[strFila].DefaultCellStyle.BackColor = Color.Red;
                    return true;
                }
            }
            return false;
        }
    }
}
