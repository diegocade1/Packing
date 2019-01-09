using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using MySql.Data.MySqlClient;


namespace Datos
{
    class D_SubLote: D_MySQL
    {
        string Mensaje { get; set; }

        public bool Existe_Pallet_recepcion(E_Recepcionado_sublote recepcion)
        {
            bool estado = false;
            string query;
            MySqlDataReader rst;


            query = "select * from tbl_recepcion_detalle where Folio = '" + recepcion.Folio + "'";
            try
            {
                if (Conectar())
                {
                    MySqlCommand cmd = new MySqlCommand(query, MySQLConexion);
                    rst = cmd.ExecuteReader();
                    if (rst.Read())
                    {
                       
                        recepcion.ID_Cliente = rst["cliente"].ToString();
                        recepcion.Productor = rst["productor"].ToString();
                        recepcion.Especie = rst["especie"].ToString();
                        recepcion.Descarga = rst["descarga"].ToString();
                        recepcion.Destino = rst["destino"].ToString();
                        recepcion.Guia = rst["guia"].ToString();
                        recepcion.ID_bandeja = rst["Bandeja"].ToString();
                        recepcion.ID_Pallet = rst["id_pallet"].ToString();
                        estado = true;
                    }
                    else
                    {
                        estado = false;
                    }
                    rst.Close();
                    cmd.Dispose();
                    Desconectar();
                }
            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
                estado = false;

            }

            return estado;
        }

    }
}
