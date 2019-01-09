namespace Packing
{
    partial class frmMantenedorEtiqueta
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
            this.cbEspecie = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.lblIDEtiqueta = new System.Windows.Forms.Label();
            this.lblTipoAccion = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtDescripcionEtiqueta = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.panelCampos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImportar
            // 
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(910, 15);
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // panelCampos
            // 
            this.panelCampos.Controls.Add(this.cbCliente);
            this.panelCampos.Controls.Add(this.cbEspecie);
            this.panelCampos.Controls.Add(this.lblCliente);
            this.panelCampos.Controls.Add(this.lblEspecie);
            this.panelCampos.Controls.Add(this.lblIDEtiqueta);
            this.panelCampos.Controls.Add(this.lblTipoAccion);
            this.panelCampos.Controls.Add(this.btnCancelar);
            this.panelCampos.Controls.Add(this.btnAceptar);
            this.panelCampos.Controls.Add(this.txtDescripcionEtiqueta);
            this.panelCampos.Controls.Add(this.lblDescripcion);
            this.panelCampos.Location = new System.Drawing.Point(727, 144);
            this.panelCampos.Margin = new System.Windows.Forms.Padding(4);
            this.panelCampos.Name = "panelCampos";
            this.panelCampos.Size = new System.Drawing.Size(862, 104);
            this.panelCampos.TabIndex = 31;
            this.panelCampos.Visible = false;
            // 
            // cbCliente
            // 
            this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(484, 11);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(227, 24);
            this.cbCliente.TabIndex = 12;
            // 
            // cbEspecie
            // 
            this.cbEspecie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEspecie.FormattingEnabled = true;
            this.cbEspecie.Location = new System.Drawing.Point(170, 52);
            this.cbEspecie.Name = "cbEspecie";
            this.cbEspecie.Size = new System.Drawing.Size(227, 24);
            this.cbEspecie.TabIndex = 11;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(426, 14);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(51, 17);
            this.lblCliente.TabIndex = 10;
            this.lblCliente.Text = "Cliente";
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Location = new System.Drawing.Point(92, 52);
            this.lblEspecie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(58, 17);
            this.lblEspecie.TabIndex = 8;
            this.lblEspecie.Text = "Especie";
            // 
            // lblIDEtiqueta
            // 
            this.lblIDEtiqueta.AutoSize = true;
            this.lblIDEtiqueta.Location = new System.Drawing.Point(115, 78);
            this.lblIDEtiqueta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDEtiqueta.Name = "lblIDEtiqueta";
            this.lblIDEtiqueta.Size = new System.Drawing.Size(87, 17);
            this.lblIDEtiqueta.TabIndex = 7;
            this.lblIDEtiqueta.Text = "lblIDEtiqueta";
            this.lblIDEtiqueta.Visible = false;
            // 
            // lblTipoAccion
            // 
            this.lblTipoAccion.AutoSize = true;
            this.lblTipoAccion.Location = new System.Drawing.Point(12, 78);
            this.lblTipoAccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoAccion.Name = "lblTipoAccion";
            this.lblTipoAccion.Size = new System.Drawing.Size(92, 17);
            this.lblTipoAccion.TabIndex = 6;
            this.lblTipoAccion.Text = "lblTipoAccion";
            this.lblTipoAccion.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(725, 52);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 33);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(725, 13);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(112, 31);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtDescripcionEtiqueta
            // 
            this.txtDescripcionEtiqueta.Location = new System.Drawing.Point(170, 14);
            this.txtDescripcionEtiqueta.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcionEtiqueta.Name = "txtDescripcionEtiqueta";
            this.txtDescripcionEtiqueta.Size = new System.Drawing.Size(227, 22);
            this.txtDescripcionEtiqueta.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(12, 14);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(138, 17);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcion Etiqueta";
            // 
            // frmMantenedorEtiqueta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 566);
            this.Controls.Add(this.panelCampos);
            this.Name = "frmMantenedorEtiqueta";
            this.Text = "frmMantenedorEtiqueta";
            this.Load += new System.EventHandler(this.frmMantenedorEtiqueta_Load);
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
        private System.Windows.Forms.Label lblIDEtiqueta;
        private System.Windows.Forms.Label lblTipoAccion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtDescripcionEtiqueta;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.ComboBox cbEspecie;
    }
}