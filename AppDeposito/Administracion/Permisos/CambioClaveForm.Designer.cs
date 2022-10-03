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
            this.CancelarButton.Location = new System.Drawing.Point(144, 152);
            this.CancelarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(112, 35);
            this.CancelarButton.TabIndex = 25;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // AceptarButton
            // 
            this.AceptarButton.Location = new System.Drawing.Point(22, 152);
            this.AceptarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(112, 35);
            this.AceptarButton.TabIndex = 24;
            this.AceptarButton.Text = "Aceptar";
            this.AceptarButton.UseVisualStyleBackColor = true;
            this.AceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // txtClaveRepetir
            // 
            this.txtClaveRepetir.Location = new System.Drawing.Point(22, 100);
            this.txtClaveRepetir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtClaveRepetir.MaxLength = 12;
            this.txtClaveRepetir.Name = "txtClaveRepetir";
            this.txtClaveRepetir.PasswordChar = '*';
            this.txtClaveRepetir.Size = new System.Drawing.Size(270, 26);
            this.txtClaveRepetir.TabIndex = 21;
            this.txtClaveRepetir.Validating += new System.ComponentModel.CancelEventHandler(this.txtClaveRepetir_Validating);
            // 
            // lblRepetir
            // 
            this.lblRepetir.AutoSize = true;
            this.lblRepetir.Location = new System.Drawing.Point(18, 74);
            this.lblRepetir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRepetir.Name = "lblRepetir";
            this.lblRepetir.Size = new System.Drawing.Size(166, 20);
            this.lblRepetir.TabIndex = 23;
            this.lblRepetir.Tag = "40";
            this.lblRepetir.Text = "Confirmar contraseña:";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(22, 38);
            this.txtClave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtClave.MaxLength = 12;
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(270, 26);
            this.txtClave.TabIndex = 20;
            this.txtClave.Validating += new System.ComponentModel.CancelEventHandler(this.txtClave_Validating);
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(18, 14);
            this.lblClave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(96, 20);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 206);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.AceptarButton);
            this.Controls.Add(this.txtClaveRepetir);
            this.Controls.Add(this.lblRepetir);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblClave);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CambioClaveForm";
            this.Text = "Cambio de clave";
            this.Load += new System.EventHandler(this.CambioClaveForm_Load);
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