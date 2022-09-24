namespace AppDeposito
{
    partial class ClienteEditForm
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
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label razonSocialLabel;
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.bsCliente = new System.Windows.Forms.BindingSource(this.components);
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.razonSocialComboBox = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            apellidoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            razonSocialLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // apellidoLabel
            // 
            apellidoLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new System.Drawing.Point(47, 37);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(47, 13);
            apellidoLabel.TabIndex = 1;
            apellidoLabel.Text = "Apellido:";
            // 
            // emailLabel
            // 
            emailLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(59, 66);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email:";
            // 
            // nombreLabel
            // 
            nombreLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(47, 8);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 9;
            nombreLabel.Text = "Nombre:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(42, 95);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 11;
            telefonoLabel.Text = "Telefono:";
            // 
            // razonSocialLabel
            // 
            razonSocialLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            razonSocialLabel.AutoSize = true;
            razonSocialLabel.Location = new System.Drawing.Point(43, 125);
            razonSocialLabel.Name = "razonSocialLabel";
            razonSocialLabel.Size = new System.Drawing.Size(51, 13);
            razonSocialLabel.TabIndex = 14;
            razonSocialLabel.Text = "Empresa:";
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCliente, "Apellido", true));
            this.apellidoTextBox.Location = new System.Drawing.Point(100, 33);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(163, 20);
            this.apellidoTextBox.TabIndex = 2;
            // 
            // bsCliente
            // 
            this.bsCliente.DataSource = typeof(BEL.ClienteBEL);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCliente, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(100, 62);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(163, 20);
            this.emailTextBox.TabIndex = 3;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCliente, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(100, 4);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(163, 20);
            this.nombreTextBox.TabIndex = 1;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCliente, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(100, 91);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(163, 20);
            this.telefonoTextBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(209, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // razonSocialComboBox
            // 
            this.razonSocialComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.razonSocialComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCliente, "Empresa.RazonSocial", true));
            this.razonSocialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.razonSocialComboBox.FormattingEnabled = true;
            this.razonSocialComboBox.Location = new System.Drawing.Point(100, 121);
            this.razonSocialComboBox.Name = "razonSocialComboBox";
            this.razonSocialComboBox.Size = new System.Drawing.Size(163, 21);
            this.razonSocialComboBox.TabIndex = 5;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.69963F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.30037F));
            this.tableLayoutPanel1.Controls.Add(nombreLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(razonSocialLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.nombreTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.razonSocialComboBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.apellidoTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(telefonoLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(emailLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(apellidoLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.emailTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.telefonoTextBox, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(33, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(288, 148);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ClienteEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 231);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClienteEditForm";
            this.Text = "Editar Cliente";
            this.Load += new System.EventHandler(this.ClienteEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsCliente;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox razonSocialComboBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}