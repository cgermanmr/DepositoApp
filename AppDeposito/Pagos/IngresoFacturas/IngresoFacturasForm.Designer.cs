namespace AppDeposito.Pagos
{
    partial class IngresoFacturasForm
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
            System.Windows.Forms.Label cuitProveedorLabel;
            System.Windows.Forms.Label nroFacturaLabel;
            System.Windows.Forms.Label letraLabel;
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label fechaEmisionLabel;
            System.Windows.Forms.Label fechaVtoLabel;
            System.Windows.Forms.Label importeLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cuitProveedorTextBox = new System.Windows.Forms.TextBox();
            this.bsFacturas = new System.Windows.Forms.BindingSource(this.components);
            this.letraTextBox = new System.Windows.Forms.TextBox();
            this.nroFacturaTextBox = new System.Windows.Forms.TextBox();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.fechaEmisionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaVtoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.importeTextBox = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.conceptosDataGridView = new System.Windows.Forms.DataGridView();
            this.bsConceptos = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cuitProveedorLabel = new System.Windows.Forms.Label();
            nroFacturaLabel = new System.Windows.Forms.Label();
            letraLabel = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            fechaEmisionLabel = new System.Windows.Forms.Label();
            fechaVtoLabel = new System.Windows.Forms.Label();
            importeLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conceptosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConceptos)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cuitProveedorLabel
            // 
            cuitProveedorLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            cuitProveedorLabel.AutoSize = true;
            cuitProveedorLabel.Location = new System.Drawing.Point(13, 8);
            cuitProveedorLabel.Name = "cuitProveedorLabel";
            cuitProveedorLabel.Size = new System.Drawing.Size(80, 13);
            cuitProveedorLabel.TabIndex = 0;
            cuitProveedorLabel.Text = "Cuit Proveedor:";
            // 
            // nroFacturaLabel
            // 
            nroFacturaLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            nroFacturaLabel.AutoSize = true;
            nroFacturaLabel.Location = new System.Drawing.Point(27, 37);
            nroFacturaLabel.Name = "nroFacturaLabel";
            nroFacturaLabel.Size = new System.Drawing.Size(66, 13);
            nroFacturaLabel.TabIndex = 2;
            nroFacturaLabel.Text = "Nro Factura:";
            // 
            // letraLabel
            // 
            letraLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            letraLabel.AutoSize = true;
            letraLabel.Location = new System.Drawing.Point(59, 95);
            letraLabel.Name = "letraLabel";
            letraLabel.Size = new System.Drawing.Size(34, 13);
            letraLabel.TabIndex = 4;
            letraLabel.Text = "Letra:";
            // 
            // codigoLabel
            // 
            codigoLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(50, 66);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(43, 13);
            codigoLabel.TabIndex = 6;
            codigoLabel.Text = "Codigo:";
            // 
            // fechaEmisionLabel
            // 
            fechaEmisionLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            fechaEmisionLabel.AutoSize = true;
            fechaEmisionLabel.Location = new System.Drawing.Point(229, 37);
            fechaEmisionLabel.Name = "fechaEmisionLabel";
            fechaEmisionLabel.Size = new System.Drawing.Size(79, 13);
            fechaEmisionLabel.TabIndex = 8;
            fechaEmisionLabel.Text = "Fecha Emision:";
            // 
            // fechaVtoLabel
            // 
            fechaVtoLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            fechaVtoLabel.AutoSize = true;
            fechaVtoLabel.Location = new System.Drawing.Point(249, 66);
            fechaVtoLabel.Name = "fechaVtoLabel";
            fechaVtoLabel.Size = new System.Drawing.Size(59, 13);
            fechaVtoLabel.TabIndex = 10;
            fechaVtoLabel.Text = "Fecha Vto:";
            // 
            // importeLabel
            // 
            importeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            importeLabel.AutoSize = true;
            importeLabel.Location = new System.Drawing.Point(236, 95);
            importeLabel.Name = "importeLabel";
            importeLabel.Size = new System.Drawing.Size(72, 13);
            importeLabel.TabIndex = 12;
            importeLabel.Text = "Importe Total:";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(235, 8);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(73, 13);
            label1.TabIndex = 14;
            label1.Text = "Razón Social:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.0596F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.70199F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.0596F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.17881F));
            this.tableLayoutPanel1.Controls.Add(cuitProveedorLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cuitProveedorTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.letraTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(letraLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(nroFacturaLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nroFacturaTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(codigoLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.codigoTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(fechaEmisionLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.fechaEmisionDateTimePicker, 3, 1);
            this.tableLayoutPanel1.Controls.Add(fechaVtoLabel, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.fechaVtoDateTimePicker, 3, 2);
            this.tableLayoutPanel1.Controls.Add(importeLabel, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.importeTextBox, 3, 3);
            this.tableLayoutPanel1.Controls.Add(label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtRazonSocial, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 47);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(604, 117);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cuitProveedorTextBox
            // 
            this.cuitProveedorTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cuitProveedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFacturas, "CuitProveedor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cuitProveedorTextBox.Location = new System.Drawing.Point(99, 4);
            this.cuitProveedorTextBox.MaxLength = 11;
            this.cuitProveedorTextBox.Name = "cuitProveedorTextBox";
            this.cuitProveedorTextBox.Size = new System.Drawing.Size(100, 20);
            this.cuitProveedorTextBox.TabIndex = 1;
            this.cuitProveedorTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.cuitProveedorTextBox_Validating);
            // 
            // bsFacturas
            // 
            this.bsFacturas.DataSource = typeof(BEL.FacturaReparacionBEL);
            // 
            // letraTextBox
            // 
            this.letraTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.letraTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.letraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFacturas, "Letra", true));
            this.letraTextBox.Location = new System.Drawing.Point(99, 92);
            this.letraTextBox.MaxLength = 1;
            this.letraTextBox.Name = "letraTextBox";
            this.letraTextBox.Size = new System.Drawing.Size(100, 20);
            this.letraTextBox.TabIndex = 5;
            // 
            // nroFacturaTextBox
            // 
            this.nroFacturaTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nroFacturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFacturas, "NroFactura", true));
            this.nroFacturaTextBox.Location = new System.Drawing.Point(99, 33);
            this.nroFacturaTextBox.MaxLength = 15;
            this.nroFacturaTextBox.Name = "nroFacturaTextBox";
            this.nroFacturaTextBox.Size = new System.Drawing.Size(100, 20);
            this.nroFacturaTextBox.TabIndex = 3;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFacturas, "Codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(99, 62);
            this.codigoTextBox.MaxLength = 2;
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(100, 20);
            this.codigoTextBox.TabIndex = 7;
            // 
            // fechaEmisionDateTimePicker
            // 
            this.fechaEmisionDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fechaEmisionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsFacturas, "FechaEmision", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.fechaEmisionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaEmisionDateTimePicker.Location = new System.Drawing.Point(314, 33);
            this.fechaEmisionDateTimePicker.Name = "fechaEmisionDateTimePicker";
            this.fechaEmisionDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.fechaEmisionDateTimePicker.TabIndex = 9;
            // 
            // fechaVtoDateTimePicker
            // 
            this.fechaVtoDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fechaVtoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsFacturas, "FechaVto", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.fechaVtoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaVtoDateTimePicker.Location = new System.Drawing.Point(314, 62);
            this.fechaVtoDateTimePicker.Name = "fechaVtoDateTimePicker";
            this.fechaVtoDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.fechaVtoDateTimePicker.TabIndex = 11;
            // 
            // importeTextBox
            // 
            this.importeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.importeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFacturas, "Importe", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.importeTextBox.Location = new System.Drawing.Point(314, 92);
            this.importeTextBox.Name = "importeTextBox";
            this.importeTextBox.ReadOnly = true;
            this.importeTextBox.Size = new System.Drawing.Size(100, 20);
            this.importeTextBox.TabIndex = 13;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtRazonSocial.Location = new System.Drawing.Point(314, 4);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.ReadOnly = true;
            this.txtRazonSocial.Size = new System.Drawing.Size(270, 20);
            this.txtRazonSocial.TabIndex = 15;
            // 
            // conceptosDataGridView
            // 
            this.conceptosDataGridView.AllowUserToAddRows = false;
            this.conceptosDataGridView.AllowUserToDeleteRows = false;
            this.conceptosDataGridView.AutoGenerateColumns = false;
            this.conceptosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.conceptosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.conceptosDataGridView.DataSource = this.bsConceptos;
            this.conceptosDataGridView.Location = new System.Drawing.Point(12, 199);
            this.conceptosDataGridView.Name = "conceptosDataGridView";
            this.conceptosDataGridView.RowHeadersVisible = false;
            this.conceptosDataGridView.RowHeadersWidth = 62;
            this.conceptosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.conceptosDataGridView.Size = new System.Drawing.Size(604, 207);
            this.conceptosDataGridView.TabIndex = 1;
            this.conceptosDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.conceptosDataGridView_CellBeginEdit);
            this.conceptosDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.conceptosDataGridView_CellValidating);
            // 
            // bsConceptos
            // 
            this.bsConceptos.DataMember = "Conceptos";
            this.bsConceptos.DataSource = this.bsFacturas;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 423);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(630, 33);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.Location = new System.Drawing.Point(552, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.Location = new System.Drawing.Point(471, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Agregar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(89, 170);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Quitar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 18);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "Buscar Proveedor";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "OtReparacion";
            this.dataGridViewTextBoxColumn2.HeaderText = "OT Reparación";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 15;
            this.dataGridViewTextBoxColumn2.MinimumWidth = 110;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 110;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn3.MaxInputLength = 200;
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Importe";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn4.HeaderText = "Importe";
            this.dataGridViewTextBoxColumn4.MaxInputLength = 15;
            this.dataGridViewTextBoxColumn4.MinimumWidth = 80;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // IngresoFacturasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 456);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.conceptosDataGridView);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "IngresoFacturasForm";
            this.Text = "Ingreso de Facturas";
            this.Load += new System.EventHandler(this.IngresoFacturasForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conceptosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConceptos)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsFacturas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox importeTextBox;
        private System.Windows.Forms.DateTimePicker fechaEmisionDateTimePicker;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox letraTextBox;
        private System.Windows.Forms.TextBox nroFacturaTextBox;
        private System.Windows.Forms.TextBox cuitProveedorTextBox;
        private System.Windows.Forms.DateTimePicker fechaVtoDateTimePicker;
        private System.Windows.Forms.BindingSource bsConceptos;
        private System.Windows.Forms.DataGridView conceptosDataGridView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}