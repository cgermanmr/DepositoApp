namespace AppDeposito
{
    partial class ActivoDatosCompraForm
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
            System.Windows.Forms.Label valorCompraLabel;
            System.Windows.Forms.Label monedaLabel;
            System.Windows.Forms.Label fechaCompraLabel;
            System.Windows.Forms.Label periodoGarantiaLabel;
            System.Windows.Forms.Label fechaAltaLabel;
            this.bsActivo = new System.Windows.Forms.BindingSource(this.components);
            this.valorCompraTextBox = new System.Windows.Forms.TextBox();
            this.monedaTextBox = new System.Windows.Forms.TextBox();
            this.fechaCompraTextBox = new System.Windows.Forms.TextBox();
            this.fechaAltaTextBox = new System.Windows.Forms.TextBox();
            this.mesesGarantiaTextBox = new System.Windows.Forms.TextBox();
            valorCompraLabel = new System.Windows.Forms.Label();
            monedaLabel = new System.Windows.Forms.Label();
            fechaCompraLabel = new System.Windows.Forms.Label();
            periodoGarantiaLabel = new System.Windows.Forms.Label();
            fechaAltaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsActivo)).BeginInit();
            this.SuspendLayout();
            // 
            // valorCompraLabel
            // 
            valorCompraLabel.AutoSize = true;
            valorCompraLabel.Location = new System.Drawing.Point(32, 102);
            valorCompraLabel.Name = "valorCompraLabel";
            valorCompraLabel.Size = new System.Drawing.Size(73, 13);
            valorCompraLabel.TabIndex = 1;
            valorCompraLabel.Text = "Valor Compra:";
            // 
            // monedaLabel
            // 
            monedaLabel.AutoSize = true;
            monedaLabel.Location = new System.Drawing.Point(56, 76);
            monedaLabel.Name = "monedaLabel";
            monedaLabel.Size = new System.Drawing.Size(49, 13);
            monedaLabel.TabIndex = 4;
            monedaLabel.Text = "Moneda:";
            // 
            // fechaCompraLabel
            // 
            fechaCompraLabel.AutoSize = true;
            fechaCompraLabel.Location = new System.Drawing.Point(26, 24);
            fechaCompraLabel.Name = "fechaCompraLabel";
            fechaCompraLabel.Size = new System.Drawing.Size(79, 13);
            fechaCompraLabel.TabIndex = 6;
            fechaCompraLabel.Text = "Fecha Compra:";
            // 
            // periodoGarantiaLabel
            // 
            periodoGarantiaLabel.AutoSize = true;
            periodoGarantiaLabel.Location = new System.Drawing.Point(16, 128);
            periodoGarantiaLabel.Name = "periodoGarantiaLabel";
            periodoGarantiaLabel.Size = new System.Drawing.Size(92, 13);
            periodoGarantiaLabel.TabIndex = 8;
            periodoGarantiaLabel.Text = "Garantía (Meses):";
            // 
            // fechaAltaLabel
            // 
            fechaAltaLabel.AutoSize = true;
            fechaAltaLabel.Location = new System.Drawing.Point(44, 50);
            fechaAltaLabel.Name = "fechaAltaLabel";
            fechaAltaLabel.Size = new System.Drawing.Size(61, 13);
            fechaAltaLabel.TabIndex = 10;
            fechaAltaLabel.Text = "Fecha Alta:";
            // 
            // bsActivo
            // 
            this.bsActivo.DataSource = typeof(BEL.ActivoBEL);
            // 
            // valorCompraTextBox
            // 
            this.valorCompraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsActivo, "ValorCompra", true));
            this.valorCompraTextBox.Location = new System.Drawing.Point(111, 99);
            this.valorCompraTextBox.Name = "valorCompraTextBox";
            this.valorCompraTextBox.Size = new System.Drawing.Size(100, 20);
            this.valorCompraTextBox.TabIndex = 2;
            // 
            // monedaTextBox
            // 
            this.monedaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsActivo, "Moneda", true));
            this.monedaTextBox.Location = new System.Drawing.Point(111, 73);
            this.monedaTextBox.Name = "monedaTextBox";
            this.monedaTextBox.Size = new System.Drawing.Size(100, 20);
            this.monedaTextBox.TabIndex = 5;
            // 
            // fechaCompraTextBox
            // 
            this.fechaCompraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsActivo, "FechaCompra", true));
            this.fechaCompraTextBox.Location = new System.Drawing.Point(111, 21);
            this.fechaCompraTextBox.Name = "fechaCompraTextBox";
            this.fechaCompraTextBox.Size = new System.Drawing.Size(100, 20);
            this.fechaCompraTextBox.TabIndex = 7;
            // 
            // fechaAltaTextBox
            // 
            this.fechaAltaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsActivo, "FechaAlta", true));
            this.fechaAltaTextBox.Location = new System.Drawing.Point(111, 47);
            this.fechaAltaTextBox.Name = "fechaAltaTextBox";
            this.fechaAltaTextBox.Size = new System.Drawing.Size(100, 20);
            this.fechaAltaTextBox.TabIndex = 11;
            // 
            // mesesGarantiaTextBox
            // 
            this.mesesGarantiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsActivo, "MesesGarantia", true));
            this.mesesGarantiaTextBox.Location = new System.Drawing.Point(111, 125);
            this.mesesGarantiaTextBox.Name = "mesesGarantiaTextBox";
            this.mesesGarantiaTextBox.Size = new System.Drawing.Size(100, 20);
            this.mesesGarantiaTextBox.TabIndex = 12;
            // 
            // ActivoDatosCompraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 164);
            this.Controls.Add(this.mesesGarantiaTextBox);
            this.Controls.Add(fechaAltaLabel);
            this.Controls.Add(this.fechaAltaTextBox);
            this.Controls.Add(periodoGarantiaLabel);
            this.Controls.Add(fechaCompraLabel);
            this.Controls.Add(this.fechaCompraTextBox);
            this.Controls.Add(monedaLabel);
            this.Controls.Add(this.monedaTextBox);
            this.Controls.Add(valorCompraLabel);
            this.Controls.Add(this.valorCompraTextBox);
            this.Name = "ActivoDatosCompraForm";
            this.Text = "Datos Compra";
            this.Load += new System.EventHandler(this.ActivoDatosCompraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsActivo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox valorCompraTextBox;
        private System.Windows.Forms.TextBox monedaTextBox;
        private System.Windows.Forms.TextBox fechaCompraTextBox;
        private System.Windows.Forms.TextBox fechaAltaTextBox;
        public System.Windows.Forms.BindingSource bsActivo;
        private System.Windows.Forms.TextBox mesesGarantiaTextBox;
    }
}