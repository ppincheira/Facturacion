namespace com.cooperativa.view
{
    partial class frmConceptosParticulares
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConceptosParticulares));
            this.dgvConceptosPart = new System.Windows.Forms.DataGridView();
            this.id_concepto_particular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvConceptos = new System.Windows.Forms.DataGridView();
            this.id_concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.variable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.cmbPeriodo = new System.Windows.Forms.ComboBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConceptosPart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConceptos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConceptosPart
            // 
            this.dgvConceptosPart.AllowUserToAddRows = false;
            this.dgvConceptosPart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConceptosPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConceptosPart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_concepto_particular,
            this.importe,
            this.id_periodo});
            this.dgvConceptosPart.Location = new System.Drawing.Point(13, 13);
            this.dgvConceptosPart.Name = "dgvConceptosPart";
            this.dgvConceptosPart.ReadOnly = true;
            this.dgvConceptosPart.Size = new System.Drawing.Size(378, 218);
            this.dgvConceptosPart.StandardTab = true;
            this.dgvConceptosPart.TabIndex = 0;
            this.dgvConceptosPart.SelectionChanged += new System.EventHandler(this.dgvConceptosPart_SelectionChanged);
            // 
            // id_concepto_particular
            // 
            this.id_concepto_particular.DataPropertyName = "id_concepto_particular";
            this.id_concepto_particular.HeaderText = "id_concepto_particular";
            this.id_concepto_particular.Name = "id_concepto_particular";
            this.id_concepto_particular.ReadOnly = true;
            this.id_concepto_particular.Visible = false;
            // 
            // importe
            // 
            this.importe.DataPropertyName = "importe";
            this.importe.HeaderText = "importe";
            this.importe.Name = "importe";
            this.importe.ReadOnly = true;
            // 
            // id_periodo
            // 
            this.id_periodo.DataPropertyName = "id_periodo";
            this.id_periodo.HeaderText = "periodo";
            this.id_periodo.Name = "id_periodo";
            this.id_periodo.ReadOnly = true;
            // 
            // dgvConceptos
            // 
            this.dgvConceptos.AllowUserToAddRows = false;
            this.dgvConceptos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConceptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConceptos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_concepto,
            this.concepto,
            this.variable});
            this.dgvConceptos.Location = new System.Drawing.Point(437, 13);
            this.dgvConceptos.Name = "dgvConceptos";
            this.dgvConceptos.Size = new System.Drawing.Size(385, 251);
            this.dgvConceptos.TabIndex = 1;
            // 
            // id_concepto
            // 
            this.id_concepto.DataPropertyName = "id_concepto";
            this.id_concepto.HeaderText = "id_concepto";
            this.id_concepto.Name = "id_concepto";
            this.id_concepto.Visible = false;
            // 
            // concepto
            // 
            this.concepto.DataPropertyName = "concepto";
            this.concepto.HeaderText = "concepto";
            this.concepto.Name = "concepto";
            // 
            // variable
            // 
            this.variable.DataPropertyName = "variable";
            this.variable.HeaderText = "importe";
            this.variable.Name = "variable";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(397, 46);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(34, 33);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "<<";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(397, 85);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(34, 33);
            this.btnQuitar.TabIndex = 3;
            this.btnQuitar.Text = "X";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(255, 270);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(136, 28);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.FormattingEnabled = true;
            this.cmbPeriodo.Location = new System.Drawing.Point(128, 275);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(112, 21);
            this.cmbPeriodo.TabIndex = 5;
            this.cmbPeriodo.SelectedIndexChanged += new System.EventHandler(this.cmbPeriodo_SelectedIndexChanged);
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(128, 244);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(112, 20);
            this.txtImporte.TabIndex = 6;
            this.txtImporte.TextChanged += new System.EventHandler(this.txtImporte_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Importe del concepto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Período de facturación";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(700, 275);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(122, 28);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(560, 275);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(124, 28);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmConceptosParticulares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 308);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.cmbPeriodo);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvConceptos);
            this.Controls.Add(this.dgvConceptosPart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConceptosParticulares";
            this.Text = "frmConceptosParticulares";
            this.Load += new System.EventHandler(this.frmConceptosParticulares_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConceptosPart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConceptos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConceptosPart;
        private System.Windows.Forms.DataGridView dgvConceptos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ComboBox cmbPeriodo;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn variable;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_concepto_particular;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_periodo;
    }
}