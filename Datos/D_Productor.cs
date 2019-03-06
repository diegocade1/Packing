using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Entity;


namespace Datos
{
    public class D_Productor : D_MySQL   
    {
        public string Mensaje { get; set; }
        public List<E_Productor> Lista(string cliente)
        {

            string query;
            MySqlCommand cmd;
            List<E_Productor> lista_productor1 = new List<E_Productor>();

            query = "select * from tbl_productor where codigo_cliente = '" + cliente + "'";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    E_Productor productor1;

                    while (reader.Read())
                    {
                        productor1 = new E_Productor
                        {
                            Codigo_Cliente = Convert.ToString(reader["codigo_cliente"]),
                            Codigo = Convert.ToString(reader["codigo"]),
                            Descripcion = Convert.ToString(reader["descripcion"]),
                            Codigo_Productor = Convert.ToString(reader["codigo_productor"])
                        };
                        lista_productor1.Add(productor1);

                    }

                }

            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
                Desconectar();
            }

            Desconectar();
            return lista_productor1;
        }        //Fin funcion Lista  

        public E_Productor ObtenerProductor(string id)
        {

            string query;
            MySqlCommand cmd;

            query = "select * from tbl_productor where codigo = @id";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@id", id);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    E_Productor productor1;

                    if(reader.Read())
                    {
                        productor1 = new E_Productor
                        {
                            Codigo_Cliente = Convert.ToString(reader["codigo_cliente"]),
                            Codigo = Convert.ToString(reader["codigo"]),
                            Descripcion = Convert.ToString(reader["descripcion"]),
                            Codigo_Productor = Convert.ToString(reader["codigo_productor"])
                        };
                        Desconectar();
                        return productor1;
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
        }        //Fin funcion Lista  

        public List<E_Productor> ListaCompleta()
        {

            string query;
            MySqlCommand cmd;
            List<E_Productor> lista_productor1 = new List<E_Productor>();

            query = "select * from tbl_productor";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    E_Productor productor1;

                    while (reader.Read())
                    {
                        productor1 = new E_Productor
                        {
                            Codigo_Cliente = Convert.ToString(reader["codigo_cliente"]),
                            Codigo = Convert.ToString(reader["codigo"]),
                            Descripcion = Convert.ToString(reader["descripcion"]),
                            Codigo_Productor = Convert.ToString(reader["codigo_productor"])
                        };
                        lista_productor1.Add(productor1);

                    }

                }

            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
                Desconectar();
            }

            Desconectar();
            return lista_productor1;
        }

        public bool Agregar(E_Productor productor1)
        {
            string query;
            MySqlCommand cmd;

            query = "insert into tbl_productor(descripcion,codigo_cliente,codigo_productor) values " +
                    "(@descripcion,@codigo,@codigo_productor)";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@descripcion", productor1.Descripcion);
                    cmd.Parameters.AddWithValue("@codigo", productor1.Codigo_Cliente);
                    cmd.Parameters.AddWithValue("@codigo_productor", productor1.Codigo_Productor);

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

        public bool Modificar(E_Productor productor1)
        {
            string query;
            MySqlCommand cmd;

            query = "update tbl_productor set descripcion = @descripcion, codigo_cliente = @codigo, codigo_productor = @codigo_productor WHERE codigo=@id";

            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@id", productor1.Codigo);
                    cmd.Parameters.AddWithValue("@descripcion", productor1.Descripcion);
                    cmd.Parameters.AddWithValue("@codigo", productor1.Codigo_Cliente);
                    cmd.Parameters.AddWithValue("@codigo_productor", productor1.Codigo_Productor);

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

        public bool Borrar(string productor1)
        {
            string query;
            MySqlCommand cmd;

            query = "delete from tbl_productor WHERE codigo=@id";

            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@id", productor1);

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
