using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Entity;

namespace Datos
{
    public class D_Recepcion: D_MySQL 
    {

        public string Mensaje { get; set; }
        public string posicion { set; get; }

        #region Metodos Destino
        public List<E_Destino> Lista_Destino()
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

        public bool Agregar_Destino(E_Destino destino1)
        {
            string query;
            MySqlCommand cmd;

            query = "insert into tbl_destinorecepcion(descripcion) values " +
                    "(@descripcion)";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@descripcion", destino1.Descripcion);

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

        public bool Modificar_Destino(E_Destino destino1)
        {
            string query;
            MySqlCommand cmd;

            query = "update tbl_destinorecepcion set descripcion = @descripcion WHERE id=@id";

            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@id", destino1.Codigo);
                    cmd.Parameters.AddWithValue("@descripcion", destino1.Descripcion);

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

        public bool Borrar_Destino(string descarga1)
        {
            string query;
            MySqlCommand cmd;

            query = "delete from tbl_destinorecepcion WHERE id=@id";

            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@id", descarga1);

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

        #region Metodos Descarga

        public List<E_Descarga> Lista_Descarga()
        {
            string query;
            MySqlCommand cmd;
            List<E_Descarga> lista1 = new List<E_Descarga>();

            query = "select * from tbl_tipodescarga";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    E_Descarga objeto1;

                    while (reader.Read())
                    {
                        objeto1 = new E_Descarga
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
        }        //Fin funcion   

        public bool Agregar_Descarga(E_Descarga descarga1)
        {
            string query;
            MySqlCommand cmd;

            query = "insert into tbl_tipodescarga(descripcion) values " +
                    "(@descripcion)";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@descripcion", descarga1.Descripcion);

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

        public bool Modificar_Descarga(E_Descarga descarga1)
        {
            string query;
            MySqlCommand cmd;

            query = "update tbl_tipodescarga set descripcion = @descripcion WHERE id=@id";

            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@id", descarga1.Codigo);
                    cmd.Parameters.AddWithValue("@descripcion", descarga1.Descripcion);

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

        public bool Borrar_Descarga(string descarga1)
        {
            string query;
            MySqlCommand cmd;

            query = "delete from tbl_tipodescarga WHERE id=@id";

            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@id", descarga1);

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
        public bool Agregar_Encabezado(E_Recepcion_Encabezado encabezado1)
        {
            string query;
            MySqlCommand cmd;
            List<E_Descarga> lista1 = new List<E_Descarga>();

            query = "insert into tbl_recepcion(ID_Cliente,ID_Productor,chofer,guia,ID_Especie,ID_Descarga,temperatura,ID_Destino,fecha,lote,cantidad_pallets,id_tipo) values " +
                    "(@ID_Cliente,@ID_Productor,@chofer,@guia,@ID_Especie,@ID_Descarga,@temperatura,@ID_Destino,@fecha,@lote,@cantidad_pallets,@id_tipo)";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@ID_Cliente", encabezado1.ID_Cliente);
                    cmd.Parameters.AddWithValue("@ID_Productor", encabezado1.Codigo_Productor);
                    cmd.Parameters.AddWithValue("@chofer", encabezado1.Chofer);
                    cmd.Parameters.AddWithValue("@guia", encabezado1.Guia);
                    cmd.Parameters.AddWithValue("@ID_Especie", encabezado1.ID_Especie);
                    cmd.Parameters.AddWithValue("@ID_Descarga", encabezado1.ID_Descarga);
                    cmd.Parameters.AddWithValue("@temperatura", encabezado1.Temperatura.Replace(",","."));
                    cmd.Parameters.AddWithValue("@ID_Destino", encabezado1.ID_Destino);
                    cmd.Parameters.AddWithValue("@fecha", encabezado1.Fecha);
                    cmd.Parameters.AddWithValue("@lote", encabezado1.Lote);
                    cmd.Parameters.AddWithValue("@cantidad_pallets", encabezado1.Cantidad_Pallets);
                    cmd.Parameters.AddWithValue("@id_tipo", encabezado1.ID_Tipo);

                    cmd.ExecuteNonQuery();
                    
                }
            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
                return false;
            }

            return true;
        }

        public bool ModificarCantidadPallets_Encabezado(E_Recepcion_Encabezado encabezado1)
        {
            string query;
            MySqlCommand cmd;
            List<E_Descarga> lista1 = new List<E_Descarga>();

            query = "update tbl_recepcion set cantidad_pallets = " + "@cantidad_pallets" + " where id = @id";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@id", encabezado1.ID_Registro);
                    cmd.Parameters.AddWithValue("@cantidad_pallets", encabezado1.Cantidad_Pallets);

                    cmd.ExecuteNonQuery();
                    Desconectar();
                    Mensaje = "";
                    return true;

                }
                else
                {

                    Mensaje = "Error de conexion";
                    Desconectar();
                    return false;
                }
            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
                Desconectar();
                return false;
            }
        }

        public bool Existe_ID_recepcion(E_Recepcion_Encabezado encabezado1)
        {
            bool existe = false;
            string query;
            MySqlDataReader rst;


            query = "select * from  tbl_recepcion Where ID_Cliente=@ID_Cliente and ID_Productor=@ID_Productor and chofer=@chofer and guia=@guia and ID_Especie=@ID_Especie and " +
                "ID_Descarga=@ID_Descarga and temperatura=@temperatura and ID_Destino=@ID_Destino and ID_Tipo = @ID_tipo";
            try
            {

                MySqlCommand cmd = new MySqlCommand(query, MySQLConexion);
                cmd.Parameters.AddWithValue("@ID_Cliente", encabezado1.ID_Cliente);
                cmd.Parameters.AddWithValue("@ID_Productor", encabezado1.Codigo_Productor);
                cmd.Parameters.AddWithValue("@chofer", encabezado1.Chofer);
                cmd.Parameters.AddWithValue("@guia", encabezado1.Guia);
                cmd.Parameters.AddWithValue("@ID_Especie", encabezado1.ID_Especie);
                cmd.Parameters.AddWithValue("@ID_Descarga", encabezado1.ID_Descarga);
                cmd.Parameters.AddWithValue("@temperatura", encabezado1.Temperatura.Replace(",", "."));
                cmd.Parameters.AddWithValue("@ID_Destino", encabezado1.ID_Destino);
                cmd.Parameters.AddWithValue("@ID_tipo", encabezado1.ID_Tipo);
                //cmd.Parameters.AddWithValue("@fecha", encabezado1.Fecha);
                //cmd.Parameters.AddWithValue("@lote", encabezado1.Lote);
                rst = cmd.ExecuteReader();
                if (rst.Read())
                {

                    existe = true;
                    encabezado1.ID_Registro = rst["ID"].ToString();
                    encabezado1.Lote = rst["Lote"].ToString();
                    encabezado1.Cantidad_Pallets = rst["cantidad_pallets"].ToString();          
                }
                else
                {
                    existe = false;
                    encabezado1.ID_Registro = "0";
                    encabezado1.Lote = "0";
                }
                rst.Close();
                cmd.Dispose();
                Posicion_detalle(encabezado1);

            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
                encabezado1.ID_Registro = "0";
                encabezado1.Lote = "0";

            }

            return existe;
        }

        public int Ultimo_ID()
        {
            string aux="0";
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

        public bool Validacion_Folio(E_Recepcion_Detalle recepcion)
        {
            string query;
            bool estado = false;
            MySqlCommand cmd;

            query = "select * from tbl_recepcion_detalle where folio = " +
                    "@folio";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@folio", recepcion.Folio);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Desconectar();
                        Mensaje = "El folio ya fue utilizado en un proceso de Recepcion";
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

        public bool Validacion_Guia(E_Recepcion_Encabezado encabezado)
        {
            string query;
            bool estado = false;
            MySqlCommand cmd;

            query = "select * from tbl_recepcion where guia = " + "@guia "+"and id_productor = "+"@productor";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@guia", encabezado.Guia);
                    cmd.Parameters.AddWithValue("@productor", encabezado.Codigo_Productor);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Desconectar();
                        Mensaje = "La guia ya fue utilizada en un proceso de Recepcion. Intente con otra guia o productor.";
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

        #region Correlativo Lote
        public int Correlativo(string proceso, string subproceso)
        {
            string aux = "0";
            int aux2;
            string query;
            MySqlDataReader rst;

            query = "select correlativo_disponible from tbl_correlativo Where proceso =@proceso and subproceso=@subproceso";
            try
            {
                if (Conectar() == true)
                {

                    MySqlCommand cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@proceso", proceso);
                    cmd.Parameters.AddWithValue("@subproceso", subproceso);
                    rst = cmd.ExecuteReader();
                    if (rst.Read())
                    {
                        aux = rst["correlativo_disponible"].ToString();
                        aux2 = Convert.ToInt32(aux) + 1;
                        Actualizar_Correlativo(proceso, subproceso, aux2);
                    }
                    else
                    {
                        aux = "1";
                        Nuevo_Correlativo(proceso, subproceso, 2);
                    }
                    rst.Close();
                    cmd.Dispose();

                }
            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
                aux = "0";

            }

            return Convert.ToInt32(aux);
        }

        bool Nuevo_Correlativo(string proceso, string subproceso, int correlativo_disponible)
        {
            string query;
            MySqlCommand cmd;
            List<E_Descarga> lista1 = new List<E_Descarga>();

            query = "insert into tbl_correlativo (proceso,subproceso,correlativo_disponible) values (@proceso,@subproceso,@correlativo_disponible)";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@proceso", proceso);
                    cmd.Parameters.AddWithValue("@subproceso", subproceso);
                    cmd.Parameters.AddWithValue("@correlativo_disponible", correlativo_disponible);

                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
                return false;
            }

            return true;
        }

        bool Actualizar_Correlativo(string proceso, string subproceso, int correlativo_disponible)
        {
            string query;
            MySqlCommand cmd;
            List<E_Descarga> lista1 = new List<E_Descarga>();

            query = "update tbl_correlativo set correlativo_disponible=@correlativo_disponible where proceso=@proceso and subproceso=@subproceso";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@proceso", proceso);
                    cmd.Parameters.AddWithValue("@subproceso", subproceso);
                    cmd.Parameters.AddWithValue("@correlativo_disponible", correlativo_disponible);

                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
                return false;
            }

            return true;
        }
        #endregion

        /*   Function Ultimo_ID() As Integer

       sSelect = "select LAST_INSERT_ID() as UltimoID"
       Try
           Dim myCommand As New MySqlCommand(sSelect, SQLConexion)
           rst = myCommand.ExecuteReader()
           If rst.Read Then
               Ultimo_ID = rst("UltimoID")
           Else
               Mensaje = "Registro no encontrado"
           End If
           rst.Close()
           myCommand.Dispose()

       Catch ex As Exception
           Mensaje = ex.Message
       End Try

       Return Ultimo_ID

   End Function*/

        public bool Agregar_Detalle(E_Recepcion_Detalle detalle1)
        {
            string query;
            MySqlCommand cmd;
            List<E_Descarga> lista1 = new List<E_Descarga>();

            query = "insert into tbl_recepcion_detalle(ID_Recepcion,item,ID_Bandeja,bandeja,peso_Bandeja,cantidad_bandejas,folio,kilos_brutos_original,kilos_brutos,tara,kilos_netos,id_pallet,tipo_pallet,peso_pallet,posicion,usuario,sublote) values " +
                    "(@ID_Recepcion,@item,@ID_Bandeja,@bandeja,@peso_Bandeja,@cantidad_bandejas,@folio,@kilos_brutos_original,@kilos_brutos,@tara,@kilos_netos,@id_pallet,@tipo_pallet,@peso_pallet,@posicion,@usuario,@sublote)";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@ID_Recepcion", detalle1.ID_Recepcion);
                    cmd.Parameters.AddWithValue("@Item", detalle1.Item);
                    cmd.Parameters.AddWithValue("@ID_Bandeja", detalle1.ID_bandeja);
                    cmd.Parameters.AddWithValue("@bandeja", detalle1.Bandeja);
                    cmd.Parameters.AddWithValue("@peso_Bandeja", detalle1.Peso_Bandeja.Replace(",", "."));
                    cmd.Parameters.AddWithValue("@cantidad_bandejas", detalle1.Cantidad_Bandejas);
                    cmd.Parameters.AddWithValue("@folio", detalle1.Folio);                    
                    cmd.Parameters.AddWithValue("@kilos_brutos_original", detalle1.Kilos_Brutos.Replace(",", "."));
                    cmd.Parameters.AddWithValue("@kilos_brutos", detalle1.Kilos_Brutos.Replace(",", "."));
                    cmd.Parameters.AddWithValue("@tara", detalle1.Tara.Replace(",", "."));
                    cmd.Parameters.AddWithValue("@kilos_netos", detalle1.Kilos_Netos.Replace(",", "."));
                    cmd.Parameters.AddWithValue("@id_pallet", detalle1.ID_Pallet );
                    cmd.Parameters.AddWithValue("@tipo_pallet", detalle1.Tipo_Pallet);
                    cmd.Parameters.AddWithValue("@peso_pallet", detalle1.Peso_Pallet.Replace(",", "."));
                    cmd.Parameters.AddWithValue("@posicion", detalle1.Posicion);
                    cmd.Parameters.AddWithValue("@usuario", detalle1.Usuario);
                    cmd.Parameters.AddWithValue("@sublote", detalle1.Sublote);
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

        public bool Modificar_Detalle(E_Recepcion_Detalle detalle1)
        {
            string query;
            MySqlCommand cmd;
            List<E_Descarga> lista1 = new List<E_Descarga>();

            query = "update tbl_recepcion_detalle set ID_bandeja = @id_bandeja, bandeja = @bandeja, peso_bandeja = @peso_bandeja, cantidad_bandejas = @cantidad_bandejas, kilos_brutos_original = @kilos_brutos, kilos_brutos = @kilos_brutos, tara = @tara,"+
                    " kilos_netos = @kilos_netos, id_pallet = @id_pallet, tipo_pallet = @tipo_pallet, peso_pallet = @peso_pallet where id = @id";
            try
            {
                if (Conectar() == true)
                {
                    cmd = new MySqlCommand(query, MySQLConexion);
                    cmd.Parameters.AddWithValue("@id_bandeja", detalle1.ID_bandeja);
                    cmd.Parameters.AddWithValue("@bandeja", detalle1.Bandeja);
                    cmd.Parameters.AddWithValue("@peso_bandeja", detalle1.Peso_Bandeja.Replace(",", "."));
                    cmd.Parameters.AddWithValue("@cantidad_bandejas", detalle1.Cantidad_Bandejas);
                    cmd.Parameters.AddWithValue("@kilos_brutos", detalle1.Kilos_Brutos);
                    cmd.Parameters.AddWithValue("@tara", detalle1.Tara.Replace(",", "."));
                    cmd.Parameters.AddWithValue("@kilos_netos", detalle1.Kilos_Netos.Replace(",", "."));
                    cmd.Parameters.AddWithValue("@id_pallet", detalle1.ID_Pallet);
                    cmd.Parameters.AddWithValue("@tipo_pallet", detalle1.Tipo_Pallet);
                    cmd.Parameters.AddWithValue("@peso_pallet", detalle1.Peso_Pallet.Replace(",", "."));
                    cmd.Parameters.AddWithValue("@id", detalle1.ID);

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

        public bool Posicion_detalle(E_Recepcion_Encabezado encabezado1)
        {
            bool existe = false;
            string query;
            MySqlDataReader rst;


            query = "SELECT posicion FROM tbl_recepcion_detalle where id_recepcion = @ID order by posicion desc limit 1;";
            try
            {

                MySqlCommand cmd = new MySqlCommand(query, MySQLConexion);
                cmd.Parameters.AddWithValue("@ID", encabezado1.ID_Registro);

                rst = cmd.ExecuteReader();
                if (rst.Read())
                {

                    existe = true;
                    posicion = rst["posicion"].ToString();

                }
                else
                {
                    posicion = "0";
                }
                rst.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
                encabezado1.ID_Registro = "0";
                encabezado1.Lote = "0";
            }

            return existe;
        }

        public E_Recepcion_Encabezado Obtener_Encabezado(string guia, string productor)
        {
            string query;
            
            MySqlCommand cmd;

            query = "SELECT * FROM tbl_recepcion where guia = @guia and id_productor = @productor;";
            try
            {
                cmd = new MySqlCommand(query, MySQLConexion);
                cmd.Parameters.AddWithValue("@guia", guia);
                cmd.Parameters.AddWithValue("@productor", productor);

                MySqlDataReader rst = cmd.ExecuteReader();
                if (rst.Read())
                {
                    E_Recepcion_Encabezado encabezado1 = new E_Recepcion_Encabezado()
                    {
                        ID_Registro = rst["id"].ToString(),
                        ID_Cliente = rst["id_cliente"].ToString(),
                        Codigo_Productor = rst["id_productor"].ToString(),
                        Chofer = rst["chofer"].ToString(),
                        Guia = rst["guia"].ToString(),
                        ID_Especie = rst["id_especie"].ToString(),
                        ID_Descarga = rst["id_descarga"].ToString(),
                        Temperatura = rst["temperatura"].ToString(),
                        ID_Destino = rst["id_destino"].ToString(),
                        Fecha = rst["fecha"].ToString(),
                        Lote = rst["lote"].ToString(),
                        Cantidad_Pallets = rst["cantidad_pallets"].ToString(),
                        ID_Tipo = rst["id_tipo"].ToString(), 
                      
                        
                    };
                    Desconectar();
                    return encabezado1;
                }
                else
                {
                    Mensaje = "No se encontraron registros";
                    Desconectar();
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

        public List<E_Recepcion_Detalle> Obtener_Detalles_Recepcion(string id)
        {
            string query;

            MySqlCommand cmd;

            List<E_Recepcion_Detalle> listatemp = new List<E_Recepcion_Detalle>();

            query = "SELECT * FROM tbl_recepcion_detalle where id_recepcion = @id;";
            try
            {
                cmd = new MySqlCommand(query, MySQLConexion);
                cmd.Parameters.AddWithValue("@id", id);

                MySqlDataReader rst = cmd.ExecuteReader();
                while(rst.Read())
                {
                    double kilos = Convert.ToDouble(rst["kilos_brutos"].ToString());
                    E_Recepcion_Detalle encabezado1 = new E_Recepcion_Detalle()
                    {
                        ID = rst["ID"].ToString(),
                        ID_Recepcion = rst["id_recepcion"].ToString(),
                        ID_bandeja = rst["id_bandeja"].ToString(),
                        Bandeja = rst["bandeja"].ToString(),
                        Peso_Bandeja = rst["peso_bandeja"].ToString(),
                        Cantidad_Bandejas = rst["cantidad_bandejas"].ToString(),
                        Folio = rst["folio"].ToString(),
                        Kilos_Brutos = kilos.ToString().Replace(",", "."),
                        Tara = rst["tara"].ToString(),
                        Kilos_Netos = rst["kilos_netos"].ToString(),
                        ID_Pallet = rst["id_pallet"].ToString(),
                        Tipo_Pallet = rst["tipo_pallet"].ToString(),
                        Peso_Pallet = rst["peso_pallet"].ToString(),
                        Fecha = rst["fecha"].ToString(),
                        Posicion = rst["posicion"].ToString()
                    };                    
                    listatemp.Add(encabezado1);                   
                }

                if(listatemp.Count==0)
                {
                    Mensaje = "Lista Vacia";
                }
                Desconectar();
                return listatemp;
            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
                Desconectar();
                return null;
            }
        }

        public E_Recepcion_Detalle Obtener_Detalle_Recepcion(string id)
        {
            string query;

            MySqlCommand cmd;

            query = "SELECT * FROM tbl_recepcion_detalle where id = @id;";
            try
            {
                cmd = new MySqlCommand(query, MySQLConexion);
                cmd.Parameters.AddWithValue("@id", id);

                MySqlDataReader rst = cmd.ExecuteReader();
                if(rst.Read())
                {
                    E_Recepcion_Detalle encabezado1 = new E_Recepcion_Detalle()
                    {
                        ID = rst["ID"].ToString(),
                        ID_Recepcion = rst["id_recepcion"].ToString(),
                        ID_bandeja = rst["id_bandeja"].ToString(),
                        Bandeja = rst["bandeja"].ToString(),
                        Peso_Bandeja = rst["peso_bandeja"].ToString(),
                        Cantidad_Bandejas = rst["cantidad_bandejas"].ToString(),
                        Folio = rst["folio"].ToString(),
                        Kilos_Brutos = rst["kilos_brutos"].ToString(),
                        Tara = rst["tara"].ToString(),
                        Kilos_Netos = rst["kilos_netos"].ToString(),
                        ID_Pallet = rst["id_pallet"].ToString(),
                        Tipo_Pallet = rst["tipo_pallet"].ToString(),
                        Peso_Pallet = rst["peso_pallet"].ToString(),
                        Fecha = rst["fecha"].ToString(),
                        Posicion = rst["posicion"].ToString()
                    };
                    return encabezado1;
                }
                else
                {
                    Mensaje = "No se encontro detalle";
                    Desconectar();
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
        //uso sublote validacion solo por folio
        public bool Existe_Pallet(string folio, E_Pallet pallet)
        {
            bool estado = false;
            string query;
            MySqlDataReader rst;


            query = "select * from v_recepcion_maquila where Folio = '" + folio + "'";
            try
            {
                if (Conectar())
                {
                    MySqlCommand cmd = new MySqlCommand(query, MySQLConexion);
                    rst = cmd.ExecuteReader();
                    if (rst.Read())
                    {
                        pallet.Descripcion = rst["bandeja"].ToString();
                        pallet.Peso = Convert.ToDouble(rst["kilos_netos"]);
                        pallet.Cajas = Convert.ToInt32(rst["cantidad_bandejas"]);
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


        public bool Existe_Pallet(E_Pallet pallet)
        {
            bool estado = false;
            string query;
            MySqlDataReader rst;


            query = "select * from v_recepcion_maquila where Folio = '" + pallet.Codigo  + "' and ID_Cliente = " + pallet.ID_Cliente + " and ID_Productor = " + pallet.ID_Productor;
            try
            {
                if (Conectar())
                {
                    MySqlCommand cmd = new MySqlCommand(query, MySQLConexion);
                    rst = cmd.ExecuteReader();
                    if (rst.Read())
                    {
                        pallet.Descripcion = rst["bandeja"].ToString();
                        pallet.Peso = Convert.ToDouble(rst["kilos_netos"]);
                        pallet.Cajas = Convert.ToInt32 (rst["cantidad_bandejas"]);
                        pallet.Estado = rst["estado"].ToString();
                        pallet.Guia = rst["guia"].ToString();
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

                       
        public int Posicion_Pallet(string ID_recepcion)
        {

            string query;
            int aux = 0;
            MySqlCommand cmd;

            query = "select count(item) from tbl_recepcion_detalle Where ID_recepcion = " + ID_recepcion;
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
                            aux = (Convert.ToInt32(reader[0]) + 1);
                        }
                        catch (Exception ex)
                        {
                            Mensaje = ex.Message;
                            aux = 0;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
            }

            return aux;
        }

        #endregion


        #region Lista Pallet Recepcion

        public List<E_pallet_Recepcion> Lista(string ID)
        {
            
            string query;
            MySqlDataReader rst;
            E_pallet_Recepcion pallet1;

            List<E_pallet_Recepcion> recepcion1 = new List<E_pallet_Recepcion>();


           query = "select * from tbl_recepcion_detalle where ID = '" + ID + "'";
            try
            {
                if (Conectar())
                {
                    MySqlCommand cmd = new MySqlCommand(query, MySQLConexion);
                    rst = cmd.ExecuteReader();
                    while (rst.Read())
                    {
                        pallet1 = new E_pallet_Recepcion();
                        pallet1.Codigo  = rst["folio"].ToString();
                        pallet1.ID_Bandeja = rst["ID_Bandeja"].ToString();
                        pallet1.Bandeja = rst["Bandeja"].ToString();
                        pallet1.Kilos_Brutos = Convert.ToDouble(rst["kilos_brutos"]);

                        recepcion1.Add(pallet1);
                    }
                   
                    rst.Close();
                    cmd.Dispose();
                    Desconectar();
                }
            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
               

            }

            return recepcion1;
        }
        #endregion
    }
}
