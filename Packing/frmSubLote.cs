using Entity;
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
using Clases.Impresion;

namespace Packing
{
    public partial class frmSubLote : Form
    {
        E_Recepcionado_sublote recepcionDetalleSublote = new E_Recepcionado_sublote();
        N_SubLote recepcionSublote = new N_SubLote();
        private E_Usuario sesion { set; get; }

        public frmSubLote(E_Usuario usuario)
        {
            InitializeComponent();
            sesion = usuario;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (cmbBandeja.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Bandejas", "");
                cmbBandeja.Focus();
                return;
            }

            if (cmbTipoPallet.Text.Trim() == "")
            {
                MessageBox.Show("Seleccione Tipo Pallet", "");
                cmbTipoPallet.Focus();
                return;
            }

            if (txtKilos.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Kilos Brutos");
                txtKilos.Focus();
                return;
            }

            if (txtCantidad_Bandejas.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Cantidad Bandejas");
                txtCantidad_Bandejas.Focus();
                return;
            }
            if (txtFolioNuevo.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Nuevo Folio");
                txtFolioNuevo.Focus();
                return;
            }

            if (ValidaDecimal(txtKilos.Text) == false)
            {
                MessageBox.Show("Kilos ingresados no son Validos");
                txtKilos.SelectAll();
                txtKilos.Focus();
                return;
            }

            if (ValidaPesoBruto() == false)
            {
                MessageBox.Show("Peso Bruto debe ser Mayor a Tara");
                txtKilos.SelectAll();
                txtKilos.Focus();
                return;
            }
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
            string hora = DateTime.Now.ToString("HH: mm:ss");

            AgregarEncabezado(); //Para impresion

            if (AgregarDetalle())  //valida folios que no se repita, ingresa registro
            {
                LimpiarCampos();
                txtGuia.Focus();
            }
            else
            {
                txtFolioNuevo.Focus();
                txtFolioNuevo.SelectAll();
            }                      

        }

        bool ValidaDecimal(string valor)
        {
            decimal value;
            if (Decimal.TryParse(valor, out value))
                return true;
            else
                return false;
        }
        N_Bandeja bandeja1 = new N_Bandeja();
        N_Pallet pallet1 = new N_Pallet();

        bool ValidaPesoBruto()
        {
            double kilos_brutos;
            double tara, pesoBandeja, pesoPallet;
            kilos_brutos = Convert.ToDouble(txtKilos.Text);

            //PENDIENTE:revisar si viene peso en bandeja e ID_Bandeja
            pesoBandeja = bandeja1.Peso(cmbBandeja.SelectedValue.ToString()); //  recepcionDetalleSublote.ID_bandeja);
            pesoBandeja = pesoBandeja * Convert.ToInt32(txtCantidad_Bandejas.Text);
            pesoPallet = pallet1.Peso(cmbTipoPallet.SelectedValue.ToString());
            tara = pesoBandeja + pesoPallet;

            if (kilos_brutos <= tara)
            {
                return false;
            }
            return true;
        }
        N_Recepcion recepcion1 = new N_Recepcion();  //Para encabezado y detalle


