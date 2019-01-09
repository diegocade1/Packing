namespace Packing
{
    partial class Maquila
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvListaRecepcion = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtGuia = new System.Windows.Forms.TextBox();
            this.txtOrdenEmbalaje = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPalletRecepcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblKilosRecepcion = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnBorrarRecepcion = new System.Windows.Forms.Button();
            this.btnAgregarRecepcion = new System.Windows.Forms.Button();
            this.panelErrorRecepcion = new System.Windows.Forms.Panel();
            this.lblMensajeRecepcion = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lblPesoTeorico = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnBorrarExportacion = new System.Windows.Forms.Button();
            this.btnAgregarExportacion = new System.Windows.Forms.Button();
            this.panelErrorExportacion = new System.Windows.Forms.Panel();
            this.lblMensajeExportacion = new System.Windows.Forms.Label();
            this.dgvListaExportacion = new System.Windows.Forms.DataGridView();
            this.txtPalletExportacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblKilosSalidaMerma = new System.Windows.Forms.Label();
            this.lblKilosSalidaComercial = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPalletComercial = new System.Windows.Forms.TextBox();
            this.panelErrorComercial = new System.Windows.Forms.Panel();
            this.lblMensajeComercial = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvListaComercial = new System.Windows.Forms.DataGridView();
            this.cmbExportador = new System.Windows.Forms.ComboBox();
            this.cmbProductor = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtRedimiento = new System.Windows.Forms.TextBox();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaRecepcion = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaProceso = new System.Windows.Forms.DateTimePicker();
            this.cmbLinea = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRecepcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelErrorRecepcion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panelErrorExportacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaExportacion)).BeginInit();
            this.panelErrorComercial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaComercial)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaRecepcion
            // 
            this.dgvListaRecepcion.AllowUserToAddRows = false;
            this.dgvListaRecepcion.AllowUserToDeleteRows = false;
            this.dgvListaRecepcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaRecepcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaRecepcion.Location = new System.Drawing.Point(6, 49);
            this.dgvListaRecepcion.MultiSelect = false;
            this.dgvListaRecepcion.Name = "dgvListaRecepcion";
            this.dgvListaRecepcion.ReadOnly = true;
            this.dgvListaRecepcion.Size = new System.Drawing.Size(253, 199);
            this.dgvListaRecepcion.TabIndex = 0;
            this.dgvListaRecepcion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaRecepcion_CellContentClick);
            this.dgvListaRecepcion.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvListaRecepcion_ColumnAdded);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(685, 49);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(137, 37);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(685, 114);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(137, 37);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtGuia
            // 
            this.txtGuia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuia.Location = new System.Drawing.Point(136, 114);
            this.txtGuia.Name = "txtGuia";
            this.txtGuia.Size = new System.Drawing.Size(143, 26);
            this.txtGuia.TabIndex = 4;
            // 
            // txtOrdenEmbalaje
            // 
            this.txtOrdenEmbalaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrdenEmbalaje.Location = new System.Drawing.Point(136, 183);
            this.txtOrdenEmbalaje.Name = "txtOrdenEmbalaje";
            this.txtOrdenEmbalaje.Size = new System.Drawing.Size(143, 26);
            this.txtOrdenEmbalaje.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(415, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Linea";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Orden Embalaje";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Guia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Folio Recepcion";
            // 
            // txtPalletRecepcion
            // 
            this.txtPalletRecepcion.Location = new System.Drawing.Point(11, 20);
            this.txtPalletRecepcion.Name = "txtPalletRecepcion";
            this.txtPalletRecepcion.Size = new System.Drawing.Size(149, 20);
            this.txtPalletRecepcion.TabIndex = 13;
            this.txtPalletRecepcion.TextChanged += new System.EventHandler(this.txtPalletRecepcion_TextChanged);
            this.txtPalletRecepcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPalletRecepcion_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(346, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Proceso";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(10, 225);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblKilosRecepcion);
            this.splitContainer1.Panel1.Controls.Add(this.label16);
            this.splitContainer1.Panel1.Controls.Add(this.btnBorrarRecepcion);
            this.splitContainer1.Panel1.Controls.Add(this.btnAgregarRecepcion);
            this.splitContainer1.Panel1.Controls.Add(this.panelErrorRecepcion);
            this.splitContainer1.Panel1.Controls.Add(this.dgvListaRecepcion);
            this.splitContainer1.Panel1.Controls.Add(this.txtPalletRecepcion);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(829, 276);
            this.splitContainer1.SplitterDistance = 271;
            this.splitContainer1.TabIndex = 17;
            // 
            // lblKilosRecepcion
            // 
            this.lblKilosRecepcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblKilosRecepcion.AutoSize = true;
            this.lblKilosRecepcion.Location = new System.Drawing.Point(70, 251);
            this.lblKilosRecepcion.Name = "lblKilosRecepcion";
            this.lblKilosRecepcion.Size = new System.Drawing.Size(13, 13);
            this.lblKilosRecepcion.TabIndex = 22;
            this.lblKilosRecepcion.Text = "0";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 251);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Total Kilos";
            // 
            // btnBorrarRecepcion
            // 
            this.btnBorrarRecepcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrarRecepcion.Location = new System.Drawing.Point(219, 17);
            this.btnBorrarRecepcion.Name = "btnBorrarRecepcion";
            this.btnBorrarRecepcion.Size = new System.Drawing.Size(30, 26);
            this.btnBorrarRecepcion.TabIndex = 19;
            this.btnBorrarRecepcion.Text = "X";
            this.btnBorrarRecepcion.UseVisualStyleBackColor = true;
            // 
            // btnAgregarRecepcion
            // 
            this.btnAgregarRecepcion.Location = new System.Drawing.Point(166, 17);
            this.btnAgregarRecepcion.Name = "btnAgregarRecepcion";
            this.btnAgregarRecepcion.Size = new System.Drawing.Size(30, 26);
            this.btnAgregarRecepcion.TabIndex = 17;
            this.btnAgregarRecepcion.Text = "...";
            this.btnAgregarRecepcion.UseVisualStyleBackColor = true;
            this.btnAgregarRecepcion.Click += new System.EventHandler(this.btnAgregarRecepcion_Click);
            // 
            // panelErrorRecepcion
            // 
            this.panelErrorRecepcion.BackColor = System.Drawing.Color.Red;
            this.panelErrorRecepcion.Controls.Add(this.lblMensajeRecepcion);
            this.panelErrorRecepcion.Location = new System.Drawing.Point(14, 102);
            this.panelErrorRecepcion.Name = "panelErrorRecepcion";
            this.panelErrorRecepcion.Size = new System.Drawing.Size(206, 109);
            this.panelErrorRecepcion.TabIndex = 16;
            this.panelErrorRecepcion.Visible = false;
            // 
            // lblMensajeRecepcion
            // 
            this.lblMensajeRecepcion.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeRecepcion.ForeColor = System.Drawing.Color.White;
            this.lblMensajeRecepcion.Location = new System.Drawing.Point(8, 25);
            this.lblMensajeRecepcion.Name = "lblMensajeRecepcion";
            this.lblMensajeRecepcion.Size = new System.Drawing.Size(191, 66);
            this.lblMensajeRecepcion.TabIndex = 0;
            this.lblMensajeRecepcion.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXx";
            this.lblMensajeRecepcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lblPesoTeorico);
            this.splitContainer2.Panel1.Controls.Add(this.label17);
            this.splitContainer2.Panel1.Controls.Add(this.btnBorrarExportacion);
            this.splitContainer2.Panel1.Controls.Add(this.btnAgregarExportacion);
            this.splitContainer2.Panel1.Controls.Add(this.panelErrorExportacion);
            this.splitContainer2.Panel1.Controls.Add(this.dgvListaExportacion);
            this.splitContainer2.Panel1.Controls.Add(this.txtPalletExportacion);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label20);
            this.splitContainer2.Panel2.Controls.Add(this.lblKilosSalidaMerma);
            this.splitContainer2.Panel2.Controls.Add(this.lblKilosSalidaComercial);
            this.splitContainer2.Panel2.Controls.Add(this.label19);
            this.splitContainer2.Panel2.Controls.Add(this.txtPalletComercial);
            this.splitContainer2.Panel2.Controls.Add(this.panelErrorComercial);
            this.splitContainer2.Panel2.Controls.Add(this.button3);
            this.splitContainer2.Panel2.Controls.Add(this.button2);
            this.splitContainer2.Panel2.Controls.Add(this.label10);
            this.splitContainer2.Panel2.Controls.Add(this.dgvListaComercial);
            this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            this.splitContainer2.Size = new System.Drawing.Size(554, 276);
            this.splitContainer2.SplitterDistance = 272;
            this.splitContainer2.TabIndex = 0;
            // 
            // lblPesoTeorico
            // 
            this.lblPesoTeorico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPesoTeorico.AutoSize = true;
            this.lblPesoTeorico.Location = new System.Drawing.Point(113, 253);
            this.lblPesoTeorico.Name = "lblPesoTeorico";
            this.lblPesoTeorico.Size = new System.Drawing.Size(13, 13);
            this.lblPesoTeorico.TabIndex = 29;
            this.lblPesoTeorico.Text = "0";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 253);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "Total Peso Teorico";
            // 
            // btnBorrarExportacion
            // 
            this.btnBorrarExportacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrarExportacion.Location = new System.Drawing.Point(225, 14);
            this.btnBorrarExportacion.Name = "btnBorrarExportacion";
            this.btnBorrarExportacion.Size = new System.Drawing.Size(30, 26);
            this.btnBorrarExportacion.TabIndex = 27;
            this.btnBorrarExportacion.Text = "X";
            this.btnBorrarExportacion.UseVisualStyleBackColor = true;
            // 
            // btnAgregarExportacion
            // 
            this.btnAgregarExportacion.Location = new System.Drawing.Point(163, 15);
            this.btnAgregarExportacion.Name = "btnAgregarExportacion";
            this.btnAgregarExportacion.Size = new System.Drawing.Size(30, 26);
            this.btnAgregarExportacion.TabIndex = 25;
            this.btnAgregarExportacion.Text = "...";
            this.btnAgregarExportacion.UseVisualStyleBackColor = true;
            // 
            // panelErrorExportacion
            // 
            this.panelErrorExportacion.BackColor = System.Drawing.Color.Red;
            this.panelErrorExportacion.Controls.Add(this.lblMensajeExportacion);
            this.panelErrorExportacion.Location = new System.Drawing.Point(18, 102);
            this.panelErrorExportacion.Name = "panelErrorExportacion";
            this.panelErrorExportacion.Size = new System.Drawing.Size(206, 109);
            this.panelErrorExportacion.TabIndex = 24;
            this.panelErrorExportacion.Visible = false;
            // 
            // lblMensajeExportacion
            // 
            this.lblMensajeExportacion.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeExportacion.ForeColor = System.Drawing.Color.White;
            this.lblMensajeExportacion.Location = new System.Drawing.Point(12, 25);
            this.lblMensajeExportacion.Name = "lblMensajeExportacion";
            this.lblMensajeExportacion.Size = new System.Drawing.Size(191, 66);
            this.lblMensajeExportacion.TabIndex = 0;
            this.lblMensajeExportacion.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXx";
            this.lblMensajeExportacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvListaExportacion
            // 
            this.dgvListaExportacion.AllowUserToAddRows = false;
            this.dgvListaExportacion.AllowUserToDeleteRows = false;
            this.dgvListaExportacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaExportacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaExportacion.Location = new System.Drawing.Point(5, 49);
            this.dgvListaExportacion.MultiSelect = false;
            this.dgvListaExportacion.Name = "dgvListaExportacion";
            this.dgvListaExportacion.ReadOnly = true;
            this.dgvListaExportacion.Size = new System.Drawing.Size(254, 199);
            this.dgvListaExportacion.TabIndex = 21;
            // 
            // txtPalletExportacion
            // 
            this.txtPalletExportacion.Location = new System.Drawing.Point(5, 20);
            this.txtPalletExportacion.Name = "txtPalletExportacion";
            this.txtPalletExportacion.Size = new System.Drawing.Size(149, 20);
            this.txtPalletExportacion.TabIndex = 23;
            this.txtPalletExportacion.TextChanged += new System.EventHandler(this.txtPalletExportacion_TextChanged_1);
            this.txtPalletExportacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPalletExportacion_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Folio Exportacion";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 257);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(91, 13);
            this.label20.TabIndex = 37;
            this.label20.Text = "Total Kilos Merma";
            // 
            // lblKilosSalidaMerma
            // 
            this.lblKilosSalidaMerma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblKilosSalidaMerma.AutoSize = true;
            this.lblKilosSalidaMerma.Location = new System.Drawing.Point(121, 257);
            this.lblKilosSalidaMerma.Name = "lblKilosSalidaMerma";
            this.lblKilosSalidaMerma.Size = new System.Drawing.Size(13, 13);
            this.lblKilosSalidaMerma.TabIndex = 36;
            this.lblKilosSalidaMerma.Text = "0";
            // 
            // lblKilosSalidaComercial
            // 
            this.lblKilosSalidaComercial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblKilosSalidaComercial.AutoSize = true;
            this.lblKilosSalidaComercial.Location = new System.Drawing.Point(121, 243);
            this.lblKilosSalidaComercial.Name = "lblKilosSalidaComercial";
            this.lblKilosSalidaComercial.Size = new System.Drawing.Size(13, 13);
            this.lblKilosSalidaComercial.TabIndex = 34;
            this.lblKilosSalidaComercial.Text = "0";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 243);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(105, 13);
            this.label19.TabIndex = 33;
            this.label19.Text = "Total Kilos Comercial";
            // 
            // txtPalletComercial
            // 
            this.txtPalletComercial.Location = new System.Drawing.Point(6, 21);
            this.txtPalletComercial.Name = "txtPalletComercial";
            this.txtPalletComercial.Size = new System.Drawing.Size(149, 20);
            this.txtPalletComercial.TabIndex = 28;
            this.txtPalletComercial.TextChanged += new System.EventHandler(this.txtPalletComercial_TextChanged);
            this.txtPalletComercial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPalletComercial_KeyPress);
            // 
            // panelErrorComercial
            // 
            this.panelErrorComercial.BackColor = System.Drawing.Color.Red;
            this.panelErrorComercial.Controls.Add(this.lblMensajeComercial);
            this.panelErrorComercial.Location = new System.Drawing.Point(20, 102);
            this.panelErrorComercial.Name = "panelErrorComercial";
            this.panelErrorComercial.Size = new System.Drawing.Size(206, 109);
            this.panelErrorComercial.TabIndex = 32;
            this.panelErrorComercial.Visible = false;
            // 
            // lblMensajeComercial
            // 
            this.lblMensajeComercial.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeComercial.ForeColor = System.Drawing.Color.White;
            this.lblMensajeComercial.Location = new System.Drawing.Point(12, 25);
            this.lblMensajeComercial.Name = "lblMensajeComercial";
            this.lblMensajeComercial.Size = new System.Drawing.Size(191, 66);
            this.lblMensajeComercial.TabIndex = 0;
            this.lblMensajeComercial.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXx";
            this.lblMensajeComercial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(161, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 26);
            this.button3.TabIndex = 31;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(222, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 26);
            this.button2.TabIndex = 30;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "Folio Salida";
            // 
            // dgvListaComercial
            // 
            this.dgvListaComercial.AllowUserToAddRows = false;
            this.dgvListaComercial.AllowUserToDeleteRows = false;
            this.dgvListaComercial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaComercial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaComercial.Location = new System.Drawing.Point(6, 49);
            this.dgvListaComercial.MultiSelect = false;
            this.dgvListaComercial.Name = "dgvListaComercial";
            this.dgvListaComercial.Size = new System.Drawing.Size(255, 188);
            this.dgvListaComercial.TabIndex = 0;
            // 
            // cmbExportador
            // 
            this.cmbExportador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExportador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbExportador.FormattingEnabled = true;
            this.cmbExportador.Location = new System.Drawing.Point(136, 40);
            this.cmbExportador.Name = "cmbExportador";
            this.cmbExportador.Size = new System.Drawing.Size(192, 28);
            this.cmbExportador.TabIndex = 18;
            this.cmbExportador.SelectedIndexChanged += new System.EventHandler(this.cmbExportador_SelectedIndexChanged);
            // 
            // cmbProductor
            // 
            this.cmbProductor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductor.FormattingEnabled = true;
            this.cmbProductor.Location = new System.Drawing.Point(136, 76);
            this.cmbProductor.Name = "cmbProductor";
            this.cmbProductor.Size = new System.Drawing.Size(192, 28);
            this.cmbProductor.TabIndex = 19;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(392, 198);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(58, 21);
            this.comboBox3.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Productor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Exportador";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(336, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Lote";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(378, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Hora Inicio";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(358, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "Hora Termino";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(364, 178);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 20);
            this.label13.TabIndex = 26;
            this.label13.Text = "Rendimiento";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(347, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 20);
            this.label14.TabIndex = 27;
            this.label14.Text = "Fecha Proceso";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(-1, 153);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 20);
            this.label15.TabIndex = 28;
            this.label15.Text = "Fecha Recepcion";
            // 
            // txtRedimiento
            // 
            this.txtRedimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRedimiento.Location = new System.Drawing.Point(467, 177);
            this.txtRedimiento.Name = "txtRedimiento";
            this.txtRedimiento.Size = new System.Drawing.Size(101, 26);
            this.txtRedimiento.TabIndex = 31;
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicio.Location = new System.Drawing.Point(467, 109);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.ShowUpDown = true;
            this.dtpHoraInicio.Size = new System.Drawing.Size(104, 26);
            this.dtpHoraInicio.TabIndex = 32;
            this.dtpHoraInicio.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtpHoraInicio_MouseDown);
            // 
            // dtpHoraFin
            // 
            this.dtpHoraFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFin.Location = new System.Drawing.Point(467, 143);
            this.dtpHoraFin.Name = "dtpHoraFin";
            this.dtpHoraFin.ShowUpDown = true;
            this.dtpHoraFin.Size = new System.Drawing.Size(104, 26);
            this.dtpHoraFin.TabIndex = 33;
            this.dtpHoraFin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtpHoraFin_MouseDown);
            // 
            // dtpFechaRecepcion
            // 
            this.dtpFechaRecepcion.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaRecepcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaRecepcion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRecepcion.Location = new System.Drawing.Point(136, 149);
            this.dtpFechaRecepcion.Name = "dtpFechaRecepcion";
            this.dtpFechaRecepcion.Size = new System.Drawing.Size(143, 24);
            this.dtpFechaRecepcion.TabIndex = 34;
            this.dtpFechaRecepcion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtpFechaRecepcion_MouseDown);
            // 
            // dtpFechaProceso
            // 
            this.dtpFechaProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaProceso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaProceso.Location = new System.Drawing.Point(467, 49);
            this.dtpFechaProceso.Name = "dtpFechaProceso";
            this.dtpFechaProceso.Size = new System.Drawing.Size(142, 24);
            this.dtpFechaProceso.TabIndex = 35;
            this.dtpFechaProceso.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtpFechaProceso_MouseDown);
            // 
            // cmbLinea
            // 
            this.cmbLinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLinea.FormattingEnabled = true;
            this.cmbLinea.Location = new System.Drawing.Point(467, 78);
            this.cmbLinea.Name = "cmbLinea";
            this.cmbLinea.Size = new System.Drawing.Size(161, 26);
            this.cmbLinea.TabIndex = 36;
            // 
            // Maquila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 513);
            this.Controls.Add(this.cmbLinea);
            this.Controls.Add(this.dtpFechaProceso);
            this.Controls.Add(this.dtpFechaRecepcion);
            this.Controls.Add(this.dtpHoraFin);
            this.Controls.Add(this.dtpHoraInicio);
            this.Controls.Add(this.txtRedimiento);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.cmbProductor);
            this.Controls.Add(this.cmbExportador);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOrdenEmbalaje);
            this.Controls.Add(this.txtGuia);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Name = "Maquila";
            this.Text = "Proceso Maquila";
            this.Load += new System.EventHandler(this.Maquila_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRecepcion)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelErrorRecepcion.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panelErrorExportacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaExportacion)).EndInit();
            this.panelErrorComercial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaComercial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaRecepcion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtGuia;
        private System.Windows.Forms.TextBox txtOrdenEmbalaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPalletRecepcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panelErrorRecepcion;
        private System.Windows.Forms.Label lblMensajeRecepcion;
        private System.Windows.Forms.Button btnBorrarRecepcion;
        private System.Windows.Forms.Button btnAgregarRecepcion;
        private System.Windows.Forms.ComboBox cmbExportador;
        private System.Windows.Forms.ComboBox cmbProductor;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnBorrarExportacion;
        private System.Windows.Forms.Button btnAgregarExportacion;
        private System.Windows.Forms.Panel panelErrorExportacion;
        private System.Windows.Forms.Label lblMensajeExportacion;
        private System.Windows.Forms.DataGridView dgvListaExportacion;
        private System.Windows.Forms.TextBox txtPalletExportacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelErrorComercial;
        private System.Windows.Forms.Label lblMensajeComercial;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPalletComercial;
        private System.Windows.Forms.DataGridView dgvListaComercial;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtRedimiento;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.DateTimePicker dtpHoraFin;
        private System.Windows.Forms.DateTimePicker dtpFechaRecepcion;
        private System.Windows.Forms.DateTimePicker dtpFechaProceso;
        private System.Windows.Forms.ComboBox cmbLinea;
        private System.Windows.Forms.Label lblKilosRecepcion;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblPesoTeorico;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblKilosSalidaComercial;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblKilosSalidaMerma;
        private System.Windows.Forms.Label label20;
    }
}