namespace AppDeposito.Administracion.Permisos
{
    partial class EdicionPermisosUsuarioForm
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
            this.PerfilTreeView = new System.Windows.Forms.TreeView();
            this.AceptarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.RemoverButton = new System.Windows.Forms.Button();
            this.AsignarButton = new System.Windows.Forms.Button();
            this.ListaPermisos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // PerfilTreeView
            // 
            this.PerfilTreeView.Location = new System.Drawing.Point(282, 12);
            this.PerfilTreeView.Name = "PerfilTreeView";
            this.PerfilTreeView.Size = new System.Drawing.Size(221, 212);
            this.PerfilTreeView.TabIndex = 1;
            // 
            // AceptarButton
            // 
            this.AceptarButton.Location = new System.Drawing.Point(347, 236);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(75, 23);
            this.AceptarButton.TabIndex = 2;
            this.AceptarButton.Text = "Aceptar";
            this.AceptarButton.UseVisualStyleBackColor = true;
            this.AceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(428, 236);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 3;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // RemoverButton
            // 
            this.RemoverButton.Location = new System.Drawing.Point(239, 90);
            this.RemoverButton.Name = "RemoverButton";
            this.RemoverButton.Size = new System.Drawing.Size(37, 23);
            this.RemoverButton.TabIndex = 4;
            this.RemoverButton.Text = "<<";
            this.RemoverButton.UseVisualStyleBackColor = true;
            this.RemoverButton.Click += new System.EventHandler(this.RemoverButton_Click);
            // 
            // AsignarButton
            // 
            this.AsignarButton.Location = new System.Drawing.Point(239, 61);
            this.AsignarButton.Name = "AsignarButton";
            this.AsignarButton.Size = new System.Drawing.Size(37, 23);
            this.AsignarButton.TabIndex = 5;
            this.AsignarButton.Text = ">>";
            this.AsignarButton.UseVisualStyleBackColor = true;
            this.AsignarButton.Click += new System.EventHandler(this.AsignarButton_Click);
            // 
            // ListaPermisos
            // 
            this.ListaPermisos.FormattingEnabled = true;
            this.ListaPermisos.Location = new System.Drawing.Point(12, 12);
            this.ListaPermisos.Name = "ListaPermisos";
            this.ListaPermisos.Size = new System.Drawing.Size(221, 212);
            this.ListaPermisos.TabIndex = 6;
            // 
            // EdicionPermisosUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 269);
            this.Controls.Add(this.ListaPermisos);
            this.Controls.Add(this.AsignarButton);
            this.Controls.Add(this.RemoverButton);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.AceptarButton);
            this.Controls.Add(this.PerfilTreeView);
            this.Name = "EdicionPermisosUsuarioForm";
            this.Text = "Administrar Perfil de Usuario";
            this.Load += new System.EventHandler(this.EdicionPermisosUsuarioForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView PerfilTreeView;
        private System.Windows.Forms.Button AceptarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button RemoverButton;
        private System.Windows.Forms.Button AsignarButton;
        private System.Windows.Forms.ListBox ListaPermisos;
    }
}