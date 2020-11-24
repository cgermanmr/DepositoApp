namespace AppDeposito
{
    partial class EmpresaAdminForm
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
            System.Windows.Forms.Label razonSocialLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label cUITLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label codigoPostalLabel;
            System.Windows.Forms.Label ciudadLabel;
            System.Windows.Forms.Label contactoLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label observacionesLabel;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.observacionesTextBox = new System.Windows.Forms.TextBox();
            this.bsOrganizaciones = new System.Windows.Forms.BindingSource(this.components);
            this.EliminarButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.contactoTextBox = new System.Windows.Forms.TextBox();
            this.ciudadTextBox = new System.Windows.Forms.TextBox();
            this.codigoPostalTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.cUITTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.razonSocialTextBox = new System.Windows.Forms.TextBox();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.razonSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoPostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            razonSocialLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            cUITLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            codigoPostalLabel = new System.Windows.Forms.Label();
            ciudadLabel = new System.Windows.Forms.Label();
            contactoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            observacionesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrganizaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // razonSocialLabel
            // 
            razonSocialLabel.AutoSize = true;
            razonSocialLabel.Location = new System.Drawing.Point(30, 15);
            razonSocialLabel.Name = "razonSocialLabel";
            razonSocialLabel.Size = new System.Drawing.Size(73, 13);
            razonSocialLabel.TabIndex = 0;
            razonSocialLabel.Text = "Razon Social:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(319, 41);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 2;
            telefonoLabel.Text = "Telefono:";
            // 
            // cUITLabel
            // 
            cUITLabel.AutoSize = true;
            cUITLabel.Location = new System.Drawing.Point(336, 15);
            cUITLabel.Name = "cUITLabel";
            cUITLabel.Size = new System.Drawing.Size(35, 13);
            cUITLabel.TabIndex = 4;
            cUITLabel.Text = "CUIT:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(67, 67);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "Email:";
            // 
            // codigoPostalLabel
            // 
            codigoPostalLabel.AutoSize = true;
            codigoPostalLabel.Location = new System.Drawing.Point(296, 67);
            codigoPostalLabel.Name = "codigoPostalLabel";
            codigoPostalLabel.Size = new System.Drawing.Size(75, 13);
            codigoPostalLabel.TabIndex = 8;
            codigoPostalLabel.Text = "Codigo Postal:";
            // 
            // ciudadLabel
            // 
            ciudadLabel.AutoSize = true;
            ciudadLabel.Location = new System.Drawing.Point(328, 93);
            ciudadLabel.Name = "ciudadLabel";
            ciudadLabel.Size = new System.Drawing.Size(43, 13);
            ciudadLabel.TabIndex = 10;
            ciudadLabel.Text = "Ciudad:";
            // 
            // contactoLabel
            // 
            contactoLabel.AutoSize = true;
            contactoLabel.Location = new System.Drawing.Point(49, 41);
            contactoLabel.Name = "contactoLabel";
            contactoLabel.Size = new System.Drawing.Size(53, 13);
            contactoLabel.TabIndex = 12;
            contactoLabel.Text = "Contacto:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(47, 93);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 14;
            direccionLabel.Text = "Direccion:";
            // 
            // observacionesLabel
            // 
            observacionesLabel.AutoSize = true;
            observacionesLabel.Location = new System.Drawing.Point(21, 119);
            observacionesLabel.Name = "observacionesLabel";
            observacionesLabel.Size = new System.Drawing.Size(81, 13);
            observacionesLabel.TabIndex = 164;
            observacionesLabel.Text = "Observaciones:";
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
            this.splitContainer1.Panel1.Controls.Add(observacionesLabel);
            this.splitContainer1.Panel1.Controls.Add(this.observacionesTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.EliminarButton);
            this.splitContainer1.Panel1.Controls.Add(this.ModificarButton);
            this.splitContainer1.Panel1.Controls.Add(this.AgregarButton);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtFiltro);
            this.splitContainer1.Panel1.Controls.Add(direccionLabel);
            this.splitContainer1.Panel1.Controls.Add(this.direccionTextBox);
            this.splitContainer1.Panel1.Controls.Add(contactoLabel);
            this.splitContainer1.Panel1.Controls.Add(this.contactoTextBox);
            this.splitContainer1.Panel1.Controls.Add(ciudadLabel);
            this.splitContainer1.Panel1.Controls.Add(this.ciudadTextBox);
            this.splitContainer1.Panel1.Controls.Add(codigoPostalLabel);
            this.splitContainer1.Panel1.Controls.Add(this.codigoPostalTextBox);
            this.splitContainer1.Panel1.Controls.Add(emailLabel);
            this.splitContainer1.Panel1.Controls.Add(this.emailTextBox);
            this.splitContainer1.Panel1.Controls.Add(cUITLabel);
            this.splitContainer1.Panel1.Controls.Add(this.cUITTextBox);
            this.splitContainer1.Panel1.Controls.Add(telefonoLabel);
            this.splitContainer1.Panel1.Controls.Add(this.telefonoTextBox);
            this.splitContainer1.Panel1.Controls.Add(razonSocialLabel);
            this.splitContainer1.Panel1.Controls.Add(this.razonSocialTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvGrilla);
            this.splitContainer1.Size = new System.Drawing.Size(582, 386);
            this.splitContainer1.SplitterDistance = 198;
            this.splitContainer1.TabIndex = 0;
            // 
            // observacionesTextBox
            // 
            this.observacionesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrganizaciones, "Observaciones", true));
            this.observacionesTextBox.Location = new System.Drawing.Point(108, 116);
            this.observacionesTextBox.Multiline = true;
            this.observacionesTextBox.Name = "observacionesTextBox";
            this.observacionesTextBox.Size = new System.Drawing.Size(443, 36);
            this.observacionesTextBox.TabIndex = 165;
            // 
            // bsOrganizaciones
            // 
            this.bsOrganizaciones.DataSource = typeof(BEL.EmpresaBEL);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(476, 158);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 23);
            this.EliminarButton.TabIndex = 1;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // ModificarButton
            // 
            this.ModificarButton.Location = new System.Drawing.Point(395, 158);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(75, 23);
            this.ModificarButton.TabIndex = 163;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = true;
            this.ModificarButton.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(314, 158);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(75, 23);
            this.AgregarButton.TabIndex = 161;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Filtrar:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(108, 158);
            this.txtFiltro.MaxLength = 50;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(174, 20);
            this.txtFiltro.TabIndex = 16;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrganizaciones, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(108, 90);
            this.direccionTextBox.MaxLength = 50;
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(174, 20);
            this.direccionTextBox.TabIndex = 15;
            // 
            // contactoTextBox
            // 
            this.contactoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrganizaciones, "Contacto", true));
            this.contactoTextBox.Location = new System.Drawing.Point(108, 38);
            this.contactoTextBox.MaxLength = 50;
            this.contactoTextBox.Name = "contactoTextBox";
            this.contactoTextBox.Size = new System.Drawing.Size(174, 20);
            this.contactoTextBox.TabIndex = 13;
            // 
            // ciudadTextBox
            // 
            this.ciudadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrganizaciones, "Ciudad", true));
            this.ciudadTextBox.Location = new System.Drawing.Point(377, 90);
            this.ciudadTextBox.MaxLength = 50;
            this.ciudadTextBox.Name = "ciudadTextBox";
            this.ciudadTextBox.Size = new System.Drawing.Size(174, 20);
            this.ciudadTextBox.TabIndex = 11;
            // 
            // codigoPostalTextBox
            // 
            this.codigoPostalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrganizaciones, "CodigoPostal", true));
            this.codigoPostalTextBox.Location = new System.Drawing.Point(377, 64);
            this.codigoPostalTextBox.MaxLength = 10;
            this.codigoPostalTextBox.Name = "codigoPostalTextBox";
            this.codigoPostalTextBox.Size = new System.Drawing.Size(174, 20);
            this.codigoPostalTextBox.TabIndex = 9;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrganizaciones, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(108, 64);
            this.emailTextBox.MaxLength = 50;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(174, 20);
            this.emailTextBox.TabIndex = 7;
            // 
            // cUITTextBox
            // 
            this.cUITTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrganizaciones, "CUIT", true));
            this.cUITTextBox.Location = new System.Drawing.Point(377, 12);
            this.cUITTextBox.MaxLength = 11;
            this.cUITTextBox.Name = "cUITTextBox";
            this.cUITTextBox.Size = new System.Drawing.Size(174, 20);
            this.cUITTextBox.TabIndex = 5;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrganizaciones, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(377, 38);
            this.telefonoTextBox.MaxLength = 50;
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(174, 20);
            this.telefonoTextBox.TabIndex = 3;
            // 
            // razonSocialTextBox
            // 
            this.razonSocialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrganizaciones, "RazonSocial", true));
            this.razonSocialTextBox.Location = new System.Drawing.Point(108, 12);
            this.razonSocialTextBox.MaxLength = 50;
            this.razonSocialTextBox.Name = "razonSocialTextBox";
            this.razonSocialTextBox.Size = new System.Drawing.Size(174, 20);
            this.razonSocialTextBox.TabIndex = 1;
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.AllowUserToAddRows = false;
            this.dgvGrilla.AllowUserToDeleteRows = false;
            this.dgvGrilla.AutoGenerateColumns = false;
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.razonSocialDataGridViewTextBoxColumn,
            this.contactoDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.cUITDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.ciudadDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.codigoPostalDataGridViewTextBoxColumn});
            this.dgvGrilla.DataSource = this.bsOrganizaciones;
            this.dgvGrilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGrilla.Location = new System.Drawing.Point(0, 0);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.ReadOnly = true;
            this.dgvGrilla.RowHeadersVisible = false;
            this.dgvGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrilla.Size = new System.Drawing.Size(582, 184);
            this.dgvGrilla.TabIndex = 0;
            this.dgvGrilla.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.GrillaOrganizaciones_DataError);
            // 
            // razonSocialDataGridViewTextBoxColumn
            // 
            this.razonSocialDataGridViewTextBoxColumn.DataPropertyName = "RazonSocial";
            this.razonSocialDataGridViewTextBoxColumn.HeaderText = "Razon Social";
            this.razonSocialDataGridViewTextBoxColumn.Name = "razonSocialDataGridViewTextBoxColumn";
            this.razonSocialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactoDataGridViewTextBoxColumn
            // 
            this.contactoDataGridViewTextBoxColumn.DataPropertyName = "Contacto";
            this.contactoDataGridViewTextBoxColumn.HeaderText = "Contacto";
            this.contactoDataGridViewTextBoxColumn.Name = "contactoDataGridViewTextBoxColumn";
            this.contactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cUITDataGridViewTextBoxColumn
            // 
            this.cUITDataGridViewTextBoxColumn.DataPropertyName = "CUIT";
            this.cUITDataGridViewTextBoxColumn.HeaderText = "CUIT";
            this.cUITDataGridViewTextBoxColumn.Name = "cUITDataGridViewTextBoxColumn";
            this.cUITDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ciudadDataGridViewTextBoxColumn
            // 
            this.ciudadDataGridViewTextBoxColumn.DataPropertyName = "Ciudad";
            this.ciudadDataGridViewTextBoxColumn.HeaderText = "Ciudad";
            this.ciudadDataGridViewTextBoxColumn.Name = "ciudadDataGridViewTextBoxColumn";
            this.ciudadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigoPostalDataGridViewTextBoxColumn
            // 
            this.codigoPostalDataGridViewTextBoxColumn.DataPropertyName = "CodigoPostal";
            this.codigoPostalDataGridViewTextBoxColumn.HeaderText = "C.P.";
            this.codigoPostalDataGridViewTextBoxColumn.Name = "codigoPostalDataGridViewTextBoxColumn";
            this.codigoPostalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // OrganizacionAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 386);
            this.Controls.Add(this.splitContainer1);
            this.Name = "OrganizacionAdminForm";
            this.Text = "Organizaciones";
            this.Load += new System.EventHandler(this.OrganizacionesForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsOrganizaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsOrganizaciones;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox contactoTextBox;
        private System.Windows.Forms.TextBox ciudadTextBox;
        private System.Windows.Forms.TextBox codigoPostalTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox cUITTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox razonSocialTextBox;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoPostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button ModificarButton;
        internal System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.TextBox observacionesTextBox;
    }
}