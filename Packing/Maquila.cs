using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entity;
using Clases.Impresion;


namespace Packing
{
    public partial class Maquila : Form
    {
        public Maquila()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        N_Cliente cliente1 = new N_Cliente();
        N_Productor productor1 = new N_Productor();

        private void Maquila_Load(object sender, EventArgs e)
        {
            dgvListaRecepcion.Columns.Add("item", "Item");
            dgvListaRecepcion.Columns[0].Width = 30;
            dgvListaRecepcion.Columns.Add("folio", "Folio");
            dgvListaRecepcion.Columns.Add("kilos_Netos", "Kilos Netos");
            //dgvListaRecepcion.Columns.Add("cantidad_bandejas", "Cantidad Bandejas");
            //dgvListaRecepcion.Columns.Add("descripcion", "Descripcion");

            dgvListaExportacion.Columns.Add("item", "Item");
            dgvListaExportacion.Columns[0].Width = 30;
            dgvListaExportacion.Columns.Add("folio", "Folio");
            dgvListaExportacion.Columns.Add("Peso_Teorico", "Peso Teorico");
            dgvListaExportacion.Columns.Add("cantidad_cajas", "Cantidad Cajas");
            dgvListaExportacion.Columns.Add("cantidad_potes", "Cantidad Potes");            
            dgvListaExportacion.Columns.Add("Total_Peso", "Total Peso");

            dgvListaComercial.Columns.Add("item", "Item");
            dgvListaComercial.Columns[0].Width = 30;
            dgvListaComercial.Columns.Add("folio", "Folio");
            dgvListaComercial.Columns.Add("tipo", "Tipo");
            dgvListaComercial.Columns.Add("kilos_Netos", "Kilos Netos");

            IniciarDateTimePicker();

            CargarCombos();

            for (int i = 1; i < 4; i++)
                cmbLinea.Items.Add(i);

        }

        void IniciarDateTimePicker()
        {
            dtpFechaRecepcion.Format  = DateTimePickerFormat.Custom;
            dtpFechaRecepcion.CustomFormat = " ";

            dtpFechaProceso.Format = DateTimePickerFormat.Custom;
            dtpFechaProceso.CustomFormat = " ";
           
            dtpHoraInicio.Format = DateTimePickerFormat.Custom;
            dtpHoraInicio.CustomFormat = " ";

            dtpHoraFin.Format = DateTimePickerFormat.Custom;
            dtpHoraFin.CustomFormat = " ";

        }

        void CargarCombos()
        {
            cmbExportador.DataSource = cliente1.Lista();
            cmbExportador.DisplayMember = "cliente";
            cmbExportador.ValueMember = "codigo";
            cmbExportador.SelectedIndex = -1;
        }

        N_Maquila maquila1= new N_Maquila();

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            decimal total_peso_teorico = Convert.ToDecimal(lblPesoTeorico.Text);
            decimal total_kilos_Comercial = Convert.ToDecimal(lblKilosSalidaComercial.Text);
            decimal total_kilos_Merma = Convert.ToDecimal(lblKilosSalidaMerma.Text);
            decimal total_kilos_Recepcion = Convert.ToDecimal(lblKilosRecepcion.Text);

            if (ValidaCampos() == false)
            {
                return;
            }

            N_Maquila maquila1 = new N_Maquila();
            List<E_Maquila> lista_Maquila = new List<E_Maquila>();
            List<E_Recepcion_Detalle> lista_Recepcion = new List<E_Recepcion_Detalle>();
            E_Recepcion_Detalle recepcion1;
            bool estado = false;

