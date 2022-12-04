namespace AppDeposito.Test
{
    partial class AyudaForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Nueva Reparación");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Ingresar presupuesto");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Reparaciones", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Ingreso de Facturas");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Generar Orden de Pago");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Pagos", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\UAI\\TD\\DepositoApp\\Ayuda\\Procedimiento para mostrar ayuda emergente - Windows " +
    "Forms .NET Framework _ Microsoft Learn.html";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(666, 475);
            this.splitContainer1.SplitterDistance = 222;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Nodo0";
            treeNode1.Tag = "Reparaciones\\NuevaReparacion";
            treeNode1.Text = "Nueva Reparación";
            treeNode2.Name = "Nodo2";
            treeNode2.Tag = "Reparaciones\\IngresarPresupuesto";
            treeNode2.Text = "Ingresar presupuesto";
            treeNode3.Name = "Nodo0";
            treeNode3.Tag = "";
            treeNode3.Text = "Reparaciones";
            treeNode4.Name = "Nodo3";
            treeNode4.Tag = "Pagos\\IngresarFacturas";
            treeNode4.Text = "Ingreso de Facturas";
            treeNode5.Name = "Nodo4";
            treeNode5.Tag = "Pagos\\GenerarOrdenPago";
            treeNode5.Text = "Generar Orden de Pago";
            treeNode6.Name = "Nodo1";
            treeNode6.Tag = "";
            treeNode6.Text = "Pagos";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(222, 475);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(440, 475);
            this.webBrowser1.TabIndex = 0;
            // 
            // PruebaAyudaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 475);
            this.Controls.Add(this.splitContainer1);
            this.HelpButton = true;
            this.Name = "PruebaAyudaForm";
            this.Text = "Ayuda";
            this.Load += new System.EventHandler(this.PruebaAyudaForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}