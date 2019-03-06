namespace Packing
{
    partial class MDIContenedorPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuControl = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.printItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBarItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VerticalItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HorizontalItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenedorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especieItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoComerItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoUsuarioItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productorItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mantRecepItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descargaItem = new System.Windows.Forms.ToolStripMenuItem();
            this.destinoItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bandejasItem = new System.Windows.Forms.ToolStripMenuItem();
            this.palletsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoRecepItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantExporItem = new System.Windows.Forms.ToolStripMenuItem();
            this.embalajeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etiquetasItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mercadoItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoArmadItem = new System.Windows.Forms.ToolStripMenuItem();
            this.variedadItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.recepcionItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportaItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maquilaItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subloteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolControl = new System.Windows.Forms.ToolStrip();
            this.RecepTool = new System.Windows.Forms.ToolStripLabel();
            this.ExportTool = new System.Windows.Forms.ToolStripLabel();
            this.ComercTool = new System.Windows.Forms.ToolStripLabel();
            this.MaquilaTool = new System.Windows.Forms.ToolStripLabel();
            this.statusControl = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.prefijoItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuControl.SuspendLayout();
            this.toolControl.SuspendLayout();
            this.statusControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuControl
            // 
            this.menuControl.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.viewMenu,
            this.windowsMenu,
            this.mantenedorMenu,
            this.procesosMenu});
            this.menuControl.Location = new System.Drawing.Point(0, 0);
            this.menuControl.MdiWindowListItem = this.windowsMenu;
            this.menuControl.Name = "menuControl";
            this.menuControl.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuControl.Size = new System.Drawing.Size(1143, 28);
            this.menuControl.TabIndex = 0;
            this.menuControl.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printItem,
            this.exitItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(71, 24);
            this.fileMenu.Text = "&Archivo";
            // 
            // printItem
            // 
            this.printItem.Name = "printItem";
            this.printItem.Size = new System.Drawing.Size(224, 26);
            this.printItem.Text = "Configurar impresión";
            this.printItem.Click += new System.EventHandler(this.printSetupToolStripMenuItem_Click);
            // 
            // exitItem
            // 
            this.exitItem.Name = "exitItem";
            this.exitItem.Size = new System.Drawing.Size(224, 26);
            this.exitItem.Text = "&Salir";
            this.exitItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBarItem,
            this.statusBarItem});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(42, 24);
            this.viewMenu.Text = "&Ver";
            this.viewMenu.Click += new System.EventHandler(this.viewMenu_Click);
            // 
            // toolBarItem
            // 
            this.toolBarItem.Checked = true;
            this.toolBarItem.CheckOnClick = true;
            this.toolBarItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolBarItem.Name = "toolBarItem";
            this.toolBarItem.Size = new System.Drawing.Size(230, 26);
            this.toolBarItem.Text = "&Barra de herramientas";
            this.toolBarItem.Click += new System.EventHandler(this.ToolBarToolStripMenuItem_Click);
            // 
            // statusBarItem
            // 
            this.statusBarItem.Checked = true;
            this.statusBarItem.CheckOnClick = true;
            this.statusBarItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarItem.Name = "statusBarItem";
            this.statusBarItem.Size = new System.Drawing.Size(230, 26);
            this.statusBarItem.Text = "&Barra de estado";
            this.statusBarItem.Click += new System.EventHandler(this.StatusBarToolStripMenuItem_Click);
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeItem,
            this.VerticalItem,
            this.HorizontalItem,
            this.closeAllItem,
            this.arrangeIconsItem});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(80, 24);
            this.windowsMenu.Text = "&Ventanas";
            this.windowsMenu.Click += new System.EventHandler(this.windowsMenu_Click);
            // 
            // cascadeItem
            // 
            this.cascadeItem.Name = "cascadeItem";
            this.cascadeItem.Size = new System.Drawing.Size(211, 26);
            this.cascadeItem.Text = "&Cascada";
            this.cascadeItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // VerticalItem
            // 
            this.VerticalItem.Name = "VerticalItem";
            this.VerticalItem.Size = new System.Drawing.Size(211, 26);
            this.VerticalItem.Text = "Mosaico &vertical";
            this.VerticalItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // HorizontalItem
            // 
            this.HorizontalItem.Name = "HorizontalItem";
            this.HorizontalItem.Size = new System.Drawing.Size(211, 26);
            this.HorizontalItem.Text = "Mosaico &horizontal";
            this.HorizontalItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // closeAllItem
            // 
            this.closeAllItem.Name = "closeAllItem";
            this.closeAllItem.Size = new System.Drawing.Size(211, 26);
            this.closeAllItem.Text = "C&errar todo";
            this.closeAllItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // arrangeIconsItem
            // 
            this.arrangeIconsItem.Name = "arrangeIconsItem";
            this.arrangeIconsItem.Size = new System.Drawing.Size(211, 26);
            this.arrangeIconsItem.Text = "&Organizar iconos";
            this.arrangeIconsItem.Click += new System.EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
            // 
            // mantenedorMenu
            // 
            this.mantenedorMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteItem,
            this.especieItem,
            this.tipoComerItem,
            this.usuarioItem,
            this.tipoUsuarioItem,
            this.productorItem,
            this.prefijoItem,
            this.toolStripMenuItem1,
            this.mantRecepItem,
            this.mantExporItem});
            this.mantenedorMenu.Name = "mantenedorMenu";
            this.mantenedorMenu.Size = new System.Drawing.Size(102, 24);
            this.mantenedorMenu.Text = "Mantenedor";
            // 
            // clienteItem
            // 
            this.clienteItem.Name = "clienteItem";
            this.clienteItem.Size = new System.Drawing.Size(216, 26);
            this.clienteItem.Text = "Cliente";
            this.clienteItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // especieItem
            // 
            this.especieItem.Name = "especieItem";
            this.especieItem.Size = new System.Drawing.Size(216, 26);
            this.especieItem.Text = "Especie";
            this.especieItem.Click += new System.EventHandler(this.especieToolStripMenuItem_Click);
            // 
            // tipoComerItem
            // 
            this.tipoComerItem.Name = "tipoComerItem";
            this.tipoComerItem.Size = new System.Drawing.Size(216, 26);
            this.tipoComerItem.Text = "Tipo Comercial";
            this.tipoComerItem.Click += new System.EventHandler(this.tipoComercialToolStripMenuItem_Click);
            // 
            // usuarioItem
            // 
            this.usuarioItem.Name = "usuarioItem";
            this.usuarioItem.Size = new System.Drawing.Size(216, 26);
            this.usuarioItem.Text = "Usuario";
            this.usuarioItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // tipoUsuarioItem
            // 
            this.tipoUsuarioItem.Name = "tipoUsuarioItem";
            this.tipoUsuarioItem.Size = new System.Drawing.Size(216, 26);
            this.tipoUsuarioItem.Text = "Tipo de Usuario";
            this.tipoUsuarioItem.Click += new System.EventHandler(this.tipoDeUsuarioToolStripMenuItem_Click);
            // 
            // productorItem
            // 
            this.productorItem.Name = "productorItem";
            this.productorItem.Size = new System.Drawing.Size(216, 26);
            this.productorItem.Text = "Productor";
            this.productorItem.Click += new System.EventHandler(this.productorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(213, 6);
            // 
            // mantRecepItem
            // 
            this.mantRecepItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.descargaItem,
            this.destinoItem,
            this.bandejasItem,
            this.palletsItem,
            this.tipoRecepItem});
            this.mantRecepItem.Name = "mantRecepItem";
            this.mantRecepItem.Size = new System.Drawing.Size(216, 26);
            this.mantRecepItem.Text = "Recepcion";
            // 
            // descargaItem
            // 
            this.descargaItem.Name = "descargaItem";
            this.descargaItem.Size = new System.Drawing.Size(216, 26);
            this.descargaItem.Text = "Descarga";
            this.descargaItem.Click += new System.EventHandler(this.descargaToolStripMenuItem1_Click);
            // 
            // destinoItem
            // 
            this.destinoItem.Name = "destinoItem";
            this.destinoItem.Size = new System.Drawing.Size(216, 26);
            this.destinoItem.Text = "Destino";
            this.destinoItem.Click += new System.EventHandler(this.destinoToolStripMenuItem_Click);
            // 
            // bandejasItem
            // 
            this.bandejasItem.Name = "bandejasItem";
            this.bandejasItem.Size = new System.Drawing.Size(216, 26);
            this.bandejasItem.Text = "Bandejas";
            this.bandejasItem.Click += new System.EventHandler(this.bandejasToolStripMenuItem_Click);
            // 
            // palletsItem
            // 
            this.palletsItem.Name = "palletsItem";
            this.palletsItem.Size = new System.Drawing.Size(216, 26);
            this.palletsItem.Text = "Pallets";
            this.palletsItem.Click += new System.EventHandler(this.palletsToolStripMenuItem_Click);
            // 
            // tipoRecepItem
            // 
            this.tipoRecepItem.Name = "tipoRecepItem";
            this.tipoRecepItem.Size = new System.Drawing.Size(216, 26);
            this.tipoRecepItem.Text = "Tipo de Recepcion";
            this.tipoRecepItem.Click += new System.EventHandler(this.tipoDeRecepcionToolStripMenuItem_Click);
            // 
            // mantExporItem
            // 
            this.mantExporItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.embalajeItem,
            this.etiquetasItem,
            this.mercadoItem,
            this.tipoArmadItem,
            this.variedadItem});
            this.mantExporItem.Name = "mantExporItem";
            this.mantExporItem.Size = new System.Drawing.Size(216, 26);
            this.mantExporItem.Text = "Exportacion";
            // 
            // embalajeItem
            // 
            this.embalajeItem.Name = "embalajeItem";
            this.embalajeItem.Size = new System.Drawing.Size(216, 26);
            this.embalajeItem.Text = "Embalaje";
            this.embalajeItem.Click += new System.EventHandler(this.cajasToolStripMenuItem_Click);
            // 
            // etiquetasItem
            // 
            this.etiquetasItem.Name = "etiquetasItem";
            this.etiquetasItem.Size = new System.Drawing.Size(216, 26);
            this.etiquetasItem.Text = "Etiquetas";
            this.etiquetasItem.Click += new System.EventHandler(this.etiquetasToolStripMenuItem_Click);
            // 
            // mercadoItem
            // 
            this.mercadoItem.Name = "mercadoItem";
            this.mercadoItem.Size = new System.Drawing.Size(216, 26);
            this.mercadoItem.Text = "Tipo de Mercado";
            this.mercadoItem.Click += new System.EventHandler(this.mercadoToolStripMenuItem_Click);
            // 
            // tipoArmadItem
            // 
            this.tipoArmadItem.Name = "tipoArmadItem";
            this.tipoArmadItem.Size = new System.Drawing.Size(216, 26);
            this.tipoArmadItem.Text = "Tipo de Armado";
            this.tipoArmadItem.Click += new System.EventHandler(this.tipoDeArmadoToolStripMenuItem_Click);
            // 
            // variedadItem
            // 
            this.variedadItem.Name = "variedadItem";
            this.variedadItem.Size = new System.Drawing.Size(216, 26);
            this.variedadItem.Text = "Variedad";
            this.variedadItem.Click += new System.EventHandler(this.variedadToolStripMenuItem_Click);
            // 
            // procesosMenu
            // 
            this.procesosMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recepcionItem,
            this.exportaItem,
            this.maquilaItem,
            this.subloteItem});
            this.procesosMenu.Name = "procesosMenu";
            this.procesosMenu.Size = new System.Drawing.Size(79, 24);
            this.procesosMenu.Text = "Procesos";
            this.procesosMenu.Click += new System.EventHandler(this.procesosToolStripMenuItem_Click);
            // 
            // recepcionItem
            // 
            this.recepcionItem.Name = "recepcionItem";
            this.recepcionItem.Size = new System.Drawing.Size(216, 26);
            this.recepcionItem.Text = "Recepcion";
            this.recepcionItem.Click += new System.EventHandler(this.recepcionToolStripMenuItem_Click);
            // 
            // exportaItem
            // 
            this.exportaItem.Name = "exportaItem";
            this.exportaItem.Size = new System.Drawing.Size(216, 26);
            this.exportaItem.Text = "Exportacion";
            this.exportaItem.Click += new System.EventHandler(this.exportacionToolStripMenuItem_Click);
            // 
            // maquilaItem
            // 
            this.maquilaItem.Name = "maquilaItem";
            this.maquilaItem.Size = new System.Drawing.Size(216, 26);
            this.maquilaItem.Text = "Proceso";
            this.maquilaItem.Click += new System.EventHandler(this.maquilaToolStripMenuItem_Click);
            // 
            // subloteItem
            // 
            this.subloteItem.Name = "subloteItem";
            this.subloteItem.Size = new System.Drawing.Size(216, 26);
            this.subloteItem.Text = "Sublote";
            this.subloteItem.Click += new System.EventHandler(this.subloteToolStripMenuItem_Click);
            // 
            // toolControl
            // 
            this.toolControl.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RecepTool,
            this.ExportTool,
            this.ComercTool,
            this.MaquilaTool});
            this.toolControl.Location = new System.Drawing.Point(0, 28);
            this.toolControl.Name = "toolControl";
            this.toolControl.Size = new System.Drawing.Size(1143, 27);
            this.toolControl.TabIndex = 1;
            this.toolControl.Text = "ToolStrip";
            // 
            // RecepTool
            // 
            this.RecepTool.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecepTool.ForeColor = System.Drawing.Color.Blue;
            this.RecepTool.Name = "RecepTool";
            this.RecepTool.Size = new System.Drawing.Size(109, 24);
            this.RecepTool.Text = "Recepcion";
            this.RecepTool.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // ExportTool
            // 
            this.ExportTool.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportTool.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ExportTool.Name = "ExportTool";
            this.ExportTool.Size = new System.Drawing.Size(124, 24);
            this.ExportTool.Text = "Exportacion";
            this.ExportTool.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // ComercTool
            // 
            this.ComercTool.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComercTool.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ComercTool.Name = "ComercTool";
            this.ComercTool.Size = new System.Drawing.Size(104, 24);
            this.ComercTool.Text = "Comercial";
            this.ComercTool.Click += new System.EventHandler(this.toolStripLabel4_Click);
            // 
            // MaquilaTool
            // 
            this.MaquilaTool.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaquilaTool.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.MaquilaTool.Name = "MaquilaTool";
            this.MaquilaTool.Size = new System.Drawing.Size(88, 24);
            this.MaquilaTool.Text = "Proceso";
            this.MaquilaTool.Click += new System.EventHandler(this.toolStripLabel3_Click);
            // 
            // statusControl
            // 
            this.statusControl.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusControl.Location = new System.Drawing.Point(0, 677);
            this.statusControl.Name = "statusControl";
            this.statusControl.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusControl.Size = new System.Drawing.Size(1143, 25);
            this.statusControl.TabIndex = 2;
            this.statusControl.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(54, 20);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // prefijoItem
            // 
            this.prefijoItem.Name = "prefijoItem";
            this.prefijoItem.Size = new System.Drawing.Size(216, 26);
            this.prefijoItem.Text = "Prefijo";
            this.prefijoItem.Click += new System.EventHandler(this.prefijoItem_Click);
            // 
            // MDIContenedorPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 702);
            this.Controls.Add(this.statusControl);
            this.Controls.Add(this.toolControl);
            this.Controls.Add(this.menuControl);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuControl;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MDIContenedorPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.MDIContenedorPrincipal_Load);
            this.menuControl.ResumeLayout(false);
            this.menuControl.PerformLayout();
            this.toolControl.ResumeLayout(false);
            this.toolControl.PerformLayout();
            this.statusControl.ResumeLayout(false);
            this.statusControl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuControl;
        private System.Windows.Forms.ToolStrip toolControl;
        private System.Windows.Forms.StatusStrip statusControl;
        private System.Windows.Forms.ToolStripMenuItem printItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem HorizontalItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem exitItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem toolBarItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem cascadeItem;
        private System.Windows.Forms.ToolStripMenuItem VerticalItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem mantenedorMenu;
        private System.Windows.Forms.ToolStripMenuItem clienteItem;
        private System.Windows.Forms.ToolStripMenuItem procesosMenu;
        private System.Windows.Forms.ToolStripMenuItem recepcionItem;
        private System.Windows.Forms.ToolStripMenuItem exportaItem;
        private System.Windows.Forms.ToolStripMenuItem maquilaItem;
        private System.Windows.Forms.ToolStripMenuItem especieItem;
        private System.Windows.Forms.ToolStripLabel RecepTool;
        private System.Windows.Forms.ToolStripLabel ExportTool;
        private System.Windows.Forms.ToolStripLabel MaquilaTool;
        private System.Windows.Forms.ToolStripLabel ComercTool;
        private System.Windows.Forms.ToolStripMenuItem tipoComerItem;
        private System.Windows.Forms.ToolStripMenuItem subloteItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mantRecepItem;
        private System.Windows.Forms.ToolStripMenuItem descargaItem;
        private System.Windows.Forms.ToolStripMenuItem destinoItem;
        private System.Windows.Forms.ToolStripMenuItem bandejasItem;
        private System.Windows.Forms.ToolStripMenuItem palletsItem;
        private System.Windows.Forms.ToolStripMenuItem tipoRecepItem;
        private System.Windows.Forms.ToolStripMenuItem mantExporItem;
        private System.Windows.Forms.ToolStripMenuItem productorItem;
        private System.Windows.Forms.ToolStripMenuItem embalajeItem;
        private System.Windows.Forms.ToolStripMenuItem etiquetasItem;
        private System.Windows.Forms.ToolStripMenuItem mercadoItem;
        private System.Windows.Forms.ToolStripMenuItem tipoArmadItem;
        private System.Windows.Forms.ToolStripMenuItem variedadItem;
        private System.Windows.Forms.ToolStripMenuItem tipoUsuarioItem;
        private System.Windows.Forms.ToolStripMenuItem prefijoItem;
    }
}