        private void AgregarEncabezado()
        {
            string fecha = DateTime.Now.ToString("s");

            //    T Format Specifier      de-DE Culture                                 17:04:32
            //    T Format Specifier      en-US Culture                               5:04:32 PM
            //    T Format Specifier      es-ES Culture                                 17:04:32
            //    T Format Specifier      fr-FR Culture                                 17:04:32
            string hora = DateTime.Now.ToString("HH: mm:ss");

            //Random rnd = new Random();
            //int lote = rnd.Next(1, 99999);

            recepcion1.Encabezado = new E_Recepcion_Encabezado();
            recepcion1.Encabezado.Cliente = recepcionDetalleSublote.Cliente;
            recepcion1.Encabezado.ID_Cliente = recepcionDetalleSublote.ID_Cliente;
            recepcion1.Encabezado.Productor = recepcionDetalleSublote.Productor;
            recepcion1.Encabezado.Codigo_Productor = recepcionDetalleSublote.Codigo_Productor;
            recepcion1.Encabezado.Chofer = recepcionDetalleSublote.Chofer;
            recepcion1.Encabezado.Guia = recepcionDetalleSublote.Guia;
            recepcion1.Encabezado.ID_Especie = recepcionDetalleSublote.ID_Especie;
            recepcion1.Encabezado.Especie = recepcionDetalleSublote.Especie;
            recepcion1.Encabezado.ID_Descarga = recepcionDetalleSublote.ID_Descarga;
            recepcion1.Encabezado.Descarga = recepcionDetalleSublote.Descarga;
            recepcion1.Encabezado.Temperatura = recepcionDetalleSublote.Temperatura;
            recepcion1.Encabezado.ID_Destino = recepcionDetalleSublote.ID_Destino;
            recepcion1.Encabezado.Destino = recepcionDetalleSublote.Destino;
            recepcion1.Encabezado.Responsable = sesion.Nombre + " " + sesion.Apellido;
            recepcion1.Encabezado.ID_Tipo = recepcionDetalleSublote.ID_Tipo; // recepcionDetalleSublote.id_tipo;
            recepcion1.Encabezado.Tipo = recepcionDetalleSublote.Tipo;// recepcionDetalleSublote.Tipo;
            recepcion1.Encabezado.Lote = "0"; // recepcionDetalleSublote.Lote; //04-02-201 va en cero por solicitud de cliente en reunion puede que cambie en produccion
            recepcion1.Encabezado.Fecha = fecha;
            recepcion1.Encabezado.Hora = hora;
            //lote se obtiene en agregar encabezado
            // recepcion1.Encabezado.Lote = lote.ToString();
            recepcion1.Encabezado.Cantidad_Pallets = "0";
        }

