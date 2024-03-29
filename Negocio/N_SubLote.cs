﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entity;

namespace Negocio
{
    public class N_SubLote
    {
        D_SubLote subloteRecepcion = new D_SubLote();
        public bool Existe_Pallet_recepcion(E_Recepcionado_sublote recepcion)
        {
            if (subloteRecepcion.Existe_Pallet_recepcion(recepcion) == true) //Primer registro nuevo encabezado
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Existe_Guia_recepcion(E_Recepcionado_sublote recepcion)
        {
            if (subloteRecepcion.Existe_Guia_recepcion(recepcion) == true) //Primer registro nuevo encabezado
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public Decimal Descuento_por_Guia(string id_Productor,string guia)
        {

            return subloteRecepcion.Descuento_por_Guia(id_Productor, guia);

        }

        public bool ModificarSublotePorGuia(string ID_Productor, string guia)
        {
            return subloteRecepcion.ModificarSublotePorGuia(ID_Productor, guia);
        }




    }
}
