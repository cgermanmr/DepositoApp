namespace AppDeposito
{
    partial class DonacionesForm
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
            this.donacionBELDataGridView = new System.Windows.Forms.DataGridView();
            this.bsActivos = new System.Windows.Forms.BindingSource(this.components);
            this.activosDataGridView = new System.Windows.Forms.DataGridView();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.AgregarActivoButton = new System.Windows.Forms.Button();
            this.QuitarButton = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDonaciones = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.donacionBELDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDonaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // donacionBELDataGridView
            // 
            this.donacionBELDataGridView.AllowUserToAddRows = false;
            this.donacionBELDataGridView.AllowUserToDeleteRows = false;
            this.donacionBELDataGridView.AutoGenerateColumns = false;
            this.donacionBELDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.donacionBELDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn3});
            this.donacionBELDataGridView.DataSource = this.bsDonaciones;
            this.donacionBELDataGridView.Location = new System.Drawing.Point(12, 12);
            this.donacionBELDataGridView.Name = "donacionBELDataGridView";
            this.donacionBELDataGridView.ReadOnly = true;
            this.donacionBELDataGridView.RowHeadersVisible = false;
            this.donacionBELDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.donacionBELDataGridView.Size = new System.Drawing.Size(669, 141);
            this.donacionBELDataGridView.TabIndex = 1;
            // 
            // bsActivos
            // 
            this.bsActivos.DataMember = "Activos";
            this.bsActivos.DataSource = this.bsDonaciones;
            // 
            // activosDataGridView
            // 
            this.activosDataGridView.AllowUserToAddRows = false;
            this.activosDataGridView.AllowUserToDeleteRows = false;
            this.activosDataGridView.AutoGenerateColumns = false;
            this.activosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn11});
            this.activosDataGridView.DataSource = this.bsActivos;
            this.activosDataGridView.Location = new System.Drawing.Point(12, 188);
            this.activosDataGridView.Name = "activosDataGridView";
            this.activosDataGridView.ReadOnly = true;
            this.activosDataGridView.RowHeadersVisible = false;
            this.activosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.activosDataGridView.Size = new System.Drawing.Size(669, 258);
            this.activosDataGridView.TabIndex = 1;
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(444, 159);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(75, 23);
            this.AgregarButton.TabIndex = 2;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // ModificarButton
            // 
            this.ModificarButton.Location = new System.Drawing.Point(525, 159);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(75, 23);
            this.ModificarButton.TabIndex = 3;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = true;
            this.ModificarButton.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(606, 159);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 23);
            this.EliminarButton.TabIndex = 4;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // AgregarActivoButton
            // 
            this.AgregarActivoButton.Location = new System.Drawing.Point(12, 159);
            this.AgregarActivoButton.Name = "AgregarActivoButton";
            this.AgregarActivoButton.Size = new System.Drawing.Size(89, 23);
            this.AgregarActivoButton.TabIndex = 5;
            this.AgregarActivoButton.Text = "Agregar activo";
            this.AgregarActivoButton.UseVisualStyleBackColor = true;
            this.AgregarActivoButton.Click += new System.EventHandler(this.AgregarActivoButton_Click);
            // 
            // QuitarButton
            // 
            this.QuitarButton.Location = new System.Drawing.Point(107, 159);
            this.QuitarButton.Name = "QuitarButton";
            this.QuitarButton.Size = new System.Drawing.Size(75, 23);
            this.QuitarButton.TabIndex = 6;
            this.QuitarButton.Text = "Quitar activo";
            this.QuitarButton.UseVisualStyleBackColor = true;
            this.QuitarButton.Click += new System.EventHandler(this.QuitarButton_Click);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Inventario";
            this.dataGridViewTextBoxColumn8.HeaderText = "Inventario";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn22.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "TipoActivo";
            this.dataGridViewTextBoxColumn13.HeaderText = "TipoActivo";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "EstadoActivo";
            this.dataGridViewTextBoxColumn12.HeaderText = "EstadoActivo";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Ubicacion";
            this.dataGridViewTextBoxColumn11.HeaderText = "Ubicacion";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // bsDonaciones
            // 
            this.bsDonaciones.DataSource = typeof(BEL.DonacionBEL);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn6.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Organizacion";
            this.dataGridViewTextBoxColumn4.HeaderText = "Organizacion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Autorizador";
            this.dataGridViewTextBoxColumn1.HeaderText = "Autorizador";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Auditor";
            this.dataGridViewTextBoxColumn2.HeaderText = "Auditor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Estado";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Aprobada";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // DonacionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 473);
            this.Controls.Add(this.QuitarButton);
            this.Controls.Add(this.AgregarActivoButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.activosDataGridView);
            this.Controls.Add(this.donacionBELDataGridView);
            this.Name = "DonacionesForm";
            this.Text = "Donaciones";
            this.Load += new System.EventHandler(this.DonacionesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.donacionBELDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDonaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsDonaciones;
        private System.Windows.Forms.DataGridView donacionBELDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource bsActivos;
        private System.Windows.Forms.DataGridView activosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button AgregarActivoButton;
        private System.Windows.Forms.Button QuitarButton;
    }
}