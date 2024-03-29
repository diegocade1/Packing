﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Entity;
using System.Globalization;

namespace Datos
{
    public class D_Exportacion:D_MySQL
    {
        public string Mensaje { get; set; }

        public bool Agregar(E_Exportacion exportacion1)
        {
            string query;
            MySqlCommand cmd;
           
            query = "insert into tbl_exportacion(ID_Cliente,ID_Especie,ID_Embalaje,ID_Etiqueta,ID_TipoArmado," + 
                    "ID_TipoMercado,Folio,ID_Productor,ID_Variedad,fecha," +
                    "cantidad_cajas,documento,usuario) values " +
                    "(@ID_Cliente, @ID_Especie, @ID_Embalaje, @ID_Etiqueta, @ID_TipoArmado, " + 
                    "@ID_TipoMercado,@Folio,@ID_Productor,@ID_Variedad,@fecha," +
                    "@cantidad_cajas,@documento,@usuario)";

            query = "insert into tbl_exportacion(ID_Cliente,ID_Especie,ID_Embalaje,ID_Etiqueta,ID_TipoArmado," +
                  "ID_TipoMercado,Folio,ID_Productor,ID_Variedad,fecha," +
                  "cantidad_cajas,documento,usuario) values " +
                  "(" + exportacion1.ID_Cliente + "," + exportacion1.ID_Especie + "," + exportacion1.ID_Embalaje + "," + exportacion1.ID_Etiqueta + "," + exportacion1.ID_TipoArmado + "," +
                  exportacion1.ID_TipoMercado + ",'" + exportacion1.Folio + "'," + exportacion1.ID_Productor + "," + exportacion1.ID_Variedad + ",'" + exportacion1.Fecha + "'," +
                  exportacion1.Cantidad_Cajas + ",'" + exportacion1.Documento  + "','"+exportacion1.Usuario+"')";

            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    //cmd.Parameters.AddWithValue("@ID_Cliente", exportacion1.ID_Cliente);
                    //cmd.Parameters.AddWithValue("@ID_Especie", exportacion1.ID_Especie);
                    //cmd.Parameters.AddWithValue("@ID_Embalaje ", exportacion1.ID_Embalaje);
                    //cmd.Parameters.AddWithValue("@ID_Etiqueta ", exportacion1.ID_Etiqueta);
                    //cmd.Parameters.AddWithValue("@ID_TipoArmado", exportacion1.ID_TipoArmado);
                    //cmd.Parameters.AddWithValue("@ID_TipoMercado", exportacion1.ID_TipoMercado);
                    //cmd.Parameters.AddWithValue("@Folio", exportacion1.Folio);
                    //cmd.Parameters.AddWithValue("@ID_Productor", exportacion1.ID_Productor);
                    //cmd.Parameters.AddWithValue("@ID_Variedad", exportacion1.ID_Variedad);
                    //cmd.Parameters.AddWithValue("@fecha", exportacion1.Fecha);
                    //cmd.Parameters.AddWithValue("@cantidad_cajas", exportacion1.Cantidad_Cajas);
                    //cmd.Parameters.AddWithValue("@documento", exportacion1.Documento);

                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
                Desconectar();
                return false;
            }

            Desconectar();
            return true;
        }

