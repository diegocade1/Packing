using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class E_Exportacion
    {
        public string ID_Cliente { get; set; }
        public string Cliente { get; set; }
        public string ID_Especie { get; set; }
        public string Especie { get; set; }
        public string ID_Embalaje { get; set; }
        public string Embalaje { get; set; }
        public string ID_Etiqueta { get; set; }
        public string Etiqueta { get; set; }
        public string ID_TipoArmado { get; set; }
        public string TipoArmado { get; set; }
        public string Folio { get; set; }
        public string ID_TipoMercado { get; set; }
        public string TipoMercado { get; set; }
        public string ID_Productor { get; set; }  //tomar codigo
        public string Productor { get; set; }
        public string ID_Variedad { get; set; }        
        public string Variedad { get; set; }
        public string Fecha { get; set; }        
        public string Cantidad_Cajas { get; set; }
        public string Documento { get; set; }       
        public string Responsable { get; set; }
        public string Hora { get; set; }
      
    }
}
