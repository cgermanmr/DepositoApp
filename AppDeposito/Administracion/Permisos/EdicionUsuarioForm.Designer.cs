namespace AppDeposito.Administracion.Permisos
{
    partial class EdicionUsuarioForm
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
            this.OKButton = new System.Windows.Forms.Button();
            this.cboIdioma = new System.Windows.Forms.ComboBox();
            this.lblCultura = new System.Windows.Forms.Label();
            this.lblBloqueado = new System.Windows.Forms.Label();
            this.chkBloqueado = new System.Windows.Forms.CheckBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblClave = new System.Windows.Forms.Label();
            this.lblRepetir = new System.Windows.Forms.Label();
            this.txtClaveRepetir = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelarButton
            // 
            this.CancelarButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CancelarButton.Location = new System.Drawing.Point(260, 195);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 50;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(179, 195);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 49;
            this.OKButton.Text = "Aceptar";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // cboIdioma
            // 
            this.cboIdioma.DisplayMember = "Nombre";
            this.cboIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIdioma.FormattingEnabled = true;
            this.cboIdioma.Location = new System.Drawing.Point(116, 155);
            this.cboIdioma.Name = "cboIdioma";
            this.cboIdioma.Size = new System.Drawing.Size(219, 21);
            this.cboIdioma.TabIndex = 40;
            // 
            // lblCultura
            // 
            this.lblCultura.AutoSize = true;
            this.lblCultura.Location = new System.Drawing.Point(45, 158);
            this.lblCultura.Name = "lblCultura";
            this.lblCultura.Size = new System.Drawing.Size(41, 13);
            this.lblCultura.TabIndex = 47;
            this.lblCultura.Tag = "43";
            this.lblCultura.Text = "Idioma:";
            // 
            // lblBloqueado
            // 
            this.lblBloqueado.AutoSize = true;
            this.lblBloqueado.Location = new System.Drawing.Point(43, 135);
            this.lblBloqueado.Name = "lblBloqueado";
            this.lblBloqueado.Size = new System.Drawing.Size(61, 13);
            this.lblBloqueado.TabIndex = 45;
            this.lblBloqueado.Tag = "42";
            this.lblBloqueado.Text = "Bloqueado:";
            // 
            // chkBloqueado
            // 
            this.chkBloqueado.AutoSize = true;
            this.chkBloqueado.Location = new System.Drawing.Point(116, 135);
            this.chkBloqueado.Name = "chkBloqueado";
            this.chkBloqueado.Size = new System.Drawing.Size(15, 14);
            this.chkBloqueado.TabIndex = 39;
            this.chkBloqueado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBloqueado.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(116, 109);
            this.txtEmail.MaxLength = 256;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(219, 20);
            this.txtEmail.TabIndex = 38;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(116, 31);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(219, 20);
            this.txtNombre.TabIndex = 35;
            this.txtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombre_Validating);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(43, 112);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 13);
            this.lblEmail.TabIndex = 46;
            this.lblEmail.Tag = "41";
            this.lblEmail.Text = "E-Mail:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(43, 34);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 42;
            this.lblNombre.Tag = "38";
            this.lblNombre.Text = "Nombre:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(43, 60);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(64, 13);
            this.lblClave.TabIndex = 43;
            this.lblClave.Tag = "39";
            this.lblClave.Text = "Contraseña:";
            // 
            // lblRepetir
            // 
            this.lblRepetir.AutoSize = true;
            this.lblRepetir.Location = new System.Drawing.Point(43, 86);
            this.lblRepetir.Name = "lblRepetir";
            this.lblRepetir.Size = new System.Drawing.Size(44, 13);
            this.lblRepetir.TabIndex = 44;
            this.lblRepetir.Tag = "40";
            this.lblRepetir.Text = "Repetir:";
            // 
            // txtClaveRepetir
            // 
            this.txtClaveRepetir.Location = new System.Drawing.Point(116, 83);
            this.txtClaveRepetir.MaxLength = 12;
            this.txtClaveRepetir.Name = "txtClaveRepetir";
            this.txtClaveRepetir.PasswordChar = '*';
            this.txtClaveRepetir.ReadOnly = true;
            this.txtClaveRepetir.Size = new System.Drawing.Size(219, 20);
            this.txtClaveRepetir.TabIndex = 37;
            this.txtClaveRepetir.Validating += new System.ComponentModel.CancelEventHandler(this.txtClaveRepetir_Validating);
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(116, 57);
            this.txtClave.MaxLength = 12;
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.ReadOnly = true;
            this.txtClave.Size = new System.Drawing.Size(219, 20);
            this.txtClave.TabIndex = 36;
            this.txtClave.Validating += new System.ComponentModel.CancelEventHandler(this.txtClave_Validating);
            // 
            // EdicionUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 237);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.cboIdioma);
            this.Controls.Add(this.lblCultura);
            this.Controls.Add(this.txtClaveRepetir);
            this.Controls.Add(this.lblRepetir);
            this.Controls.Add(this.lblBloqueado);
            this.Controls.Add(this.chkBloqueado);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblNombre);
            this.Name = "EdicionUsuarioForm";
            this.Text = "NuevoUsuarioForm";
            this.Load += new System.EventHandler(this.EdicionUsuarioForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button CancelarButton;
        internal System.Windows.Forms.Button OKButton;
        internal System.Windows.Forms.ComboBox cboIdioma;
        internal System.Windows.Forms.Label lblCultura;
        internal System.Windows.Forms.Label lblBloqueado;
        internal System.Windows.Forms.CheckBox chkBloqueado;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.Label lblEmail;
        internal System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ErrorProvider errorProvider;
        internal System.Windows.Forms.TextBox txtClaveRepetir;
        internal System.Windows.Forms.Label lblRepetir;
        internal System.Windows.Forms.TextBox txtClave;
        internal System.Windows.Forms.Label lblClave;
    }
}