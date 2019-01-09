using Datos;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_TipoComercial
    {
        public List<E_TipoComercial> Lista()
        {
            D_TipoComercial objeto1 = new D_TipoComercial();
            return objeto1.Lista();
        }

        public bool Agregar(E_TipoComercial tipo1)
        {
            D_TipoComercial tipo = new D_TipoComercial();
            return tipo.Agregar(tipo1);
        }

        public bool Modificar(E_TipoComercial tipo1)
        {
            D_TipoComercial tipo = new D_TipoComercial();
            return tipo.Modificar(tipo1);
        }

        public bool Borrar(string tipo1)
        {
            D_TipoComercial tipo = new D_TipoComercial();
            return tipo.Borrar(tipo1);
        }
    }
}
