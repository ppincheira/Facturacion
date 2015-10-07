namespace com.cooperativa.view
{
    partial class frmAcciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcciones));
            this.gbAcciones = new System.Windows.Forms.GroupBox();
            this.btnNuevaSuscripcion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminarSuscripcion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificarSuscripcion = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.mtxtNumero = new System.Windows.Forms.MaskedTextBox();
            this.dgvAcciones = new System.Windows.Forms.DataGridView();
            this.id_accion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Facturadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pendientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Terminado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcciones)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAcciones
            // 
            this.gbAcciones.Controls.Add(this.btnNuevaSuscripcion);
            this.gbAcciones.Controls.Add(this.label2);
            this.gbAcciones.Controls.Add(this.btnEliminarSuscripcion);
            this.gbAcciones.Controls.Add(this.label1);
            this.gbAcciones.Controls.Add(this.btnModificarSuscripcion);
            this.gbAcciones.Controls.Add(this.txtNombre);
            this.gbAcciones.Controls.Add(this.mtxtNumero);
            this.gbAcciones.Location = new System.Drawing.Point(12, 12);
            this.gbAcciones.Name = "gbAcciones";
            this.gbAcciones.Size = new System.Drawing.Size(547, 78);
            this.gbAcciones.TabIndex = 0;
            this.gbAcciones.TabStop = false;
            this.gbAcciones.Text = "Socio";
            // 
            // btnNuevaSuscripcion
            // 
            this.btnNuevaSuscripcion.Location = new System.Drawing.Point(19, 49);
            this.btnNuevaSuscripcion.Name = "btnNuevaSuscripcion";
            this.btnNuevaSuscripcion.Size = new System.Drawing.Size(178, 23);
            this.btnNuevaSuscripcion.TabIndex = 11;
            this.btnNuevaSuscripcion.Text = "&Nueva suscripción de acciones";
            this.btnNuevaSuscripcion.UseVisualStyleBackColor = true;
            this.btnNuevaSuscripcion.Click += new System.EventHandler(this.btnNuevaSuscripcion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre:";
            // 
            // btnEliminarSuscripcion
            // 
            this.btnEliminarSuscripcion.Location = new System.Drawing.Point(410, 49);
            this.btnEliminarSuscripcion.Name = "btnEliminarSuscripcion";
            this.btnEliminarSuscripcion.Size = new System.Drawing.Size(112, 23);
            this.btnEliminarSuscripcion.TabIndex = 13;
            this.btnEliminarSuscripcion.Text = "&Eliminar Suscripción";
            this.btnEliminarSuscripcion.UseVisualStyleBackColor = true;
            this.btnEliminarSuscripcion.Click += new System.EventHandler(this.btnEliminarSuscripcion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Numero:";
            // 
            // btnModificarSuscripcion
            // 
            this.btnModificarSuscripcion.Location = new System.Drawing.Point(237, 49);
            this.btnModificarSuscripcion.Name = "btnModificarSuscripcion";
            this.btnModificarSuscripcion.Size = new System.Drawing.Size(131, 23);
            this.btnModificarSuscripcion.TabIndex = 12;
            this.btnModificarSuscripcion.Text = "&Modificar suscripción";
            this.btnModificarSuscripcion.UseVisualStyleBackColor = true;
            this.btnModificarSuscripcion.Click += new System.EventHandler(this.btnModificarSuscripcion_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(216, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(306, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // mtxtNumero
            // 
            this.mtxtNumero.Location = new System.Drawing.Point(69, 19);
            this.mtxtNumero.Mask = "000000/00";
            this.mtxtNumero.Name = "mtxtNumero";
            this.mtxtNumero.Size = new System.Drawing.Size(64, 20);
            this.mtxtNumero.TabIndex = 7;
            // 
            // dgvAcciones
            // 
            this.dgvAcciones.AllowUserToAddRows = false;
            this.dgvAcciones.AllowUserToDeleteRows = false;
            this.dgvAcciones.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAcciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAcciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_accion,
            this.fecha,
            this.Importe,
            this.Cuotas,
            this.ValorCuota,
            this.Facturadas,
            this.pendientes,
            this.Terminado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAcciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAcciones.Location = new System.Drawing.Point(12, 96);
            this.dgvAcciones.Name = "dgvAcciones";
            this.dgvAcciones.ReadOnly = true;
            this.dgvAcciones.Size = new System.Drawing.Size(552, 159);
            this.dgvAcciones.TabIndex = 3;
            this.dgvAcciones.SelectionChanged += new System.EventHandler(this.dgvAcciones_SelectionChanged);
            // 
            // id_accion
            // 
            this.id_accion.DataPropertyName = "id_accion";
            this.id_accion.HeaderText = "id_accion";
            this.id_accion.Name = "id_accion";
            this.id_accion.ReadOnly = true;
            this.id_accion.Visible = false;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // Importe
            // 
            this.Importe.DataPropertyName = "importe";
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // Cuotas
            // 
            this.Cuotas.DataPropertyName = "cuotas";
            this.Cuotas.HeaderText = "Cuotas";
            this.Cuotas.Name = "Cuotas";
            this.Cuotas.ReadOnly = true;
            // 
            // ValorCuota
            // 
            this.ValorCuota.DataPropertyName = "valor_cuota";
            this.ValorCuota.HeaderText = "Valor Cuota";
            this.ValorCuota.Name = "ValorCuota";
            this.ValorCuota.ReadOnly = true;
            // 
            // Facturadas
            // 
            this.Facturadas.DataPropertyName = "facturadas";
            this.Facturadas.HeaderText = "Facturadas";
            this.Facturadas.Name = "Facturadas";
            this.Facturadas.ReadOnly = true;
            // 
            // pendientes
            // 
            this.pendientes.DataPropertyName = "pendientes";
            this.pendientes.HeaderText = "Pendientes";
            this.pendientes.Name = "pendientes";
            this.pendientes.ReadOnly = true;
            // 
            // Terminado
            // 
            this.Terminado.DataPropertyName = "finalizado";
            this.Terminado.HeaderText = "Terminado";
            this.Terminado.Name = "Terminado";
            this.Terminado.ReadOnly = true;
            // 
            // frmAcciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 262);
            this.Controls.Add(this.dgvAcciones);
            this.Controls.Add(this.gbAcciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAcciones";
            this.Text = "frmAcciones";
            this.Load += new System.EventHandler(this.frmAcciones_Load);
            this.gbAcciones.ResumeLayout(false);
            this.gbAcciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAcciones;
        private System.Windows.Forms.Button btnNuevaSuscripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminarSuscripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModificarSuscripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.MaskedTextBox mtxtNumero;
        private System.Windows.Forms.DataGridView dgvAcciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_accion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Facturadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn pendientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Terminado;
    }
}