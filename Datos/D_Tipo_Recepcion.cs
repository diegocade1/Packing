using Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class D_Tipo_Recepcion : D_MySQL
    {
        string Mensaje { set; get; }

        public List<E_Tipo_Recepcion> Lista()
        {
            string query;
            MySqlCommand cmd;

            List<E_Tipo_Recepcion> lista1 = new List<E_Tipo_Recepcion>();

            query = "select * from tbl_tiporecepcion";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    E_Tipo_Recepcion objeto1;

                    while (reader.Read())
                    {
                        objeto1 = new E_Tipo_Recepcion();

                        objeto1.ID = Convert.ToString(reader["ID"]);
                        objeto1.Descripcion = Convert.ToString(reader["descripcion"]);
                        //try
                        //{
                        //    objeto1.Peso = Convert.ToInt32(reader["peso"]);
                        //}
                        //catch
                        //{
                        //    objeto1.Peso = 0;
                        //}

                        lista1.Add(objeto1);
                    }
                }
            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
                Desconectar();
            }
            Desconectar();
            return lista1;
        }
        public E_Tipo_Recepcion Obtener_TipoRecepcion(string id)
        {
            string query;

            MySqlCommand cmd;

            query = "SELECT * FROM tbl_tiporecepcion where id = @id;";
            try
            {
                if(Conectar()==true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@id", id);

                    MySqlDataReader rst = cmd.ExecuteReader();
                    if (rst.Read())
                    {
                        E_Tipo_Recepcion encabezado1 = new E_Tipo_Recepcion()
                        {
                            ID = rst["id"].ToString(),
                            Descripcion = rst["descripcion"].ToString()
                        };
                        Desconectar();
                        return encabezado1;
                    }
                    else
                    {
                        Mensaje = "No se encontraron registros";
                        Desconectar();
                        return null;
                    }
                }
                else
                {
                    Mensaje = "Error en la conexion";
                    Desconectar();
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

        public bool Agregar(E_Tipo_Recepcion tipo1)
        {
            string query;
            MySqlCommand cmd;

            query = "insert into tbl_tipo_recepcion(descripcion) values " +
                    "(@descripcion)";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@descripcion", tipo1.Descripcion);

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

        public bool Modificar(E_Tipo_Recepcion tipo1)
        {
            string query;
            MySqlCommand cmd;

            query = "update tbl_tipo_recepcion set descripcion=@descripcion WHERE ID=@ID";

            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@ID", tipo1.ID);
                    cmd.Parameters.AddWithValue("@descripcion", tipo1.Descripcion);

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

        public bool Borrar(string tipo1)
        {
            string query;
            MySqlCommand cmd;

            query = "delete from tbl_tipo_recepcion WHERE ID=@ID";

            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@ID", tipo1);

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
    }
}
