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

    }
}
