using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Datos;

namespace Negocio
{
    public class N_TipoArmado
    {
        public List<E_TipoArmado> Lista()
        {
            D_TipoArmado objeto1 = new D_TipoArmado();
            return objeto1.Lista();
        }
        public E_TipoArmado ObtenerTipoArmado(string id)
        {
            D_TipoArmado objeto1 = new D_TipoArmado();
            return objeto1.ObtenerTipoArmado(id);
        }
        public bool Agregar(E_TipoArmado tipo1)
        {
            D_TipoArmado tipo = new D_TipoArmado();
            return tipo.Agregar(tipo1);
        }

        public bool Modificar(E_TipoArmado tipo1)
        {
            D_TipoArmado tipo = new D_TipoArmado();
            return tipo.Modificar(tipo1);
        }

        public bool Borrar(string tipo1)
        {
            D_TipoArmado tipo = new D_TipoArmado();
            return tipo.Borrar(tipo1);
        }
    }
}
