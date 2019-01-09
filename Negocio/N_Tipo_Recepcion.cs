using Datos;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_Tipo_Recepcion
    {
        public List<E_Tipo_Recepcion> Lista()
        {
            D_Tipo_Recepcion objeto1 = new D_Tipo_Recepcion();
            return objeto1.Lista();
        }

        public bool Agregar(E_Tipo_Recepcion tipo1)
        {
            D_Tipo_Recepcion tipo = new D_Tipo_Recepcion();
            return tipo.Agregar(tipo1);
        }

        public bool Modificar(E_Tipo_Recepcion tipo1)
        {
            D_Tipo_Recepcion tipo = new D_Tipo_Recepcion();
            return tipo.Modificar(tipo1);
        }

        public bool Borrar(string tipo1)
        {
            D_Tipo_Recepcion tipo = new D_Tipo_Recepcion();
            return tipo.Borrar(tipo1);
        }
    }
}
