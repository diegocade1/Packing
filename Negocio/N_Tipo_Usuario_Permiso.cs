using Datos;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_Tipo_Usuario_Permiso
    {
        public string Mensaje { set; get; }
        public List<E_Tipo_Usuario_Permiso> Lista()
        {
            D_Tipo_Usuario_Permiso usuario = new D_Tipo_Usuario_Permiso();
            return usuario.Lista();
        }

        public E_Tipo_Usuario_Permiso ObtenerPermisos(string id_tipo_usuario)
        {
            D_Tipo_Usuario_Permiso usuario = new D_Tipo_Usuario_Permiso();
            return usuario.LeerTipoUsuarioPermisos(id_tipo_usuario);
        }

        public bool Agregar(E_Tipo_Usuario_Permiso usuario1)
        {
            D_Tipo_Usuario_Permiso usuario = new D_Tipo_Usuario_Permiso();
            if(usuario.Agregar(usuario1))
            {
                return true;
            }
            else
            {
                Mensaje = usuario.Mensaje;
                return false;
            }
            
        }

        public bool Modificar(E_Tipo_Usuario_Permiso usuario1)
        {
            D_Tipo_Usuario_Permiso usuario = new D_Tipo_Usuario_Permiso();
            return usuario.Modificar(usuario1);
        }

        public bool Borrar(string usuario1)
        {
            D_Tipo_Usuario_Permiso usuario = new D_Tipo_Usuario_Permiso();
            return usuario.Borrar(usuario1);
        }
    }
}
