namespace Packing
{
    partial class frmLista
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
            this.panelCampos = new System.Windows.Forms.GroupBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblTipoAccion = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbTipoPallet = new System.Windows.Forms.ComboBox();
            this.txtCantidadBandejas = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtKilos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbBandeja = new System.Windows.Forms.ComboBox();
            this.dgvLista1 = new System.Windows.Forms.DataGridView();
            this.panelCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(101, 12);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(903, 12);
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(15, 12);
            // 
            // panelCampos
            // 
            this.panelCampos.Controls.Add(this.lblID);
            this.panelCampos.Controls.Add(this.lblTipoAccion);
            this.panelCampos.Controls.Add(this.btnCancelar);
            this.panelCampos.Controls.Add(this.btnAceptar);
            this.panelCampos.Controls.Add(this.label12);
            this.panelCampos.Controls.Add(this.cmbTipoPallet);
            this.panelCampos.Controls.Add(this.txtCantidadBandejas);
            this.panelCampos.Controls.Add(this.label11);
            this.panelCampos.Controls.Add(this.txtKilos);
            this.panelCampos.Controls.Add(this.label5);
            this.panelCampos.Controls.Add(this.label8);
            this.panelCampos.Controls.Add(this.cmbBandeja);
            this.panelCampos.Location = new System.Drawing.Point(983, 12);
            this.panelCampos.Name = "panelCampos";
            this.panelCampos.Size = new System.Drawing.Size(885, 91);
            this.panelCampos.TabIndex = 29;
            this.panelCampos.TabStop = false;
            this.panelCampos.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(93, 84);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(28, 13);
            this.lblID.TabIndex = 74;
            this.lblID.Text = "lblID";
            this.lblID.Visible = false;
            // 
            // lblTipoAccion
            // 
            this.lblTipoAccion.AutoSize = true;
            this.lblTipoAccion.Location = new System.Drawing.Point(16, 84);
            this.lblTipoAccion.Name = "lblTipoAccion";
            this.lblTipoAccion.Size = new System.Drawing.Size(71, 13);
            this.lblTipoAccion.TabIndex = 73;
            this.lblTipoAccion.Text = "lblTipoAccion";
            this.lblTipoAccion.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(797, 53);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 25);
            this.btnCancelar.TabIndex = 72;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(795, 20);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(84, 25);
            this.btnAceptar.TabIndex = 71;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(384, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 20);
            this.label12.TabIndex = 58;
            this.label12.Text = "Tipo Pallet";
            // 
            // cmbTipoPallet
            // 
            this.cmbTipoPallet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoPallet.FormattingEnabled = true;
            this.cmbTipoPallet.Location = new System.Drawing.Point(472, 18);
            this.cmbTipoPallet.Name = "cmbTipoPallet";
            this.cmbTipoPallet.Size = new System.Drawing.Size(283, 28);
            this.cmbTipoPallet.TabIndex = 9;
            // 
            // txtCantidadBandejas
            // 
            this.txtCantidadBandejas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadBandejas.Location = new System.Drawing.Point(388, 53);
            this.txtCantidadBandejas.MaxLength = 4;
            this.txtCantidadBandejas.Name = "txtCantidadBandejas";
            this.txtCantidadBandejas.Size = new System.Drawing.Size(140, 26);
            this.txtCantidadBandejas.TabIndex = 11;
            this.txtCantidadBandejas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadBandejas_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(243, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 20);
            this.label11.TabIndex = 55;
            this.label11.Text = "Cantidad Bandejas";
            // 
            // txtKilos
            // 
            this.txtKilos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKilos.Location = new System.Drawing.Point(105, 53);
            this.txtKilos.MaxLength = 10;
            this.txtKilos.Name = "txtKilos";
            this.txtKilos.Size = new System.Drawing.Size(132, 26);
            this.txtKilos.TabIndex = 10;
            this.txtKilos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKilos_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 53;
            this.label5.Text = "Kilos Brutos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 48;
            this.label8.Text = "Bandeja";
            // 
            // cmbBandeja
            // 
            this.cmbBandeja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBandeja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBandeja.FormattingEnabled = true;
            this.cmbBandeja.Location = new System.Drawing.Point(79, 15);
            this.cmbBandeja.Name = "cmbBandeja";
            this.cmbBandeja.Size = new System.Drawing.Size(283, 28);
            this.cmbBandeja.TabIndex = 8;
            // 
            // dgvLista1
            // 
            this.dgvLista1.AllowUserToAddRows = false;
            this.dgvLista1.AllowUserToDeleteRows = false;
            this.dgvLista1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLista1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLista1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista1.Location = new System.Drawing.Point(12, 94);
            this.dgvLista1.Name = "dgvLista1";
            this.dgvLista1.ReadOnly = true;
            this.dgvLista1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista1.Size = new System.Drawing.Size(964, 347);
            this.dgvLista1.TabIndex = 30;
            this.dgvLista1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista1_CellClick);
            // 
            // frmLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 457);
            this.Controls.Add(this.dgvLista1);
            this.Controls.Add(this.panelCampos);
            this.Name = "frmLista";
            this.Text = "frmLista";
            this.Load += new System.EventHandler(this.frmLista_Load);
            this.Controls.SetChildIndex(this.btnModificar, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnAgregar, 0);
            this.Controls.SetChildIndex(this.btnImportar, 0);
            this.Controls.SetChildIndex(this.panelCampos, 0);
            this.Controls.SetChildIndex(this.dgvLista1, 0);
            this.panelCampos.ResumeLayout(false);
            this.panelCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox panelCampos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbTipoPallet;
        private System.Windows.Forms.TextBox txtCantidadBandejas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtKilos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbBandeja;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblTipoAccion;
        private System.Windows.Forms.DataGridView dgvLista1;
    }
}