            maquila1.Maquila = new E_Maquila();
            maquila1.Maquila.ID_Cliente = cmbExportador.SelectedValue.ToString();
            maquila1.Maquila.Cliente = cmbExportador.Text;
            maquila1.Maquila.ID_Productor = cmbProductor.SelectedValue.ToString();
            maquila1.Maquila.Productor = cmbProductor.Text;
            maquila1.Maquila.Lote = "1"; //Falta Lote txtlote.text;
            maquila1.Maquila.Documento = txtGuia.Text;
            maquila1.Maquila.Fecha_Recepcion = dtpFechaRecepcion.Value;
            maquila1.Maquila.Fecha_Proceso = dtpFechaProceso.Value;
            maquila1.Maquila.OrdenEmbalaje = txtOrdenEmbalaje.Text;
            maquila1.Maquila.Linea = cmbLinea.Text;
            maquila1.Maquila.Hora_Inicio = dtpHoraInicio.Value;
            maquila1.Maquila.Hora_Termino = dtpHoraFin.Value;
            maquila1.Maquila.Rendimiento = txtRedimiento.Text;
            maquila1.Maquila.Kilos_PesoTeorico = total_peso_teorico;
            maquila1.Maquila.Kilos_Comerciales = total_kilos_Comercial;
            maquila1.Maquila.Kilos_Merma = total_kilos_Merma;
            maquila1.Maquila.Kilos_Recepcion = total_kilos_Recepcion;

            estado = maquila1.Agregar();
            if (estado == true)
            { 

                List<E_Pallet> lista_pallet1 = new List<E_Pallet>();
                for (int i = dgvListaRecepcion.Rows.Count - 1; i >= 0; i--)
                {
                
                    DataGridViewRow row = dgvListaRecepcion.Rows[i];
                    recepcion1 = new E_Recepcion_Detalle();
                   // maquila1.Maquila_Recepcion = new E_Maquila();

                    recepcion1.Folio = row.Cells["Folio"].Value.ToString();
                    recepcion1.Kilos_Netos = row.Cells["Kilos_Netos"].Value.ToString();
                    lista_Recepcion.Add(recepcion1);

                    maquila1.Modificar_Estado(recepcion1.Folio, maquila1.Maquila.ID.ToString());

                }

                E_Pallet_Exportacion exportacion1;
                List<E_Pallet_Exportacion> lista_Exportacion = new List<E_Pallet_Exportacion>();
                int totalCajas = 0;
                int totalPotes = 0;
                for (int i = dgvListaExportacion.Rows.Count -1; i >= 0; i--)
                {
                    DataGridViewRow row = dgvListaExportacion.Rows[i];
                    exportacion1 = new E_Pallet_Exportacion();
                  //  maquila1.Maquila_Recepcion = new E_Maquila();

                    exportacion1.Codigo  = row.Cells["folio"].Value.ToString();
                    exportacion1.Peso = Convert.ToDouble(row.Cells["Peso_Teorico"].Value);
                    exportacion1.Cajas = Convert.ToInt32(row.Cells["cantidad_cajas"].Value);
                    exportacion1.Total_Peso = Convert.ToDouble(row.Cells["total_peso"].Value);
                    exportacion1.Potes = Convert.ToInt32(row.Cells["cantidad_potes"].Value);
                    exportacion1.ID_Cliente = cmbExportador.SelectedValue.ToString();
                    exportacion1.ID_Productor = cmbProductor.SelectedValue.ToString();

                    lista_Exportacion.Add(exportacion1);
                    totalCajas = totalCajas + exportacion1.Cajas;
                    totalPotes = totalPotes + exportacion1.Potes;
                    maquila1.Modificar_Estado_Exportacion(exportacion1, maquila1.Maquila.ID.ToString());

                }

                E_Pallet_Comercial pallet1;
                List<E_Pallet_Comercial> lista_comercial = new List<E_Pallet_Comercial>();
                for(int i = dgvListaComercial.RowCount -1;i>=0;i--)
                {
                    DataGridViewRow row = dgvListaComercial.Rows[i];
                    pallet1 = new E_Pallet_Comercial();
                    pallet1.Codigo = row.Cells["folio"].Value.ToString();
                    pallet1.Tipo = row.Cells["tipo"].Value.ToString();
                    pallet1.Kilos_Netos = Convert.ToDouble(row.Cells["kilos_netos"].Value);
                    lista_comercial.Add(pallet1);
                    maquila1.Modificar_Estado_Comercial(pallet1.Codigo, maquila1.Maquila.ID.ToString());
                }

                decimal kilos_exportacion = maquila1.Maquila.Kilos_Recepcion - (maquila1.Maquila.Kilos_Comerciales + maquila1.Maquila.Kilos_Merma);
                decimal total_sobrepeso = kilos_exportacion - maquila1.Maquila.Kilos_PesoTeorico;
                decimal total_sobrepesoCajas = total_sobrepeso / totalCajas;
                decimal total_sobrepesoPotes = total_sobrepeso / totalPotes;
                decimal porcentaje_rendimiento = kilos_exportacion / maquila1.Maquila.Kilos_Recepcion;
                Imprimir_Maquila(maquila1.Maquila, lista_Recepcion, lista_Exportacion, lista_comercial,maquila1.Maquila.Kilos_Recepcion.ToString(), maquila1.Maquila.Kilos_Comerciales.ToString(), maquila1.Maquila.Kilos_Merma.ToString(), kilos_exportacion.ToString(),total_sobrepeso.ToString("N2"), total_sobrepesoCajas.ToString("N2"),total_sobrepesoPotes.ToString("N2"), maquila1.Maquila.Kilos_PesoTeorico.ToString("N2"), porcentaje_rendimiento.ToString("N2"));
            }

        }

