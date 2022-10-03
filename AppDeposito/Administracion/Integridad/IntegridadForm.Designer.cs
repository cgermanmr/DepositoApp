namespace AppDeposito.Administracion.Integridad
{
    partial class IntegridadForm
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
            this.VerificarButton = new System.Windows.Forms.Button();
            this.RegenerarButton = new System.Windows.Forms.Button();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VerificarButton
            // 
            this.VerificarButton.Location = new System.Drawing.Point(54, 49);
            this.VerificarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VerificarButton.Name = "VerificarButton";
            this.VerificarButton.Size = new System.Drawing.Size(300, 103);
            this.VerificarButton.TabIndex = 0;
            this.VerificarButton.Text = "Verificar Integridad";
            this.VerificarButton.UseVisualStyleBackColor = true;
            this.VerificarButton.Click += new System.EventHandler(this.VerificarButton_Click);
            // 
            // RegenerarButton
            // 
            this.RegenerarButton.Location = new System.Drawing.Point(405, 49);
            this.RegenerarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RegenerarButton.Name = "RegenerarButton";
            this.RegenerarButton.Size = new System.Drawing.Size(300, 103);
            this.RegenerarButton.TabIndex = 1;
            this.RegenerarButton.Text = "Regenerar Codigos Verificadores";
            this.RegenerarButton.UseVisualStyleBackColor = true;
            this.RegenerarButton.Click += new System.EventHandler(this.RegenerarButton_Click);
            // 
            // txtSalida
            // 
            this.txtSalida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSalida.Location = new System.Drawing.Point(54, 211);
            this.txtSalida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSalida.Multiline = true;
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(649, 261);
            this.txtSalida.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 186);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Resultado:";
            // 
            // IntegridadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 514);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSalida);
            this.Controls.Add(this.RegenerarButton);
            this.Controls.Add(this.VerificarButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "IntegridadForm";
            this.Text = "Integridad de los datos";
            this.Load += new System.EventHandler(this.IntegridadForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VerificarButton;
        private System.Windows.Forms.Button RegenerarButton;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.Label label1;
    }
}