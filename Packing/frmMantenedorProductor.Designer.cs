namespace Packing
{
    partial class frmMantenedorProductor
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
            this.panelCampos = new System.Windows.Forms.Panel();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblIDProductor = new System.Windows.Forms.Label();
            this.lblTipoAccion = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtDescripcionProductor = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtCodigoProductor = new System.Windows.Forms.TextBox();
            this.lblCodigoProductor = new System.Windows.Forms.Label();
            this.panelCampos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(730, 18);
            // 
            // panelCampos
            // 
            this.panelCampos.Controls.Add(this.txtCodigoProductor);
            this.panelCampos.Controls.Add(this.lblCodigoProductor);
            this.panelCampos.Controls.Add(this.cbCliente);
            this.panelCampos.Controls.Add(this.lblCliente);
            this.panelCampos.Controls.Add(this.lblIDProductor);
            this.panelCampos.Controls.Add(this.lblTipoAccion);
            this.panelCampos.Controls.Add(this.btnCancelar);
            this.panelCampos.Controls.Add(this.btnAceptar);
            this.panelCampos.Controls.Add(this.txtDescripcionProductor);
            this.panelCampos.Controls.Add(this.lblDescripcion);
            this.panelCampos.Location = new System.Drawing.Point(735, 94);
            this.panelCampos.Name = "panelCampos";
            this.panelCampos.Size = new System.Drawing.Size(700, 84);
            this.panelCampos.TabIndex = 32;
            this.panelCampos.Visible = false;
            // 
            // cbCliente
            // 
            this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(128, 40);
            this.cbCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(171, 21);
            this.cbCliente.TabIndex = 12;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(82, 42);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 10;
            this.lblCliente.Text = "Cliente";
            // 
            // lblIDProductor
            // 
            this.lblIDProductor.AutoSize = true;
            this.lblIDProductor.Location = new System.Drawing.Point(86, 63);
            this.lblIDProductor.Name = "lblIDProductor";
            this.lblIDProductor.Size = new System.Drawing.Size(74, 13);
            this.lblIDProductor.TabIndex = 7;
            this.lblIDProductor.Text = "lblIDProductor";
            this.lblIDProductor.Visible = false;
            // 
            // lblTipoAccion
            // 
            this.lblTipoAccion.AutoSize = true;
            this.lblTipoAccion.Location = new System.Drawing.Point(9, 63);
            this.lblTipoAccion.Name = "lblTipoAccion";
            this.lblTipoAccion.Size = new System.Drawing.Size(71, 13);
            this.lblTipoAccion.TabIndex = 6;
            this.lblTipoAccion.Text = "lblTipoAccion";
            this.lblTipoAccion.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(589, 42);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 27);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(589, 11);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(84, 25);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtDescripcionProductor
            // 
            this.txtDescripcionProductor.Location = new System.Drawing.Point(128, 11);
            this.txtDescripcionProductor.Name = "txtDescripcionProductor";
            this.txtDescripcionProductor.Size = new System.Drawing.Size(171, 20);
            this.txtDescripcionProductor.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(9, 11);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(112, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcion Productor";
            // 
            // txtCodigoProductor
            // 
            this.txtCodigoProductor.Location = new System.Drawing.Point(400, 11);
            this.txtCodigoProductor.Name = "txtCodigoProductor";
            this.txtCodigoProductor.Size = new System.Drawing.Size(171, 20);
            this.txtCodigoProductor.TabIndex = 14;
            // 
            // lblCodigoProductor
            // 
            this.lblCodigoProductor.AutoSize = true;
            this.lblCodigoProductor.Location = new System.Drawing.Point(305, 14);
            this.lblCodigoProductor.Name = "lblCodigoProductor";
            this.lblCodigoProductor.Size = new System.Drawing.Size(89, 13);
            this.lblCodigoProductor.TabIndex = 13;
            this.lblCodigoProductor.Text = "Codigo Productor";
            // 
            // frmMantenedorProductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 459);
            this.Controls.Add(this.panelCampos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMantenedorProductor";
            this.Text = "frmMantenedorProductor";
            this.Load += new System.EventHandler(this.frmMantenedorProductor_Load);
            this.Controls.SetChildIndex(this.btnModificar, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnAgregar, 0);
            this.Controls.SetChildIndex(this.btnImportar, 0);
            this.Controls.SetChildIndex(this.panelCampos, 0);
            this.panelCampos.ResumeLayout(false);
            this.panelCampos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCampos;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblIDProductor;
        private System.Windows.Forms.Label lblTipoAccion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtDescripcionProductor;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtCodigoProductor;
        private System.Windows.Forms.Label lblCodigoProductor;
    }
}