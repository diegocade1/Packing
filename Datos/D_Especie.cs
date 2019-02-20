using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Entity;

namespace Datos
{
    public class D_Especie : D_MySQL
    {
        public string Mensaje { get; set; }


        public List<E_Especie> Lista()
        {

            string query;
            MySqlCommand cmd;
            List<E_Especie> lista_especie1 = new List<E_Especie>();

            query = "select * from tbl_especie order by fecha_uso desc";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    E_Especie especie1;

                    while (reader.Read())
                    {
                        especie1 = new E_Especie
                        {
                            Codigo = Convert.ToString(reader["ID_especie"]),
                            Descripcion = Convert.ToString(reader["descripcion"]),
                        };
                        lista_especie1.Add(especie1);
                    }
                }
            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
                Desconectar();
            }

            Desconectar();
            return lista_especie1;
        }        //Fin funcion Lista      

        public bool Agregar(E_Especie especie1)
        {
            string query;
            MySqlCommand cmd;

            query = "insert into tbl_especie(descripcion) values " +
                    "(@descripcion)";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@descripcion", especie1.Descripcion);

                    cmd.ExecuteNonQuery();
                    return true;
                }
                else
                {
                    Desconectar();
                    Mensaje = "Error de conexion";
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

        public bool Modificar(E_Especie especie1)
        {
            string query;
            MySqlCommand cmd;

            query = "update tbl_especie set descripcion=@descripcion WHERE ID_especie=@ID";

            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@ID", especie1.Codigo);
                    cmd.Parameters.AddWithValue("@descripcion", especie1.Descripcion);

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

        public bool Borrar(string especie1)
        {
            string query;
            MySqlCommand cmd;

            query = "delete from tbl_especie WHERE ID_especie=@ID";

            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@ID", especie1);

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

        public bool Actualizar_Fecha_uso(string ID_Especie)
        {
            string query;
            MySqlCommand cmd;
            List<E_Descarga> lista1 = new List<E_Descarga>();

            query = "update tbl_especie set fecha_uso=CURRENT_TIMESTAMP where ID_especie=@ID";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@ID", ID_Especie);

                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
                return false;
            }

            return true;
        }

        //Obtener especie

        public E_Especie Obtener_Especie(string ID)
        {

            string query;
            MySqlCommand cmd;

            query = "select * from tbl_especie where id_especie=@id";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@ID", ID);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    E_Especie especie1;

                    if(reader.Read())
                    {
                        especie1 = new E_Especie
                        {
                            Codigo = Convert.ToString(reader["ID_especie"]),
                            Descripcion = Convert.ToString(reader["descripcion"])
                        };
                        Desconectar();
                        return especie1;
                    }
                    else
                    {
                        Desconectar();
                        Mensaje = "No se encontro ninguna especie con ese ID";
                        return null;
                    }
                }
                else
                {
                    Desconectar();
                    Mensaje = "Error de conexion";
                    return null;
                }
            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
                Desconectar();
                return null;
            }
        }        //Fin funcion Lista     

    }
}
