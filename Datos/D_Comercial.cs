using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class D_Comercial: D_MySQL
    {

        public string Mensaje { get; set; }

        public bool Agregar(E_Comercial comercial)
        {
            string query;
            MySqlCommand cmd;
            
            query = "insert into tbl_comercial(ID_Cliente,ID_Productor,ID_Especie,ID_Tipo,ID_Bandeja,ID_Pallet,kilos_brutos,cantidad_bandejas,folio,fecha,tara,kilos_netos,usuario) values " +
                    "(@ID_Cliente,@ID_Productor,@ID_Especie,@ID_Tipo,@ID_Bandeja,@ID_Pallet,@kilos_brutos,@cantidad_bandejas,@folio,@fecha,@tara,@kilos_netos,@usuario)";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@ID_Cliente", comercial.ID_Cliente);
                    cmd.Parameters.AddWithValue("@ID_Productor", comercial.ID_Productor);
                    cmd.Parameters.AddWithValue("@ID_Especie", comercial.ID_Especie);
                    cmd.Parameters.AddWithValue("@ID_Tipo", comercial.ID_Tipo);
                    //cmd.Parameters.AddWithValue("@Total_Pallet", comercial.Total_Pallet);
                    cmd.Parameters.AddWithValue("@ID_Bandeja", comercial.ID_Bandeja);
                    cmd.Parameters.AddWithValue("@ID_Pallet", comercial.ID_Pallet);
                    cmd.Parameters.AddWithValue("@kilos_brutos", comercial.Kilos_Brutos);
                    cmd.Parameters.AddWithValue("@cantidad_bandejas", comercial.Cantidad_Bandejas);
                    cmd.Parameters.AddWithValue("@folio", comercial.Folio);
                    cmd.Parameters.AddWithValue("@fecha", comercial.Fecha);
                    cmd.Parameters.AddWithValue("@tara", comercial.Tara);
                    cmd.Parameters.AddWithValue("@kilos_netos", comercial.Kilos_Netos);
                    cmd.Parameters.AddWithValue("@usuario", comercial.Usuario);

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

        public bool Validacion_Folio(E_Comercial comercial)
        {
            string query;
            bool estado = false;
            MySqlCommand cmd;

            query = "select * from tbl_comercial where folio = " +
                    "@folio";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@folio", comercial.Folio);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Desconectar();
                        Mensaje = "El folio ya fue utilizado en un proceso de Comercial";
                        estado = true;
                    }
                    else
                    {
                        Desconectar();
                        estado = false;
                    }
                }
                else
                {
                    estado = false;
                }
            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
                Desconectar();
                return false;
            }
            return estado;
        }

        public E_Comercial Obtener_Comercial_Folio(string folio)
        {
            string query;

            MySqlCommand cmd;

            query = "SELECT * FROM tbl_comercial where folio = @folio;";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@folio", folio);

                    MySqlDataReader rst = cmd.ExecuteReader();
                    E_Comercial encabezado1 = new E_Comercial();

                   if(rst.Read())
                    {
                        encabezado1.ID_Cliente = rst["ID_cliente"].ToString();
                        encabezado1.ID_Productor = rst["id_productor"].ToString();
                        encabezado1.ID_Especie = rst["id_especie"].ToString();
                        encabezado1.ID_Tipo = rst["id_tipo"].ToString();
                        encabezado1.ID_Bandeja = rst["id_bandeja"].ToString();
                        encabezado1.ID_Pallet = rst["id_pallet"].ToString();
                        encabezado1.Folio = rst["folio"].ToString();
                        encabezado1.Kilos_Brutos = Convert.ToDouble(rst["kilos_brutos"]);
                        encabezado1.Tara = Convert.ToDouble(rst["tara"]);
                        encabezado1.Kilos_Netos = Convert.ToDouble(rst["kilos_netos"]);
                        encabezado1.Cantidad_Bandejas = Convert.ToInt32(rst["cantidad_bandejas"]);
                        encabezado1.Fecha = rst["fecha"].ToString();
                        encabezado1.Usuario = rst["usuario"].ToString();

                        Desconectar();
                        return encabezado1;
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
        }

        #region Validacion Pallet

        public bool Existe_Pallet(E_Pallet_Comercial pallet)
        {
            bool estado = false;
            string query;
            MySqlDataReader rst;


            query = "select * from v_comercial_maquila where Folio = '" + pallet.Codigo + "' and ID_Cliente = " + pallet.ID_Cliente + " and ID_Productor = " + pallet.ID_Productor;
            
            try
            {
                if (Conectar())
                {
                    MySqlCommand cmd = new MySqlCommand(query, MySQLConexion);
                    rst = cmd.ExecuteReader();
                    if (rst.Read())
                    {
                        
                        pallet.ID_Cliente = rst["ID_Cliente"].ToString();
                        pallet.ID_Productor = rst["ID_Productor"].ToString();
                        pallet.ID_Tipo = rst["ID_tipo"].ToString();
                        pallet.Tipo = rst["tipo"].ToString();
                        pallet.Kilos_Netos = Convert.ToDouble(rst["kilos_netos"]);                        
                        pallet.Estado = rst["estado"].ToString();

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

        #endregion
    }
}
