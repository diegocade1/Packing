using Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class D_Usuario : D_MySQL
    {
        public string Mensaje { get; set; }
        public List<E_Usuario> Lista()
        {

            string query;
            MySqlCommand cmd;
            List<E_Usuario> lista_usuario1 = new List<E_Usuario>();

            query = "select * from tbl_usuario;";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    E_Usuario usuario1;

                    while (reader.Read())
                    {
                        usuario1 = new E_Usuario
                        {
                            Usuario = Convert.ToString(reader["usuario"]),
                            Apellido = Convert.ToString(reader["apellido"]),
                            Contrasenia = Convert.ToString(reader["contrasenia"]),
                            Nombre = Convert.ToString(reader["nombre"]),
                            Tipo_usuario = Convert.ToString(reader["id_tipo_usuario"])
                        };
                        lista_usuario1.Add(usuario1);

                    }

                }

            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
            }

            return lista_usuario1;
        }        //Fin funcion Lista

        public E_Usuario LeerUsuario(string usuario)
        {

            string query;
            MySqlCommand cmd;

            query = "select * from tbl_usuario where usuario = @usuario;";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    MySqlDataReader reader = cmd.ExecuteReader();                  
                    if (reader.Read())
                    {
                        E_Usuario usuario1 = new E_Usuario
                        {
                            Usuario = reader.GetString("usuario"),
                            Apellido = reader.GetString("apellido"),
                            Contrasenia = reader.GetString("contrasenia"),
                            Nombre = reader.GetString("nombre"),
                            Tipo_usuario = reader.GetString("id_tipo_usuario")
                        };
                        Desconectar();
                        Mensaje = "";
                        return usuario1;                        
                    }
                    else
                    {
                        Desconectar();
                        Mensaje = "No se ha encontrado ningun usuario con ese nombre de usuario.";
                        return null;
                    }
                }
                else
                {
                    Desconectar();
                    Mensaje = "No hay conexion con la base de datos";
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

        public bool Agregar(E_Usuario usuario1)
        {
            string query;
            MySqlCommand cmd;

            query = "insert into tbl_usuario(usuario,contrasenia,nombre,apellido,id_tipo_usuario) values " +
                    "(@usuario,@contrasenia,@nombre,@apellido,@tipo_usuario)";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@usuario", usuario1.Usuario);
                    cmd.Parameters.AddWithValue("@contrasenia", usuario1.Contrasenia);
                    cmd.Parameters.AddWithValue("@nombre", usuario1.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", usuario1.Apellido);
                    cmd.Parameters.AddWithValue("@tipo_usuario", usuario1.Tipo_usuario);

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

        public bool Modificar(E_Usuario usuario1)
        {
            string query;
            MySqlCommand cmd;

            query = "update tbl_usuario set contrasenia = @contrasenia, nombre = @nombre, apellido = @apellido, id_tipo_usuario = @tipo_usuario WHERE usuario = @usuario";

            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@usuario", usuario1.Usuario);
                    cmd.Parameters.AddWithValue("@contrasenia", usuario1.Contrasenia);
                    cmd.Parameters.AddWithValue("@nombre", usuario1.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", usuario1.Apellido);
                    cmd.Parameters.AddWithValue("@tipo_usuario", usuario1.Tipo_usuario);

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

            query = "delete from tbl_usuario WHERE usuario=@Usuario";

            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@Usuario", usuario1);

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