        public bool Validacion_Folio(E_Exportacion exportacion)
        {
            string query;
            bool estado = false;
            MySqlCommand cmd;

            query = "select * from tbl_exportacion where folio = " +
                    "@folio";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@folio", exportacion.Folio);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Desconectar();
                        Mensaje = "El folio ya fue utilizado en un proceso de Exportacion anterior. Intente con otro folio.";
                        estado = true;
                    }
                    else
                    {
                        Desconectar();
                        estado = false;
                    }
                }
                else
                {
                    estado = false;
                }
            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
                Desconectar();
                return false;
            }
            return estado;
        }

        public bool Validacion_Exportacion(E_Exportacion exportacion)
        {
            string query;
            bool estado = false;
            MySqlCommand cmd;

            query = "select * from tbl_exportacion where folio = @folio and ID_productor = @productor and ID_variedad = @variedad;";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@folio", exportacion.Folio);
                    cmd.Parameters.AddWithValue("@productor", exportacion.ID_Productor);
                    cmd.Parameters.AddWithValue("@variedad", exportacion.ID_Variedad);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Desconectar();
                        Mensaje = "El folio ya fue utilizado en un proceso de Exportacion con el mismo productor y variedad";
                        estado = true;
                    }
                    else
                    {
                        Desconectar();
                        estado = false;
                    }
                }
                else
                {
                    estado = false;
                }
            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
                Desconectar();
                return false;
            }
            return estado;
        }

        public List<E_Exportacion> Obtener_Exportaciones_Folio(string folio)
        {
            string query;

            MySqlCommand cmd;

            query = "SELECT * FROM tbl_exportacion where folio = @folio;";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@folio", folio);

                    MySqlDataReader rst = cmd.ExecuteReader();
                    E_Exportacion encabezado1 = new E_Exportacion();
                    List<E_Exportacion> lista = new List<E_Exportacion>();
                    while (rst.Read())
                    {
                        D_Cliente cliente1 = new D_Cliente();
                        D_Embalaje embalaje1 = new D_Embalaje();
                        D_Especie especie1 = new D_Especie();
                        D_Etiqueta etiqueta1 = new D_Etiqueta();
                        D_TipoArmado armado1 = new D_TipoArmado();
                        D_TipoMercado mercado1 = new D_TipoMercado();
                        D_Variedad variedad1 = new D_Variedad();
                        D_Usuario usuario1 = new D_Usuario();
                        DateTime date = new DateTime();

                        encabezado1.ID_Cliente = rst["ID_cliente"].ToString();
                        encabezado1.ID_Embalaje = rst["id_embalaje"].ToString();
                        encabezado1.ID_Especie = rst["id_especie"].ToString();
                        encabezado1.ID_Etiqueta = rst["id_etiqueta"].ToString();
                        encabezado1.ID_TipoArmado = rst["id_tipoarmado"].ToString();
                        encabezado1.ID_TipoMercado = rst["id_tipomercado"].ToString();
                        encabezado1.Folio = rst["folio"].ToString();
                        encabezado1.ID_Variedad = rst["id_variedad"].ToString();
                        encabezado1.ID_Productor = rst["id_productor"].ToString();
                        encabezado1.Fecha = rst["fecha"].ToString();
                        encabezado1.Cantidad_Cajas = rst["cantidad_cajas"].ToString();
                        encabezado1.Documento = rst["documento"].ToString();
                        encabezado1.Usuario = rst["usuario"].ToString();
                        
                        date = DateTime.ParseExact(encabezado1.Fecha, "dd-MM-yyyy", CultureInfo.InvariantCulture);

                        encabezado1.Cliente = cliente1.Obtener_Cliente(encabezado1.ID_Cliente.ToString()).Cliente;
                        encabezado1.Embalaje = embalaje1.ObtenerEmbalaje(encabezado1.ID_Embalaje.ToString()).Descripcion;
                        encabezado1.Especie = especie1.Obtener_Especie(encabezado1.ID_Especie.ToString()).Descripcion;
                        encabezado1.Etiqueta = etiqueta1.LeerEtiqueta(encabezado1.ID_Etiqueta).Descripcion;
                        encabezado1.TipoArmado = armado1.ObtenerTipoArmado(encabezado1.ID_TipoArmado).Descripcion;
                        encabezado1.TipoMercado = mercado1.ObtenerTipoMercado(encabezado1.ID_TipoMercado).Descripcion;
                        encabezado1.Variedad = variedad1.ObtenerVariedad(encabezado1.ID_Variedad).Descripcion;
                        encabezado1.Responsable = usuario1.LeerUsuario(encabezado1.Usuario).Nombre + " " + usuario1.LeerUsuario(encabezado1.Usuario).Apellido;
                        encabezado1.Hora = date.ToString("h:mm:ss tt");

                        lista.Add(encabezado1);
                    }
                    Desconectar();
                    return lista;
                }
                else
                {
                    Mensaje = "Error en la conexion";
                    return null;
                }
            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
                Desconectar();
                return null;
            }
        }

        #region Validacion Pallet

        public bool Existe_Pallet(E_Pallet_Exportacion pallet)
        {
            bool estado = false;
            string query;
            MySqlDataReader rst;


            query = "select * from v_exportacion_maquila where Folio = '" + pallet.Codigo + "' and ID_Cliente = " + pallet.ID_Cliente + " and ID_Productor = " + pallet.ID_Productor;
            try
            {
                if (Conectar())
                {
                    MySqlCommand cmd = new MySqlCommand(query, MySQLConexion);
                    rst = cmd.ExecuteReader();
                    if (rst.Read())
                    {
                       // pallet.Descripcion = rst["ID_Variedad"].ToString(); //no se usa en maquila
                        pallet.Peso = Convert.ToDouble(rst["peso_teorico"]);
                        pallet.Cajas = Convert.ToInt32(rst["cantidad_cajas"]);
                        pallet.Total_Peso = Convert.ToDouble(rst["total_peso"]);
                        pallet.Embalaje = rst["embalaje"].ToString();
                        pallet.Estado = rst["estado"].ToString();
                        pallet.Potes = Convert.ToInt32(rst["cantidad_potes"]);
                        estado = true;
                    }
                    else
                    {
                        estado = false;
                    }
                    rst.Close();
                    cmd.Dispose();
                    Desconectar();
                }
            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
                estado = false;

            }

            return estado;
        }

        #endregion

    }
}
