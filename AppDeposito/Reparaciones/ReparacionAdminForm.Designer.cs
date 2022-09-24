namespace AppDeposito
{
    partial class ReparacionAdminForm
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
            System.Windows.Forms.Label fechaFinalizacionLabel;
            System.Windows.Forms.Label fechaSolicitudLabel;
            System.Windows.Forms.Label observacionesLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label numeroInventarioLabel;
            System.Windows.Forms.Label ticketSoporteLabel;
            System.Windows.Forms.Label descripcionLabel1;
            this.Button2 = new System.Windows.Forms.Button();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.estadoCheckBox = new System.Windows.Forms.CheckBox();
            this.bsReparaciones = new System.Windows.Forms.BindingSource(this.components);
            this.fechaFinalizacionTextBox = new System.Windows.Forms.TextBox();
            this.fechaSolicitudTextBox = new System.Windows.Forms.TextBox();
            this.numeroInventarioTextBox = new System.Windows.Forms.TextBox();
            this.txtDescripcionActivo = new System.Windows.Forms.TextBox();
            this.btnPresupuestos = new System.Windows.Forms.Button();
            this.ticketSoporteTextBox = new System.Windows.Forms.TextBox();
            this.enGarantiaCheckBox = new System.Windows.Forms.CheckBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.observacionesTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.GrillaReparaciones = new System.Windows.Forms.DataGridView();
            this.solicitanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPresupuestos = new System.Windows.Forms.BindingSource(this.components);
            descripcionLabel = new System.Windows.Forms.Label();
            fechaFinalizacionLabel = new System.Windows.Forms.Label();
            fechaSolicitudLabel = new System.Windows.Forms.Label();
            observacionesLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            numeroInventarioLabel = new System.Windows.Forms.Label();
            ticketSoporteLabel = new System.Windows.Forms.Label();
            descripcionLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsReparaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaReparaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPresupuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(91, 77);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(32, 13);
            descripcionLabel.TabIndex = 4;
            descripcionLabel.Text = "Falla:";
            // 
            // fechaFinalizacionLabel
            // 
            fechaFinalizacionLabel.AutoSize = true;
            fechaFinalizacionLabel.Location = new System.Drawing.Point(383, 123);
            fechaFinalizacionLabel.Name = "fechaFinalizacionLabel";
            fechaFinalizacionLabel.Size = new System.Drawing.Size(65, 13);
            fechaFinalizacionLabel.TabIndex = 8;
            fechaFinalizacionLabel.Text = "Finalización:";
            // 
            // fechaSolicitudLabel
            // 
            fechaSolicitudLabel.AutoSize = true;
            fechaSolicitudLabel.Location = new System.Drawing.Point(242, 123);
            fechaSolicitudLabel.Name = "fechaSolicitudLabel";
            fechaSolicitudLabel.Size = new System.Drawing.Size(50, 13);
            fechaSolicitudLabel.TabIndex = 16;
            fechaSolicitudLabel.Text = "Solicitud:";
            // 
            // observacionesLabel
            // 
            observacionesLabel.AutoSize = true;
            observacionesLabel.Location = new System.Drawing.Point(42, 146);
            observacionesLabel.Name = "observacionesLabel";
            observacionesLabel.Size = new System.Drawing.Size(81, 13);
            observacionesLabel.TabIndex = 19;
            observacionesLabel.Text = "Observaciones:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(40, 48);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(83, 13);
            nombreLabel.TabIndex = 21;
            nombreLabel.Text = "Usuario/Cliente:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(426, 48);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 23;
            telefonoLabel.Text = "Telefono:";
            // 
            // numeroInventarioLabel
            // 
            numeroInventarioLabel.AutoSize = true;
            numeroInventarioLabel.Location = new System.Drawing.Point(26, 22);
            numeroInventarioLabel.Name = "numeroInventarioLabel";
            numeroInventarioLabel.Size = new System.Drawing.Size(57, 13);
            numeroInventarioLabel.TabIndex = 25;
            numeroInventarioLabel.Text = "Inventario:";
            // 
            // ticketSoporteLabel
            // 
            ticketSoporteLabel.AutoSize = true;
            ticketSoporteLabel.Location = new System.Drawing.Point(44, 120);
            ticketSoporteLabel.Name = "ticketSoporteLabel";
            ticketSoporteLabel.Size = new System.Drawing.Size(80, 13);
            ticketSoporteLabel.TabIndex = 28;
            ticketSoporteLabel.Text = "Ticket Soporte:";
            // 
            // descripcionLabel1
            // 
            descripcionLabel1.AutoSize = true;
            descripcionLabel1.Location = new System.Drawing.Point(235, 22);
            descripcionLabel1.Name = "descripcionLabel1";
            descripcionLabel1.Size = new System.Drawing.Size(66, 13);
            descripcionLabel1.TabIndex = 32;
            descripcionLabel1.Text = "Descripcion:";
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(0, 0);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 23);
            this.Button2.TabIndex = 1;
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer1.Name = "SplitContainer1";
            this.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.AutoScroll = true;
            this.SplitContainer1.Panel1.Controls.Add(this.EliminarButton);
            this.SplitContainer1.Panel1.Controls.Add(this.ModificarButton);
            this.SplitContainer1.Panel1.Controls.Add(this.AgregarButton);
            this.SplitContainer1.Panel1.Controls.Add(this.estadoCheckBox);
            this.SplitContainer1.Panel1.Controls.Add(this.fechaFinalizacionTextBox);
            this.SplitContainer1.Panel1.Controls.Add(this.fechaSolicitudTextBox);
            this.SplitContainer1.Panel1.Controls.Add(this.numeroInventarioTextBox);
            this.SplitContainer1.Panel1.Controls.Add(descripcionLabel1);
            this.SplitContainer1.Panel1.Controls.Add(this.txtDescripcionActivo);
            this.SplitContainer1.Panel1.Controls.Add(fechaFinalizacionLabel);
            this.SplitContainer1.Panel1.Controls.Add(fechaSolicitudLabel);
            this.SplitContainer1.Panel1.Controls.Add(this.btnPresupuestos);
            this.SplitContainer1.Panel1.Controls.Add(ticketSoporteLabel);
            this.SplitContainer1.Panel1.Controls.Add(this.ticketSoporteTextBox);
            this.SplitContainer1.Panel1.Controls.Add(this.enGarantiaCheckBox);
            this.SplitContainer1.Panel1.Controls.Add(numeroInventarioLabel);
            this.SplitContainer1.Panel1.Controls.Add(telefonoLabel);
            this.SplitContainer1.Panel1.Controls.Add(this.telefonoTextBox);
            this.SplitContainer1.Panel1.Controls.Add(nombreLabel);
            this.SplitContainer1.Panel1.Controls.Add(this.nombreTextBox);
            this.SplitContainer1.Panel1.Controls.Add(observacionesLabel);
            this.SplitContainer1.Panel1.Controls.Add(this.observacionesTextBox);
            this.SplitContainer1.Panel1.Controls.Add(descripcionLabel);
            this.SplitContainer1.Panel1.Controls.Add(this.descripcionTextBox);
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.GrillaReparaciones);
            this.SplitContainer1.Size = new System.Drawing.Size(869, 561);
            this.SplitContainer1.SplitterDistance = 270;
            this.SplitContainer1.TabIndex = 2;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(780, 233);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 23);
            this.EliminarButton.TabIndex = 39;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // ModificarButton
            // 
            this.ModificarButton.Location = new System.Drawing.Point(699, 233);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(75, 23);
            this.ModificarButton.TabIndex = 38;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = true;
            this.ModificarButton.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(618, 233);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(75, 23);
            this.AgregarButton.TabIndex = 37;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // estadoCheckBox
            // 
            this.estadoCheckBox.AutoCheck = false;
            this.estadoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsReparaciones, "Estado", true));
            this.estadoCheckBox.Location = new System.Drawing.Point(226, 195);
            this.estadoCheckBox.Name = "estadoCheckBox";
            this.estadoCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.estadoCheckBox.Size = new System.Drawing.Size(144, 24);
            this.estadoCheckBox.TabIndex = 7;
            this.estadoCheckBox.Text = "Reparación autorizada";
            this.estadoCheckBox.UseVisualStyleBackColor = true;
            this.estadoCheckBox.CheckedChanged += new System.EventHandler(this.estadoCheckBox_CheckedChanged);
            // 
            // bsReparaciones
            // 
            this.bsReparaciones.DataSource = typeof(BEL.ReparacionBEL);
            // 
            // fechaFinalizacionTextBox
            // 
            this.fechaFinalizacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReparaciones, "FechaFinalizacion", true));
            this.fechaFinalizacionTextBox.Location = new System.Drawing.Point(454, 120);
            this.fechaFinalizacionTextBox.MaxLength = 10;
            this.fechaFinalizacionTextBox.Name = "fechaFinalizacionTextBox";
            this.fechaFinalizacionTextBox.ReadOnly = true;
            this.fechaFinalizacionTextBox.Size = new System.Drawing.Size(70, 20);
            this.fechaFinalizacionTextBox.TabIndex = 36;
            // 
            // fechaSolicitudTextBox
            // 
            this.fechaSolicitudTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReparaciones, "FechaSolicitud", true));
            this.fechaSolicitudTextBox.Location = new System.Drawing.Point(298, 120);
            this.fechaSolicitudTextBox.MaxLength = 10;
            this.fechaSolicitudTextBox.Name = "fechaSolicitudTextBox";
            this.fechaSolicitudTextBox.ReadOnly = true;
            this.fechaSolicitudTextBox.Size = new System.Drawing.Size(70, 20);
            this.fechaSolicitudTextBox.TabIndex = 35;
            // 
            // numeroInventarioTextBox
            // 
            this.numeroInventarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReparaciones, "Activo.Inventario", true));
            this.numeroInventarioTextBox.Location = new System.Drawing.Point(129, 19);
            this.numeroInventarioTextBox.Name = "numeroInventarioTextBox";
            this.numeroInventarioTextBox.ReadOnly = true;
            this.numeroInventarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.numeroInventarioTextBox.TabIndex = 34;
            // 
            // txtDescripcionActivo
            // 
            this.txtDescripcionActivo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReparaciones, "Activo.Descripcion", true));
            this.txtDescripcionActivo.Location = new System.Drawing.Point(307, 19);
            this.txtDescripcionActivo.Name = "txtDescripcionActivo";
            this.txtDescripcionActivo.ReadOnly = true;
            this.txtDescripcionActivo.Size = new System.Drawing.Size(283, 20);
            this.txtDescripcionActivo.TabIndex = 33;
            // 
            // btnPresupuestos
            // 
            this.btnPresupuestos.Location = new System.Drawing.Point(376, 196);
            this.btnPresupuestos.Name = "btnPresupuestos";
            this.btnPresupuestos.Size = new System.Drawing.Size(111, 23);
            this.btnPresupuestos.TabIndex = 32;
            this.btnPresupuestos.Text = "Ver presupuestos";
            this.btnPresupuestos.UseVisualStyleBackColor = true;
            this.btnPresupuestos.Click += new System.EventHandler(this.btnPresupuestos_Click);
            // 
            // ticketSoporteTextBox
            // 
            this.ticketSoporteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReparaciones, "TicketSoporte", true));
            this.ticketSoporteTextBox.Location = new System.Drawing.Point(130, 120);
            this.ticketSoporteTextBox.Name = "ticketSoporteTextBox";
            this.ticketSoporteTextBox.ReadOnly = true;
            this.ticketSoporteTextBox.Size = new System.Drawing.Size(99, 20);
            this.ticketSoporteTextBox.TabIndex = 29;
            // 
            // enGarantiaCheckBox
            // 
            this.enGarantiaCheckBox.AutoCheck = false;
            this.enGarantiaCheckBox.AutoSize = true;
            this.enGarantiaCheckBox.Location = new System.Drawing.Point(129, 197);
            this.enGarantiaCheckBox.Name = "enGarantiaCheckBox";
            this.enGarantiaCheckBox.Size = new System.Drawing.Size(91, 21);
            this.enGarantiaCheckBox.TabIndex = 28;
            this.enGarantiaCheckBox.Text = "En Garantía";
            this.enGarantiaCheckBox.UseVisualStyleBackColor = true;
            this.enGarantiaCheckBox.CheckedChanged += new System.EventHandler(this.enGarantiaCheckBox_CheckedChanged);
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReparaciones, "Solicitante.Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(483, 45);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.ReadOnly = true;
            this.telefonoTextBox.Size = new System.Drawing.Size(191, 20);
            this.telefonoTextBox.TabIndex = 24;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReparaciones, "Solicitante", true));
            this.nombreTextBox.Location = new System.Drawing.Point(129, 45);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.ReadOnly = true;
            this.nombreTextBox.Size = new System.Drawing.Size(291, 20);
            this.nombreTextBox.TabIndex = 22;
            // 
            // observacionesTextBox
            // 
            this.observacionesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReparaciones, "Descripcion", true));
            this.observacionesTextBox.Location = new System.Drawing.Point(129, 146);
            this.observacionesTextBox.Multiline = true;
            this.observacionesTextBox.Name = "observacionesTextBox";
            this.observacionesTextBox.ReadOnly = true;
            this.observacionesTextBox.Size = new System.Drawing.Size(545, 43);
            this.observacionesTextBox.TabIndex = 20;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReparaciones, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(129, 71);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.ReadOnly = true;
            this.descripcionTextBox.Size = new System.Drawing.Size(545, 43);
            this.descripcionTextBox.TabIndex = 5;
            // 
            // GrillaReparaciones
            // 
            this.GrillaReparaciones.AllowUserToAddRows = false;
            this.GrillaReparaciones.AllowUserToDeleteRows = false;
            this.GrillaReparaciones.AutoGenerateColumns = false;
            this.GrillaReparaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaReparaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.solicitanteDataGridViewTextBoxColumn,
            this.activoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.GrillaReparaciones.DataSource = this.bsReparaciones;
            this.GrillaReparaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrillaReparaciones.Location = new System.Drawing.Point(0, 0);
            this.GrillaReparaciones.Name = "GrillaReparaciones";
            this.GrillaReparaciones.ReadOnly = true;
            this.GrillaReparaciones.RowHeadersVisible = false;
            this.GrillaReparaciones.RowHeadersWidth = 62;
            this.GrillaReparaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaReparaciones.Size = new System.Drawing.Size(869, 287);
            this.GrillaReparaciones.TabIndex = 0;
            // 
            // solicitanteDataGridViewTextBoxColumn
            // 
            this.solicitanteDataGridViewTextBoxColumn.DataPropertyName = "Solicitante";
            this.solicitanteDataGridViewTextBoxColumn.HeaderText = "Solicitante";
            this.solicitanteDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.solicitanteDataGridViewTextBoxColumn.Name = "solicitanteDataGridViewTextBoxColumn";
            this.solicitanteDataGridViewTextBoxColumn.ReadOnly = true;
            this.solicitanteDataGridViewTextBoxColumn.Width = 150;
            // 
            // activoDataGridViewTextBoxColumn
            // 
            this.activoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.activoDataGridViewTextBoxColumn.DataPropertyName = "Activo";
            this.activoDataGridViewTextBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.activoDataGridViewTextBoxColumn.Name = "activoDataGridViewTextBoxColumn";
            this.activoDataGridViewTextBoxColumn.ReadOnly = true;
            this.activoDataGridViewTextBoxColumn.Width = 73;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Falla";
            this.descripcionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsPresupuestos
            // 
            this.bsPresupuestos.DataMember = "Presupuestos";
            this.bsPresupuestos.DataSource = this.bsReparaciones;
            // 
            // ReparacionAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 561);
            this.Controls.Add(this.SplitContainer1);
            this.Controls.Add(this.Button2);
            this.Name = "ReparacionAdminForm";
            this.Text = "Reparaciones";
            this.Load += new System.EventHandler(this.ReparacionesForm_Load);
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel1.PerformLayout();
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsReparaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaReparaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPresupuestos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.SplitContainer SplitContainer1;
        private System.Windows.Forms.DataGridView GrillaReparaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionFallaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presupuestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPresupuestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaValidezPresupuestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoMonedaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEntregaProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEstimadaReparacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRealReparacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsReparaciones;
        private System.Windows.Forms.CheckBox estadoCheckBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox observacionesTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox ticketSoporteTextBox;
        private System.Windows.Forms.CheckBox enGarantiaCheckBox;
        private System.Windows.Forms.BindingSource bsPresupuestos;
        private System.Windows.Forms.Button btnPresupuestos;
        private System.Windows.Forms.TextBox txtDescripcionActivo;
        private System.Windows.Forms.TextBox numeroInventarioTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn solicitanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox fechaFinalizacionTextBox;
        private System.Windows.Forms.TextBox fechaSolicitudTextBox;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.Button AgregarButton;
    }
}