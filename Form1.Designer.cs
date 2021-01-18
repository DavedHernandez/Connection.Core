namespace Analizador
{
    partial class Form1
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
            this.gridPrincipal = new System.Windows.Forms.DataGridView();
            this.viewFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.gridDetalle = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rbConfig = new System.Windows.Forms.RadioButton();
            this.btnExportar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gvExternos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.gvProyectos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtruta = new System.Windows.Forms.TextBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblConexion = new System.Windows.Forms.Label();
            this.gvConfiguracion = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtConfigOriginal = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbNodos = new System.Windows.Forms.ComboBox();
            this.txtRutaconfig = new System.Windows.Forms.TextBox();
            this.selectFile = new System.Windows.Forms.OpenFileDialog();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalle)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvExternos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProyectos)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvConfiguracion)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridPrincipal
            // 
            this.gridPrincipal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridPrincipal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPrincipal.Location = new System.Drawing.Point(13, 62);
            this.gridPrincipal.Name = "gridPrincipal";
            this.gridPrincipal.RowHeadersWidth = 51;
            this.gridPrincipal.RowTemplate.Height = 24;
            this.gridPrincipal.Size = new System.Drawing.Size(807, 317);
            this.gridPrincipal.TabIndex = 2;
            this.gridPrincipal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPrincipal_CellClick);
            // 
            // gridDetalle
            // 
            this.gridDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridDetalle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDetalle.Location = new System.Drawing.Point(826, 62);
            this.gridDetalle.Name = "gridDetalle";
            this.gridDetalle.RowHeadersWidth = 51;
            this.gridDetalle.RowTemplate.Height = 24;
            this.gridDetalle.Size = new System.Drawing.Size(528, 317);
            this.gridDetalle.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(409, -84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "NUGETS";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.tabControl1.Location = new System.Drawing.Point(42, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1380, 731);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage1.Controls.Add(this.rbConfig);
            this.tabPage1.Controls.Add(this.btnExportar);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.gvExternos);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.gvProyectos);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtruta);
            this.tabPage1.Controls.Add(this.gridDetalle);
            this.tabPage1.Controls.Add(this.btnProcesar);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.gridPrincipal);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1372, 702);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Analizar .csproj";
            // 
            // rbConfig
            // 
            this.rbConfig.AutoSize = true;
            this.rbConfig.Location = new System.Drawing.Point(979, 34);
            this.rbConfig.Name = "rbConfig";
            this.rbConfig.Size = new System.Drawing.Size(69, 21);
            this.rbConfig.TabIndex = 18;
            this.rbConfig.TabStop = true;
            this.rbConfig.Text = "Config";
            this.rbConfig.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.Black;
            this.btnExportar.Enabled = false;
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.Color.Cyan;
            this.btnExportar.Location = new System.Drawing.Point(826, 29);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(146, 32);
            this.btnExportar.TabIndex = 17;
            this.btnExportar.Text = "Exportar - Excel";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(1282, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "NUGETS";
            // 
            // gvExternos
            // 
            this.gvExternos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvExternos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvExternos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvExternos.Location = new System.Drawing.Point(419, 427);
            this.gvExternos.Name = "gvExternos";
            this.gvExternos.RowHeadersWidth = 51;
            this.gvExternos.RowTemplate.Height = 24;
            this.gvExternos.Size = new System.Drawing.Size(935, 259);
            this.gvExternos.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(416, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "EXTERNAS";
            // 
            // gvProyectos
            // 
            this.gvProyectos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvProyectos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProyectos.Location = new System.Drawing.Point(13, 427);
            this.gvProyectos.Name = "gvProyectos";
            this.gvProyectos.RowHeadersWidth = 51;
            this.gvProyectos.RowTemplate.Height = 24;
            this.gvProyectos.Size = new System.Drawing.Size(386, 259);
            this.gvProyectos.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(13, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "INTERNAS";
            // 
            // txtruta
            // 
            this.txtruta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtruta.Location = new System.Drawing.Point(13, 34);
            this.txtruta.Name = "txtruta";
            this.txtruta.ReadOnly = true;
            this.txtruta.Size = new System.Drawing.Size(707, 22);
            this.txtruta.TabIndex = 11;
            // 
            // btnProcesar
            // 
            this.btnProcesar.BackColor = System.Drawing.Color.Black;
            this.btnProcesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.ForeColor = System.Drawing.Color.Cyan;
            this.btnProcesar.Location = new System.Drawing.Point(730, 29);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(90, 32);
            this.btnProcesar.TabIndex = 10;
            this.btnProcesar.Text = "Analizar";
            this.btnProcesar.UseVisualStyleBackColor = false;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblConexion);
            this.tabPage2.Controls.Add(this.gvConfiguracion);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1372, 702);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Conexiones";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblConexion
            // 
            this.lblConexion.AutoSize = true;
            this.lblConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConexion.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblConexion.Location = new System.Drawing.Point(21, 47);
            this.lblConexion.Name = "lblConexion";
            this.lblConexion.Size = new System.Drawing.Size(90, 17);
            this.lblConexion.TabIndex = 16;
            this.lblConexion.Text = "EXTERNAS";
            // 
            // gvConfiguracion
            // 
            this.gvConfiguracion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvConfiguracion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvConfiguracion.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gvConfiguracion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvConfiguracion.Location = new System.Drawing.Point(24, 76);
            this.gvConfiguracion.Name = "gvConfiguracion";
            this.gvConfiguracion.RowHeadersWidth = 51;
            this.gvConfiguracion.RowTemplate.Height = 24;
            this.gvConfiguracion.Size = new System.Drawing.Size(945, 317);
            this.gvConfiguracion.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.iconButton5);
            this.tabPage3.Controls.Add(this.iconButton4);
            this.tabPage3.Controls.Add(this.iconButton3);
            this.tabPage3.Controls.Add(this.iconButton2);
            this.tabPage3.Controls.Add(this.iconButton1);
            this.tabPage3.Controls.Add(this.txtConfigOriginal);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.cmbNodos);
            this.tabPage3.Controls.Add(this.txtRutaconfig);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1372, 702);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Configurar .config";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtConfigOriginal
            // 
            this.txtConfigOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfigOriginal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtConfigOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfigOriginal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(154)))), ((int)(((byte)(231)))));
            this.txtConfigOriginal.Location = new System.Drawing.Point(131, 169);
            this.txtConfigOriginal.Name = "txtConfigOriginal";
            this.txtConfigOriginal.ReadOnly = true;
            this.txtConfigOriginal.Size = new System.Drawing.Size(1199, 515);
            this.txtConfigOriginal.TabIndex = 17;
            this.txtConfigOriginal.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ruta config:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nodos:";
            // 
            // cmbNodos
            // 
            this.cmbNodos.BackColor = System.Drawing.SystemColors.Control;
            this.cmbNodos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNodos.FormattingEnabled = true;
            this.cmbNodos.Location = new System.Drawing.Point(131, 75);
            this.cmbNodos.Name = "cmbNodos";
            this.cmbNodos.Size = new System.Drawing.Size(713, 28);
            this.cmbNodos.TabIndex = 14;
            this.cmbNodos.SelectedIndexChanged += new System.EventHandler(this.cmbNodos_SelectedIndexChanged);
            // 
            // txtRutaconfig
            // 
            this.txtRutaconfig.BackColor = System.Drawing.Color.White;
            this.txtRutaconfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutaconfig.Location = new System.Drawing.Point(131, 33);
            this.txtRutaconfig.Name = "txtRutaconfig";
            this.txtRutaconfig.ReadOnly = true;
            this.txtRutaconfig.Size = new System.Drawing.Size(713, 26);
            this.txtRutaconfig.TabIndex = 13;
            // 
            // selectFile
            // 
            this.selectFile.FileName = "openFileDialog1";
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.iconButton1.IconColor = System.Drawing.Color.Blue;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(1227, 23);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(1);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(37, 32);
            this.iconButton1.TabIndex = 27;
            this.iconButton1.Tag = "Guardar cambios";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.CheckDouble;
            this.iconButton2.IconColor = System.Drawing.Color.MediumSeaGreen;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton2.IconSize = 30;
            this.iconButton2.Location = new System.Drawing.Point(1188, 23);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(1);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(37, 32);
            this.iconButton2.TabIndex = 28;
            this.iconButton2.Tag = "Editar";
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            this.iconButton3.IconColor = System.Drawing.Color.Navy;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton3.IconSize = 30;
            this.iconButton3.Location = new System.Drawing.Point(1266, 23);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(1);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(37, 32);
            this.iconButton3.TabIndex = 29;
            this.iconButton3.Tag = "Exportar .config";
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.btnExportarxml_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconButton4.IconColor = System.Drawing.Color.Red;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton4.IconSize = 30;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton4.Location = new System.Drawing.Point(1146, 23);
            this.iconButton4.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(45, 32);
            this.iconButton4.TabIndex = 30;
            this.iconButton4.Tag = "Cancelar";
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.btnRollback_Click);
            // 
            // iconButton5
            // 
            this.iconButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton5.IconColor = System.Drawing.Color.Teal;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton5.IconSize = 30;
            this.iconButton5.Location = new System.Drawing.Point(1299, 23);
            this.iconButton5.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(37, 32);
            this.iconButton5.TabIndex = 31;
            this.iconButton5.Tag = "Buscar archivo";
            this.iconButton5.UseVisualStyleBackColor = true;
            this.iconButton5.Click += new System.EventHandler(this.btnCargarConfig_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1434, 791);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalle)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvExternos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProyectos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvConfiguracion)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gridPrincipal;
        private System.Windows.Forms.FolderBrowserDialog viewFolder;
        private System.Windows.Forms.DataGridView gridDetalle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtruta;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.DataGridView gvExternos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gvProyectos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gvConfiguracion;
        private System.Windows.Forms.Label lblConexion;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.RadioButton rbConfig;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtRutaconfig;
        private System.Windows.Forms.OpenFileDialog selectFile;
        private System.Windows.Forms.RichTextBox txtConfigOriginal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbNodos;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton5;
    }
}

