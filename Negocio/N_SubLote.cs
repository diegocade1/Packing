using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entity;

namespace Negocio
{
    public class N_SubLote
    {
        D_SubLote subloteRecepcion = new D_SubLote();
        public bool Existe_Pallet_recepcion(E_Recepcionado_sublote recepcion)
        {
            if (subloteRecepcion.Existe_Pallet_recepcion(recepcion) == true) //Primer registro nuevo encabezado
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
