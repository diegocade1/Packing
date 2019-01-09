using Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class D_Tipo_Usuario : D_MySQL
    {
        string Mensaje { get; set; }
        public List<E_Tipo_Usuario> Lista()
        {

            string query;
            MySqlCommand cmd;
            List<E_Tipo_Usuario> lista_tipo_usuario1 = new List<E_Tipo_Usuario>();

            query = "select * from tbl_tipo_usuario;";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    E_Tipo_Usuario usuario1;

                    while (reader.Read())
                    {
                        usuario1 = new E_Tipo_Usuario
                        {
                            ID = Convert.ToInt32(reader["id"]),
                            Descripcion = Convert.ToString(reader["descripcion"])

                        };
                        lista_tipo_usuario1.Add(usuario1);

                    }

                }

            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
                Desconectar();
            }
            Desconectar();
            return lista_tipo_usuario1;
        }        //Fin funcion Lista

        public E_Tipo_Usuario LeerTipoUsuario(string tipo_usuario)
        {

            string query;
            MySqlCommand cmd;

            query = "select * from tbl_tipo_usuario where id=@id;";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@id", tipo_usuario);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        E_Tipo_Usuario usuario1 = new E_Tipo_Usuario
                        {
                            ID = Convert.ToInt32(reader["usuario"]),
                            Descripcion = Convert.ToString(reader["descripcion"])
                        };
                        Desconectar();
                        return usuario1;
                    }
                    else
                    {
                        Desconectar();
                        return null;
                    }
                }
                else
                {
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

        public bool Agregar(E_Tipo_Usuario usuario1)
        {
            string query;
            MySqlCommand cmd;

            query = "insert into tbl_tipo_usuario(descripcion) values " +
                    "(@descripcion)";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@descripcion", usuario1.Descripcion);

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

        public bool Modificar(E_Tipo_Usuario usuario1)
        {
            string query;
            MySqlCommand cmd;

            query = "update tbl_tipo_usuario set descripcion = @descripcion WHERE id=@id";

            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@id", usuario1.ID);
                    cmd.Parameters.AddWithValue("@descripcion", usuario1.Descripcion);

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

        public bool Borrar(string usuario1)
        {
            string query;
            MySqlCommand cmd;

            query = "delete from tbl_tipo_usuario WHERE id=@id";

            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@id", usuario1);

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