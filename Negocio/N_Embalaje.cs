using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Datos;

namespace Negocio
{
    public class N_Embalaje
    {

        public List<E_Embalaje> Lista()
        {
            D_Embalaje objeto1 = new D_Embalaje();
            return objeto1.Lista();
        }
        public E_Embalaje ObtenerEmbalaje(string id)
        {
            D_Embalaje objeto1 = new D_Embalaje();
            return objeto1.ObtenerEmbalaje(id);
        }
        public List<E_Embalaje> ListaCliente(string cliente)
        {
            D_Embalaje objeto1 = new D_Embalaje();
            return objeto1.ListaCliente(cliente);
        }
        public double Peso1(string ID)
        {
            D_Embalaje objeto1 = new D_Embalaje();
            return objeto1.Peso(ID);
        }

        public bool Agregar(E_Embalaje caja1)
        {
            D_Embalaje caja = new D_Embalaje();
            return caja.Agregar(caja1);
        }

        public bool Modificar(E_Embalaje caja1)
        {
            D_Embalaje caja = new D_Embalaje ();
            return caja.Modificar(caja1);
        }

        public bool Borrar(string caja1)
        {
            D_Embalaje caja = new D_Embalaje();
            return caja.Borrar(caja1);
        }


    }
}
