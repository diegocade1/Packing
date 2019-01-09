using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class E_Comercial
    {
        public string ID_Cliente { get; set; }
        public string Cliente { get; set; }
        public string ID_Productor { get; set; }
        public string Productor { get; set; }
        public string ID_Especie { get; set; }
        public string Especie { get; set; }
        public string ID_Tipo { get; set; }
        public string Tipo { get; set; }
        public int Total_Pallet { get; set; }
        public string ID_Bandeja { get; set; }
        public string Bandeja { get; set; }
        public string ID_Pallet { get; set; }
        public string Pallet { get; set; }
        public double Kilos_Brutos { get; set; }
        public double Tara { get; set; }
        public double Kilos_Netos { get; set; }
        public int Cantidad_Bandejas { get; set; }
        public string Folio { get; set; }
        public string Fecha { get; set; }


    }    
}
