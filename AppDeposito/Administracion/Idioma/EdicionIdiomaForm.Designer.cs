namespace AppDeposito.Administracion.Idioma
{
    partial class EdicionIdiomaForm
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
            this.btnTraducirDesdeInternet = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.bsIdiomas = new System.Windows.Forms.BindingSource(this.components);
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GrillaLeyendas = new System.Windows.Forms.DataGridView();
            this.bsLeyendas = new System.Windows.Forms.BindingSource(this.components);
            this.txtPredeterminada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEditada = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.chkHabilitado = new System.Windows.Forms.CheckBox();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsIdiomas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaLeyendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLeyendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTraducirDesdeInternet
            // 
            this.btnTraducirDesdeInternet.Location = new System.Drawing.Point(36, 704);
            this.btnTraducirDesdeInternet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTraducirDesdeInternet.Name = "btnTraducirDesdeInternet";
            this.btnTraducirDesdeInternet.Size = new System.Drawing.Size(152, 35);
            this.btnTraducirDesdeInternet.TabIndex = 6;
            this.btnTraducirDesdeInternet.Tag = "30";
            this.btnTraducirDesdeInternet.Text = "Traducir en línea";
            this.btnTraducirDesdeInternet.UseVisualStyleBackColor = true;
            this.btnTraducirDesdeInternet.Visible = false;
            this.btnTraducirDesdeInternet.Click += new System.EventHandler(this.btnTraducirDesdeInternet_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(494, 704);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(112, 35);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Tag = "8";
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(614, 704);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 35);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Tag = "9";
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsIdiomas, "Nombre", true));
            this.txtNombre.Location = new System.Drawing.Point(36, 43);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(202, 26);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombre_Validating);
            // 
            // bsIdiomas
            // 
            this.bsIdiomas.DataSource = typeof(BEL.IdiomaBEL);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsIdiomas, "Descripcion", true));
            this.txtDescripcion.Location = new System.Drawing.Point(36, 103);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(690, 26);
            this.txtDescripcion.TabIndex = 3;
            this.txtDescripcion.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescripcion_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 4;
            this.label1.Tag = "32";
            this.label1.Text = "Nombre Idioma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 20);
            this.label2.TabIndex = 5;
            this.label2.Tag = "33";
            this.label2.Text = "Descripción (Pais de origen)";
            // 
            // GrillaLeyendas
            // 
            this.GrillaLeyendas.AllowUserToAddRows = false;
            this.GrillaLeyendas.AllowUserToDeleteRows = false;
            this.GrillaLeyendas.AutoGenerateColumns = false;
            this.GrillaLeyendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrillaLeyendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaLeyendas.ColumnHeadersVisible = false;
            this.GrillaLeyendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn});
            this.GrillaLeyendas.DataSource = this.bsLeyendas;
            this.GrillaLeyendas.Location = new System.Drawing.Point(36, 163);
            this.GrillaLeyendas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GrillaLeyendas.MultiSelect = false;
            this.GrillaLeyendas.Name = "GrillaLeyendas";
            this.GrillaLeyendas.ReadOnly = true;
            this.GrillaLeyendas.RowHeadersVisible = false;
            this.GrillaLeyendas.RowHeadersWidth = 62;
            this.GrillaLeyendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaLeyendas.Size = new System.Drawing.Size(692, 249);
            this.GrillaLeyendas.TabIndex = 25;
            // 
            // bsLeyendas
            // 
            this.bsLeyendas.DataSource = typeof(BEL.LeyendaBEL);
            // 
            // txtPredeterminada
            // 
            this.txtPredeterminada.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLeyendas, "Codigo", true));
            this.txtPredeterminada.Location = new System.Drawing.Point(36, 456);
            this.txtPredeterminada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPredeterminada.Multiline = true;
            this.txtPredeterminada.Name = "txtPredeterminada";
            this.txtPredeterminada.ReadOnly = true;
            this.txtPredeterminada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPredeterminada.Size = new System.Drawing.Size(690, 99);
            this.txtPredeterminada.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 26;
            this.label3.Tag = "6";
            this.label3.Text = "Leyendas:";
            // 
            // txtEditada
            // 
            this.txtEditada.AcceptsReturn = true;
            this.txtEditada.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLeyendas, "Valor", true));
            this.txtEditada.Location = new System.Drawing.Point(36, 595);
            this.txtEditada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEditada.Multiline = true;
            this.txtEditada.Name = "txtEditada";
            this.txtEditada.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEditada.Size = new System.Drawing.Size(690, 99);
            this.txtEditada.TabIndex = 30;
            this.txtEditada.Validating += new System.ComponentModel.CancelEventHandler(this.txtEditada_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 570);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Traducción:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 431);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Predeterminado:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // chkHabilitado
            // 
            this.chkHabilitado.AutoSize = true;
            this.chkHabilitado.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsIdiomas, "Habilitado", true));
            this.chkHabilitado.Location = new System.Drawing.Point(260, 44);
            this.chkHabilitado.Name = "chkHabilitado";
            this.chkHabilitado.Size = new System.Drawing.Size(106, 24);
            this.chkHabilitado.TabIndex = 34;
            this.chkHabilitado.Text = "Habilitado";
            this.chkHabilitado.UseVisualStyleBackColor = true;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EdicionIdiomaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 753);
            this.Controls.Add(this.chkHabilitado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTraducirDesdeInternet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GrillaLeyendas);
            this.Controls.Add(this.txtEditada);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPredeterminada);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EdicionIdiomaForm";
            this.Text = "Modificación Idioma";
            this.Load += new System.EventHandler(this.EdicionIdiomaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsIdiomas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaLeyendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLeyendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTraducirDesdeInternet;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView GrillaLeyendas;
        private System.Windows.Forms.TextBox txtPredeterminada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEditada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.BindingSource bsIdiomas;
        private System.Windows.Forms.CheckBox chkHabilitado;
        private System.Windows.Forms.BindingSource bsLeyendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
    }
}