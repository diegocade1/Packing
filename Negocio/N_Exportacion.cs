using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entity;

namespace Negocio
{
    public class N_Exportacion
    {
        D_Exportacion exportacion1 = new D_Exportacion();
        public string Mensaje { get; set; }
        public E_Exportacion Exportacion { get; set; }

        public bool Agregar()
        {
            bool estado;
            if (exportacion1.Conectar() == true)
            {
                estado = exportacion1.Agregar(Exportacion);                
            }
            else
            {                
                estado = false;
            }

            return estado;
        }
        public bool Validacion_Folio()
        {
            bool estado;
            if (exportacion1.Conectar() == true)
            {
                estado = exportacion1.Validacion_Folio(Exportacion);
                if (estado != false)
                {
                    Mensaje = exportacion1.Mensaje;
                }
                else
                {
                    Mensaje = "";
                }
            }
            else
            {
                // UltimoID = 0;
                Mensaje = "Error en Conexion";
                estado = false;
            }
            return estado;
        }

        #region validacion Pallet

        public bool Existe_Pallet(E_Pallet_Exportacion pallet)
        {
            D_Exportacion exportacion1 = new D_Exportacion();

            return exportacion1.Existe_Pallet(pallet);

        }

        #endregion

    }
}
