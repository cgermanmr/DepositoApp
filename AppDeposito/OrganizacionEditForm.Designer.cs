namespace AppDeposito
{
    partial class OrganizacionEditForm
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
            System.Windows.Forms.Label ciudadLabel;
            System.Windows.Forms.Label codigoPostalLabel;
            System.Windows.Forms.Label contactoLabel;
            System.Windows.Forms.Label cUITLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label razonSocialLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label observacionesLabel;
            this.ciudadTextBox = new System.Windows.Forms.TextBox();
            this.bsOrganizacion = new System.Windows.Forms.BindingSource(this.components);
            this.codigoPostalTextBox = new System.Windows.Forms.TextBox();
            this.contactoTextBox = new System.Windows.Forms.TextBox();
            this.cUITTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.razonSocialTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.AceptarButton = new System.Windows.Forms.Button();
            this.observacionesTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ciudadLabel = new System.Windows.Forms.Label();
            codigoPostalLabel = new System.Windows.Forms.Label();
            contactoLabel = new System.Windows.Forms.Label();
            cUITLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            razonSocialLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            observacionesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrganizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ciudadLabel
            // 
            ciudadLabel.AutoSize = true;
            ciudadLabel.Location = new System.Drawing.Point(254, 104);
            ciudadLabel.Name = "ciudadLabel";
            ciudadLabel.Size = new System.Drawing.Size(43, 13);
            ciudadLabel.TabIndex = 1;
            ciudadLabel.Text = "Ciudad:";
            // 
            // codigoPostalLabel
            // 
            codigoPostalLabel.AutoSize = true;
            codigoPostalLabel.Location = new System.Drawing.Point(222, 78);
            codigoPostalLabel.Name = "codigoPostalLabel";
            codigoPostalLabel.Size = new System.Drawing.Size(75, 13);
            codigoPostalLabel.TabIndex = 3;
            codigoPostalLabel.Text = "Codigo Postal:";
            // 
            // contactoLabel
            // 
            contactoLabel.AutoSize = true;
            contactoLabel.Location = new System.Drawing.Point(49, 52);
            contactoLabel.Name = "contactoLabel";
            contactoLabel.Size = new System.Drawing.Size(53, 13);
            contactoLabel.TabIndex = 5;
            contactoLabel.Text = "Contacto:";
            // 
            // cUITLabel
            // 
            cUITLabel.AutoSize = true;
            cUITLabel.Location = new System.Drawing.Point(262, 26);
            cUITLabel.Name = "cUITLabel";
            cUITLabel.Size = new System.Drawing.Size(35, 13);
            cUITLabel.TabIndex = 7;
            cUITLabel.Text = "CUIT:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(47, 104);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 9;
            direccionLabel.Text = "Direccion:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(67, 78);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 11;
            emailLabel.Text = "Email:";
            // 
            // razonSocialLabel
            // 
            razonSocialLabel.AutoSize = true;
            razonSocialLabel.Location = new System.Drawing.Point(29, 26);
            razonSocialLabel.Name = "razonSocialLabel";
            razonSocialLabel.Size = new System.Drawing.Size(73, 13);
            razonSocialLabel.TabIndex = 13;
            razonSocialLabel.Text = "Razon Social:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(245, 52);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 15;
            telefonoLabel.Text = "Telefono:";
            // 
            // observacionesLabel
            // 
            observacionesLabel.AutoSize = true;
            observacionesLabel.Location = new System.Drawing.Point(21, 130);
            observacionesLabel.Name = "observacionesLabel";
            observacionesLabel.Size = new System.Drawing.Size(81, 13);
            observacionesLabel.TabIndex = 18;
            observacionesLabel.Text = "Observaciones:";
            observacionesLabel.Click += new System.EventHandler(this.observacionesLabel_Click);
            // 
            // ciudadTextBox
            // 
            this.ciudadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrganizacion, "Ciudad", true));
            this.ciudadTextBox.Location = new System.Drawing.Point(303, 101);
            this.ciudadTextBox.MaxLength = 50;
            this.ciudadTextBox.Name = "ciudadTextBox";
            this.ciudadTextBox.Size = new System.Drawing.Size(100, 20);
            this.ciudadTextBox.TabIndex = 2;
            // 
            // bsOrganizacion
            // 
            this.bsOrganizacion.DataSource = typeof(BEL.EmpresaBEL);
            // 
            // codigoPostalTextBox
            // 
            this.codigoPostalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrganizacion, "CodigoPostal", true));
            this.codigoPostalTextBox.Location = new System.Drawing.Point(303, 75);
            this.codigoPostalTextBox.MaxLength = 10;
            this.codigoPostalTextBox.Name = "codigoPostalTextBox";
            this.codigoPostalTextBox.Size = new System.Drawing.Size(100, 20);
            this.codigoPostalTextBox.TabIndex = 4;
            // 
            // contactoTextBox
            // 
            this.contactoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrganizacion, "Contacto", true));
            this.contactoTextBox.Location = new System.Drawing.Point(108, 49);
            this.contactoTextBox.MaxLength = 50;
            this.contactoTextBox.Name = "contactoTextBox";
            this.contactoTextBox.Size = new System.Drawing.Size(100, 20);
            this.contactoTextBox.TabIndex = 6;
            // 
            // cUITTextBox
            // 
            this.cUITTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrganizacion, "CUIT", true));
            this.cUITTextBox.Location = new System.Drawing.Point(303, 23);
            this.cUITTextBox.MaxLength = 11;
            this.cUITTextBox.Name = "cUITTextBox";
            this.cUITTextBox.Size = new System.Drawing.Size(100, 20);
            this.cUITTextBox.TabIndex = 8;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrganizacion, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(108, 101);
            this.direccionTextBox.MaxLength = 50;
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(100, 20);
            this.direccionTextBox.TabIndex = 10;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrganizacion, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(108, 75);
            this.emailTextBox.MaxLength = 50;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 12;
            // 
            // razonSocialTextBox
            // 
            this.razonSocialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrganizacion, "RazonSocial", true));
            this.razonSocialTextBox.Location = new System.Drawing.Point(108, 23);
            this.razonSocialTextBox.MaxLength = 50;
            this.razonSocialTextBox.Name = "razonSocialTextBox";
            this.razonSocialTextBox.Size = new System.Drawing.Size(100, 20);
            this.razonSocialTextBox.TabIndex = 14;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrganizacion, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(303, 49);
            this.telefonoTextBox.MaxLength = 50;
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefonoTextBox.TabIndex = 16;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(328, 175);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 18;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // AceptarButton
            // 
            this.AceptarButton.Location = new System.Drawing.Point(247, 175);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(75, 23);
            this.AceptarButton.TabIndex = 17;
            this.AceptarButton.Text = "Aceptar";
            this.AceptarButton.UseVisualStyleBackColor = true;
            this.AceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // observacionesTextBox
            // 
            this.observacionesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsOrganizacion, "Observaciones", true));
            this.observacionesTextBox.Location = new System.Drawing.Point(108, 127);
            this.observacionesTextBox.Multiline = true;
            this.observacionesTextBox.Name = "observacionesTextBox";
            this.observacionesTextBox.Size = new System.Drawing.Size(295, 42);
            this.observacionesTextBox.TabIndex = 19;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // OrganizacionEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 211);
            this.Controls.Add(observacionesLabel);
            this.Controls.Add(this.observacionesTextBox);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.AceptarButton);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(razonSocialLabel);
            this.Controls.Add(this.razonSocialTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(cUITLabel);
            this.Controls.Add(this.cUITTextBox);
            this.Controls.Add(contactoLabel);
            this.Controls.Add(this.contactoTextBox);
            this.Controls.Add(codigoPostalLabel);
            this.Controls.Add(this.codigoPostalTextBox);
            this.Controls.Add(ciudadLabel);
            this.Controls.Add(this.ciudadTextBox);
            this.Name = "OrganizacionEditForm";
            this.Text = "Edición Organización";
            this.Load += new System.EventHandler(this.EdicionOrganizacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsOrganizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsOrganizacion;
        private System.Windows.Forms.TextBox ciudadTextBox;
        private System.Windows.Forms.TextBox codigoPostalTextBox;
        private System.Windows.Forms.TextBox contactoTextBox;
        private System.Windows.Forms.TextBox cUITTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox razonSocialTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button AceptarButton;
        private System.Windows.Forms.TextBox observacionesTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}