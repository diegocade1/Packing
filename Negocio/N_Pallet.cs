using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Datos;

namespace Negocio
{
    public class N_Pallet
    {

        public List<E_Pallet> Lista()
        {
            D_Pallet objeto1 = new D_Pallet();
            return objeto1.Lista();
        }


        public double Peso(string ID)
        {
            D_Pallet objeto1 = new D_Pallet();
            return objeto1.Peso(ID);
        }

        public bool Agregar(E_Pallet pallet1)
        {
            D_Pallet pallet = new D_Pallet();
            return pallet.Agregar(pallet1);
        }

        public bool Modificar(E_Pallet pallet1)
        {
            D_Pallet pallet = new D_Pallet();
            return pallet.Modificar(pallet1);
        }

        public bool Borrar(string pallet1)
        {
            D_Pallet pallet = new D_Pallet();
            return pallet.Borrar(pallet1);
        }
    }
}
