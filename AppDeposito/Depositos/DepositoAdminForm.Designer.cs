namespace AppDeposito
{
    partial class DepositoAdminForm
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
            this.activosDataGridView = new System.Windows.Forms.DataGridView();
            this.AgregarActivoButton = new System.Windows.Forms.Button();
            this.QuitarActivoButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.depositoBELDataGridView = new System.Windows.Forms.DataGridView();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivosDisponibles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivosEnReparacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivosEnUso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivosParaDonar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivosParaDescartar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDepositos = new System.Windows.Forms.BindingSource(this.components);
            this.porcentajeUtilizadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsActivos = new System.Windows.Forms.BindingSource(this.components);
            this.EliminarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.activosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositoBELDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDepositos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsActivos)).BeginInit();
            this.SuspendLayout();
            // 
            // activosDataGridView
            // 
            this.activosDataGridView.AllowUserToAddRows = false;
            this.activosDataGridView.AllowUserToDeleteRows = false;
            this.activosDataGridView.AutoGenerateColumns = false;
            this.activosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewCheckBoxColumn1});
            this.activosDataGridView.DataSource = this.bsActivos;
            this.activosDataGridView.Location = new System.Drawing.Point(23, 169);
            this.activosDataGridView.Name = "activosDataGridView";
            this.activosDataGridView.ReadOnly = true;
            this.activosDataGridView.RowHeadersVisible = false;
            this.activosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.activosDataGridView.Size = new System.Drawing.Size(710, 245);
            this.activosDataGridView.TabIndex = 6;
            this.activosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.activosDataGridView_CellContentClick);
            // 
            // AgregarActivoButton
            // 
            this.AgregarActivoButton.Location = new System.Drawing.Point(23, 420);
            this.AgregarActivoButton.Name = "AgregarActivoButton";
            this.AgregarActivoButton.Size = new System.Drawing.Size(95, 23);
            this.AgregarActivoButton.TabIndex = 9;
            this.AgregarActivoButton.Text = "Agregar Activo";
            this.AgregarActivoButton.UseVisualStyleBackColor = true;
            this.AgregarActivoButton.Click += new System.EventHandler(this.AgregarActivoButton_Click);
            // 
            // QuitarActivoButton
            // 
            this.QuitarActivoButton.Location = new System.Drawing.Point(124, 420);
            this.QuitarActivoButton.Name = "QuitarActivoButton";
            this.QuitarActivoButton.Size = new System.Drawing.Size(95, 23);
            this.QuitarActivoButton.TabIndex = 10;
            this.QuitarActivoButton.Text = "Modificar Activo";
            this.QuitarActivoButton.UseVisualStyleBackColor = true;
            this.QuitarActivoButton.Click += new System.EventHandler(this.QuitarActivoButton_Click);
            // 
            // ModificarButton
            // 
            this.ModificarButton.Location = new System.Drawing.Point(576, 142);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(75, 23);
            this.ModificarButton.TabIndex = 11;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = true;
            this.ModificarButton.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(495, 141);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(75, 23);
            this.AgregarButton.TabIndex = 12;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Filtro:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(62, 143);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(226, 20);
            this.txtFiltro.TabIndex = 14;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // depositoBELDataGridView
            // 
            this.depositoBELDataGridView.AllowUserToAddRows = false;
            this.depositoBELDataGridView.AllowUserToDeleteRows = false;
            this.depositoBELDataGridView.AutoGenerateColumns = false;
            this.depositoBELDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.depositoBELDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.porcentajeUtilizadoDataGridViewTextBoxColumn,
            this.ActivosDisponibles,
            this.ActivosEnReparacion,
            this.ActivosEnUso,
            this.ActivosParaDonar,
            this.ActivosParaDescartar});
            this.depositoBELDataGridView.DataSource = this.bsDepositos;
            this.depositoBELDataGridView.Location = new System.Drawing.Point(23, 12);
            this.depositoBELDataGridView.Name = "depositoBELDataGridView";
            this.depositoBELDataGridView.ReadOnly = true;
            this.depositoBELDataGridView.RowHeadersVisible = false;
            this.depositoBELDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.depositoBELDataGridView.Size = new System.Drawing.Size(710, 122);
            this.depositoBELDataGridView.TabIndex = 14;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // ActivosDisponibles
            // 
            this.ActivosDisponibles.DataPropertyName = "ActivosDisponibles";
            this.ActivosDisponibles.HeaderText = "Disponibles";
            this.ActivosDisponibles.Name = "ActivosDisponibles";
            this.ActivosDisponibles.ReadOnly = true;
            // 
            // ActivosEnReparacion
            // 
            this.ActivosEnReparacion.DataPropertyName = "ActivosEnReparacion";
            this.ActivosEnReparacion.HeaderText = "En Reparacion";
            this.ActivosEnReparacion.Name = "ActivosEnReparacion";
            this.ActivosEnReparacion.ReadOnly = true;
            // 
            // ActivosEnUso
            // 
            this.ActivosEnUso.DataPropertyName = "ActivosEnUso";
            this.ActivosEnUso.HeaderText = "En Uso";
            this.ActivosEnUso.Name = "ActivosEnUso";
            this.ActivosEnUso.ReadOnly = true;
            // 
            // ActivosParaDonar
            // 
            this.ActivosParaDonar.DataPropertyName = "ActivosParaDonar";
            this.ActivosParaDonar.HeaderText = "Para Donar";
            this.ActivosParaDonar.Name = "ActivosParaDonar";
            this.ActivosParaDonar.ReadOnly = true;
            // 
            // ActivosParaDescartar
            // 
            this.ActivosParaDescartar.DataPropertyName = "ActivosParaDescartar";
            this.ActivosParaDescartar.HeaderText = "Para Descartar";
            this.ActivosParaDescartar.Name = "ActivosParaDescartar";
            this.ActivosParaDescartar.ReadOnly = true;
            // 
            // bsDepositos
            // 
            this.bsDepositos.DataSource = typeof(BEL.DepositoBEL);
            // 
            // porcentajeUtilizadoDataGridViewTextBoxColumn
            // 
            this.porcentajeUtilizadoDataGridViewTextBoxColumn.DataPropertyName = "PorcentajeUtilizado";
            this.porcentajeUtilizadoDataGridViewTextBoxColumn.HeaderText = "% Utilizado";
            this.porcentajeUtilizadoDataGridViewTextBoxColumn.Name = "porcentajeUtilizadoDataGridViewTextBoxColumn";
            this.porcentajeUtilizadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Inventario";
            this.dataGridViewTextBoxColumn3.HeaderText = "Inventario";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Serie";
            this.dataGridViewTextBoxColumn4.HeaderText = "Serie";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn17.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TipoActivo";
            this.dataGridViewTextBoxColumn8.HeaderText = "TipoActivo";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Sector";
            this.dataGridViewTextBoxColumn5.HeaderText = "Sector";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Marca";
            this.dataGridViewTextBoxColumn10.HeaderText = "Marca";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "EstadoActivo";
            this.dataGridViewTextBoxColumn7.HeaderText = "EstadoActivo";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Ubicacion";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ubicacion";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Organizacion";
            this.dataGridViewTextBoxColumn9.HeaderText = "Organizacion";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Volumen";
            this.dataGridViewTextBoxColumn15.HeaderText = "Volumen";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "EnGarantia";
            this.dataGridViewCheckBoxColumn1.HeaderText = "EnGarantia";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // bsActivos
            // 
            this.bsActivos.DataMember = "Activos";
            this.bsActivos.DataSource = this.bsDepositos;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(657, 141);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 23);
            this.EliminarButton.TabIndex = 15;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // DepositoAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 449);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.depositoBELDataGridView);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.QuitarActivoButton);
            this.Controls.Add(this.AgregarActivoButton);
            this.Controls.Add(this.activosDataGridView);
            this.Name = "DepositoAdminForm";
            this.Text = "Administrar Depositos";
            this.Load += new System.EventHandler(this.DepositosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositoBELDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDepositos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsActivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsDepositos;
        private System.Windows.Forms.BindingSource bsActivos;
        private System.Windows.Forms.DataGridView activosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button AgregarActivoButton;
        private System.Windows.Forms.Button QuitarActivoButton;
        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.DataGridView depositoBELDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentajeUtilizadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivosDisponibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivosEnReparacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivosEnUso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivosParaDonar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivosParaDescartar;
        private System.Windows.Forms.Button EliminarButton;
    }
}