namespace AppDeposito.Administracion.Backup
{
    partial class BackupRestoreForm
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
            this.btnRealizarRestore = new System.Windows.Forms.Button();
            this.btnRealizarBackup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRealizarRestore
            // 
            this.btnRealizarRestore.Location = new System.Drawing.Point(26, 117);
            this.btnRealizarRestore.Name = "btnRealizarRestore";
            this.btnRealizarRestore.Size = new System.Drawing.Size(215, 71);
            this.btnRealizarRestore.TabIndex = 24;
            this.btnRealizarRestore.Tag = "15";
            this.btnRealizarRestore.Text = "Restaurar Base de Datos";
            this.btnRealizarRestore.UseVisualStyleBackColor = true;
            this.btnRealizarRestore.Click += new System.EventHandler(this.BtnRealizarRestore_Click);
            // 
            // btnRealizarBackup
            // 
            this.btnRealizarBackup.Location = new System.Drawing.Point(26, 24);
            this.btnRealizarBackup.Name = "btnRealizarBackup";
            this.btnRealizarBackup.Size = new System.Drawing.Size(215, 71);
            this.btnRealizarBackup.TabIndex = 23;
            this.btnRealizarBackup.Tag = "14";
            this.btnRealizarBackup.Text = "Realizar Backup Base de Datos";
            this.btnRealizarBackup.UseVisualStyleBackColor = true;
            this.btnRealizarBackup.Click += new System.EventHandler(this.BtnRealizarBackup_Click);
            // 
            // BackupRestoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 208);
            this.Controls.Add(this.btnRealizarRestore);
            this.Controls.Add(this.btnRealizarBackup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BackupRestoreForm";
            this.Text = "Backups Base de Datos";
            this.Load += new System.EventHandler(this.BackupRestoreForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnRealizarRestore;
        internal System.Windows.Forms.Button btnRealizarBackup;
    }
}