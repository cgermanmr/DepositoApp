namespace AppDeposito
{
    partial class UbicacionEditForm
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
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label direccionLabel1;
            this.bsEditado = new System.Windows.Forms.BindingSource(this.components);
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            descripcionLabel = new System.Windows.Forms.Label();
            direccionLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsEditado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(20, 19);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 2;
            descripcionLabel.Text = "Descripcion:";
            // 
            // direccionLabel1
            // 
            direccionLabel1.AutoSize = true;
            direccionLabel1.Location = new System.Drawing.Point(31, 49);
            direccionLabel1.Name = "direccionLabel1";
            direccionLabel1.Size = new System.Drawing.Size(55, 13);
            direccionLabel1.TabIndex = 4;
            direccionLabel1.Text = "Direccion:";
            // 
            // bsEditado
            // 
            this.bsEditado.DataSource = typeof(BEL.UbicacionBEL);
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsEditado, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(92, 19);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(295, 20);
            this.descripcionTextBox.TabIndex = 3;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(312, 88);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsEditado, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(92, 46);
            this.direccionTextBox.Multiline = true;
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(295, 35);
            this.direccionTextBox.TabIndex = 5;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // UbicacionEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 123);
            this.Controls.Add(direccionLabel1);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Name = "UbicacionEditForm";
            this.Text = "Edición Ubicación";
            this.Load += new System.EventHandler(this.UbicacionEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsEditado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.BindingSource bsEditado;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}