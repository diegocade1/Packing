using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Impresion
{
    public class N_Recepcion_Encabezado
    {
        private string _exportador;
        private string _productor;
        private string _codigo_productor;
        private string _guia_despacho;
        private string _chofer;
        private string _fecha;
        private string _hora;
        private string _correlativo;
        private string _especie;
        private string _responsable;

        public string Responsable
        {
            get { return _responsable; }
            set { _responsable = value; }
        }


        public string Especie
        {
            get { return _especie; }
            set { _especie = value; }
        }


        public string Correlativo
        {
            get { return _correlativo; }
            set { _correlativo = value; }
        }


        public string Hora
        {
            get { return _hora; }
            set { _hora = value; }
        }

        public string Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public string Chofer
        {
            get { return _chofer; }
            set { _chofer = value; }
        }

        public string Guia_despacho
        {
            get { return _guia_despacho; }
            set { _guia_despacho = value; }
        }

        public string Codigo_productor
        {
            get { return _codigo_productor; }
            set { _codigo_productor = value; }
        }

        public string Productor
        {
            get { return _productor; }
            set { _productor = value; }
        }

        public string Exportador
        {
            get { return _exportador; }
            set { _exportador = value; }
        }

        public string Tipo { get; set; }

    }

    public class N_Recepcion_Detalle
    {
        private string _temperatura;
        private string _hora_recepcion;
        private string _peso_pallet;
        private string _rejillas;
        private string _folio;
        private string _peso_promedio;
        private string _destino;
        private string _numero_lote;
        private string _sub_lote;
        private string _descarga;
        private string _comentario;
        private string _responsable;
        private string _tipo_rejilla_bandeja;
        private string _cantidad;
        private string _kilos_brutos;
        private string _tara;
        private string _kilos_netos;

        public string Kilos_netos
        {
            get { return _kilos_netos; }
            set { _kilos_netos = value; }
        }

        public string Tara
        {
            get { return _tara; }
            set { _tara = value; }
        }

        public string Kilos_brutos
        {
            get { return _kilos_brutos; }
            set { _kilos_brutos = value; }
        }

        public string Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        public string Tipo_rejilla_bandeja
        {
            get { return _tipo_rejilla_bandeja; }
            set { _tipo_rejilla_bandeja = value; }
        }

        public string Responsable
        {
            get { return _responsable; }
            set { _responsable = value; }
        }

        public string Comentario
        {
            get { return _comentario; }
            set { _comentario = value; }
        }

        public string Descarga
        {
            get { return _descarga; }
            set { _descarga = value; }
        }

        public string Sub_lote
        {
            get { return _sub_lote; }
            set { _sub_lote = value; }
        }

        public string Numero_lote
        {
            get { return _numero_lote; }
            set { _numero_lote = value; }
        }

        public string Destino
        {
            get { return _destino; }
            set { _destino = value; }
        }

        public string Peso_promedio
        {
            get { return _peso_promedio; }
            set { _peso_promedio = value; }
        }

        public string Folio
        {
            get { return _folio; }
            set { _folio = value; }
        }

        public string Peso_rejillas
        {
            get { return _rejillas; }
            set { _rejillas = value; }
        }

        public string Peso_pallet
        {
            get { return _peso_pallet; }
            set { _peso_pallet = value; }
        }

        public string Hora_recepcion
        {
            get { return _hora_recepcion; }
            set { _hora_recepcion = value; }
        }

        public string Temperatura
        {
            get { return _temperatura; }
            set { _temperatura = value; }
        }

        public string Posicion_Pallet { get; set; }

    }
}
