using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Entity;


namespace Datos
{
    public class D_Variedad:D_MySQL
    {
        string Mensaje { get; set; }

        public List<E_Variedad> Lista()
        {

            string query;
            MySqlCommand cmd;

            List<E_Variedad> lista1 = new List<E_Variedad>();

            query = "select * from tbl_variedad";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    E_Variedad objeto1;

                    while (reader.Read())
                    {
                        objeto1 = new E_Variedad();

                        objeto1.Codigo = Convert.ToString(reader["ID"]);
                        objeto1.Descripcion = Convert.ToString(reader["descripcion"]);
                        objeto1.ID_Especie = Convert.ToString(reader["id_especie"]);
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

        public bool Agregar(E_Variedad variedad1)
        {
            string query;
            MySqlCommand cmd;

            query = "insert into tbl_variedad(descripcion,id_especie) values " +
                    "(@descripcion,@especie)";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@descripcion", variedad1.Descripcion);
                    cmd.Parameters.AddWithValue("@especie", variedad1.ID_Especie);

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

        public bool Modificar(E_Variedad variedad1)
        {
            string query;
            MySqlCommand cmd;

            query = "update tbl_variedad set descripcion=@descripcion, id_especie = @especie WHERE ID_variedad=@ID";

            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@ID", variedad1.Codigo);
                    cmd.Parameters.AddWithValue("@descripcion", variedad1.Descripcion);
                    cmd.Parameters.AddWithValue("@especie", variedad1.ID_Especie);

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

        public bool Borrar(string variedad1)
        {
            string query;
            MySqlCommand cmd;

            query = "delete from tbl_variedad WHERE ID=@ID";

            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@ID", variedad1);

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

