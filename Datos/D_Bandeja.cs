using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Entity;

namespace Datos
{
    public class D_Bandeja: D_MySQL 
    {
        string Mensaje { get; set; }

        public List<E_Bandeja> Lista()
        {

            string query;
            MySqlCommand cmd;
            List<E_Bandeja> lista1 = new List<E_Bandeja>();

            query = "select * from tbl_bandeja";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    E_Bandeja objeto1;

                    while (reader.Read())
                    {
                        objeto1 = new E_Bandeja();

                        objeto1.Codigo = Convert.ToString(reader["ID"]);
                        objeto1.Descripcion = Convert.ToString(reader["descripcion"]);
                        try
                        {
                            objeto1.Peso = Convert.ToDouble(reader["peso"]);                                 
                        }
                        catch
                        {
                            objeto1.Peso = 0;
                        }
                        
                       
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

        public double Peso(string ID )
        {

            string query;
            double peso_Aux=0; 
            MySqlCommand cmd;
           
            query = "select * from tbl_bandeja Where ID = " + ID;
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    
                    while (reader.Read())
                    {                                           
                        try
                        {
                            peso_Aux = Convert.ToDouble(reader["Peso"]);
                        }
                        catch
                        {
                            peso_Aux = 0;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
                Desconectar();
            }

            Desconectar();
            return peso_Aux;
        }

        public bool Agregar(E_Bandeja bandeja1)
        {
            string query;
            MySqlCommand cmd;

            query = "insert into tbl_bandeja(descripcion, peso) values " +
                    "(@descripcion,@peso)";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@descripcion", bandeja1.Descripcion);
                    cmd.Parameters.AddWithValue("@peso", bandeja1.Peso);

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

        public bool Modificar(E_Bandeja bandeja1)
        {
            string query;
            MySqlCommand cmd;

            query = "update tbl_bandeja set descripcion=@descripcion, peso = @peso WHERE ID=@ID";

            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@ID", bandeja1.Codigo);
                    cmd.Parameters.AddWithValue("@descripcion", bandeja1.Descripcion);
                    cmd.Parameters.AddWithValue("@peso", bandeja1.Peso);

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

        public bool Borrar(string bandeja1)
        {
            string query;
            MySqlCommand cmd;

            query = "delete from tbl_bandeja WHERE ID=@ID";

            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@ID", bandeja1);

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
