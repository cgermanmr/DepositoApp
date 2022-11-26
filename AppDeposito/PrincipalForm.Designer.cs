﻿namespace AppDeposito
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
            this.controlDeCambiosFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.GestionarUbicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsuarioDelActivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReparacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionarReparacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionarProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaReparaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarHistorialReparacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArchivoToolStripMenuItem,
            this.AdministrarToolStripMenuItem,
            this.ActivosToolStripMenuItem,
            this.ReparacionesToolStripMenuItem});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
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
            this.ArchivoToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.ArchivoToolStripMenuItem.Text = "Archivo";
            // 
            // IniciarSesionToolStripMenuItem
            // 
            this.IniciarSesionToolStripMenuItem.Name = "IniciarSesionToolStripMenuItem";
            this.IniciarSesionToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.IniciarSesionToolStripMenuItem.Text = "Iniciar Sesión";
            this.IniciarSesionToolStripMenuItem.Click += new System.EventHandler(this.IniciarSesionToolStripMenuItem_Click);
            // 
            // CerrarSesionToolStripMenuItem
            // 
            this.CerrarSesionToolStripMenuItem.Enabled = false;
            this.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem";
            this.CerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.CerrarSesionToolStripMenuItem.Text = "Cerrar Sesión";
            this.CerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.CerrarSesionToolStripMenuItem_Click);
            // 
            // SalirToolStripMenuItem
            // 
            this.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem";
            this.SalirToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
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
            this.AdministrarToolStripMenuItem.Size = new System.Drawing.Size(81, 22);
            this.AdministrarToolStripMenuItem.Text = "Administrar";
            this.AdministrarToolStripMenuItem.Visible = false;
            // 
            // UsuariosToolStripMenuItem
            // 
            this.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem";
            this.UsuariosToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.UsuariosToolStripMenuItem.Text = "Usuarios";
            this.UsuariosToolStripMenuItem.Visible = false;
            this.UsuariosToolStripMenuItem.Click += new System.EventHandler(this.UsuariosToolStripMenuItem_Click);
            // 
            // PermisosToolStripMenuItem
            // 
            this.PermisosToolStripMenuItem.Name = "PermisosToolStripMenuItem";
            this.PermisosToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.PermisosToolStripMenuItem.Text = "Permisos";
            this.PermisosToolStripMenuItem.Visible = false;
            this.PermisosToolStripMenuItem.Click += new System.EventHandler(this.PermisosToolStripMenuItem_Click);
            // 
            // BitacoraToolStripMenuItem
            // 
            this.BitacoraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventosToolStripMenuItem,
            this.controlDeCambiosToolStripMenuItem,
            this.controlDeCambiosFacturasToolStripMenuItem});
            this.BitacoraToolStripMenuItem.Name = "BitacoraToolStripMenuItem";
            this.BitacoraToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.BitacoraToolStripMenuItem.Text = "Bitácora";
            this.BitacoraToolStripMenuItem.Visible = false;
            // 
            // eventosToolStripMenuItem
            // 
            this.eventosToolStripMenuItem.Name = "eventosToolStripMenuItem";
            this.eventosToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.eventosToolStripMenuItem.Text = "Eventos";
            this.eventosToolStripMenuItem.Click += new System.EventHandler(this.eventosToolStripMenuItem_Click);
            // 
            // controlDeCambiosToolStripMenuItem
            // 
            this.controlDeCambiosToolStripMenuItem.Name = "controlDeCambiosToolStripMenuItem";
            this.controlDeCambiosToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.controlDeCambiosToolStripMenuItem.Text = "Control de Cambios Usuarios";
            this.controlDeCambiosToolStripMenuItem.Click += new System.EventHandler(this.controlDeCambiosToolStripMenuItem_Click);
            // 
            // controlDeCambiosFacturasToolStripMenuItem
            // 
            this.controlDeCambiosFacturasToolStripMenuItem.Name = "controlDeCambiosFacturasToolStripMenuItem";
            this.controlDeCambiosFacturasToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.controlDeCambiosFacturasToolStripMenuItem.Text = "Control de Cambios Facturas";
            this.controlDeCambiosFacturasToolStripMenuItem.Click += new System.EventHandler(this.controlDeCambiosFacturasToolStripMenuItem_Click);
            // 
            // BackupToolStripMenuItem
            // 
            this.BackupToolStripMenuItem.Name = "BackupToolStripMenuItem";
            this.BackupToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.BackupToolStripMenuItem.Text = "Backup";
            this.BackupToolStripMenuItem.Visible = false;
            this.BackupToolStripMenuItem.Click += new System.EventHandler(this.BackupToolStripMenuItem_Click);
            // 
            // IdiomaToolStripMenuItem
            // 
            this.IdiomaToolStripMenuItem.Name = "IdiomaToolStripMenuItem";
            this.IdiomaToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.IdiomaToolStripMenuItem.Text = "Idioma";
            this.IdiomaToolStripMenuItem.Visible = false;
            this.IdiomaToolStripMenuItem.Click += new System.EventHandler(this.IdiomaToolStripMenuItem_Click);
            // 
            // IntegridadToolStripMenuItem
            // 
            this.IntegridadToolStripMenuItem.Name = "IntegridadToolStripMenuItem";
            this.IntegridadToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.IntegridadToolStripMenuItem.Text = "Integridad";
            this.IntegridadToolStripMenuItem.Visible = false;
            this.IntegridadToolStripMenuItem.Click += new System.EventHandler(this.IntegridadToolStripMenuItem_Click);
            // 
            // ActivosToolStripMenuItem
            // 
            this.ActivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GestionarActivosToolStripMenuItem,
            this.GestionarToolStripMenuItem,
            this.GestionarUbicacionesToolStripMenuItem,
            this.UsuarioDelActivoToolStripMenuItem});
            this.ActivosToolStripMenuItem.Name = "ActivosToolStripMenuItem";
            this.ActivosToolStripMenuItem.Size = new System.Drawing.Size(53, 22);
            this.ActivosToolStripMenuItem.Text = "Activo";
            this.ActivosToolStripMenuItem.Visible = false;
            this.ActivosToolStripMenuItem.Click += new System.EventHandler(this.ActivosToolStripMenuItem_Click);
            // 
            // GestionarActivosToolStripMenuItem
            // 
            this.GestionarActivosToolStripMenuItem.Name = "GestionarActivosToolStripMenuItem";
            this.GestionarActivosToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.GestionarActivosToolStripMenuItem.Text = "Gestionar Activos";
            this.GestionarActivosToolStripMenuItem.Click += new System.EventHandler(this.GestionarActivosToolStripMenuItem_Click);
            // 
            // GestionarToolStripMenuItem
            // 
            this.GestionarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EstadosToolStripMenuItem,
            this.TiposToolStripMenuItem,
            this.MarcasToolStripMenuItem,
            this.SectoresToolStripMenuItem});
            this.GestionarToolStripMenuItem.Name = "GestionarToolStripMenuItem";
            this.GestionarToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.GestionarToolStripMenuItem.Text = "Propiedades de Activos";
            // 
            // EstadosToolStripMenuItem
            // 
            this.EstadosToolStripMenuItem.Name = "EstadosToolStripMenuItem";
            this.EstadosToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.EstadosToolStripMenuItem.Text = "Estados";
            this.EstadosToolStripMenuItem.Click += new System.EventHandler(this.EstadosToolStripMenuItem_Click);
            // 
            // TiposToolStripMenuItem
            // 
            this.TiposToolStripMenuItem.Name = "TiposToolStripMenuItem";
            this.TiposToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.TiposToolStripMenuItem.Text = "Tipos";
            this.TiposToolStripMenuItem.Click += new System.EventHandler(this.TiposToolStripMenuItem_Click);
            // 
            // MarcasToolStripMenuItem
            // 
            this.MarcasToolStripMenuItem.Name = "MarcasToolStripMenuItem";
            this.MarcasToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.MarcasToolStripMenuItem.Text = "Marcas";
            this.MarcasToolStripMenuItem.Click += new System.EventHandler(this.MarcasToolStripMenuItem_Click);
            // 
            // SectoresToolStripMenuItem
            // 
            this.SectoresToolStripMenuItem.Name = "SectoresToolStripMenuItem";
            this.SectoresToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.SectoresToolStripMenuItem.Text = "Sectores";
            this.SectoresToolStripMenuItem.Click += new System.EventHandler(this.SectoresToolStripMenuItem_Click);
            // 
            // GestionarUbicacionesToolStripMenuItem
            // 
            this.GestionarUbicacionesToolStripMenuItem.Name = "GestionarUbicacionesToolStripMenuItem";
            this.GestionarUbicacionesToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.GestionarUbicacionesToolStripMenuItem.Text = "Gestionar Ubicaciones";
            this.GestionarUbicacionesToolStripMenuItem.Click += new System.EventHandler(this.GestionarUbicacionesToolStripMenuItem_Click);
            // 
            // UsuarioDelActivoToolStripMenuItem
            // 
            this.UsuarioDelActivoToolStripMenuItem.Name = "UsuarioDelActivoToolStripMenuItem";
            this.UsuarioDelActivoToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.UsuarioDelActivoToolStripMenuItem.Text = "Gestionar Clientes";
            this.UsuarioDelActivoToolStripMenuItem.Click += new System.EventHandler(this.UsuarioDelActivoToolStripMenuItem_Click);
            // 
            // ReparacionesToolStripMenuItem
            // 
            this.ReparacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GestionarReparacionesToolStripMenuItem,
            this.GestionarProveedoresToolStripMenuItem,
            this.ingresoFacturasToolStripMenuItem,
            this.ordenesDePagoToolStripMenuItem,
            this.nuevaReparaciónToolStripMenuItem,
            this.consultarHistorialReparacionesToolStripMenuItem});
            this.ReparacionesToolStripMenuItem.Name = "ReparacionesToolStripMenuItem";
            this.ReparacionesToolStripMenuItem.Size = new System.Drawing.Size(78, 22);
            this.ReparacionesToolStripMenuItem.Text = "Reparación";
            this.ReparacionesToolStripMenuItem.Visible = false;
            // 
            // GestionarReparacionesToolStripMenuItem
            // 
            this.GestionarReparacionesToolStripMenuItem.Name = "GestionarReparacionesToolStripMenuItem";
            this.GestionarReparacionesToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.GestionarReparacionesToolStripMenuItem.Text = "Reparaciones";
            this.GestionarReparacionesToolStripMenuItem.Click += new System.EventHandler(this.GestionarReparacionesToolStripMenuItem_Click);
            // 
            // GestionarProveedoresToolStripMenuItem
            // 
            this.GestionarProveedoresToolStripMenuItem.Name = "GestionarProveedoresToolStripMenuItem";
            this.GestionarProveedoresToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.GestionarProveedoresToolStripMenuItem.Text = "Proveedores";
            this.GestionarProveedoresToolStripMenuItem.Click += new System.EventHandler(this.GestionarProveedoresToolStripMenuItem_Click);
            // 
            // ingresoFacturasToolStripMenuItem
            // 
            this.ingresoFacturasToolStripMenuItem.Name = "ingresoFacturasToolStripMenuItem";
            this.ingresoFacturasToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.ingresoFacturasToolStripMenuItem.Text = "Ingresar Facturas";
            this.ingresoFacturasToolStripMenuItem.Click += new System.EventHandler(this.ingresoFacturasToolStripMenuItem_Click);
            // 
            // ordenesDePagoToolStripMenuItem
            // 
            this.ordenesDePagoToolStripMenuItem.Name = "ordenesDePagoToolStripMenuItem";
            this.ordenesDePagoToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.ordenesDePagoToolStripMenuItem.Text = "Ordenes de Pago";
            this.ordenesDePagoToolStripMenuItem.Click += new System.EventHandler(this.ordenesDePagoToolStripMenuItem_Click);
            // 
            // nuevaReparaciónToolStripMenuItem
            // 
            this.nuevaReparaciónToolStripMenuItem.Name = "nuevaReparaciónToolStripMenuItem";
            this.nuevaReparaciónToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.nuevaReparaciónToolStripMenuItem.Text = "Nueva Reparación";
            this.nuevaReparaciónToolStripMenuItem.Click += new System.EventHandler(this.nuevaReparaciónToolStripMenuItem_Click);
            // 
            // consultarHistorialReparacionesToolStripMenuItem
            // 
            this.consultarHistorialReparacionesToolStripMenuItem.Name = "consultarHistorialReparacionesToolStripMenuItem";
            this.consultarHistorialReparacionesToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.consultarHistorialReparacionesToolStripMenuItem.Text = "Consultar Historial Reparaciones";
            this.consultarHistorialReparacionesToolStripMenuItem.Click += new System.EventHandler(this.consultarHistorialReparacionesToolStripMenuItem_Click);
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrincipalForm_FormClosing);
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
        private System.Windows.Forms.ToolStripMenuItem GestionarUbicacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReparacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GestionarReparacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GestionarProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UsuarioDelActivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlDeCambiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoFacturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenesDePagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlDeCambiosFacturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaReparaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarHistorialReparacionesToolStripMenuItem;
    }
}

