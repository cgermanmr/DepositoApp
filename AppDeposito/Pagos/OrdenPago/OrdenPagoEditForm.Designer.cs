namespace AppDeposito.Pagos
{
    partial class OrdenPagoEditForm
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
            System.Windows.Forms.Label fechaPagoLabel;
            System.Windows.Forms.Label importeLabel;
            System.Windows.Forms.Label fechaEmisionLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.CuitTextBox = new System.Windows.Forms.TextBox();
            this.RazonSocialTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.facturaModelViewDataGridView = new System.Windows.Forms.DataGridView();
            this.nroFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDetalles = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.fechaPagoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.importeTextBox = new System.Windows.Forms.TextBox();
            this.fechaEmisionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pagadoCheckBox = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.bsOrdenPago = new System.Windows.Forms.BindingSource(this.components);
            fechaPagoLabel = new System.Windows.Forms.Label();
            importeLabel = new System.Windows.Forms.Label();
            fechaEmisionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.facturaModelViewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrdenPago)).BeginInit();
            this.SuspendLayout();
            // 
            // fechaPagoLabel
            // 
            fechaPagoLabel.AutoSize = true;
            fechaPagoLabel.Location = new System.Drawing.Point(168, 23);
            fechaPagoLabel.Name = "fechaPagoLabel";
            fechaPagoLabel.Size = new System.Drawing.Size(68, 13);
            fechaPagoLabel.TabIndex = 8;
            fechaPagoLabel.Text = "Fecha Pago:";
            // 
            // importeLabel
            // 
            importeLabel.AutoSize = true;
            importeLabel.Location = new System.Drawing.Point(6, 22);
            importeLabel.Name = "importeLabel";
            importeLabel.Size = new System.Drawing.Size(45, 13);
            importeLabel.TabIndex = 10;
            importeLabel.Text = "Importe:";
            // 
            // fechaEmisionLabel
            // 
            fechaEmisionLabel.AutoSize = true;
            fechaEmisionLabel.Location = new System.Drawing.Point(347, 23);
            fechaEmisionLabel.Name = "fechaEmisionLabel";
            fechaEmisionLabel.Size = new System.Drawing.Size(79, 13);
            fechaEmisionLabel.TabIndex = 12;
            fechaEmisionLabel.Text = "Fecha Emision:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(416, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buscar Proveedor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CuitTextBox
            // 
            this.CuitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrdenPago, "CuitProveedor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CuitTextBox.Location = new System.Drawing.Point(57, 52);
            this.CuitTextBox.Name = "CuitTextBox";
            this.CuitTextBox.ReadOnly = true;
            this.CuitTextBox.Size = new System.Drawing.Size(100, 20);
            this.CuitTextBox.TabIndex = 1;
            // 
            // RazonSocialTextBox
            // 
            this.RazonSocialTextBox.Location = new System.Drawing.Point(242, 52);
            this.RazonSocialTextBox.Name = "RazonSocialTextBox";
            this.RazonSocialTextBox.ReadOnly = true;
            this.RazonSocialTextBox.Size = new System.Drawing.Size(168, 20);
            this.RazonSocialTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Razon Social:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CUIT:";
            // 
            // facturaModelViewDataGridView
            // 
            this.facturaModelViewDataGridView.AllowUserToAddRows = false;
            this.facturaModelViewDataGridView.AllowUserToDeleteRows = false;
            this.facturaModelViewDataGridView.AutoGenerateColumns = false;
            this.facturaModelViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facturaModelViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroFacturaDataGridViewTextBoxColumn,
            this.Descripcion,
            this.importeDataGridViewTextBoxColumn});
            this.facturaModelViewDataGridView.DataSource = this.bsDetalles;
            this.facturaModelViewDataGridView.Location = new System.Drawing.Point(12, 118);
            this.facturaModelViewDataGridView.Name = "facturaModelViewDataGridView";
            this.facturaModelViewDataGridView.ReadOnly = true;
            this.facturaModelViewDataGridView.RowHeadersVisible = false;
            this.facturaModelViewDataGridView.Size = new System.Drawing.Size(516, 208);
            this.facturaModelViewDataGridView.TabIndex = 5;
            this.facturaModelViewDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.facturaModelViewDataGridView_DataError);
            // 
            // nroFacturaDataGridViewTextBoxColumn
            // 
            this.nroFacturaDataGridViewTextBoxColumn.DataPropertyName = "NroFactura";
            this.nroFacturaDataGridViewTextBoxColumn.HeaderText = "Nro Factura";
            this.nroFacturaDataGridViewTextBoxColumn.Name = "nroFacturaDataGridViewTextBoxColumn";
            this.nroFacturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // importeDataGridViewTextBoxColumn
            // 
            this.importeDataGridViewTextBoxColumn.DataPropertyName = "Importe";
            this.importeDataGridViewTextBoxColumn.HeaderText = "Importe";
            this.importeDataGridViewTextBoxColumn.Name = "importeDataGridViewTextBoxColumn";
            this.importeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsDetalles
            // 
            this.bsDetalles.DataSource = typeof(BEL.OrdenPagoDetalleBEL);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(364, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Aceptar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(445, 332);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // fechaPagoDateTimePicker
            // 
            this.fechaPagoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsOrdenPago, "FechaPago", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.fechaPagoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaPagoDateTimePicker.Location = new System.Drawing.Point(242, 19);
            this.fechaPagoDateTimePicker.Name = "fechaPagoDateTimePicker";
            this.fechaPagoDateTimePicker.Size = new System.Drawing.Size(86, 20);
            this.fechaPagoDateTimePicker.TabIndex = 9;
            // 
            // importeTextBox
            // 
            this.importeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrdenPago, "Importe", true));
            this.importeTextBox.Location = new System.Drawing.Point(57, 19);
            this.importeTextBox.Name = "importeTextBox";
            this.importeTextBox.ReadOnly = true;
            this.importeTextBox.Size = new System.Drawing.Size(100, 20);
            this.importeTextBox.TabIndex = 11;
            // 
            // fechaEmisionDateTimePicker
            // 
            this.fechaEmisionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsOrdenPago, "FechaEmision", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.fechaEmisionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaEmisionDateTimePicker.Location = new System.Drawing.Point(432, 19);
            this.fechaEmisionDateTimePicker.Name = "fechaEmisionDateTimePicker";
            this.fechaEmisionDateTimePicker.Size = new System.Drawing.Size(86, 20);
            this.fechaEmisionDateTimePicker.TabIndex = 13;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 89);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Agregar Facturas";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 332);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(180, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = "Eliminar Factura Seleccionada";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pagadoCheckBox
            // 
            this.pagadoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsOrdenPago, "Pagado", true));
            this.pagadoCheckBox.Location = new System.Drawing.Point(242, 88);
            this.pagadoCheckBox.Name = "pagadoCheckBox";
            this.pagadoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.pagadoCheckBox.TabIndex = 17;
            this.pagadoCheckBox.Text = "Pagado";
            this.pagadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsOrdenPago, "Anulado", true));
            this.checkBox1.Location = new System.Drawing.Point(322, 88);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 24);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Anulado";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // bsOrdenPago
            // 
            this.bsOrdenPago.DataSource = typeof(BEL.OrdenPagoBEL);
            // 
            // OrdenPagoEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 375);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pagadoCheckBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(fechaEmisionLabel);
            this.Controls.Add(this.fechaEmisionDateTimePicker);
            this.Controls.Add(importeLabel);
            this.Controls.Add(this.importeTextBox);
            this.Controls.Add(fechaPagoLabel);
            this.Controls.Add(this.fechaPagoDateTimePicker);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.facturaModelViewDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RazonSocialTextBox);
            this.Controls.Add(this.CuitTextBox);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OrdenPagoEditForm";
            this.Text = "Edición Orden Pago ";
            this.Load += new System.EventHandler(this.OrdenPagoEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facturaModelViewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrdenPago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox CuitTextBox;
        private System.Windows.Forms.TextBox RazonSocialTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bsDetalles;
        private System.Windows.Forms.DataGridView facturaModelViewDataGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource bsOrdenPago;
        private System.Windows.Forms.DateTimePicker fechaPagoDateTimePicker;
        private System.Windows.Forms.TextBox importeTextBox;
        private System.Windows.Forms.DateTimePicker fechaEmisionDateTimePicker;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox pagadoCheckBox;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}