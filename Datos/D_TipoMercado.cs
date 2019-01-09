using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Entity;


namespace Datos
{
    public class D_TipoMercado:D_MySQL
    {
        string Mensaje { get; set; }

        public List<E_TipoMercado> Lista()
        {

            string query;
            MySqlCommand cmd;

            List<E_TipoMercado> lista1 = new List<E_TipoMercado>();

            query = "select * from tbl_tipoMercado";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    E_TipoMercado objeto1;

                    while (reader.Read())
                    {
                        objeto1 = new E_TipoMercado();

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
        }
        public bool Agregar(E_TipoMercado tipo1)
        {
            string query;
            MySqlCommand cmd;

            query = "insert into tbl_tipomercado(descripcion) values " +
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

        public bool Modificar(E_TipoMercado tipo1)
        {
            string query;
            MySqlCommand cmd;

            query = "update tbl_tipomercado set descripcion=@descripcion WHERE ID=@ID";

            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@ID", tipo1.Codigo);
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

            query = "delete from tbl_tipomercado WHERE ID=@ID";

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
