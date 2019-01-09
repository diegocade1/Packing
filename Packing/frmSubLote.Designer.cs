namespace Packing
{
    partial class frmSubLote
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFolioNuevo = new System.Windows.Forms.TextBox();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.lblExportador = new System.Windows.Forms.Label();
            this.lblProductor = new System.Windows.Forms.Label();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDescarga = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblGuia = new System.Windows.Forms.Label();
            this.txtKilos = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(274, 417);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(128, 31);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(56, 417);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(128, 31);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Folio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Exportador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Productor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 316);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nuevo Folio";
            // 
            // txtFolioNuevo
            // 
            this.txtFolioNuevo.Location = new System.Drawing.Point(115, 313);
            this.txtFolioNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.txtFolioNuevo.Name = "txtFolioNuevo";
            this.txtFolioNuevo.Size = new System.Drawing.Size(212, 25);
            this.txtFolioNuevo.TabIndex = 1;
            // 
            // txtFolio
            // 
            this.txtFolio.Location = new System.Drawing.Point(116, 34);
            this.txtFolio.Margin = new System.Windows.Forms.Padding(4);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(241, 25);
            this.txtFolio.TabIndex = 0;
            this.txtFolio.TextChanged += new System.EventHandler(this.txtFolio_TextChanged);
            this.txtFolio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFolio_KeyPress);
            // 
            // lblExportador
            // 
            this.lblExportador.BackColor = System.Drawing.Color.White;
            this.lblExportador.Location = new System.Drawing.Point(112, 75);
            this.lblExportador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExportador.Name = "lblExportador";
            this.lblExportador.Size = new System.Drawing.Size(284, 27);
            this.lblExportador.TabIndex = 8;
            // 
            // lblProductor
            // 
            this.lblProductor.BackColor = System.Drawing.Color.White;
            this.lblProductor.Location = new System.Drawing.Point(112, 112);
            this.lblProductor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductor.Name = "lblProductor";
            this.lblProductor.Size = new System.Drawing.Size(284, 27);
            this.lblProductor.TabIndex = 9;
            // 
            // lblEspecie
            // 
            this.lblEspecie.BackColor = System.Drawing.Color.White;
            this.lblEspecie.Location = new System.Drawing.Point(112, 147);
            this.lblEspecie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(284, 27);
            this.lblEspecie.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 147);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Especie";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 182);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Descarga";
            // 
            // lblDescarga
            // 
            this.lblDescarga.BackColor = System.Drawing.Color.White;
            this.lblDescarga.Location = new System.Drawing.Point(112, 182);
            this.lblDescarga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescarga.Name = "lblDescarga";
            this.lblDescarga.Size = new System.Drawing.Size(284, 27);
            this.lblDescarga.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 217);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "Destino";
            // 
            // lblDestino
            // 
            this.lblDestino.BackColor = System.Drawing.Color.White;
            this.lblDestino.Location = new System.Drawing.Point(112, 217);
            this.lblDestino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(284, 27);
            this.lblDestino.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(53, 253);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 17);
            this.label13.TabIndex = 16;
            this.label13.Text = "Guia";
            // 
            // lblGuia
            // 
            this.lblGuia.BackColor = System.Drawing.Color.White;
            this.lblGuia.Location = new System.Drawing.Point(112, 253);
            this.lblGuia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGuia.Name = "lblGuia";
            this.lblGuia.Size = new System.Drawing.Size(284, 27);
            this.lblGuia.TabIndex = 17;
            // 
            // txtKilos
            // 
            this.txtKilos.Location = new System.Drawing.Point(115, 355);
            this.txtKilos.Margin = new System.Windows.Forms.Padding(4);
            this.txtKilos.Name = "txtKilos";
            this.txtKilos.Size = new System.Drawing.Size(151, 25);
            this.txtKilos.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 363);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 17);
            this.label15.TabIndex = 19;
            this.label15.Text = "Kilos Brutos";
            // 
            // frmSubLote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 483);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtKilos);
            this.Controls.Add(this.lblGuia);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblDescarga);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblEspecie);
            this.Controls.Add(this.lblProductor);
            this.Controls.Add(this.lblExportador);
            this.Controls.Add(this.txtFolio);
            this.Controls.Add(this.txtFolioNuevo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSubLote";
            this.Text = "SubLote";
            this.Load += new System.EventHandler(this.frmSubLote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFolioNuevo;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.Label lblExportador;
        private System.Windows.Forms.Label lblProductor;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDescarga;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblGuia;
        private System.Windows.Forms.TextBox txtKilos;
        private System.Windows.Forms.Label label15;
    }
}