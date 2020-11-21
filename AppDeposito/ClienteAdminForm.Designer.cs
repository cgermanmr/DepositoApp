namespace AppDeposito
{
    partial class ClienteAdminForm
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
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label razonSocialLabel;
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.bsClientes = new System.Windows.Forms.BindingSource(this.components);
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.razonSocialTextBox = new System.Windows.Forms.TextBox();
            this.usuarioAsignacionBELDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bsActivosAsignados = new System.Windows.Forms.BindingSource(this.components);
            this.activosAsignadosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.AsignarButton = new System.Windows.Forms.Button();
            this.QuitarButton = new System.Windows.Forms.Button();
            apellidoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            razonSocialLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioAsignacionBELDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsActivosAsignados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosAsignadosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new System.Drawing.Point(318, 18);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(47, 13);
            apellidoLabel.TabIndex = 1;
            apellidoLabel.Text = "Apellido:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(318, 44);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(23, 18);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 9;
            nombreLabel.Text = "Nombre:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(23, 44);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 11;
            telefonoLabel.Text = "Telefono:";
            // 
            // razonSocialLabel
            // 
            razonSocialLabel.AutoSize = true;
            razonSocialLabel.Location = new System.Drawing.Point(23, 70);
            razonSocialLabel.Name = "razonSocialLabel";
            razonSocialLabel.Size = new System.Drawing.Size(51, 13);
            razonSocialLabel.TabIndex = 12;
            razonSocialLabel.Text = "Empresa:";
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsClientes, "Apellido", true));
            this.apellidoTextBox.Location = new System.Drawing.Point(390, 15);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(210, 20);
            this.apellidoTextBox.TabIndex = 2;
            // 
            // bsClientes
            // 
            this.bsClientes.DataSource = typeof(BEL.ClienteBEL);
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsClientes, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(390, 41);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(210, 20);
            this.emailTextBox.TabIndex = 6;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsClientes, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(95, 15);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(210, 20);
            this.nombreTextBox.TabIndex = 10;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsClientes, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(95, 41);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(210, 20);
            this.telefonoTextBox.TabIndex = 12;
            // 
            // razonSocialTextBox
            // 
            this.razonSocialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsClientes, "Empresa.RazonSocial", true));
            this.razonSocialTextBox.Location = new System.Drawing.Point(95, 67);
            this.razonSocialTextBox.Name = "razonSocialTextBox";
            this.razonSocialTextBox.Size = new System.Drawing.Size(210, 20);
            this.razonSocialTextBox.TabIndex = 13;
            // 
            // usuarioAsignacionBELDataGridView
            // 
            this.usuarioAsignacionBELDataGridView.AllowUserToAddRows = false;
            this.usuarioAsignacionBELDataGridView.AllowUserToDeleteRows = false;
            this.usuarioAsignacionBELDataGridView.AutoGenerateColumns = false;
            this.usuarioAsignacionBELDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuarioAsignacionBELDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.usuarioAsignacionBELDataGridView.DataSource = this.bsClientes;
            this.usuarioAsignacionBELDataGridView.Location = new System.Drawing.Point(12, 132);
            this.usuarioAsignacionBELDataGridView.Name = "usuarioAsignacionBELDataGridView";
            this.usuarioAsignacionBELDataGridView.ReadOnly = true;
            this.usuarioAsignacionBELDataGridView.RowHeadersVisible = false;
            this.usuarioAsignacionBELDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usuarioAsignacionBELDataGridView.Size = new System.Drawing.Size(609, 157);
            this.usuarioAsignacionBELDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Apellido";
            this.dataGridViewTextBoxColumn2.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn3.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Empresa";
            this.dataGridViewTextBoxColumn5.HeaderText = "Empresa";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(95, 103);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(210, 20);
            this.txtFiltro.TabIndex = 14;
            this.txtFiltro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Filtro:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(447, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(528, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bsActivosAsignados
            // 
            this.bsActivosAsignados.DataMember = "ActivosAsignados";
            this.bsActivosAsignados.DataSource = this.bsClientes;
            // 
            // activosAsignadosDataGridView
            // 
            this.activosAsignadosDataGridView.AllowUserToAddRows = false;
            this.activosAsignadosDataGridView.AllowUserToDeleteRows = false;
            this.activosAsignadosDataGridView.AutoGenerateColumns = false;
            this.activosAsignadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activosAsignadosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn12});
            this.activosAsignadosDataGridView.DataSource = this.bsActivosAsignados;
            this.activosAsignadosDataGridView.Location = new System.Drawing.Point(12, 323);
            this.activosAsignadosDataGridView.Name = "activosAsignadosDataGridView";
            this.activosAsignadosDataGridView.ReadOnly = true;
            this.activosAsignadosDataGridView.RowHeadersVisible = false;
            this.activosAsignadosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.activosAsignadosDataGridView.Size = new System.Drawing.Size(609, 129);
            this.activosAsignadosDataGridView.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "TipoActivo";
            this.dataGridViewTextBoxColumn13.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Inventario";
            this.dataGridViewTextBoxColumn8.HeaderText = "Inventario";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Serie";
            this.dataGridViewTextBoxColumn9.HeaderText = "Serie";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Marca";
            this.dataGridViewTextBoxColumn15.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "EnGarantia";
            this.dataGridViewCheckBoxColumn1.HeaderText = "En Garantia";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Sector";
            this.dataGridViewTextBoxColumn10.HeaderText = "Sector";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Ubicacion";
            this.dataGridViewTextBoxColumn11.HeaderText = "Ubicacion";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Organizacion";
            this.dataGridViewTextBoxColumn14.HeaderText = "Organizacion";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "EstadoActivo";
            this.dataGridViewTextBoxColumn12.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Activos asignados:";
            // 
            // AsignarButton
            // 
            this.AsignarButton.Location = new System.Drawing.Point(12, 458);
            this.AsignarButton.Name = "AsignarButton";
            this.AsignarButton.Size = new System.Drawing.Size(146, 23);
            this.AsignarButton.TabIndex = 20;
            this.AsignarButton.Text = "Asignar";
            this.AsignarButton.UseVisualStyleBackColor = true;
            this.AsignarButton.Click += new System.EventHandler(this.AsignarButton_Click);
            // 
            // QuitarButton
            // 
            this.QuitarButton.Location = new System.Drawing.Point(164, 458);
            this.QuitarButton.Name = "QuitarButton";
            this.QuitarButton.Size = new System.Drawing.Size(146, 23);
            this.QuitarButton.TabIndex = 21;
            this.QuitarButton.Text = "Quitar";
            this.QuitarButton.UseVisualStyleBackColor = true;
            this.QuitarButton.Click += new System.EventHandler(this.QuitarButton_Click);
            // 
            // ClienteAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 492);
            this.Controls.Add(this.QuitarButton);
            this.Controls.Add(this.AsignarButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.activosAsignadosDataGridView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.usuarioAsignacionBELDataGridView);
            this.Controls.Add(razonSocialLabel);
            this.Controls.Add(this.razonSocialTextBox);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Name = "ClienteAdminForm";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.ClienteAdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioAsignacionBELDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsActivosAsignados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosAsignadosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsClientes;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox razonSocialTextBox;
        private System.Windows.Forms.DataGridView usuarioAsignacionBELDataGridView;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource bsActivosAsignados;
        private System.Windows.Forms.DataGridView activosAsignadosDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AsignarButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Button QuitarButton;
    }
}