namespace AppDeposito
{
    partial class EdicionDepositoForm
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
            System.Windows.Forms.Label capacidadLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label ubicacionLabel;
            this.capacidadTextBox = new System.Windows.Forms.TextBox();
            this.bsDeposito = new System.Windows.Forms.BindingSource(this.components);
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.ubicacionComboBox = new System.Windows.Forms.ComboBox();
            this.AceptarButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            capacidadLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            ubicacionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsDeposito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // capacidadLabel
            // 
            capacidadLabel.AutoSize = true;
            capacidadLabel.Location = new System.Drawing.Point(26, 51);
            capacidadLabel.Name = "capacidadLabel";
            capacidadLabel.Size = new System.Drawing.Size(61, 13);
            capacidadLabel.TabIndex = 1;
            capacidadLabel.Text = "Capacidad:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(21, 25);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 2;
            descripcionLabel.Text = "Descripcion:";
            // 
            // ubicacionLabel
            // 
            ubicacionLabel.AutoSize = true;
            ubicacionLabel.Location = new System.Drawing.Point(29, 77);
            ubicacionLabel.Name = "ubicacionLabel";
            ubicacionLabel.Size = new System.Drawing.Size(58, 13);
            ubicacionLabel.TabIndex = 4;
            ubicacionLabel.Text = "Ubicacion:";
            // 
            // capacidadTextBox
            // 
            this.capacidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeposito, "Capacidad", true));
            this.capacidadTextBox.Location = new System.Drawing.Point(93, 48);
            this.capacidadTextBox.Name = "capacidadTextBox";
            this.capacidadTextBox.Size = new System.Drawing.Size(46, 20);
            this.capacidadTextBox.TabIndex = 2;
            // 
            // bsDeposito
            // 
            this.bsDeposito.DataSource = typeof(BEL.DepositoBEL);
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeposito, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(93, 22);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(282, 20);
            this.descripcionTextBox.TabIndex = 3;
            // 
            // ubicacionComboBox
            // 
            this.ubicacionComboBox.CausesValidation = false;
            this.ubicacionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDeposito, "Ubicacion", true));
            this.ubicacionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ubicacionComboBox.FormattingEnabled = true;
            this.ubicacionComboBox.Location = new System.Drawing.Point(93, 74);
            this.ubicacionComboBox.Name = "ubicacionComboBox";
            this.ubicacionComboBox.Size = new System.Drawing.Size(282, 21);
            this.ubicacionComboBox.TabIndex = 5;
            // 
            // AceptarButton
            // 
            this.AceptarButton.Location = new System.Drawing.Point(300, 106);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(75, 23);
            this.AceptarButton.TabIndex = 6;
            this.AceptarButton.Text = "Aceptar";
            this.AceptarButton.UseVisualStyleBackColor = true;
            this.AceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // EdicionDepositoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 141);
            this.Controls.Add(this.AceptarButton);
            this.Controls.Add(ubicacionLabel);
            this.Controls.Add(this.ubicacionComboBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(capacidadLabel);
            this.Controls.Add(this.capacidadTextBox);
            this.Name = "EdicionDepositoForm";
            this.Text = "Edición Deposito";
            this.Load += new System.EventHandler(this.EdicionDepositoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsDeposito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsDeposito;
        private System.Windows.Forms.TextBox capacidadTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.ComboBox ubicacionComboBox;
        private System.Windows.Forms.Button AceptarButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}