using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entity;

namespace Negocio
{
    public class N_Recepcion
    {
        D_Recepcion recepcion1 = new D_Recepcion();
        public string Mensaje { get; set; }
        public E_Recepcion_Encabezado Encabezado { get; set; }
        public E_Recepcion_Detalle Detalle { get; set; }
        public int UltimoID { get; set; }
        public int CantidadPallets { set; get; }
        public int Posicion { set; get; }
        public bool nuevo;
        public bool Agregar_Encabezado()
        {
            bool estado;
            if (recepcion1.Conectar() == true)
            {
                if (recepcion1.Existe_ID_recepcion(Encabezado) == true) //Primer registro nuevo encabezado
                {
                    estado = true;
                    UltimoID = Convert.ToInt32(Encabezado.ID_Registro);
                    CantidadPallets = Convert.ToInt32(Encabezado.Cantidad_Pallets);
                    Posicion = Convert.ToInt32(recepcion1.posicion);
                    nuevo = false;
                }
                else //encabezado registrado no es el primer registro
                {
                    if(recepcion1.Validacion_Guia(Encabezado))
                    {
                        estado = false;
                        UltimoID = 0;
                        Mensaje = recepcion1.Mensaje;
                    }
                    else
                    {
                        estado = true;
                        nuevo = true;
                        Encabezado.Lote = recepcion1.Correlativo("Recepcion", "Recepcion").ToString();
                        estado = recepcion1.Agregar_Encabezado(Encabezado);
                        UltimoID = recepcion1.Ultimo_ID();
                    }
                }


                //estado = recepcion1.Agregar_Encabezado(Encabezado);
                //UltimoID = recepcion1.Ultimo_ID();

            }
            else
            {
                UltimoID = 0;
                estado = false;
            }

            return estado;
        }

         int Ultimo_ID()
        {
            return recepcion1.Ultimo_ID();
        }




            public bool Agregar_Detalle()
        {
            return recepcion1.Agregar_Detalle(Detalle);
        }

        public bool Modificar_Detalle()
        {
            return recepcion1.Modificar_Detalle(Detalle);
        }

        public bool Validacion_Folio()
        {
            bool estado;
            if (recepcion1.Conectar() == true)
            {
                estado = recepcion1.Validacion_Folio(Detalle);
                if (estado != false)
                {
                    Mensaje = recepcion1.Mensaje;
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

        public bool Validacion_Guia()
        {
            bool estado;
            if (recepcion1.Conectar() == true)
            {
                estado = recepcion1.Validacion_Guia(Encabezado);
                if (estado != false)
                {
                    Mensaje = recepcion1.Mensaje;
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

        public E_Recepcion_Encabezado Obtener_Encabezado()
        {
            E_Recepcion_Encabezado recepcion2;
            if (recepcion1.Conectar() == true)
            {
                recepcion2 = recepcion1.Obtener_Encabezado(Encabezado.Guia,Encabezado.Codigo_Productor);
                if (recepcion2 != null)
                {
                    return recepcion2;
                }
                else
                {
                    Mensaje = recepcion1.Mensaje;
                    return null;
                }
            }
            else
            {
                // UltimoID = 0;
                Mensaje = "Error en Conexion";
                return null;
            }
        }

        public E_Recepcion_Detalle Obtener_Detalle()
        {
            E_Recepcion_Detalle recepcion2;
            if (recepcion1.Conectar() == true)
            {
                recepcion2 = recepcion1.Obtener_Detalle_Recepcion(Detalle.ID);
                if (recepcion2 != null)
                {
                    return recepcion2;
                }
                else
                {
                    Mensaje = recepcion1.Mensaje;
                    return null;
                }
            }
            else
            {
                // UltimoID = 0;
                Mensaje = "Error en Conexion";
                return null;
            }
        }

        public bool ModificarCantidadPallets_Encabezado()
        {
            bool estado = recepcion1.ModificarCantidadPallets_Encabezado(Encabezado);
            Mensaje = recepcion1.Mensaje;
            return estado;
        }

        public List<E_Recepcion_Detalle> Obtener_Detalles_Recepcion()
        {
            if (recepcion1.Conectar() == true)
            {
                List<E_Recepcion_Detalle > lista = recepcion1.Obtener_Detalles_Recepcion(Encabezado.ID_Registro);
                Mensaje = recepcion1.Mensaje;

                return lista;
            }
            else
            {
                // UltimoID = 0;
                Mensaje = "Error en Conexion";
                return null;
            }
        }

        #region Metodos Destino
        public List<E_Destino> Lista_Destino()
        {
            D_Recepcion objeto1 = new D_Recepcion();
            return objeto1.Lista_Destino();
        }

        public bool Agregar_Destino(E_Destino destino1)
        {
            D_Recepcion destino = new D_Recepcion();
            return destino.Agregar_Destino(destino1);
        }

        public bool Modificar_Destino(E_Destino destino1)
        {
            D_Recepcion destino = new D_Recepcion();
            return destino.Modificar_Destino(destino1);
        }

        public bool Borrar_Destino(string destino1)
        {
            D_Recepcion destino = new D_Recepcion();
            return destino.Borrar_Destino(destino1);
        }

        #endregion
        #region Metodos Descarga
        public List<E_Descarga> Lista_Descarga()
        {
            D_Recepcion objeto1 = new D_Recepcion();
            return objeto1.Lista_Descarga();
        }

        public bool Agregar_Descarga(E_Descarga descarga1)
        {
            D_Recepcion descarga = new D_Recepcion();
            return descarga.Agregar_Descarga(descarga1);
        }

        public bool Modificar_Descarga(E_Descarga descarga1)
        {
            D_Recepcion descarga = new D_Recepcion();
            return descarga.Modificar_Descarga(descarga1);
        }

        public bool Borrar_Descarga(string descarga1)
        {
            D_Recepcion descarga = new D_Recepcion();
            return descarga.Borrar_Descarga(descarga1);
        }

        #endregion
        #region validacion Pallet
        //uso sublote busca solo por folio 
        public bool Existe_Pallet(string folio, E_Pallet pallet)
        {
            D_Recepcion recepcion1 = new D_Recepcion();

            return recepcion1.Existe_Pallet(folio, pallet);

        }

        public bool Existe_Pallet(E_Pallet pallet)
        {
            D_Recepcion recepcion1 = new D_Recepcion();

            return recepcion1.Existe_Pallet(pallet);
            
        }

        public int Posicion_Pallet(string ID_recepcion)
        {
            D_Recepcion recepcion1 = new D_Recepcion();
            return recepcion1.Posicion_Pallet(ID_recepcion);
        }
        #endregion
        

    }



}
