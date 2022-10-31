namespace AppDeposito.Administracion.Logs
{
    partial class FacturasControlCambiosForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label fechaEmisionDesdeLabel;
            System.Windows.Forms.Label fechaEmisionHastaLabel;
            System.Windows.Forms.Label fechaVtoDesdeLabel;
            System.Windows.Forms.Label fechaVtoHastaLabel;
            System.Windows.Forms.Label usuarioModificadorLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrillaUsuarios = new System.Windows.Forms.DataGridView();
            this.tipoModificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.letraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuitProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEmisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioModificadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaModificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsFacturas = new System.Windows.Forms.BindingSource(this.components);
            this.DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnQuitarFiltro = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEvento = new System.Windows.Forms.ComboBox();
            this.fechaEmisionDesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bsFiltro = new System.Windows.Forms.BindingSource(this.components);
            this.fechaEmisionHastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaVtoDesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaVtoHastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.usuarioModificadorTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            fechaEmisionDesdeLabel = new System.Windows.Forms.Label();
            fechaEmisionHastaLabel = new System.Windows.Forms.Label();
            fechaVtoDesdeLabel = new System.Windows.Forms.Label();
            fechaVtoHastaLabel = new System.Windows.Forms.Label();
            usuarioModificadorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFiltro)).BeginInit();
            this.SuspendLayout();
            // 
            // fechaEmisionDesdeLabel
            // 
            fechaEmisionDesdeLabel.AutoSize = true;
            fechaEmisionDesdeLabel.Location = new System.Drawing.Point(42, 21);
            fechaEmisionDesdeLabel.Name = "fechaEmisionDesdeLabel";
            fechaEmisionDesdeLabel.Size = new System.Drawing.Size(113, 13);
            fechaEmisionDesdeLabel.TabIndex = 51;
            fechaEmisionDesdeLabel.Text = "Fecha Emision Desde:";
            // 
            // fechaEmisionHastaLabel
            // 
            fechaEmisionHastaLabel.AutoSize = true;
            fechaEmisionHastaLabel.Location = new System.Drawing.Point(281, 17);
            fechaEmisionHastaLabel.Name = "fechaEmisionHastaLabel";
            fechaEmisionHastaLabel.Size = new System.Drawing.Size(110, 13);
            fechaEmisionHastaLabel.TabIndex = 52;
            fechaEmisionHastaLabel.Text = "Fecha Emision Hasta:";
            // 
            // fechaVtoDesdeLabel
            // 
            fechaVtoDesdeLabel.AutoSize = true;
            fechaVtoDesdeLabel.Location = new System.Drawing.Point(62, 51);
            fechaVtoDesdeLabel.Name = "fechaVtoDesdeLabel";
            fechaVtoDesdeLabel.Size = new System.Drawing.Size(93, 13);
            fechaVtoDesdeLabel.TabIndex = 53;
            fechaVtoDesdeLabel.Text = "Fecha Vto Desde:";
            // 
            // fechaVtoHastaLabel
            // 
            fechaVtoHastaLabel.AutoSize = true;
            fechaVtoHastaLabel.Location = new System.Drawing.Point(301, 50);
            fechaVtoHastaLabel.Name = "fechaVtoHastaLabel";
            fechaVtoHastaLabel.Size = new System.Drawing.Size(90, 13);
            fechaVtoHastaLabel.TabIndex = 54;
            fechaVtoHastaLabel.Text = "Fecha Vto Hasta:";
            // 
            // usuarioModificadorLabel
            // 
            usuarioModificadorLabel.AutoSize = true;
            usuarioModificadorLabel.Location = new System.Drawing.Point(51, 83);
            usuarioModificadorLabel.Name = "usuarioModificadorLabel";
            usuarioModificadorLabel.Size = new System.Drawing.Size(104, 13);
            usuarioModificadorLabel.TabIndex = 55;
            usuarioModificadorLabel.Text = "Usuario Modificador:";
            // 
            // DataGridViewTextBoxColumn1
            // 
            this.DataGridViewTextBoxColumn1.DataPropertyName = "Perfil";
            this.DataGridViewTextBoxColumn1.HeaderText = "Perfil";
            this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            this.DataGridViewTextBoxColumn1.ReadOnly = true;
            this.DataGridViewTextBoxColumn1.Width = 55;
            // 
            // GrillaUsuarios
            // 
            this.GrillaUsuarios.AllowUserToAddRows = false;
            this.GrillaUsuarios.AllowUserToDeleteRows = false;
            this.GrillaUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrillaUsuarios.AutoGenerateColumns = false;
            this.GrillaUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrillaUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GrillaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipoModificacionDataGridViewTextBoxColumn,
            this.estadoDataGridViewCheckBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.nroFacturaDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.letraDataGridViewTextBoxColumn,
            this.cuitProveedorDataGridViewTextBoxColumn,
            this.fechaVtoDataGridViewTextBoxColumn,
            this.fechaEmisionDataGridViewTextBoxColumn,
            this.importeDataGridViewTextBoxColumn,
            this.usuarioModificadorDataGridViewTextBoxColumn,
            this.fechaModificacionDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.GrillaUsuarios.DataSource = this.bsFacturas;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrillaUsuarios.DefaultCellStyle = dataGridViewCellStyle4;
            this.GrillaUsuarios.Location = new System.Drawing.Point(12, 160);
            this.GrillaUsuarios.MultiSelect = false;
            this.GrillaUsuarios.Name = "GrillaUsuarios";
            this.GrillaUsuarios.ReadOnly = true;
            this.GrillaUsuarios.RowHeadersVisible = false;
            this.GrillaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaUsuarios.Size = new System.Drawing.Size(845, 257);
            this.GrillaUsuarios.TabIndex = 30;
            // 
            // tipoModificacionDataGridViewTextBoxColumn
            // 
            this.tipoModificacionDataGridViewTextBoxColumn.DataPropertyName = "TipoModificacion";
            this.tipoModificacionDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoModificacionDataGridViewTextBoxColumn.Name = "tipoModificacionDataGridViewTextBoxColumn";
            this.tipoModificacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoModificacionDataGridViewTextBoxColumn.Width = 53;
            // 
            // estadoDataGridViewCheckBoxColumn
            // 
            this.estadoDataGridViewCheckBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewCheckBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewCheckBoxColumn.Name = "estadoDataGridViewCheckBoxColumn";
            this.estadoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.estadoDataGridViewCheckBoxColumn.Width = 46;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 41;
            // 
            // nroFacturaDataGridViewTextBoxColumn
            // 
            this.nroFacturaDataGridViewTextBoxColumn.DataPropertyName = "NroFactura";
            this.nroFacturaDataGridViewTextBoxColumn.HeaderText = "Nro Factura";
            this.nroFacturaDataGridViewTextBoxColumn.Name = "nroFacturaDataGridViewTextBoxColumn";
            this.nroFacturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nroFacturaDataGridViewTextBoxColumn.Width = 88;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Width = 65;
            // 
            // letraDataGridViewTextBoxColumn
            // 
            this.letraDataGridViewTextBoxColumn.DataPropertyName = "Letra";
            this.letraDataGridViewTextBoxColumn.HeaderText = "Letra";
            this.letraDataGridViewTextBoxColumn.Name = "letraDataGridViewTextBoxColumn";
            this.letraDataGridViewTextBoxColumn.ReadOnly = true;
            this.letraDataGridViewTextBoxColumn.Width = 56;
            // 
            // cuitProveedorDataGridViewTextBoxColumn
            // 
            this.cuitProveedorDataGridViewTextBoxColumn.DataPropertyName = "CuitProveedor";
            this.cuitProveedorDataGridViewTextBoxColumn.HeaderText = "CUIT";
            this.cuitProveedorDataGridViewTextBoxColumn.Name = "cuitProveedorDataGridViewTextBoxColumn";
            this.cuitProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.cuitProveedorDataGridViewTextBoxColumn.Width = 57;
            // 
            // fechaVtoDataGridViewTextBoxColumn
            // 
            this.fechaVtoDataGridViewTextBoxColumn.DataPropertyName = "FechaVto";
            this.fechaVtoDataGridViewTextBoxColumn.HeaderText = "Vto";
            this.fechaVtoDataGridViewTextBoxColumn.Name = "fechaVtoDataGridViewTextBoxColumn";
            this.fechaVtoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaVtoDataGridViewTextBoxColumn.Width = 48;
            // 
            // fechaEmisionDataGridViewTextBoxColumn
            // 
            this.fechaEmisionDataGridViewTextBoxColumn.DataPropertyName = "FechaEmision";
            this.fechaEmisionDataGridViewTextBoxColumn.HeaderText = "Emision";
            this.fechaEmisionDataGridViewTextBoxColumn.Name = "fechaEmisionDataGridViewTextBoxColumn";
            this.fechaEmisionDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaEmisionDataGridViewTextBoxColumn.Width = 68;
            // 
            // importeDataGridViewTextBoxColumn
            // 
            this.importeDataGridViewTextBoxColumn.DataPropertyName = "Importe";
            this.importeDataGridViewTextBoxColumn.HeaderText = "Importe";
            this.importeDataGridViewTextBoxColumn.Name = "importeDataGridViewTextBoxColumn";
            this.importeDataGridViewTextBoxColumn.ReadOnly = true;
            this.importeDataGridViewTextBoxColumn.Width = 67;
            // 
            // usuarioModificadorDataGridViewTextBoxColumn
            // 
            this.usuarioModificadorDataGridViewTextBoxColumn.DataPropertyName = "UsuarioModificador";
            this.usuarioModificadorDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioModificadorDataGridViewTextBoxColumn.Name = "usuarioModificadorDataGridViewTextBoxColumn";
            this.usuarioModificadorDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuarioModificadorDataGridViewTextBoxColumn.Width = 68;
            // 
            // fechaModificacionDataGridViewTextBoxColumn
            // 
            this.fechaModificacionDataGridViewTextBoxColumn.DataPropertyName = "FechaModificacion";
            this.fechaModificacionDataGridViewTextBoxColumn.HeaderText = "Modificacion";
            this.fechaModificacionDataGridViewTextBoxColumn.Name = "fechaModificacionDataGridViewTextBoxColumn";
            this.fechaModificacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaModificacionDataGridViewTextBoxColumn.Width = 92;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 88;
            // 
            // bsFacturas
            // 
            this.bsFacturas.DataSource = typeof(BEL.FacturaReparacionBEL);
            this.bsFacturas.CurrentChanged += new System.EventHandler(this.bsFacturas_CurrentChanged);
            // 
            // DataGridViewTextBoxColumn2
            // 
            this.DataGridViewTextBoxColumn2.DataPropertyName = "Idioma";
            this.DataGridViewTextBoxColumn2.HeaderText = "Idioma";
            this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            this.DataGridViewTextBoxColumn2.ReadOnly = true;
            this.DataGridViewTextBoxColumn2.Width = 63;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(17, 119);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 46;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnQuitarFiltro
            // 
            this.btnQuitarFiltro.Location = new System.Drawing.Point(98, 119);
            this.btnQuitarFiltro.Name = "btnQuitarFiltro";
            this.btnQuitarFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnQuitarFiltro.TabIndex = 47;
            this.btnQuitarFiltro.Text = "Quitar Filtro";
            this.btnQuitarFiltro.UseVisualStyleBackColor = true;
            this.btnQuitarFiltro.Click += new System.EventHandler(this.btnQuitarFiltro_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Tipo Modificación:";
            // 
            // cmbEvento
            // 
            this.cmbEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEvento.FormattingEnabled = true;
            this.cmbEvento.Items.AddRange(new object[] {
            "Alta",
            "Baja",
            "Modificación"});
            this.cmbEvento.Location = new System.Drawing.Point(397, 78);
            this.cmbEvento.Name = "cmbEvento";
            this.cmbEvento.Size = new System.Drawing.Size(109, 21);
            this.cmbEvento.TabIndex = 48;
            this.cmbEvento.SelectedIndexChanged += new System.EventHandler(this.cmbEvento_SelectedIndexChanged);
            // 
            // fechaEmisionDesdeDateTimePicker
            // 
            this.fechaEmisionDesdeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsFiltro, "FechaEmisionDesde", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "d"));
            this.fechaEmisionDesdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaEmisionDesdeDateTimePicker.Location = new System.Drawing.Point(161, 17);
            this.fechaEmisionDesdeDateTimePicker.Name = "fechaEmisionDesdeDateTimePicker";
            this.fechaEmisionDesdeDateTimePicker.Size = new System.Drawing.Size(82, 20);
            this.fechaEmisionDesdeDateTimePicker.TabIndex = 52;
            // 
            // bsFiltro
            // 
            this.bsFiltro.DataSource = typeof(AppDeposito.Administracion.Logs.Model.FacturaFiltro);
            // 
            // fechaEmisionHastaDateTimePicker
            // 
            this.fechaEmisionHastaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsFiltro, "FechaEmisionHasta", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "d"));
            this.fechaEmisionHastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaEmisionHastaDateTimePicker.Location = new System.Drawing.Point(397, 13);
            this.fechaEmisionHastaDateTimePicker.Name = "fechaEmisionHastaDateTimePicker";
            this.fechaEmisionHastaDateTimePicker.Size = new System.Drawing.Size(82, 20);
            this.fechaEmisionHastaDateTimePicker.TabIndex = 53;
            // 
            // fechaVtoDesdeDateTimePicker
            // 
            this.fechaVtoDesdeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsFiltro, "FechaVtoDesde", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "d"));
            this.fechaVtoDesdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaVtoDesdeDateTimePicker.Location = new System.Drawing.Point(161, 47);
            this.fechaVtoDesdeDateTimePicker.Name = "fechaVtoDesdeDateTimePicker";
            this.fechaVtoDesdeDateTimePicker.Size = new System.Drawing.Size(82, 20);
            this.fechaVtoDesdeDateTimePicker.TabIndex = 54;
            // 
            // fechaVtoHastaDateTimePicker
            // 
            this.fechaVtoHastaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsFiltro, "FechaVtoHasta", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "d"));
            this.fechaVtoHastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaVtoHastaDateTimePicker.Location = new System.Drawing.Point(397, 46);
            this.fechaVtoHastaDateTimePicker.Name = "fechaVtoHastaDateTimePicker";
            this.fechaVtoHastaDateTimePicker.Size = new System.Drawing.Size(82, 20);
            this.fechaVtoHastaDateTimePicker.TabIndex = 55;
            // 
            // usuarioModificadorTextBox
            // 
            this.usuarioModificadorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFiltro, "UsuarioModificador", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.usuarioModificadorTextBox.Location = new System.Drawing.Point(161, 80);
            this.usuarioModificadorTextBox.Name = "usuarioModificadorTextBox";
            this.usuarioModificadorTextBox.Size = new System.Drawing.Size(100, 20);
            this.usuarioModificadorTextBox.TabIndex = 56;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 23);
            this.button1.TabIndex = 57;
            this.button1.Text = "Restaurar Todo a la Fecha Seleccionada";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(732, 124);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(55, 13);
            this.lblFecha.TabIndex = 58;
            this.lblFecha.Text = "                ";
            // 
            // FacturasControlCambiosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(881, 443);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.button1);
            this.Controls.Add(usuarioModificadorLabel);
            this.Controls.Add(this.usuarioModificadorTextBox);
            this.Controls.Add(fechaVtoHastaLabel);
            this.Controls.Add(this.fechaVtoHastaDateTimePicker);
            this.Controls.Add(fechaVtoDesdeLabel);
            this.Controls.Add(this.fechaVtoDesdeDateTimePicker);
            this.Controls.Add(fechaEmisionHastaLabel);
            this.Controls.Add(this.fechaEmisionHastaDateTimePicker);
            this.Controls.Add(fechaEmisionDesdeLabel);
            this.Controls.Add(this.fechaEmisionDesdeDateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbEvento);
            this.Controls.Add(this.btnQuitarFiltro);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.GrillaUsuarios);
            this.Name = "FacturasControlCambiosForm";
            this.Text = "Facturas Control de Cambios";
            this.Load += new System.EventHandler(this.AdminUsuariosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFiltro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        internal System.Windows.Forms.DataGridView GrillaUsuarios;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnQuitarFiltro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bsFacturas;
        private System.Windows.Forms.ComboBox cmbEvento;
        private System.Windows.Forms.BindingSource bsFiltro;
        private System.Windows.Forms.DateTimePicker fechaEmisionDesdeDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaEmisionHastaDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaVtoDesdeDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaVtoHastaDateTimePicker;
        private System.Windows.Forms.TextBox usuarioModificadorTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoModificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn letraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuitProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEmisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioModificadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaModificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
    }
}