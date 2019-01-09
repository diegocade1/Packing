using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Datos;


namespace Negocio
{
    public class N_Bandeja
    {
        public List<E_Bandeja> Lista()
        {
            D_Bandeja objeto1 = new D_Bandeja();
            return objeto1.Lista();
        }

        public double Peso(string ID)
        {
            D_Bandeja objeto1 = new D_Bandeja();
            return objeto1.Peso(ID);
        }

        public bool Agregar(E_Bandeja bandeja1)
        {
            D_Bandeja bandeja = new D_Bandeja();
            return bandeja.Agregar(bandeja1);
        }

        public bool Modificar(E_Bandeja bandeja1)
        {
            D_Bandeja bandeja = new D_Bandeja();
            return bandeja.Modificar(bandeja1);
        }

        public bool Borrar(string bandeja1)
        {
            D_Bandeja bandeja = new D_Bandeja();
            return bandeja.Borrar(bandeja1);
        }
    }
}
