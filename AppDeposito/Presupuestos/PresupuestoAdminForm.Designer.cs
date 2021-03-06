﻿namespace AppDeposito
{
    partial class PresupuestoAdminForm
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.grilla = new System.Windows.Forms.DataGridView();
            this.proveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cotizacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaValidezDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tiempoEstimadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPresupuestos = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPresupuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(22, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(103, 12);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(184, 12);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // grilla
            // 
            this.grilla.AllowUserToAddRows = false;
            this.grilla.AllowUserToDeleteRows = false;
            this.grilla.AutoGenerateColumns = false;
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proveedorDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.cotizacionDataGridViewTextBoxColumn,
            this.fechaValidezDataGridViewTextBoxColumn,
            this.estadoDataGridViewCheckBoxColumn,
            this.tiempoEstimadoDataGridViewTextBoxColumn});
            this.grilla.DataSource = this.bsPresupuestos;
            this.grilla.Location = new System.Drawing.Point(22, 41);
            this.grilla.Name = "grilla";
            this.grilla.ReadOnly = true;
            this.grilla.RowHeadersVisible = false;
            this.grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilla.Size = new System.Drawing.Size(613, 168);
            this.grilla.TabIndex = 7;
            // 
            // proveedorDataGridViewTextBoxColumn
            // 
            this.proveedorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.proveedorDataGridViewTextBoxColumn.DataPropertyName = "Proveedor";
            this.proveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor";
            this.proveedorDataGridViewTextBoxColumn.Name = "proveedorDataGridViewTextBoxColumn";
            this.proveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 62;
            // 
            // cotizacionDataGridViewTextBoxColumn
            // 
            this.cotizacionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cotizacionDataGridViewTextBoxColumn.DataPropertyName = "Cotizacion";
            this.cotizacionDataGridViewTextBoxColumn.HeaderText = "Cotizacion";
            this.cotizacionDataGridViewTextBoxColumn.Name = "cotizacionDataGridViewTextBoxColumn";
            this.cotizacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.cotizacionDataGridViewTextBoxColumn.Width = 81;
            // 
            // fechaValidezDataGridViewTextBoxColumn
            // 
            this.fechaValidezDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fechaValidezDataGridViewTextBoxColumn.DataPropertyName = "FechaValidez";
            this.fechaValidezDataGridViewTextBoxColumn.HeaderText = "Validez";
            this.fechaValidezDataGridViewTextBoxColumn.Name = "fechaValidezDataGridViewTextBoxColumn";
            this.fechaValidezDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaValidezDataGridViewTextBoxColumn.Width = 66;
            // 
            // estadoDataGridViewCheckBoxColumn
            // 
            this.estadoDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.estadoDataGridViewCheckBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewCheckBoxColumn.HeaderText = "Autorizado";
            this.estadoDataGridViewCheckBoxColumn.Name = "estadoDataGridViewCheckBoxColumn";
            this.estadoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.estadoDataGridViewCheckBoxColumn.Width = 63;
            // 
            // tiempoEstimadoDataGridViewTextBoxColumn
            // 
            this.tiempoEstimadoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tiempoEstimadoDataGridViewTextBoxColumn.DataPropertyName = "TiempoEstimado";
            this.tiempoEstimadoDataGridViewTextBoxColumn.HeaderText = "Demora";
            this.tiempoEstimadoDataGridViewTextBoxColumn.Name = "tiempoEstimadoDataGridViewTextBoxColumn";
            this.tiempoEstimadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tiempoEstimadoDataGridViewTextBoxColumn.Width = 69;
            // 
            // bsPresupuestos
            // 
            this.bsPresupuestos.DataSource = typeof(BEL.PresupuestoBEL);
            // 
            // PresupuestoAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 221);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "PresupuestoAdminForm";
            this.Text = "Presupuestos";
            this.Load += new System.EventHandler(this.PresupuestoAdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPresupuestos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsPresupuestos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cotizacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaValidezDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoEstimadoDataGridViewTextBoxColumn;
    }
}