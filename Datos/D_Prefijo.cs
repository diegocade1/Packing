using Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class D_Prefijo : D_MySQL
    {
        string Mensaje { get; set; }

        public List<E_Prefijo> Lista()
        {
            string query;
            MySqlCommand cmd;
            List<E_Prefijo> lista1 = new List<E_Prefijo>();

            query = "select * from tbl_prefijo";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    E_Prefijo objeto1;

                    while (reader.Read())
                    {
                        objeto1 = new E_Prefijo();

                        objeto1.ID = Convert.ToString(reader["ID"]);
                        objeto1.Prefijo = Convert.ToString(reader["prefijo"]);
                        objeto1.Estado = Convert.ToBoolean(reader["estado"]);

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

        public bool AgregarPrefijoActivo(E_Prefijo prefijo1)
        {

            string query;
            MySqlCommand cmd;

            query = "insert into tbl_prefijo(prefijo,estado) values (@prefijo,@estado)";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@prefijo", prefijo1.Prefijo);
                    cmd.Parameters.AddWithValue("@estado", prefijo1.Estado);

                    cmd.ExecuteNonQuery();
                    Desconectar();
                    return true;
                }
                else
                {
                    Mensaje = "Problemas con la conexion";
                    return false;
                }
            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
                Desconectar();
                return false;
            }
        }

        public bool ActualizarPrefijoActivo(E_Prefijo prefijo1)
        {

            string query;
            MySqlCommand cmd;

            query = "update tbl_prefijo set estado=@estado where id = @id";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@id", prefijo1.ID);
                    cmd.Parameters.AddWithValue("@estado", prefijo1.Estado);

                    cmd.ExecuteNonQuery();
                    Desconectar();
                    return true;
                }
                else
                {
                    Mensaje = "Problemas con la conexion";
                    return false;
                }
            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
                Desconectar();
                return false;
            }
        }

        public bool BorrarPrefijoActivo(string ID)
        {
            string query;
            MySqlCommand cmd;

            query = "delete from tbl_prefijo WHERE ID=@ID";

            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@ID", ID);

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

        public E_Prefijo LeerPrefijoActivo(string id)
        {

            string query;
            MySqlCommand cmd;

            query = "select * from tbl_prefijo where id=@id;";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@id", id);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        E_Prefijo usuario1 = new E_Prefijo
                        {
                            ID = Convert.ToString(reader["id"]),
                            Prefijo = Convert.ToString(reader["prefijo"]),
                            Estado = Convert.ToBoolean(reader["estado"])
                        };
                        Desconectar();
                        return usuario1;
                    }
                    else
                    {
                        Desconectar();
                        Mensaje = "No se ha encontrado el prefijo con el id seleccionado";
                        return null;
                    }
                }
                else
                {
                    Desconectar();
                    Mensaje = "Problemas con la conexion";
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
    }
}
