namespace com.cooperativa.view
{
    partial class frmCuentaCorriente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCuentaCorriente));
            this.gbSocio = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.mtxtNumero = new System.Windows.Forms.MaskedTextBox();
            this.dgvCuentas = new System.Windows.Forms.DataGridView();
            this.id_cuenta_corriente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Socio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_cobranza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debitos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Creditos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbSocio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSocio
            // 
            this.gbSocio.Controls.Add(this.label2);
            this.gbSocio.Controls.Add(this.label1);
            this.gbSocio.Controls.Add(this.txtNombre);
            this.gbSocio.Controls.Add(this.mtxtNumero);
            this.gbSocio.Enabled = false;
            this.gbSocio.Location = new System.Drawing.Point(12, 12);
            this.gbSocio.Name = "gbSocio";
            this.gbSocio.Size = new System.Drawing.Size(579, 52);
            this.gbSocio.TabIndex = 0;
            this.gbSocio.TabStop = false;
            this.gbSocio.Text = "Socio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(229, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(296, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // mtxtNumero
            // 
            this.mtxtNumero.Location = new System.Drawing.Point(52, 19);
            this.mtxtNumero.Mask = "000000/00";
            this.mtxtNumero.Name = "mtxtNumero";
            this.mtxtNumero.Size = new System.Drawing.Size(100, 20);
            this.mtxtNumero.TabIndex = 0;
            // 
            // dgvCuentas
            // 
            this.dgvCuentas.AllowUserToAddRows = false;
            this.dgvCuentas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCuentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cuenta_corriente,
            this.id_Socio,
            this.id_cobranza,
            this.ID_Factura,
            this.Fecha,
            this.Descripcion,
            this.Debitos,
            this.Creditos,
            this.Saldo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCuentas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCuentas.Location = new System.Drawing.Point(0, 75);
            this.dgvCuentas.Name = "dgvCuentas";
            this.dgvCuentas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCuentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCuentas.Size = new System.Drawing.Size(731, 219);
            this.dgvCuentas.TabIndex = 1;
            // 
            // id_cuenta_corriente
            // 
            this.id_cuenta_corriente.DataPropertyName = "id_cuenta_corriente";
            this.id_cuenta_corriente.HeaderText = "id_cuenta_corriente";
            this.id_cuenta_corriente.Name = "id_cuenta_corriente";
            this.id_cuenta_corriente.ReadOnly = true;
            this.id_cuenta_corriente.Visible = false;
            // 
            // id_Socio
            // 
            this.id_Socio.DataPropertyName = "id_socio";
            this.id_Socio.HeaderText = "id_socio";
            this.id_Socio.Name = "id_Socio";
            this.id_Socio.ReadOnly = true;
            this.id_Socio.Visible = false;
            // 
            // id_cobranza
            // 
            this.id_cobranza.DataPropertyName = "id_cobranza";
            this.id_cobranza.HeaderText = "Comp Caja";
            this.id_cobranza.Name = "id_cobranza";
            this.id_cobranza.ReadOnly = true;
            this.id_cobranza.Width = 90;
            // 
            // ID_Factura
            // 
            this.ID_Factura.DataPropertyName = "id_factura";
            this.ID_Factura.HeaderText = "Factura";
            this.ID_Factura.Name = "ID_Factura";
            this.ID_Factura.ReadOnly = true;
            this.ID_Factura.Width = 80;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 80;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "movimiento";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 200;
            // 
            // Debitos
            // 
            this.Debitos.DataPropertyName = "debito";
            this.Debitos.HeaderText = "Débitos";
            this.Debitos.Name = "Debitos";
            this.Debitos.ReadOnly = true;
            this.Debitos.Width = 80;
            // 
            // Creditos
            // 
            this.Creditos.DataPropertyName = "credito";
            this.Creditos.HeaderText = "Créditos";
            this.Creditos.Name = "Creditos";
            this.Creditos.ReadOnly = true;
            this.Creditos.Width = 80;
            // 
            // Saldo
            // 
            this.Saldo.DataPropertyName = "saldo";
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            this.Saldo.Width = 80;
            // 
            // frmCuentaCorriente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 297);
            this.Controls.Add(this.dgvCuentas);
            this.Controls.Add(this.gbSocio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(618, 332);
            this.Name = "frmCuentaCorriente";
            this.Text = "Cuenta Corriente";
            this.Load += new System.EventHandler(this.frmCuentaCorriente_Load);
            this.gbSocio.ResumeLayout(false);
            this.gbSocio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSocio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.MaskedTextBox mtxtNumero;
        private System.Windows.Forms.DataGridView dgvCuentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cuenta_corriente;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Socio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cobranza;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debitos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Creditos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
    }
}