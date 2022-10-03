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
            this.EliminarButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.AgregarButton = new System.Windows.Forms.Button();
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
            this.bsPresupuestos = new System.Windows.Forms.BindingSource(this.components);
            this.bsReparaciones = new System.Windows.Forms.BindingSource(this.components);
            this.solicitanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            descripcionLabel = new System.Windows.Forms.Label();
            fechaFinalizacionLabel = new System.Windows.Forms.Label();
            fechaSolicitudLabel = new System.Windows.Forms.Label();
            observacionesLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            numeroInventarioLabel = new System.Windows.Forms.Label();
            ticketSoporteLabel = new System.Windows.Forms.Label();
            descripcionLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaReparaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPresupuestos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReparaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(127, 109);
            descripcionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(47, 20);
            descripcionLabel.TabIndex = 4;
            descripcionLabel.Text = "Falla:";
            // 
            // fechaFinalizacionLabel
            // 
            fechaFinalizacionLabel.AutoSize = true;
            fechaFinalizacionLabel.Location = new System.Drawing.Point(562, 182);
            fechaFinalizacionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fechaFinalizacionLabel.Name = "fechaFinalizacionLabel";
            fechaFinalizacionLabel.Size = new System.Drawing.Size(96, 20);
            fechaFinalizacionLabel.TabIndex = 8;
            fechaFinalizacionLabel.Text = "Finalización:";
            // 
            // fechaSolicitudLabel
            // 
            fechaSolicitudLabel.AutoSize = true;
            fechaSolicitudLabel.Location = new System.Drawing.Point(351, 182);
            fechaSolicitudLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fechaSolicitudLabel.Name = "fechaSolicitudLabel";
            fechaSolicitudLabel.Size = new System.Drawing.Size(73, 20);
            fechaSolicitudLabel.TabIndex = 16;
            fechaSolicitudLabel.Text = "Solicitud:";
            // 
            // observacionesLabel
            // 
            observacionesLabel.AutoSize = true;
            observacionesLabel.Location = new System.Drawing.Point(51, 222);
            observacionesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            observacionesLabel.Name = "observacionesLabel";
            observacionesLabel.Size = new System.Drawing.Size(118, 20);
            observacionesLabel.TabIndex = 19;
            observacionesLabel.Text = "Observaciones:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(48, 69);
            nombreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(121, 20);
            nombreLabel.TabIndex = 21;
            nombreLabel.Text = "Usuario/Cliente:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(627, 69);
            telefonoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(75, 20);
            telefonoLabel.TabIndex = 23;
            telefonoLabel.Text = "Telefono:";
            // 
            // numeroInventarioLabel
            // 
            numeroInventarioLabel.AutoSize = true;
            numeroInventarioLabel.Location = new System.Drawing.Point(86, 31);
            numeroInventarioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            numeroInventarioLabel.Name = "numeroInventarioLabel";
            numeroInventarioLabel.Size = new System.Drawing.Size(83, 20);
            numeroInventarioLabel.TabIndex = 25;
            numeroInventarioLabel.Text = "Inventario:";
            // 
            // ticketSoporteLabel
            // 
            ticketSoporteLabel.AutoSize = true;
            ticketSoporteLabel.Location = new System.Drawing.Point(54, 182);
            ticketSoporteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ticketSoporteLabel.Name = "ticketSoporteLabel";
            ticketSoporteLabel.Size = new System.Drawing.Size(116, 20);
            ticketSoporteLabel.TabIndex = 28;
            ticketSoporteLabel.Text = "Ticket Soporte:";
            // 
            // descripcionLabel1
            // 
            descripcionLabel1.AutoSize = true;
            descripcionLabel1.Location = new System.Drawing.Point(333, 31);
            descripcionLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descripcionLabel1.Name = "descripcionLabel1";
            descripcionLabel1.Size = new System.Drawing.Size(96, 20);
            descripcionLabel1.TabIndex = 32;
            descripcionLabel1.Text = "Descripcion:";
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(884, 324);
            this.EliminarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(112, 35);
            this.EliminarButton.TabIndex = 39;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // ModificarButton
            // 
            this.ModificarButton.Location = new System.Drawing.Point(764, 324);
            this.ModificarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(112, 35);
            this.ModificarButton.TabIndex = 38;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = true;
            this.ModificarButton.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(644, 324);
            this.AgregarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(112, 35);
            this.AgregarButton.TabIndex = 37;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // fechaFinalizacionTextBox
            // 
            this.fechaFinalizacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReparaciones, "FechaFinalizacion", true));
            this.fechaFinalizacionTextBox.Location = new System.Drawing.Point(669, 179);
            this.fechaFinalizacionTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fechaFinalizacionTextBox.MaxLength = 10;
            this.fechaFinalizacionTextBox.Name = "fechaFinalizacionTextBox";
            this.fechaFinalizacionTextBox.ReadOnly = true;
            this.fechaFinalizacionTextBox.Size = new System.Drawing.Size(103, 26);
            this.fechaFinalizacionTextBox.TabIndex = 36;
            // 
            // fechaSolicitudTextBox
            // 
            this.fechaSolicitudTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReparaciones, "FechaSolicitud", true));
            this.fechaSolicitudTextBox.Location = new System.Drawing.Point(435, 179);
            this.fechaSolicitudTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fechaSolicitudTextBox.MaxLength = 10;
            this.fechaSolicitudTextBox.Name = "fechaSolicitudTextBox";
            this.fechaSolicitudTextBox.ReadOnly = true;
            this.fechaSolicitudTextBox.Size = new System.Drawing.Size(103, 26);
            this.fechaSolicitudTextBox.TabIndex = 35;
            // 
            // numeroInventarioTextBox
            // 
            this.numeroInventarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReparaciones, "Activo.Inventario", true));
            this.numeroInventarioTextBox.Location = new System.Drawing.Point(177, 28);
            this.numeroInventarioTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numeroInventarioTextBox.Name = "numeroInventarioTextBox";
            this.numeroInventarioTextBox.ReadOnly = true;
            this.numeroInventarioTextBox.Size = new System.Drawing.Size(148, 26);
            this.numeroInventarioTextBox.TabIndex = 34;
            // 
            // txtDescripcionActivo
            // 
            this.txtDescripcionActivo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReparaciones, "Activo.Descripcion", true));
            this.txtDescripcionActivo.Location = new System.Drawing.Point(437, 28);
            this.txtDescripcionActivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescripcionActivo.Name = "txtDescripcionActivo";
            this.txtDescripcionActivo.ReadOnly = true;
            this.txtDescripcionActivo.Size = new System.Drawing.Size(422, 26);
            this.txtDescripcionActivo.TabIndex = 33;
            // 
            // btnPresupuestos
            // 
            this.btnPresupuestos.Location = new System.Drawing.Point(13, 324);
            this.btnPresupuestos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPresupuestos.Name = "btnPresupuestos";
            this.btnPresupuestos.Size = new System.Drawing.Size(316, 35);
            this.btnPresupuestos.TabIndex = 32;
            this.btnPresupuestos.Text = "Ver presupuestos asignados";
            this.btnPresupuestos.UseVisualStyleBackColor = true;
            this.btnPresupuestos.Click += new System.EventHandler(this.btnPresupuestos_Click);
            // 
            // ticketSoporteTextBox
            // 
            this.ticketSoporteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReparaciones, "TicketSoporte", true));
            this.ticketSoporteTextBox.Location = new System.Drawing.Point(183, 179);
            this.ticketSoporteTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ticketSoporteTextBox.Name = "ticketSoporteTextBox";
            this.ticketSoporteTextBox.ReadOnly = true;
            this.ticketSoporteTextBox.Size = new System.Drawing.Size(146, 26);
            this.ticketSoporteTextBox.TabIndex = 29;
            // 
            // enGarantiaCheckBox
            // 
            this.enGarantiaCheckBox.AutoCheck = false;
            this.enGarantiaCheckBox.AutoSize = true;
            this.enGarantiaCheckBox.Location = new System.Drawing.Point(883, 29);
            this.enGarantiaCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enGarantiaCheckBox.Name = "enGarantiaCheckBox";
            this.enGarantiaCheckBox.Size = new System.Drawing.Size(121, 24);
            this.enGarantiaCheckBox.TabIndex = 28;
            this.enGarantiaCheckBox.Text = "En Garantía";
            this.enGarantiaCheckBox.UseVisualStyleBackColor = true;
            this.enGarantiaCheckBox.CheckedChanged += new System.EventHandler(this.enGarantiaCheckBox_CheckedChanged);
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReparaciones, "Solicitante.Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(712, 66);
            this.telefonoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.ReadOnly = true;
            this.telefonoTextBox.Size = new System.Drawing.Size(284, 26);
            this.telefonoTextBox.TabIndex = 24;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReparaciones, "Solicitante", true));
            this.nombreTextBox.Location = new System.Drawing.Point(177, 66);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.ReadOnly = true;
            this.nombreTextBox.Size = new System.Drawing.Size(434, 26);
            this.nombreTextBox.TabIndex = 22;
            // 
            // observacionesTextBox
            // 
            this.observacionesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReparaciones, "Descripcion", true));
            this.observacionesTextBox.Location = new System.Drawing.Point(182, 222);
            this.observacionesTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.observacionesTextBox.Multiline = true;
            this.observacionesTextBox.Name = "observacionesTextBox";
            this.observacionesTextBox.ReadOnly = true;
            this.observacionesTextBox.Size = new System.Drawing.Size(814, 64);
            this.observacionesTextBox.TabIndex = 20;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsReparaciones, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(177, 105);
            this.descripcionTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.ReadOnly = true;
            this.descripcionTextBox.Size = new System.Drawing.Size(819, 64);
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
            this.GrillaReparaciones.Location = new System.Drawing.Point(13, 369);
            this.GrillaReparaciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GrillaReparaciones.Name = "GrillaReparaciones";
            this.GrillaReparaciones.ReadOnly = true;
            this.GrillaReparaciones.RowHeadersVisible = false;
            this.GrillaReparaciones.RowHeadersWidth = 62;
            this.GrillaReparaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaReparaciones.Size = new System.Drawing.Size(983, 442);
            this.GrillaReparaciones.TabIndex = 0;
            // 
            // bsPresupuestos
            // 
            this.bsPresupuestos.DataMember = "Presupuestos";
            this.bsPresupuestos.DataSource = this.bsReparaciones;
            // 
            // bsReparaciones
            // 
            this.bsReparaciones.DataSource = typeof(BEL.ReparacionBEL);
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
            this.activoDataGridViewTextBoxColumn.Width = 88;
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
            // ReparacionAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 863);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GrillaReparaciones);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(numeroInventarioLabel);
            this.Controls.Add(this.fechaFinalizacionTextBox);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(this.fechaSolicitudTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.numeroInventarioTextBox);
            this.Controls.Add(this.observacionesTextBox);
            this.Controls.Add(descripcionLabel1);
            this.Controls.Add(observacionesLabel);
            this.Controls.Add(this.txtDescripcionActivo);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(fechaFinalizacionLabel);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(fechaSolicitudLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(this.btnPresupuestos);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(ticketSoporteLabel);
            this.Controls.Add(this.enGarantiaCheckBox);
            this.Controls.Add(this.ticketSoporteTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReparacionAdminForm";
            this.Text = "Reparaciones";
            this.Load += new System.EventHandler(this.ReparacionesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaReparaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPresupuestos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReparaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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