using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Impresion
{
    public class N_Exportacion_Encabezado
    {
        private string _cliente;
        private string _fecha_armado;
        private string _tipo_transporte; // maritimo, guarda,aereo
        private string _tipo_accion;// exportacion,devolucion,rechazo,reembalaje
        private string _especie;
        private string _embalaje;
        private string _etiqueta;
        private string _n_folio_repo;
        private string _temperatura;
        private string _co2;
        private string _tipo_detalle;//Nombre productor, repaletizaje   
        private string _nombre_encargado;
        private string _total_num_cajas;

        public string Total_num_cajas
        {
            get { return _total_num_cajas; }
            set { _total_num_cajas = value; }
        }

        public string Nombre_encargado
        {
            get { return _nombre_encargado; }
            set { _nombre_encargado = value; }
        }

        public string Tipo_detalle
        {
            get { return _tipo_detalle; }
            set { _tipo_detalle = value; }
        }


        public string Co2
        {
            get { return _co2; }
            set { _co2 = value; }
        }

        public string Temperatura
        {
            get { return _temperatura; }
            set { _temperatura = value; }
        }

        public string N_folio_repo
        {
            get { return _n_folio_repo; }
            set { _n_folio_repo = value; }
        }

        public string Etiqueta
        {
            get { return _etiqueta; }
            set { _etiqueta = value; }
        }

        public string Embalaje
        {
            get { return _embalaje; }
            set { _embalaje = value; }
        }

        public string Especie
        {
            get { return _especie; }
            set { _especie = value; }
        }

        public string Tipo_accion
        {
            get { return _tipo_accion; }
            set { _tipo_accion = value; }
        }

        public string Tipo_transporte
        {
            get { return _tipo_transporte; }
            set { _tipo_transporte = value; }
        }

        public string Fecha_armado
        {
            get { return _fecha_armado; }
            set { _fecha_armado = value; }
        }

        public string Cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }

    }

    public class N_Exportacion_Detalle
    {
        private string _mes;
        private string _dia;
        private string _anio;
        private string _codigo_productor;
        private string _variedad;
        private string _guia_productor;
        private string _numero_caja;
        private string _descripcion_productor;

        public string Descripcion_productor
        {
            get { return _descripcion_productor; }
            set { _descripcion_productor = value; }
        }

        public string Numero_caja
        {
            get { return _numero_caja; }
            set { _numero_caja = value; }
        }

        public string Guia_productor
        {
            get { return _guia_productor; }
            set { _guia_productor = value; }
        }

        public string Variedad
        {
            get { return _variedad; }
            set { _variedad = value; }
        }

        public string Codigo_productor
        {
            get { return _codigo_productor; }
            set { _codigo_productor = value; }
        }

        public string Anio
        {
            get { return _anio; }
            set { _anio = value; }
        }

        public string Dia
        {
            get { return _dia; }
            set { _dia = value; }
        }

        public string Mes
        {
            get { return _mes; }
            set { _mes = value; }
        }

    }

}
