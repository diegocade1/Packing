using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entity;

namespace Negocio
{
    public class N_Etiqueta
    {
        public List<E_Etiqueta> Lista()
        {
            D_Etiqueta objeto1 = new D_Etiqueta();
            return objeto1.Lista();
        }

        public List<E_Etiqueta> ListaCliente(string cliente)
        {
            D_Etiqueta objeto1 = new D_Etiqueta();
            return objeto1.ListaCliente(cliente);
        }
        public bool Agregar(E_Etiqueta etiqueta1,string especie,string cliente)
        {
            D_Etiqueta etiqueta = new D_Etiqueta();
            return etiqueta.Agregar(etiqueta1,especie,cliente);
        }

        public bool Modificar(E_Etiqueta etiqueta1, string especie, string cliente)
        {
            D_Etiqueta etiqueta = new D_Etiqueta();
            return etiqueta.Modificar(etiqueta1,especie,cliente);
        }

        public bool Borrar(string etiqueta1)
        {
            D_Etiqueta etiqueta = new D_Etiqueta();
            return etiqueta.Borrar(etiqueta1);
        }

        //Obtener etqiueta con todos los datos
        public E_Etiqueta_EC ObtenerEtiqueta(string etiqueta1)
        {
            D_Etiqueta etiqueta = new D_Etiqueta();
            return etiqueta.LeerEtiqueta(etiqueta1);
        }

        public List<E_Etiqueta_EC> Lista_EC()
        {
            D_Etiqueta objeto1 = new D_Etiqueta();
            return objeto1.Lista_EC();
        }

        // Listar etiqueta con todos los datos
    }
}
