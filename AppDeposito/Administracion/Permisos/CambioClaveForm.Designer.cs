namespace AppDeposito.Administracion.Permisos
{
    partial class CambioClaveForm
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
            this.CancelarButton = new System.Windows.Forms.Button();
            this.AceptarButton = new System.Windows.Forms.Button();
            this.txtClaveRepetir = new System.Windows.Forms.TextBox();
            this.lblRepetir = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelarButton
            // 
            this.CancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarButton.Location = new System.Drawing.Point(96, 99);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 25;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // AceptarButton
            // 
            this.AceptarButton.Location = new System.Drawing.Point(15, 99);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(75, 23);
            this.AceptarButton.TabIndex = 24;
            this.AceptarButton.Text = "Aceptar";
            this.AceptarButton.UseVisualStyleBackColor = true;
            this.AceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // txtClaveRepetir
            // 
            this.txtClaveRepetir.Location = new System.Drawing.Point(15, 65);
            this.txtClaveRepetir.MaxLength = 12;
            this.txtClaveRepetir.Name = "txtClaveRepetir";
            this.txtClaveRepetir.PasswordChar = '*';
            this.txtClaveRepetir.Size = new System.Drawing.Size(181, 20);
            this.txtClaveRepetir.TabIndex = 21;
            this.txtClaveRepetir.Validating += new System.ComponentModel.CancelEventHandler(this.txtClaveRepetir_Validating);
            // 
            // lblRepetir
            // 
            this.lblRepetir.AutoSize = true;
            this.lblRepetir.Location = new System.Drawing.Point(12, 48);
            this.lblRepetir.Name = "lblRepetir";
            this.lblRepetir.Size = new System.Drawing.Size(110, 13);
            this.lblRepetir.TabIndex = 23;
            this.lblRepetir.Tag = "40";
            this.lblRepetir.Text = "Confirmar contraseña:";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(15, 25);
            this.txtClave.MaxLength = 12;
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(181, 20);
            this.txtClave.TabIndex = 20;
            this.txtClave.Validating += new System.ComponentModel.CancelEventHandler(this.txtClave_Validating);
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(12, 9);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(64, 13);
            this.lblClave.TabIndex = 22;
            this.lblClave.Tag = "39";
            this.lblClave.Text = "Contraseña:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // CambioClaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 134);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.AceptarButton);
            this.Controls.Add(this.txtClaveRepetir);
            this.Controls.Add(this.lblRepetir);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblClave);
            this.Name = "CambioClaveForm";
            this.Text = "Cambio de clave";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button CancelarButton;
        internal System.Windows.Forms.Button AceptarButton;
        internal System.Windows.Forms.TextBox txtClaveRepetir;
        internal System.Windows.Forms.Label lblRepetir;
        internal System.Windows.Forms.TextBox txtClave;
        internal System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}