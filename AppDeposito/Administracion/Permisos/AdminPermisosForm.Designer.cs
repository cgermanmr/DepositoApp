namespace AppDeposito.Administracion.Permisos
{
    partial class AdminPermisosForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.NuevoGrupoButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.GrillaPermisos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PermisoBaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EliminarButton = new System.Windows.Forms.Button();
            this.PermisosTreeView = new System.Windows.Forms.TreeView();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPermisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PermisoBaseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // NuevoGrupoButton
            // 
            this.NuevoGrupoButton.Location = new System.Drawing.Point(11, 199);
            this.NuevoGrupoButton.Name = "NuevoGrupoButton";
            this.NuevoGrupoButton.Size = new System.Drawing.Size(75, 23);
            this.NuevoGrupoButton.TabIndex = 3;
            this.NuevoGrupoButton.Tag = "45";
            this.NuevoGrupoButton.Text = "Nuevo";
            this.NuevoGrupoButton.UseVisualStyleBackColor = true;
            this.NuevoGrupoButton.Click += new System.EventHandler(this.NuevoGrupoButton_Click);
            // 
            // ModificarButton
            // 
            this.ModificarButton.Location = new System.Drawing.Point(92, 199);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(75, 23);
            this.ModificarButton.TabIndex = 4;
            this.ModificarButton.Tag = "2";
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = true;
            this.ModificarButton.Click += new System.EventHandler(this.ModificarButton_Click);
            // 
            // GrillaPermisos
            // 
            this.GrillaPermisos.AllowUserToAddRows = false;
            this.GrillaPermisos.AllowUserToDeleteRows = false;
            this.GrillaPermisos.AutoGenerateColumns = false;
            this.GrillaPermisos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrillaPermisos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GrillaPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaPermisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.GrillaPermisos.DataSource = this.PermisoBaseBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrillaPermisos.DefaultCellStyle = dataGridViewCellStyle2;
            this.GrillaPermisos.Location = new System.Drawing.Point(12, 12);
            this.GrillaPermisos.MultiSelect = false;
            this.GrillaPermisos.Name = "GrillaPermisos";
            this.GrillaPermisos.ReadOnly = true;
            this.GrillaPermisos.RowHeadersVisible = false;
            this.GrillaPermisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaPermisos.Size = new System.Drawing.Size(395, 114);
            this.GrillaPermisos.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // PermisoBaseBindingSource
            // 
            this.PermisoBaseBindingSource.DataSource = typeof(BEL.PermisoBase);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(173, 201);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 23);
            this.EliminarButton.TabIndex = 5;
            this.EliminarButton.Tag = "3";
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // PermisosTreeView
            // 
            this.PermisosTreeView.Location = new System.Drawing.Point(12, 230);
            this.PermisosTreeView.Name = "PermisosTreeView";
            this.PermisosTreeView.Size = new System.Drawing.Size(395, 191);
            this.PermisosTreeView.TabIndex = 10;
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(11, 148);
            this.DescripcionTextBox.Multiline = true;
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.ReadOnly = true;
            this.DescripcionTextBox.Size = new System.Drawing.Size(395, 45);
            this.DescripcionTextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Descripción:";
            // 
            // AdminPermisosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.PermisosTreeView);
            this.Controls.Add(this.NuevoGrupoButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.GrillaPermisos);
            this.Name = "AdminPermisosForm";
            this.Text = "Administrar Permisos";
            this.Load += new System.EventHandler(this.AdminPermisosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPermisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PermisoBaseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button NuevoGrupoButton;
        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.DataGridView GrillaPermisos;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.TreeView PermisosTreeView;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        internal System.Windows.Forms.BindingSource PermisoBaseBindingSource;
    }
}