        bool ValidaCampos()
        {

            if ( cmbExportador.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Exportador", "Guardar");
                cmbExportador.Focus();
                return false;
            }

            if (cmbProductor.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Productor", "Guardar");
                cmbProductor.Focus();
                return false;
            }

            if (txtGuia.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Guia", "Guardar");
                txtGuia.Focus();
                return false;
            }

            if (dtpFechaRecepcion.Text  == " ")
            {
                MessageBox.Show("Ingrese Fecha Recepcion", "Guardar");
                dtpFechaRecepcion.Focus();
                return false;
            }

            //orden embalaje 
            //if (txtOrdenEmbalaje.Text.Trim() == "")
            //{
            //    MessageBox.Show("Ingrese Orden Embalaje", "Guardar");
            //    txtOrdenEmbalaje.Focus();
            //    return false;
            //}

            if (dtpFechaProceso.Text == " ")
            {
                MessageBox.Show("Ingrese Fecha Proceso", "Guardar");
                dtpFechaProceso.Focus();
                return false;
            }

            if (cmbLinea.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Linea", "Guardar");
                cmbLinea.Focus();
                return false;
            }

            if (dtpHoraInicio.Text == " ")
            {
                MessageBox.Show("Ingrese Hora Inicio", "Guardar");
                dtpHoraInicio.Focus();
                return false;
            }

            if (dtpHoraFin.Text == " ")
            {
                MessageBox.Show("Ingrese Hora Termino", "Guardar");
                dtpHoraFin.Focus();
                return false;
            }

            if (txtRedimiento.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Rendimiento", "Guardar");
                txtRedimiento.Focus();
                return false;
            }

            if (dgvListaRecepcion.Rows.Count == 0)
            {
                MessageBox.Show("Ingrese Folio Recepcion","Guardar");
                txtPalletRecepcion.Focus();
                return false;
            }

            if (dgvListaExportacion.Rows.Count == 0)
            {
                MessageBox.Show("Ingrese Folio Exportacion", "Guardar");
                txtPalletExportacion.Focus();
                return false;
            }

            if (dgvListaComercial.Rows.Count == 0)
            {
                MessageBox.Show("Ingrese Folio Comercial", "Guardar");
                txtPalletComercial.Focus();
                return false;
            }



            return true;
        }

