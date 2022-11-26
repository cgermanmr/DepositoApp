namespace AppDeposito
{
    partial class ActivoEditForm
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
            System.Windows.Forms.Label DescripcionLabel;
            System.Windows.Forms.Label NumeroInventarioLabel;
            System.Windows.Forms.Label NumeroSerieLabel;
            System.Windows.Forms.Label ObservacionesLabel;
            System.Windows.Forms.Label PeriodoGarantiaLabel;
            System.Windows.Forms.Label ValorCompraLabel;
            System.Windows.Forms.Label VolumenLabel;
            System.Windows.Forms.Label EstadoDescripcionLabel;
            System.Windows.Forms.Label monedaLabel1;
            System.Windows.Forms.Label fechaAltaLabel1;
            System.Windows.Forms.Label fechaCompraLabel;
            this.DireccionTextBox = new System.Windows.Forms.TextBox();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.AceptarButton = new System.Windows.Forms.Button();
            this.UbicacionComboBox = new System.Windows.Forms.ComboBox();
            this.SectorComboBox = new System.Windows.Forms.ComboBox();
            this.OrganizacionComboBox = new System.Windows.Forms.ComboBox();
            this.MarcaComboBox = new System.Windows.Forms.ComboBox();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.NumeroInventarioTextBox = new System.Windows.Forms.TextBox();
            this.NumeroSerieTextBox = new System.Windows.Forms.TextBox();
            this.ObservacionesTextBox = new System.Windows.Forms.TextBox();
            this.PeriodoGarantiaTextBox = new System.Windows.Forms.TextBox();
            this.ValorCompraTextBox = new System.Windows.Forms.TextBox();
            this.VolumenTextBox = new System.Windows.Forms.TextBox();
            this.TipoComboBox = new System.Windows.Forms.ComboBox();
            this.EstadoComboBox = new System.Windows.Forms.ComboBox();
            this.bsEditado = new System.Windows.Forms.BindingSource(this.components);
            this.monedaComboBox = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.fechaAltaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaCompraDateTimePicker = new System.Windows.Forms.DateTimePicker();
            Label1 = new System.Windows.Forms.Label();
            UbicacionDescripcionLabel1 = new System.Windows.Forms.Label();
            TipoDescripcionLabel1 = new System.Windows.Forms.Label();
            SectorNombreLabel = new System.Windows.Forms.Label();
            RazonSocialLabel = new System.Windows.Forms.Label();
            MarcaNombreLabel = new System.Windows.Forms.Label();
            DescripcionLabel = new System.Windows.Forms.Label();
            NumeroInventarioLabel = new System.Windows.Forms.Label();
            NumeroSerieLabel = new System.Windows.Forms.Label();
            ObservacionesLabel = new System.Windows.Forms.Label();
            PeriodoGarantiaLabel = new System.Windows.Forms.Label();
            ValorCompraLabel = new System.Windows.Forms.Label();
            VolumenLabel = new System.Windows.Forms.Label();
            EstadoDescripcionLabel = new System.Windows.Forms.Label();
            monedaLabel1 = new System.Windows.Forms.Label();
            fechaAltaLabel1 = new System.Windows.Forms.Label();
            fechaCompraLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsEditado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new System.Drawing.Point(62, 334);
            Label1.Name = "Label1";
            Label1.Size = new System.Drawing.Size(55, 13);
            Label1.TabIndex = 120;
            Label1.Text = "Dirección:";
            // 
            // UbicacionDescripcionLabel1
            // 
            UbicacionDescripcionLabel1.AutoSize = true;
            UbicacionDescripcionLabel1.Location = new System.Drawing.Point(59, 307);
            UbicacionDescripcionLabel1.Name = "UbicacionDescripcionLabel1";
            UbicacionDescripcionLabel1.Size = new System.Drawing.Size(58, 13);
            UbicacionDescripcionLabel1.TabIndex = 112;
            UbicacionDescripcionLabel1.Text = "Ubicación:";
            // 
            // TipoDescripcionLabel1
            // 
            TipoDescripcionLabel1.AutoSize = true;
            TipoDescripcionLabel1.Location = new System.Drawing.Point(83, 280);
            TipoDescripcionLabel1.Name = "TipoDescripcionLabel1";
            TipoDescripcionLabel1.Size = new System.Drawing.Size(31, 13);
            TipoDescripcionLabel1.TabIndex = 110;
            TipoDescripcionLabel1.Text = "Tipo:";
            // 
            // SectorNombreLabel
            // 
            SectorNombreLabel.AutoSize = true;
            SectorNombreLabel.Location = new System.Drawing.Point(74, 253);
            SectorNombreLabel.Name = "SectorNombreLabel";
            SectorNombreLabel.Size = new System.Drawing.Size(41, 13);
            SectorNombreLabel.TabIndex = 108;
            SectorNombreLabel.Text = "Sector:";
            // 
            // RazonSocialLabel
            // 
            RazonSocialLabel.AutoSize = true;
            RazonSocialLabel.Location = new System.Drawing.Point(41, 226);
            RazonSocialLabel.Name = "RazonSocialLabel";
            RazonSocialLabel.Size = new System.Drawing.Size(72, 13);
            RazonSocialLabel.TabIndex = 106;
            RazonSocialLabel.Text = "Organización:";
            // 
            // MarcaNombreLabel
            // 
            MarcaNombreLabel.AutoSize = true;
            MarcaNombreLabel.Location = new System.Drawing.Point(74, 199);
            MarcaNombreLabel.Name = "MarcaNombreLabel";
            MarcaNombreLabel.Size = new System.Drawing.Size(40, 13);
            MarcaNombreLabel.TabIndex = 103;
            MarcaNombreLabel.Text = "Marca:";
            // 
            // DescripcionLabel
            // 
            DescripcionLabel.AutoSize = true;
            DescripcionLabel.Location = new System.Drawing.Point(48, 40);
            DescripcionLabel.Name = "DescripcionLabel";
            DescripcionLabel.Size = new System.Drawing.Size(66, 13);
            DescripcionLabel.TabIndex = 82;
            DescripcionLabel.Text = "Descripcion:";
            // 
            // NumeroInventarioLabel
            // 
            NumeroInventarioLabel.AutoSize = true;
            NumeroInventarioLabel.Location = new System.Drawing.Point(17, 14);
            NumeroInventarioLabel.Name = "NumeroInventarioLabel";
            NumeroInventarioLabel.Size = new System.Drawing.Size(97, 13);
            NumeroInventarioLabel.TabIndex = 88;
            NumeroInventarioLabel.Text = "Numero Inventario:";
            // 
            // NumeroSerieLabel
            // 
            NumeroSerieLabel.AutoSize = true;
            NumeroSerieLabel.Location = new System.Drawing.Point(40, 66);
            NumeroSerieLabel.Name = "NumeroSerieLabel";
            NumeroSerieLabel.Size = new System.Drawing.Size(74, 13);
            NumeroSerieLabel.TabIndex = 90;
            NumeroSerieLabel.Text = "Numero Serie:";
            // 
            // ObservacionesLabel
            // 
            ObservacionesLabel.AutoSize = true;
            ObservacionesLabel.Location = new System.Drawing.Point(33, 357);
            ObservacionesLabel.Name = "ObservacionesLabel";
            ObservacionesLabel.Size = new System.Drawing.Size(81, 13);
            ObservacionesLabel.TabIndex = 92;
            ObservacionesLabel.Text = "Observaciones:";
            // 
            // PeriodoGarantiaLabel
            // 
            PeriodoGarantiaLabel.AutoSize = true;
            PeriodoGarantiaLabel.Location = new System.Drawing.Point(291, 115);
            PeriodoGarantiaLabel.Name = "PeriodoGarantiaLabel";
            PeriodoGarantiaLabel.Size = new System.Drawing.Size(90, 13);
            PeriodoGarantiaLabel.TabIndex = 94;
            PeriodoGarantiaLabel.Text = "Garantia (Meses):";
            // 
            // ValorCompraLabel
            // 
            ValorCompraLabel.AutoSize = true;
            ValorCompraLabel.Location = new System.Drawing.Point(345, 92);
            ValorCompraLabel.Name = "ValorCompraLabel";
            ValorCompraLabel.Size = new System.Drawing.Size(37, 13);
            ValorCompraLabel.TabIndex = 96;
            ValorCompraLabel.Text = "Costo:";
            // 
            // VolumenLabel
            // 
            VolumenLabel.AutoSize = true;
            VolumenLabel.Location = new System.Drawing.Point(330, 143);
            VolumenLabel.Name = "VolumenLabel";
            VolumenLabel.Size = new System.Drawing.Size(51, 13);
            VolumenLabel.TabIndex = 100;
            VolumenLabel.Text = "Volumen:";
            // 
            // EstadoDescripcionLabel
            // 
            EstadoDescripcionLabel.AutoSize = true;
            EstadoDescripcionLabel.Location = new System.Drawing.Point(71, 172);
            EstadoDescripcionLabel.Name = "EstadoDescripcionLabel";
            EstadoDescripcionLabel.Size = new System.Drawing.Size(43, 13);
            EstadoDescripcionLabel.TabIndex = 102;
            EstadoDescripcionLabel.Text = "Estado:";
            // 
            // monedaLabel1
            // 
            monedaLabel1.AutoSize = true;
            monedaLabel1.Location = new System.Drawing.Point(65, 92);
            monedaLabel1.Name = "monedaLabel1";
            monedaLabel1.Size = new System.Drawing.Size(49, 13);
            monedaLabel1.TabIndex = 120;
            monedaLabel1.Text = "Moneda:";
            // 
            // fechaAltaLabel1
            // 
            fechaAltaLabel1.AutoSize = true;
            fechaAltaLabel1.Location = new System.Drawing.Point(52, 118);
            fechaAltaLabel1.Name = "fechaAltaLabel1";
            fechaAltaLabel1.Size = new System.Drawing.Size(61, 13);
            fechaAltaLabel1.TabIndex = 121;
            fechaAltaLabel1.Text = "Fecha Alta:";
            // 
            // fechaCompraLabel
            // 
            fechaCompraLabel.AutoSize = true;
            fechaCompraLabel.Location = new System.Drawing.Point(33, 143);
            fechaCompraLabel.Name = "fechaCompraLabel";
            fechaCompraLabel.Size = new System.Drawing.Size(79, 13);
            fechaCompraLabel.TabIndex = 122;
            fechaCompraLabel.Text = "Fecha Compra:";
            // 
            // DireccionTextBox
            // 
            this.DireccionTextBox.Location = new System.Drawing.Point(120, 331);
            this.DireccionTextBox.Name = "DireccionTextBox";
            this.DireccionTextBox.ReadOnly = true;
            this.DireccionTextBox.Size = new System.Drawing.Size(368, 20);
            this.DireccionTextBox.TabIndex = 119;
            // 
            // CancelarButton
            // 
            this.CancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarButton.Location = new System.Drawing.Point(412, 433);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 115;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // AceptarButton
            // 
            this.AceptarButton.Location = new System.Drawing.Point(330, 433);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(75, 23);
            this.AceptarButton.TabIndex = 114;
            this.AceptarButton.Text = "Aceptar";
            this.AceptarButton.UseVisualStyleBackColor = true;
            this.AceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // UbicacionComboBox
            // 
            this.UbicacionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UbicacionComboBox.FormattingEnabled = true;
            this.UbicacionComboBox.Location = new System.Drawing.Point(120, 304);
            this.UbicacionComboBox.Name = "UbicacionComboBox";
            this.UbicacionComboBox.Size = new System.Drawing.Size(368, 21);
            this.UbicacionComboBox.TabIndex = 16;
            // 
            // SectorComboBox
            // 
            this.SectorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SectorComboBox.FormattingEnabled = true;
            this.SectorComboBox.Location = new System.Drawing.Point(120, 250);
            this.SectorComboBox.Name = "SectorComboBox";
            this.SectorComboBox.Size = new System.Drawing.Size(368, 21);
            this.SectorComboBox.TabIndex = 14;
            // 
            // OrganizacionComboBox
            // 
            this.OrganizacionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OrganizacionComboBox.FormattingEnabled = true;
            this.OrganizacionComboBox.Location = new System.Drawing.Point(120, 223);
            this.OrganizacionComboBox.Name = "OrganizacionComboBox";
            this.OrganizacionComboBox.Size = new System.Drawing.Size(368, 21);
            this.OrganizacionComboBox.TabIndex = 13;
            // 
            // MarcaComboBox
            // 
            this.MarcaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MarcaComboBox.FormattingEnabled = true;
            this.MarcaComboBox.Location = new System.Drawing.Point(120, 196);
            this.MarcaComboBox.Name = "MarcaComboBox";
            this.MarcaComboBox.Size = new System.Drawing.Size(368, 21);
            this.MarcaComboBox.TabIndex = 12;
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(120, 37);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(368, 20);
            this.DescripcionTextBox.TabIndex = 2;
            // 
            // NumeroInventarioTextBox
            // 
            this.NumeroInventarioTextBox.Location = new System.Drawing.Point(120, 11);
            this.NumeroInventarioTextBox.Name = "NumeroInventarioTextBox";
            this.NumeroInventarioTextBox.Size = new System.Drawing.Size(368, 20);
            this.NumeroInventarioTextBox.TabIndex = 1;
            // 
            // NumeroSerieTextBox
            // 
            this.NumeroSerieTextBox.Location = new System.Drawing.Point(120, 63);
            this.NumeroSerieTextBox.Name = "NumeroSerieTextBox";
            this.NumeroSerieTextBox.Size = new System.Drawing.Size(368, 20);
            this.NumeroSerieTextBox.TabIndex = 3;
            // 
            // ObservacionesTextBox
            // 
            this.ObservacionesTextBox.Location = new System.Drawing.Point(120, 357);
            this.ObservacionesTextBox.Multiline = true;
            this.ObservacionesTextBox.Name = "ObservacionesTextBox";
            this.ObservacionesTextBox.Size = new System.Drawing.Size(368, 60);
            this.ObservacionesTextBox.TabIndex = 17;
            // 
            // PeriodoGarantiaTextBox
            // 
            this.PeriodoGarantiaTextBox.Location = new System.Drawing.Point(387, 115);
            this.PeriodoGarantiaTextBox.Name = "PeriodoGarantiaTextBox";
            this.PeriodoGarantiaTextBox.Size = new System.Drawing.Size(101, 20);
            this.PeriodoGarantiaTextBox.TabIndex = 7;
            // 
            // ValorCompraTextBox
            // 
            this.ValorCompraTextBox.Location = new System.Drawing.Point(388, 89);
            this.ValorCompraTextBox.Name = "ValorCompraTextBox";
            this.ValorCompraTextBox.Size = new System.Drawing.Size(100, 20);
            this.ValorCompraTextBox.TabIndex = 5;
            // 
            // VolumenTextBox
            // 
            this.VolumenTextBox.Location = new System.Drawing.Point(387, 141);
            this.VolumenTextBox.Name = "VolumenTextBox";
            this.VolumenTextBox.Size = new System.Drawing.Size(99, 20);
            this.VolumenTextBox.TabIndex = 8;
            // 
            // TipoComboBox
            // 
            this.TipoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoComboBox.FormattingEnabled = true;
            this.TipoComboBox.Location = new System.Drawing.Point(121, 278);
            this.TipoComboBox.Name = "TipoComboBox";
            this.TipoComboBox.Size = new System.Drawing.Size(367, 21);
            this.TipoComboBox.TabIndex = 15;
            // 
            // EstadoComboBox
            // 
            this.EstadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EstadoComboBox.FormattingEnabled = true;
            this.EstadoComboBox.Location = new System.Drawing.Point(120, 169);
            this.EstadoComboBox.Name = "EstadoComboBox";
            this.EstadoComboBox.Size = new System.Drawing.Size(368, 21);
            this.EstadoComboBox.TabIndex = 11;
            // 
            // bsEditado
            // 
            this.bsEditado.DataSource = typeof(BEL.ActivoBEL);
            // 
            // monedaComboBox
            // 
            this.monedaComboBox.CausesValidation = false;
            this.monedaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsEditado, "FechaAlta", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.monedaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monedaComboBox.FormattingEnabled = true;
            this.monedaComboBox.Location = new System.Drawing.Point(119, 89);
            this.monedaComboBox.Name = "monedaComboBox";
            this.monedaComboBox.Size = new System.Drawing.Size(96, 21);
            this.monedaComboBox.TabIndex = 121;
            this.monedaComboBox.SelectedIndexChanged += new System.EventHandler(this.monedaComboBox_SelectedIndexChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // fechaAltaDateTimePicker
            // 
            this.fechaAltaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsEditado, "FechaAlta", true));
            this.fechaAltaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsEditado, "FechaAlta", true));
            this.fechaAltaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaAltaDateTimePicker.Location = new System.Drawing.Point(119, 116);
            this.fechaAltaDateTimePicker.Name = "fechaAltaDateTimePicker";
            this.fechaAltaDateTimePicker.Size = new System.Drawing.Size(96, 20);
            this.fechaAltaDateTimePicker.TabIndex = 122;
            // 
            // fechaCompraDateTimePicker
            // 
            this.fechaCompraDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsEditado, "FechaCompra", true));
            this.fechaCompraDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsEditado, "FechaCompra", true));
            this.fechaCompraDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaCompraDateTimePicker.Location = new System.Drawing.Point(118, 140);
            this.fechaCompraDateTimePicker.Name = "fechaCompraDateTimePicker";
            this.fechaCompraDateTimePicker.Size = new System.Drawing.Size(97, 20);
            this.fechaCompraDateTimePicker.TabIndex = 123;
            // 
            // ActivoEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 476);
            this.Controls.Add(fechaCompraLabel);
            this.Controls.Add(this.fechaCompraDateTimePicker);
            this.Controls.Add(fechaAltaLabel1);
            this.Controls.Add(this.fechaAltaDateTimePicker);
            this.Controls.Add(monedaLabel1);
            this.Controls.Add(this.monedaComboBox);
            this.Controls.Add(this.TipoComboBox);
            this.Controls.Add(Label1);
            this.Controls.Add(this.DireccionTextBox);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.AceptarButton);
            this.Controls.Add(UbicacionDescripcionLabel1);
            this.Controls.Add(this.UbicacionComboBox);
            this.Controls.Add(TipoDescripcionLabel1);
            this.Controls.Add(SectorNombreLabel);
            this.Controls.Add(this.SectorComboBox);
            this.Controls.Add(RazonSocialLabel);
            this.Controls.Add(this.OrganizacionComboBox);
            this.Controls.Add(MarcaNombreLabel);
            this.Controls.Add(this.MarcaComboBox);
            this.Controls.Add(EstadoDescripcionLabel);
            this.Controls.Add(this.EstadoComboBox);
            this.Controls.Add(DescripcionLabel);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(NumeroInventarioLabel);
            this.Controls.Add(this.NumeroInventarioTextBox);
            this.Controls.Add(NumeroSerieLabel);
            this.Controls.Add(this.NumeroSerieTextBox);
            this.Controls.Add(ObservacionesLabel);
            this.Controls.Add(this.ObservacionesTextBox);
            this.Controls.Add(PeriodoGarantiaLabel);
            this.Controls.Add(this.PeriodoGarantiaTextBox);
            this.Controls.Add(ValorCompraLabel);
            this.Controls.Add(this.ValorCompraTextBox);
            this.Controls.Add(VolumenLabel);
            this.Controls.Add(this.VolumenTextBox);
            this.Name = "ActivoEditForm";
            this.Text = "Edición Activo";
            this.Load += new System.EventHandler(this.ActivoABMForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsEditado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox DireccionTextBox;
        internal System.Windows.Forms.Button CancelarButton;
        internal System.Windows.Forms.Button AceptarButton;
        internal System.Windows.Forms.ComboBox UbicacionComboBox;
        internal System.Windows.Forms.ComboBox SectorComboBox;
        internal System.Windows.Forms.ComboBox OrganizacionComboBox;
        internal System.Windows.Forms.ComboBox MarcaComboBox;
        internal System.Windows.Forms.TextBox DescripcionTextBox;
        internal System.Windows.Forms.TextBox NumeroInventarioTextBox;
        internal System.Windows.Forms.TextBox NumeroSerieTextBox;
        internal System.Windows.Forms.TextBox ObservacionesTextBox;
        internal System.Windows.Forms.TextBox PeriodoGarantiaTextBox;
        internal System.Windows.Forms.TextBox ValorCompraTextBox;
        internal System.Windows.Forms.TextBox VolumenTextBox;
        private System.Windows.Forms.ComboBox TipoComboBox;
        public System.Windows.Forms.BindingSource bsEditado;
        internal System.Windows.Forms.ComboBox EstadoComboBox;
        private System.Windows.Forms.ComboBox monedaComboBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DateTimePicker fechaCompraDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaAltaDateTimePicker;
    }
}