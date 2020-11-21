namespace AppDeposito.Administracion.Permisos
{
    partial class EdicionPermisoForm
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ListaPermisos = new System.Windows.Forms.ListBox();
            this.PermisosTreeView = new System.Windows.Forms.TreeView();
            this.DesasignarButton = new System.Windows.Forms.Button();
            this.AsignarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelarButton
            // 
            this.CancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarButton.Location = new System.Drawing.Point(383, 351);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 51;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // AceptarButton
            // 
            this.AceptarButton.Location = new System.Drawing.Point(302, 351);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(75, 23);
            this.AceptarButton.TabIndex = 50;
            this.AceptarButton.Text = "Aceptar";
            this.AceptarButton.UseVisualStyleBackColor = true;
            this.AceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(20, 33);
            this.txtNombre.MaxLength = 255;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(438, 20);
            this.txtNombre.TabIndex = 46;
            this.txtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombre_Validating);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 17);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 49;
            this.lblNombre.Tag = "38";
            this.lblNombre.Text = "Nombre:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(20, 72);
            this.txtDescripcion.MaxLength = 255;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(438, 20);
            this.txtDescripcion.TabIndex = 47;
            this.txtDescripcion.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescripcion_Validating);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(17, 56);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 48;
            this.lblDescripcion.Tag = "50";
            this.lblDescripcion.Text = "Descripción:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ListaPermisos
            // 
            this.ListaPermisos.FormattingEnabled = true;
            this.ListaPermisos.Location = new System.Drawing.Point(20, 107);
            this.ListaPermisos.Name = "ListaPermisos";
            this.ListaPermisos.Size = new System.Drawing.Size(199, 238);
            this.ListaPermisos.TabIndex = 52;
            // 
            // PermisosTreeView
            // 
            this.PermisosTreeView.Location = new System.Drawing.Point(263, 107);
            this.PermisosTreeView.Name = "PermisosTreeView";
            this.PermisosTreeView.Size = new System.Drawing.Size(195, 238);
            this.PermisosTreeView.TabIndex = 53;
            // 
            // DesasignarButton
            // 
            this.DesasignarButton.Location = new System.Drawing.Point(225, 197);
            this.DesasignarButton.Name = "DesasignarButton";
            this.DesasignarButton.Size = new System.Drawing.Size(32, 23);
            this.DesasignarButton.TabIndex = 54;
            this.DesasignarButton.Text = "<<";
            this.DesasignarButton.UseVisualStyleBackColor = true;
            this.DesasignarButton.Click += new System.EventHandler(this.DesasignarButton_Click);
            // 
            // AsignarButton
            // 
            this.AsignarButton.Location = new System.Drawing.Point(225, 168);
            this.AsignarButton.Name = "AsignarButton";
            this.AsignarButton.Size = new System.Drawing.Size(32, 23);
            this.AsignarButton.TabIndex = 54;
            this.AsignarButton.Text = ">>";
            this.AsignarButton.UseVisualStyleBackColor = true;
            this.AsignarButton.Click += new System.EventHandler(this.AsignarButton_Click);
            // 
            // EdicionPermisoForm
            // 
            this.AcceptButton = this.AceptarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarButton;
            this.ClientSize = new System.Drawing.Size(470, 388);
            this.Controls.Add(this.AsignarButton);
            this.Controls.Add(this.DesasignarButton);
            this.Controls.Add(this.PermisosTreeView);
            this.Controls.Add(this.ListaPermisos);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.AceptarButton);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Name = "EdicionPermisoForm";
            this.Text = "Nuevo Grupo de Permisos";
            this.Load += new System.EventHandler(this.NuevoGrupoPermisoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button CancelarButton;
        internal System.Windows.Forms.Button AceptarButton;
        internal System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.Label lblNombre;
        internal System.Windows.Forms.TextBox txtDescripcion;
        internal System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ListBox ListaPermisos;
        private System.Windows.Forms.Button AsignarButton;
        private System.Windows.Forms.Button DesasignarButton;
        private System.Windows.Forms.TreeView PermisosTreeView;
    }
}