        private void Imprimir_Maquila(E_Maquila maquila, List<E_Recepcion_Detalle> recepcion, List<E_Pallet_Exportacion> exportacion,List<E_Pallet_Comercial> comercial, string total_kilos_netos, string total_kilos_comerciales, string total_kilos_merma, string total_kilos_exportacion, string total_sobrepeso, string total_sobrepeso_cajas, string total_sobrepeso_potes, string total_peso_teorico,string rendimiento_porcentaje )
        {
            N_Imprimir imprimir = new N_Imprimir();
            N_Maquila_Encabezado encabezado = new N_Maquila_Encabezado();
            encabezado.Exportador = maquila.Cliente;
            encabezado.Productor = maquila.Productor;
            encabezado.Guia_despacho = maquila.Documento;
            encabezado.Fecha_recepcion = maquila.Fecha_Recepcion.ToShortDateString();
            encabezado.Orden_embalaje = maquila.OrdenEmbalaje;
            encabezado.Fecha_Proceso = maquila.Fecha_Proceso.ToShortDateString();
            encabezado.Linea = maquila.Linea;
            encabezado.Hora_Inicio = maquila.Hora_Inicio.ToShortTimeString();
            encabezado.Hora_Termino = maquila.Hora_Termino.ToShortTimeString();
            encabezado.Rendimiento = maquila.Rendimiento;
            encabezado.Numero_lote = maquila.Lote;


            //PENDIENTE:deberia ser de encabezado maquila 
            N_Maquila_Salida exportacion_encabezado = new N_Maquila_Salida();
            exportacion_encabezado.Fecha_proceso = maquila.Fecha_Proceso.ToShortDateString();
            exportacion_encabezado.Hora_inicio = maquila.Hora_Inicio.ToShortTimeString();
            exportacion_encabezado.Hora_termino = maquila.Hora_Termino.ToShortTimeString();
            exportacion_encabezado.Lineas = maquila.Linea;
            exportacion_encabezado.Rendimiento = maquila.Rendimiento;

            // Recepcion detalle           
            N_Maquila_Detalle_Recepcion detalle_recepcion;
            List<N_Maquila_Detalle_Recepcion> lista_detalle_recepcion = new List<N_Maquila_Detalle_Recepcion>();
             foreach (E_Recepcion_Detalle recepcion2 in recepcion)
            {
                detalle_recepcion = new N_Maquila_Detalle_Recepcion();
                detalle_recepcion.Folio_pallet = recepcion2.Folio;
                detalle_recepcion.Total_kilos_netos = recepcion2.Kilos_Netos;
                lista_detalle_recepcion.Add(detalle_recepcion);

            }

             //Corresponde a Exportacion            
            N_Maquila_Cajas exportacion_detalle = new N_Maquila_Cajas();

            List<N_Maquila_Cajas> lista_exportacion_detalle = new List<N_Maquila_Cajas>();
            foreach (E_Pallet_Exportacion exportacion2 in exportacion)
            {
                exportacion_detalle = new N_Maquila_Cajas();
                exportacion_detalle.Numero_pallet = exportacion2.Codigo;
                exportacion_detalle.Formato = exportacion2.Embalaje;
                exportacion_detalle.Cajas = exportacion2.Cajas.ToString();
                exportacion_detalle.Peso_teorico = exportacion2.Peso.ToString();
                exportacion_detalle.Total_peso_teorico = exportacion2.Total_Peso.ToString();
                lista_exportacion_detalle.Add(exportacion_detalle);
            }

            //Corresponde a Comercial y merma      
            N_Maquila_Salida_Detalle comercial_detalle = new N_Maquila_Salida_Detalle();
            List<N_Maquila_Salida_Detalle> lista_comercial_detalle = new List<N_Maquila_Salida_Detalle>();
            foreach (E_Pallet_Comercial comercial2 in comercial)
            {
                comercial_detalle = new N_Maquila_Salida_Detalle();
                if(comercial2.Tipo.ToLower() == "comercial")
                {
                    comercial_detalle.Kilos_comerciales = comercial2.Codigo + ": " + comercial2.Kilos_Netos.ToString();
                    lista_comercial_detalle.Add(comercial_detalle);
                }                   
                
            }
            int i = 0;
            bool edita = true;

            if (lista_comercial_detalle.Count == 0)
            {
                edita = false;
            }

            foreach (E_Pallet_Comercial comercial2 in comercial)
            {
                comercial_detalle = new N_Maquila_Salida_Detalle();
                if (comercial2.Tipo.ToLower() == "merma")
                {
                    if (edita == true)
                    {
                        if ((lista_comercial_detalle.Count - 1) <= i)
                        {
                            edita = false;
                        }
                        lista_comercial_detalle[i].Kilos_merma = comercial2.Codigo + ": " + comercial2.Kilos_Netos.ToString();
                        i++;
                    }
                    else
                    {
                        comercial_detalle = new N_Maquila_Salida_Detalle();
                        comercial_detalle.Kilos_merma = comercial2.Codigo + ": " + comercial2.Kilos_Netos.ToString();
                        lista_comercial_detalle.Add(comercial_detalle);
                    }


                }

            }

            N_Coordenadas_Impresion coordenadas = new N_Coordenadas_Impresion()
            {
                PosicionX = "0",
                PosicionY = "-3"
            };
            imprimir.Encabezado_maquila = encabezado; //encabezado
            imprimir.Salida_maquila = exportacion_encabezado; //Encabezado 

            imprimir.Detalle_recepcion_maquilas = lista_detalle_recepcion; //recepcion
            imprimir.Lista_salida_detalle_maquila = lista_comercial_detalle; //comercial/merma
            imprimir.Lista_cajas_maquila = lista_exportacion_detalle; //exportacion                 
           

            imprimir.Fuente = new Font("Verdana", 10);
            imprimir.Coordenadas_impresion = coordenadas;

            /*PROPIEDADES DE TOTALES PARA IMPRESION*/

            imprimir.Total_kilos_netos = total_kilos_netos;
            imprimir.Total_kilos_comercio = total_kilos_comerciales;
            imprimir.Total_kilos_merma = total_kilos_merma;
            imprimir.Total_kilos_exportacion = total_kilos_exportacion;
            imprimir.Total_sobrepeso = total_sobrepeso;
            imprimir.Total_sobrepeso_cajas = total_sobrepeso_cajas;
            imprimir.Total_sobrepeso_pote = total_sobrepeso_potes;
            imprimir.Total_peso_teorico = total_peso_teorico;
            imprimir.Rendimiento_Porcentaje = rendimiento_porcentaje;

            /***************************************/

            PrintDocument pd = new PrintDocument();

            pd.PrintPage += new PrintPageEventHandler(imprimir.PrintTextFileHandlerMaquila);
            pd.DefaultPageSettings.PrinterSettings.PrinterName = N_Impresora.Nombre;
            if (pd.PrinterSettings.IsValid)
            {
                pd.Print();
            }
            else
            {
                MessageBox.Show("Impresora " + N_Impresora.Nombre + " no esta instalada");
                return;
            }
            //para utilizar con printdialog
            //printDialog1.Document = pd;
            //Llamar al printDialog 
            //if (printDialog1.ShowDialog() == DialogResult.OK) pd.Print();
        }

