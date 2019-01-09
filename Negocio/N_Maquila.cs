using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Datos;

namespace Negocio
{
    public class N_Maquila
    {
        D_Maquila maquila1= new D_Maquila();
        public E_Maquila Maquila { get; set; }

        public E_Maquila Maquila_Recepcion { get; set; }
        public E_Maquila Maquila_Exportacion { get; set; }

        public bool Agregar()
        {
            bool estado;
            if (maquila1.Conectar() == true)
            {
                estado = maquila1.Agregar(Maquila);
                Maquila.ID =  maquila1.Ultimo_ID();
            }
            else
            {
                estado = false;
            }

            return estado;
        }

        //recepcion
        public bool Modificar_Estado(string folio, string maquila)
        {
            return maquila1.Modificar_Estado(folio, maquila);
        }

        //exportacion
        public bool Modificar_Estado_Exportacion(E_Pallet_Exportacion exportacion1, string maquila)
        {
            return maquila1.Modificar_Estado_Exportacion(exportacion1, maquila);
        }

        public bool Modificar_Estado_Comercial(string folio, string maquila)
        {
            return maquila1.Modificar_Estado_Comercial(folio, maquila);
        }
    }
}
