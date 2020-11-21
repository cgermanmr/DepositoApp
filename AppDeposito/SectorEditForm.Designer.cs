namespace AppDeposito
{
    partial class SectorEditForm
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
            System.Windows.Forms.Label centroCostoLabel;
            System.Windows.Forms.Label descripcionLabel;
            this.bsEditado = new System.Windows.Forms.BindingSource(this.components);
            this.centroCostoTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            centroCostoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsEditado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // centroCostoLabel
            // 
            centroCostoLabel.AutoSize = true;
            centroCostoLabel.Location = new System.Drawing.Point(15, 18);
            centroCostoLabel.Name = "centroCostoLabel";
            centroCostoLabel.Size = new System.Drawing.Size(71, 13);
            centroCostoLabel.TabIndex = 1;
            centroCostoLabel.Text = "Centro Costo:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(20, 41);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 2;
            descripcionLabel.Text = "Descripcion:";
            // 
            // bsEditado
            // 
            this.bsEditado.DataSource = typeof(BEL.SectorBEL);
            // 
            // centroCostoTextBox
            // 
            this.centroCostoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsEditado, "CentroCosto", true));
            this.centroCostoTextBox.Location = new System.Drawing.Point(92, 15);
            this.centroCostoTextBox.Name = "centroCostoTextBox";
            this.centroCostoTextBox.Size = new System.Drawing.Size(206, 20);
            this.centroCostoTextBox.TabIndex = 2;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsEditado, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(92, 41);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(206, 50);
            this.descripcionTextBox.TabIndex = 3;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(223, 97);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // SectorEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 133);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(centroCostoLabel);
            this.Controls.Add(this.centroCostoTextBox);
            this.Name = "SectorEditForm";
            this.Text = "Edición Sector";
            this.Load += new System.EventHandler(this.SectorEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsEditado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox centroCostoTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.BindingSource bsEditado;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}