namespace AppDeposito
{
    partial class PrincipalForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.ArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IniciarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdministrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BitacoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDeCambiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IdiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IntegridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ActivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionarActivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EstadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MarcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SectoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrganizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionarPCsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionarUbicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PropuestaDeReemplazoPCsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsuarioDelActivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DepositosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarDepositosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdministrarDonacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PropuestaDeDonaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReparacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionarReparacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionarProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReparacionesRecurrentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AcercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasPCsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArchivoToolStripMenuItem,
            this.AdministrarToolStripMenuItem,
            this.ActivosToolStripMenuItem,
            this.DepositosToolStripMenuItem,
            this.ReparacionesToolStripMenuItem,
            this.AyudaToolStripMenuItem});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(686, 24);
            this.MenuPrincipal.TabIndex = 1;
            this.MenuPrincipal.Text = "menuStrip1";
            this.MenuPrincipal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuPrincipal_ItemClicked);
            // 
            // ArchivoToolStripMenuItem
            // 
            this.ArchivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IniciarSesionToolStripMenuItem,
            this.CerrarSesionToolStripMenuItem,
            this.SalirToolStripMenuItem});
            this.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem";
            this.ArchivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.ArchivoToolStripMenuItem.Text = "Archivo";
            // 
            // IniciarSesionToolStripMenuItem
            // 
            this.IniciarSesionToolStripMenuItem.Name = "IniciarSesionToolStripMenuItem";
            this.IniciarSesionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.IniciarSesionToolStripMenuItem.Text = "Iniciar Sesión";
            this.IniciarSesionToolStripMenuItem.Click += new System.EventHandler(this.IniciarSesionToolStripMenuItem_Click);
            // 
            // CerrarSesionToolStripMenuItem
            // 
            this.CerrarSesionToolStripMenuItem.Enabled = false;
            this.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem";
            this.CerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CerrarSesionToolStripMenuItem.Text = "Cerrar Sesión";
            this.CerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.CerrarSesionToolStripMenuItem_Click);
            // 
            // SalirToolStripMenuItem
            // 
            this.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem";
            this.SalirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SalirToolStripMenuItem.Text = "Salir";
            this.SalirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // AdministrarToolStripMenuItem
            // 
            this.AdministrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsuariosToolStripMenuItem,
            this.PermisosToolStripMenuItem,
            this.BitacoraToolStripMenuItem,
            this.BackupToolStripMenuItem,
            this.IdiomaToolStripMenuItem,
            this.IntegridadToolStripMenuItem});
            this.AdministrarToolStripMenuItem.Name = "AdministrarToolStripMenuItem";
            this.AdministrarToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.AdministrarToolStripMenuItem.Text = "Administrar";
            this.AdministrarToolStripMenuItem.Visible = false;
            // 
            // UsuariosToolStripMenuItem
            // 
            this.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem";
            this.UsuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.UsuariosToolStripMenuItem.Text = "Usuarios";
            this.UsuariosToolStripMenuItem.Visible = false;
            this.UsuariosToolStripMenuItem.Click += new System.EventHandler(this.UsuariosToolStripMenuItem_Click);
            // 
            // PermisosToolStripMenuItem
            // 
            this.PermisosToolStripMenuItem.Name = "PermisosToolStripMenuItem";
            this.PermisosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.PermisosToolStripMenuItem.Text = "Permisos";
            this.PermisosToolStripMenuItem.Visible = false;
            this.PermisosToolStripMenuItem.Click += new System.EventHandler(this.PermisosToolStripMenuItem_Click);
            // 
            // BitacoraToolStripMenuItem
            // 
            this.BitacoraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventosToolStripMenuItem,
            this.controlDeCambiosToolStripMenuItem});
            this.BitacoraToolStripMenuItem.Name = "BitacoraToolStripMenuItem";
            this.BitacoraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.BitacoraToolStripMenuItem.Text = "Bitácora";
            this.BitacoraToolStripMenuItem.Visible = false;
            // 
            // eventosToolStripMenuItem
            // 
            this.eventosToolStripMenuItem.Name = "eventosToolStripMenuItem";
            this.eventosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eventosToolStripMenuItem.Text = "Eventos";
            this.eventosToolStripMenuItem.Click += new System.EventHandler(this.eventosToolStripMenuItem_Click);
            // 
            // controlDeCambiosToolStripMenuItem
            // 
            this.controlDeCambiosToolStripMenuItem.Name = "controlDeCambiosToolStripMenuItem";
            this.controlDeCambiosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.controlDeCambiosToolStripMenuItem.Text = "Control de Cambios";
            this.controlDeCambiosToolStripMenuItem.Click += new System.EventHandler(this.controlDeCambiosToolStripMenuItem_Click);
            // 
            // BackupToolStripMenuItem
            // 
            this.BackupToolStripMenuItem.Name = "BackupToolStripMenuItem";
            this.BackupToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.BackupToolStripMenuItem.Text = "Backup";
            this.BackupToolStripMenuItem.Visible = false;
            this.BackupToolStripMenuItem.Click += new System.EventHandler(this.BackupToolStripMenuItem_Click);
            // 
            // IdiomaToolStripMenuItem
            // 
            this.IdiomaToolStripMenuItem.Name = "IdiomaToolStripMenuItem";
            this.IdiomaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.IdiomaToolStripMenuItem.Text = "Idioma";
            this.IdiomaToolStripMenuItem.Visible = false;
            this.IdiomaToolStripMenuItem.Click += new System.EventHandler(this.IdiomaToolStripMenuItem_Click);
            // 
            // IntegridadToolStripMenuItem
            // 
            this.IntegridadToolStripMenuItem.Name = "IntegridadToolStripMenuItem";
            this.IntegridadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.IntegridadToolStripMenuItem.Text = "Integridad";
            this.IntegridadToolStripMenuItem.Visible = false;
            this.IntegridadToolStripMenuItem.Click += new System.EventHandler(this.IntegridadToolStripMenuItem_Click);
            // 
            // ActivosToolStripMenuItem
            // 
            this.ActivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GestionarActivosToolStripMenuItem,
            this.GestionarToolStripMenuItem,
            this.GestionarPCsToolStripMenuItem,
            this.GestionarUbicacionesToolStripMenuItem,
            this.PropuestaDeReemplazoPCsToolStripMenuItem,
            this.UsuarioDelActivoToolStripMenuItem,
            this.categoriasPCsToolStripMenuItem});
            this.ActivosToolStripMenuItem.Name = "ActivosToolStripMenuItem";
            this.ActivosToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ActivosToolStripMenuItem.Text = "Activo";
            this.ActivosToolStripMenuItem.Visible = false;
            this.ActivosToolStripMenuItem.Click += new System.EventHandler(this.ActivosToolStripMenuItem_Click);
            // 
            // GestionarActivosToolStripMenuItem
            // 
            this.GestionarActivosToolStripMenuItem.Name = "GestionarActivosToolStripMenuItem";
            this.GestionarActivosToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.GestionarActivosToolStripMenuItem.Text = "Gestionar Activos";
            this.GestionarActivosToolStripMenuItem.Click += new System.EventHandler(this.GestionarActivosToolStripMenuItem_Click);
            // 
            // GestionarToolStripMenuItem
            // 
            this.GestionarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EstadosToolStripMenuItem,
            this.TiposToolStripMenuItem,
            this.MarcasToolStripMenuItem,
            this.SectoresToolStripMenuItem,
            this.OrganizacionesToolStripMenuItem});
            this.GestionarToolStripMenuItem.Name = "GestionarToolStripMenuItem";
            this.GestionarToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.GestionarToolStripMenuItem.Text = "Propiedades de Activos";
            // 
            // EstadosToolStripMenuItem
            // 
            this.EstadosToolStripMenuItem.Name = "EstadosToolStripMenuItem";
            this.EstadosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.EstadosToolStripMenuItem.Text = "Estados";
            this.EstadosToolStripMenuItem.Click += new System.EventHandler(this.EstadosToolStripMenuItem_Click);
            // 
            // TiposToolStripMenuItem
            // 
            this.TiposToolStripMenuItem.Name = "TiposToolStripMenuItem";
            this.TiposToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.TiposToolStripMenuItem.Text = "Tipos";
            this.TiposToolStripMenuItem.Click += new System.EventHandler(this.TiposToolStripMenuItem_Click);
            // 
            // MarcasToolStripMenuItem
            // 
            this.MarcasToolStripMenuItem.Name = "MarcasToolStripMenuItem";
            this.MarcasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.MarcasToolStripMenuItem.Text = "Marcas";
            this.MarcasToolStripMenuItem.Click += new System.EventHandler(this.MarcasToolStripMenuItem_Click);
            // 
            // SectoresToolStripMenuItem
            // 
            this.SectoresToolStripMenuItem.Name = "SectoresToolStripMenuItem";
            this.SectoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SectoresToolStripMenuItem.Text = "Sectores";
            this.SectoresToolStripMenuItem.Click += new System.EventHandler(this.SectoresToolStripMenuItem_Click);
            // 
            // OrganizacionesToolStripMenuItem
            // 
            this.OrganizacionesToolStripMenuItem.Name = "OrganizacionesToolStripMenuItem";
            this.OrganizacionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OrganizacionesToolStripMenuItem.Text = "Empresas";
            this.OrganizacionesToolStripMenuItem.Click += new System.EventHandler(this.OrganizacionesToolStripMenuItem_Click);
            // 
            // GestionarPCsToolStripMenuItem
            // 
            this.GestionarPCsToolStripMenuItem.Name = "GestionarPCsToolStripMenuItem";
            this.GestionarPCsToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.GestionarPCsToolStripMenuItem.Text = "Gestionar PCs";
            // 
            // GestionarUbicacionesToolStripMenuItem
            // 
            this.GestionarUbicacionesToolStripMenuItem.Name = "GestionarUbicacionesToolStripMenuItem";
            this.GestionarUbicacionesToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.GestionarUbicacionesToolStripMenuItem.Text = "Gestionar Ubicaciones";
            this.GestionarUbicacionesToolStripMenuItem.Click += new System.EventHandler(this.GestionarUbicacionesToolStripMenuItem_Click);
            // 
            // PropuestaDeReemplazoPCsToolStripMenuItem
            // 
            this.PropuestaDeReemplazoPCsToolStripMenuItem.Name = "PropuestaDeReemplazoPCsToolStripMenuItem";
            this.PropuestaDeReemplazoPCsToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.PropuestaDeReemplazoPCsToolStripMenuItem.Text = "Propuesta de Reemplazo PCs";
            this.PropuestaDeReemplazoPCsToolStripMenuItem.Click += new System.EventHandler(this.PropuestaDeReemplazoPCsToolStripMenuItem_Click);
            // 
            // UsuarioDelActivoToolStripMenuItem
            // 
            this.UsuarioDelActivoToolStripMenuItem.Name = "UsuarioDelActivoToolStripMenuItem";
            this.UsuarioDelActivoToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.UsuarioDelActivoToolStripMenuItem.Text = "Gestionar Clientes";
            this.UsuarioDelActivoToolStripMenuItem.Click += new System.EventHandler(this.UsuarioDelActivoToolStripMenuItem_Click);
            // 
            // DepositosToolStripMenuItem
            // 
            this.DepositosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarDepositosToolStripMenuItem,
            this.AdministrarDonacionesToolStripMenuItem,
            this.PropuestaDeDonaciónToolStripMenuItem});
            this.DepositosToolStripMenuItem.Name = "DepositosToolStripMenuItem";
            this.DepositosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.DepositosToolStripMenuItem.Text = "Depósito";
            this.DepositosToolStripMenuItem.Visible = false;
            // 
            // administrarDepositosToolStripMenuItem
            // 
            this.administrarDepositosToolStripMenuItem.Name = "administrarDepositosToolStripMenuItem";
            this.administrarDepositosToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.administrarDepositosToolStripMenuItem.Text = "Depósitos";
            this.administrarDepositosToolStripMenuItem.Click += new System.EventHandler(this.administrarDepositosToolStripMenuItem_Click);
            // 
            // AdministrarDonacionesToolStripMenuItem
            // 
            this.AdministrarDonacionesToolStripMenuItem.Name = "AdministrarDonacionesToolStripMenuItem";
            this.AdministrarDonacionesToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.AdministrarDonacionesToolStripMenuItem.Text = "Donaciones";
            this.AdministrarDonacionesToolStripMenuItem.Click += new System.EventHandler(this.AdministrarDonacionesToolStripMenuItem_Click);
            // 
            // PropuestaDeDonaciónToolStripMenuItem
            // 
            this.PropuestaDeDonaciónToolStripMenuItem.Name = "PropuestaDeDonaciónToolStripMenuItem";
            this.PropuestaDeDonaciónToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.PropuestaDeDonaciónToolStripMenuItem.Text = "Propuesta de Donación";
            // 
            // ReparacionesToolStripMenuItem
            // 
            this.ReparacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GestionarReparacionesToolStripMenuItem,
            this.GestionarProveedoresToolStripMenuItem,
            this.ReparacionesRecurrentesToolStripMenuItem});
            this.ReparacionesToolStripMenuItem.Name = "ReparacionesToolStripMenuItem";
            this.ReparacionesToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.ReparacionesToolStripMenuItem.Text = "Reparación";
            this.ReparacionesToolStripMenuItem.Visible = false;
            // 
            // GestionarReparacionesToolStripMenuItem
            // 
            this.GestionarReparacionesToolStripMenuItem.Name = "GestionarReparacionesToolStripMenuItem";
            this.GestionarReparacionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.GestionarReparacionesToolStripMenuItem.Text = "Reparaciones";
            this.GestionarReparacionesToolStripMenuItem.Click += new System.EventHandler(this.GestionarReparacionesToolStripMenuItem_Click);
            // 
            // GestionarProveedoresToolStripMenuItem
            // 
            this.GestionarProveedoresToolStripMenuItem.Name = "GestionarProveedoresToolStripMenuItem";
            this.GestionarProveedoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.GestionarProveedoresToolStripMenuItem.Text = "Proveedores";
            this.GestionarProveedoresToolStripMenuItem.Click += new System.EventHandler(this.GestionarProveedoresToolStripMenuItem_Click);
            // 
            // ReparacionesRecurrentesToolStripMenuItem
            // 
            this.ReparacionesRecurrentesToolStripMenuItem.Name = "ReparacionesRecurrentesToolStripMenuItem";
            this.ReparacionesRecurrentesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ReparacionesRecurrentesToolStripMenuItem.Text = "Recurrentes";
            this.ReparacionesRecurrentesToolStripMenuItem.Click += new System.EventHandler(this.ReparacionesRecurrentesToolStripMenuItem_Click);
            // 
            // AyudaToolStripMenuItem
            // 
            this.AyudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AcercaDeToolStripMenuItem});
            this.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem";
            this.AyudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.AyudaToolStripMenuItem.Text = "Ayuda";
            // 
            // AcercaDeToolStripMenuItem
            // 
            this.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem";
            this.AcercaDeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.AcercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // categoriasPCsToolStripMenuItem
            // 
            this.categoriasPCsToolStripMenuItem.Name = "categoriasPCsToolStripMenuItem";
            this.categoriasPCsToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.categoriasPCsToolStripMenuItem.Text = "Categorias PCs";
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 430);
            this.Controls.Add(this.MenuPrincipal);
            this.IsMdiContainer = true;
            this.Name = "PrincipalForm";
            this.Text = "Sistema Depósito";
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem ArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IniciarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SalirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdministrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PermisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BitacoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IdiomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IntegridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ActivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GestionarActivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GestionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EstadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MarcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SectoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrganizacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GestionarPCsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GestionarUbicacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PropuestaDeReemplazoPCsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DepositosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarDepositosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdministrarDonacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PropuestaDeDonaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReparacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GestionarReparacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GestionarProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReparacionesRecurrentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AyudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AcercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UsuarioDelActivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlDeCambiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasPCsToolStripMenuItem;
    }
}

