using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class E_Etiqueta
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
    }

    public class E_Etiqueta_EC : E_Etiqueta
    {
        public string Especie { set; get; }
        public string Cliente { set; get; }
    }

    public class E_Etiqueta_C : E_Etiqueta
    {
        public string Cliente { set; get; }
    }
}
