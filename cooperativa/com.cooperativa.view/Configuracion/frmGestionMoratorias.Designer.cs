namespace com.cooperativa.view.Configuracion
{
    partial class frmGestionMoratorias
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
            this.dgvMoratorias = new System.Windows.Forms.DataGridView();
            this.IdMoratorias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VigenciaDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VigenciaHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadCuotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Limitada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.cmbAnio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNueva = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoratorias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMoratorias
            // 
            this.dgvMoratorias.AllowUserToAddRows = false;
            this.dgvMoratorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMoratorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMoratorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMoratorias,
            this.VigenciaDesde,
            this.VigenciaHasta,
            this.CantidadCuotas,
            this.Limitada});
            this.dgvMoratorias.Location = new System.Drawing.Point(12, 70);
            this.dgvMoratorias.MultiSelect = false;
            this.dgvMoratorias.Name = "dgvMoratorias";
            this.dgvMoratorias.ReadOnly = true;
            this.dgvMoratorias.Size = new System.Drawing.Size(622, 196);
            this.dgvMoratorias.TabIndex = 0;
            this.dgvMoratorias.SelectionChanged += new System.EventHandler(this.dgvMoratorias_SelectionChanged);
            // 
            // IdMoratorias
            // 
            this.IdMoratorias.DataPropertyName = "idmoratorias";
            this.IdMoratorias.HeaderText = "idMoratorias";
            this.IdMoratorias.Name = "IdMoratorias";
            this.IdMoratorias.ReadOnly = true;
            this.IdMoratorias.Visible = false;
            // 
            // VigenciaDesde
            // 
            this.VigenciaDesde.DataPropertyName = "vigencia_desde";
            this.VigenciaDesde.HeaderText = "Vigencia Desde";
            this.VigenciaDesde.Name = "VigenciaDesde";
            this.VigenciaDesde.ReadOnly = true;
            // 
            // VigenciaHasta
            // 
            this.VigenciaHasta.DataPropertyName = "vigencia_hasta";
            this.VigenciaHasta.HeaderText = "Vigencia Hasta";
            this.VigenciaHasta.Name = "VigenciaHasta";
            this.VigenciaHasta.ReadOnly = true;
            // 
            // CantidadCuotas
            // 
            this.CantidadCuotas.DataPropertyName = "cantidad_cuotas_max";
            this.CantidadCuotas.HeaderText = "Cantidad Cuotas";
            this.CantidadCuotas.Name = "CantidadCuotas";
            this.CantidadCuotas.ReadOnly = true;
            // 
            // Limitada
            // 
            this.Limitada.DataPropertyName = "limitar";
            this.Limitada.HeaderText = "Limitada";
            this.Limitada.Name = "Limitada";
            this.Limitada.ReadOnly = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(559, 25);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(462, 25);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Modificar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // cmbAnio
            // 
            this.cmbAnio.FormattingEnabled = true;
            this.cmbAnio.Location = new System.Drawing.Point(41, 27);
            this.cmbAnio.Name = "cmbAnio";
            this.cmbAnio.Size = new System.Drawing.Size(121, 21);
            this.cmbAnio.TabIndex = 3;
            this.cmbAnio.SelectedIndexChanged += new System.EventHandler(this.cmbAnio_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Año:";
            // 
            // btnNueva
            // 
            this.btnNueva.Location = new System.Drawing.Point(362, 25);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(75, 23);
            this.btnNueva.TabIndex = 5;
            this.btnNueva.Text = "Nueva";
            this.btnNueva.UseVisualStyleBackColor = true;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // frmGestionMoratorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 280);
            this.Controls.Add(this.btnNueva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAnio);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvMoratorias);
            this.Name = "frmGestionMoratorias";
            this.Text = "frmGestionMoratorias";
            this.Load += new System.EventHandler(this.frmGestionMoratorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMoratorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMoratorias;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ComboBox cmbAnio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMoratorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn VigenciaDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn VigenciaHasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadCuotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Limitada;
    }
}