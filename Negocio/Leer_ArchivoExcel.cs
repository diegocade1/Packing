using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.Office.Interop;
using Datos;
using Entity;



namespace Negocio
{
    public class Leer_ArchivoExcel
    {
        // object oExcel;
        public string Mensaje { get; set; }
        public string Detalle { get; set; }
        Microsoft.Office.Interop.Excel.Application oExcel;
        Microsoft.Office.Interop.Excel.Workbook oBook;
        Microsoft.Office.Interop.Excel.Worksheet oSheet;
        // Inicializar
        public void CargaPlanilla(string sFile)
        {

        }
        //Cargar archivo Clientes
        public void CargaPlanillaClientes(string sFile)
        {
            //obtiene el tipo de cultura actual para recuperarlo cuando termine la carga
            System.Globalization.CultureInfo OldCultureInfo =  Thread.CurrentThread.CurrentCulture;
            //Crear una cultura standard (en-US) inglés estados unidos            
            Thread.CurrentThread.CurrentCulture= new System.Globalization.CultureInfo("en-US");

            oExcel = new Microsoft.Office.Interop.Excel.Application();
            oExcel.DisplayAlerts = false; //para no mostrar mensajes de confirmaciòn
            oExcel.Visible = false;
          //  oBook = oExcel.Workbooks.Add();
          //  oSheet = oBook.Sheets.Add();

            try
            {
                LoadCodigosClientes(sFile);               
                oBook.Close();
                oExcel.Visible = true;
                oBook = null; 
               
                if (oExcel != null)
                {
                    oExcel.Quit();
                    oExcel = null;
                }
               
            }
            catch(Exception ex)
            {
                Mensaje = ex.Message;
                throw new Exception("Error Leer Excel " + ex.Message);
            }
            finally
            {
                //Vuelve cultura antigua
                Thread.CurrentThread.CurrentCulture = OldCultureInfo;
            }     

        }

