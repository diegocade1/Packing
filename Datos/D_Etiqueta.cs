using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Entity;

namespace Datos
{
    public class D_Etiqueta:D_MySQL
    {
        string Mensaje { get; set; }

        public List<E_Etiqueta> Lista()
        {

            string query;
            MySqlCommand cmd;

            List<E_Etiqueta> lista1 = new List<E_Etiqueta>();

            query = "select * from tbl_etiqueta";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    E_Etiqueta objeto1;

                    while (reader.Read())
                    {
                        objeto1 = new E_Etiqueta();

                        objeto1.Codigo = Convert.ToString(reader["ID"]);
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
        }        //Fin funcion  
        public List<E_Etiqueta> ListaCliente(string cliente)
        {

            string query;
            MySqlCommand cmd;

            List<E_Etiqueta> lista1 = new List<E_Etiqueta>();

            query = "select * from tbl_etiqueta where id_cliente = @cliente;";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@cliente", cliente);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    E_Etiqueta objeto1;

                    while (reader.Read())
                    {
                        objeto1 = new E_Etiqueta();

                        objeto1.Codigo = Convert.ToString(reader["ID"]);
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
        }        //Fin funcion  

        public bool Agregar(E_Etiqueta etiqueta1, string especie, string cliente)
        {
            string query;
            MySqlCommand cmd;

            query = "insert into tbl_etiqueta(descripcion,ID_especie,ID_cliente) values " +
                    "(@descripcion,@especie,@cliente)";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@descripcion", etiqueta1.Descripcion);
                    cmd.Parameters.AddWithValue("@especie", especie);
                    cmd.Parameters.AddWithValue("@cliente", cliente);

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

        public bool Modificar(E_Etiqueta etiqueta1,string especie,string cliente)
        {
            string query;
            MySqlCommand cmd;

            query = "update tbl_etiqueta set descripcion=@descripcion, ID_especie = @especie, ID_cliente = @cliente WHERE ID=@ID";

            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@ID", etiqueta1.Codigo);
                    cmd.Parameters.AddWithValue("@descripcion", etiqueta1.Descripcion);
                    cmd.Parameters.AddWithValue("@especie", especie);
                    cmd.Parameters.AddWithValue("@cliente", cliente);
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

        public bool Borrar(string etiqueta1)
        {
            string query;
            MySqlCommand cmd;

            query = "delete from tbl_etiqueta WHERE ID=@ID";

            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@ID", etiqueta1);

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

        //Obtener Etiqueta con todos los datos
        public E_Etiqueta_EC LeerEtiqueta(string codigo)
        {

            string query;
            MySqlCommand cmd;

            query = "select * from tbl_etiqueta where id = @codigo;";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        E_Etiqueta_EC etiqueta1 = new E_Etiqueta_EC
                        {
                            Codigo = reader.GetString("id"),
                            Descripcion = reader.GetString("descripcion"),
                            Cliente = reader.GetString("id_cliente"),
                            Especie = reader.GetString("id_especie")
                        };
                        Desconectar();
                        return etiqueta1;
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
        // Lista con el Cliente
        public List<E_Etiqueta_EC> Lista_EC()
        {

            string query;
            MySqlCommand cmd;

            List<E_Etiqueta_EC> lista1 = new List<E_Etiqueta_EC>();

            query = "select * from tbl_etiqueta";
            try
            {
                if (Conectar() == true)
                {
                    D_Cliente cliente1;
                    D_Especie especie1;
                    cmd = new MySqlCommand(query, MySQLConexion);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    E_Etiqueta_EC objeto1;

                    while (reader.Read())
                    {
                        objeto1 = new E_Etiqueta_EC();
                        cliente1 = new D_Cliente();
                        especie1 = new D_Especie();
                        string cliente2 = cliente1.Obtener_Cliente(reader.GetString("id_cliente")).Cliente;
                        string especie2 = especie1.Obtener_Especie(reader.GetString("id_especie")).Descripcion;

                        objeto1.Codigo = Convert.ToString(reader["ID"]);
                        objeto1.Descripcion = Convert.ToString(reader["descripcion"]);
                        objeto1.Cliente = cliente2;
                        objeto1.Especie = especie2;
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
        }        //Fin funcion  
    }
}
