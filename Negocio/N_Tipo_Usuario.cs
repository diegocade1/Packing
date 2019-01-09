using Datos;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_Tipo_Usuario
    {
        public List<E_Tipo_Usuario> Lista()
        {
            D_Tipo_Usuario usuario = new D_Tipo_Usuario();
            return usuario.Lista();
        }

        public bool Agregar(E_Tipo_Usuario usuario1)
        {
            D_Tipo_Usuario usuario = new D_Tipo_Usuario();
            return usuario.Agregar(usuario1);
        }

        public bool Modificar(E_Tipo_Usuario usuario1)
        {
            D_Tipo_Usuario usuario = new D_Tipo_Usuario();
            return usuario.Modificar(usuario1);
        }

        public bool Borrar(string usuario1)
        {
            D_Tipo_Usuario usuario = new D_Tipo_Usuario();
            return usuario.Borrar(usuario1);
        }
    }
}
