using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Datos;

namespace Negocio
{
    public class N_TipoMercado
    {
        public List<E_TipoMercado> Lista()
        {
            D_TipoMercado objeto1 = new D_TipoMercado();
            return objeto1.Lista();
        }
        public bool Agregar(E_TipoMercado tipo1)
        {
            D_TipoMercado tipo = new D_TipoMercado();
            return tipo.Agregar(tipo1);
        }

        public bool Modificar(E_TipoMercado tipo1)
        {
            D_TipoMercado tipo = new D_TipoMercado();
            return tipo.Modificar(tipo1);
        }

        public bool Borrar(string tipo1)
        {
            D_TipoMercado tipo = new D_TipoMercado();
            return tipo.Borrar(tipo1);
        }
    }
}
