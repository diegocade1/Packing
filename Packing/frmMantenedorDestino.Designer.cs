namespace Packing
{
    partial class frmMantenedorDestino
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
            this.lblIDDestino = new System.Windows.Forms.Label();
            this.lblTipoAccion = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtDescripcionDestino = new System.Windows.Forms.TextBox();
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
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // panelCampos
            // 
            this.panelCampos.Controls.Add(this.lblIDDestino);
            this.panelCampos.Controls.Add(this.lblTipoAccion);
            this.panelCampos.Controls.Add(this.btnCancelar);
            this.panelCampos.Controls.Add(this.btnAceptar);
            this.panelCampos.Controls.Add(this.txtDescripcionDestino);
            this.panelCampos.Controls.Add(this.lblDescripcion);
            this.panelCampos.Location = new System.Drawing.Point(684, 13);
            this.panelCampos.Margin = new System.Windows.Forms.Padding(4);
            this.panelCampos.Name = "panelCampos";
            this.panelCampos.Size = new System.Drawing.Size(564, 91);
            this.panelCampos.TabIndex = 31;
            this.panelCampos.Visible = false;
            // 
            // lblIDDestino
            // 
            this.lblIDDestino.AutoSize = true;
            this.lblIDDestino.Location = new System.Drawing.Point(115, 69);
            this.lblIDDestino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDDestino.Name = "lblIDDestino";
            this.lblIDDestino.Size = new System.Drawing.Size(83, 17);
            this.lblIDDestino.TabIndex = 7;
            this.lblIDDestino.Text = "lblIDDestino";
            this.lblIDDestino.Visible = false;
            // 
            // lblTipoAccion
            // 
            this.lblTipoAccion.AutoSize = true;
            this.lblTipoAccion.Location = new System.Drawing.Point(12, 69);
            this.lblTipoAccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoAccion.Name = "lblTipoAccion";
            this.lblTipoAccion.Size = new System.Drawing.Size(92, 17);
            this.lblTipoAccion.TabIndex = 6;
            this.lblTipoAccion.Text = "lblTipoAccion";
            this.lblTipoAccion.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(435, 48);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 31);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(432, 7);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(112, 31);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtDescripcionDestino
            // 
            this.txtDescripcionDestino.Location = new System.Drawing.Point(170, 21);
            this.txtDescripcionDestino.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcionDestino.Name = "txtDescripcionDestino";
            this.txtDescripcionDestino.Size = new System.Drawing.Size(227, 22);
            this.txtDescripcionDestino.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(12, 21);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(134, 17);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcion Destino";
            // 
            // frmMantenedorDestino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 567);
            this.Controls.Add(this.panelCampos);
            this.Name = "frmMantenedorDestino";
            this.Text = "frmMantenedorDestino";
            this.Load += new System.EventHandler(this.frmMantenedorDestino_Load);
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
        private System.Windows.Forms.Label lblIDDestino;
        private System.Windows.Forms.Label lblTipoAccion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtDescripcionDestino;
        private System.Windows.Forms.Label lblDescripcion;
    }
}