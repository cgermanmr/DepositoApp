namespace AppDeposito
{
    partial class ProveedorAdminForm
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
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.cUITTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.razonSocialTextBox = new System.Windows.Forms.TextBox();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.razonSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            razonSocialLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            cUITLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
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
            razonSocialLabel.Location = new System.Drawing.Point(45, 23);
            razonSocialLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            razonSocialLabel.Name = "razonSocialLabel";
            razonSocialLabel.Size = new System.Drawing.Size(107, 20);
            razonSocialLabel.TabIndex = 0;
            razonSocialLabel.Text = "Razon Social:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(478, 98);
            telefonoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(75, 20);
            telefonoLabel.TabIndex = 2;
            telefonoLabel.Text = "Telefono:";
            // 
            // cUITLabel
            // 
            cUITLabel.AutoSize = true;
            cUITLabel.Location = new System.Drawing.Point(503, 65);
            cUITLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cUITLabel.Name = "cUITLabel";
            cUITLabel.Size = new System.Drawing.Size(50, 20);
            cUITLabel.TabIndex = 4;
            cUITLabel.Text = "CUIT:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(100, 103);
            emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(52, 20);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "Email:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(71, 58);
            direccionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(79, 20);
            direccionLabel.TabIndex = 14;
            direccionLabel.Text = "Direccion:";
            // 
            // observacionesLabel
            // 
            observacionesLabel.AutoSize = true;
            observacionesLabel.Location = new System.Drawing.Point(35, 137);
            observacionesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            observacionesLabel.Name = "observacionesLabel";
            observacionesLabel.Size = new System.Drawing.Size(118, 20);
            observacionesLabel.TabIndex = 164;
            observacionesLabel.Text = "Observaciones:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.splitContainer1.Size = new System.Drawing.Size(873, 594);
            this.splitContainer1.SplitterDistance = 287;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // observacionesTextBox
            // 
            this.observacionesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrganizaciones, "Observaciones", true));
            this.observacionesTextBox.Location = new System.Drawing.Point(158, 134);
            this.observacionesTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.observacionesTextBox.Multiline = true;
            this.observacionesTextBox.Name = "observacionesTextBox";
            this.observacionesTextBox.Size = new System.Drawing.Size(662, 53);
            this.observacionesTextBox.TabIndex = 165;
            // 
            // bsOrganizaciones
            // 
            this.bsOrganizaciones.DataSource = typeof(BEL.ProveedorBEL);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(713, 208);
            this.EliminarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(112, 35);
            this.EliminarButton.TabIndex = 1;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // ModificarButton
            // 
            this.ModificarButton.Location = new System.Drawing.Point(592, 208);
            this.ModificarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(112, 35);
            this.ModificarButton.TabIndex = 163;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = true;
            this.ModificarButton.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(472, 208);
            this.AgregarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(112, 35);
            this.AgregarButton.TabIndex = 161;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 223);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Filtrar:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(173, 217);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFiltro.MaxLength = 50;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(259, 26);
            this.txtFiltro.TabIndex = 16;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrganizaciones, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(158, 62);
            this.direccionTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.direccionTextBox.MaxLength = 50;
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(297, 26);
            this.direccionTextBox.TabIndex = 15;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrganizaciones, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(158, 98);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailTextBox.MaxLength = 50;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(297, 26);
            this.emailTextBox.TabIndex = 7;
            // 
            // cUITTextBox
            // 
            this.cUITTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrganizaciones, "CUIT", true));
            this.cUITTextBox.Location = new System.Drawing.Point(566, 62);
            this.cUITTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cUITTextBox.MaxLength = 11;
            this.cUITTextBox.Name = "cUITTextBox";
            this.cUITTextBox.Size = new System.Drawing.Size(259, 26);
            this.cUITTextBox.TabIndex = 5;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrganizaciones, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(561, 98);
            this.telefonoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.telefonoTextBox.MaxLength = 50;
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(259, 26);
            this.telefonoTextBox.TabIndex = 3;
            // 
            // razonSocialTextBox
            // 
            this.razonSocialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrganizaciones, "RazonSocial", true));
            this.razonSocialTextBox.Location = new System.Drawing.Point(158, 18);
            this.razonSocialTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.razonSocialTextBox.MaxLength = 50;
            this.razonSocialTextBox.Name = "razonSocialTextBox";
            this.razonSocialTextBox.Size = new System.Drawing.Size(297, 26);
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
            this.telefonoDataGridViewTextBoxColumn,
            this.cUITDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn});
            this.dgvGrilla.DataSource = this.bsOrganizaciones;
            this.dgvGrilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGrilla.Location = new System.Drawing.Point(0, 0);
            this.dgvGrilla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.ReadOnly = true;
            this.dgvGrilla.RowHeadersVisible = false;
            this.dgvGrilla.RowHeadersWidth = 62;
            this.dgvGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrilla.Size = new System.Drawing.Size(873, 301);
            this.dgvGrilla.TabIndex = 0;
            this.dgvGrilla.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.GrillaOrganizaciones_DataError);
            // 
            // razonSocialDataGridViewTextBoxColumn
            // 
            this.razonSocialDataGridViewTextBoxColumn.DataPropertyName = "RazonSocial";
            this.razonSocialDataGridViewTextBoxColumn.HeaderText = "Razon Social";
            this.razonSocialDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.razonSocialDataGridViewTextBoxColumn.Name = "razonSocialDataGridViewTextBoxColumn";
            this.razonSocialDataGridViewTextBoxColumn.ReadOnly = true;
            this.razonSocialDataGridViewTextBoxColumn.Width = 150;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefonoDataGridViewTextBoxColumn.Width = 150;
            // 
            // cUITDataGridViewTextBoxColumn
            // 
            this.cUITDataGridViewTextBoxColumn.DataPropertyName = "CUIT";
            this.cUITDataGridViewTextBoxColumn.HeaderText = "CUIT";
            this.cUITDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cUITDataGridViewTextBoxColumn.Name = "cUITDataGridViewTextBoxColumn";
            this.cUITDataGridViewTextBoxColumn.ReadOnly = true;
            this.cUITDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ProveedorAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 594);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProveedorAdminForm";
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
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox cUITTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox razonSocialTextBox;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button ModificarButton;
        internal System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.TextBox observacionesTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
    }
}