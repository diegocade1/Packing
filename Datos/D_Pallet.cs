using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Entity;

namespace Datos
{
    public class D_Pallet: D_MySQL 
    {
        string Mensaje { get; set; }

        public List<E_Pallet> Lista()
        {
            string query;
            MySqlCommand cmd;
            List<E_Pallet> lista1 = new List<E_Pallet>();

            query = "select * from tbl_pallet";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    E_Pallet objeto1;

                    while (reader.Read())
                    {
                        objeto1 = new E_Pallet();

                        objeto1.Codigo = Convert.ToString(reader["ID"]);
                        objeto1.Descripcion = Convert.ToString(reader["descripcion"]);
                        try
                        {
                            objeto1.Peso =  Convert.ToDouble(reader["peso"]);
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

        public E_Pallet ObtenerPallet(string id)
        {
            string query;
            MySqlCommand cmd;

            query = "select * from tbl_pallet where id = @id";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@id", id);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    E_Pallet objeto1;

                    if(reader.Read())
                    {
                        objeto1 = new E_Pallet();

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

                        Desconectar();
                        return objeto1;
                    }
                    else
                    {
                        Desconectar();
                        Mensaje = "No se encontraron registros";
                        return null;
                    }
                }
                else
                {
                    Desconectar();
                    Mensaje = "Error en la conexion";
                    return null;
                }
            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
                Desconectar();
                return null;
            }
        }        //Fin funcion 

        public double Peso(string ID)
        {

            string query;
            double peso_Aux = 0;
            MySqlCommand cmd;

            query = "select * from tbl_Pallet Where ID = " + ID;
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

        public bool Agregar(E_Pallet pallet1)
        {
            string query;
            MySqlCommand cmd;

            query = "insert into tbl_pallet(descripcion, peso) values " +
                    "(@descripcion,@peso)";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@descripcion", pallet1.Descripcion);
                    cmd.Parameters.AddWithValue("@peso", pallet1.Peso);

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

        public bool Modificar(E_Pallet pallet1)
        {
            string query;
            MySqlCommand cmd;

            query = "update tbl_pallet set descripcion=@descripcion, peso = @peso WHERE ID=@ID";

            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@ID", pallet1.Codigo);
                    cmd.Parameters.AddWithValue("@descripcion", pallet1.Descripcion);
                    cmd.Parameters.AddWithValue("@peso", pallet1.Peso);

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

        public bool Borrar(string pallet1)
        {
            string query;
            MySqlCommand cmd;

            query = "delete from tbl_pallet WHERE ID=@ID";

            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@ID", pallet1);

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

        public string GetPrefijoActivo()
        {

            string query;
            string prefijo="";
            MySqlCommand cmd;

            query = "select * from tbl_Prefijo Where estado = true";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        try
                        {
                            prefijo = reader["prefijo"].ToString();
                        }
                        catch
                        {
                            prefijo  = "";
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
            return prefijo;
        }
    }
}
