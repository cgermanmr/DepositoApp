namespace AppDeposito
{
    partial class PresupuestoEditForm
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
            System.Windows.Forms.Label cotizacionLabel;
            System.Windows.Forms.Label tiempoEstimadoLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label fechaValidezLabel;
            System.Windows.Forms.Label razonSocialLabel1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.cotizacionTextBox = new System.Windows.Forms.TextBox();
            this.bsPresupuesto = new System.Windows.Forms.BindingSource(this.components);
            this.estadoCheckBox = new System.Windows.Forms.CheckBox();
            this.tiempoEstimadoTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaValidezDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AceptarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.bsProveedores = new System.Windows.Forms.BindingSource(this.components);
            this.proveedorComboBox = new System.Windows.Forms.ComboBox();
            this.cmbMoneda = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtOtProveedor = new System.Windows.Forms.TextBox();
            cotizacionLabel = new System.Windows.Forms.Label();
            tiempoEstimadoLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            fechaValidezLabel = new System.Windows.Forms.Label();
            razonSocialLabel1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsPresupuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cotizacionLabel
            // 
            cotizacionLabel.AutoSize = true;
            cotizacionLabel.Location = new System.Drawing.Point(86, 117);
            cotizacionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cotizacionLabel.Name = "cotizacionLabel";
            cotizacionLabel.Size = new System.Drawing.Size(87, 20);
            cotizacionLabel.TabIndex = 0;
            cotizacionLabel.Text = "Cotización:";
            // 
            // tiempoEstimadoLabel
            // 
            tiempoEstimadoLabel.AutoSize = true;
            tiempoEstimadoLabel.Location = new System.Drawing.Point(50, 162);
            tiempoEstimadoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tiempoEstimadoLabel.Name = "tiempoEstimadoLabel";
            tiempoEstimadoLabel.Size = new System.Drawing.Size(123, 20);
            tiempoEstimadoLabel.TabIndex = 14;
            tiempoEstimadoLabel.Text = "Estimado (días):";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(112, 35);
            fechaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(58, 20);
            fechaLabel.TabIndex = 15;
            fechaLabel.Text = "Fecha:";
            // 
            // fechaValidezLabel
            // 
            fechaValidezLabel.AutoSize = true;
            fechaValidezLabel.Location = new System.Drawing.Point(316, 162);
            fechaValidezLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fechaValidezLabel.Name = "fechaValidezLabel";
            fechaValidezLabel.Size = new System.Drawing.Size(114, 20);
            fechaValidezLabel.TabIndex = 16;
            fechaValidezLabel.Text = "Fecha Validez:";
            // 
            // razonSocialLabel1
            // 
            razonSocialLabel1.AutoSize = true;
            razonSocialLabel1.Location = new System.Drawing.Point(86, 78);
            razonSocialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            razonSocialLabel1.Name = "razonSocialLabel1";
            razonSocialLabel1.Size = new System.Drawing.Size(85, 20);
            razonSocialLabel1.TabIndex = 23;
            razonSocialLabel1.Text = "Proveedor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(50, 240);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(96, 20);
            label2.TabIndex = 28;
            label2.Text = "Descripción:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(86, 203);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(87, 20);
            label3.TabIndex = 30;
            label3.Text = "Cotización:";
            // 
            // cotizacionTextBox
            // 
            this.cotizacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPresupuesto, "Cotizacion", true));
            this.cotizacionTextBox.Location = new System.Drawing.Point(182, 117);
            this.cotizacionTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cotizacionTextBox.MaxLength = 15;
            this.cotizacionTextBox.Name = "cotizacionTextBox";
            this.cotizacionTextBox.Size = new System.Drawing.Size(126, 26);
            this.cotizacionTextBox.TabIndex = 1;
            // 
            // bsPresupuesto
            // 
            this.bsPresupuesto.DataSource = typeof(BEL.PresupuestoBEL);
            // 
            // estadoCheckBox
            // 
            this.estadoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsPresupuesto, "Autorizado", true));
            this.estadoCheckBox.Location = new System.Drawing.Point(321, 29);
            this.estadoCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.estadoCheckBox.Name = "estadoCheckBox";
            this.estadoCheckBox.Size = new System.Drawing.Size(128, 37);
            this.estadoCheckBox.TabIndex = 5;
            this.estadoCheckBox.Text = "Autorizado";
            this.estadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // tiempoEstimadoTextBox
            // 
            this.tiempoEstimadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPresupuesto, "TiempoEstimado", true));
            this.tiempoEstimadoTextBox.Location = new System.Drawing.Point(182, 157);
            this.tiempoEstimadoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tiempoEstimadoTextBox.MaxLength = 2;
            this.tiempoEstimadoTextBox.Name = "tiempoEstimadoTextBox";
            this.tiempoEstimadoTextBox.Size = new System.Drawing.Size(126, 26);
            this.tiempoEstimadoTextBox.TabIndex = 15;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsPresupuesto, "Fecha", true));
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(182, 31);
            this.fechaDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(126, 26);
            this.fechaDateTimePicker.TabIndex = 16;
            // 
            // fechaValidezDateTimePicker
            // 
            this.fechaValidezDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsPresupuesto, "FechaValidez", true));
            this.fechaValidezDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaValidezDateTimePicker.Location = new System.Drawing.Point(442, 157);
            this.fechaValidezDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fechaValidezDateTimePicker.Name = "fechaValidezDateTimePicker";
            this.fechaValidezDateTimePicker.Size = new System.Drawing.Size(126, 26);
            this.fechaValidezDateTimePicker.TabIndex = 17;
            // 
            // AceptarButton
            // 
            this.AceptarButton.Location = new System.Drawing.Point(336, 384);
            this.AceptarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(112, 35);
            this.AceptarButton.TabIndex = 20;
            this.AceptarButton.Text = "Aceptar";
            this.AceptarButton.UseVisualStyleBackColor = true;
            this.AceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(456, 384);
            this.CancelarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(112, 35);
            this.CancelarButton.TabIndex = 21;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // bsProveedores
            // 
            this.bsProveedores.DataSource = typeof(BEL.EmpresaBEL);
            // 
            // proveedorComboBox
            // 
            this.proveedorComboBox.DataSource = this.bsProveedores;
            this.proveedorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.proveedorComboBox.FormattingEnabled = true;
            this.proveedorComboBox.Location = new System.Drawing.Point(182, 75);
            this.proveedorComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.proveedorComboBox.Name = "proveedorComboBox";
            this.proveedorComboBox.Size = new System.Drawing.Size(386, 28);
            this.proveedorComboBox.TabIndex = 24;
            this.proveedorComboBox.SelectedIndexChanged += new System.EventHandler(this.razonSocialComboBox_SelectedIndexChanged);
            // 
            // cmbMoneda
            // 
            this.cmbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoneda.FormattingEnabled = true;
            this.cmbMoneda.Location = new System.Drawing.Point(442, 117);
            this.cmbMoneda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMoneda.Name = "cmbMoneda";
            this.cmbMoneda.Size = new System.Drawing.Size(126, 28);
            this.cmbMoneda.TabIndex = 25;
            this.cmbMoneda.SelectedIndexChanged += new System.EventHandler(this.cmbMoneda_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Moneda:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPresupuesto, "Descripcion", true));
            this.textBox1.Location = new System.Drawing.Point(54, 274);
            this.textBox1.MaxLength = 200;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(514, 102);
            this.textBox1.TabIndex = 27;
            // 
            // txtOtProveedor
            // 
            this.txtOtProveedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPresupuesto, "OtProveedor", true));
            this.txtOtProveedor.Location = new System.Drawing.Point(182, 203);
            this.txtOtProveedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOtProveedor.MaxLength = 20;
            this.txtOtProveedor.Name = "txtOtProveedor";
            this.txtOtProveedor.Size = new System.Drawing.Size(247, 26);
            this.txtOtProveedor.TabIndex = 29;
            // 
            // PresupuestoEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(622, 457);
            this.Controls.Add(label3);
            this.Controls.Add(this.txtOtProveedor);
            this.Controls.Add(label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMoneda);
            this.Controls.Add(razonSocialLabel1);
            this.Controls.Add(this.proveedorComboBox);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.AceptarButton);
            this.Controls.Add(fechaValidezLabel);
            this.Controls.Add(this.fechaValidezDateTimePicker);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(cotizacionLabel);
            this.Controls.Add(this.cotizacionTextBox);
            this.Controls.Add(this.estadoCheckBox);
            this.Controls.Add(tiempoEstimadoLabel);
            this.Controls.Add(this.tiempoEstimadoTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PresupuestoEditForm";
            this.Text = "Edición presupuesto";
            this.Load += new System.EventHandler(this.EdicionPresupuestoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsPresupuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsPresupuesto;
        private System.Windows.Forms.TextBox cotizacionTextBox;
        private System.Windows.Forms.CheckBox estadoCheckBox;
        private System.Windows.Forms.TextBox tiempoEstimadoTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaValidezDateTimePicker;
        private System.Windows.Forms.Button AceptarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.BindingSource bsProveedores;
        private System.Windows.Forms.ComboBox proveedorComboBox;
        private System.Windows.Forms.ComboBox cmbMoneda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtOtProveedor;
    }
}