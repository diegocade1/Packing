namespace Packing
{
    partial class frmImpresora
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
            this.lblImpresora = new System.Windows.Forms.Label();
            this.txtImpresora = new System.Windows.Forms.TextBox();
            this.pdSeleccionImpresora = new System.Windows.Forms.PrintDialog();
            this.btnCambiarImpresora = new System.Windows.Forms.Button();
            this.gbCambiar = new System.Windows.Forms.GroupBox();
            this.lblImpresoras = new System.Windows.Forms.Label();
            this.cbImpresoras = new System.Windows.Forms.ComboBox();
            this.gbCambiar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblImpresora
            // 
            this.lblImpresora.AutoSize = true;
            this.lblImpresora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpresora.Location = new System.Drawing.Point(59, 54);
            this.lblImpresora.Name = "lblImpresora";
            this.lblImpresora.Size = new System.Drawing.Size(149, 24);
            this.lblImpresora.TabIndex = 0;
            this.lblImpresora.Text = "Predeterminada:";
            // 
            // txtImpresora
            // 
            this.txtImpresora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpresora.Location = new System.Drawing.Point(214, 55);
            this.txtImpresora.Name = "txtImpresora";
            this.txtImpresora.ReadOnly = true;
            this.txtImpresora.Size = new System.Drawing.Size(299, 24);
            this.txtImpresora.TabIndex = 1;
            // 
            // pdSeleccionImpresora
            // 
            this.pdSeleccionImpresora.UseEXDialog = true;
            // 
            // btnCambiarImpresora
            // 
            this.btnCambiarImpresora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarImpresora.Location = new System.Drawing.Point(176, 65);
            this.btnCambiarImpresora.Name = "btnCambiarImpresora";
            this.btnCambiarImpresora.Size = new System.Drawing.Size(88, 29);
            this.btnCambiarImpresora.TabIndex = 2;
            this.btnCambiarImpresora.Text = "Cambiar";
            this.btnCambiarImpresora.UseVisualStyleBackColor = true;
            this.btnCambiarImpresora.Click += new System.EventHandler(this.btnCambiarImpresora_Click);
            // 
            // gbCambiar
            // 
            this.gbCambiar.Controls.Add(this.cbImpresoras);
            this.gbCambiar.Controls.Add(this.lblImpresoras);
            this.gbCambiar.Controls.Add(this.btnCambiarImpresora);
            this.gbCambiar.Location = new System.Drawing.Point(63, 109);
            this.gbCambiar.Name = "gbCambiar";
            this.gbCambiar.Size = new System.Drawing.Size(450, 100);
            this.gbCambiar.TabIndex = 3;
            this.gbCambiar.TabStop = false;
            // 
            // lblImpresoras
            // 
            this.lblImpresoras.AutoSize = true;
            this.lblImpresoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpresoras.Location = new System.Drawing.Point(67, 16);
            this.lblImpresoras.Name = "lblImpresoras";
            this.lblImpresoras.Size = new System.Drawing.Size(82, 17);
            this.lblImpresoras.TabIndex = 3;
            this.lblImpresoras.Text = "Impresoras:";
            // 
            // cbImpresoras
            // 
            this.cbImpresoras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbImpresoras.FormattingEnabled = true;
            this.cbImpresoras.Location = new System.Drawing.Point(151, 13);
            this.cbImpresoras.Name = "cbImpresoras";
            this.cbImpresoras.Size = new System.Drawing.Size(211, 21);
            this.cbImpresoras.TabIndex = 4;
            // 
            // frmImpresora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 231);
            this.Controls.Add(this.gbCambiar);
            this.Controls.Add(this.txtImpresora);
            this.Controls.Add(this.lblImpresora);
            this.Name = "frmImpresora";
            this.Text = "Configuraciones de Impresora";
            this.Load += new System.EventHandler(this.frmImpresora_Load);
            this.gbCambiar.ResumeLayout(false);
            this.gbCambiar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImpresora;
        private System.Windows.Forms.TextBox txtImpresora;
        private System.Windows.Forms.PrintDialog pdSeleccionImpresora;
        private System.Windows.Forms.Button btnCambiarImpresora;
        private System.Windows.Forms.GroupBox gbCambiar;
        private System.Windows.Forms.ComboBox cbImpresoras;
        private System.Windows.Forms.Label lblImpresoras;
    }
}