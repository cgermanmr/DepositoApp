namespace AppDeposito.Reparaciones
{
    partial class ConsultarHistorialReparacionesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaSolicitudDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFinalizacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demoraReparacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solicitanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realizadaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsGrilla = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalDias = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalReparaciones = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblActivo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bsActivo = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGrilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsActivo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descripcionDataGridViewTextBoxColumn,
            this.fechaSolicitudDataGridViewTextBoxColumn,
            this.fechaFinalizacionDataGridViewTextBoxColumn,
            this.demoraReparacionDataGridViewTextBoxColumn,
            this.CostoFinal,
            this.solicitanteDataGridViewTextBoxColumn,
            this.realizadaDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.bsGrilla;
            this.dataGridView1.Location = new System.Drawing.Point(12, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(716, 231);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Falla";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaSolicitudDataGridViewTextBoxColumn
            // 
            this.fechaSolicitudDataGridViewTextBoxColumn.DataPropertyName = "FechaSolicitud";
            this.fechaSolicitudDataGridViewTextBoxColumn.HeaderText = "Inicio";
            this.fechaSolicitudDataGridViewTextBoxColumn.Name = "fechaSolicitudDataGridViewTextBoxColumn";
            this.fechaSolicitudDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaFinalizacionDataGridViewTextBoxColumn
            // 
            this.fechaFinalizacionDataGridViewTextBoxColumn.DataPropertyName = "FechaFinalizacion";
            this.fechaFinalizacionDataGridViewTextBoxColumn.HeaderText = "Fin";
            this.fechaFinalizacionDataGridViewTextBoxColumn.Name = "fechaFinalizacionDataGridViewTextBoxColumn";
            this.fechaFinalizacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // demoraReparacionDataGridViewTextBoxColumn
            // 
            this.demoraReparacionDataGridViewTextBoxColumn.DataPropertyName = "DemoraReparacion";
            this.demoraReparacionDataGridViewTextBoxColumn.HeaderText = "Dias Demora";
            this.demoraReparacionDataGridViewTextBoxColumn.Name = "demoraReparacionDataGridViewTextBoxColumn";
            this.demoraReparacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CostoFinal
            // 
            this.CostoFinal.DataPropertyName = "CostoFinal";
            dataGridViewCellStyle1.Format = "C0";
            this.CostoFinal.DefaultCellStyle = dataGridViewCellStyle1;
            this.CostoFinal.HeaderText = "Costo Final";
            this.CostoFinal.Name = "CostoFinal";
            this.CostoFinal.ReadOnly = true;
            // 
            // solicitanteDataGridViewTextBoxColumn
            // 
            this.solicitanteDataGridViewTextBoxColumn.DataPropertyName = "Solicitante";
            this.solicitanteDataGridViewTextBoxColumn.HeaderText = "Solicitante";
            this.solicitanteDataGridViewTextBoxColumn.Name = "solicitanteDataGridViewTextBoxColumn";
            this.solicitanteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // realizadaDataGridViewCheckBoxColumn
            // 
            this.realizadaDataGridViewCheckBoxColumn.DataPropertyName = "Realizada";
            this.realizadaDataGridViewCheckBoxColumn.HeaderText = "Realizada";
            this.realizadaDataGridViewCheckBoxColumn.Name = "realizadaDataGridViewCheckBoxColumn";
            this.realizadaDataGridViewCheckBoxColumn.ReadOnly = true;
            this.realizadaDataGridViewCheckBoxColumn.Width = 60;
            // 
            // bsGrilla
            // 
            this.bsGrilla.DataSource = typeof(BEL.ReparacionBEL);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Costo total en reparaciones:";
            // 
            // lblTotalDias
            // 
            this.lblTotalDias.AutoSize = true;
            this.lblTotalDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDias.Location = new System.Drawing.Point(286, 62);
            this.lblTotalDias.Name = "lblTotalDias";
            this.lblTotalDias.Size = new System.Drawing.Size(13, 17);
            this.lblTotalDias.TabIndex = 5;
            this.lblTotalDias.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dias en reparación";
            // 
            // lblTotalReparaciones
            // 
            this.lblTotalReparaciones.AutoSize = true;
            this.lblTotalReparaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalReparaciones.Location = new System.Drawing.Point(121, 62);
            this.lblTotalReparaciones.Name = "lblTotalReparaciones";
            this.lblTotalReparaciones.Size = new System.Drawing.Size(13, 17);
            this.lblTotalReparaciones.TabIndex = 7;
            this.lblTotalReparaciones.Text = " ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total Reparaciones:";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(494, 62);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(13, 17);
            this.lblCosto.TabIndex = 9;
            this.lblCosto.Text = " ";
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Location = new System.Drawing.Point(217, 28);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(25, 13);
            this.lblActivo.TabIndex = 10;
            this.lblActivo.Text = "      ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Equipo:";
            // 
            // bsActivo
            // 
            this.bsActivo.DataSource = typeof(BEL.ActivoBEL);
            // 
            // ConsultarHistorialReparacionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 338);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblActivo);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTotalReparaciones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotalDias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ConsultarHistorialReparacionesForm";
            this.Text = "Consultar Historial de Reparaciones";
            this.Load += new System.EventHandler(this.ConsultarHistorialReparacionesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGrilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsActivo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsGrilla;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bsActivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalDias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalReparaciones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaSolicitudDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFinalizacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn demoraReparacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn solicitanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn realizadaDataGridViewCheckBoxColumn;
    }
}