namespace com.cooperativa.view
{
    partial class frmMediciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMediciones));
            this.txtSubcodigoSocio = new System.Windows.Forms.TextBox();
            this.txtCodigoSocio = new System.Windows.Forms.TextBox();
            this.txtNombreSocio = new System.Windows.Forms.TextBox();
            this.txtMedidor = new System.Windows.Forms.TextBox();
            this.gbMedidor = new System.Windows.Forms.GroupBox();
            this.gbSocio = new System.Windows.Forms.GroupBox();
            this.dvMediciones = new System.Windows.Forms.DataGridView();
            this.Periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaLectura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lectura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LecturaAnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbMedidor.SuspendLayout();
            this.gbSocio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvMediciones)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSubcodigoSocio
            // 
            this.txtSubcodigoSocio.Enabled = false;
            this.txtSubcodigoSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubcodigoSocio.Location = new System.Drawing.Point(113, 28);
            this.txtSubcodigoSocio.Name = "txtSubcodigoSocio";
            this.txtSubcodigoSocio.ReadOnly = true;
            this.txtSubcodigoSocio.Size = new System.Drawing.Size(28, 20);
            this.txtSubcodigoSocio.TabIndex = 0;
            // 
            // txtCodigoSocio
            // 
            this.txtCodigoSocio.Enabled = false;
            this.txtCodigoSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoSocio.Location = new System.Drawing.Point(23, 28);
            this.txtCodigoSocio.Name = "txtCodigoSocio";
            this.txtCodigoSocio.ReadOnly = true;
            this.txtCodigoSocio.Size = new System.Drawing.Size(84, 20);
            this.txtCodigoSocio.TabIndex = 1;
            // 
            // txtNombreSocio
            // 
            this.txtNombreSocio.Enabled = false;
            this.txtNombreSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreSocio.Location = new System.Drawing.Point(160, 28);
            this.txtNombreSocio.Name = "txtNombreSocio";
            this.txtNombreSocio.ReadOnly = true;
            this.txtNombreSocio.Size = new System.Drawing.Size(293, 20);
            this.txtNombreSocio.TabIndex = 2;
            // 
            // txtMedidor
            // 
            this.txtMedidor.Enabled = false;
            this.txtMedidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedidor.Location = new System.Drawing.Point(16, 28);
            this.txtMedidor.Name = "txtMedidor";
            this.txtMedidor.ReadOnly = true;
            this.txtMedidor.Size = new System.Drawing.Size(100, 20);
            this.txtMedidor.TabIndex = 3;
            // 
            // gbMedidor
            // 
            this.gbMedidor.Controls.Add(this.txtMedidor);
            this.gbMedidor.Location = new System.Drawing.Point(503, 12);
            this.gbMedidor.Name = "gbMedidor";
            this.gbMedidor.Size = new System.Drawing.Size(130, 63);
            this.gbMedidor.TabIndex = 4;
            this.gbMedidor.TabStop = false;
            this.gbMedidor.Text = "Medidor";
            // 
            // gbSocio
            // 
            this.gbSocio.Controls.Add(this.txtNombreSocio);
            this.gbSocio.Controls.Add(this.txtCodigoSocio);
            this.gbSocio.Controls.Add(this.txtSubcodigoSocio);
            this.gbSocio.Location = new System.Drawing.Point(12, 12);
            this.gbSocio.Name = "gbSocio";
            this.gbSocio.Size = new System.Drawing.Size(474, 63);
            this.gbSocio.TabIndex = 5;
            this.gbSocio.TabStop = false;
            this.gbSocio.Text = "Socio";
            // 
            // dvMediciones
            // 
            this.dvMediciones.AllowUserToAddRows = false;
            this.dvMediciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvMediciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Periodo,
            this.Consumo,
            this.FechaLectura,
            this.Lectura,
            this.FechaAnt,
            this.LecturaAnt});
            this.dvMediciones.Location = new System.Drawing.Point(12, 81);
            this.dvMediciones.MultiSelect = false;
            this.dvMediciones.Name = "dvMediciones";
            this.dvMediciones.Size = new System.Drawing.Size(621, 244);
            this.dvMediciones.TabIndex = 6;
            // 
            // Periodo
            // 
            this.Periodo.DataPropertyName = "Periodo";
            this.Periodo.HeaderText = "Periodo";
            this.Periodo.Name = "Periodo";
            this.Periodo.ReadOnly = true;
            // 
            // Consumo
            // 
            this.Consumo.DataPropertyName = "Consumo";
            this.Consumo.HeaderText = "Consumo";
            this.Consumo.Name = "Consumo";
            this.Consumo.ReadOnly = true;
            // 
            // FechaLectura
            // 
            this.FechaLectura.DataPropertyName = "FechaLectura";
            this.FechaLectura.HeaderText = "Fecha Lectura";
            this.FechaLectura.Name = "FechaLectura";
            this.FechaLectura.ReadOnly = true;
            // 
            // Lectura
            // 
            this.Lectura.DataPropertyName = "Lectura";
            this.Lectura.HeaderText = "Lectura";
            this.Lectura.Name = "Lectura";
            this.Lectura.ReadOnly = true;
            // 
            // FechaAnt
            // 
            this.FechaAnt.DataPropertyName = "FechaAnt";
            this.FechaAnt.HeaderText = "Fecha Ant";
            this.FechaAnt.Name = "FechaAnt";
            this.FechaAnt.ReadOnly = true;
            // 
            // LecturaAnt
            // 
            this.LecturaAnt.DataPropertyName = "LecturaAnt";
            this.LecturaAnt.HeaderText = "Lectura Ant";
            this.LecturaAnt.Name = "LecturaAnt";
            this.LecturaAnt.ReadOnly = true;
            // 
            // frmMediciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 332);
            this.Controls.Add(this.dvMediciones);
            this.Controls.Add(this.gbSocio);
            this.Controls.Add(this.gbMedidor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMediciones";
            this.Text = "frmMediciones";
            this.Load += new System.EventHandler(this.frmMediciones_Load);
            this.gbMedidor.ResumeLayout(false);
            this.gbMedidor.PerformLayout();
            this.gbSocio.ResumeLayout(false);
            this.gbSocio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvMediciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSubcodigoSocio;
        private System.Windows.Forms.TextBox txtCodigoSocio;
        private System.Windows.Forms.TextBox txtNombreSocio;
        private System.Windows.Forms.TextBox txtMedidor;
        private System.Windows.Forms.GroupBox gbMedidor;
        private System.Windows.Forms.GroupBox gbSocio;
        private System.Windows.Forms.DataGridView dvMediciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaLectura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lectura;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn LecturaAnt;
    }
}