namespace com.cooperativa.view.Cobranza
{
    partial class frmCobranza
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNroFactura = new System.Windows.Forms.TextBox();
            this.cmbCaja = new System.Windows.Forms.ComboBox();
            this.dtpFechaCaja = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFactIngresadas = new System.Windows.Forms.TextBox();
            this.gbDatosFacturas = new System.Windows.Forms.GroupBox();
            this.btnSolicitarAutorizacion = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtRecargo = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtAcciones = new System.Windows.Forms.TextBox();
            this.txtConvenio = new System.Windows.Forms.TextBox();
            this.txtResto = new System.Windows.Forms.TextBox();
            this.txtCobrado = new System.Windows.Forms.TextBox();
            this.txtFacturado = new System.Windows.Forms.TextBox();
            this.txtVencimiento = new System.Windows.Forms.TextBox();
            this.txtNombreSocio = new System.Windows.Forms.TextBox();
            this.txtCodigoSubCodSocio = new System.Windows.Forms.TextBox();
            this.gbResumen = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDiferencia = new System.Windows.Forms.TextBox();
            this.txtTotalFactura = new System.Windows.Forms.TextBox();
            this.txtTotalCobrado = new System.Windows.Forms.TextBox();
            this.txtNombreCaja = new System.Windows.Forms.TextBox();
            this.lblFechaCobro = new System.Windows.Forms.Label();
            this.dtpFechaCobro = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.gbDatosFacturas.SuspendLayout();
            this.gbResumen.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Factura";
            // 
            // txtNroFactura
            // 
            this.txtNroFactura.Location = new System.Drawing.Point(77, 21);
            this.txtNroFactura.Name = "txtNroFactura";
            this.txtNroFactura.Size = new System.Drawing.Size(100, 20);
            this.txtNroFactura.TabIndex = 1;
            this.txtNroFactura.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNroFactura_KeyDown);
            this.txtNroFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroFactura_KeyPress);
            // 
            // cmbCaja
            // 
            this.cmbCaja.FormattingEnabled = true;
            this.cmbCaja.Location = new System.Drawing.Point(77, 61);
            this.cmbCaja.Name = "cmbCaja";
            this.cmbCaja.Size = new System.Drawing.Size(50, 21);
            this.cmbCaja.TabIndex = 2;
            this.cmbCaja.SelectedIndexChanged += new System.EventHandler(this.cmbCaja_SelectedIndexChanged);
            this.cmbCaja.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCaja_KeyDown);
            // 
            // dtpFechaCaja
            // 
            this.dtpFechaCaja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCaja.Location = new System.Drawing.Point(499, 21);
            this.dtpFechaCaja.Name = "dtpFechaCaja";
            this.dtpFechaCaja.Size = new System.Drawing.Size(102, 20);
            this.dtpFechaCaja.TabIndex = 3;
            this.dtpFechaCaja.ValueChanged += new System.EventHandler(this.dtpFechaCaja_ValueChanged);
            this.dtpFechaCaja.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpFechaCaja_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha Caja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Caja";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFactIngresadas);
            this.groupBox1.Location = new System.Drawing.Point(637, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 70);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fact. Ingresadas";
            // 
            // txtFactIngresadas
            // 
            this.txtFactIngresadas.Enabled = false;
            this.txtFactIngresadas.Location = new System.Drawing.Point(43, 28);
            this.txtFactIngresadas.Name = "txtFactIngresadas";
            this.txtFactIngresadas.ReadOnly = true;
            this.txtFactIngresadas.Size = new System.Drawing.Size(67, 20);
            this.txtFactIngresadas.TabIndex = 0;
            // 
            // gbDatosFacturas
            // 
            this.gbDatosFacturas.Controls.Add(this.btnSolicitarAutorizacion);
            this.gbDatosFacturas.Controls.Add(this.label13);
            this.gbDatosFacturas.Controls.Add(this.label12);
            this.gbDatosFacturas.Controls.Add(this.label11);
            this.gbDatosFacturas.Controls.Add(this.label10);
            this.gbDatosFacturas.Controls.Add(this.label9);
            this.gbDatosFacturas.Controls.Add(this.label8);
            this.gbDatosFacturas.Controls.Add(this.label7);
            this.gbDatosFacturas.Controls.Add(this.label6);
            this.gbDatosFacturas.Controls.Add(this.label5);
            this.gbDatosFacturas.Controls.Add(this.label4);
            this.gbDatosFacturas.Controls.Add(this.txtTotal);
            this.gbDatosFacturas.Controls.Add(this.txtRecargo);
            this.gbDatosFacturas.Controls.Add(this.txtDescuento);
            this.gbDatosFacturas.Controls.Add(this.txtAcciones);
            this.gbDatosFacturas.Controls.Add(this.txtConvenio);
            this.gbDatosFacturas.Controls.Add(this.txtResto);
            this.gbDatosFacturas.Controls.Add(this.txtCobrado);
            this.gbDatosFacturas.Controls.Add(this.txtFacturado);
            this.gbDatosFacturas.Controls.Add(this.txtVencimiento);
            this.gbDatosFacturas.Controls.Add(this.txtNombreSocio);
            this.gbDatosFacturas.Controls.Add(this.txtCodigoSubCodSocio);
            this.gbDatosFacturas.Location = new System.Drawing.Point(31, 104);
            this.gbDatosFacturas.Name = "gbDatosFacturas";
            this.gbDatosFacturas.Size = new System.Drawing.Size(758, 196);
            this.gbDatosFacturas.TabIndex = 7;
            this.gbDatosFacturas.TabStop = false;
            this.gbDatosFacturas.Text = "Datos Facturas";
            // 
            // btnSolicitarAutorizacion
            // 
            this.btnSolicitarAutorizacion.Location = new System.Drawing.Point(606, 115);
            this.btnSolicitarAutorizacion.Name = "btnSolicitarAutorizacion";
            this.btnSolicitarAutorizacion.Size = new System.Drawing.Size(128, 63);
            this.btnSolicitarAutorizacion.TabIndex = 28;
            this.btnSolicitarAutorizacion.Text = "Solicitar autorización para cobro sin interés";
            this.btnSolicitarAutorizacion.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(429, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 16);
            this.label13.TabIndex = 27;
            this.label13.Text = "Total";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(425, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Recargo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(414, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Descuento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(230, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Acciones";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(230, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Convenio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Resto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Cobrado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Facturado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(563, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Vencimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Socio";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(484, 158);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 18;
            // 
            // txtRecargo
            // 
            this.txtRecargo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtRecargo.Enabled = false;
            this.txtRecargo.Location = new System.Drawing.Point(484, 123);
            this.txtRecargo.Name = "txtRecargo";
            this.txtRecargo.ReadOnly = true;
            this.txtRecargo.Size = new System.Drawing.Size(100, 20);
            this.txtRecargo.TabIndex = 17;
            // 
            // txtDescuento
            // 
            this.txtDescuento.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtDescuento.Enabled = false;
            this.txtDescuento.Location = new System.Drawing.Point(484, 83);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.ReadOnly = true;
            this.txtDescuento.Size = new System.Drawing.Size(100, 20);
            this.txtDescuento.TabIndex = 16;
            // 
            // txtAcciones
            // 
            this.txtAcciones.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtAcciones.Enabled = false;
            this.txtAcciones.Location = new System.Drawing.Point(290, 123);
            this.txtAcciones.Name = "txtAcciones";
            this.txtAcciones.ReadOnly = true;
            this.txtAcciones.Size = new System.Drawing.Size(100, 20);
            this.txtAcciones.TabIndex = 15;
            // 
            // txtConvenio
            // 
            this.txtConvenio.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtConvenio.Enabled = false;
            this.txtConvenio.Location = new System.Drawing.Point(290, 83);
            this.txtConvenio.Name = "txtConvenio";
            this.txtConvenio.ReadOnly = true;
            this.txtConvenio.Size = new System.Drawing.Size(100, 20);
            this.txtConvenio.TabIndex = 14;
            // 
            // txtResto
            // 
            this.txtResto.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtResto.Enabled = false;
            this.txtResto.Location = new System.Drawing.Point(97, 158);
            this.txtResto.Name = "txtResto";
            this.txtResto.ReadOnly = true;
            this.txtResto.Size = new System.Drawing.Size(100, 20);
            this.txtResto.TabIndex = 13;
            // 
            // txtCobrado
            // 
            this.txtCobrado.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtCobrado.Enabled = false;
            this.txtCobrado.Location = new System.Drawing.Point(97, 123);
            this.txtCobrado.Name = "txtCobrado";
            this.txtCobrado.ReadOnly = true;
            this.txtCobrado.Size = new System.Drawing.Size(100, 20);
            this.txtCobrado.TabIndex = 12;
            // 
            // txtFacturado
            // 
            this.txtFacturado.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtFacturado.Enabled = false;
            this.txtFacturado.Location = new System.Drawing.Point(97, 86);
            this.txtFacturado.Name = "txtFacturado";
            this.txtFacturado.ReadOnly = true;
            this.txtFacturado.Size = new System.Drawing.Size(100, 20);
            this.txtFacturado.TabIndex = 11;
            // 
            // txtVencimiento
            // 
            this.txtVencimiento.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtVencimiento.Enabled = false;
            this.txtVencimiento.Location = new System.Drawing.Point(634, 35);
            this.txtVencimiento.Name = "txtVencimiento";
            this.txtVencimiento.ReadOnly = true;
            this.txtVencimiento.Size = new System.Drawing.Size(100, 20);
            this.txtVencimiento.TabIndex = 10;
            // 
            // txtNombreSocio
            // 
            this.txtNombreSocio.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtNombreSocio.Enabled = false;
            this.txtNombreSocio.Location = new System.Drawing.Point(165, 34);
            this.txtNombreSocio.Name = "txtNombreSocio";
            this.txtNombreSocio.ReadOnly = true;
            this.txtNombreSocio.Size = new System.Drawing.Size(278, 20);
            this.txtNombreSocio.TabIndex = 9;
            // 
            // txtCodigoSubCodSocio
            // 
            this.txtCodigoSubCodSocio.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtCodigoSubCodSocio.Enabled = false;
            this.txtCodigoSubCodSocio.Location = new System.Drawing.Point(59, 35);
            this.txtCodigoSubCodSocio.Name = "txtCodigoSubCodSocio";
            this.txtCodigoSubCodSocio.ReadOnly = true;
            this.txtCodigoSubCodSocio.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoSubCodSocio.TabIndex = 8;
            // 
            // gbResumen
            // 
            this.gbResumen.Controls.Add(this.label16);
            this.gbResumen.Controls.Add(this.label15);
            this.gbResumen.Controls.Add(this.label14);
            this.gbResumen.Controls.Add(this.txtDiferencia);
            this.gbResumen.Controls.Add(this.txtTotalFactura);
            this.gbResumen.Controls.Add(this.txtTotalCobrado);
            this.gbResumen.Location = new System.Drawing.Point(31, 318);
            this.gbResumen.Name = "gbResumen";
            this.gbResumen.Size = new System.Drawing.Size(758, 79);
            this.gbResumen.TabIndex = 8;
            this.gbResumen.TabStop = false;
            this.gbResumen.Text = "Resumen";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(532, 40);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Diferencia";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(270, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Total factura";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Total cobrado";
            // 
            // txtDiferencia
            // 
            this.txtDiferencia.Location = new System.Drawing.Point(593, 37);
            this.txtDiferencia.Name = "txtDiferencia";
            this.txtDiferencia.ReadOnly = true;
            this.txtDiferencia.Size = new System.Drawing.Size(100, 20);
            this.txtDiferencia.TabIndex = 4;
            // 
            // txtTotalFactura
            // 
            this.txtTotalFactura.Location = new System.Drawing.Point(343, 35);
            this.txtTotalFactura.Name = "txtTotalFactura";
            this.txtTotalFactura.ReadOnly = true;
            this.txtTotalFactura.Size = new System.Drawing.Size(100, 20);
            this.txtTotalFactura.TabIndex = 3;
            // 
            // txtTotalCobrado
            // 
            this.txtTotalCobrado.Location = new System.Drawing.Point(105, 35);
            this.txtTotalCobrado.Name = "txtTotalCobrado";
            this.txtTotalCobrado.ReadOnly = true;
            this.txtTotalCobrado.Size = new System.Drawing.Size(100, 20);
            this.txtTotalCobrado.TabIndex = 2;
            // 
            // txtNombreCaja
            // 
            this.txtNombreCaja.Enabled = false;
            this.txtNombreCaja.Location = new System.Drawing.Point(133, 61);
            this.txtNombreCaja.Name = "txtNombreCaja";
            this.txtNombreCaja.ReadOnly = true;
            this.txtNombreCaja.Size = new System.Drawing.Size(183, 20);
            this.txtNombreCaja.TabIndex = 28;
            // 
            // lblFechaCobro
            // 
            this.lblFechaCobro.AutoSize = true;
            this.lblFechaCobro.Location = new System.Drawing.Point(425, 64);
            this.lblFechaCobro.Name = "lblFechaCobro";
            this.lblFechaCobro.Size = new System.Drawing.Size(68, 13);
            this.lblFechaCobro.TabIndex = 30;
            this.lblFechaCobro.Text = "Fecha Cobro";
            this.lblFechaCobro.Visible = false;
            // 
            // dtpFechaCobro
            // 
            this.dtpFechaCobro.Enabled = false;
            this.dtpFechaCobro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCobro.Location = new System.Drawing.Point(499, 62);
            this.dtpFechaCobro.Name = "dtpFechaCobro";
            this.dtpFechaCobro.Size = new System.Drawing.Size(102, 20);
            this.dtpFechaCobro.TabIndex = 29;
            this.dtpFechaCobro.Visible = false;
            this.dtpFechaCobro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpFechaCobro_KeyDown);
            // 
            // frmCobranza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 419);
            this.Controls.Add(this.lblFechaCobro);
            this.Controls.Add(this.dtpFechaCobro);
            this.Controls.Add(this.txtNombreCaja);
            this.Controls.Add(this.gbResumen);
            this.Controls.Add(this.gbDatosFacturas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFechaCaja);
            this.Controls.Add(this.cmbCaja);
            this.Controls.Add(this.txtNroFactura);
            this.Controls.Add(this.label1);
            this.Name = "frmCobranza";
            this.Text = "Cobranza";
            this.Load += new System.EventHandler(this.frmCobranza_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbDatosFacturas.ResumeLayout(false);
            this.gbDatosFacturas.PerformLayout();
            this.gbResumen.ResumeLayout(false);
            this.gbResumen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNroFactura;
        private System.Windows.Forms.ComboBox cmbCaja;
        private System.Windows.Forms.DateTimePicker dtpFechaCaja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFactIngresadas;
        private System.Windows.Forms.GroupBox gbDatosFacturas;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtRecargo;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtAcciones;
        private System.Windows.Forms.TextBox txtConvenio;
        private System.Windows.Forms.TextBox txtResto;
        private System.Windows.Forms.TextBox txtCobrado;
        private System.Windows.Forms.TextBox txtFacturado;
        private System.Windows.Forms.TextBox txtVencimiento;
        private System.Windows.Forms.TextBox txtNombreSocio;
        private System.Windows.Forms.TextBox txtCodigoSubCodSocio;
        private System.Windows.Forms.GroupBox gbResumen;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDiferencia;
        private System.Windows.Forms.TextBox txtTotalFactura;
        private System.Windows.Forms.TextBox txtTotalCobrado;
        private System.Windows.Forms.TextBox txtNombreCaja;
        private System.Windows.Forms.Button btnSolicitarAutorizacion;
        private System.Windows.Forms.Label lblFechaCobro;
        private System.Windows.Forms.DateTimePicker dtpFechaCobro;
    }
}