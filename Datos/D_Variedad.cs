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

