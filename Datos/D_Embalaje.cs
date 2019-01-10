using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Entity;

namespace Datos
{
    public class D_Embalaje: D_MySQL
    {

        string Mensaje { get; set; }

        public List<E_Embalaje> Lista()
        {

            string query;
            MySqlCommand cmd;
            List<E_Embalaje> lista1 = new List<E_Embalaje>();

            query = "select * from tbl_embalaje";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    E_Embalaje objeto1;

                    while (reader.Read())
                    {
                        objeto1 = new E_Embalaje();

                        objeto1.ID = Convert.ToString(reader["ID"]);
                        objeto1.Descripcion = Convert.ToString(reader["descripcion"]);
                        objeto1.Potes = Convert.ToInt32(reader["potes"]);
                        objeto1.ID_Cliente = Convert.ToInt32(reader["id_cliente"]);
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

        public List<E_Embalaje> ListaCliente(string cliente)
        {

            string query;
            MySqlCommand cmd;
            List<E_Embalaje> lista1 = new List<E_Embalaje>();

            query = "select * from tbl_embalaje where id_cliente = @cliente";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@cliente",cliente);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    E_Embalaje objeto1;

                    while (reader.Read())
                    {
                        objeto1 = new E_Embalaje();

                        objeto1.ID = Convert.ToString(reader["ID"]);
                        objeto1.Descripcion = Convert.ToString(reader["descripcion"]);
                        objeto1.Potes = Convert.ToInt32(reader["potes"]);
                        objeto1.ID_Cliente = Convert.ToInt32(reader["id_cliente"]);
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

        public double Peso(string codigo)
        {

            string query;
            double peso_Aux = 0;
            MySqlCommand cmd;

            query = "select * from tbl_embalaje Where ID = " + codigo;
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

        public bool Agregar(E_Embalaje caja1)
        {
            string query;
            MySqlCommand cmd;

            query = "insert into tbl_embalaje(descripcion, peso,potes,id_cliente) values " +
                    "(@descripcion,@peso,@potes,@cliente)";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@descripcion", caja1.Descripcion);
                    cmd.Parameters.AddWithValue("@peso", caja1.Peso);
                    cmd.Parameters.AddWithValue("@potes", caja1.Potes);
                    cmd.Parameters.AddWithValue("@cliente", caja1.ID_Cliente);

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

        public bool Modificar(E_Embalaje caja1)
        {
            string query;
            MySqlCommand cmd;

            query = "update tbl_embalaje set descripcion=@descripcion, peso = @peso, potes = @potes, id_cliente = @cliente WHERE ID = @ID";

            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@ID", caja1.ID);
                    cmd.Parameters.AddWithValue("@descripcion", caja1.Descripcion);
                    cmd.Parameters.AddWithValue("@peso", caja1.Peso);
                    cmd.Parameters.AddWithValue("@potes", caja1.Potes);
                    cmd.Parameters.AddWithValue("@cliente", caja1.ID_Cliente);

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

        public bool Borrar(string caja1)
        {
            string query;
            MySqlCommand cmd;

            query = "delete from tbl_embalaje WHERE ID = @ID";

            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@ID", caja1);

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




        //    string Mensaje { get; set; }

        //    public List<E_Embalaje> Lista()
        //    {

        //        string query;
        //        MySqlCommand cmd;
        //        List<E_Embalaje> lista1 = new List<E_Embalaje>();

        //        query = "select * from tbl_embalaje";
        //        try
        //        {
        //            if (Conectar() == true)
        //            {
        //                cmd = new MySqlCommand(query, MySQLConexion);
        //                MySqlDataReader reader = cmd.ExecuteReader();
        //                E_Embalaje objeto1;

        //                while (reader.Read())
        //                {
        //                    objeto1 = new E_Embalaje();

        //                    objeto1.ID = Convert.ToString(reader["ID"]);
        //                    objeto1.Descripcion = Convert.ToString(reader["descripcion"]);
        //                    //try
        //                    //{
        //                    //    objeto1.Peso = Convert.ToInt32(reader["peso"]);
        //                    //}
        //                    //catch
        //                    //{
        //                    //    objeto1.Peso = 0;
        //                    //}


        //                    lista1.Add(objeto1);
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Mensaje = ex.Message;
        //            Desconectar();
        //        }

        //        Desconectar();
        //        return lista1;
        //    }        //Fin funcion  
    }
}
