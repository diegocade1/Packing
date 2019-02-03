using Entity;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Packing
{
    public partial class frmLista : frmMantenedorAMB
    {
        E_Usuario sesion { set; get; }
        N_Recepcion recepcion1 { set; get; }
        public frmLista(E_Usuario usuario, N_Recepcion recepcion)
        {
            InitializeComponent();
            sesion = usuario;
            recepcion1 = recepcion;
        }

        private void frmLista_Load(object sender, EventArgs e)
        {
            N_Bandeja bandeja1 = new N_Bandeja();
            N_Pallet pallet1 = new N_Pallet();
            dgvLista.Visible = false;

            dgvLista1.DataSource = recepcion1.Obtener_Detalles_Recepcion().Select(ob => new
            {
                ID = ob.ID,
                Bandeja = ob.Bandeja,
                Peso_Bandeja = ob.Peso_Bandeja,
                Cantidad_bandejas = ob.Cantidad_Bandejas,
                Folio = ob.Folio,
                Kilos_Brutos = ob.Kilos_Brutos,
                Tara = ob.Tara,
                Kilos_netos = ob.Kilos_Netos,
                Tipo_pallet = ob.Tipo_Pallet,
                Peso_pallet = ob.Peso_Pallet,
                Fecha = ob.Fecha,
                Usuario = ob.Usuario,
                Posicion = ob.Posicion
            }).ToList();

            //dgvLista1.DataBindingComplete += (o, _) =>
            //{
            //    var dataGridView = o as DataGridView;
            //    if (dataGridView != null)
            //    {
            //        dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //        dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //    }
            //};

            cmbBandeja.DataSource = bandeja1.Lista();
            cmbBandeja.DisplayMember = "descripcion";
            cmbBandeja.ValueMember = "codigo";
            cmbBandeja.SelectedIndex = -1;

            cmbTipoPallet.DataSource = pallet1.Lista();
            cmbTipoPallet.DisplayMember = "descripcion";
            cmbTipoPallet.ValueMember = "codigo";
            cmbTipoPallet.SelectedIndex = -1;

            btnEliminar.Visible = false;
            btnImportar.Visible = false;
            btnAgregar.Visible = false;
        }

        private void LlenarGrilla()
        {
            dgvLista1.DataSource = recepcion1.Obtener_Detalles_Recepcion().Select(ob => new
            {
                ID = ob.ID,
                Bandeja = ob.Bandeja,
                Peso_Bandeja = ob.Peso_Bandeja,
                Cantidad_bandejas = ob.Cantidad_Bandejas,
                Folio = ob.Folio,
                Kilos_Brutos = ob.Kilos_Brutos,
                Tara = ob.Tara,
                Kilos_netos = ob.Kilos_Netos,
                Tipo_pallet = ob.Tipo_Pallet,
                Peso_pallet = ob.Peso_Pallet,
                Fecha = ob.Fecha,
                Usuario = ob.Usuario,
                Posicion = ob.Posicion
            }).ToList();
        }

        private bool ValidarCampos()
        {

            if (cmbBandeja.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Bandejas", "");
                cmbBandeja.Focus();
                return false;
            }

            if (cmbTipoPallet.Text.Trim() == "")
            {
                MessageBox.Show("Seleccione Tipo Pallet", "");
                cmbTipoPallet.Focus();
                return false;
            }

            if (txtKilos.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Kilos", "");
                txtKilos.Focus();
                return false;
            }

            if (txtCantidadBandejas.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Cantidad Bandejas", "");
                txtCantidadBandejas.Focus();
                return false;
            }

            return true;

        }

        bool ValidaDecimal(string valor)
        {
            decimal value;
            if (Decimal.TryParse(valor, out value))
                return true;
            else
                return false;
        }

        bool ValidaPesoBruto()
        {
            double kilos_brutos;
            double tara, pesoBandeja, pesoPallet;
            kilos_brutos = Convert.ToDouble(txtKilos.Text);

            N_Bandeja bandeja1 = new N_Bandeja();
            N_Pallet pallet1 = new N_Pallet();

            pesoBandeja = bandeja1.Peso(cmbBandeja.SelectedValue.ToString());
            pesoBandeja = pesoBandeja * Convert.ToInt32(txtCantidadBandejas.Text);
            pesoPallet = pallet1.Peso(cmbTipoPallet.SelectedValue.ToString());
            tara = pesoBandeja + pesoPallet;

            if (kilos_brutos <= tara)
            {
                return false;
            }
            return true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos() == false)
                return;

            if (ValidaDecimal(txtKilos.Text) == false)
            {
                MessageBox.Show("Kilos ingresados no son Validos");
                txtKilos.SelectAll();
                txtKilos.Focus();
                return;
            }

            if (ValidaPesoBruto() == false)
            {
                MessageBox.Show("Peso Bruto debe ser Mayor a Tara");
                txtKilos.SelectAll();
                txtKilos.Focus();
                return;
            }

            switch (lblTipoAccion.Text)
            {
                case "Agregar":
                    AgregarBandeja();
                    break;
                case "Modificar":
                    ModificarDetalle();
                    break;
                    //  default:
                    //     Console.WriteLine("Default case");
                    //    break;
            }
            panelCampos.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelCampos.Visible = false;
        }

        #region Metodos virtuales

        public override void Agregar()
        {
            //panelCampos.Top = 0;
            //panelCampos.Left = 0;
            //panelCampos.Visible = true;
            //lblTipoAccion.Text = "Agregar";
            //btnAceptar.Text = lblTipoAccion.Text;

        }

        void AgregarBandeja()
        {
            //N_Bandeja bandeja1 = new N_Bandeja();
            //E_Bandeja bandeja2 = new E_Bandeja();

            //bandeja2.Codigo = "0";
            //bandeja2.Descripcion = txtDescripcionBandeja.Text;
            //bandeja2.Peso = Convert.ToDouble(txtPeso.Text.Replace(".", ","));
            //if (bandeja1.Agregar(bandeja2) == true)
            //{
            //    dgvLista.DataSource = bandeja1.Lista();
            //}
            //else
            //{
            //    MessageBox.Show("Error: No se pudo agregar el registro", "Agregar");
            //}
        }

        public override void Modificar()
        {

            if (dgvLista1.SelectedRows.Count != 0)
            {
                panelCampos.Top = 0;
                panelCampos.Left = 0;
                panelCampos.Visible = true;
                lblTipoAccion.Text = "Modificar";
                btnAceptar.Text = lblTipoAccion.Text;

                int pos = dgvLista1.CurrentRow.Index;

                recepcion1.Detalle = new E_Recepcion_Detalle();
                recepcion1.Detalle.ID = dgvLista1.Rows[pos].Cells["id"].Value.ToString();
                E_Recepcion_Detalle detalle = recepcion1.Obtener_Detalle();

                cmbBandeja.SelectedValue = detalle.ID_bandeja;
                cmbTipoPallet.SelectedValue = detalle.ID_Pallet;
                txtCantidadBandejas.Text = detalle.Cantidad_Bandejas;
                double kilos_brutos = Convert.ToDouble(detalle.Kilos_Brutos);
                txtKilos.Text = kilos_brutos.ToString().Replace(",",".");
                lblID.Text = dgvLista1.Rows[pos].Cells["id"].Value.ToString();

            }

        }

        void ModificarDetalle()
        {
            double pesoBandeja = 0;
            double pesoPallet = 0;
            double tara, pesoNeto;

            N_Bandeja bandeja1 = new N_Bandeja();
            N_Pallet pallet1 = new N_Pallet();

            pesoBandeja = bandeja1.Peso(cmbBandeja.SelectedValue.ToString());
            pesoPallet = pallet1.Peso(cmbTipoPallet.SelectedValue.ToString());

            recepcion1.Detalle = new E_Recepcion_Detalle();
            recepcion1.Detalle.ID = lblID.Text;
            recepcion1.Obtener_Detalle();
            recepcion1.Detalle.ID_bandeja = cmbBandeja.SelectedValue.ToString();
            recepcion1.Detalle.Bandeja = cmbBandeja.Text.ToString();
            recepcion1.Detalle.Peso_Bandeja = pesoBandeja.ToString();
            recepcion1.Detalle.Cantidad_Bandejas = txtCantidadBandejas.Text;
            recepcion1.Detalle.Kilos_Brutos = txtKilos.Text;
            tara = (pesoBandeja * Convert.ToInt32(txtCantidadBandejas.Text)) + pesoPallet;
            recepcion1.Detalle.Tara = tara.ToString();
            double kilos_brutos = Convert.ToDouble(txtKilos.Text.Replace(".",","));
            pesoNeto = kilos_brutos - tara;
            recepcion1.Detalle.Kilos_Netos = pesoNeto.ToString();
            recepcion1.Detalle.ID_Pallet = cmbTipoPallet.SelectedValue.ToString();
            recepcion1.Detalle.Tipo_Pallet = cmbTipoPallet.Text;
            recepcion1.Detalle.Peso_Pallet = pesoPallet.ToString();

            if (recepcion1.Modificar_Detalle() == true)
            {
                LlenarGrilla();
            }
            else
            {
                MessageBox.Show("Error: No se pudo modificar el registro", "Modificar");
            }
        }

        public override void Borrar()
        {
            //if (dgvLista.SelectedRows.Count != 0)
            //{

            //    int pos = dgvLista.CurrentRow.Index;
            //    string ID;
            //    ID = dgvLista.Rows[pos].Cells["codigo"].Value.ToString();
            //    if (MessageBox.Show("¿Borrar Registro Seleccionado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            //    {
            //        return;
            //    }

            //    N_Bandeja bandeja1 = new N_Bandeja();
            //    if (bandeja1.Borrar(ID) == true)
            //    {
            //        dgvLista.DataSource = bandeja1.Lista();
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("Seleccione Item", "Borrar");
            //}

        }

        public override void Importar()
        {
            //Leer_ArchivoExcel excel1 = new Negocio.Leer_ArchivoExcel();
            //try
            //{
            //    OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //    openFileDialog1.Filter = "Archivo Excel|*.xlsx";
            //    openFileDialog1.Title = "Seleccione Archivo";

            //    if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //    {
            //        //excel1.CargaPlanilla(openFileDialog1.FileName);

            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Excel " + ex.Message);
            //    return;
            //}

            //MessageBox.Show("Archivo Cargado");

        }

        public override void CellClick()
        {
            Limpiar();
            panelCampos.Visible = false;
        }

        #endregion

        private void Limpiar()
        {
            cmbBandeja.SelectedIndex = -1;
            cmbTipoPallet.SelectedIndex = -1;
            txtKilos.Text = string.Empty;
            txtCantidadBandejas.Text = string.Empty;
        }

        private void dgvLista1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CellClick();
        }

        private void txtCantidadBandejas_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void txtKilos_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '.')
            {
                if (e.KeyChar == '.' && txtKilos.Text.Contains("."))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }
    }
}
