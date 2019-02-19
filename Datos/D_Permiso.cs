using Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class D_Permiso : D_MySQL
    {
        public string Mensaje { get; set; }
        public List<E_Permiso> Lista()
        {

            string query;
            MySqlCommand cmd;
            List<E_Permiso> lista_permiso1 = new List<E_Permiso>();

            query = "select * from tbl_permiso order by id asc;";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    E_Permiso permiso1;

                    while (reader.Read())
                    {
                        permiso1 = new E_Permiso
                        {
                            ID = Convert.ToString(reader["id"]),
                            Nombre = Convert.ToString(reader["nombre"]),
                            Llave = Convert.ToString(reader["llave"])
                        };
                        lista_permiso1.Add(permiso1);
                    }

                }

            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
                Desconectar();
            }

            Desconectar();
            return lista_permiso1;
        }        //Fin funcion Lista  

        public bool Agregar(E_Permiso permiso1)
        {
            string query;
            MySqlCommand cmd;

            query = "insert into tbl_permiso(nombre,llave) values " +
                    "(@nombre,@llave)";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@nombre", permiso1.Nombre);
                    cmd.Parameters.AddWithValue("@llave", permiso1.Llave);

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

        public bool Modificar(E_Permiso permiso1)
        {
            string query;
            MySqlCommand cmd;

            query = "update tbl_permiso set nombre = @nombre, llave = @llave WHERE id=@id";

            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@id", permiso1.ID);
                    cmd.Parameters.AddWithValue("@nombre", permiso1.Nombre);
                    cmd.Parameters.AddWithValue("@llave", permiso1.Llave);

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

        public bool Borrar(string permiso1)
        {
            string query;
            MySqlCommand cmd;

            query = "delete from tbl_permiso WHERE codigo=@id";

            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@id", permiso1);

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
