using Datos;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_Prefijo
    {
        public List<E_Prefijo> Lista()
        {
            D_Prefijo prefijo1 = new D_Prefijo();
            return prefijo1.Lista();
        }
        public bool AgregarPrefijoActivo(E_Prefijo prefijo)
        {
            D_Prefijo prefijo1 = new D_Prefijo();
            return prefijo1.AgregarPrefijoActivo(prefijo);
        }
        public bool ActualizarPrefijoActivo(E_Prefijo prefijo)
        {
            D_Prefijo prefijo1 = new D_Prefijo();
            return prefijo1.ActualizarPrefijoActivo(prefijo);
        }
        public bool ActualizarPrefijoActivoTodoFalso()
        {
            D_Prefijo prefijo1 = new D_Prefijo();
            return prefijo1.ActualizarPrefijoActivoTodoFalso();
        }
        public bool BorrarPrefijoActivo(string ID)
        {
            D_Prefijo prefijo1 = new D_Prefijo();
            return prefijo1.BorrarPrefijoActivo(ID);
        }

        public E_Prefijo ObtenerPrefijoActivo(string id)
        {
            D_Prefijo prefijo1 = new D_Prefijo();
            return prefijo1.LeerPrefijoActivo(id);
        }
    }
}
