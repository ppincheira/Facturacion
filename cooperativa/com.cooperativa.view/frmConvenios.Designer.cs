namespace com.cooperativa.view
{
    partial class frmConvenios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConvenios));
            this.gbSocio = new System.Windows.Forms.GroupBox();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.btnNuevoConvenio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminarConvenio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificarConvenio = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.mtxtNumero = new System.Windows.Forms.MaskedTextBox();
            this.dgvConvenio = new System.Windows.Forms.DataGridView();
            this.idConvenio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Facturadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Terminado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbSocio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConvenio)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSocio
            // 
            this.gbSocio.Controls.Add(this.btnTransferir);
            this.gbSocio.Controls.Add(this.btnNuevoConvenio);
            this.gbSocio.Controls.Add(this.label2);
            this.gbSocio.Controls.Add(this.btnEliminarConvenio);
            this.gbSocio.Controls.Add(this.label1);
            this.gbSocio.Controls.Add(this.btnModificarConvenio);
            this.gbSocio.Controls.Add(this.txtNombre);
            this.gbSocio.Controls.Add(this.mtxtNumero);
            this.gbSocio.Location = new System.Drawing.Point(12, 12);
            this.gbSocio.Name = "gbSocio";
            this.gbSocio.Size = new System.Drawing.Size(743, 81);
            this.gbSocio.TabIndex = 1;
            this.gbSocio.TabStop = false;
            this.gbSocio.Text = "Socio";
            // 
            // btnTransferir
            // 
            this.btnTransferir.Location = new System.Drawing.Point(607, 45);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(112, 23);
            this.btnTransferir.TabIndex = 7;
            this.btnTransferir.Text = "&Transferir";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // btnNuevoConvenio
            // 
            this.btnNuevoConvenio.Location = new System.Drawing.Point(24, 45);
            this.btnNuevoConvenio.Name = "btnNuevoConvenio";
            this.btnNuevoConvenio.Size = new System.Drawing.Size(112, 23);
            this.btnNuevoConvenio.TabIndex = 4;
            this.btnNuevoConvenio.Text = "&Nuevo Convenio";
            this.btnNuevoConvenio.UseVisualStyleBackColor = true;
            this.btnNuevoConvenio.Click += new System.EventHandler(this.btnNuevoConvenio_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // btnEliminarConvenio
            // 
            this.btnEliminarConvenio.Location = new System.Drawing.Point(416, 45);
            this.btnEliminarConvenio.Name = "btnEliminarConvenio";
            this.btnEliminarConvenio.Size = new System.Drawing.Size(112, 23);
            this.btnEliminarConvenio.TabIndex = 6;
            this.btnEliminarConvenio.Text = "&Eliminar Convenio";
            this.btnEliminarConvenio.UseVisualStyleBackColor = true;
            this.btnEliminarConvenio.Click += new System.EventHandler(this.btnEliminarConvenio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero:";
            // 
            // btnModificarConvenio
            // 
            this.btnModificarConvenio.Location = new System.Drawing.Point(221, 45);
            this.btnModificarConvenio.Name = "btnModificarConvenio";
            this.btnModificarConvenio.Size = new System.Drawing.Size(112, 23);
            this.btnModificarConvenio.TabIndex = 5;
            this.btnModificarConvenio.Text = "&Modificar Convenio";
            this.btnModificarConvenio.UseVisualStyleBackColor = true;
            this.btnModificarConvenio.Click += new System.EventHandler(this.btnModificarConvenio_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNombre.Location = new System.Drawing.Point(320, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(399, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // mtxtNumero
            // 
            this.mtxtNumero.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mtxtNumero.Location = new System.Drawing.Point(70, 19);
            this.mtxtNumero.Mask = "000000/00";
            this.mtxtNumero.Name = "mtxtNumero";
            this.mtxtNumero.ReadOnly = true;
            this.mtxtNumero.Size = new System.Drawing.Size(100, 20);
            this.mtxtNumero.TabIndex = 0;
            // 
            // dgvConvenio
            // 
            this.dgvConvenio.AllowDrop = true;
            this.dgvConvenio.AllowUserToAddRows = false;
            this.dgvConvenio.AllowUserToDeleteRows = false;
            this.dgvConvenio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConvenio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConvenio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConvenio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idConvenio,
            this.fecha,
            this.Importe,
            this.Cuotas,
            this.ValorCuota,
            this.Facturadas,
            this.Terminado,
            this.NV});
            this.dgvConvenio.Location = new System.Drawing.Point(12, 99);
            this.dgvConvenio.Name = "dgvConvenio";
            this.dgvConvenio.Size = new System.Drawing.Size(743, 159);
            this.dgvConvenio.TabIndex = 2;
            // 
            // idConvenio
            // 
            this.idConvenio.DataPropertyName = "id_convenio";
            this.idConvenio.HeaderText = "idConvenio";
            this.idConvenio.Name = "idConvenio";
            this.idConvenio.Visible = false;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha_convenio";
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            // 
            // Importe
            // 
            this.Importe.DataPropertyName = "importe_total";
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            // 
            // Cuotas
            // 
            this.Cuotas.DataPropertyName = "cuotas";
            this.Cuotas.HeaderText = "Cuotas";
            this.Cuotas.Name = "Cuotas";
            // 
            // ValorCuota
            // 
            this.ValorCuota.DataPropertyName = "valor_cuota";
            this.ValorCuota.HeaderText = "Valor Cuota";
            this.ValorCuota.Name = "ValorCuota";
            // 
            // Facturadas
            // 
            this.Facturadas.DataPropertyName = "facturadas";
            this.Facturadas.HeaderText = "Facturadas";
            this.Facturadas.Name = "Facturadas";
            // 
            // Terminado
            // 
            this.Terminado.DataPropertyName = "finalizado";
            this.Terminado.HeaderText = "Terminado";
            this.Terminado.Name = "Terminado";
            // 
            // NV
            // 
            this.NV.HeaderText = "NV";
            this.NV.Name = "NV";
            this.NV.Visible = false;
            // 
            // frmConvenios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 270);
            this.Controls.Add(this.dgvConvenio);
            this.Controls.Add(this.gbSocio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(599, 308);
            this.Name = "frmConvenios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Convenios";
            this.Load += new System.EventHandler(this.frmConvenios_Load);
            this.gbSocio.ResumeLayout(false);
            this.gbSocio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConvenio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSocio;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.Button btnNuevoConvenio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminarConvenio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModificarConvenio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.MaskedTextBox mtxtNumero;
        private System.Windows.Forms.DataGridView dgvConvenio;
        private System.Windows.Forms.DataGridViewTextBoxColumn idConvenio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Facturadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Terminado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NV;
    }
}