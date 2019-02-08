using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Impresion
{
    public class N_Maquila_Encabezado
    {
        private string _exportador;
        private string _productor;
        private string _guia_despacho;
        private string _numero_lote;
        private string _fecha_recepcion;
        private string _orden_embalaje;

        public string Orden_embalaje
        {
            get { return _orden_embalaje; }
            set { _orden_embalaje = value; }
        }

        public string Fecha_recepcion
        {
            get { return _fecha_recepcion; }
            set { _fecha_recepcion = value; }
        }
        public string Fecha_Proceso { get; set; }

        public string Numero_lote
        {
            get { return _numero_lote; }
            set { _numero_lote = value; }
        }

        public string Linea { get; set; }

        public string Hora_Inicio { get; set; }

        public string Hora_Termino { get; set; }

        public string Rendimiento { get; set; }

        public string Guia_despacho
        {
            get { return _guia_despacho; }
            set { _guia_despacho = value; }
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
    }

    public class N_Maquila_Detalle_Recepcion
    {
        private string _folio_pallet;
        private string _total_kilos_netos;

        public string Total_kilos_netos
        {
            get { return _total_kilos_netos; }
            set { _total_kilos_netos = value; }
        }

        public string Folio_pallet
        {
            get { return _folio_pallet; }
            set { _folio_pallet = value; }
        }
       
    }

    public class N_Maquila_Cajas
    {
        private string _numero_pallet;
        private string _formato;
        private string _peso_teorico;
        private string _cajas;
        private string _total_peso_teorico;

        public string Total_peso_teorico
        {
            get { return _total_peso_teorico; }
            set { _total_peso_teorico = value; }
        }

        public string Cajas
        {
            get { return _cajas; }
            set { _cajas = value; }
        }

        public string Peso_teorico
        {
            get { return _peso_teorico; }
            set { _peso_teorico = value; }
        }

        public string Formato
        {
            get { return _formato; }
            set { _formato = value; }
        }

        public string Numero_pallet
        {
            get { return _numero_pallet; }
            set { _numero_pallet = value; }
        }

    }

    public class N_Maquila_Salida
    {
        private string _fecha_proceso;
        private string _lineas;
        private string _hora_inicio;
        private string _hora_termino;
        private string _rendimiento;

        public string Rendimiento
        {
            get { return _rendimiento; }
            set { _rendimiento = value; }
        }

        public string Hora_termino
        {
            get { return _hora_termino; }
            set { _hora_termino = value; }
        }

        public string Hora_inicio
        {
            get { return _hora_inicio; }
            set { _hora_inicio = value; }
        }

        public string Lineas
        {
            get { return _lineas; }
            set { _lineas = value; }
        }

        public string Fecha_proceso
        {
            get { return _fecha_proceso; }
            set { _fecha_proceso = value; }
        }
    }

    public class N_Maquila_Salida_Detalle
    {
        private string _kilos_comerciales;
        private string _kilos_merma;

        public string Kilos_merma
        {
            get { return _kilos_merma; }
            set { _kilos_merma = value; }
        }

        public string Kilos_comerciales
        {
            get { return _kilos_comerciales; }
            set { _kilos_comerciales = value; }
        }

    }
}
