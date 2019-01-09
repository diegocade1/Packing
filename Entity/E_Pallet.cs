using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class E_Pallet
    {
        public string ID_Cliente { get; set; }
        public string ID_Productor { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public double Peso { get; set; }
        public int Cajas { get; set; }
        public double Total_Peso { get; set; }
        public string Estado { get; set; }
        
    }

    public class E_pallet_Recepcion:E_Pallet
    {
        public string ID_Bandeja { get; set; }
        public string Bandeja { get; set; }
        public int Cantidad_Bandejas { get; set; }
        public double Kilos_Brutos { get; set; }
        public string ID_Pallet { get; set; }
        public string Pallet { get; set; }


        
    }

    public class E_Pallet_Exportacion:E_Pallet
    {
        public string Embalaje { get; set; }
        public int Potes { get; set; } //clunch
    }

    public class E_Pallet_Comercial:E_Pallet
    {        
        public string ID_Tipo { get; set; }
        public string Tipo { get; set; }
        public double Kilos_Netos { get; set; }
    }

}
