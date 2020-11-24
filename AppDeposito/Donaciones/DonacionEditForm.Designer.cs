namespace AppDeposito
{
    partial class EdicionDonacionForm
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
            System.Windows.Forms.Label auditorLabel;
            System.Windows.Forms.Label autorizadorLabel;
            System.Windows.Forms.Label organizacionLabel;
            System.Windows.Forms.Label fechaLabel1;
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.estadoCheckBox = new System.Windows.Forms.CheckBox();
            this.auditorComboBox = new System.Windows.Forms.ComboBox();
            this.autorizadorComboBox = new System.Windows.Forms.ComboBox();
            this.organizacionComboBox = new System.Windows.Forms.ComboBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AceptarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.bsDonacion = new System.Windows.Forms.BindingSource(this.components);
            descripcionLabel = new System.Windows.Forms.Label();
            auditorLabel = new System.Windows.Forms.Label();
            autorizadorLabel = new System.Windows.Forms.Label();
            organizacionLabel = new System.Windows.Forms.Label();
            fechaLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDonacion)).BeginInit();
            this.SuspendLayout();
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(39, 24);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 1;
            descripcionLabel.Text = "Descripcion:";
            // 
            // auditorLabel
            // 
            auditorLabel.AutoSize = true;
            auditorLabel.Location = new System.Drawing.Point(62, 76);
            auditorLabel.Name = "auditorLabel";
            auditorLabel.Size = new System.Drawing.Size(43, 13);
            auditorLabel.TabIndex = 6;
            auditorLabel.Text = "Auditor:";
            // 
            // autorizadorLabel
            // 
            autorizadorLabel.AutoSize = true;
            autorizadorLabel.Location = new System.Drawing.Point(42, 103);
            autorizadorLabel.Name = "autorizadorLabel";
            autorizadorLabel.Size = new System.Drawing.Size(63, 13);
            autorizadorLabel.TabIndex = 8;
            autorizadorLabel.Text = "Autorizador:";
            // 
            // organizacionLabel
            // 
            organizacionLabel.AutoSize = true;
            organizacionLabel.Location = new System.Drawing.Point(33, 130);
            organizacionLabel.Name = "organizacionLabel";
            organizacionLabel.Size = new System.Drawing.Size(72, 13);
            organizacionLabel.TabIndex = 10;
            organizacionLabel.Text = "Organizacion:";
            // 
            // fechaLabel1
            // 
            fechaLabel1.AutoSize = true;
            fechaLabel1.Location = new System.Drawing.Point(205, 51);
            fechaLabel1.Name = "fechaLabel1";
            fechaLabel1.Size = new System.Drawing.Size(40, 13);
            fechaLabel1.TabIndex = 11;
            fechaLabel1.Text = "Fecha:";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDonacion, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(111, 21);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(297, 20);
            this.descripcionTextBox.TabIndex = 2;
            // 
            // estadoCheckBox
            // 
            this.estadoCheckBox.AutoSize = true;
            this.estadoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsDonacion, "Estado", true));
            this.estadoCheckBox.Location = new System.Drawing.Point(111, 50);
            this.estadoCheckBox.Name = "estadoCheckBox";
            this.estadoCheckBox.Size = new System.Drawing.Size(76, 17);
            this.estadoCheckBox.TabIndex = 4;
            this.estadoCheckBox.Text = "Autorizado";
            this.estadoCheckBox.UseVisualStyleBackColor = true;
            this.estadoCheckBox.CheckedChanged += new System.EventHandler(this.estadoCheckBox_CheckedChanged);
            // 
            // auditorComboBox
            // 
            this.auditorComboBox.CausesValidation = false;
            this.auditorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDonacion, "Auditor", true));
            this.auditorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsDonacion, "Auditor", true));
            this.auditorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bsDonacion, "Auditor", true));
            this.auditorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.auditorComboBox.FormattingEnabled = true;
            this.auditorComboBox.Location = new System.Drawing.Point(111, 73);
            this.auditorComboBox.Name = "auditorComboBox";
            this.auditorComboBox.Size = new System.Drawing.Size(297, 21);
            this.auditorComboBox.TabIndex = 7;
            // 
            // autorizadorComboBox
            // 
            this.autorizadorComboBox.CausesValidation = false;
            this.autorizadorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDonacion, "Autorizador", true));
            this.autorizadorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsDonacion, "Autorizador", true));
            this.autorizadorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bsDonacion, "Autorizador", true));
            this.autorizadorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.autorizadorComboBox.FormattingEnabled = true;
            this.autorizadorComboBox.Location = new System.Drawing.Point(111, 100);
            this.autorizadorComboBox.Name = "autorizadorComboBox";
            this.autorizadorComboBox.Size = new System.Drawing.Size(297, 21);
            this.autorizadorComboBox.TabIndex = 9;
            // 
            // organizacionComboBox
            // 
            this.organizacionComboBox.CausesValidation = false;
            this.organizacionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDonacion, "Organizacion", true));
            this.organizacionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bsDonacion, "Organizacion", true));
            this.organizacionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsDonacion, "Organizacion", true));
            this.organizacionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.organizacionComboBox.FormattingEnabled = true;
            this.organizacionComboBox.Location = new System.Drawing.Point(111, 127);
            this.organizacionComboBox.Name = "organizacionComboBox";
            this.organizacionComboBox.Size = new System.Drawing.Size(297, 21);
            this.organizacionComboBox.TabIndex = 11;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsDonacion, "Fecha", true));
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(251, 47);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(80, 20);
            this.fechaDateTimePicker.TabIndex = 12;
            // 
            // AceptarButton
            // 
            this.AceptarButton.Location = new System.Drawing.Point(252, 158);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(75, 23);
            this.AceptarButton.TabIndex = 13;
            this.AceptarButton.Text = "Aceptar";
            this.AceptarButton.UseVisualStyleBackColor = true;
            this.AceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(333, 158);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 14;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // bsDonacion
            // 
            this.bsDonacion.DataSource = typeof(BEL.DonacionBEL);
            // 
            // EdicionDonacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 193);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.AceptarButton);
            this.Controls.Add(fechaLabel1);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(organizacionLabel);
            this.Controls.Add(this.organizacionComboBox);
            this.Controls.Add(autorizadorLabel);
            this.Controls.Add(this.autorizadorComboBox);
            this.Controls.Add(auditorLabel);
            this.Controls.Add(this.auditorComboBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(this.estadoCheckBox);
            this.Name = "EdicionDonacionForm";
            this.Text = "Edición Donación";
            this.Load += new System.EventHandler(this.EdicionDonacionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDonacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsDonacion;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.CheckBox estadoCheckBox;
        private System.Windows.Forms.ComboBox auditorComboBox;
        private System.Windows.Forms.ComboBox autorizadorComboBox;
        private System.Windows.Forms.ComboBox organizacionComboBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.Button AceptarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}