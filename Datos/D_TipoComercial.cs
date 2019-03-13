using Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class D_TipoComercial:D_MySQL
    {
        string Mensaje { set; get; }

        public List<E_TipoComercial> Lista()
        {
            string query;
            MySqlCommand cmd;

            List<E_TipoComercial> lista1 = new List<E_TipoComercial>();

            query = "select * from tbl_tipocomercial";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    E_TipoComercial objeto1;

                    while (reader.Read())
                    {
                        objeto1 = new E_TipoComercial();

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
        public E_TipoComercial ObtenerTipoConmercial(string id)
        {

            string query;
            MySqlCommand cmd;

            query = "select * from tbl_tipocomercial where id = @id";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@id", id);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    E_TipoComercial tipo1;

                    if (reader.Read())
                    {
                        tipo1 = new E_TipoComercial
                        {
                            ID = Convert.ToString(reader["id"]),
                            Descripcion = Convert.ToString(reader["descripcion"]),

                        };
                        Desconectar();
                        return tipo1;
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

        public bool Agregar(E_TipoComercial tipo1)
        {
            string query;
            MySqlCommand cmd;

            query = "insert into tbl_tipocomercial(descripcion) values " +
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

        public bool Modificar(E_TipoComercial tipo1)
        {
            string query;
            MySqlCommand cmd;

            query = "update tbl_tipocomercial set descripcion=@descripcion WHERE ID=@ID";

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

            query = "delete from tbl_tipocomercial WHERE ID=@ID";

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
