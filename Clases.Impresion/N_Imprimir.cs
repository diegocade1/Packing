using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing.Printing;
using System.Drawing;

namespace Clases.Impresion
{
    public class N_Imprimir
    {
        private N_Recepcion_Encabezado encabezado_recepcion;
        private N_Recepcion_Detalle detalle_recepcion;
        private Font fuente;
        private N_Coordenadas_Impresion coordenadas_impresion;
        private N_Maquila_Encabezado encabezado_Maquila;
        private List<N_Maquila_Detalle_Recepcion> lista_detalle_Recepcion_Maquilas;
        private List<N_Maquila_Cajas> lista_Cajas_Maquilas;
        private N_Maquila_Salida salida_Maquila;
        private List<N_Maquila_Salida_Detalle> lista_salida_detalle_maquilas;
        private N_Exportacion_Encabezado encabezado_exportacion;
        private List<N_Exportacion_Detalle> lista_exportacion_detalles;
        private string limite;
        private string numero;
        public string Total_kilos_netos { get; set; }
        public string Total_kilos_comercio { get; set; }
        public string Total_kilos_merma { get; set; }
        public string Total_kilos_exportacion { get; set; }
        public string Total_sobrepeso { get; set; }
        public string Total_sobrepeso_cajas { get; set; }
        public string Total_sobrepeso_pote { get; set; }
        public string Total_peso_teorico { get; set; }
        public string Rendimiento_Porcentaje { get; set; }
        public string Descuento_Sublote { get; set; }
        public string Numero            
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Limite
        {
            get { return limite; }
            set { limite = value; }
        }

        public List<N_Exportacion_Detalle> Lista_exportacion_detalles
        {
            get { return lista_exportacion_detalles; }
            set { lista_exportacion_detalles = value; }
        }


        public N_Exportacion_Encabezado Encabezado_exportacion
        {
            get { return encabezado_exportacion; }
            set { encabezado_exportacion = value; }
        }

        public List<N_Maquila_Salida_Detalle> Lista_salida_detalle_maquila
        {
            get { return lista_salida_detalle_maquilas; }
            set { lista_salida_detalle_maquilas = value; }
        }


        public N_Maquila_Salida Salida_maquila
        {
            get { return salida_Maquila; }
            set { salida_Maquila = value; }
        }

        public List<N_Maquila_Cajas> Lista_cajas_maquila
        {
            get { return lista_Cajas_Maquilas; }
            set { lista_Cajas_Maquilas = value; }
        }

        public List<N_Maquila_Detalle_Recepcion> Detalle_recepcion_maquilas
        {
            get { return lista_detalle_Recepcion_Maquilas; }
            set { lista_detalle_Recepcion_Maquilas = value; }
        }

        public N_Maquila_Encabezado Encabezado_maquila
        {
            get { return encabezado_Maquila; }
            set { encabezado_Maquila = value; }
        }


        public N_Coordenadas_Impresion Coordenadas_impresion
        {
            get { return coordenadas_impresion; }
            set { coordenadas_impresion = value; }
        }


        public Font Fuente
        {
            get { return fuente; }
            set { fuente = value; }
        }

        public N_Recepcion_Detalle Detalle
        {
            get { return detalle_recepcion; }
            set { detalle_recepcion = value; }
        }

        public N_Recepcion_Encabezado Encabezado
        {
            get { return encabezado_recepcion; }
            set { encabezado_recepcion = value; }
        }

