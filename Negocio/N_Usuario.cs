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
        public string Mensaje { get; set; }
        public List<E_Usuario> Lista()
        {
            D_Usuario usuario = new D_Usuario();
            List<E_Usuario> lista = usuario.Lista();
            Mensaje = usuario.Mensaje;
            return lista;
        }

        public bool Agregar(E_Usuario usuario1)
        {
            D_Usuario usuario = new D_Usuario();
            bool estado = usuario.Agregar(usuario1);
            Mensaje = usuario.Mensaje;
            return estado;
        }

        public bool Modificar(E_Usuario usuario1)
        {
            D_Usuario usuario = new D_Usuario();
            bool estado = usuario.Modificar(usuario1);
            Mensaje = usuario.Mensaje;
            return estado;
        }

        public bool Borrar(string usuario1)
        {
            D_Usuario usuario = new D_Usuario();
            bool estado = usuario.Borrar(usuario1);
            Mensaje = usuario.Mensaje;
            return estado;
        }

        public E_Usuario ObtenerUsuario(string usuario1)
        {
            D_Usuario usuario = new D_Usuario();
            E_Usuario usuario2 = usuario.LeerUsuario(usuario1);
            Mensaje = usuario.Mensaje;
            return usuario2;
        }
    }
}
