namespace AppDeposito
{
    partial class ActivoAdminForm
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
            System.Windows.Forms.Label Label1;
            System.Windows.Forms.Label UbicacionDescripcionLabel1;
            System.Windows.Forms.Label TipoDescripcionLabel1;
            System.Windows.Forms.Label SectorNombreLabel;
            System.Windows.Forms.Label RazonSocialLabel;
            System.Windows.Forms.Label MarcaNombreLabel;
            System.Windows.Forms.Label EstadoDescripcionLabel;
            System.Windows.Forms.Label DescripcionLabel;
            System.Windows.Forms.Label NumeroSerieLabel;
            System.Windows.Forms.Label ObservacionesLabel;
            System.Windows.Forms.Label VolumenLabel;
            System.Windows.Forms.Label numeroInventarioLabel1;
            this.GrillaActivos = new System.Windows.Forms.DataGridView();
            this.inventarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoActivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoActivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Organizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enGarantiaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsActivos = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.observacionesTextBox = new System.Windows.Forms.TextBox();
            this.enGarantiaCheckBox = new System.Windows.Forms.CheckBox();
            this.serieTextBox = new System.Windows.Forms.TextBox();
            this.inventarioTextBox = new System.Windows.Forms.TextBox();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.DatosDeCompraButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FiltroTextBox = new System.Windows.Forms.TextBox();
            this.UbicacionTextBox = new System.Windows.Forms.TextBox();
            this.TipoTextBox = new System.Windows.Forms.TextBox();
            this.SectorTextBox = new System.Windows.Forms.TextBox();
            this.OrganizacionTextBox = new System.Windows.Forms.TextBox();
            this.MarcaTextBox = new System.Windows.Forms.TextBox();
            this.EstadoTextBox = new System.Windows.Forms.TextBox();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.DireccionTextBox = new System.Windows.Forms.TextBox();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.VolumenTextBox = new System.Windows.Forms.TextBox();
            Label1 = new System.Windows.Forms.Label();
            UbicacionDescripcionLabel1 = new System.Windows.Forms.Label();
            TipoDescripcionLabel1 = new System.Windows.Forms.Label();
            SectorNombreLabel = new System.Windows.Forms.Label();
            RazonSocialLabel = new System.Windows.Forms.Label();
            MarcaNombreLabel = new System.Windows.Forms.Label();
            EstadoDescripcionLabel = new System.Windows.Forms.Label();
            DescripcionLabel = new System.Windows.Forms.Label();
            NumeroSerieLabel = new System.Windows.Forms.Label();
            ObservacionesLabel = new System.Windows.Forms.Label();
            VolumenLabel = new System.Windows.Forms.Label();
            numeroInventarioLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new System.Drawing.Point(31, 246);
            Label1.Name = "Label1";
            Label1.Size = new System.Drawing.Size(55, 13);
            Label1.TabIndex = 192;
            Label1.Text = "Dirección:";
            // 
            // UbicacionDescripcionLabel1
            // 
            UbicacionDescripcionLabel1.AutoSize = true;
            UbicacionDescripcionLabel1.Location = new System.Drawing.Point(29, 220);
            UbicacionDescripcionLabel1.Name = "UbicacionDescripcionLabel1";
            UbicacionDescripcionLabel1.Size = new System.Drawing.Size(58, 13);
            UbicacionDescripcionLabel1.TabIndex = 188;
            UbicacionDescripcionLabel1.Text = "Ubicación:";
            // 
            // TipoDescripcionLabel1
            // 
            TipoDescripcionLabel1.AutoSize = true;
            TipoDescripcionLabel1.Location = new System.Drawing.Point(55, 119);
            TipoDescripcionLabel1.Name = "TipoDescripcionLabel1";
            TipoDescripcionLabel1.Size = new System.Drawing.Size(31, 13);
            TipoDescripcionLabel1.TabIndex = 187;
            TipoDescripcionLabel1.Text = "Tipo:";
            // 
            // SectorNombreLabel
            // 
            SectorNombreLabel.AutoSize = true;
            SectorNombreLabel.Location = new System.Drawing.Point(45, 194);
            SectorNombreLabel.Name = "SectorNombreLabel";
            SectorNombreLabel.Size = new System.Drawing.Size(41, 13);
            SectorNombreLabel.TabIndex = 186;
            SectorNombreLabel.Text = "Sector:";
            // 
            // RazonSocialLabel
            // 
            RazonSocialLabel.AutoSize = true;
            RazonSocialLabel.Location = new System.Drawing.Point(15, 169);
            RazonSocialLabel.Name = "RazonSocialLabel";
            RazonSocialLabel.Size = new System.Drawing.Size(72, 13);
            RazonSocialLabel.TabIndex = 185;
            RazonSocialLabel.Text = "Organización:";
            // 
            // MarcaNombreLabel
            // 
            MarcaNombreLabel.AutoSize = true;
            MarcaNombreLabel.Location = new System.Drawing.Point(46, 91);
            MarcaNombreLabel.Name = "MarcaNombreLabel";
            MarcaNombreLabel.Size = new System.Drawing.Size(40, 13);
            MarcaNombreLabel.TabIndex = 184;
            MarcaNombreLabel.Text = "Marca:";
            // 
            // EstadoDescripcionLabel
            // 
            EstadoDescripcionLabel.AutoSize = true;
            EstadoDescripcionLabel.Location = new System.Drawing.Point(43, 143);
            EstadoDescripcionLabel.Name = "EstadoDescripcionLabel";
            EstadoDescripcionLabel.Size = new System.Drawing.Size(43, 13);
            EstadoDescripcionLabel.TabIndex = 183;
            EstadoDescripcionLabel.Text = "Estado:";
            // 
            // DescripcionLabel
            // 
            DescripcionLabel.AutoSize = true;
            DescripcionLabel.Location = new System.Drawing.Point(20, 65);
            DescripcionLabel.Name = "DescripcionLabel";
            DescripcionLabel.Size = new System.Drawing.Size(66, 13);
            DescripcionLabel.TabIndex = 173;
            DescripcionLabel.Text = "Descripcion:";
            // 
            // NumeroSerieLabel
            // 
            NumeroSerieLabel.AutoSize = true;
            NumeroSerieLabel.Location = new System.Drawing.Point(231, 39);
            NumeroSerieLabel.Name = "NumeroSerieLabel";
            NumeroSerieLabel.Size = new System.Drawing.Size(34, 13);
            NumeroSerieLabel.TabIndex = 177;
            NumeroSerieLabel.Text = "Serie:";
            // 
            // ObservacionesLabel
            // 
            ObservacionesLabel.AutoSize = true;
            ObservacionesLabel.Location = new System.Drawing.Point(7, 273);
            ObservacionesLabel.Name = "ObservacionesLabel";
            ObservacionesLabel.Size = new System.Drawing.Size(81, 13);
            ObservacionesLabel.TabIndex = 179;
            ObservacionesLabel.Text = "Observaciones:";
            // 
            // VolumenLabel
            // 
            VolumenLabel.AutoSize = true;
            VolumenLabel.Location = new System.Drawing.Point(355, 119);
            VolumenLabel.Name = "VolumenLabel";
            VolumenLabel.Size = new System.Drawing.Size(51, 13);
            VolumenLabel.TabIndex = 181;
            VolumenLabel.Text = "Volumen:";
            // 
            // numeroInventarioLabel1
            // 
            numeroInventarioLabel1.AutoSize = true;
            numeroInventarioLabel1.Location = new System.Drawing.Point(31, 35);
            numeroInventarioLabel1.Name = "numeroInventarioLabel1";
            numeroInventarioLabel1.Size = new System.Drawing.Size(57, 13);
            numeroInventarioLabel1.TabIndex = 205;
            numeroInventarioLabel1.Text = "Inventario:";
            // 
            // GrillaActivos
            // 
            this.GrillaActivos.AllowUserToAddRows = false;
            this.GrillaActivos.AllowUserToDeleteRows = false;
            this.GrillaActivos.AllowUserToOrderColumns = true;
            this.GrillaActivos.AutoGenerateColumns = false;
            this.GrillaActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaActivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inventarioDataGridViewTextBoxColumn,
            this.serieDataGridViewTextBoxColumn,
            this.Descripcion,
            this.tipoActivoDataGridViewTextBoxColumn,
            this.estadoActivoDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.Organizacion,
            this.enGarantiaDataGridViewCheckBoxColumn});
            this.GrillaActivos.DataSource = this.bsActivos;
            this.GrillaActivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrillaActivos.Location = new System.Drawing.Point(0, 0);
            this.GrillaActivos.Name = "GrillaActivos";
            this.GrillaActivos.ReadOnly = true;
            this.GrillaActivos.RowHeadersVisible = false;
            this.GrillaActivos.RowHeadersWidth = 62;
            this.GrillaActivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaActivos.Size = new System.Drawing.Size(591, 231);
            this.GrillaActivos.TabIndex = 1;
            // 
            // inventarioDataGridViewTextBoxColumn
            // 
            this.inventarioDataGridViewTextBoxColumn.DataPropertyName = "Inventario";
            this.inventarioDataGridViewTextBoxColumn.HeaderText = "Inventario";
            this.inventarioDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.inventarioDataGridViewTextBoxColumn.Name = "inventarioDataGridViewTextBoxColumn";
            this.inventarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.inventarioDataGridViewTextBoxColumn.Width = 150;
            // 
            // serieDataGridViewTextBoxColumn
            // 
            this.serieDataGridViewTextBoxColumn.DataPropertyName = "Serie";
            this.serieDataGridViewTextBoxColumn.HeaderText = "Serie";
            this.serieDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.serieDataGridViewTextBoxColumn.Name = "serieDataGridViewTextBoxColumn";
            this.serieDataGridViewTextBoxColumn.ReadOnly = true;
            this.serieDataGridViewTextBoxColumn.Width = 150;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.MinimumWidth = 8;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 99;
            // 
            // tipoActivoDataGridViewTextBoxColumn
            // 
            this.tipoActivoDataGridViewTextBoxColumn.DataPropertyName = "TipoActivo";
            this.tipoActivoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoActivoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tipoActivoDataGridViewTextBoxColumn.Name = "tipoActivoDataGridViewTextBoxColumn";
            this.tipoActivoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoActivoDataGridViewTextBoxColumn.Width = 150;
            // 
            // estadoActivoDataGridViewTextBoxColumn
            // 
            this.estadoActivoDataGridViewTextBoxColumn.DataPropertyName = "EstadoActivo";
            this.estadoActivoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoActivoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.estadoActivoDataGridViewTextBoxColumn.Name = "estadoActivoDataGridViewTextBoxColumn";
            this.estadoActivoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoActivoDataGridViewTextBoxColumn.Width = 150;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
            this.marcaDataGridViewTextBoxColumn.Width = 150;
            // 
            // Organizacion
            // 
            this.Organizacion.DataPropertyName = "Organizacion";
            this.Organizacion.HeaderText = "Organizacion";
            this.Organizacion.MinimumWidth = 8;
            this.Organizacion.Name = "Organizacion";
            this.Organizacion.ReadOnly = true;
            this.Organizacion.Width = 150;
            // 
            // enGarantiaDataGridViewCheckBoxColumn
            // 
            this.enGarantiaDataGridViewCheckBoxColumn.DataPropertyName = "EnGarantia";
            this.enGarantiaDataGridViewCheckBoxColumn.HeaderText = "EnGarantia";
            this.enGarantiaDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.enGarantiaDataGridViewCheckBoxColumn.Name = "enGarantiaDataGridViewCheckBoxColumn";
            this.enGarantiaDataGridViewCheckBoxColumn.ReadOnly = true;
            this.enGarantiaDataGridViewCheckBoxColumn.Width = 150;
            // 
            // bsActivos
            // 
            this.bsActivos.DataSource = typeof(BEL.ActivoBEL);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.observacionesTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.enGarantiaCheckBox);
            this.splitContainer1.Panel1.Controls.Add(this.serieTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.inventarioTextBox);
            this.splitContainer1.Panel1.Controls.Add(numeroInventarioLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.EliminarButton);
            this.splitContainer1.Panel1.Controls.Add(this.DatosDeCompraButton);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.FiltroTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.UbicacionTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.TipoTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.SectorTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.OrganizacionTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.MarcaTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.EstadoTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.ModificarButton);
            this.splitContainer1.Panel1.Controls.Add(Label1);
            this.splitContainer1.Panel1.Controls.Add(this.DireccionTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.AgregarButton);
            this.splitContainer1.Panel1.Controls.Add(UbicacionDescripcionLabel1);
            this.splitContainer1.Panel1.Controls.Add(TipoDescripcionLabel1);
            this.splitContainer1.Panel1.Controls.Add(SectorNombreLabel);
            this.splitContainer1.Panel1.Controls.Add(RazonSocialLabel);
            this.splitContainer1.Panel1.Controls.Add(MarcaNombreLabel);
            this.splitContainer1.Panel1.Controls.Add(EstadoDescripcionLabel);
            this.splitContainer1.Panel1.Controls.Add(DescripcionLabel);
            this.splitContainer1.Panel1.Controls.Add(this.DescripcionTextBox);
            this.splitContainer1.Panel1.Controls.Add(NumeroSerieLabel);
            this.splitContainer1.Panel1.Controls.Add(ObservacionesLabel);
            this.splitContainer1.Panel1.Controls.Add(VolumenLabel);
            this.splitContainer1.Panel1.Controls.Add(this.VolumenTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.GrillaActivos);
            this.splitContainer1.Size = new System.Drawing.Size(591, 604);
            this.splitContainer1.SplitterDistance = 369;
            this.splitContainer1.TabIndex = 173;
            // 
            // observacionesTextBox
            // 
            this.observacionesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsActivos, "Observaciones", true));
            this.observacionesTextBox.Location = new System.Drawing.Point(92, 269);
            this.observacionesTextBox.Multiline = true;
            this.observacionesTextBox.Name = "observacionesTextBox";
            this.observacionesTextBox.Size = new System.Drawing.Size(419, 55);
            this.observacionesTextBox.TabIndex = 209;
            // 
            // enGarantiaCheckBox
            // 
            this.enGarantiaCheckBox.AutoSize = true;
            this.enGarantiaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsActivos, "EnGarantia", true));
            this.enGarantiaCheckBox.Location = new System.Drawing.Point(412, 87);
            this.enGarantiaCheckBox.Name = "enGarantiaCheckBox";
            this.enGarantiaCheckBox.Size = new System.Drawing.Size(91, 21);
            this.enGarantiaCheckBox.TabIndex = 208;
            this.enGarantiaCheckBox.Text = "En Garantía";
            this.enGarantiaCheckBox.UseVisualStyleBackColor = true;
            this.enGarantiaCheckBox.CheckedChanged += new System.EventHandler(this.enGarantiaCheckBox_CheckedChanged);
            // 
            // serieTextBox
            // 
            this.serieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsActivos, "Serie", true));
            this.serieTextBox.Location = new System.Drawing.Point(271, 35);
            this.serieTextBox.Name = "serieTextBox";
            this.serieTextBox.Size = new System.Drawing.Size(100, 20);
            this.serieTextBox.TabIndex = 207;
            // 
            // inventarioTextBox
            // 
            this.inventarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsActivos, "Inventario", true));
            this.inventarioTextBox.Location = new System.Drawing.Point(92, 35);
            this.inventarioTextBox.Name = "inventarioTextBox";
            this.inventarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.inventarioTextBox.TabIndex = 206;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(439, 330);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 23);
            this.EliminarButton.TabIndex = 174;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // DatosDeCompraButton
            // 
            this.DatosDeCompraButton.Location = new System.Drawing.Point(399, 33);
            this.DatosDeCompraButton.Name = "DatosDeCompraButton";
            this.DatosDeCompraButton.Size = new System.Drawing.Size(112, 23);
            this.DatosDeCompraButton.TabIndex = 205;
            this.DatosDeCompraButton.Text = "Info Compra";
            this.DatosDeCompraButton.UseVisualStyleBackColor = true;
            this.DatosDeCompraButton.Click += new System.EventHandler(this.DatosDeCompraButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 201;
            this.label2.Text = "Filtrar:";
            // 
            // FiltroTextBox
            // 
            this.FiltroTextBox.Location = new System.Drawing.Point(92, 330);
            this.FiltroTextBox.Name = "FiltroTextBox";
            this.FiltroTextBox.Size = new System.Drawing.Size(161, 20);
            this.FiltroTextBox.TabIndex = 200;
            this.FiltroTextBox.TextChanged += new System.EventHandler(this.FiltroTextBox_TextChanged);
            // 
            // UbicacionTextBox
            // 
            this.UbicacionTextBox.Location = new System.Drawing.Point(92, 217);
            this.UbicacionTextBox.Name = "UbicacionTextBox";
            this.UbicacionTextBox.Size = new System.Drawing.Size(419, 20);
            this.UbicacionTextBox.TabIndex = 199;
            // 
            // TipoTextBox
            // 
            this.TipoTextBox.Location = new System.Drawing.Point(92, 113);
            this.TipoTextBox.Name = "TipoTextBox";
            this.TipoTextBox.Size = new System.Drawing.Size(250, 20);
            this.TipoTextBox.TabIndex = 198;
            // 
            // SectorTextBox
            // 
            this.SectorTextBox.Location = new System.Drawing.Point(92, 191);
            this.SectorTextBox.Name = "SectorTextBox";
            this.SectorTextBox.Size = new System.Drawing.Size(419, 20);
            this.SectorTextBox.TabIndex = 197;
            // 
            // OrganizacionTextBox
            // 
            this.OrganizacionTextBox.Location = new System.Drawing.Point(92, 165);
            this.OrganizacionTextBox.Name = "OrganizacionTextBox";
            this.OrganizacionTextBox.Size = new System.Drawing.Size(419, 20);
            this.OrganizacionTextBox.TabIndex = 196;
            // 
            // MarcaTextBox
            // 
            this.MarcaTextBox.Location = new System.Drawing.Point(92, 87);
            this.MarcaTextBox.Name = "MarcaTextBox";
            this.MarcaTextBox.Size = new System.Drawing.Size(250, 20);
            this.MarcaTextBox.TabIndex = 195;
            // 
            // EstadoTextBox
            // 
            this.EstadoTextBox.Location = new System.Drawing.Point(92, 139);
            this.EstadoTextBox.Name = "EstadoTextBox";
            this.EstadoTextBox.Size = new System.Drawing.Size(419, 20);
            this.EstadoTextBox.TabIndex = 194;
            // 
            // ModificarButton
            // 
            this.ModificarButton.Location = new System.Drawing.Point(358, 330);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(75, 23);
            this.ModificarButton.TabIndex = 193;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = true;
            this.ModificarButton.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // DireccionTextBox
            // 
            this.DireccionTextBox.Location = new System.Drawing.Point(92, 243);
            this.DireccionTextBox.Name = "DireccionTextBox";
            this.DireccionTextBox.ReadOnly = true;
            this.DireccionTextBox.Size = new System.Drawing.Size(419, 20);
            this.DireccionTextBox.TabIndex = 191;
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(277, 330);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(75, 23);
            this.AgregarButton.TabIndex = 189;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(92, 61);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(419, 20);
            this.DescripcionTextBox.TabIndex = 174;
            // 
            // VolumenTextBox
            // 
            this.VolumenTextBox.Location = new System.Drawing.Point(412, 113);
            this.VolumenTextBox.Name = "VolumenTextBox";
            this.VolumenTextBox.Size = new System.Drawing.Size(99, 20);
            this.VolumenTextBox.TabIndex = 182;
            // 
            // ActivoAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 604);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ActivoAdminForm";
            this.Text = "Activos";
            this.Load += new System.EventHandler(this.ActivosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsActivos)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView GrillaActivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UbicacionTextBox;
        private System.Windows.Forms.TextBox TipoTextBox;
        private System.Windows.Forms.TextBox SectorTextBox;
        private System.Windows.Forms.TextBox OrganizacionTextBox;
        private System.Windows.Forms.TextBox MarcaTextBox;
        private System.Windows.Forms.TextBox EstadoTextBox;
        private System.Windows.Forms.Button ModificarButton;
        internal System.Windows.Forms.TextBox DireccionTextBox;
        internal System.Windows.Forms.Button AgregarButton;
        internal System.Windows.Forms.TextBox DescripcionTextBox;
        internal System.Windows.Forms.TextBox VolumenTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button DatosDeCompraButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.TextBox serieTextBox;
        private System.Windows.Forms.BindingSource bsActivos;
        private System.Windows.Forms.TextBox inventarioTextBox;
        private System.Windows.Forms.CheckBox enGarantiaCheckBox;
        private System.Windows.Forms.TextBox observacionesTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoActivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoActivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Organizacion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn enGarantiaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TextBox FiltroTextBox;
    }
}