using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class E_Recepcion_Detalle
    {
        // public string ID_Recepcion { get; set; }
        // public string Item { get; set; }
        // public string ID_bandeja { get; set; }
        // public string Bandeja { get; set; }
        // public string Peso_Bandeja { get; set; }
        // public string Cantidad_Bandejas { get; set; }
        // public string ID_Descarga { get; set; }
        //// public string Descarga { get; set; } //esta en el encabezado
        // public string Folio { get; set; }
        // public string Kilos_Brutos { get; set; } 
        // public string Tara { get; set; }
        // public string Kilos_Netos { get; set; }
        // public string ID_Pallet { get; set; }
        // public string Tipo_Pallet { get; set; }
        // public string Peso_Pallet { get; set; }
        // public string Comentario { get; set; }           
        // public string Hora { get; set; }
        public string ID { get; set; }
        public string ID_Recepcion { get; set; }
        public string Item { get; set; }
        public string ID_bandeja { get; set; }
        public string Bandeja { get; set; }
        public string Peso_Bandeja { get; set; }
        public string Cantidad_Bandejas { get; set; }
        public string ID_Descarga { get; set; }
        // public string Descarga { get; set; } //esta en el encabezado
        public string Folio { get; set; }
        public string Kilos_Brutos { get; set; }
        public string Tara { get; set; }
        public string Kilos_Netos { get; set; }
        public string ID_Pallet { get; set; }
        public string Tipo_Pallet { get; set; }
        public string Peso_Pallet { get; set; }
        public string Peso_Promedio { get; set; }
        public string Comentario { get; set; }
        public string Hora { get; set; }
        public string Posicion { get; set; }
        public string Usuario { get; set; }
        public string Fecha { get; set; }
        public string Sublote { get; set; }

    }

    public class E_Recepcion_Encabezado
    {
        public string ID_Registro { get; set; }
        public string ID_Cliente { get; set; }
        public string Cliente { get; set; }
        public string Codigo_Productor { get; set; }
        public string Productor { get; set; }
        public string Chofer { get; set; }
        public string Guia { get; set; }
        public string ID_Especie { get; set; }
        public string Especie { get; set; }
        public string ID_Descarga { get; set; }
        public string Descarga { get; set; }
        public string Temperatura { get; set; }
        public string ID_Destino { get; set; }
        public string Destino { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string Lote { get; set; }
        public string Responsable { get; set; }
        public string Cantidad_Pallets { get; set; }
        public string ID_Tipo { get; set; }
        public string Tipo { get; set; }

        //public string ID_Cliente { get; set; }
        //public string Cliente { get; set; }
        //public string Codigo_Productor { get; set; }
        //public string Productor { get; set; }
        //public string Chofer { get; set; }
        //public string Guia { get; set; }
        //public string ID_Especie { get; set; }
        //public string Especie { get; set; }
        //public string ID_Descarga { get; set; }
        //public string Descarga { get; set; }
        //public string Temperatura { get; set; }
        //public string ID_Destino { get; set; }
        //public string Destino { get; set; }
        //public string Fecha { get; set; }
        //public string Hora { get; set; }
        //public string Lote { get; set; }
        //public string Responsable { get; set; }


    }

    public class E_Recepcionado_sublote
    {
        public string ID_Registro { get; set; }
        public string ID_Cliente { get; set; }
        public string Cliente { get; set; }
        public string Codigo_Productor { get; set; }
        public string Productor { get; set; }
        public string Chofer { get; set; }
        public string Guia { get; set; }
        public string ID_Especie { get; set; }
        public string Especie { get; set; }
        public string ID_Descarga { get; set; }
        public string Descarga { get; set; }
        public string Temperatura { get; set; }
        public string ID_Destino { get; set; }
        public string Destino { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string Lote { get; set; }
        public string Usuario { get; set; }
        public string Total_Pallet { get; set; }
      
        public string Item { get; set; }
        public string ID_bandeja { get; set; }
        public string Bandeja { get; set; }
        public string Peso_Bandeja { get; set; }
        public string Cantidad_Bandejas { get; set; }
        public string Folio { get; set; }
        public string Kilos_Brutos { get; set; }
        public string Tara { get; set; }
        public string Kilos_Netos { get; set; }
        public string ID_Pallet { get; set; }
        public string Tipo_Pallet { get; set; }
        public string Peso_Pallet { get; set; }
        public string Peso_Promedio { get; set; }
        public string Comentario { get; set; }
        public string Estado { get; set; }
        public string ID_Tipo { get; set; }
        public string Tipo { get; set; }


    }



}
