using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Entity;

namespace Datos
{
    public class D_Destino: D_MySQL
    {
        string Mensaje { get; set; }


        public List<E_Destino> Lista()
        {

            string query;
            MySqlCommand cmd;
            List<E_Destino> lista1 = new List<E_Destino>();

            query = "select * from tbl_destinorecepcion";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    E_Destino objeto1;

                    while (reader.Read())
                    {
                        objeto1 = new E_Destino
                        {
                            Codigo = Convert.ToString(reader["ID"]),
                            Descripcion = Convert.ToString(reader["descripcion"])
                        };
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
        }        //Fin funcion Lista   
    }
}
