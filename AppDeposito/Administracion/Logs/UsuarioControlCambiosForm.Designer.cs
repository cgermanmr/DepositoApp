namespace AppDeposito.Administracion.Logs
{
    partial class UsuarioControlCambiosForm
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
            System.Windows.Forms.Label usuarioModificadorLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrillaUsuarios = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bloqueado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IntentosIncorrectos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idioma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dateTimeDesde = new System.Windows.Forms.DateTimePicker();
            this.dateTimeHasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFiltroUsuario = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnQuitarFiltro = new System.Windows.Forms.Button();
            this.cmbEvento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.usuarioBELBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioModificadorTextBox = new System.Windows.Forms.TextBox();
            usuarioModificadorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBELBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usuarioModificadorLabel
            // 
            usuarioModificadorLabel.AutoSize = true;
            usuarioModificadorLabel.Location = new System.Drawing.Point(9, 82);
            usuarioModificadorLabel.Name = "usuarioModificadorLabel";
            usuarioModificadorLabel.Size = new System.Drawing.Size(104, 13);
            usuarioModificadorLabel.TabIndex = 50;
            usuarioModificadorLabel.Text = "Usuario Modificador:";
            // 
            // DataGridViewTextBoxColumn1
            // 
            this.DataGridViewTextBoxColumn1.DataPropertyName = "Perfil";
            this.DataGridViewTextBoxColumn1.HeaderText = "Perfil";
            this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            this.DataGridViewTextBoxColumn1.ReadOnly = true;
            this.DataGridViewTextBoxColumn1.Width = 55;
            // 
            // GrillaUsuarios
            // 
            this.GrillaUsuarios.AllowUserToAddRows = false;
            this.GrillaUsuarios.AllowUserToDeleteRows = false;
            this.GrillaUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrillaUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrillaUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GrillaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Modificacion,
            this.Modificador,
            this.Estado,
            this.Nombre,
            this.Email,
            this.Bloqueado,
            this.IntentosIncorrectos,
            this.Idioma});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrillaUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.GrillaUsuarios.Location = new System.Drawing.Point(17, 162);
            this.GrillaUsuarios.MultiSelect = false;
            this.GrillaUsuarios.Name = "GrillaUsuarios";
            this.GrillaUsuarios.ReadOnly = true;
            this.GrillaUsuarios.RowHeadersVisible = false;
            this.GrillaUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaUsuarios.Size = new System.Drawing.Size(733, 377);
            this.GrillaUsuarios.TabIndex = 30;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "FechaModificacion";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 62;
            // 
            // Modificacion
            // 
            this.Modificacion.DataPropertyName = "TipoModificacion";
            this.Modificacion.HeaderText = "Modificación";
            this.Modificacion.Name = "Modificacion";
            this.Modificacion.ReadOnly = true;
            this.Modificacion.Width = 92;
            // 
            // Modificador
            // 
            this.Modificador.DataPropertyName = "UsuarioModificador";
            this.Modificador.HeaderText = "Modificador";
            this.Modificador.Name = "Modificador";
            this.Modificador.ReadOnly = true;
            this.Modificador.Width = 87;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 65;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 69;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 57;
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
            this.IntentosIncorrectos.HeaderText = "Rechazos";
            this.IntentosIncorrectos.Name = "IntentosIncorrectos";
            this.IntentosIncorrectos.ReadOnly = true;
            this.IntentosIncorrectos.Width = 80;
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
            this.btnCancelar.Location = new System.Drawing.Point(281, 119);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(73, 23);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Tag = "9";
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dateTimeDesde
            // 
            this.dateTimeDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDesde.Location = new System.Drawing.Point(119, 12);
            this.dateTimeDesde.Name = "dateTimeDesde";
            this.dateTimeDesde.Size = new System.Drawing.Size(85, 20);
            this.dateTimeDesde.TabIndex = 39;
            this.dateTimeDesde.Value = new System.DateTime(2019, 7, 7, 0, 0, 0, 0);
            this.dateTimeDesde.ValueChanged += new System.EventHandler(this.dateTimeDesde_ValueChanged);
            // 
            // dateTimeHasta
            // 
            this.dateTimeHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeHasta.Location = new System.Drawing.Point(433, 9);
            this.dateTimeHasta.Name = "dateTimeHasta";
            this.dateTimeHasta.Size = new System.Drawing.Size(85, 20);
            this.dateTimeHasta.TabIndex = 40;
            this.dateTimeHasta.Value = new System.DateTime(2019, 7, 7, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Usuario Modificado:";
            // 
            // txtFiltroUsuario
            // 
            this.txtFiltroUsuario.Location = new System.Drawing.Point(119, 47);
            this.txtFiltroUsuario.Name = "txtFiltroUsuario";
            this.txtFiltroUsuario.Size = new System.Drawing.Size(200, 20);
            this.txtFiltroUsuario.TabIndex = 45;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(119, 119);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 46;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnQuitarFiltro
            // 
            this.btnQuitarFiltro.Location = new System.Drawing.Point(200, 119);
            this.btnQuitarFiltro.Name = "btnQuitarFiltro";
            this.btnQuitarFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnQuitarFiltro.TabIndex = 47;
            this.btnQuitarFiltro.Text = "Quitar Filtro";
            this.btnQuitarFiltro.UseVisualStyleBackColor = true;
            this.btnQuitarFiltro.Click += new System.EventHandler(this.btnQuitarFiltro_Click);
            // 
            // cmbEvento
            // 
            this.cmbEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEvento.FormattingEnabled = true;
            this.cmbEvento.Items.AddRange(new object[] {
            "Alta",
            "Baja",
            "Modificación"});
            this.cmbEvento.Location = new System.Drawing.Point(433, 46);
            this.cmbEvento.Name = "cmbEvento";
            this.cmbEvento.Size = new System.Drawing.Size(200, 21);
            this.cmbEvento.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Modificación:";
            // 
            // usuarioBELBindingSource
            // 
            this.usuarioBELBindingSource.DataSource = typeof(BEL.UsuarioBEL);
            // 
            // usuarioModificadorTextBox
            // 
            this.usuarioModificadorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBELBindingSource, "UsuarioModificador", true));
            this.usuarioModificadorTextBox.Location = new System.Drawing.Point(119, 79);
            this.usuarioModificadorTextBox.Name = "usuarioModificadorTextBox";
            this.usuarioModificadorTextBox.Size = new System.Drawing.Size(200, 20);
            this.usuarioModificadorTextBox.TabIndex = 51;
            // 
            // UsuarioControlCambiosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 456);
            this.Controls.Add(usuarioModificadorLabel);
            this.Controls.Add(this.usuarioModificadorTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbEvento);
            this.Controls.Add(this.btnQuitarFiltro);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtFiltroUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeHasta);
            this.Controls.Add(this.dateTimeDesde);
            this.Controls.Add(this.GrillaUsuarios);
            this.Controls.Add(this.btnCancelar);
            this.Name = "UsuarioControlCambiosForm";
            this.Text = "Usuarios Control de Cambios";
            this.Load += new System.EventHandler(this.AdminUsuariosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBELBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        internal System.Windows.Forms.DataGridView GrillaUsuarios;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        internal System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dateTimeDesde;
        private System.Windows.Forms.DateTimePicker dateTimeHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFiltroUsuario;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnQuitarFiltro;
        private System.Windows.Forms.ComboBox cmbEvento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource usuarioBELBindingSource;
        private System.Windows.Forms.TextBox usuarioModificadorTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Bloqueado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntentosIncorrectos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idioma;
    }
}