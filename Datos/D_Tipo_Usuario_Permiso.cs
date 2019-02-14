using Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class D_Tipo_Usuario_Permiso : D_MySQL
    {
        public string Mensaje { get; set; }
        public List<E_Tipo_Usuario_Permiso> Lista()
        {

            string query;
            MySqlCommand cmd;
            List<E_Tipo_Usuario_Permiso> lista_tipo_usuario_permiso1 = new List<E_Tipo_Usuario_Permiso>();

            query = "select * from tbl_tipo_usuario_permisos;";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    E_Tipo_Usuario_Permiso usuario1;

                    while (reader.Read())
                    {
                        usuario1 = new E_Tipo_Usuario_Permiso
                        {
                            ID = Convert.ToInt32(reader["id"]),
                            ID_tipo_usuario = Convert.ToInt32(reader["id_tipo_usuario"]),
                            Permisos = Convert.ToString(reader["permisos"])

                        };
                        lista_tipo_usuario_permiso1.Add(usuario1);

                    }

                }

            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
                Desconectar();
            }

            Desconectar();
            return lista_tipo_usuario_permiso1;
        }        //Fin funcion Lista

        public E_Tipo_Usuario_Permiso LeerTipoUsuarioPermisos(string tipo_usuario)
        {

            string query;
            MySqlCommand cmd;

            query = "select * from tbl_tipo_usuario_permisos where id_tipo_usuario=@id;";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@id", tipo_usuario);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        E_Tipo_Usuario_Permiso usuario1 = new E_Tipo_Usuario_Permiso
                        {
                            ID = Convert.ToInt32(reader["id"]),
                            ID_tipo_usuario = Convert.ToInt32(reader["id_tipo_usuario"]),
                            Permisos = Convert.ToString(reader["permisos"])
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

        public bool Agregar(E_Tipo_Usuario_Permiso usuario1)
        {
            string query;
            MySqlCommand cmd;

            query = "insert into tbl_tipo_usuario_permisos(id_tipo_usuario,permisos) values " +
                    "(@id,@permisos)";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@id", usuario1.ID_tipo_usuario);
                    cmd.Parameters.AddWithValue("@permisos", usuario1.Permisos);

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

        public bool Modificar(E_Tipo_Usuario_Permiso usuario1)
        {
            string query;
            MySqlCommand cmd;

            query = "update tbl_tipo_usuario_permisos set id_tipo_usuario = @id_tipo, permisos = @permisos WHERE id=@id";

            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@id", usuario1.ID);
                    cmd.Parameters.AddWithValue("@permisos", usuario1.Permisos);
                    cmd.Parameters.AddWithValue("@id_tipo", usuario1.ID_tipo_usuario);

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

            query = "delete from tbl_tipo_usuario_permisos WHERE id=@id";

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