        void LoadCodigosClientes(string sFile)
        {
            int totalHojas, j, i;
            int ingresadas = 0, errores = 0;
            try
            {
                oBook = oExcel.Workbooks.Open(sFile);// .Workbooks.Open(sFile);
                totalHojas = oBook.Sheets.Count;
                D_Cliente cliente1 = new D_Cliente();
                E_Cliente eCliente2;
                string texto;
                cliente1.Conectar(); 
                for(j = 1; j <= totalHojas; j++)
                {
                    oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oBook.Worksheets.get_Item(j);//  .Worksheets(j);// oBook.Sheets();

                    i = 2;
                    while (true)
                    {
                        texto = oSheet.Cells[i, 1].text;
                        if (texto.Trim() == "")
                        {
                            break;
                        }
                        eCliente2 = new E_Cliente();
                        eCliente2.Codigo = oSheet.Cells[i, 1].text;
                        eCliente2.Cliente = oSheet.Cells[i, 2].Text;

                        if(cliente1.Agregar(eCliente2))
                        {
                            i++;
                            ingresadas++;
                        }
                        else
                        {
                            Detalle += "Linea Excel " + i + ": " + cliente1.Mensaje + "\n";
                            i++;
                            errores++;
                        }
                        

                    }
                   // oSheet.Cells[1, 1]
                   // oSheet.Activate()
                }

                if(ingresadas!= 0 && errores!=0)
                {
                    Mensaje = ingresadas + " entradas registradas con exito." + "\n" + errores + " entradas no se pudieron agregar.";
                }
                else
                {
                    if(ingresadas == 0 && errores!=0)
                    {
                        Mensaje = ingresadas + " entradas no se pudieron agregar.";
                    }
                    else
                    {
                        if(ingresadas!=0 && errores==0)
                        {
                            Mensaje = ingresadas + " entradas registradas con exito.";
                        }
                        else
                        {
                            Mensaje = "El archivo no tiene el formato correcto o no se han encontrado datos";
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Mensaje = ex.Message;
                throw new Exception("Error Excel " + ex.Message);
            }
        }

        // Cargar Archivo Especie

        public void CargaPlanillaEspecie(string sFile)
        {
            //obtiene el tipo de cultura actual para recuperarlo cuando termine la carga
            System.Globalization.CultureInfo OldCultureInfo = Thread.CurrentThread.CurrentCulture;
            //Crear una cultura standard (en-US) inglés estados unidos            
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            oExcel = new Microsoft.Office.Interop.Excel.Application();
            oExcel.DisplayAlerts = false; //para no mostrar mensajes de confirmaciòn
            oExcel.Visible = false;
            //  oBook = oExcel.Workbooks.Add();
            //  oSheet = oBook.Sheets.Add();

            try
            {
                LoadCodigosEspecie(sFile);
                oBook.Close();
                oExcel.Visible = true;
                oBook = null;

                if (oExcel != null)
                {
                    oExcel.Quit();
                    oExcel = null;
                }

            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
                throw new Exception("Error Leer Excel " + ex.Message);
            }
            finally
            {
                //Vuelve cultura antigua
                Thread.CurrentThread.CurrentCulture = OldCultureInfo;
            }

        }

        void LoadCodigosEspecie(string sFile)
        {
            int totalHojas, j, i;
            int ingresadas = 0, errores = 0;
            try
            {
                oBook = oExcel.Workbooks.Open(sFile);// .Workbooks.Open(sFile);
                totalHojas = oBook.Sheets.Count;
                D_Especie especie1 = new D_Especie();
                E_Especie especie2;
                string texto;
                especie1.Conectar();
                for (j = 1; j <= totalHojas; j++)
                {
                    oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oBook.Worksheets.get_Item(j);//  .Worksheets(j);// oBook.Sheets();

                    i = 2;
                    while (true)
                    {
                        texto = oSheet.Cells[i, 1].text;
                        if (texto.Trim() == "")
                        {
                            break;
                        }
                        especie2 = new E_Especie();
                        especie2.Descripcion = oSheet.Cells[i, 1].text;

                        if (especie1.Agregar(especie2))
                        {
                            i++;
                            ingresadas++;
                        }
                        else
                        {
                            Detalle += "Linea Excel " + i + ": " + especie1.Mensaje + "\n";
                            i++;
                            errores++;
                        }


                    }
                    // oSheet.Cells[1, 1]
                    // oSheet.Activate()
                }

                if (ingresadas != 0 && errores != 0)
                {
                    Mensaje = ingresadas + " entradas registradas con exito." + "\n" + errores + " entradas no se pudieron agregar.";
                }
                else
                {
                    if (ingresadas == 0 && errores != 0)
                    {
                        Mensaje = ingresadas + " entradas no se pudieron agregar.";
                    }
                    else
                    {
                        if (ingresadas != 0 && errores == 0)
                        {
                            Mensaje = ingresadas + " entradas registradas con exito.";
                        }
                        else
                        {
                            Mensaje = "El archivo no tiene el formato correcto o no se han encontrado datos";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
                throw new Exception("Error Excel " + ex.Message);
            }
        }

        // Cargar Archivo Productor

        public void CargaPlanillaProductor(string sFile)
        {
            //obtiene el tipo de cultura actual para recuperarlo cuando termine la carga
            System.Globalization.CultureInfo OldCultureInfo = Thread.CurrentThread.CurrentCulture;
            //Crear una cultura standard (en-US) inglés estados unidos            
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            oExcel = new Microsoft.Office.Interop.Excel.Application();
            oExcel.DisplayAlerts = false; //para no mostrar mensajes de confirmaciòn
            oExcel.Visible = false;
            //  oBook = oExcel.Workbooks.Add();
            //  oSheet = oBook.Sheets.Add();

            try
            {
                LoadCodigosProductor(sFile);
                oBook.Close();
                oExcel.Visible = true;
                oBook = null;

                if (oExcel != null)
                {
                    oExcel.Quit();
                    oExcel = null;
                }

            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
                throw new Exception("Error Leer Excel " + ex.Message);
            }
            finally
            {
                //Vuelve cultura antigua
                Thread.CurrentThread.CurrentCulture = OldCultureInfo;
            }

        }

        void LoadCodigosProductor(string sFile)
        {
            int totalHojas, j, i;
            int ingresadas = 0, errores = 0;
            try
            {
                oBook = oExcel.Workbooks.Open(sFile);// .Workbooks.Open(sFile);
                totalHojas = oBook.Sheets.Count;
                D_Productor productor1 = new D_Productor();
                E_Productor productor2;
                string texto;
                productor1.Conectar();
                for (j = 1; j <= totalHojas; j++)
                {
                    oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oBook.Worksheets.get_Item(j);//  .Worksheets(j);// oBook.Sheets();

                    i = 2;
                    while (true)
                    {
                        texto = oSheet.Cells[i, 1].text;
                        if (texto.Trim() == "")
                        {
                            break;
                        }
                        productor2 = new E_Productor();
                        productor2.Descripcion = oSheet.Cells[i, 1].text;
                        productor2.Codigo_Cliente = oSheet.Cells[i, 2].text;
                        productor2.Codigo_Productor = oSheet.Cells[i, 3].text;

                        if (productor1.Agregar(productor2))
                        {
                            i++;
                            ingresadas++;
                        }
                        else
                        {
                            Detalle += "Linea Excel "+i+": "+productor1.Mensaje + "\n";
                            i++;
                            errores++;
                        }


                    }
                    // oSheet.Cells[1, 1]
                    // oSheet.Activate()
                }

                if (ingresadas != 0 && errores != 0)
                {
                    Mensaje = ingresadas + " entradas registradas con exito." + "\n" + errores + " entradas no se pudieron agregar.";
                }
                else
                {
                    if (ingresadas == 0 && errores != 0)
                    {
                        Mensaje = errores + " entradas no se pudieron agregar.";
                    }
                    else
                    {
                        if (ingresadas != 0 && errores == 0)
                        {
                            Mensaje = ingresadas + " entradas registradas con exito.";
                        }
                        else
                        {
                            Mensaje = "El archivo no tiene el formato correcto o no se han encontrado datos";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Mensaje = ex.Message;
                throw new Exception("Error Excel " + ex.Message);
            }
        }
    }
}
