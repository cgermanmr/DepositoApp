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
            System.Windows.Forms.Label usuarioModificadorLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrillaUsuarios = new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dateTimeDesde = new System.Windows.Forms.DateTimePicker();
            this.dateTimeHasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFiltroUsuario = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnQuitarFiltro = new System.Windows.Forms.Button();
            this.cmbEvento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bsFacturas = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioModificadorTextBox = new System.Windows.Forms.TextBox();
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
            this.tipoModificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            usuarioModificadorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // usuarioModificadorLabel
            // 
            usuarioModificadorLabel.AutoSize = true;
            usuarioModificadorLabel.Location = new System.Drawing.Point(14, 126);
            usuarioModificadorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            usuarioModificadorLabel.Name = "usuarioModificadorLabel";
            usuarioModificadorLabel.Size = new System.Drawing.Size(154, 20);
            usuarioModificadorLabel.TabIndex = 50;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrillaUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GrillaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.tipoModificacionDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.estadoDataGridViewCheckBoxColumn});
            this.GrillaUsuarios.DataSource = this.bsFacturas;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrillaUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.GrillaUsuarios.Location = new System.Drawing.Point(26, 249);
            this.GrillaUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GrillaUsuarios.MultiSelect = false;
            this.GrillaUsuarios.Name = "GrillaUsuarios";
            this.GrillaUsuarios.ReadOnly = true;
            this.GrillaUsuarios.RowHeadersVisible = false;
            this.GrillaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaUsuarios.Size = new System.Drawing.Size(1100, 580);
            this.GrillaUsuarios.TabIndex = 30;
            // 
            // DataGridViewTextBoxColumn2
            // 
            this.DataGridViewTextBoxColumn2.DataPropertyName = "Idioma";
            this.DataGridViewTextBoxColumn2.HeaderText = "Idioma";
            this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            this.DataGridViewTextBoxColumn2.ReadOnly = true;
            this.DataGridViewTextBoxColumn2.Width = 63;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(422, 183);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 35);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Tag = "9";
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dateTimeDesde
            // 
            this.dateTimeDesde.Location = new System.Drawing.Point(178, 18);
            this.dateTimeDesde.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimeDesde.Name = "dateTimeDesde";
            this.dateTimeDesde.Size = new System.Drawing.Size(298, 26);
            this.dateTimeDesde.TabIndex = 39;
            this.dateTimeDesde.Value = new System.DateTime(2019, 7, 7, 0, 0, 0, 0);
            this.dateTimeDesde.ValueChanged += new System.EventHandler(this.dateTimeDesde_ValueChanged);
            // 
            // dateTimeHasta
            // 
            this.dateTimeHasta.Location = new System.Drawing.Point(650, 14);
            this.dateTimeHasta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimeHasta.Name = "dateTimeHasta";
            this.dateTimeHasta.Size = new System.Drawing.Size(298, 26);
            this.dateTimeHasta.TabIndex = 40;
            this.dateTimeHasta.Value = new System.DateTime(2019, 7, 7, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(584, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Usuario Modificado:";
            // 
            // txtFiltroUsuario
            // 
            this.txtFiltroUsuario.Location = new System.Drawing.Point(178, 72);
            this.txtFiltroUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFiltroUsuario.Name = "txtFiltroUsuario";
            this.txtFiltroUsuario.Size = new System.Drawing.Size(298, 26);
            this.txtFiltroUsuario.TabIndex = 45;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(178, 183);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(112, 35);
            this.btnFiltrar.TabIndex = 46;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnQuitarFiltro
            // 
            this.btnQuitarFiltro.Location = new System.Drawing.Point(300, 183);
            this.btnQuitarFiltro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQuitarFiltro.Name = "btnQuitarFiltro";
            this.btnQuitarFiltro.Size = new System.Drawing.Size(112, 35);
            this.btnQuitarFiltro.TabIndex = 47;
            this.btnQuitarFiltro.Text = "Quitar Filtro";
            this.btnQuitarFiltro.UseVisualStyleBackColor = true;
            this.btnQuitarFiltro.Click += new System.EventHandler(this.btnQuitarFiltro_Click);
            // 
            // cmbEvento
            // 
            this.cmbEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEvento.FormattingEnabled = true;
            this.cmbEvento.Items.AddRange(new object[] {
            "Alta",
            "Baja",
            "Modificación"});
            this.cmbEvento.Location = new System.Drawing.Point(650, 71);
            this.cmbEvento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbEvento.Name = "cmbEvento";
            this.cmbEvento.Size = new System.Drawing.Size(298, 28);
            this.cmbEvento.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(536, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "Modificación:";
            // 
            // bsFacturas
            // 
            this.bsFacturas.DataSource = typeof(BEL.FacturaReparacionBEL);
            // 
            // usuarioModificadorTextBox
            // 
            this.usuarioModificadorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFacturas, "UsuarioModificador", true));
            this.usuarioModificadorTextBox.Location = new System.Drawing.Point(178, 122);
            this.usuarioModificadorTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usuarioModificadorTextBox.Name = "usuarioModificadorTextBox";
            this.usuarioModificadorTextBox.Size = new System.Drawing.Size(298, 26);
            this.usuarioModificadorTextBox.TabIndex = 51;
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
            this.nroFacturaDataGridViewTextBoxColumn.HeaderText = "NroFactura";
            this.nroFacturaDataGridViewTextBoxColumn.Name = "nroFacturaDataGridViewTextBoxColumn";
            this.nroFacturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nroFacturaDataGridViewTextBoxColumn.Width = 85;
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
            this.cuitProveedorDataGridViewTextBoxColumn.HeaderText = "CuitProveedor";
            this.cuitProveedorDataGridViewTextBoxColumn.Name = "cuitProveedorDataGridViewTextBoxColumn";
            this.cuitProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.cuitProveedorDataGridViewTextBoxColumn.Width = 99;
            // 
            // fechaVtoDataGridViewTextBoxColumn
            // 
            this.fechaVtoDataGridViewTextBoxColumn.DataPropertyName = "FechaVto";
            this.fechaVtoDataGridViewTextBoxColumn.HeaderText = "FechaVto";
            this.fechaVtoDataGridViewTextBoxColumn.Name = "fechaVtoDataGridViewTextBoxColumn";
            this.fechaVtoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaVtoDataGridViewTextBoxColumn.Width = 78;
            // 
            // fechaEmisionDataGridViewTextBoxColumn
            // 
            this.fechaEmisionDataGridViewTextBoxColumn.DataPropertyName = "FechaEmision";
            this.fechaEmisionDataGridViewTextBoxColumn.HeaderText = "FechaEmision";
            this.fechaEmisionDataGridViewTextBoxColumn.Name = "fechaEmisionDataGridViewTextBoxColumn";
            this.fechaEmisionDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaEmisionDataGridViewTextBoxColumn.Width = 98;
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
            this.usuarioModificadorDataGridViewTextBoxColumn.HeaderText = "UsuarioModificador";
            this.usuarioModificadorDataGridViewTextBoxColumn.Name = "usuarioModificadorDataGridViewTextBoxColumn";
            this.usuarioModificadorDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuarioModificadorDataGridViewTextBoxColumn.Width = 123;
            // 
            // fechaModificacionDataGridViewTextBoxColumn
            // 
            this.fechaModificacionDataGridViewTextBoxColumn.DataPropertyName = "FechaModificacion";
            this.fechaModificacionDataGridViewTextBoxColumn.HeaderText = "FechaModificacion";
            this.fechaModificacionDataGridViewTextBoxColumn.Name = "fechaModificacionDataGridViewTextBoxColumn";
            this.fechaModificacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaModificacionDataGridViewTextBoxColumn.Width = 122;
            // 
            // tipoModificacionDataGridViewTextBoxColumn
            // 
            this.tipoModificacionDataGridViewTextBoxColumn.DataPropertyName = "TipoModificacion";
            this.tipoModificacionDataGridViewTextBoxColumn.HeaderText = "TipoModificacion";
            this.tipoModificacionDataGridViewTextBoxColumn.Name = "tipoModificacionDataGridViewTextBoxColumn";
            this.tipoModificacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoModificacionDataGridViewTextBoxColumn.Width = 113;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 88;
            // 
            // estadoDataGridViewCheckBoxColumn
            // 
            this.estadoDataGridViewCheckBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewCheckBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewCheckBoxColumn.Name = "estadoDataGridViewCheckBoxColumn";
            this.estadoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.estadoDataGridViewCheckBoxColumn.Width = 46;
            // 
            // FacturasControlCambiosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 848);
            this.Controls.Add(usuarioModificadorLabel);
            this.Controls.Add(this.usuarioModificadorTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbEvento);
            this.Controls.Add(this.btnQuitarFiltro);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtFiltroUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeHasta);
            this.Controls.Add(this.dateTimeDesde);
            this.Controls.Add(this.GrillaUsuarios);
            this.Controls.Add(this.btnCancelar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FacturasControlCambiosForm";
            this.Text = "Facturas Control de Cambios";
            this.Load += new System.EventHandler(this.AdminUsuariosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        internal System.Windows.Forms.DataGridView GrillaUsuarios;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        internal System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dateTimeDesde;
        private System.Windows.Forms.DateTimePicker dateTimeHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFiltroUsuario;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnQuitarFiltro;
        private System.Windows.Forms.ComboBox cmbEvento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bsFacturas;
        private System.Windows.Forms.TextBox usuarioModificadorTextBox;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoModificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDataGridViewCheckBoxColumn;
    }
}