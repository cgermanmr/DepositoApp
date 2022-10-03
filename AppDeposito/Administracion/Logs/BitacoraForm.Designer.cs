namespace AppDeposito.Administracion.Logs
{
    partial class BitacoraForm
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
            System.Windows.Forms.Label DescripcionLabel;
            System.Windows.Forms.Label UsuarioLabel;
            System.Windows.Forms.Label FechaLabel;
            this.QuitarFiltroButton = new System.Windows.Forms.Button();
            this.FiltrarButton = new System.Windows.Forms.Button();
            this.cmbEvento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.BitacoraBELBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.FechaDesde = new System.Windows.Forms.DateTimePicker();
            this.GrillaBitacora = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DescripcionLabel = new System.Windows.Forms.Label();
            UsuarioLabel = new System.Windows.Forms.Label();
            FechaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BitacoraBELBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaBitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // DescripcionLabel
            // 
            DescripcionLabel.AutoSize = true;
            DescripcionLabel.Location = new System.Drawing.Point(485, 115);
            DescripcionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            DescripcionLabel.Name = "DescripcionLabel";
            DescripcionLabel.Size = new System.Drawing.Size(96, 20);
            DescripcionLabel.TabIndex = 4;
            DescripcionLabel.Text = "Descripcion:";
            // 
            // UsuarioLabel
            // 
            UsuarioLabel.AutoSize = true;
            UsuarioLabel.Location = new System.Drawing.Point(83, 72);
            UsuarioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            UsuarioLabel.Name = "UsuarioLabel";
            UsuarioLabel.Size = new System.Drawing.Size(68, 20);
            UsuarioLabel.TabIndex = 2;
            UsuarioLabel.Text = "Usuario:";
            // 
            // FechaLabel
            // 
            FechaLabel.AutoSize = true;
            FechaLabel.Location = new System.Drawing.Point(49, 25);
            FechaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            FechaLabel.Name = "FechaLabel";
            FechaLabel.Size = new System.Drawing.Size(106, 20);
            FechaLabel.TabIndex = 0;
            FechaLabel.Text = "Fecha desde:";
            // 
            // QuitarFiltroButton
            // 
            this.QuitarFiltroButton.Location = new System.Drawing.Point(133, 147);
            this.QuitarFiltroButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.QuitarFiltroButton.Name = "QuitarFiltroButton";
            this.QuitarFiltroButton.Size = new System.Drawing.Size(112, 35);
            this.QuitarFiltroButton.TabIndex = 10;
            this.QuitarFiltroButton.Text = "Quitar Filtro";
            this.QuitarFiltroButton.UseVisualStyleBackColor = true;
            this.QuitarFiltroButton.Click += new System.EventHandler(this.QuitarFiltroButton_Click);
            // 
            // FiltrarButton
            // 
            this.FiltrarButton.Location = new System.Drawing.Point(13, 147);
            this.FiltrarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FiltrarButton.Name = "FiltrarButton";
            this.FiltrarButton.Size = new System.Drawing.Size(112, 35);
            this.FiltrarButton.TabIndex = 2;
            this.FiltrarButton.Text = "Filtrar";
            this.FiltrarButton.UseVisualStyleBackColor = true;
            this.FiltrarButton.Click += new System.EventHandler(this.FiltrarButton_Click);
            // 
            // cmbEvento
            // 
            this.cmbEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEvento.FormattingEnabled = true;
            this.cmbEvento.Location = new System.Drawing.Point(593, 68);
            this.cmbEvento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbEvento.Name = "cmbEvento";
            this.cmbEvento.Size = new System.Drawing.Size(298, 28);
            this.cmbEvento.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Evento:";
            // 
            // FechaHasta
            // 
            this.FechaHasta.Location = new System.Drawing.Point(593, 25);
            this.FechaHasta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FechaHasta.Name = "FechaHasta";
            this.FechaHasta.Size = new System.Drawing.Size(298, 26);
            this.FechaHasta.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha hasta:";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BitacoraBELBindingSource, "Descripcion", true));
            this.DescripcionTextBox.Location = new System.Drawing.Point(593, 110);
            this.DescripcionTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DescripcionTextBox.Multiline = true;
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(298, 29);
            this.DescripcionTextBox.TabIndex = 5;
            // 
            // BitacoraBELBindingSource
            // 
            this.BitacoraBELBindingSource.DataSource = typeof(BEL.BitacoraBEL);
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BitacoraBELBindingSource, "Usuario", true));
            this.UsuarioTextBox.Location = new System.Drawing.Point(161, 72);
            this.UsuarioTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(298, 26);
            this.UsuarioTextBox.TabIndex = 3;
            // 
            // FechaDesde
            // 
            this.FechaDesde.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.BitacoraBELBindingSource, "Fecha", true));
            this.FechaDesde.Location = new System.Drawing.Point(161, 25);
            this.FechaDesde.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FechaDesde.Name = "FechaDesde";
            this.FechaDesde.Size = new System.Drawing.Size(298, 26);
            this.FechaDesde.TabIndex = 1;
            // 
            // GrillaBitacora
            // 
            this.GrillaBitacora.AllowUserToAddRows = false;
            this.GrillaBitacora.AllowUserToDeleteRows = false;
            this.GrillaBitacora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrillaBitacora.AutoGenerateColumns = false;
            this.GrillaBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaBitacora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            this.GrillaBitacora.DataSource = this.BitacoraBELBindingSource;
            this.GrillaBitacora.Location = new System.Drawing.Point(13, 192);
            this.GrillaBitacora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GrillaBitacora.MultiSelect = false;
            this.GrillaBitacora.Name = "GrillaBitacora";
            this.GrillaBitacora.ReadOnly = true;
            this.GrillaBitacora.RowHeadersVisible = false;
            this.GrillaBitacora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaBitacora.Size = new System.Drawing.Size(878, 430);
            this.GrillaBitacora.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn1.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Evento";
            this.dataGridViewTextBoxColumn3.HeaderText = "Evento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Usuario";
            this.dataGridViewTextBoxColumn2.HeaderText = "Usuario";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // BitacoraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 650);
            this.Controls.Add(this.GrillaBitacora);
            this.Controls.Add(this.QuitarFiltroButton);
            this.Controls.Add(this.FiltrarButton);
            this.Controls.Add(FechaLabel);
            this.Controls.Add(this.cmbEvento);
            this.Controls.Add(this.FechaDesde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.FechaHasta);
            this.Controls.Add(UsuarioLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(DescripcionLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BitacoraForm";
            this.Text = "Eventos ";
            this.Load += new System.EventHandler(this.BitacoraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BitacoraBELBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaBitacora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.TextBox DescripcionTextBox;
        internal System.Windows.Forms.BindingSource BitacoraBELBindingSource;
        internal System.Windows.Forms.TextBox UsuarioTextBox;
        internal System.Windows.Forms.DateTimePicker FechaDesde;
        internal System.Windows.Forms.DataGridView GrillaBitacora;
        private System.Windows.Forms.DateTimePicker FechaHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEvento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button QuitarFiltroButton;
        private System.Windows.Forms.Button FiltrarButton;
    }
}