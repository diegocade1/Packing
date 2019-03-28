using Clases.Impresion;
using Entity;
using Negocio;
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

namespace Packing
{
    public partial class ReImpresion : Form
    {
        private E_Usuario sesion { set; get; }
        public ReImpresion(E_Usuario usuario)
        {
            InitializeComponent();
            sesion = usuario;
        }

        N_Recepcion recepcion1 = new N_Recepcion();
        N_Exportacion exportacion1 = new N_Exportacion();
        N_Comercial comercial1 = new N_Comercial();

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (txtFolio.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el folio", "");
                txtFolio.Focus();
                return;
            }
            string folio = txtFolio.Text;
            recepcion1.Detalle = new E_Recepcion_Detalle();
            recepcion1.Detalle.Folio = folio;
            if (recepcion1.Obtener_Detalle_Recepcion_Folio() != null)
            {
                E_Recepcion_Detalle recepcion2 = recepcion1.Obtener_Detalle_Recepcion_Folio();
                N_Usuario usuario1 = new N_Usuario();
                E_Usuario usuario2 = usuario1.ObtenerUsuario(recepcion2.Usuario);
                E_Recepcion_Encabezado recepcion3 = recepcion1.Obtener_Encabezado_ID(recepcion2.ID_Recepcion);
                recepcion3.Responsable = usuario2.Nombre + " " + usuario2.Apellido;
                double peso_promedio;
                double neto = Convert.ToDouble(recepcion2.Kilos_Netos);
                double cantidad_bandejas = Convert.ToDouble(recepcion2.Cantidad_Bandejas);
                peso_promedio = neto / cantidad_bandejas;
                recepcion2.Peso_Promedio = peso_promedio.ToString("#0.##");
                Imprimir_Recepcion(recepcion3,recepcion2);
                txtFolio.Text = string.Empty;
            }
            else if(exportacion1.Obtener_Exportaciones_Folio(folio).Count!=0)
            {
                List<E_Exportacion> exportacion2 = exportacion1.Obtener_Exportaciones_Folio(folio);
                Imprimir_Exportacion(exportacion2);
                txtFolio.Text = string.Empty;
            }
            else if(comercial1.Obtener_Exportacion_Folio(folio)!= null)
            {
                E_Comercial comercial2 = comercial1.Obtener_Exportacion_Folio(folio);
                Imprimir_Comercial(comercial2);
                txtFolio.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("No se ha encontrado ningun resultado con el folio ingresado", "Mensaje de Advertencia!");
                txtFolio.SelectAll();
            }
        }

        private void Imprimir_Recepcion(E_Recepcion_Encabezado encabezado_recepcion, E_Recepcion_Detalle detalle_recepcion)
        {


            DateTime fecha = DateTime.Parse(encabezado_recepcion.Fecha);

            //DateTime fecha = DateTime.ParseExact(encabezado_recepcion.Fecha, "yyyy-MM-ddTHH:mm:ss",
            //               System.Globalization.CultureInfo.InvariantCulture);

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
                Hora = fecha.ToString("HH:mm:ss"),
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
            imprimir.Numero = detalle_recepcion.Posicion;
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

        private void Imprimir_Exportacion(List<E_Exportacion> exportacion)
        {
            N_Imprimir imprimir = new N_Imprimir();
            N_Exportacion_Encabezado encabezado = new N_Exportacion_Encabezado();
            encabezado.Cliente = exportacion[0].Cliente;
            encabezado.Especie = exportacion[0].Especie;
            encabezado.Embalaje = exportacion[0].Embalaje;
            encabezado.Etiqueta = exportacion[0].Etiqueta;
            encabezado.Tipo_transporte = exportacion[0].TipoArmado;
            encabezado.N_folio_repo = exportacion[0].Folio;
            encabezado.Nombre_encargado = exportacion[0].Responsable;

            N_Exportacion_Detalle detalle;
            List<N_Exportacion_Detalle> lista_detalle = new List<N_Exportacion_Detalle>();
            foreach (E_Exportacion exportacion2 in exportacion)
            {
                detalle = new N_Exportacion_Detalle();
                detalle.Codigo_productor = exportacion2.ID_Productor;
                detalle.Descripcion_productor = exportacion2.Productor;
                detalle.Dia = exportacion2.Fecha.Substring(0, 2);
                detalle.Mes = exportacion2.Fecha.Substring(3, 2);
                detalle.Anio = exportacion2.Fecha.Substring(6, 4);
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
            imprimir.Lista_exportacion_detalles = lista_detalle;
            imprimir.Encabezado_exportacion = encabezado;
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

        private void Imprimir_Comercial(E_Comercial detalle_comercial)
        {
            double pesobandeja = 0;
            double pesopallet = 0;
            double tara, pesoNeto, pesopromedio;

            N_Bandeja bandeja1 = new N_Bandeja();
            N_Pallet pallet1 = new N_Pallet();
            N_Especie especie1 = new N_Especie();
            N_Productor productor1 = new N_Productor();
            N_Cliente cliente1 = new N_Cliente();
            N_TipoComercial tipo1 = new N_TipoComercial();

            E_Bandeja bandeja2 = bandeja1.ObtenerBandeja(detalle_comercial.ID_Tipo.ToString());
            E_Pallet pallet2 = pallet1.ObtenerPallet(detalle_comercial.ID_Pallet.ToString());
            E_Especie especie2 = especie1.ObtenerEspecie(detalle_comercial.ID_Especie.ToString());
            E_Productor productor2 = productor1.ObtenerProductor(detalle_comercial.ID_Productor);
            E_Cliente cliente2 = cliente1.ObtenerCliente(detalle_comercial.ID_Cliente.ToString());
            E_TipoComercial tipo2 = tipo1.ObtenerTipoComercial(detalle_comercial.ID_Tipo.ToString());

            detalle_comercial.Bandeja = bandeja2.Descripcion;
            detalle_comercial.Pallet = pallet2.Descripcion;
            detalle_comercial.Especie = especie2.Descripcion;
            detalle_comercial.Productor = productor2.Descripcion;
            detalle_comercial.Cliente = cliente2.Cliente;
            detalle_comercial.Tipo = tipo2.Descripcion;

            pesobandeja = bandeja1.Peso(detalle_comercial.ID_Bandeja);
            pesopallet = pallet1.Peso(detalle_comercial.ID_Pallet);
            tara = (pesobandeja * Convert.ToInt32(detalle_comercial.Cantidad_Bandejas)) + pesopallet;
            pesoNeto = Convert.ToDouble(detalle_comercial.Kilos_Brutos) - tara;
            pesopromedio = pesoNeto / Convert.ToInt32(detalle_comercial.Cantidad_Bandejas);

            DateTime fecha = Convert.ToDateTime(detalle_comercial.Fecha);
            string hora = fecha.ToString("HH:mm:ss");
            /*---------------------------------------------------------------------------*/
            N_Imprimir imprimir = new N_Imprimir();
            N_Recepcion_Encabezado encabezado = new N_Recepcion_Encabezado()
            {
                Chofer = detalle_comercial.Tipo,
                Codigo_productor = detalle_comercial.ID_Productor,
                Correlativo = "",
                Exportador = detalle_comercial.Cliente,
                Fecha = fecha.ToString("dd/MM/yyyy"),
                Guia_despacho = "",
                Hora = fecha.ToString("h:mm:ss tt"),
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
                Peso_pallet = pesopallet.ToString(),
                Peso_promedio = pesopromedio.ToString(),
                Peso_rejillas = pesobandeja.ToString(),
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
    }
}