        public void PrintTextFileHandlerRecepcion(object sender, PrintPageEventArgs ppeArgs)
        {
            //Recibimos el objeto Graphics  
            Graphics g = ppeArgs.Graphics;
            //float linesPerPage;
            float xPos = fuente.GetHeight(g);
            float yPos = fuente.GetHeight(g); ;
            //Leemos los margenes de PrintPageEventArgs  
            float leftMargin = ppeArgs.MarginBounds.Left;
            float topMargin = ppeArgs.MarginBounds.Top;
            double linea = 3.5 + Convert.ToDouble(coordenadas_impresion.PosicionY);
           
            //
            /*
            xPos = 21 * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString("FRUTA A PROCESO", fuente, Brushes.Black, xPos, yPos, new StringFormat());
            */
            //Move to next line  
            linea += 1.6;
            xPos = (float)(12 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(encabezado_recepcion.Exportador, fuente, Brushes.Black, xPos, yPos, new StringFormat());// Exportador
            xPos = (float)(38 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(encabezado_recepcion.Chofer, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Chofer
            //Move to next line
            linea += 1.3;
            xPos = (float)(12 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(encabezado_recepcion.Productor, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Productor
            xPos = (float)(38 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(encabezado_recepcion.Fecha, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Fecha
            //Move to next line
            linea += 1.4;
            xPos = (float)(12 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(encabezado_recepcion.Codigo_productor, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Codigo Productor
            xPos = (float)(38 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(encabezado_recepcion.Hora, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Hora
                                 
            //Move to next line
            linea += 1.4;
            xPos = (float)(12 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(encabezado_recepcion.Guia_despacho, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Guia de despacho
            xPos = (float)(38 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(encabezado_recepcion.Tipo, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Tipo convencional o 
            //Move to next line
            linea += 5.2;
            xPos = (float)(12 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(encabezado_recepcion.Especie, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Especie
            /*
            //Move to next line
            linea++;
            xPos = 5 * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString("_".PadLeft(76, '_'), fuente, Brushes.Black, xPos, yPos, new StringFormat());
            */
            /*
            //Move to next line
            linea += 2;
            xPos = 15 * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString("RECEPCION PACKING(USO DE LA EXPORTADORA)", fuente, Brushes.Black, xPos, yPos, new StringFormat());
            */
            //Move to next line                                                                                 Detalle Recepcion
            linea += 14;
            xPos = (float)(38 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(detalle_recepcion.Temperatura, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Temperatura
            //Move to next line
            linea += 2.5;
            xPos = (float)(38 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(detalle_recepcion.Hora_recepcion, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Hora recepcion
            //Detalle tipo rejilla o bandeja
            xPos = (float)(5.5 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(detalle_recepcion.Tipo_rejilla_bandeja, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Tipo Rejilla o Bandeja
            //detalle cantidad
            xPos = (float)(12.3 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(detalle_recepcion.Cantidad, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Cantidad
            //detalle Kilos Brutos
            xPos = (float)(15.6 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(detalle_recepcion.Kilos_brutos, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Kilos Brutos
            //detalle Tara
            xPos = (float)(20.4 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(detalle_recepcion.Tara, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Tara
            //detalle Kilos Netos
            xPos = (float)(26 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(detalle_recepcion.Kilos_netos, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Kilos Netos
            //Move to next line
            linea += 3.7;
            xPos = (float)(38 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(detalle_recepcion.Peso_pallet, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Peso Pallet
            //Move to next line
            linea += 2.3;
            xPos = (float)(38 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(detalle_recepcion.Peso_rejillas, fuente, Brushes.Black, xPos, yPos, new StringFormat()); //Peso Rejillas
            //Mensaje sublote codicional solo si es sublote                                                                                                      //
            linea += 3.5;  //linea igual suma aunque no se imprima mensaje sublote porque avanzan los siguientes campos (folio,lote)            
            if (!string.IsNullOrEmpty(detalle_recepcion.Sub_lote))
            {
                if (detalle_recepcion.Sub_lote != "0")
                {
                    xPos = (float)(12 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
                    yPos = (float)linea * fuente.GetHeight(g);
                    g.DrawString("***************** S U B L O T E **********************", fuente, Brushes.Black, xPos, yPos, new StringFormat());  // Mensaje SUBLOTE
                }
            }
            //Move to next line
            linea += 2.0;// 5.5 anterior a mensaje sublote;
            xPos = (float)(38 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(detalle_recepcion.Folio, fuente, Brushes.Black, xPos, yPos, new StringFormat());       // Pallet(#/Lote)
            xPos = (float)(12 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(detalle_recepcion.Numero_lote, fuente, Brushes.Black, xPos, yPos, new StringFormat());  // Numero de Lote
            //Move to next line
            linea += 2.3;
            xPos = (float)(38 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(detalle_recepcion.Peso_promedio, fuente, Brushes.Black, xPos, yPos, new StringFormat());  // Peso promedio
            xPos = (float)(12 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(detalle_recepcion.Sub_lote, fuente, Brushes.Black, xPos, yPos, new StringFormat());   // Sublote
            //Move to next line
            linea += 4.3;
            xPos = (float)(12 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(detalle_recepcion.Descarga, fuente, Brushes.Black, xPos, yPos, new StringFormat());   // Descarga
            xPos = (float)(38 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(detalle_recepcion.Destino, fuente, Brushes.Black, xPos, yPos, new StringFormat());    // Destino
            //Move to next line
            linea += 3.2;
            xPos = (float)(12 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(detalle_recepcion.Comentario, fuente, Brushes.Black, xPos, yPos, new StringFormat());   // Comentario
            //Move to next line
            linea += 2.7;
            xPos = (float)(12 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(detalle_recepcion.Responsable, fuente, Brushes.Black, xPos, yPos, new StringFormat());    // Responsable
            //Move to next line
            linea += 3.5;
            xPos = (float)(12 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(numero+"/"+limite, fuente, Brushes.Black, xPos, yPos, new StringFormat());    // Enumeracion
            //Move to next line
            /*
            xPos = 20 * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString("Peso Pallet: " + detalle.Peso_pallet, fuente, Brushes.Black, xPos, yPos, new StringFormat());
            xPos = 31 * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString("Destino: " + detalle.Destino, fuente, Brushes.Black, xPos, yPos, new StringFormat());
            //Move to next line
            linea++;
            xPos = 5 * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString("Hora de Recepcion: " + detalle.Hora_recepcion, fuente, Brushes.Black, xPos, yPos, new StringFormat());
            xPos = 20 * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString("Peso Rejillas: " + detalle.Peso_rejillas, fuente, Brushes.Black, xPos, yPos, new StringFormat());
            xPos = 31 * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString("Descarga: " + detalle.Descarga, fuente, Brushes.Black, xPos, yPos, new StringFormat());
            //Move to next line
            //Move to next line
            linea += 2;
            xPos = 5 * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString("Numero de Lote: " + detalle.Numero_lote, fuente, Brushes.Black, xPos, yPos, new StringFormat());
            xPos = 31 * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString("Pallet(#/Lote): " + detalle.Folio, fuente, Brushes.Black, xPos, yPos, new StringFormat());
            //Move to next line
            linea++;
            xPos = 5 * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString("Peso Promedio Rejilla: " + detalle.Peso_promedio, fuente, Brushes.Black, xPos, yPos, new StringFormat());
            xPos = 31 * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString("Sub Lote: " + detalle.Sub_lote, fuente, Brushes.Black, xPos, yPos, new StringFormat());
            //Move to next line
            */
            /*
            // TABLA
            //ENCABEZADO
            //Rectangulo
            //Rectangulo Columna 1
            linea += 3;
            xPos = 5 * fuente.GetHeight(g);
            yPos = linea * fuente.GetHeight(g);
            float ht = 200; //Table Height
            float wt = 50; //Table Width
            g.DrawRectangle(new Pen(Brushes.Black), xPos, yPos, ht, wt);
            //Rectangulo Columna 2
            ht = 100; //Table Height
            wt = 50; //Table Width
            xPos = 17 * fuente.GetHeight(g);
            yPos = linea * fuente.GetHeight(g);
            g.DrawRectangle(new Pen(Brushes.Black), xPos, yPos, ht, wt);
            //Rectangulo Columna 3
            ht = 100; //Table Height
            wt = 50; //Table Width
            xPos = 23 * fuente.GetHeight(g);
            yPos = linea * fuente.GetHeight(g);
            g.DrawRectangle(new Pen(Brushes.Black), xPos, yPos, ht, wt);
            //Rectangulo Columna 4
            ht = 100; //Table Height
            wt = 50; //Table Width
            xPos = 29 * fuente.GetHeight(g);
            yPos = linea * fuente.GetHeight(g);
            g.DrawRectangle(new Pen(Brushes.Black), xPos, yPos, ht, wt);
            //Rectangulo Columna 5
            ht = 100; //Table Height
            wt = 50; //Table Width
            xPos = 35 * fuente.GetHeight(g);
            yPos = linea * fuente.GetHeight(g);
            g.DrawRectangle(new Pen(Brushes.Black), xPos, yPos, ht, wt);
            //Palabra
            linea++;
            //Palabra Columna 1
            xPos = (float)5.5 * fuente.GetHeight(g);
            yPos = linea * fuente.GetHeight(g);
            g.DrawString("Tipo de Rejilla o Bandeja", fuente, Brushes.Black, xPos, yPos, new StringFormat());
            //Palabra Columna 2
            xPos = (float)18 * fuente.GetHeight(g);
            yPos = linea * fuente.GetHeight(g);
            g.DrawString("Cantidad", fuente, Brushes.Black, xPos, yPos, new StringFormat());
            //Palabra Columna 3
            xPos = (float)23.5 * fuente.GetHeight(g);
            yPos = linea * fuente.GetHeight(g);
            g.DrawString("Kilos Brutos", fuente, Brushes.Black, xPos, yPos, new StringFormat());
            //Palabra Columna 4
            xPos = (float)31 * fuente.GetHeight(g);
            yPos = linea * fuente.GetHeight(g);
            g.DrawString("Tara", fuente, Brushes.Black, xPos, yPos, new StringFormat());
            //Palabra Columna 4
            xPos = (float)35.5 * fuente.GetHeight(g);
            yPos = linea * fuente.GetHeight(g);
            g.DrawString("Kilos Netos", fuente, Brushes.Black, xPos, yPos, new StringFormat());
            //DETALLE
            //Rectangulo
            linea+=2;
            //Rectangulo Columna 1          
            xPos = 5 * fuente.GetHeight(g);
            yPos = linea * fuente.GetHeight(g);
            ht = 200; //Table Height
            wt = 50; //Table Width
            g.DrawRectangle(new Pen(Brushes.Black), xPos, yPos, ht, wt);
            //Rectangulo Columna 2
            ht = 100; //Table Height
            wt = 50; //Table Width
            xPos = 17 * fuente.GetHeight(g);
            yPos = linea * fuente.GetHeight(g);
            g.DrawRectangle(new Pen(Brushes.Black), xPos, yPos, ht, wt);
            //Rectangulo Columna 3
            ht = 100; //Table Height
            wt = 50; //Table Width
            xPos = 23 * fuente.GetHeight(g);
            yPos = linea * fuente.GetHeight(g);
            g.DrawRectangle(new Pen(Brushes.Black), xPos, yPos, ht, wt);
            //Rectangulo Columna 4
            ht = 100; //Table Height
            wt = 50; //Table Width
            xPos = 29 * fuente.GetHeight(g);
            yPos = linea * fuente.GetHeight(g);
            g.DrawRectangle(new Pen(Brushes.Black), xPos, yPos, ht, wt);
            //Rectangulo Columna 5
            ht = 100; //Table Height
            wt = 50; //Table Width
            xPos = 35 * fuente.GetHeight(g);
            yPos = linea * fuente.GetHeight(g);
            g.DrawRectangle(new Pen(Brushes.Black), xPos, yPos, ht, wt);
            //Palabra
            linea++;
            //
            */
            //Move to next line

            //If PrintPageEventArgs has more pages to print  
            ppeArgs.HasMorePages = false;
        }

        public void PrintTextFileHandlerMaquila(object sender, PrintPageEventArgs ppeArgs)
        {
            //Recibimos el objeto Graphics  
            Graphics g = ppeArgs.Graphics;
            //float linesPerPage;
            float xPos = fuente.GetHeight(g);
            float yPos = fuente.GetHeight(g); ;
            //Leemos los margenes de PrintPageEventArgs  
            float leftMargin = ppeArgs.MarginBounds.Left;
            float topMargin = ppeArgs.MarginBounds.Top;
            double linea = 3.5 + Convert.ToDouble(coordenadas_impresion.PosicionY);
            //Move to next line  
            linea += 5.5;
            xPos = (float)(10.5 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(encabezado_Maquila.Exportador, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Exportador
            xPos = (float)(37.0 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(salida_Maquila.Fecha_proceso, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Fecha Proceso
            //Move to next line
            linea += 1.5;
            xPos = (float)(10.5 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(encabezado_Maquila.Productor, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Productor
            xPos = (float)(37.0 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(salida_Maquila.Lineas, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Linea
            //Move to next line
            linea += 1.5;
            xPos = (float)(10.5 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(encabezado_Maquila.Guia_despacho, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Guia despacho
            xPos = (float)(37.0 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(salida_Maquila.Hora_inicio, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Hora inicio
            //Move to next line
            linea += 1.5;
            xPos = (float)(10.5 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(encabezado_Maquila.Numero_lote, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Numero Lote
            xPos = (float)(37.0 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(salida_Maquila.Hora_termino, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Hora Termino
            //Move to next line
            linea += 1.3;
            xPos = (float)(10.5 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(encabezado_Maquila.Fecha_recepcion, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Fecha recepcion
            xPos = (float)(37.0 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(salida_Maquila.Rendimiento, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Rendimiento
            //Move to next line
            linea += 1.4;
            xPos = (float)(10.5 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(encabezado_Maquila.Orden_embalaje, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Orden de embalaje
            //Move to next line  Detalle de Recepcion
            linea += 6.7;
            double tempLinea = linea;
            //double total_peso_teorico = 0;
            //double kilos_exportacion = 0;
            //double total_cajas = 0;
            //double total_sobre_peso = 0;
            foreach (N_Maquila_Detalle_Recepcion detalle in lista_detalle_Recepcion_Maquilas)
            {
                xPos = (float)(10.5 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
                yPos = (float)linea * fuente.GetHeight(g);
                g.DrawString(detalle.Folio_pallet, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Folio pallet
                xPos = (float)(17.5 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
                yPos = (float)linea * fuente.GetHeight(g);
                g.DrawString(detalle.Total_kilos_netos, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // kilo neto
                //total_kilos_netos = total_kilos_netos + Convert.ToDouble(detalle.Total_kilos_netos);
                linea += 1.5;
            }
            //Move to next line Detalle de Salida
            foreach (N_Maquila_Salida_Detalle detalle in lista_salida_detalle_maquilas)
            {
                xPos = (float)(26.5 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
                yPos = (float)tempLinea * fuente.GetHeight(g);
                g.DrawString(detalle.Kilos_comerciales, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Kilos comerciales
                //Pendiente TOTAL Kilos comerciales desde campo propiedad
                //total_kilos_comercio = total_kilos_comercio + Convert.ToDouble(detalle.Kilos_comerciales);
                xPos = (float)(37.0 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
                yPos = (float)tempLinea * fuente.GetHeight(g);
                g.DrawString(detalle.Kilos_merma, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Kilos merma
                //PENDIENTE obtener desde negocio kilos merma
                //total_kilos_merma = total_kilos_merma + Convert.ToDouble(detalle.Kilos_merma);
                tempLinea += 1.5;
            }
            if (Descuento_Sublote != "0,000" && Descuento_Sublote != "0")
            {
                tempLinea = 29.6 + Convert.ToDouble(coordenadas_impresion.PosicionY); ;
                xPos = (float)(13.5 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
                yPos = (float)tempLinea * fuente.GetHeight(g);
                Descuento_Sublote = "Sublote: " + Descuento_Sublote;
                g.DrawString(Descuento_Sublote, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // total kilos netos
            }
            //Move to next line
            string slinea = linea.ToString();
            linea = 31.5 + Convert.ToDouble(coordenadas_impresion.PosicionY);
            xPos = (float)(17.5 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(Total_kilos_netos, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // total kilos netos
            xPos = (float)(26.5 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(Total_kilos_comercio, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // total kilos comercio
            xPos = (float)(37.0 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(Total_kilos_merma, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // total kilos merma
            //Move to next line Lista de Cajas
            linea += 7.5;
            tempLinea = linea;
            foreach (N_Maquila_Cajas caja in lista_Cajas_Maquilas)
            {
                xPos = (float)(10.5 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
                yPos = (float)tempLinea * fuente.GetHeight(g);
                g.DrawString(caja.Numero_pallet, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // numero pallet caja
                xPos = (float)(17.5 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
                yPos = (float)tempLinea * fuente.GetHeight(g);
                g.DrawString(caja.Formato, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // formato caja
                xPos = (float)(22.5 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
                yPos = (float)tempLinea * fuente.GetHeight(g);
                g.DrawString(caja.Peso_teorico, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // peso teorico caja
                xPos = (float)(27.5 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
                yPos = (float)tempLinea * fuente.GetHeight(g);
                g.DrawString(caja.Cajas, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // cantidad cajas
                xPos = (float)(33.5 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
                yPos = (float)tempLinea * fuente.GetHeight(g);
                g.DrawString(caja.Total_peso_teorico, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // total peso teorico caja
                //total_peso_teorico = total_peso_teorico + Convert.ToDouble(caja.Total_peso_teorico);
                //total_cajas = total_cajas + Convert.ToDouble(caja.Cajas);
                tempLinea += 1.4;
            }
            //Move to next line
            linea = 52 + Convert.ToDouble(coordenadas_impresion.PosicionY);
            xPos = (float)(37.0 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(Total_sobrepeso, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // total sobre peso x cajas
            //Move to next line
            linea += 1.4;
            tempLinea = linea;
            xPos = (float)(37.0 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(Total_sobrepeso_cajas, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // peso cajas
            tempLinea += 0.5;
            xPos = (float)(13.5 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)tempLinea * fuente.GetHeight(g);
            g.DrawString(Total_kilos_exportacion.ToString(), fuente, Brushes.Black, xPos, yPos, new StringFormat()); // total kilos exportacion
            //Move to next line templinea
            tempLinea += 3.8;
            xPos = (float)(13.5 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)tempLinea * fuente.GetHeight(g);
            g.DrawString(Total_peso_teorico, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // total peso teorico
            //Move to next line
            linea += 1.4;
            tempLinea = linea;
            xPos = (float)(37.0 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(Total_sobrepeso_pote, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // total sobre peso x pote
            //Move to next line
            linea += 3.4;
            xPos = (float)(37.0 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(Rendimiento_Porcentaje, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Rendimiento proceso

            /*
            //Move to next line
            linea += 3.8;
            xPos = (float)(49.5 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(total_peso_teorico.ToString(), fuente, Brushes.Black, xPos, yPos, new StringFormat());
            //Move to next line
            linea += 1.7;

            linea += 4.5;
            xPos = (float)(49.5 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(salida_Maquila.Rendimiento, fuente, Brushes.Black, xPos, yPos, new StringFormat());
            */

            //If PrintPageEventArgs has more pages to print  
            ppeArgs.HasMorePages = false;
        }

        public void PrintTextFileHandlerExportacion(object sender, PrintPageEventArgs ppeArgs)
        {
            //Recibimos el objeto Graphics  
            Graphics g = ppeArgs.Graphics;
            //float linesPerPage;
            float xPos = fuente.GetHeight(g);
            float yPos = fuente.GetHeight(g); ;
            //Leemos los margenes de PrintPageEventArgs  
            float leftMargin = ppeArgs.MarginBounds.Left;
            float topMargin = ppeArgs.MarginBounds.Top;
            double linea = 3.5 + Convert.ToDouble(coordenadas_impresion.PosicionY);
            //Move to next line  
            linea += 8.1;
            xPos = (float)(14.5 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(encabezado_exportacion.Cliente, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Clientes
            //Move to next line  
            linea += 2.3;
            xPos = (float)(14.5 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(encabezado_exportacion.Fecha_armado, fuente, Brushes.Black, xPos, yPos, new StringFormat());  // Fecha Armado
            xPos = (float)(37.5 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(encabezado_exportacion.Especie, fuente, Brushes.Black, xPos, yPos, new StringFormat());  //  Especie
            //Move to next line
            linea += 2.3;
            xPos = (float)(8.2 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(encabezado_exportacion.Tipo_transporte, fuente, Brushes.Black, xPos, yPos, new StringFormat());  //  Tipo de Transporte
            xPos = (float)(21.5 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(encabezado_exportacion.Tipo_accion, fuente, Brushes.Black, xPos, yPos, new StringFormat());   // Tipo de Accion
            xPos = (float)(37.5 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(encabezado_exportacion.Embalaje, fuente, Brushes.Black, xPos, yPos, new StringFormat());  //  Embalaje
            //Move to next line
            linea += 1.4;
            xPos = (float)(37.5 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(encabezado_exportacion.Etiqueta, fuente, Brushes.Black, xPos, yPos, new StringFormat());  //  Etiqueta
            //Move to next line
            linea += 1.3;
            xPos = (float)(37.5 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(encabezado_exportacion.N_folio_repo, fuente, Brushes.Black, xPos, yPos, new StringFormat());   //  Numero de Folio
            //Move to next line
            linea += 1.3;
            xPos = (float)(37.5 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(encabezado_exportacion.Temperatura, fuente, Brushes.Black, xPos, yPos, new StringFormat());  // Temperatura
            //Move to next line
            linea += 1.3;
            xPos = (float)(37.5 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(encabezado_exportacion.Co2, fuente, Brushes.Black, xPos, yPos, new StringFormat());   //  Co2
            //Move to next line
            linea = 25.0 + Convert.ToDouble(coordenadas_impresion.PosicionY);
            xPos = (float)(16.5 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(encabezado_exportacion.Tipo_detalle, fuente, Brushes.Black, xPos, yPos, new StringFormat());  //  Tipo de Detalle
            //Move to next line
            double tempLinea = 0;
            linea += 3.3;
            tempLinea = linea;
            foreach (N_Exportacion_Detalle detalle in lista_exportacion_detalles)
            {
                xPos = (float)(5.2 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
                yPos = (float)tempLinea * fuente.GetHeight(g);
                g.DrawString(detalle.Mes, fuente, Brushes.Black, xPos, yPos, new StringFormat());                       //  mes
                xPos = (float)(8.0 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
                yPos = (float)tempLinea * fuente.GetHeight(g);
                g.DrawString(detalle.Dia, fuente, Brushes.Black, xPos, yPos, new StringFormat());                       // Dia
                xPos = (float)(10.6 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
                yPos = (float)tempLinea * fuente.GetHeight(g);
                g.DrawString(detalle.Anio, fuente, Brushes.Black, xPos, yPos, new StringFormat());                      //  Año                 
                xPos = (float)(14.5 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
                yPos = (float)tempLinea * fuente.GetHeight(g);
                g.DrawString(detalle.Descripcion_productor, fuente, Brushes.Black, xPos, yPos, new StringFormat());   //  Descripcion  de productor
                xPos = (float)(27.5 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
                yPos = (float)tempLinea * fuente.GetHeight(g);
                g.DrawString(detalle.Codigo_productor, fuente, Brushes.Black, xPos, yPos, new StringFormat());          //Codigo del productor
                xPos = (float)(32.7 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
                yPos = (float)tempLinea * fuente.GetHeight(g);
                g.DrawString(detalle.Variedad, fuente, Brushes.Black, xPos, yPos, new StringFormat());               //  Variable   
                xPos = (float)(37.5 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
                yPos = (float)tempLinea * fuente.GetHeight(g);
                g.DrawString(detalle.Guia_productor, fuente, Brushes.Black, xPos, yPos, new StringFormat());        // Guia productor
                xPos = (float)(42.7 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
                yPos = (float)tempLinea * fuente.GetHeight(g);
                g.DrawString(detalle.Numero_caja, fuente, Brushes.Black, xPos, yPos, new StringFormat());       //  Numero de Cajas
                tempLinea += 2.5;
            }

            //Move to next line
            linea = 55.3 + Convert.ToDouble(coordenadas_impresion.PosicionY);
            xPos = (float)(42.7 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(encabezado_exportacion.Total_num_cajas, fuente, Brushes.Black, xPos, yPos, new StringFormat());   //  Total numero de cajas
            //Move to next line
            linea += 3.5;
            xPos = (float)(14.5 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(encabezado_exportacion.Nombre_encargado, fuente, Brushes.Black, xPos, yPos, new StringFormat());    // Nombre del Encargado
            //Move to next line


            //If PrintPageEventArgs has more pages to print  
            ppeArgs.HasMorePages = false;
        }

        public void PrintTextFileHandlerComercial(object sender, PrintPageEventArgs ppeArgs)
        {
            //Recibimos el objeto Graphics  
            Graphics g = ppeArgs.Graphics;
            //float linesPerPage;
            float xPos = fuente.GetHeight(g);
            float yPos = fuente.GetHeight(g); ;
            //Leemos los margenes de PrintPageEventArgs  
            float leftMargin = ppeArgs.MarginBounds.Left;
            float topMargin = ppeArgs.MarginBounds.Top;
            double linea = 3.5 + Convert.ToDouble(coordenadas_impresion.PosicionY);
            //
            /*
            xPos = 21 * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString("FRUTA A PROCESO", fuente, Brushes.Black, xPos, yPos, new StringFormat());
            */
            //Move to next line  
            linea += 1.6;
            xPos = (float)(12 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(encabezado_recepcion.Exportador, fuente, Brushes.Black, xPos, yPos, new StringFormat());// Exportador
            xPos = (float)(38 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(encabezado_recepcion.Chofer, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Chofer
            //Move to next line
            linea += 1.3;
            xPos = (float)(12 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(encabezado_recepcion.Productor, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Productor
            xPos = (float)(38 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(encabezado_recepcion.Fecha, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Fecha
            //Move to next line
            linea += 1.4;
            xPos = (float)(12 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(encabezado_recepcion.Codigo_productor, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Codigo Productor
            xPos = (float)(38 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(encabezado_recepcion.Hora, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Hora
            //Move to next line
            linea += 1.4;
            xPos = (float)(12 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(encabezado_recepcion.Guia_despacho, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Guia de despacho
            //Move to next line
            linea += 5.2;
            xPos = (float)(12 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(encabezado_recepcion.Especie, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Especie
            /*
            //Move to next line
            linea++;
            xPos = 5 * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString("_".PadLeft(76, '_'), fuente, Brushes.Black, xPos, yPos, new StringFormat());
            */
            /*
            //Move to next line
            linea += 2;
            xPos = 15 * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString("RECEPCION PACKING(USO DE LA EXPORTADORA)", fuente, Brushes.Black, xPos, yPos, new StringFormat());
            */
            //Move to next line                                                                                 Detalle Recepcion
            linea += 14;
            xPos = (float)(38 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(detalle_recepcion.Temperatura, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Temperatura
            //Move to next line
            linea += 2.5;
            xPos = (float)(38 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(detalle_recepcion.Hora_recepcion, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Hora recepcion
            //Detalle tipo rejilla o bandeja
            xPos = (float)(5.5 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(detalle_recepcion.Tipo_rejilla_bandeja, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Tipo Rejilla o Bandeja
            //detalle cantidad
            xPos = (float)(12.3 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(detalle_recepcion.Cantidad, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Cantidad
            //detalle Kilos Brutos
            xPos = (float)(15.6 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(detalle_recepcion.Kilos_brutos, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Kilos Brutos
            //detalle Tara
            xPos = (float)(20.4 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(detalle_recepcion.Tara, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Tara
            //detalle Kilos Netos
            xPos = (float)(26 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(detalle_recepcion.Kilos_netos, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Kilos Netos
            //Move to next line
            linea += 3.7;
            xPos = (float)(38 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(detalle_recepcion.Peso_pallet, fuente, Brushes.Black, xPos, yPos, new StringFormat()); // Peso Pallet
            //Move to next line
            linea += 2.3;
            xPos = (float)(38 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(detalle_recepcion.Peso_rejillas, fuente, Brushes.Black, xPos, yPos, new StringFormat()); //Peso Rejillas
            //Move to next line
            linea += 5.5;
            xPos = (float)(38 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(detalle_recepcion.Folio, fuente, Brushes.Black, xPos, yPos, new StringFormat());       // Pallet(#/Lote)
            xPos = (float)(12 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(detalle_recepcion.Numero_lote, fuente, Brushes.Black, xPos, yPos, new StringFormat());  // Numero de Lote
            //Move to next line
            linea += 2.3;
            xPos = (float)(38 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(detalle_recepcion.Peso_promedio, fuente, Brushes.Black, xPos, yPos, new StringFormat());  // Peso promedio
            xPos = (float)(12 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(detalle_recepcion.Sub_lote, fuente, Brushes.Black, xPos, yPos, new StringFormat());   // Sublote
            //Move to next line
            linea += 4.3;
            xPos = (float)(12 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(detalle_recepcion.Descarga, fuente, Brushes.Black, xPos, yPos, new StringFormat());   // Descarga
            xPos = (float)(38 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(detalle_recepcion.Destino, fuente, Brushes.Black, xPos, yPos, new StringFormat());    // Destino
            //Move to next line
            linea += 3.2;
            xPos = (float)(12 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(detalle_recepcion.Comentario, fuente, Brushes.Black, xPos, yPos, new StringFormat());   // Comentario
            //Move to next line
            linea += 2.7;
            xPos = (float)(12 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            yPos = (float)linea * fuente.GetHeight(g);
            g.DrawString(detalle_recepcion.Responsable, fuente, Brushes.Black, xPos, yPos, new StringFormat());    // Responsable
            //Move to next line
            //linea += 3.5;
            //xPos = (float)(12 + Convert.ToDouble(coordenadas_impresion.PosicionX)) * fuente.GetHeight(g);
            //yPos = (float)linea * fuente.GetHeight(g);
            //g.DrawString(numero + "/" + limite, fuente, Brushes.Black, xPos, yPos, new StringFormat());    // Enumeracion
            /**/

            //If PrintPageEventArgs has more pages to print  
            ppeArgs.HasMorePages = false;
        }

    }
}
