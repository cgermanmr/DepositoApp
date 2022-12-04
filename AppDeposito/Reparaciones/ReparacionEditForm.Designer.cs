namespace AppDeposito
{
    partial class ReparacionEditForm
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
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label ticketSoporteLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label numeroInventarioLabel;
            System.Windows.Forms.Label descripcionLabel1;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label fechaSolicitudLabel;
            System.Windows.Forms.Label descripcionLabel2;
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.bsReparacion = new System.Windows.Forms.BindingSource(this.components);
            this.ticketSoporteTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.numeroInventarioTextBox = new System.Windows.Forms.TextBox();
            this.enGarantiaCheckBox = new System.Windows.Forms.CheckBox();
            this.descripcionTextBox1 = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.fechaFinalizacionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaSolicitudDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ActivoBuscarButton = new System.Windows.Forms.Button();
            this.ClienteBuscarButton = new System.Windows.Forms.Button();
            this.AceptarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.realizadaCheckBox = new System.Windows.Forms.CheckBox();
            this.descripcionTextBox2 = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            descripcionLabel = new System.Windows.Forms.Label();
            ticketSoporteLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            numeroInventarioLabel = new System.Windows.Forms.Label();
            descripcionLabel1 = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            fechaSolicitudLabel = new System.Windows.Forms.Label();
            descripcionLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsReparacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(81, 235);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(32, 13);
            descripcionLabel.TabIndex = 0;
            descripcionLabel.Text = "Falla:";
            // 
            // ticketSoporteLabel
            // 
            ticketSoporteLabel.AutoSize = true;
            ticketSoporteLabel.Location = new System.Drawing.Point(33, 306);
            ticketSoporteLabel.Name = "ticketSoporteLabel";
            ticketSoporteLabel.Size = new System.Drawing.Size(80, 13);
            ticketSoporteLabel.TabIndex = 14;
            ticketSoporteLabel.Text = "Ticket Soporte:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(30, 186);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(83, 13);
            nombreLabel.TabIndex = 15;
            nombreLabel.Text = "Usuario/Cliente:";
            // 
            // numeroInventarioLabel
            // 
            numeroInventarioLabel.AutoSize = true;
            numeroInventarioLabel.Location = new System.Drawing.Point(16, 79);
            numeroInventarioLabel.Name = "numeroInventarioLabel";
            numeroInventarioLabel.Size = new System.Drawing.Size(97, 13);
            numeroInventarioLabel.TabIndex = 16;
            numeroInventarioLabel.Text = "Numero Inventario:";
            // 
            // descripcionLabel1
            // 
            descripcionLabel1.AutoSize = true;
            descripcionLabel1.Location = new System.Drawing.Point(47, 105);
            descripcionLabel1.Name = "descripcionLabel1";
            descripcionLabel1.Size = new System.Drawing.Size(66, 13);
            descripcionLabel1.TabIndex = 19;
            descripcionLabel1.Text = "Descripcion:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(61, 209);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 20;
            telefonoLabel.Text = "Telefono:";
            // 
            // fechaSolicitudLabel
            // 
            fechaSolicitudLabel.AutoSize = true;
            fechaSolicitudLabel.Location = new System.Drawing.Point(30, 21);
            fechaSolicitudLabel.Name = "fechaSolicitudLabel";
            fechaSolicitudLabel.Size = new System.Drawing.Size(83, 13);
            fechaSolicitudLabel.TabIndex = 23;
            fechaSolicitudLabel.Text = "Fecha Solicitud:";
            // 
            // descripcionLabel2
            // 
            descripcionLabel2.AutoSize = true;
            descripcionLabel2.Location = new System.Drawing.Point(81, 131);
            descripcionLabel2.Name = "descripcionLabel2";
            descripcionLabel2.Size = new System.Drawing.Size(31, 13);
            descripcionLabel2.TabIndex = 30;
            descripcionLabel2.Text = "Tipo:";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReparacion, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(119, 235);
            this.descripcionTextBox.MaxLength = 200;
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(344, 48);
            this.descripcionTextBox.TabIndex = 1;
            // 
            // bsReparacion
            // 
            this.bsReparacion.DataSource = typeof(BEL.ReparacionBEL);
            // 
            // ticketSoporteTextBox
            // 
            this.ticketSoporteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReparacion, "TicketSoporte", true));
            this.ticketSoporteTextBox.Location = new System.Drawing.Point(119, 302);
            this.ticketSoporteTextBox.MaxLength = 9;
            this.ticketSoporteTextBox.Name = "ticketSoporteTextBox";
            this.ticketSoporteTextBox.Size = new System.Drawing.Size(100, 20);
            this.ticketSoporteTextBox.TabIndex = 15;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReparacion, "Solicitante", true));
            this.nombreTextBox.Location = new System.Drawing.Point(119, 183);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.ReadOnly = true;
            this.nombreTextBox.Size = new System.Drawing.Size(216, 20);
            this.nombreTextBox.TabIndex = 16;
            // 
            // numeroInventarioTextBox
            // 
            this.numeroInventarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReparacion, "Activo.Inventario", true));
            this.numeroInventarioTextBox.Location = new System.Drawing.Point(119, 76);
            this.numeroInventarioTextBox.Name = "numeroInventarioTextBox";
            this.numeroInventarioTextBox.ReadOnly = true;
            this.numeroInventarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.numeroInventarioTextBox.TabIndex = 17;
            // 
            // enGarantiaCheckBox
            // 
            this.enGarantiaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsReparacion, "Activo.EnGarantia", true));
            this.enGarantiaCheckBox.Enabled = false;
            this.enGarantiaCheckBox.Location = new System.Drawing.Point(225, 76);
            this.enGarantiaCheckBox.Name = "enGarantiaCheckBox";
            this.enGarantiaCheckBox.Size = new System.Drawing.Size(104, 24);
            this.enGarantiaCheckBox.TabIndex = 18;
            this.enGarantiaCheckBox.Text = "Garantia";
            this.enGarantiaCheckBox.UseVisualStyleBackColor = true;
            // 
            // descripcionTextBox1
            // 
            this.descripcionTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReparacion, "Activo.Descripcion", true));
            this.descripcionTextBox1.Location = new System.Drawing.Point(119, 102);
            this.descripcionTextBox1.Name = "descripcionTextBox1";
            this.descripcionTextBox1.ReadOnly = true;
            this.descripcionTextBox1.Size = new System.Drawing.Size(216, 20);
            this.descripcionTextBox1.TabIndex = 20;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReparacion, "Solicitante.Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(119, 209);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.ReadOnly = true;
            this.telefonoTextBox.Size = new System.Drawing.Size(216, 20);
            this.telefonoTextBox.TabIndex = 21;
            // 
            // fechaFinalizacionDateTimePicker
            // 
            this.fechaFinalizacionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsReparacion, "FechaFinalizacion", true));
            this.fechaFinalizacionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaFinalizacionDateTimePicker.Location = new System.Drawing.Point(239, 302);
            this.fechaFinalizacionDateTimePicker.Name = "fechaFinalizacionDateTimePicker";
            this.fechaFinalizacionDateTimePicker.Size = new System.Drawing.Size(96, 20);
            this.fechaFinalizacionDateTimePicker.TabIndex = 23;
            // 
            // fechaSolicitudDateTimePicker
            // 
            this.fechaSolicitudDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsReparacion, "FechaSolicitud", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.fechaSolicitudDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaSolicitudDateTimePicker.Location = new System.Drawing.Point(119, 21);
            this.fechaSolicitudDateTimePicker.Name = "fechaSolicitudDateTimePicker";
            this.fechaSolicitudDateTimePicker.Size = new System.Drawing.Size(82, 20);
            this.fechaSolicitudDateTimePicker.TabIndex = 24;
            // 
            // ActivoBuscarButton
            // 
            this.ActivoBuscarButton.Location = new System.Drawing.Point(119, 47);
            this.ActivoBuscarButton.Name = "ActivoBuscarButton";
            this.ActivoBuscarButton.Size = new System.Drawing.Size(216, 23);
            this.ActivoBuscarButton.TabIndex = 25;
            this.ActivoBuscarButton.Text = "Buscar Activo";
            this.ActivoBuscarButton.UseVisualStyleBackColor = true;
            this.ActivoBuscarButton.Click += new System.EventHandler(this.ActivoBuscarButton_Click);
            // 
            // ClienteBuscarButton
            // 
            this.ClienteBuscarButton.Location = new System.Drawing.Point(119, 154);
            this.ClienteBuscarButton.Name = "ClienteBuscarButton";
            this.ClienteBuscarButton.Size = new System.Drawing.Size(216, 23);
            this.ClienteBuscarButton.TabIndex = 26;
            this.ClienteBuscarButton.Text = "Buscar Cliente";
            this.ClienteBuscarButton.UseVisualStyleBackColor = true;
            this.ClienteBuscarButton.Click += new System.EventHandler(this.ClienteBuscarButton_Click);
            // 
            // AceptarButton
            // 
            this.AceptarButton.Location = new System.Drawing.Point(304, 348);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(75, 23);
            this.AceptarButton.TabIndex = 27;
            this.AceptarButton.Text = "Aceptar";
            this.AceptarButton.UseVisualStyleBackColor = true;
            this.AceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(385, 348);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 28;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // realizadaCheckBox
            // 
            this.realizadaCheckBox.AutoSize = true;
            this.realizadaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsReparacion, "Realizada", true));
            this.realizadaCheckBox.Location = new System.Drawing.Point(341, 302);
            this.realizadaCheckBox.Name = "realizadaCheckBox";
            this.realizadaCheckBox.Size = new System.Drawing.Size(73, 17);
            this.realizadaCheckBox.TabIndex = 30;
            this.realizadaCheckBox.Text = "Realizada";
            this.realizadaCheckBox.UseVisualStyleBackColor = true;
            this.realizadaCheckBox.CheckedChanged += new System.EventHandler(this.realizadaCheckBox_CheckedChanged);
            // 
            // descripcionTextBox2
            // 
            this.descripcionTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReparacion, "Activo.TipoActivo.Descripcion", true));
            this.descripcionTextBox2.Location = new System.Drawing.Point(119, 128);
            this.descripcionTextBox2.Name = "descripcionTextBox2";
            this.descripcionTextBox2.ReadOnly = true;
            this.descripcionTextBox2.Size = new System.Drawing.Size(216, 20);
            this.descripcionTextBox2.TabIndex = 31;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Agregar Reemplazo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReparacionEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(488, 389);
            this.Controls.Add(this.button1);
            this.Controls.Add(descripcionLabel2);
            this.Controls.Add(this.descripcionTextBox2);
            this.Controls.Add(this.realizadaCheckBox);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.AceptarButton);
            this.Controls.Add(this.ClienteBuscarButton);
            this.Controls.Add(this.ActivoBuscarButton);
            this.Controls.Add(fechaSolicitudLabel);
            this.Controls.Add(this.fechaSolicitudDateTimePicker);
            this.Controls.Add(this.fechaFinalizacionDateTimePicker);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(descripcionLabel1);
            this.Controls.Add(this.descripcionTextBox1);
            this.Controls.Add(this.enGarantiaCheckBox);
            this.Controls.Add(numeroInventarioLabel);
            this.Controls.Add(this.numeroInventarioTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(ticketSoporteLabel);
            this.Controls.Add(this.ticketSoporteTextBox);
            this.Name = "ReparacionEditForm";
            this.Text = "Editar Reparación";
            this.Load += new System.EventHandler(this.EdicionReparacionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsReparacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsReparacion;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox ticketSoporteTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox numeroInventarioTextBox;
        private System.Windows.Forms.CheckBox enGarantiaCheckBox;
        private System.Windows.Forms.TextBox descripcionTextBox1;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.DateTimePicker fechaFinalizacionDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaSolicitudDateTimePicker;
        private System.Windows.Forms.Button ActivoBuscarButton;
        private System.Windows.Forms.Button ClienteBuscarButton;
        private System.Windows.Forms.Button AceptarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.CheckBox realizadaCheckBox;
        private System.Windows.Forms.TextBox descripcionTextBox2;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button button1;
    }
}