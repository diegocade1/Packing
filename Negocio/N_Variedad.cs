using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Datos;

namespace Negocio
{
   public class N_Variedad
    {
        public List<E_Variedad> Lista()
        {
            D_Variedad objeto1 = new D_Variedad();
            return objeto1.Lista();
        }

        public bool Agregar(E_Variedad variedad1)
        {
            D_Variedad variedad = new D_Variedad();
            return variedad.Agregar(variedad1);
        }

        public bool Modificar(E_Variedad variedad1)
        {
            D_Variedad variedad = new D_Variedad();
            return variedad.Modificar(variedad1);
        }

        public bool Borrar(string variedad1)
        {
            D_Variedad variedad = new D_Variedad();
            return variedad.Borrar(variedad1);
        }

    }
}
