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

        Microsoft.Office.Interop.Excel.Application oExcel;
        Microsoft.Office.Interop.Excel.Workbook oBook;
        Microsoft.Office.Interop.Excel.Worksheet oSheet;


        public void CargaPlanilla(string sFile)
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
                LoadCodigos(sFile);               
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
                throw new Exception("Error Leer Excel " + ex.Message);
            }
            finally
            {
                //Vuelve cultura antigua
                Thread.CurrentThread.CurrentCulture = OldCultureInfo;
            }     

        }

        void LoadCodigos(string sFile)
        {
            int totalHojas,j,i;
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
                        texto = oSheet.Cells[i, 2].text;
                        if (texto.Trim() == "")
                        {
                            break;
                        }
                        eCliente2 = new E_Cliente();
                        eCliente2.Codigo = oSheet.Cells[i, 1].text;
                        eCliente2.Cliente = oSheet.Cells[i, 2].Text;

                        cliente1.AgregarMasivo(eCliente2);
                        i++;

                    }
                   // oSheet.Cells[1, 1]
    //                oSheet.Activate()
                }

            }
            catch(Exception ex)
            {
                throw new Exception("Error Excel " + ex.Message);
            }
        }


    //    Private Sub LoadCodigos(ByVal sFile As String)
    //    Dim i As Long
    //    Dim e_articulo1 As New E_Articulo
    //    Dim TotalHojas As Integer
    //    Dim porcentaje As Integer
    //    Dim registros As Integer

    //    _Progreso = 1

    //    Try
    //        oBook = oExcel.Workbooks.Open(sFile)

    //        TotalHojas = oBook.Sheets.Count

    //        Dim articulo1 As New D_Articulo

    //        If articulo1.Conectar = True Then


    //            For j = 1 To TotalHojas
    //                oSheet = oBook.Sheets(j)
    //                oSheet.Activate()
    //                ' Cargamos Productos 
    //                i = 2
    //                Mensaje = ""

    //                registros = oSheet.Cells.Range("B1").CurrentRegion.Rows.Count()

    //                Do While True
    //                    If Len(Trim(oSheet.cells(i, 2).Value)) = 0 Then
    //                        Exit Do
    //                    End If

    //                    e_articulo1.soldto = Trim(oSheet.cells(i, 6).Value)
    //                    e_articulo1.skuCliente = Trim(oSheet.cells(i, 2).Value)
    //                    e_articulo1.EAN = Trim(oSheet.cells(i, 5).Value)
    //                    e_articulo1.articleNo = Trim(oSheet.cells(i, 3).Value)
    //                    e_articulo1.size = Trim(oSheet.cells(i, 4).Value)
    //                    e_articulo1.temporada = Trim(oSheet.cells(i, 7).Value)

    //                    ' Buscar cliente
    //                    ' solo si es nuevo

    //                    ''falta validar si existe para no duplicar
    //                    'If articulo1.Existe(e_articulo1) = False Then
    //                    '    If articulo1.Insertar(e_articulo1) = False Then
    //                    '        Mensaje = articulo1.Mensaje
    //                    '    End If
    //                    'End If

    //                    If articulo1.Existe(e_articulo1) = False Then
    //                        If articulo1.Insertar(e_articulo1) = False Then
    //                            Mensaje = articulo1.Mensaje
    //                        End If
    //                    Else
    //                        If articulo1.Actualizar2(e_articulo1) = False Then
    //                            Mensaje = articulo1.Mensaje
    //                        End If
    //                    End If

    //                    porcentaje = (i * 100) / registros

    //                    Application.DoEvents()
    //                    i = i + 1
    //                    If porcentaje > 100 Then porcentaje = 100

    //                    _Progreso = porcentaje
    //                    If Cancelar = True Then
    //                        Exit For
    //                    End If
    //                    N_Generic.porcentaje = (i - 2) * 100 / registros   'resto 2 porque estoy utilizando las posiciones y parten en 2
    //                    If N_Generic.porcentaje > 100 Then
    //                        N_Generic.porcentaje = 100
    //                    End If

    //                Loop


    //            Next

    //        End If
    //        Progreso = 100
    //        articulo1.Desconectar()

    //    Catch ex As Exception
    //        MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
    //        oExcel.Visible = True
    //        Exit Sub
    //    End Try

    //End Sub


    }
}
