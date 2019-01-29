using Entity;
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


            if (AgregarDetalle())
            {
                LimpiarCampos();
                txtFolio.Focus();
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
            pesoBandeja = bandeja1.Peso(recepcionDetalleSublote.ID_bandeja);
            pesoBandeja = pesoBandeja * Convert.ToInt32(txtCantidad_Bandejas.Text);
            pesoPallet = pallet1.Peso(recepcionDetalleSublote.ID_Pallet);
            tara = pesoBandeja + pesoPallet;

            if (kilos_brutos <= tara)
            {
                return false;
            }
            return true;
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
            N_Recepcion recepcion1 = new N_Recepcion();

            try
            {
                pesoBandeja = bandeja1.Peso(recepcionDetalleSublote.ID_bandeja);            
                pesoPallet = pallet1.Peso(recepcionDetalleSublote.ID_Pallet);

                item_posicion = recepcion1.Posicion_Pallet(recepcionDetalleSublote.ID_Registro); //PENDIENTE: obtener la ultima posicion y agregar siguiente

                recepcion1.Detalle = new E_Recepcion_Detalle();
                recepcion1.Detalle.ID_Recepcion = recepcionDetalleSublote.ID_Registro;
                recepcion1.Detalle.Item = item_posicion.ToString(); //obtener de la base de datos el ultimo registro                
                recepcion1.Detalle.ID_bandeja = recepcionDetalleSublote.ID_bandeja;
                recepcion1.Detalle.Bandeja = recepcionDetalleSublote.Bandeja;
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
                recepcion1.Detalle.ID_Pallet = recepcionDetalleSublote.ID_Pallet;
                recepcion1.Detalle.Tipo_Pallet = recepcionDetalleSublote.Tipo_Pallet;
                recepcion1.Detalle.Peso_Pallet = pesoPallet.ToString();
                peso_promedio = pesoNeto / Convert.ToInt32(recepcion1.Detalle.Cantidad_Bandejas);
                peso_promedio = Math.Round(peso_promedio, 2);//redondea a 2 decimales 
                recepcion1.Detalle.Peso_Promedio = peso_promedio.ToString();
                recepcion1.Detalle.Posicion = item_posicion.ToString(); // numero_actual.ToString();
                                                  //recepcion1.detalle.posion = contador posicion numero actual

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
                            bool estado = recepcion1.Agregar_Detalle();
                            if (estado == true)
                            {
                                txtKilos.Text = string.Empty;
                                txtFolio.Text = string.Empty;
                                txtCantidad_Bandejas.Text = string.Empty;
                                txtFolio.Focus();
                                txtFolio.Text = string.Empty;
                                txtKilos.Text = string.Empty;
                                txtCantidad_Bandejas.Text = string.Empty;
                                txtFolioNuevo.Text = string.Empty;

                                //PENDIENTE: Imprimir formato recepcion
                                //Imprimir_Recepcion(recepcion1.Encabezado, recepcion1.Detalle);
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

        void LimpiarCampos()
        {
            txtFolio.Text = "";
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
        }

        private void txtFolio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFolio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtFolio.Text.Trim() == "")
                {
                   MessageBox.Show ("Ingrese Folio","Folio");
                    return;
                }

               // N_Recepcion recepcion1 = new N_Recepcion();
              
              
                
                recepcionDetalleSublote.Folio = txtFolio.Text;
                if (recepcionSublote.Existe_Pallet_recepcion(recepcionDetalleSublote) == true) //pallet se utiliza para asignarle datos
                {
                    if (recepcionDetalleSublote.Estado == "0")
                    {
                        MessageBox .Show ( "Pallet no ha sido asignado","Folio");
                        return;
                    }

                    lblExportador.Text = recepcionDetalleSublote.Cliente;
                    lblProductor.Text = recepcionDetalleSublote.Productor;
                    lblEspecie.Text = recepcionDetalleSublote.Especie;
                    lblDestino.Text = recepcionDetalleSublote.Destino;
                    lblDescarga.Text = recepcionDetalleSublote.Descarga;
                    lblGuia.Text = recepcionDetalleSublote.Guia;
                    lblKilosNetos.Text = recepcionDetalleSublote.Kilos_Netos;
                    txtKilos.Focus();
                    
                }
                else
                {
                    MessageBox.Show ("Pallet no Existe");                    
                }

            }
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
    }
}
