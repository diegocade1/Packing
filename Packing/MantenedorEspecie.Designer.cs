namespace Packing
{
    partial class MantenedorEspecie
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
            this.lblIDEspecie = new System.Windows.Forms.Label();
            this.lblTipoAccion = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.panelCampos.Controls.Add(this.lblIDEspecie);
            this.panelCampos.Controls.Add(this.lblTipoAccion);
            this.panelCampos.Controls.Add(this.btnCancelar);
            this.panelCampos.Controls.Add(this.btnAceptar);
            this.panelCampos.Controls.Add(this.txtDescripcion);
            this.panelCampos.Controls.Add(this.label2);
            this.panelCampos.Location = new System.Drawing.Point(684, 4);
            this.panelCampos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCampos.Name = "panelCampos";
            this.panelCampos.Size = new System.Drawing.Size(564, 91);
            this.panelCampos.TabIndex = 30;
            this.panelCampos.Visible = false;
            // 
            // lblIDEspecie
            // 
            this.lblIDEspecie.AutoSize = true;
            this.lblIDEspecie.Location = new System.Drawing.Point(107, 48);
            this.lblIDEspecie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDEspecie.Name = "lblIDEspecie";
            this.lblIDEspecie.Size = new System.Drawing.Size(85, 17);
            this.lblIDEspecie.TabIndex = 7;
            this.lblIDEspecie.Text = "lblIDEspecie";
            this.lblIDEspecie.Visible = false;
            // 
            // lblTipoAccion
            // 
            this.lblTipoAccion.AutoSize = true;
            this.lblTipoAccion.Location = new System.Drawing.Point(4, 48);
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
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(112, 31);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(152, 15);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(227, 22);
            this.txtDescripcion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // MantenedorEspecie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 554);
            this.Controls.Add(this.panelCampos);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "MantenedorEspecie";
            this.Text = "MantenedorEspecie";
            this.Load += new System.EventHandler(this.MantenedorEspecie_Load);
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
        private System.Windows.Forms.Label lblIDEspecie;
        private System.Windows.Forms.Label lblTipoAccion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
    }
}