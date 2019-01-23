using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using MySql.Data.MySqlClient;



namespace Datos
{
    public class D_Cliente : D_MySQL
    {
        public string Mensaje { get; set; }


        public List<E_Cliente> Lista()
        {

            string query;
            MySqlCommand cmd;
            List<E_Cliente> lista_cliente1 = new List<E_Cliente>();

            query = "select * from tbl_cliente";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    E_Cliente cliente1;

                    while (reader.Read())
                    {
                        cliente1 = new E_Cliente
                        {
                            ID = Convert.ToString(reader["ID"]),
                            Codigo = Convert.ToString(reader["codigo"]),
                            Cliente = Convert.ToString(reader["cliente"])
                        };
                        lista_cliente1.Add(cliente1);

                    }

                }

            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
                Desconectar();
            }

            Desconectar();
            return lista_cliente1;
        }        //Fin funcion Lista      

        //Agrega cliente mantenedor
        public bool Agregar(E_Cliente cliente1)
        {
            string query;
            MySqlCommand cmd;

            query = "insert into tbl_Cliente(codigo,cliente) values " +
                    "(@codigo,@cliente)";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@codigo", cliente1.Codigo);
                    cmd.Parameters.AddWithValue("@cliente", cliente1.Cliente);

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

        public bool AgregarMasivo(E_Cliente cliente1)
        {
            string query;
            MySqlCommand cmd;

            query = "insert into tbl_Cliente(codigo,cliente) values " +
                    "(@codigo,@cliente)";
            try
            {
                cmd = new MySqlCommand(query, MySQLConexion);
                cmd.Parameters.AddWithValue("@codigo", cliente1.Codigo);
                cmd.Parameters.AddWithValue("@cliente", cliente1.Cliente);

                cmd.ExecuteNonQuery();
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

        //Modificar cliente mantenedor
        public bool Modificar(E_Cliente cliente1)
        {
            string query;
            MySqlCommand cmd;

            query = "update tbl_Cliente set codigo=@codigo,cliente=@cliente WHERE ID=@ID";

            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@ID", cliente1.ID);
                    cmd.Parameters.AddWithValue("@codigo", cliente1.Codigo);
                    cmd.Parameters.AddWithValue("@cliente", cliente1.Cliente);

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

        public bool Borrar(string ID)
        {
            string query;
            MySqlCommand cmd;

            query = "delete from tbl_Cliente WHERE ID=@ID";

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

        public E_Cliente Obtener_Cliente(string ID)
        {

            string query;
            MySqlCommand cmd;

            query = "select * from tbl_cliente where id = @ID";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@ID", ID);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    E_Cliente cliente1;

                    if (reader.Read())
                    {
                        cliente1 = new E_Cliente
                        {
                            ID = Convert.ToString(reader["ID"]),
                            Codigo = Convert.ToString(reader["codigo"]),
                            Cliente = Convert.ToString(reader["cliente"])
                        };

                        Desconectar();
                        return cliente1;
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
        }        //Fin funcion Lista  
    }
}
