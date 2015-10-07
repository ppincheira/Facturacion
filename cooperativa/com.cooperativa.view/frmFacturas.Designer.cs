namespace com.cooperativa.view
{
    partial class frmFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturas));
            this.gbSocio = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtSubCodigo = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.gbAcciones = new System.Windows.Forms.GroupBox();
            this.btnGenerarInforme = new System.Windows.Forms.Button();
            this.chkInformacionAdic = new System.Windows.Forms.CheckBox();
            this.chkValoresAct = new System.Windows.Forms.CheckBox();
            this.chkMostrarImpagas = new System.Windows.Forms.CheckBox();
            this.gbTotales = new System.Windows.Forms.GroupBox();
            this.txtRecargo = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtFactListadas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvConceptos = new System.Windows.Forms.DataGridView();
            this.id_Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDetalleConceptos = new System.Windows.Forms.Button();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.id_factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVenc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Neto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVA_Rec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVA_Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cobrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cons_M3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lectura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lect_Ant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiasVenc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbSocio.SuspendLayout();
            this.gbAcciones.SuspendLayout();
            this.gbTotales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConceptos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSocio
            // 
            this.gbSocio.Controls.Add(this.txtNombre);
            this.gbSocio.Controls.Add(this.txtSubCodigo);
            this.gbSocio.Controls.Add(this.txtCodigo);
            this.gbSocio.Controls.Add(this.lblCodigo);
            this.gbSocio.Location = new System.Drawing.Point(12, 12);
            this.gbSocio.Name = "gbSocio";
            this.gbSocio.Size = new System.Drawing.Size(531, 59);
            this.gbSocio.TabIndex = 0;
            this.gbSocio.TabStop = false;
            this.gbSocio.Text = "Socio";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(214, 24);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(304, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtSubCodigo
            // 
            this.txtSubCodigo.Enabled = false;
            this.txtSubCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubCodigo.Location = new System.Drawing.Point(168, 24);
            this.txtSubCodigo.Name = "txtSubCodigo";
            this.txtSubCodigo.ReadOnly = true;
            this.txtSubCodigo.Size = new System.Drawing.Size(30, 20);
            this.txtSubCodigo.TabIndex = 2;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(63, 24);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(99, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(22, 27);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo";
            // 
            // gbAcciones
            // 
            this.gbAcciones.Controls.Add(this.btnGenerarInforme);
            this.gbAcciones.Controls.Add(this.chkInformacionAdic);
            this.gbAcciones.Controls.Add(this.chkValoresAct);
            this.gbAcciones.Controls.Add(this.chkMostrarImpagas);
            this.gbAcciones.Location = new System.Drawing.Point(12, 89);
            this.gbAcciones.Name = "gbAcciones";
            this.gbAcciones.Size = new System.Drawing.Size(361, 94);
            this.gbAcciones.TabIndex = 1;
            this.gbAcciones.TabStop = false;
            this.gbAcciones.Text = "Acciones";
            // 
            // btnGenerarInforme
            // 
            this.btnGenerarInforme.Location = new System.Drawing.Point(258, 12);
            this.btnGenerarInforme.Name = "btnGenerarInforme";
            this.btnGenerarInforme.Size = new System.Drawing.Size(86, 75);
            this.btnGenerarInforme.TabIndex = 3;
            this.btnGenerarInforme.Text = "Generar informe  estado de cuenta";
            this.btnGenerarInforme.UseVisualStyleBackColor = true;
            this.btnGenerarInforme.Click += new System.EventHandler(this.btnGenerarInforme_Click);
            // 
            // chkInformacionAdic
            // 
            this.chkInformacionAdic.AutoSize = true;
            this.chkInformacionAdic.Location = new System.Drawing.Point(6, 65);
            this.chkInformacionAdic.Name = "chkInformacionAdic";
            this.chkInformacionAdic.Size = new System.Drawing.Size(161, 17);
            this.chkInformacionAdic.TabIndex = 2;
            this.chkInformacionAdic.Text = "Mostrar informacion adcional";
            this.chkInformacionAdic.UseVisualStyleBackColor = true;
            this.chkInformacionAdic.Visible = false;
            // 
            // chkValoresAct
            // 
            this.chkValoresAct.AutoSize = true;
            this.chkValoresAct.Location = new System.Drawing.Point(25, 42);
            this.chkValoresAct.Name = "chkValoresAct";
            this.chkValoresAct.Size = new System.Drawing.Size(143, 17);
            this.chkValoresAct.TabIndex = 1;
            this.chkValoresAct.Text = "con valores actualizados";
            this.chkValoresAct.UseVisualStyleBackColor = true;
            this.chkValoresAct.CheckedChanged += new System.EventHandler(this.chkValoresAct_CheckedChanged);
            // 
            // chkMostrarImpagas
            // 
            this.chkMostrarImpagas.AutoSize = true;
            this.chkMostrarImpagas.Location = new System.Drawing.Point(6, 19);
            this.chkMostrarImpagas.Name = "chkMostrarImpagas";
            this.chkMostrarImpagas.Size = new System.Drawing.Size(166, 17);
            this.chkMostrarImpagas.TabIndex = 0;
            this.chkMostrarImpagas.Text = "Mostrar solo facturas impagas";
            this.chkMostrarImpagas.UseVisualStyleBackColor = true;
            this.chkMostrarImpagas.CheckedChanged += new System.EventHandler(this.chkMostrarImpagas_CheckedChanged);
            // 
            // gbTotales
            // 
            this.gbTotales.Controls.Add(this.txtRecargo);
            this.gbTotales.Controls.Add(this.txtTotal);
            this.gbTotales.Controls.Add(this.txtFactListadas);
            this.gbTotales.Controls.Add(this.label4);
            this.gbTotales.Controls.Add(this.label3);
            this.gbTotales.Controls.Add(this.label2);
            this.gbTotales.Location = new System.Drawing.Point(379, 89);
            this.gbTotales.Name = "gbTotales";
            this.gbTotales.Size = new System.Drawing.Size(164, 94);
            this.gbTotales.TabIndex = 2;
            this.gbTotales.TabStop = false;
            this.gbTotales.Text = "Totales";
            // 
            // txtRecargo
            // 
            this.txtRecargo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRecargo.Location = new System.Drawing.Point(73, 68);
            this.txtRecargo.Name = "txtRecargo";
            this.txtRecargo.ReadOnly = true;
            this.txtRecargo.Size = new System.Drawing.Size(85, 20);
            this.txtRecargo.TabIndex = 5;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTotal.Location = new System.Drawing.Point(73, 42);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(85, 20);
            this.txtTotal.TabIndex = 4;
            // 
            // txtFactListadas
            // 
            this.txtFactListadas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtFactListadas.Location = new System.Drawing.Point(103, 16);
            this.txtFactListadas.Name = "txtFactListadas";
            this.txtFactListadas.ReadOnly = true;
            this.txtFactListadas.Size = new System.Drawing.Size(55, 20);
            this.txtFactListadas.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Recargo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fact. listadas";
            // 
            // dgvConceptos
            // 
            this.dgvConceptos.AllowUserToAddRows = false;
            this.dgvConceptos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConceptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConceptos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Concepto,
            this.Concepto,
            this.Valor});
            this.dgvConceptos.Location = new System.Drawing.Point(564, 21);
            this.dgvConceptos.Name = "dgvConceptos";
            this.dgvConceptos.ReadOnly = true;
            this.dgvConceptos.Size = new System.Drawing.Size(240, 130);
            this.dgvConceptos.TabIndex = 3;
            // 
            // id_Concepto
            // 
            this.id_Concepto.DataPropertyName = "id_Concepto";
            this.id_Concepto.HeaderText = "id_Concepto";
            this.id_Concepto.Name = "id_Concepto";
            this.id_Concepto.ReadOnly = true;
            this.id_Concepto.Visible = false;
            // 
            // Concepto
            // 
            this.Concepto.DataPropertyName = "Concepto";
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.Name = "Concepto";
            this.Concepto.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Importe";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // btnDetalleConceptos
            // 
            this.btnDetalleConceptos.Location = new System.Drawing.Point(564, 159);
            this.btnDetalleConceptos.Name = "btnDetalleConceptos";
            this.btnDetalleConceptos.Size = new System.Drawing.Size(240, 23);
            this.btnDetalleConceptos.TabIndex = 4;
            this.btnDetalleConceptos.Text = "Ver detalle completo de conceptos";
            this.btnDetalleConceptos.UseVisualStyleBackColor = true;
            this.btnDetalleConceptos.Click += new System.EventHandler(this.btnDetalleConceptos_Click);
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.AllowUserToAddRows = false;
            this.dgvFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_factura,
            this.idEstado,
            this.Periodo,
            this.Factura,
            this.FechaFact,
            this.FechaVenc,
            this.Estado,
            this.Total,
            this.Neto,
            this.IVA,
            this.Recargo,
            this.IVA_Rec,
            this.Descuento,
            this.IVA_Desc,
            this.Cobrado,
            this.Cons_M3,
            this.Lectura,
            this.Lect_Ant,
            this.DiasVenc});
            this.dgvFacturas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvFacturas.Location = new System.Drawing.Point(12, 189);
            this.dgvFacturas.MultiSelect = false;
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.ReadOnly = true;
            this.dgvFacturas.Size = new System.Drawing.Size(795, 259);
            this.dgvFacturas.TabIndex = 5;
            this.dgvFacturas.SelectionChanged += new System.EventHandler(this.dgvFacturas_SelectionChanged);
            // 
            // id_factura
            // 
            this.id_factura.DataPropertyName = "Factura";
            this.id_factura.HeaderText = "id_factura";
            this.id_factura.Name = "id_factura";
            this.id_factura.ReadOnly = true;
            this.id_factura.Visible = false;
            // 
            // idEstado
            // 
            this.idEstado.DataPropertyName = "idEstado";
            this.idEstado.HeaderText = "idEstado";
            this.idEstado.Name = "idEstado";
            this.idEstado.ReadOnly = true;
            this.idEstado.Visible = false;
            // 
            // Periodo
            // 
            this.Periodo.DataPropertyName = "Periodo";
            this.Periodo.HeaderText = "Periodo";
            this.Periodo.Name = "Periodo";
            this.Periodo.ReadOnly = true;
            // 
            // Factura
            // 
            this.Factura.DataPropertyName = "Factura";
            this.Factura.HeaderText = "Factura";
            this.Factura.Name = "Factura";
            this.Factura.ReadOnly = true;
            // 
            // FechaFact
            // 
            this.FechaFact.DataPropertyName = "FechaFact";
            this.FechaFact.HeaderText = "Fecha Fact";
            this.FechaFact.Name = "FechaFact";
            this.FechaFact.ReadOnly = true;
            // 
            // FechaVenc
            // 
            this.FechaVenc.DataPropertyName = "FechaVenc";
            this.FechaVenc.HeaderText = "Fecha Venc";
            this.FechaVenc.Name = "FechaVenc";
            this.FechaVenc.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Neto
            // 
            this.Neto.DataPropertyName = "Neto";
            this.Neto.HeaderText = "Neto";
            this.Neto.Name = "Neto";
            this.Neto.ReadOnly = true;
            // 
            // IVA
            // 
            this.IVA.DataPropertyName = "IVA";
            this.IVA.HeaderText = "IVA";
            this.IVA.Name = "IVA";
            this.IVA.ReadOnly = true;
            // 
            // Recargo
            // 
            this.Recargo.DataPropertyName = "Recargo";
            this.Recargo.HeaderText = "Recargo";
            this.Recargo.Name = "Recargo";
            this.Recargo.ReadOnly = true;
            // 
            // IVA_Rec
            // 
            this.IVA_Rec.DataPropertyName = "IVARecargo";
            this.IVA_Rec.HeaderText = "IVA Rec";
            this.IVA_Rec.Name = "IVA_Rec";
            this.IVA_Rec.ReadOnly = true;
            // 
            // Descuento
            // 
            this.Descuento.DataPropertyName = "Descuento";
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            // 
            // IVA_Desc
            // 
            this.IVA_Desc.DataPropertyName = "IVADescuento";
            this.IVA_Desc.HeaderText = "IVA Desc";
            this.IVA_Desc.Name = "IVA_Desc";
            this.IVA_Desc.ReadOnly = true;
            // 
            // Cobrado
            // 
            this.Cobrado.DataPropertyName = "Cobrado";
            this.Cobrado.HeaderText = "Cobrado";
            this.Cobrado.Name = "Cobrado";
            this.Cobrado.ReadOnly = true;
            // 
            // Cons_M3
            // 
            this.Cons_M3.DataPropertyName = "Consumo";
            this.Cons_M3.HeaderText = "Cons M3";
            this.Cons_M3.Name = "Cons_M3";
            this.Cons_M3.ReadOnly = true;
            // 
            // Lectura
            // 
            this.Lectura.DataPropertyName = "Lectura";
            this.Lectura.HeaderText = "Lectura";
            this.Lectura.Name = "Lectura";
            this.Lectura.ReadOnly = true;
            // 
            // Lect_Ant
            // 
            this.Lect_Ant.DataPropertyName = "LecturaAnt";
            this.Lect_Ant.HeaderText = "Lect Ant";
            this.Lect_Ant.Name = "Lect_Ant";
            this.Lect_Ant.ReadOnly = true;
            // 
            // DiasVenc
            // 
            this.DiasVenc.DataPropertyName = "DiasVenc";
            this.DiasVenc.HeaderText = "Dias Venc.";
            this.DiasVenc.Name = "DiasVenc";
            this.DiasVenc.ReadOnly = true;
            this.DiasVenc.Visible = false;
            // 
            // frmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 459);
            this.Controls.Add(this.dgvFacturas);
            this.Controls.Add(this.btnDetalleConceptos);
            this.Controls.Add(this.dgvConceptos);
            this.Controls.Add(this.gbTotales);
            this.Controls.Add(this.gbAcciones);
            this.Controls.Add(this.gbSocio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFacturas";
            this.Text = "Detalle de facturacion al cliente";
            this.Load += new System.EventHandler(this.frmFacturas_Load);
            this.gbSocio.ResumeLayout(false);
            this.gbSocio.PerformLayout();
            this.gbAcciones.ResumeLayout(false);
            this.gbAcciones.PerformLayout();
            this.gbTotales.ResumeLayout(false);
            this.gbTotales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConceptos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSocio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtSubCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox gbAcciones;
        private System.Windows.Forms.Button btnGenerarInforme;
        private System.Windows.Forms.CheckBox chkInformacionAdic;
        private System.Windows.Forms.CheckBox chkValoresAct;
        private System.Windows.Forms.CheckBox chkMostrarImpagas;
        private System.Windows.Forms.GroupBox gbTotales;
        private System.Windows.Forms.TextBox txtRecargo;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtFactListadas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvConceptos;
        private System.Windows.Forms.Button btnDetalleConceptos;
        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVenc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Neto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVA_Rec;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVA_Desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cobrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cons_M3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lectura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lect_Ant;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiasVenc;
    }
}