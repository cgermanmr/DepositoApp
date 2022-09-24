namespace AppDeposito.Administracion.Permisos
{
    partial class AdminUsuariosForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClaveButton = new System.Windows.Forms.Button();
            this.lblCultura = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.GrillaUsuarios = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bloqueado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IntentosIncorrectos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idioma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.UsuarioBELBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PerfilTreeView = new System.Windows.Forms.TreeView();
            this.btnModificarPermisos = new System.Windows.Forms.Button();
            this.txtIdioma = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioBELBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewTextBoxColumn1
            // 
            this.DataGridViewTextBoxColumn1.DataPropertyName = "Perfil";
            this.DataGridViewTextBoxColumn1.HeaderText = "Perfil";
            this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            this.DataGridViewTextBoxColumn1.ReadOnly = true;
            this.DataGridViewTextBoxColumn1.Width = 55;
            // 
            // ClaveButton
            // 
            this.ClaveButton.Location = new System.Drawing.Point(334, 133);
            this.ClaveButton.Name = "ClaveButton";
            this.ClaveButton.Size = new System.Drawing.Size(85, 23);
            this.ClaveButton.TabIndex = 34;
            this.ClaveButton.Text = "Cambiar clave";
            this.ClaveButton.UseVisualStyleBackColor = true;
            this.ClaveButton.Click += new System.EventHandler(this.ClaveButton_Click);
            // 
            // lblCultura
            // 
            this.lblCultura.AutoSize = true;
            this.lblCultura.Location = new System.Drawing.Point(9, 88);
            this.lblCultura.Name = "lblCultura";
            this.lblCultura.Size = new System.Drawing.Size(41, 13);
            this.lblCultura.TabIndex = 32;
            this.lblCultura.Tag = "43";
            this.lblCultura.Text = "Idioma:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(174, 133);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(73, 23);
            this.btnEliminar.TabIndex = 27;
            this.btnEliminar.Tag = "3";
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // GrillaUsuarios
            // 
            this.GrillaUsuarios.AllowUserToAddRows = false;
            this.GrillaUsuarios.AllowUserToDeleteRows = false;
            this.GrillaUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrillaUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GrillaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Email,
            this.Bloqueado,
            this.IntentosIncorrectos,
            this.Idioma});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrillaUsuarios.DefaultCellStyle = dataGridViewCellStyle4;
            this.GrillaUsuarios.Location = new System.Drawing.Point(12, 162);
            this.GrillaUsuarios.MultiSelect = false;
            this.GrillaUsuarios.Name = "GrillaUsuarios";
            this.GrillaUsuarios.ReadOnly = true;
            this.GrillaUsuarios.RowHeadersVisible = false;
            this.GrillaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaUsuarios.Size = new System.Drawing.Size(515, 182);
            this.GrillaUsuarios.TabIndex = 30;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 69;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Bloqueado
            // 
            this.Bloqueado.DataPropertyName = "Bloqueado";
            this.Bloqueado.HeaderText = "Bloqueado";
            this.Bloqueado.Name = "Bloqueado";
            this.Bloqueado.ReadOnly = true;
            this.Bloqueado.Width = 64;
            // 
            // IntentosIncorrectos
            // 
            this.IntentosIncorrectos.DataPropertyName = "IntentosIncorrectos";
            this.IntentosIncorrectos.HeaderText = "Intentos Incorrectos";
            this.IntentosIncorrectos.Name = "IntentosIncorrectos";
            this.IntentosIncorrectos.ReadOnly = true;
            this.IntentosIncorrectos.Width = 115;
            // 
            // Idioma
            // 
            this.Idioma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Idioma.DataPropertyName = "Idioma";
            this.Idioma.HeaderText = "Idioma";
            this.Idioma.Name = "Idioma";
            this.Idioma.ReadOnly = true;
            this.Idioma.Width = 63;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 65);
            this.txtEmail.MaxLength = 256;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(235, 20);
            this.txtEmail.TabIndex = 21;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 26);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(235, 20);
            this.txtNombre.TabIndex = 20;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(9, 49);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 13);
            this.lblEmail.TabIndex = 31;
            this.lblEmail.Tag = "41";
            this.lblEmail.Text = "E-Mail:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(9, 10);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 29;
            this.lblNombre.Tag = "38";
            this.lblNombre.Text = "Nombre:";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(93, 133);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(73, 23);
            this.btnModificar.TabIndex = 26;
            this.btnModificar.Tag = "2";
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 133);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(73, 23);
            this.btnAgregar.TabIndex = 25;
            this.btnAgregar.Tag = "45";
            this.btnAgregar.Text = "Nuevo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // DataGridViewTextBoxColumn2
            // 
            this.DataGridViewTextBoxColumn2.DataPropertyName = "Idioma";
            this.DataGridViewTextBoxColumn2.HeaderText = "Idioma";
            this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            this.DataGridViewTextBoxColumn2.ReadOnly = true;
            this.DataGridViewTextBoxColumn2.Width = 63;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(255, 133);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(73, 23);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Tag = "9";
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // UsuarioBELBindingSource
            // 
            this.UsuarioBELBindingSource.DataSource = typeof(BEL.UsuarioBEL);
            // 
            // PerfilTreeView
            // 
            this.PerfilTreeView.Location = new System.Drawing.Point(255, 26);
            this.PerfilTreeView.Name = "PerfilTreeView";
            this.PerfilTreeView.Size = new System.Drawing.Size(272, 98);
            this.PerfilTreeView.TabIndex = 35;
            // 
            // btnModificarPermisos
            // 
            this.btnModificarPermisos.Location = new System.Drawing.Point(425, 133);
            this.btnModificarPermisos.Name = "btnModificarPermisos";
            this.btnModificarPermisos.Size = new System.Drawing.Size(102, 23);
            this.btnModificarPermisos.TabIndex = 36;
            this.btnModificarPermisos.Text = "Modificar permisos";
            this.btnModificarPermisos.UseVisualStyleBackColor = true;
            this.btnModificarPermisos.Click += new System.EventHandler(this.BtnModificarPermisos_Click);
            // 
            // txtIdioma
            // 
            this.txtIdioma.Location = new System.Drawing.Point(12, 104);
            this.txtIdioma.Name = "txtIdioma";
            this.txtIdioma.ReadOnly = true;
            this.txtIdioma.Size = new System.Drawing.Size(235, 20);
            this.txtIdioma.TabIndex = 37;
            // 
            // AdminUsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 360);
            this.Controls.Add(this.txtIdioma);
            this.Controls.Add(this.btnModificarPermisos);
            this.Controls.Add(this.PerfilTreeView);
            this.Controls.Add(this.ClaveButton);
            this.Controls.Add(this.lblCultura);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.GrillaUsuarios);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Name = "AdminUsuariosForm";
            this.Text = "Administrar Usuarios";
            this.Load += new System.EventHandler(this.AdminUsuariosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioBELBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.BindingSource UsuarioBELBindingSource;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        internal System.Windows.Forms.Button ClaveButton;
        internal System.Windows.Forms.Label lblCultura;
        internal System.Windows.Forms.Button btnEliminar;
        internal System.Windows.Forms.DataGridView GrillaUsuarios;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.Label lblEmail;
        internal System.Windows.Forms.Label lblNombre;
        internal System.Windows.Forms.Button btnModificar;
        internal System.Windows.Forms.Button btnAgregar;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        internal System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TreeView PerfilTreeView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Bloqueado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntentosIncorrectos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idioma;
        private System.Windows.Forms.Button btnModificarPermisos;
        private System.Windows.Forms.TextBox txtIdioma;
    }
}