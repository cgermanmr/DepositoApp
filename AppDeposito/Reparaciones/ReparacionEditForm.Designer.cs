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
            descripcionLabel.Location = new System.Drawing.Point(122, 362);
            descripcionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(47, 20);
            descripcionLabel.TabIndex = 0;
            descripcionLabel.Text = "Falla:";
            // 
            // ticketSoporteLabel
            // 
            ticketSoporteLabel.AutoSize = true;
            ticketSoporteLabel.Location = new System.Drawing.Point(50, 471);
            ticketSoporteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ticketSoporteLabel.Name = "ticketSoporteLabel";
            ticketSoporteLabel.Size = new System.Drawing.Size(116, 20);
            ticketSoporteLabel.TabIndex = 14;
            ticketSoporteLabel.Text = "Ticket Soporte:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(45, 286);
            nombreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(121, 20);
            nombreLabel.TabIndex = 15;
            nombreLabel.Text = "Usuario/Cliente:";
            // 
            // numeroInventarioLabel
            // 
            numeroInventarioLabel.AutoSize = true;
            numeroInventarioLabel.Location = new System.Drawing.Point(24, 122);
            numeroInventarioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            numeroInventarioLabel.Name = "numeroInventarioLabel";
            numeroInventarioLabel.Size = new System.Drawing.Size(143, 20);
            numeroInventarioLabel.TabIndex = 16;
            numeroInventarioLabel.Text = "Numero Inventario:";
            // 
            // descripcionLabel1
            // 
            descripcionLabel1.AutoSize = true;
            descripcionLabel1.Location = new System.Drawing.Point(70, 162);
            descripcionLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descripcionLabel1.Name = "descripcionLabel1";
            descripcionLabel1.Size = new System.Drawing.Size(96, 20);
            descripcionLabel1.TabIndex = 19;
            descripcionLabel1.Text = "Descripcion:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(92, 322);
            telefonoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(75, 20);
            telefonoLabel.TabIndex = 20;
            telefonoLabel.Text = "Telefono:";
            // 
            // fechaSolicitudLabel
            // 
            fechaSolicitudLabel.AutoSize = true;
            fechaSolicitudLabel.Location = new System.Drawing.Point(45, 32);
            fechaSolicitudLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fechaSolicitudLabel.Name = "fechaSolicitudLabel";
            fechaSolicitudLabel.Size = new System.Drawing.Size(122, 20);
            fechaSolicitudLabel.TabIndex = 23;
            fechaSolicitudLabel.Text = "Fecha Solicitud:";
            // 
            // descripcionLabel2
            // 
            descripcionLabel2.AutoSize = true;
            descripcionLabel2.Location = new System.Drawing.Point(122, 202);
            descripcionLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descripcionLabel2.Name = "descripcionLabel2";
            descripcionLabel2.Size = new System.Drawing.Size(43, 20);
            descripcionLabel2.TabIndex = 30;
            descripcionLabel2.Text = "Tipo:";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReparacion, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(178, 362);
            this.descripcionTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.descripcionTextBox.MaxLength = 200;
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(514, 72);
            this.descripcionTextBox.TabIndex = 1;
            // 
            // bsReparacion
            // 
            this.bsReparacion.DataSource = typeof(BEL.ReparacionBEL);
            // 
            // ticketSoporteTextBox
            // 
            this.ticketSoporteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReparacion, "TicketSoporte", true));
            this.ticketSoporteTextBox.Location = new System.Drawing.Point(178, 465);
            this.ticketSoporteTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ticketSoporteTextBox.MaxLength = 9;
            this.ticketSoporteTextBox.Name = "ticketSoporteTextBox";
            this.ticketSoporteTextBox.Size = new System.Drawing.Size(148, 26);
            this.ticketSoporteTextBox.TabIndex = 15;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReparacion, "Solicitante", true));
            this.nombreTextBox.Location = new System.Drawing.Point(178, 282);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.ReadOnly = true;
            this.nombreTextBox.Size = new System.Drawing.Size(322, 26);
            this.nombreTextBox.TabIndex = 16;
            // 
            // numeroInventarioTextBox
            // 
            this.numeroInventarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReparacion, "Activo.Inventario", true));
            this.numeroInventarioTextBox.Location = new System.Drawing.Point(178, 117);
            this.numeroInventarioTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numeroInventarioTextBox.Name = "numeroInventarioTextBox";
            this.numeroInventarioTextBox.ReadOnly = true;
            this.numeroInventarioTextBox.Size = new System.Drawing.Size(148, 26);
            this.numeroInventarioTextBox.TabIndex = 17;
            // 
            // enGarantiaCheckBox
            // 
            this.enGarantiaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsReparacion, "Activo.EnGarantia", true));
            this.enGarantiaCheckBox.Enabled = false;
            this.enGarantiaCheckBox.Location = new System.Drawing.Point(338, 117);
            this.enGarantiaCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enGarantiaCheckBox.Name = "enGarantiaCheckBox";
            this.enGarantiaCheckBox.Size = new System.Drawing.Size(156, 37);
            this.enGarantiaCheckBox.TabIndex = 18;
            this.enGarantiaCheckBox.Text = "En garantía";
            this.enGarantiaCheckBox.UseVisualStyleBackColor = true;
            // 
            // descripcionTextBox1
            // 
            this.descripcionTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReparacion, "Activo.Descripcion", true));
            this.descripcionTextBox1.Location = new System.Drawing.Point(178, 157);
            this.descripcionTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.descripcionTextBox1.Name = "descripcionTextBox1";
            this.descripcionTextBox1.ReadOnly = true;
            this.descripcionTextBox1.Size = new System.Drawing.Size(322, 26);
            this.descripcionTextBox1.TabIndex = 20;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReparacion, "Solicitante.Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(178, 322);
            this.telefonoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.ReadOnly = true;
            this.telefonoTextBox.Size = new System.Drawing.Size(322, 26);
            this.telefonoTextBox.TabIndex = 21;
            // 
            // fechaFinalizacionDateTimePicker
            // 
            this.fechaFinalizacionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsReparacion, "FechaFinalizacion", true));
            this.fechaFinalizacionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaFinalizacionDateTimePicker.Location = new System.Drawing.Point(358, 465);
            this.fechaFinalizacionDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fechaFinalizacionDateTimePicker.Name = "fechaFinalizacionDateTimePicker";
            this.fechaFinalizacionDateTimePicker.Size = new System.Drawing.Size(142, 26);
            this.fechaFinalizacionDateTimePicker.TabIndex = 23;
            // 
            // fechaSolicitudDateTimePicker
            // 
            this.fechaSolicitudDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsReparacion, "FechaSolicitud", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.fechaSolicitudDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaSolicitudDateTimePicker.Location = new System.Drawing.Point(178, 32);
            this.fechaSolicitudDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fechaSolicitudDateTimePicker.Name = "fechaSolicitudDateTimePicker";
            this.fechaSolicitudDateTimePicker.Size = new System.Drawing.Size(121, 26);
            this.fechaSolicitudDateTimePicker.TabIndex = 24;
            // 
            // ActivoBuscarButton
            // 
            this.ActivoBuscarButton.Location = new System.Drawing.Point(178, 72);
            this.ActivoBuscarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ActivoBuscarButton.Name = "ActivoBuscarButton";
            this.ActivoBuscarButton.Size = new System.Drawing.Size(324, 35);
            this.ActivoBuscarButton.TabIndex = 25;
            this.ActivoBuscarButton.Text = "Buscar Activo";
            this.ActivoBuscarButton.UseVisualStyleBackColor = true;
            this.ActivoBuscarButton.Click += new System.EventHandler(this.ActivoBuscarButton_Click);
            // 
            // ClienteBuscarButton
            // 
            this.ClienteBuscarButton.Location = new System.Drawing.Point(178, 237);
            this.ClienteBuscarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClienteBuscarButton.Name = "ClienteBuscarButton";
            this.ClienteBuscarButton.Size = new System.Drawing.Size(324, 35);
            this.ClienteBuscarButton.TabIndex = 26;
            this.ClienteBuscarButton.Text = "Buscar Cliente";
            this.ClienteBuscarButton.UseVisualStyleBackColor = true;
            this.ClienteBuscarButton.Click += new System.EventHandler(this.ClienteBuscarButton_Click);
            // 
            // AceptarButton
            // 
            this.AceptarButton.Location = new System.Drawing.Point(456, 535);
            this.AceptarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(112, 35);
            this.AceptarButton.TabIndex = 27;
            this.AceptarButton.Text = "Aceptar";
            this.AceptarButton.UseVisualStyleBackColor = true;
            this.AceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(578, 535);
            this.CancelarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(112, 35);
            this.CancelarButton.TabIndex = 28;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // realizadaCheckBox
            // 
            this.realizadaCheckBox.AutoSize = true;
            this.realizadaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsReparacion, "Realizada", true));
            this.realizadaCheckBox.Location = new System.Drawing.Point(512, 465);
            this.realizadaCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.realizadaCheckBox.Name = "realizadaCheckBox";
            this.realizadaCheckBox.Size = new System.Drawing.Size(99, 24);
            this.realizadaCheckBox.TabIndex = 30;
            this.realizadaCheckBox.Text = "Realizada";
            this.realizadaCheckBox.UseVisualStyleBackColor = true;
            this.realizadaCheckBox.CheckedChanged += new System.EventHandler(this.realizadaCheckBox_CheckedChanged);
            // 
            // descripcionTextBox2
            // 
            this.descripcionTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReparacion, "Activo.TipoActivo.Descripcion", true));
            this.descripcionTextBox2.Location = new System.Drawing.Point(178, 197);
            this.descripcionTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.descripcionTextBox2.Name = "descripcionTextBox2";
            this.descripcionTextBox2.ReadOnly = true;
            this.descripcionTextBox2.Size = new System.Drawing.Size(322, 26);
            this.descripcionTextBox2.TabIndex = 31;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ReparacionEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(732, 620);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
    }
}