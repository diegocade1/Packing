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
        public E_Pallet ObtenerPallet(string id)
        {
            D_Pallet objeto1 = new D_Pallet();
            return objeto1.ObtenerPallet(id);
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

        public void SetPrefijoActivo()
        {
            D_Pallet pallet = new D_Pallet();
            E_Pallet_General.Prefijo = pallet.GetPrefijoActivo();
        }
        public string GetPrefijoActivo()
        {
            return E_Pallet_General.Prefijo;
        }

        public bool ValidaPrefijoActivo(string folio)
        {
            string prefijoActivo = GetPrefijoActivo();
            int largo = prefijoActivo.Length;
            if (largo > -1)
            {
                string prefijoFolio = folio.Substring(0, largo);
                if (prefijoActivo != prefijoFolio)
                {
                    return false;
                }
                else
                    return true;
            }
            else
            {
                //retorna verdadero para que lo acepte sin validar pensar en dejar opcion para que no valide
                return true;
            }
        }
    }
}