        N_Exportacion exportacion1 = new N_Exportacion();
        N_Comercial comercial1 = new N_Comercial();
        private bool AgregarDetalle()
        {
            //numero_actual += 1;

            double pesoBandeja = 0;
            double pesoPallet = 0;
            double tara, pesoNeto;
            double peso_promedio;
            int item_posicion;

            N_Bandeja bandeja1 = new N_Bandeja();
            N_Pallet pallet1 = new N_Pallet();
            

            try
            {

                pesoBandeja = bandeja1.Peso(cmbBandeja.SelectedValue.ToString());            
                pesoPallet = pallet1.Peso(cmbTipoPallet.SelectedValue.ToString());

                item_posicion = recepcion1.Posicion_Pallet(recepcionDetalleSublote.ID_Registro); //PENDIENTE: obtener la ultima posicion y agregar siguiente

                recepcion1.Detalle = new E_Recepcion_Detalle();
                recepcion1.Detalle.ID_Recepcion = recepcionDetalleSublote.ID_Registro;
                recepcion1.Detalle.Item = item_posicion.ToString(); //obtener de la base de datos el ultimo registro                
                recepcion1.Detalle.ID_bandeja = cmbBandeja.SelectedValue.ToString();
                recepcion1.Detalle.Bandeja = cmbBandeja.Text;
                recepcion1.Detalle.Peso_Bandeja = pesoBandeja.ToString();
                recepcion1.Detalle.Cantidad_Bandejas = txtCantidad_Bandejas.Text;
                recepcion1.Detalle.Folio = txtFolioNuevo.Text;
                recepcion1.Detalle.Usuario = sesion.Usuario;
                //recepcion1.Detalle.su
                recepcion1.Detalle.Kilos_Brutos = txtKilos.Text;
                tara = (pesoBandeja * Convert.ToInt32(txtCantidad_Bandejas.Text)) + pesoPallet;
                recepcion1.Detalle.Tara = tara.ToString();
                pesoNeto = Convert.ToDouble(txtKilos.Text) - tara;
                recepcion1.Detalle.Kilos_Netos = pesoNeto.ToString();
                recepcion1.Detalle.ID_Pallet = cmbTipoPallet.SelectedValue.ToString();
                recepcion1.Detalle.Tipo_Pallet = cmbTipoPallet.Text;
                recepcion1.Detalle.Peso_Pallet = pesoPallet.ToString();
                peso_promedio = pesoNeto / Convert.ToInt32(txtCantidad_Bandejas.Text);
                peso_promedio = Math.Round(peso_promedio, 2);//redondea a 2 decimales 
                recepcion1.Detalle.Peso_Promedio = peso_promedio.ToString();
                recepcion1.Detalle.Posicion = item_posicion.ToString(); // numero_actual.ToString();
                                                  //recepcion1.detalle.posion = contador posicion numero actual
                //para validar que no se repita folio
                exportacion1.Exportacion = new E_Exportacion();
                exportacion1.Exportacion.Folio = txtFolioNuevo.Text;

                comercial1.Detalle = new E_Comercial();
                comercial1.Detalle.Folio = txtFolioNuevo.Text;

                if (!recepcion1.Validacion_Folio())
                {
                    if (!exportacion1.Validacion_Folio())
                    {
                        if (!comercial1.Validacion_Folio())
                        {
                            
                            bool estado = recepcion1.Agregar_Detalle("sublote");
                            if (estado == true)
                            {
                                txtKilos.Text = string.Empty;
                                txtGuia.Text = string.Empty;
                                txtCantidad_Bandejas.Text = string.Empty;
                                txtGuia.Focus();
                                cmbBandeja.SelectedIndex = -1;
                                cmbTipoPallet.SelectedIndex = -1;
                                txtKilos.Text = string.Empty;
                                txtCantidad_Bandejas.Text = string.Empty;
                                txtFolioNuevo.Text = string.Empty;
                                

                                //PENDIENTE: Imprimir formato recepcion
                                Imprimir_Recepcion(recepcion1.Encabezado, recepcion1.Detalle);
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("Error al Guardar Datos " + recepcion1.Mensaje);
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show(comercial1.Mensaje);
                            //txtFolio.Text = string.Empty;
                            //txtFolio.Focus();
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show(exportacion1.Mensaje);
                        //txtFolio.Text = string.Empty;
                        //txtFolio.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show(recepcion1.Mensaje);
                    //txtFolio.Text = string.Empty;
                    //txtFolio.Focus();
                    return false;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void Imprimir_Recepcion(E_Recepcion_Encabezado encabezado_recepcion, E_Recepcion_Detalle detalle_recepcion)
        {


            DateTime fecha = DateTime.ParseExact(encabezado_recepcion.Fecha, "yyyy-MM-ddTHH:mm:ss",
                                       System.Globalization.CultureInfo.InvariantCulture);

            N_Imprimir imprimir = new N_Imprimir();
            N_Recepcion_Encabezado encabezado = new N_Recepcion_Encabezado()
            {
                Chofer = encabezado_recepcion.Chofer,
                Codigo_productor = encabezado_recepcion.Codigo_Productor,
                Correlativo = encabezado_recepcion.Lote,
                Exportador = encabezado_recepcion.Cliente,
                //    s Format Specifier      de-DE Culture                      2008-10-01T17:04:32

                Fecha = fecha.ToShortDateString(),
                Guia_despacho = encabezado_recepcion.Guia,
                Hora = encabezado_recepcion.Hora,
                Productor = encabezado_recepcion.Productor,
                Especie = encabezado_recepcion.Especie,
                Responsable = encabezado_recepcion.Responsable,
                Tipo = encabezado_recepcion.Tipo
            };
            N_Recepcion_Detalle detalle = new N_Recepcion_Detalle()
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
                Peso_promedio = detalle_recepcion.Peso_Promedio,
                Peso_rejillas = detalle_recepcion.Peso_Bandeja,
                Responsable = encabezado_recepcion.Responsable,
                Sub_lote = detalle_recepcion.Sublote,
                Temperatura = encabezado_recepcion.Temperatura,
                Tipo_rejilla_bandeja = detalle_recepcion.Bandeja,
                Posicion_Pallet = detalle_recepcion.Item                 
                
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
            imprimir.Numero = "0"; // numero_actual.ToString();
            imprimir.Limite = encabezado_recepcion.Cantidad_Pallets;
            PrintDocument pd = new PrintDocument();

            pd.PrintPage += new PrintPageEventHandler(imprimir.PrintTextFileHandlerRecepcion);
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

        void LimpiarCampos()
        {
            txtGuia.Text = "";
            txtFolioNuevo.Text = "";
            txtKilos.Text = "";
            txtCantidad_Bandejas.Text ="";

            lblDescarga.Text = "";
            lblDestino.Text = "";
            lblEspecie.Text = "";
            lblExportador.Text = "";
            lblGuia.Text = "";
            lblProductor.Text = "";
            lblKilosNetos.Text = "";
                        
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmSubLote_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "Usuario Activo: " + sesion.Usuario;

            cmbBandeja.DataSource = bandeja1.Lista();
            cmbBandeja.DisplayMember = "descripcion";
            cmbBandeja.ValueMember = "codigo";
            cmbBandeja.SelectedIndex = -1;

            cmbTipoPallet.DataSource = pallet1.Lista();
            cmbTipoPallet.DisplayMember = "descripcion";
            cmbTipoPallet.ValueMember = "codigo";
            cmbTipoPallet.SelectedIndex = -1;
        }

        //private void txtFolio_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == Convert.ToChar(Keys.Enter))
        //    {
        //        if (txtFolio.Text.Trim() == "")
        //        {
        //           MessageBox.Show ("Ingrese Folio","Folio");
        //            return;
        //        }

        //       // N_Recepcion recepcion1 = new N_Recepcion();
              
              
                
        //        recepcionDetalleSublote.Folio = txtFolio.Text;
        //        if (recepcionSublote.Existe_Pallet_recepcion(recepcionDetalleSublote) == true) //pallet se utiliza para asignarle datos
        //        {
        //            if (recepcionDetalleSublote.Estado == "0")
        //            {
        //                MessageBox .Show ( "Pallet no ha sido asignado","Folio");
        //                return;
        //            }

        //            lblExportador.Text = recepcionDetalleSublote.Cliente;
        //            lblProductor.Text = recepcionDetalleSublote.Productor;
        //            lblEspecie.Text = recepcionDetalleSublote.Especie;
        //            lblDestino.Text = recepcionDetalleSublote.Destino;
        //            lblDescarga.Text = recepcionDetalleSublote.Descarga;
        //            lblGuia.Text = recepcionDetalleSublote.Guia;
        //            lblKilosNetos.Text = recepcionDetalleSublote.Kilos_Netos;
        //            txtKilos.Focus();
                    
        //        }
        //        else
        //        {
        //            MessageBox.Show ("Pallet no Existe");                    
        //        }

        //    }
        //}

        private void txtKilos_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '.')
            {
                if (e.KeyChar == '.' && txtKilos.Text.Contains("."))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void txtGuia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtGuia.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese Guia", "Guia");
                    return;
                }

                // N_Recepcion recepcion1 = new N_Recepcion();

                recepcionDetalleSublote.Guia = txtGuia.Text;
                if (recepcionSublote.Existe_Guia_recepcion(recepcionDetalleSublote) == true) //pallet se utiliza para asignarle datos
                {
                    //if (recepcionDetalleSublote.Estado == "0")
                    //{
                    //    MessageBox.Show("Pallet no ha sido asignado", "Folio");
                    //    return;
                    //}

                    lblExportador.Text = recepcionDetalleSublote.Cliente;
                    lblProductor.Text = recepcionDetalleSublote.Productor;
                    lblEspecie.Text = recepcionDetalleSublote.Especie;
                    lblDestino.Text = recepcionDetalleSublote.Destino;
                    lblDescarga.Text = recepcionDetalleSublote.Descarga;
                    lblGuia.Text = recepcionDetalleSublote.Guia;
                    //lblKilosNetos.Text = recepcionDetalleSublote.Kilos_Netos;
                    cmbBandeja.Focus();

                }
                else
                {
                    MessageBox.Show("Guia no Existe");
                }

            }
        }

        private void txtGuia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
