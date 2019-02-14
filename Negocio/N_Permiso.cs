using Datos;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_Permiso
    {
        public List<E_Permiso> Lista()
        {
            D_Permiso permiso1 = new D_Permiso();
            return permiso1.Lista();
        }
        public bool Agregar(E_Permiso permiso1)
        {
            D_Permiso productor = new D_Permiso();
            return productor.Agregar(permiso1);
        }

        public bool Modificar(E_Permiso permiso1)
        {
            D_Permiso productor = new D_Permiso();
            return productor.Modificar(permiso1);
        }

        public bool Borrar(string permiso1)
        {
            D_Permiso productor = new D_Permiso();
            return productor.Borrar(permiso1);
        }
    }
}
