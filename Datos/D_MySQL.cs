using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class D_MySQL
    {
        static string _StringConexion="";

        public string StringConexion 
        {
            get => _StringConexion;  //Leee desde Variable sArchivo
            set => _StringConexion = value;  //escribe a variable sArchivo
        }

        protected MySqlConnection MySQLConexion;

        public bool Conectar()
        {          
            string sConexionMysql;
            bool estado = false;
            if (StringConexion.Trim() == "" )
            {
                //sConexionMysql = "server = pcl-pc;user id = atc;password = 123atc;port = 3306;database = packing2";
                sConexionMysql = "server = localhost;user id = admin;password = 57706897;port = 3306;database = packing";
            }
            else
            {
                sConexionMysql = StringConexion;
            }
            try
            {
                MySQLConexion = new MySqlConnection();
                MySQLConexion.ConnectionString = sConexionMysql;
                MySQLConexion.Open();
                estado = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return estado;
        }

        public void Desconectar()
        {
            MySQLConexion.Close();
        }               
    }
}
