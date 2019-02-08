using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class E_Maquila
    {
        public int ID { get; set; }        
        public string ID_Cliente { get; set; }
        public string Cliente { get; set; }
        public string ID_Productor { get; set; }  //tomar codigo
        public string Productor { get; set; }
        public string Lote { get; set; }
        public string Documento { get; set; }
        public DateTime Fecha_Recepcion { get; set; }
        public DateTime Fecha_Proceso { get; set; }
        public string OrdenEmbalaje { get; set; }
        public string Linea { get; set; }
        public DateTime Hora_Inicio { get; set; }
        public DateTime Hora_Termino { get; set; }
        public string Rendimiento { get; set; }
        public decimal Kilos_PesoTeorico { get; set; }
        public decimal Kilos_Comerciales { get; set; }
        public decimal Kilos_Merma { get; set; }
        public decimal Kilos_Recepcion { get; set; }
        public decimal Descuento_SubLote { get; set; }
        public string Usuario { get; set; }
    }
}
