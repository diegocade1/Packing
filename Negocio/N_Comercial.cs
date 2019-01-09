using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entity;

namespace Negocio
{
    public class N_Comercial
    {

        //Clase datos
        D_Comercial comercial1 = new D_Comercial();
             

        //propiedades
        public E_Comercial Detalle { get; set; }
        public string Mensaje { get; set; }

        public bool Agregar()
        {
            bool estado;
            if (comercial1.Conectar() == true)
            {
                estado = comercial1.Agregar(Detalle);

                if (estado == false)
                    Mensaje = comercial1.Mensaje;
                else
                    Mensaje = "";

               // UltimoID = recepcion1.Ultimo_ID();

            }
            else
            {
                // UltimoID = 0;
                Mensaje = "Error en Conexion";
                estado = false;
            }

            return estado;
        }

        public bool Validacion_Folio()
        {
            bool estado;
            if (comercial1.Conectar() == true)
            {
                estado = comercial1.Validacion_Folio(Detalle);
                if (estado != false)
                {
                    Mensaje = comercial1.Mensaje;
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

        public bool Existe_Pallet(E_Pallet_Comercial pallet)
        {
            D_Comercial comercial1 = new D_Comercial();

            return comercial1.Existe_Pallet(pallet);

        }

        #endregion

    }
}
