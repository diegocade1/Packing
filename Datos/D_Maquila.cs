using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using MySql.Data.MySqlClient;


namespace Datos
{
    public class D_Maquila:D_MySQL
    {
        string Mensaje { get; set; }

        public bool Agregar(E_Maquila maquila1)
        {
            string query;
            MySqlCommand cmd;            


            query = "insert into tbl_maquila(ID_cliente,ID_productor,lote,documento,fecha_recepcion," +
                    "ordenEmbalaje,Linea,Hora_Inicio,Hora_Termino,rendimiento," +
                    "kilos_exportacion,kilos_comerciales,kilos_merma,kilos_recepcion) values " +
                "(@ID_cliente,@ID_productor,@lote,@documento,@fecha_recepcion," +
                    "@ordenEmbalaje,@Linea,@Hora_Inicio,@Hora_Termino,@rendimiento," +
                    "@kilos_exportacion,@kilos_comerciales,@kilos_merma,@kilos_recepcion)";

            try
            {
                //if (Conectar() == true)
                //{
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@ID_Cliente", maquila1.ID_Cliente);
                    cmd.Parameters.AddWithValue("@ID_Productor", maquila1.ID_Productor);
                    cmd.Parameters.AddWithValue("@lote", maquila1.Lote);
                    cmd.Parameters.AddWithValue("@documento", maquila1.Documento);
                    cmd.Parameters.AddWithValue("@fecha_recepcion", maquila1.Fecha_Recepcion);
                    cmd.Parameters.AddWithValue("@ordenEmbalaje", maquila1.OrdenEmbalaje);
                    cmd.Parameters.AddWithValue("@Linea", maquila1.Linea);
                    cmd.Parameters.AddWithValue("@Hora_Inicio", maquila1.Hora_Inicio);
                    cmd.Parameters.AddWithValue("@Hora_Termino", maquila1.Hora_Termino);
                    cmd.Parameters.AddWithValue("@rendimiento", maquila1.Rendimiento);
                    cmd.Parameters.AddWithValue("@kilos_exportacion", maquila1.Kilos_PesoTeorico);
                    cmd.Parameters.AddWithValue("@kilos_comerciales", maquila1.Kilos_Comerciales);
                    cmd.Parameters.AddWithValue("@kilos_merma", maquila1.Kilos_Merma);
                    cmd.Parameters.AddWithValue("@kilos_recepcion", maquila1.Kilos_Recepcion);

                cmd.ExecuteNonQuery();

               // }
            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
                Desconectar();
                return false;
            }

           // Desconectar();
            return true;
        }

        public int Ultimo_ID()
        {
            string aux = "0";
            string query;
            MySqlDataReader rst;


            query = "select LAST_INSERT_ID() as UltimoID";
            try
            {

                MySqlCommand cmd = new MySqlCommand(query, MySQLConexion);
                rst = cmd.ExecuteReader();
                if (rst.Read())
                {
                    aux = rst["UltimoID"].ToString();
                }
                else
                {
                    aux = "0";
                }
                rst.Close();
                cmd.Dispose();


            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
                aux = "0";
            }

            return Convert.ToInt32(aux);
        }


        #region Valida/Modifica Recepcion
        public bool Modificar_Estado(string folio,string maquila)
        {
            string query;
            MySqlCommand cmd;

            query = "update tbl_recepcion_detalle set estado=@estado, maquila=@maquila WHERE folio=@folio";

            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@folio", folio);
                    cmd.Parameters.AddWithValue("@estado","1");
                    cmd.Parameters.AddWithValue("@maquila", maquila);
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


        public bool Modificar_Estado_Exportacion(E_Pallet_Exportacion exportacion1, string maquila)
        {
            string query;
            MySqlCommand cmd;

            query = "update tbl_exportacion set estado=@estado, maquila=@maquila WHERE folio=@folio and ID_Cliente=@ID_Cliente and ID_Productor=@ID_Productor";

            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@ID_Cliente", exportacion1.ID_Cliente);
                    cmd.Parameters.AddWithValue("@ID_Productor", exportacion1.ID_Productor);
                    cmd.Parameters.AddWithValue("@folio",exportacion1.Codigo);
                    cmd.Parameters.AddWithValue("@estado", "1");
                    cmd.Parameters.AddWithValue("@maquila", maquila);
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

        public bool Modificar_Estado_Comercial(string folio, string maquila)
        {
            string query;
            MySqlCommand cmd;

            query = "update tbl_comercial set estado=@estado, maquila=@maquila WHERE folio=@folio";

            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@folio", folio);
                    cmd.Parameters.AddWithValue("@estado", "1");
                    cmd.Parameters.AddWithValue("@maquila", maquila);
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



        #endregion
    }
}
