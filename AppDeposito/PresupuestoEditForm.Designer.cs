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
            this.cotizacionTextBox = new System.Windows.Forms.TextBox();
            this.bsPresupuesto = new System.Windows.Forms.BindingSource(this.components);
            this.estadoCheckBox = new System.Windows.Forms.CheckBox();
            this.tiempoEstimadoTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaValidezDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AceptarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.bsProveedores = new System.Windows.Forms.BindingSource(this.components);
            this.razonSocialComboBox = new System.Windows.Forms.ComboBox();
            this.cmbMoneda = new System.Windows.Forms.ComboBox();
            this.bsMoneda = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            cotizacionLabel = new System.Windows.Forms.Label();
            tiempoEstimadoLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            fechaValidezLabel = new System.Windows.Forms.Label();
            razonSocialLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsPresupuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMoneda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cotizacionLabel
            // 
            cotizacionLabel.AutoSize = true;
            cotizacionLabel.Location = new System.Drawing.Point(36, 76);
            cotizacionLabel.Name = "cotizacionLabel";
            cotizacionLabel.Size = new System.Drawing.Size(59, 13);
            cotizacionLabel.TabIndex = 0;
            cotizacionLabel.Text = "Cotizacion:";
            // 
            // tiempoEstimadoLabel
            // 
            tiempoEstimadoLabel.AutoSize = true;
            tiempoEstimadoLabel.Location = new System.Drawing.Point(12, 105);
            tiempoEstimadoLabel.Name = "tiempoEstimadoLabel";
            tiempoEstimadoLabel.Size = new System.Drawing.Size(83, 13);
            tiempoEstimadoLabel.TabIndex = 14;
            tiempoEstimadoLabel.Text = "Estimado (días):";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(54, 25);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 15;
            fechaLabel.Text = "Fecha:";
            // 
            // fechaValidezLabel
            // 
            fechaValidezLabel.AutoSize = true;
            fechaValidezLabel.Location = new System.Drawing.Point(191, 105);
            fechaValidezLabel.Name = "fechaValidezLabel";
            fechaValidezLabel.Size = new System.Drawing.Size(77, 13);
            fechaValidezLabel.TabIndex = 16;
            fechaValidezLabel.Text = "Fecha Validez:";
            // 
            // razonSocialLabel1
            // 
            razonSocialLabel1.AutoSize = true;
            razonSocialLabel1.Location = new System.Drawing.Point(21, 52);
            razonSocialLabel1.Name = "razonSocialLabel1";
            razonSocialLabel1.Size = new System.Drawing.Size(73, 13);
            razonSocialLabel1.TabIndex = 23;
            razonSocialLabel1.Text = "Razon Social:";
            // 
            // cotizacionTextBox
            // 
            this.cotizacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPresupuesto, "Cotizacion", true));
            this.cotizacionTextBox.Location = new System.Drawing.Point(100, 76);
            this.cotizacionTextBox.Name = "cotizacionTextBox";
            this.cotizacionTextBox.Size = new System.Drawing.Size(85, 20);
            this.cotizacionTextBox.TabIndex = 1;
            // 
            // bsPresupuesto
            // 
            this.bsPresupuesto.DataSource = typeof(BEL.PresupuestoBEL);
            // 
            // estadoCheckBox
            // 
            this.estadoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsPresupuesto, "Estado", true));
            this.estadoCheckBox.Location = new System.Drawing.Point(191, 20);
            this.estadoCheckBox.Name = "estadoCheckBox";
            this.estadoCheckBox.Size = new System.Drawing.Size(85, 24);
            this.estadoCheckBox.TabIndex = 5;
            this.estadoCheckBox.Text = "Autorizado";
            this.estadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // tiempoEstimadoTextBox
            // 
            this.tiempoEstimadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPresupuesto, "TiempoEstimado", true));
            this.tiempoEstimadoTextBox.Location = new System.Drawing.Point(100, 102);
            this.tiempoEstimadoTextBox.Name = "tiempoEstimadoTextBox";
            this.tiempoEstimadoTextBox.Size = new System.Drawing.Size(85, 20);
            this.tiempoEstimadoTextBox.TabIndex = 15;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsPresupuesto, "Fecha", true));
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(100, 20);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(85, 20);
            this.fechaDateTimePicker.TabIndex = 16;
            // 
            // fechaValidezDateTimePicker
            // 
            this.fechaValidezDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsPresupuesto, "FechaValidez", true));
            this.fechaValidezDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaValidezDateTimePicker.Location = new System.Drawing.Point(274, 102);
            this.fechaValidezDateTimePicker.Name = "fechaValidezDateTimePicker";
            this.fechaValidezDateTimePicker.Size = new System.Drawing.Size(85, 20);
            this.fechaValidezDateTimePicker.TabIndex = 17;
            // 
            // AceptarButton
            // 
            this.AceptarButton.Location = new System.Drawing.Point(203, 137);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(75, 23);
            this.AceptarButton.TabIndex = 20;
            this.AceptarButton.Text = "Aceptar";
            this.AceptarButton.UseVisualStyleBackColor = true;
            this.AceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(284, 137);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 21;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // bsProveedores
            // 
            this.bsProveedores.DataSource = typeof(BEL.EmpresaBEL);
            // 
            // razonSocialComboBox
            // 
            this.razonSocialComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProveedores, "RazonSocial", true));
            this.razonSocialComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsPresupuesto, "Proveedor", true));
            this.razonSocialComboBox.DataSource = this.bsProveedores;
            this.razonSocialComboBox.DisplayMember = "RazonSocial";
            this.razonSocialComboBox.FormattingEnabled = true;
            this.razonSocialComboBox.Location = new System.Drawing.Point(100, 49);
            this.razonSocialComboBox.Name = "razonSocialComboBox";
            this.razonSocialComboBox.Size = new System.Drawing.Size(259, 21);
            this.razonSocialComboBox.TabIndex = 24;
            // 
            // cmbMoneda
            // 
            this.cmbMoneda.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsPresupuesto, "Moneda", true));
            this.cmbMoneda.DataSource = this.bsMoneda;
            this.cmbMoneda.DisplayMember = "Descripcion";
            this.cmbMoneda.FormattingEnabled = true;
            this.cmbMoneda.Location = new System.Drawing.Point(274, 76);
            this.cmbMoneda.Name = "cmbMoneda";
            this.cmbMoneda.Size = new System.Drawing.Size(85, 21);
            this.cmbMoneda.TabIndex = 25;
            // 
            // bsMoneda
            // 
            this.bsMoneda.DataSource = typeof(BEL.MonedaBEL);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Moneda:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // PresupuestoEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(399, 181);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMoneda);
            this.Controls.Add(razonSocialLabel1);
            this.Controls.Add(this.razonSocialComboBox);
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
            this.Name = "PresupuestoEditForm";
            this.Text = "Edición presupuesto";
            this.Load += new System.EventHandler(this.EdicionPresupuestoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsPresupuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMoneda)).EndInit();
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
        private System.Windows.Forms.ComboBox razonSocialComboBox;
        private System.Windows.Forms.ComboBox cmbMoneda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bsMoneda;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}