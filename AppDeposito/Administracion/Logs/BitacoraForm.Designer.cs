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
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
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
            this.FiltrarButton = new System.Windows.Forms.Button();
            this.QuitarFiltroButton = new System.Windows.Forms.Button();
            DescripcionLabel = new System.Windows.Forms.Label();
            UsuarioLabel = new System.Windows.Forms.Label();
            FechaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BitacoraBELBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaBitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // DescripcionLabel
            // 
            DescripcionLabel.AutoSize = true;
            DescripcionLabel.Location = new System.Drawing.Point(335, 81);
            DescripcionLabel.Name = "DescripcionLabel";
            DescripcionLabel.Size = new System.Drawing.Size(66, 13);
            DescripcionLabel.TabIndex = 4;
            DescripcionLabel.Text = "Descripcion:";
            // 
            // UsuarioLabel
            // 
            UsuarioLabel.AutoSize = true;
            UsuarioLabel.Location = new System.Drawing.Point(67, 53);
            UsuarioLabel.Name = "UsuarioLabel";
            UsuarioLabel.Size = new System.Drawing.Size(46, 13);
            UsuarioLabel.TabIndex = 2;
            UsuarioLabel.Text = "Usuario:";
            // 
            // FechaLabel
            // 
            FechaLabel.AutoSize = true;
            FechaLabel.Location = new System.Drawing.Point(44, 23);
            FechaLabel.Name = "FechaLabel";
            FechaLabel.Size = new System.Drawing.Size(72, 13);
            FechaLabel.TabIndex = 0;
            FechaLabel.Text = "Fecha desde:";
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer1.Name = "SplitContainer1";
            this.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.AutoScroll = true;
            this.SplitContainer1.Panel1.Controls.Add(this.QuitarFiltroButton);
            this.SplitContainer1.Panel1.Controls.Add(this.FiltrarButton);
            this.SplitContainer1.Panel1.Controls.Add(this.cmbEvento);
            this.SplitContainer1.Panel1.Controls.Add(this.label2);
            this.SplitContainer1.Panel1.Controls.Add(this.FechaHasta);
            this.SplitContainer1.Panel1.Controls.Add(this.label1);
            this.SplitContainer1.Panel1.Controls.Add(DescripcionLabel);
            this.SplitContainer1.Panel1.Controls.Add(this.DescripcionTextBox);
            this.SplitContainer1.Panel1.Controls.Add(UsuarioLabel);
            this.SplitContainer1.Panel1.Controls.Add(this.UsuarioTextBox);
            this.SplitContainer1.Panel1.Controls.Add(FechaLabel);
            this.SplitContainer1.Panel1.Controls.Add(this.FechaDesde);
            this.SplitContainer1.Panel1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.BitacoraBELBindingSource, "Usuario", true));
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.GrillaBitacora);
            this.SplitContainer1.Size = new System.Drawing.Size(758, 450);
            this.SplitContainer1.SplitterDistance = 178;
            this.SplitContainer1.TabIndex = 1;
            // 
            // cmbEvento
            // 
            this.cmbEvento.FormattingEnabled = true;
            this.cmbEvento.Location = new System.Drawing.Point(407, 51);
            this.cmbEvento.Name = "cmbEvento";
            this.cmbEvento.Size = new System.Drawing.Size(200, 21);
            this.cmbEvento.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Evento:";
            // 
            // FechaHasta
            // 
            this.FechaHasta.Location = new System.Drawing.Point(407, 23);
            this.FechaHasta.Name = "FechaHasta";
            this.FechaHasta.Size = new System.Drawing.Size(200, 20);
            this.FechaHasta.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha hasta:";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BitacoraBELBindingSource, "Descripcion", true));
            this.DescripcionTextBox.Location = new System.Drawing.Point(407, 78);
            this.DescripcionTextBox.Multiline = true;
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(200, 20);
            this.DescripcionTextBox.TabIndex = 5;
            // 
            // BitacoraBELBindingSource
            // 
            this.BitacoraBELBindingSource.DataSource = typeof(BEL.BitacoraBEL);
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BitacoraBELBindingSource, "Usuario", true));
            this.UsuarioTextBox.Location = new System.Drawing.Point(119, 53);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(200, 20);
            this.UsuarioTextBox.TabIndex = 3;
            // 
            // FechaDesde
            // 
            this.FechaDesde.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.BitacoraBELBindingSource, "Fecha", true));
            this.FechaDesde.Location = new System.Drawing.Point(119, 23);
            this.FechaDesde.Name = "FechaDesde";
            this.FechaDesde.Size = new System.Drawing.Size(200, 20);
            this.FechaDesde.TabIndex = 1;
            // 
            // GrillaBitacora
            // 
            this.GrillaBitacora.AllowUserToAddRows = false;
            this.GrillaBitacora.AllowUserToDeleteRows = false;
            this.GrillaBitacora.AutoGenerateColumns = false;
            this.GrillaBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaBitacora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            this.GrillaBitacora.DataSource = this.BitacoraBELBindingSource;
            this.GrillaBitacora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrillaBitacora.Location = new System.Drawing.Point(0, 0);
            this.GrillaBitacora.MultiSelect = false;
            this.GrillaBitacora.Name = "GrillaBitacora";
            this.GrillaBitacora.ReadOnly = true;
            this.GrillaBitacora.RowHeadersVisible = false;
            this.GrillaBitacora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaBitacora.Size = new System.Drawing.Size(758, 268);
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
            // FiltrarButton
            // 
            this.FiltrarButton.Location = new System.Drawing.Point(38, 102);
            this.FiltrarButton.Name = "FiltrarButton";
            this.FiltrarButton.Size = new System.Drawing.Size(75, 23);
            this.FiltrarButton.TabIndex = 2;
            this.FiltrarButton.Text = "Filtrar";
            this.FiltrarButton.UseVisualStyleBackColor = true;
            this.FiltrarButton.Click += new System.EventHandler(this.FiltrarButton_Click);
            // 
            // QuitarFiltroButton
            // 
            this.QuitarFiltroButton.Location = new System.Drawing.Point(119, 102);
            this.QuitarFiltroButton.Name = "QuitarFiltroButton";
            this.QuitarFiltroButton.Size = new System.Drawing.Size(75, 23);
            this.QuitarFiltroButton.TabIndex = 10;
            this.QuitarFiltroButton.Text = "Quitar Filtro";
            this.QuitarFiltroButton.UseVisualStyleBackColor = true;
            this.QuitarFiltroButton.Click += new System.EventHandler(this.QuitarFiltroButton_Click);
            // 
            // BitacoraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 450);
            this.Controls.Add(this.SplitContainer1);
            this.Name = "BitacoraForm";
            this.Text = "Eventos ";
            this.Load += new System.EventHandler(this.BitacoraForm_Load);
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel1.PerformLayout();
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BitacoraBELBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaBitacora)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.SplitContainer SplitContainer1;
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