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
            this.panelCampos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCampos
            // 
            this.panelCampos.Controls.Add(this.cbCliente);
            this.panelCampos.Controls.Add(this.lblCliente);
            this.panelCampos.Controls.Add(this.lblIDProductor);
            this.panelCampos.Controls.Add(this.lblTipoAccion);
            this.panelCampos.Controls.Add(this.btnCancelar);
            this.panelCampos.Controls.Add(this.btnAceptar);
            this.panelCampos.Controls.Add(this.txtDescripcionProductor);
            this.panelCampos.Controls.Add(this.lblDescripcion);
            this.panelCampos.Location = new System.Drawing.Point(684, 4);
            this.panelCampos.Margin = new System.Windows.Forms.Padding(4);
            this.panelCampos.Name = "panelCampos";
            this.panelCampos.Size = new System.Drawing.Size(687, 104);
            this.panelCampos.TabIndex = 32;
            this.panelCampos.Visible = false;
            // 
            // cbCliente
            // 
            this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(170, 49);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(227, 24);
            this.cbCliente.TabIndex = 12;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(109, 52);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(51, 17);
            this.lblCliente.TabIndex = 10;
            this.lblCliente.Text = "Cliente";
            // 
            // lblIDProductor
            // 
            this.lblIDProductor.AutoSize = true;
            this.lblIDProductor.Location = new System.Drawing.Point(115, 78);
            this.lblIDProductor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDProductor.Name = "lblIDProductor";
            this.lblIDProductor.Size = new System.Drawing.Size(97, 17);
            this.lblIDProductor.TabIndex = 7;
            this.lblIDProductor.Text = "lblIDProductor";
            this.lblIDProductor.Visible = false;
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
            this.btnCancelar.Location = new System.Drawing.Point(492, 52);
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
            this.btnAceptar.Location = new System.Drawing.Point(492, 13);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(112, 31);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtDescripcionProductor
            // 
            this.txtDescripcionProductor.Location = new System.Drawing.Point(170, 14);
            this.txtDescripcionProductor.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcionProductor.Name = "txtDescripcionProductor";
            this.txtDescripcionProductor.Size = new System.Drawing.Size(227, 22);
            this.txtDescripcionProductor.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(12, 14);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(148, 17);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcion Productor";
            // 
            // frmMantenedorProductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.panelCampos);
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
    }
}