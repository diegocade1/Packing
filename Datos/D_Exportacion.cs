using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Entity;

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
                    "cantidad_cajas,documento) values " +
                    "(@ID_Cliente, @ID_Especie, @ID_Embalaje, @ID_Etiqueta, @ID_TipoArmado, " + 
                    "@ID_TipoMercado,@Folio,@ID_Productor,@ID_Variedad,@fecha," +
                    "@cantidad_cajas,@documento)";

            query = "insert into tbl_exportacion(ID_Cliente,ID_Especie,ID_Embalaje,ID_Etiqueta,ID_TipoArmado," +
                  "ID_TipoMercado,Folio,ID_Productor,ID_Variedad,fecha," +
                  "cantidad_cajas,documento) values " +
                  "(" + exportacion1.ID_Cliente + "," + exportacion1.ID_Especie + "," + exportacion1.ID_Embalaje + "," + exportacion1.ID_Etiqueta + "," + exportacion1.ID_TipoArmado + "," +
                  exportacion1.ID_TipoMercado + ",'" + exportacion1.Folio + "'," + exportacion1.ID_Productor + "," + exportacion1.ID_Variedad + "," + exportacion1.Fecha + "," +
                  exportacion1.Cantidad_Cajas + "," + exportacion1.Documento  + ")";

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
                        Mensaje = "El folio ya fue utilizado en un proceso de exportacion";
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

            query = "select * from tbl_exportacion where folio = @folio and ID_productor = @productor and ID_variedad = @variedad";
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
                        Mensaje = "El folio ya fue utilizado en un proceso de exportacion con el mismo productor y variedad";
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
