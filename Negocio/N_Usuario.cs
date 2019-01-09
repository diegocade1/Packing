using Datos;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_Usuario
    {
        public List<E_Usuario> Lista()
        {
            D_Usuario usuario = new D_Usuario();
            return usuario.Lista();
        }

        public bool Agregar(E_Usuario usuario1)
        {
            D_Usuario usuario = new D_Usuario();
            return usuario.Agregar(usuario1);
        }

        public bool Modificar(E_Usuario usuario1)
        {
            D_Usuario usuario = new D_Usuario();
            return usuario.Modificar(usuario1);
        }

        public bool Borrar(string usuario1)
        {
            D_Usuario usuario = new D_Usuario();
            return usuario.Borrar(usuario1);
        }

        public E_Usuario ObtenerUsuario(string usuario1)
        {
            D_Usuario usuario = new D_Usuario();
            return usuario.LeerUsuario(usuario1);
        }
    }
}
