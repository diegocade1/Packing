﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using MySql.Data.MySqlClient;


namespace Datos
{
    public class D_SubLote : D_MySQL
    {
        string Mensaje { get; set; }

        public bool Existe_Pallet_recepcion(E_Recepcionado_sublote recepcion)
        {
            bool estado = false;
            string query;
            MySqlDataReader rst;


            query = "select * from v_recepcion_lista where Folio = '" + recepcion.Folio + "'";
            try
            {
                if (Conectar())
                {
                    MySqlCommand cmd = new MySqlCommand(query, MySQLConexion);
                    rst = cmd.ExecuteReader();
                    if (rst.Read())
                    {
                        recepcion.ID_Registro = rst["ID_recepcion"].ToString();
                        recepcion.ID_Cliente = rst["ID_Cliente"].ToString();
                        recepcion.Cliente = rst["cliente"].ToString();
                        recepcion.Codigo_Productor = rst["ID_productor"].ToString();
                        recepcion.Productor = rst["productor"].ToString();
                        recepcion.Chofer = rst["chofer"].ToString();
                        recepcion.Guia = rst["guia"].ToString();
                        recepcion.ID_Especie = rst["ID_Especie"].ToString();
                        recepcion.Especie = rst["especie"].ToString();
                        recepcion.ID_Descarga = rst["ID_Descarga"].ToString();
                        recepcion.Descarga = rst["Descarga"].ToString();
                        recepcion.Temperatura = rst["temperatura"].ToString();
                        recepcion.ID_Destino = rst["productor"].ToString();
                        recepcion.Destino = rst["destino"].ToString();
                        recepcion.Fecha = rst["fecha"].ToString();
                        //recepcion.Hora = rst["hora"].ToString();
                        recepcion.Lote = rst["lote"].ToString();
                        recepcion.Usuario = rst["usuario"].ToString();
                        recepcion.Total_Pallet = rst["total_pallet"].ToString();
                        recepcion.Item = rst["item"].ToString();
                        recepcion.ID_bandeja = rst["id_bandeja"].ToString();
                        recepcion.Bandeja = rst["Bandeja"].ToString();
                        recepcion.Peso_Bandeja = rst["Peso_bandeja"].ToString();
                        //recepcion.Cantidad_Bandejas = rst["cantidad_bandejas"].ToString();
                        recepcion.Folio = rst["folio"].ToString();
                        recepcion.Kilos_Brutos = rst["kilos_brutos"].ToString();
                        recepcion.Tara = rst["tara"].ToString();
                        recepcion.Kilos_Netos = rst["kilos_netos"].ToString();
                        recepcion.ID_Pallet = rst["id_pallet"].ToString();
                        recepcion.Tipo_Pallet = rst["tipo_pallet"].ToString();
                        //recepcion.Peso_Pallet = rst["peso_pallet"].ToString();
                        //recepcion.Peso_Promedio = rst["peso_promedio"].ToString();
                        //recepcion.Comentario = rst["comentario"].ToString();
                        //recepcion.Estado = rst["estado"].ToString();

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

        public bool Existe_Guia_recepcion(E_Recepcionado_sublote recepcion)
        {
            bool estado = false;
            string query;
            MySqlDataReader rst;


            query = "select * from v_sublote_lista where Guia = '" + recepcion.Guia + "'";
            try
            {
                if (Conectar())
                {
                    MySqlCommand cmd = new MySqlCommand(query, MySQLConexion);
                    rst = cmd.ExecuteReader();

                    if (rst.Read())
                    {
                        recepcion.ID_Registro = rst["ID_recepcion"].ToString();
                        recepcion.ID_Cliente = rst["ID_Cliente"].ToString();
                        recepcion.Cliente = rst["cliente"].ToString();
                        recepcion.Codigo_Productor = rst["ID_productor"].ToString();
                        recepcion.Productor = rst["productor"].ToString();
                        recepcion.Chofer = rst["chofer"].ToString();
                        recepcion.Guia = rst["guia"].ToString();
                        recepcion.ID_Especie = rst["ID_Especie"].ToString();
                        recepcion.Especie = rst["especie"].ToString();
                        recepcion.ID_Descarga = rst["ID_Descarga"].ToString();
                        recepcion.Descarga = rst["Descarga"].ToString();
                        recepcion.Temperatura = rst["temperatura"].ToString();
                        recepcion.ID_Destino = rst["ID_destino"].ToString();
                        recepcion.Destino = rst["destino"].ToString();
                        recepcion.Fecha = rst["fecha"].ToString();                        
                        recepcion.Lote = rst["lote"].ToString();
                        recepcion.ID_Tipo = rst["ID_Tipo"].ToString();
                        recepcion.Tipo = rst["tipo"].ToString();

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

        public decimal Descuento_por_Guia(string ID_Productor,string guia)
        {
            decimal valor;
            string query;
            MySqlDataReader rst;

            query = "select coalesce(sum(kilos_netos),0) from v_recepcion_lista where Guia = '" + guia + "' and ID_Productor = " + ID_Productor + " and sublote <> 0 and uso_descuento = 0";
            try
            {
                if (Conectar())
                {
                    MySqlCommand cmd = new MySqlCommand(query, MySQLConexion);
                    rst = cmd.ExecuteReader();
                    if (rst.Read())
                    {
                        valor = Convert.ToDecimal(rst[0]);
                    }
                    else
                    {
                        valor = 0;
                    }

                    rst.Close();
                    cmd.Dispose();
                    Desconectar();
                }
                else
                {
                    valor = 0;
                }
            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
                valor = 0;

            }
            return valor;
        }

        public bool ModificarSublotePorGuia(string ID_Productor, string guia)
        { 
            string query;
            MySqlCommand cmd;

            query = "update tbl_recepcion_detalle T1 left join tbl_recepcion T2 on T1.ID_Recepcion = T2.ID set T1.uso_descuento = true WHERE T2.guia = @guia and T2.ID_productor = @ID_productor and sublote <> 0";


            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@ID_productor", ID_Productor);
                    cmd.Parameters.AddWithValue("@guia", guia);
                  

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