        private void txtPalletRecepcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (panelErrorRecepcion.Visible == true)
                panelErrorRecepcion.Visible = false;

            if (ValidarCamposClienteProductor() == false)
            {
                e.Handled = true;
                return;
            }


            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtPalletRecepcion.Text.Trim() == "")
                {
                    lblMensajeRecepcion.Text = "Ingrese Pallet";
                    panelErrorRecepcion.Visible = true;
                    return;
                }
               
                txtPalletRecepcion.Text = txtPalletRecepcion.Text.ToUpper();

                //revisa si  se agrego folio en grilla
                if (Existe_Pallet_Lista(dgvListaRecepcion,txtPalletRecepcion.Text) == true)
                {
                    lblMensajeRecepcion.Text = "Pallet ya esta en la Lista";
                    panelErrorRecepcion.Visible = true;
                    txtPalletRecepcion.SelectAll();
                    return;
                }

                N_Recepcion recepcion1 = new N_Recepcion();
                E_Pallet pallet1 = new E_Pallet();

                pallet1.Codigo = txtPalletRecepcion.Text;
                pallet1.ID_Cliente = cmbExportador.SelectedValue.ToString();
                pallet1.ID_Productor = cmbProductor.SelectedValue.ToString();

                if (recepcion1.Existe_Pallet(pallet1)  == true)
                {
                    if (pallet1.Estado != "0")
                    {
                        lblMensajeRecepcion.Text = "Pallet fue asignado";
                        panelErrorRecepcion.Visible = true;
                        txtPalletRecepcion.SelectAll();
                        return;
                    }
                    int rowNuevo;
                    rowNuevo = 0; //dgvLista.Rows.Count;

                    dgvListaRecepcion.Rows.Insert(0, 1);//  .Add(1);
                    dgvListaRecepcion.Rows[rowNuevo].Cells["item"].Value = (dgvListaRecepcion.Rows.Count);
                    dgvListaRecepcion.Rows[rowNuevo].Cells["folio"].Value = pallet1.Codigo;
                    dgvListaRecepcion.Rows[rowNuevo].Cells["kilos_netos"].Value = pallet1.Peso;
                  //  dgvListaRecepcion.Rows[rowNuevo].Cells["cantidad_bandejas"].Value = pallet1.Cajas;
                  //  dgvListaRecepcion.Rows[rowNuevo].Cells["descripcion"].Value = pallet1.Descripcion;
                    dgvListaRecepcion.Rows[0].Selected = true;
                    lblKilosRecepcion.Text = Total_Kilos_Lista(dgvListaRecepcion,"kilos_netos").ToString();


                }
                else
                {
                    lblMensajeRecepcion.Text = "Pallet no Existe";
                    panelErrorRecepcion.Visible = true;
                }
                txtPalletRecepcion.Text = "";
                txtPalletRecepcion.Focus();

            }
        }

        bool ValidarCamposClienteProductor()
        {
            if (cmbExportador.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Exportador", "Validar");
                cmbExportador.Focus();
                return false;
            }

            if (cmbProductor.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Productor", "Validar");
                cmbProductor.Focus();
                return false;
            }
            return true;
        }


        private bool Existe_Pallet_Lista(DataGridView lista,string folio)
        {
            foreach (DataGridViewRow Row in lista.Rows)
            {
               // int strFila = Row.Index.ToString();
                string valor = Convert.ToString(Row.Cells["Folio"].Value);

                if (valor.ToUpper() == folio.ToUpper())
                {
                 //   dgvListaRecepcion.Rows[strFila].DefaultCellStyle.BackColor = Color.Red;
                    return true;
                }
            }
            return false;
        }

        private double Total_Kilos_Lista(DataGridView lista,string campo)
        {
            double suma=0.0;
            double valor=0.0;
            foreach (DataGridViewRow Row in lista.Rows)
            {
                try
                {
                    valor = Convert.ToDouble(Row.Cells[campo].Value);
                }
                catch 
                {
                    valor = 0.0;
                }
                suma = suma + valor;
               
            }
            Math.Round(suma, 2);
            return suma;
        }

        //para filtrar los campos que desea contar caso especial merma/comercial
        private double Total_Kilos_Lista(DataGridView lista, string campo,string tipo)
        {
            double suma = 0.0;
            double valor = 0.0;
            foreach (DataGridViewRow Row in lista.Rows)
            {
                try
                {
                    if (Row.Cells["tipo"].Value.ToString() == tipo)
                    {
                        valor = Convert.ToDouble(Row.Cells[campo].Value);
                    }
                    else
                    {
                        valor = 0.0;
                    }
                }
                catch 
                {
                    valor = 0.0;
                }
                suma = suma + valor;

            }
            Math.Round(suma, 2);
            return suma;
        }

        private void txtPalletExportacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPalletExportacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (panelErrorExportacion.Visible == true)
                panelErrorExportacion.Visible = false;

            if (ValidarCamposClienteProductor() == false)
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtPalletExportacion.Text.Trim() == "")
                {
                    lblMensajeExportacion.Text = "Ingrese Pallet";
                    panelErrorExportacion.Visible = true;

                    return;
                }

                txtPalletExportacion.Text = txtPalletExportacion.Text.ToUpper();

                if (Existe_Pallet_Lista(dgvListaExportacion, txtPalletExportacion.Text) == true)
                {
                    lblMensajeExportacion.Text = "Pallet ya esta en la Lista";
                    panelErrorExportacion.Visible = true;
                    txtPalletExportacion.SelectAll();
                    return;
                }

                N_Exportacion exportacion1 = new N_Exportacion();
                E_Pallet_Exportacion pallet1 = new E_Pallet_Exportacion();

                pallet1.Codigo = txtPalletExportacion.Text;
                pallet1.ID_Cliente = cmbExportador.SelectedValue.ToString();
                pallet1.ID_Productor = cmbProductor.SelectedValue.ToString();
                if (exportacion1.Existe_Pallet(pallet1) == true)
                {
                    if (pallet1.Estado != "0")
                    {
                        lblMensajeExportacion.Text = "Pallet fue asignado";
                        panelErrorExportacion.Visible = true;
                        txtPalletExportacion.SelectAll();                        
                        return;
                    }
                    int rowNuevo;
                    rowNuevo = 0; //dgvLista.Rows.Count;

                    dgvListaExportacion.Rows.Insert(0, 1);//  .Add(1);
                    dgvListaExportacion.Rows[rowNuevo].Cells["item"].Value = (dgvListaExportacion.Rows.Count);
                    dgvListaExportacion.Rows[rowNuevo].Cells["folio"].Value = pallet1.Codigo;
                    dgvListaExportacion.Rows[rowNuevo].Cells["Peso_Teorico"].Value = pallet1.Peso;
                    dgvListaExportacion.Rows[rowNuevo].Cells["cantidad_cajas"].Value = pallet1.Cajas;
                    dgvListaExportacion.Rows[rowNuevo].Cells["cantidad_potes"].Value = pallet1.Potes;
                    dgvListaExportacion.Rows[rowNuevo].Cells["total_peso"].Value = pallet1.Total_Peso;
                    dgvListaExportacion.Rows[0].Selected = true;
                    lblPesoTeorico.Text = Total_Kilos_Lista(dgvListaExportacion, "Total_Peso").ToString();

                }
                else
                {
                    lblMensajeExportacion.Text = "Pallet no Existe";
                    panelErrorExportacion.Visible = true;
                   // txtPalletExportacion.SelectAll();                    
                }

                txtPalletExportacion.Text = "";



            }
        }

        private void dgvListaRecepcion_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void dgvListaExportacion_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void txtPalletExportacion_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtPalletComercial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (panelErrorComercial.Visible == true)
                panelErrorComercial.Visible = false;

            if (ValidarCamposClienteProductor() == false)
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtPalletComercial.Text.Trim() == "")
                {
                    lblMensajeComercial.Text = "Ingrese Pallet";
                    panelErrorComercial.Visible = true;
                    return;
                }

                txtPalletComercial.Text = txtPalletComercial.Text.ToUpper();

                if (Existe_Pallet_Lista(dgvListaComercial, txtPalletComercial.Text) == true)
                {
                    lblMensajeComercial.Text = "Pallet ya esta en la Lista";
                    panelErrorComercial.Visible = true;
                    txtPalletComercial.SelectAll();
                    return;
                }

                N_Comercial comercial1 = new N_Comercial();
                E_Pallet_Comercial pallet1 = new E_Pallet_Comercial();

                pallet1.Codigo = txtPalletComercial.Text;
                pallet1.ID_Cliente = cmbExportador.SelectedValue.ToString();
                pallet1.ID_Productor = cmbProductor.SelectedValue.ToString();
                if (comercial1.Existe_Pallet(pallet1) == true)
                {
                    if (pallet1.Estado != "0")
                    {
                        lblMensajeComercial.Text = "Pallet fue asignado";
                        panelErrorComercial.Visible = true;
                        return;
                    }
                    int rowNuevo;
                    rowNuevo = 0; //dgvLista.Rows.Count;

                    dgvListaComercial.Rows.Insert(0, 1);//  .Add(1);
                    dgvListaComercial.Rows[rowNuevo].Cells["item"].Value = (dgvListaComercial.Rows.Count);
                    dgvListaComercial.Rows[rowNuevo].Cells["folio"].Value = pallet1.Codigo;
                    dgvListaComercial.Rows[rowNuevo].Cells["tipo"].Value = pallet1.Tipo;
                    dgvListaComercial.Rows[rowNuevo].Cells["kilos_netos"].Value = pallet1.Kilos_Netos;
                  //  dgvListaComercial.Rows[rowNuevo].Cells["descripcion"].Value = pallet1.Descripcion;
                    dgvListaComercial.Rows[0].Selected = true;
                    lblKilosSalidaComercial.Text = Total_Kilos_Lista(dgvListaComercial, "kilos_netos","Comercial").ToString();
                    lblKilosSalidaMerma.Text = Total_Kilos_Lista(dgvListaComercial, "kilos_netos", "Merma").ToString();
                }
                else
                {
                    lblMensajeComercial.Text = "Pallet no Existe";
                    panelErrorComercial.Visible = true;
                }
                txtPalletComercial.Text = "";




            }
        }

        private void txtPalletComercial_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaRecepcion_MouseDown(object sender, MouseEventArgs e)
        {

            switch (e.Button)
            {
                case MouseButtons.Left:
                    dtpFechaRecepcion.Format = DateTimePickerFormat.Short;
                    dtpFechaRecepcion.Value = DateTime.Now;
                    break;
                case MouseButtons.Right:
                    dtpFechaRecepcion.Format = DateTimePickerFormat.Custom;
                    dtpFechaRecepcion.CustomFormat = " ";
                    break;                
            }
          
        }

        private void dtpFechaProceso_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    dtpFechaProceso.Format = DateTimePickerFormat.Short;
                    dtpFechaProceso.Value = DateTime.Now;
                    break;
                case MouseButtons.Right:
                    dtpFechaProceso.Format = DateTimePickerFormat.Custom;
                    dtpFechaProceso.CustomFormat = " ";
                    break;
            }

        }

        private void dtpHoraInicio_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    dtpHoraInicio.Format = DateTimePickerFormat.Time;
                    dtpHoraInicio.Value = DateTime.Now;
                    break;
                case MouseButtons.Right:
                    dtpHoraInicio.Format = DateTimePickerFormat.Time;
                    dtpHoraInicio.CustomFormat = " ";
                    break;
            }
        }

        private void dtpHoraFin_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    dtpHoraFin.Format = DateTimePickerFormat.Time;
                    dtpHoraFin.Value = DateTime.Now;
                    break;
                case MouseButtons.Right:
                    dtpHoraFin.Format = DateTimePickerFormat.Time;
                    dtpHoraFin.CustomFormat = " ";
                    break;
            }
        }

        private void cmbExportador_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbExportador.SelectedIndex == -1)
                return;
            cmbProductor.DataSource = productor1.Lista(cmbExportador.SelectedValue.ToString());
            cmbProductor.DisplayMember = "descripcion";
            cmbProductor.ValueMember = "codigo";
            cmbProductor.SelectedIndex = -1;
        }

        private void btnAgregarRecepcion_Click(object sender, EventArgs e)
        {

        }

        private void dgvListaRecepcion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPalletRecepcion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
