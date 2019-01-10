using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class E_Embalaje
    {
        public string ID { get; set; }
        public string Descripcion { get; set; }
        public double Peso { get; set; }
        public int Potes { get; set; }
        public int ID_Cliente { set; get; }
    }
}
