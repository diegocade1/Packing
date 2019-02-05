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
    public partial class Recepcion5 : Form
    {
        private E_Usuario sesion { get; set; }
        private int numero_actual;  //Corresponde a la cantidad de pallet que lleva el proceso valida que no supere a cantidad de pallet


        public Recepcion5(E_Usuario usuario)
        {
            InitializeComponent();
            sesion = usuario;
        }

        N_Cliente cliente1 = new N_Cliente();
        N_Productor producto1 = new N_Productor();
        N_Especie especie1 = new N_Especie();
        N_Recepcion recepcion1 = new N_Recepcion();
        N_Bandeja bandeja1 = new N_Bandeja();
        N_Pallet pallet1 = new N_Pallet();
        N_Tipo_Recepcion tipo1 = new N_Tipo_Recepcion();
        //----
        N_Comercial comercial1 = new N_Comercial();
        N_Exportacion exportacion1 = new N_Exportacion();

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

            cmbTipo.DataSource = tipo1.Lista();
            cmbTipo.DisplayMember = "descripcion";
            cmbTipo.ValueMember = "ID";
            cmbTipo.SelectedIndex = -1;

            lblUsuario.Text = "Usuario Activo: " + sesion.Usuario;

                                                              
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

           if  (ValidarCampos() == false)
                return;

           if(ValidaDecimal(txtKilos.Text) == false)
            {
                MessageBox.Show("Kilos ingresados no son Validos");
                txtKilos.SelectAll();
                txtKilos.Focus();
                return;
            }

            if (ValidaDecimal(txtTemperatura.Text) == false)
            {
                MessageBox.Show("Temperatura ingresada no es valida");
                txtTemperatura.SelectAll();
                txtTemperatura.Focus();
                return;
            }

            if(ValidaPesoBruto() == false)
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

            //Random rnd = new Random();
            //int lote = rnd.Next(1, 99999);

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
            recepcion1.Encabezado.Responsable = sesion.Nombre + " " + sesion.Apellido;
            recepcion1.Encabezado.ID_Tipo = cmbTipo.SelectedValue.ToString();
            recepcion1.Encabezado.Tipo = cmbTipo.Text.ToString();

            recepcion1.Encabezado.Fecha = fecha;
            recepcion1.Encabezado.Hora = hora;
            //lote se obtiene en agregar encabezado
           // recepcion1.Encabezado.Lote = lote.ToString();
           if(txtTotalPallets.Text.Trim() != "")
            {
                recepcion1.Encabezado.Cantidad_Pallets = txtTotalPallets.Text;
            }
            else
            {
                recepcion1.Encabezado.Cantidad_Pallets = "0";
            }

            //if (!recepcion1.Validacion_Guia())
            //{
                bool estado = recepcion1.Agregar_Encabezado();

            if (estado == true)
            {
                txtTotalPallets.ReadOnly = true;
                btnModificarTotalPallets.Visible = true;
                    int ID = recepcion1.UltimoID;
                    if (recepcion1.nuevo)
                    {
                        numero_actual = 0;
                    }
                    else
                    {
                        //txtTotalPallets.Text = recepcion1.Encabezado.Cantidad_Pallets;
                        numero_actual = recepcion1.Posicion;
                    }

                if (Convert.ToInt32(recepcion1.Encabezado.Cantidad_Pallets)!=0)
                {
                    if (numero_actual < Convert.ToInt32(recepcion1.Encabezado.Cantidad_Pallets))
                    {
                        //Agrega detalle de recepcion
                        if (AgregarDetalle(ID, recepcion1.Encabezado.Codigo_Productor) == true)
                        {
                            especie1.Actualizar_Fecha_uso(recepcion1.Encabezado.ID_Especie);
                            //txtKilos.Text = string.Empty;
                            //txtFolio.Text = string.Empty;
                            //txtCantidadBandejas.Text = string.Empty;
                            //cmbBandeja.Focus();
                            //cmbBandeja.SelectedIndex = -1;
                            //cmbTipoPallet.SelectedIndex = -1;
                        }
                        else
                        {
                            //MessageBox.Show("Error al registrar el detalle de la recepcion");
                            //txtKilos.SelectAll();
                            //txtCantidadBandejas.SelectAll();
                            txtFolio.SelectAll();
                            //cmbBandeja.SelectedIndex = -1;
                            //cmbTipoPallet.SelectedIndex = -1;
                            //cmbBandeja.Focus();
                            txtFolio.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ya se alcanzo la cantidad de pallets registrada");
                    }
                }
                else
                {
                    if (AgregarDetalle(ID, recepcion1.Encabezado.Codigo_Productor) == true)
                    {
                        especie1.Actualizar_Fecha_uso(recepcion1.Encabezado.ID_Especie);
                        //txtKilos.Text = string.Empty;
                        //txtFolio.Text = string.Empty;
                        //txtCantidadBandejas.Text = string.Empty;
                        //cmbBandeja.Focus();
                        //cmbBandeja.SelectedIndex = -1;
                        //cmbTipoPallet.SelectedIndex = -1;
                    }
                    else
                    {
                        //MessageBox.Show("Error al registrar el detalle de la recepcion");
                        //txtKilos.SelectAll();
                        //txtCantidadBandejas.SelectAll();
                        txtFolio.SelectAll();
                        //cmbBandeja.SelectedIndex = -1;
                        //cmbTipoPallet.SelectedIndex = -1;
                        //cmbBandeja.Focus();
                        txtFolio.Focus();
                    }
                }
                    

            }
            else
            {
                MessageBox.Show(recepcion1.Mensaje);
                //txtFolio.Text = string.Empty;
                //txtFolio.Focus();
                //cmbCliente.Focus();
                txtGuia.SelectAll();
                txtGuia.Focus();
            }
            //}
            //else
            //{
            //    MessageBox.Show(recepcion1.Mensaje);
            //    txtGuia.SelectAll();
            //    txtGuia.Focus();
            //}
        }

        private bool ValidarCampos()
        {
            if(cmbCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Exportador", "");
                cmbCliente.Focus();
                return false;
            }

            if (cmbProductor.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Productor", "");
                cmbProductor.Focus();
                return false;
            }

            if (cmbEspecie.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Especie", "");
                cmbEspecie.Focus();
                return false;
            }

            if (cmbDescarga.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Descarga", "");
                cmbDescarga.Focus();
                return false;
            }

            if (txtChofer.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Chofer","");
                txtChofer.Focus();
                return false;
            }

            if (cmbDestino.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Destino", "");
                cmbDestino.Focus();
                return false;

            }

            if (txtTemperatura.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Temperatura", "");
                txtTemperatura.Focus();
                return false;
            }

            if (txtGuia.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Guia", "");
                txtGuia.Focus();
                return false;
            }

             
            //if (txtTotalPallets.Text.Trim() == "")          
            //{
            //    MessageBox.Show("Ingrese Total Pallet", "");
            //    txtTotalPallets.Focus();
            //    return false;
            //}

            if (cmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Tipo", "");
                cmbTipo.Focus();
                return false;
            }

            if (cmbBandeja.SelectedIndex  == -1)
            {
                MessageBox.Show("Seleccione Bandejas", "");
                cmbBandeja.Focus();
                return false;
            }

            if (cmbTipoPallet.Text.Trim() == "")
            {
                MessageBox.Show("Seleccione Tipo Pallet", "");
                cmbTipoPallet.Focus();
                return false;
            }

            if (txtKilos.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Kilos", "");
                txtKilos.Focus();
                return false;
            }

            if (txtCantidadBandejas.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Cantidad Bandejas", "");
                txtCantidadBandejas.Focus();
                return false;
            }           

            if (txtFolio.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Folio", "");
                txtFolio.Focus();
                return false;

            }

            return true ;

        }

        bool ValidaPesoBruto()
        {
            double kilos_brutos;
            double tara,pesoBandeja,pesoPallet;
            kilos_brutos = Convert.ToDouble(txtKilos.Text);

            pesoBandeja = bandeja1.Peso(cmbBandeja.SelectedValue.ToString());
            pesoBandeja = pesoBandeja * Convert.ToInt32(txtCantidadBandejas.Text);
            pesoPallet = pallet1.Peso(cmbTipoPallet.SelectedValue.ToString());
            tara = pesoBandeja + pesoPallet;
              
            if (kilos_brutos <= tara)
            {
                return false;
            }
            return true;
        }

        private bool AgregarDetalle(int ID_recepcion,string id_productor)
        {
            numero_actual += 1;

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
                 
                item_posicion = recepcion1.Posicion_Pallet(ID_recepcion.ToString()); //PENDIENTE: obtener la ultima posicion y agregar siguiente

                recepcion1.Detalle = new E_Recepcion_Detalle();
                recepcion1.Detalle.ID_Recepcion = ID_recepcion.ToString();
                recepcion1.Detalle.Item = item_posicion.ToString(); //obtener de la base de datos el ultimo registro                
                recepcion1.Detalle.ID_bandeja = cmbBandeja.SelectedValue.ToString();
                recepcion1.Detalle.Bandeja = cmbBandeja.Text.ToString();
                recepcion1.Detalle.Peso_Bandeja = pesoBandeja.ToString();
                recepcion1.Detalle.Cantidad_Bandejas = txtCantidadBandejas.Text;
                recepcion1.Detalle.Folio = txtFolio.Text;
                recepcion1.Detalle.Kilos_Brutos = txtKilos.Text;
                tara = (pesoBandeja * Convert.ToInt32(txtCantidadBandejas.Text)) + pesoPallet;
                recepcion1.Detalle.Tara = tara.ToString();
                pesoNeto = Convert.ToDouble(txtKilos.Text) - tara;
                recepcion1.Detalle.Kilos_Netos = pesoNeto.ToString();
                recepcion1.Detalle.ID_Pallet = cmbTipoPallet.SelectedValue.ToString();
                recepcion1.Detalle.Tipo_Pallet = cmbTipoPallet.Text;
                recepcion1.Detalle.Peso_Pallet = pesoPallet.ToString();
                peso_promedio = pesoNeto / Convert.ToInt32 (recepcion1.Detalle.Cantidad_Bandejas);
                peso_promedio = Math.Round(peso_promedio,2);//redondea a 2 decimales 
                recepcion1.Detalle.Peso_Promedio = peso_promedio.ToString();
                recepcion1.Detalle.Posicion = numero_actual.ToString();
                //recepcion1.detalle.posion = contador posicion numero actual
                recepcion1.Detalle.Usuario = sesion.Usuario;

                exportacion1.Exportacion = new E_Exportacion();
                exportacion1.Exportacion.Folio = recepcion1.Detalle.Folio;

                comercial1.Detalle = new E_Comercial();
                comercial1.Detalle.Folio = recepcion1.Detalle.Folio;

                if (!recepcion1.Validacion_Folio())
                {
                    if (!exportacion1.Validacion_Folio())
                    {
                        if (!comercial1.Validacion_Folio())
                        {
                            bool estado = recepcion1.Agregar_Detalle("recepcion");
                            if (estado == true)
                            {
                                txtKilos.Text = string.Empty;
                                txtFolio.Text = string.Empty;
                                txtCantidadBandejas.Text = string.Empty;
                                cmbBandeja.Focus();
                                cmbBandeja.SelectedIndex = -1;
                                cmbTipoPallet.SelectedIndex = -1;
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

        private void Imprimir_Recepcion(E_Recepcion_Encabezado encabezado_recepcion,E_Recepcion_Detalle detalle_recepcion)
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
                Peso_promedio = detalle_recepcion.Peso_Promedio,
                Peso_rejillas = detalle_recepcion.Peso_Bandeja,
                Responsable = encabezado_recepcion.Responsable,
                Sub_lote = "",                
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
            imprimir.Numero = numero_actual.ToString();
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
            frmMantenedorCliente frmobj = new frmMantenedorCliente(sesion);
            frmobj.ShowDialog();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbProductor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

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

        bool ValidaDecimal(string valor)
        {
            decimal value;
            if (Decimal.TryParse(valor, out value))
                return true;
            else
                return false;
        }

        bool ValidaNumerico(string valor)
        {
            if (Int32.Parse(valor.Trim()) > 0)
                return true;
            else
                return false;

        }

        private void txtCantidadBandejas_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
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

        private void txtTemperatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-')
            {
                if (e.KeyChar == '.' && txtTemperatura.Text.Contains("."))
                {
                    e.Handled = true;
                }
                else
                {
                    if(e.KeyChar == '-' && txtTemperatura.Text.Contains("-"))
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        e.Handled = false;
                    }
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

        private void txtTotalPallets_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
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

        private void txtFolio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificarTotalPallets_Click(object sender, EventArgs e)
        {
            N_Recepcion recepcion2 = new N_Recepcion();
            string guia = txtGuia.Text;
            string productor = cmbProductor.Text.ToString();

            if (guia.Trim() == "")
            {
                return;
            }

            if (productor.Trim() == "")
            {
                return;
            }

            productor = cmbProductor.SelectedValue.ToString();
            recepcion1.Encabezado = new E_Recepcion_Encabezado()
            {
                Guia = guia,
                Codigo_Productor = productor
            };
            recepcion2.Encabezado = recepcion1.Obtener_Encabezado();
            if (recepcion2.Encabezado != null)
            {
                frmVentaModificar frm = new frmVentaModificar(sesion, recepcion2);
                frm.ShowDialog();
                recepcion2.Encabezado = recepcion1.Obtener_Encabezado();
                txtTotalPallets.Text = recepcion2.Encabezado.Cantidad_Pallets;
            }
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            N_Recepcion recepcion2 = new N_Recepcion();
            string guia = txtGuia.Text;
            string productor = cmbProductor.Text.ToString();

            if (guia.Trim() == "")
            {
                return;
            }

            if (productor.Trim() == "")
            {
                return;
            }

            productor = cmbProductor.SelectedValue.ToString();
            recepcion1.Encabezado = new E_Recepcion_Encabezado()
            {
                Guia = guia,
                Codigo_Productor = productor
            };
            recepcion2.Encabezado = recepcion1.Obtener_Encabezado();
            if (recepcion2.Encabezado != null)
            {
                frmLista frm = new frmLista(sesion, recepcion2);
                frm.ShowDialog();
            }
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            N_Recepcion recepcion2 = new N_Recepcion();
            string guia = txtGuia.Text;
            string productor = cmbProductor.Text.ToString();

            if (cmbCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccionar Exportador");
                return;
            }

            if (productor.Trim() == "")
            {                
                MessageBox.Show("Seleccionar Productor");
                return;
            }

            if (guia.Trim() == "")
            {
                MessageBox.Show("Ingrese guia");
                return;
            }

            productor = cmbProductor.SelectedValue.ToString();
            recepcion1.Encabezado = new E_Recepcion_Encabezado()
            {
                Guia = guia,
                Codigo_Productor = productor
            };
            recepcion2.Encabezado = recepcion1.Obtener_Encabezado();
            if (recepcion2.Encabezado != null)
            {
                cmbCliente.SelectedValue = recepcion2.Encabezado.ID_Cliente;
                cmbEspecie.SelectedValue = recepcion2.Encabezado.ID_Especie;
                txtChofer.Text = recepcion2.Encabezado.Chofer;
                double temperatura = Convert.ToDouble(recepcion2.Encabezado.Temperatura);
                txtTemperatura.Text = temperatura.ToString().Replace(",",".");
                txtTotalPallets.Text = recepcion2.Encabezado.Cantidad_Pallets;
                cmbDescarga.SelectedValue = recepcion2.Encabezado.ID_Descarga;
                cmbDestino.SelectedValue = recepcion2.Encabezado.ID_Destino;
                cmbTipo.SelectedValue = recepcion2.Encabezado.ID_Tipo;
                txtTotalPallets.ReadOnly = true;
            }
            else
            {
                Limpiar();
            }
        }

        private void Limpiar()
        {
            //cmbCliente.SelectedIndex = -1;
            cmbEspecie.SelectedIndex = -1;
            txtChofer.Text = string.Empty;
            txtTemperatura.Text = string.Empty;
            txtTotalPallets.Text = string.Empty;
            cmbDescarga.SelectedIndex = -1;
            cmbDestino.SelectedIndex = -1;
            cmbTipo.SelectedIndex = -1;
            txtTotalPallets.Text = string.Empty;
            txtTotalPallets.ReadOnly = false;
            btnModificarTotalPallets.Visible = false;
        }
    }
}
