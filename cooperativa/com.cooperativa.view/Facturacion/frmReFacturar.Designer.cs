namespace com.cooperativa.view.Facturacion
{
    partial class frmReFacturar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReFacturar));
            this.gbSocio = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxtNumero = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.pDetalles = new System.Windows.Forms.Panel();
            this.gbRefacturar = new System.Windows.Forms.GroupBox();
            this.txtTotalFut = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalAct = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgDetalleFut = new System.Windows.Forms.DataGridView();
            this.idDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idConcepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfconcepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfimporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDetalleAct = new System.Windows.Forms.DataGridView();
            this.colConcepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImporteTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFechaFut = new System.Windows.Forms.TextBox();
            this.txtFechaAct = new System.Windows.Forms.TextBox();
            this.txtNroFacturaFut = new System.Windows.Forms.TextBox();
            this.txtNroFacturaAct = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbPeriodos = new System.Windows.Forms.GroupBox();
            this.dgFacturar = new System.Windows.Forms.DataGridView();
            this.periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteNeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFacturacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbReferencias = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPagoParcial = new System.Windows.Forms.Label();
            this.lblPrescripta = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblPagada = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bgBotones = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRefacturar = new System.Windows.Forms.Button();
            this.gbSocio.SuspendLayout();
            this.pDetalles.SuspendLayout();
            this.gbRefacturar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleFut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleAct)).BeginInit();
            this.gbPeriodos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFacturar)).BeginInit();
            this.gbReferencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bgBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSocio
            // 
            this.gbSocio.Controls.Add(this.txtNombre);
            this.gbSocio.Controls.Add(this.label3);
            this.gbSocio.Controls.Add(this.label2);
            this.gbSocio.Controls.Add(this.mtxtNumero);
            this.gbSocio.Controls.Add(this.btnBuscar);
            this.gbSocio.Controls.Add(this.label1);
            this.gbSocio.Controls.Add(this.txtBusqueda);
            this.gbSocio.Location = new System.Drawing.Point(12, 12);
            this.gbSocio.Name = "gbSocio";
            this.gbSocio.Size = new System.Drawing.Size(561, 76);
            this.gbSocio.TabIndex = 0;
            this.gbSocio.TabStop = false;
            this.gbSocio.Text = "Socio";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(264, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(290, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número:";
            // 
            // mtxtNumero
            // 
            this.mtxtNumero.Location = new System.Drawing.Point(113, 45);
            this.mtxtNumero.Mask = "000000/00";
            this.mtxtNumero.Name = "mtxtNumero";
            this.mtxtNumero.Size = new System.Drawing.Size(83, 20);
            this.mtxtNumero.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(479, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Búsqueda rápida:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(113, 17);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(235, 20);
            this.txtBusqueda.TabIndex = 0;
            // 
            // pDetalles
            // 
            this.pDetalles.Controls.Add(this.gbRefacturar);
            this.pDetalles.Controls.Add(this.progressBar1);
            this.pDetalles.Controls.Add(this.btnCancelar);
            this.pDetalles.Controls.Add(this.btnAceptar);
            this.pDetalles.Location = new System.Drawing.Point(12, 12);
            this.pDetalles.Name = "pDetalles";
            this.pDetalles.Size = new System.Drawing.Size(583, 359);
            this.pDetalles.TabIndex = 3;
            this.pDetalles.Visible = false;
            // 
            // gbRefacturar
            // 
            this.gbRefacturar.Controls.Add(this.txtTotalFut);
            this.gbRefacturar.Controls.Add(this.label11);
            this.gbRefacturar.Controls.Add(this.txtTotalAct);
            this.gbRefacturar.Controls.Add(this.label9);
            this.gbRefacturar.Controls.Add(this.label8);
            this.gbRefacturar.Controls.Add(this.dgDetalleFut);
            this.gbRefacturar.Controls.Add(this.dgDetalleAct);
            this.gbRefacturar.Controls.Add(this.txtFechaFut);
            this.gbRefacturar.Controls.Add(this.txtFechaAct);
            this.gbRefacturar.Controls.Add(this.txtNroFacturaFut);
            this.gbRefacturar.Controls.Add(this.txtNroFacturaAct);
            this.gbRefacturar.Controls.Add(this.label7);
            this.gbRefacturar.Controls.Add(this.label6);
            this.gbRefacturar.Controls.Add(this.label10);
            this.gbRefacturar.Location = new System.Drawing.Point(11, 16);
            this.gbRefacturar.Name = "gbRefacturar";
            this.gbRefacturar.Size = new System.Drawing.Size(544, 304);
            this.gbRefacturar.TabIndex = 27;
            this.gbRefacturar.TabStop = false;
            this.gbRefacturar.Text = "Importes de Refacturación";
            // 
            // txtTotalFut
            // 
            this.txtTotalFut.Location = new System.Drawing.Point(434, 278);
            this.txtTotalFut.Name = "txtTotalFut";
            this.txtTotalFut.Size = new System.Drawing.Size(71, 20);
            this.txtTotalFut.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(403, 281);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "Total:";
            // 
            // txtTotalAct
            // 
            this.txtTotalAct.Location = new System.Drawing.Point(434, 138);
            this.txtTotalAct.Name = "txtTotalAct";
            this.txtTotalAct.Size = new System.Drawing.Size(71, 20);
            this.txtTotalAct.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(329, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Fecha Facturación:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Nº Factura:";
            // 
            // dgDetalleFut
            // 
            this.dgDetalleFut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetalleFut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDetalle,
            this.idConcepto,
            this.idFactura,
            this.idOrden,
            this.idTipo,
            this.colfconcepto,
            this.colfimporte});
            this.dgDetalleFut.Location = new System.Drawing.Point(52, 190);
            this.dgDetalleFut.Name = "dgDetalleFut";
            this.dgDetalleFut.Size = new System.Drawing.Size(345, 108);
            this.dgDetalleFut.TabIndex = 37;
            // 
            // idDetalle
            // 
            this.idDetalle.DataPropertyName = "id_detalle";
            this.idDetalle.HeaderText = "idDetalle";
            this.idDetalle.Name = "idDetalle";
            this.idDetalle.Visible = false;
            // 
            // idConcepto
            // 
            this.idConcepto.DataPropertyName = "id_concepto";
            this.idConcepto.HeaderText = "idConcepto";
            this.idConcepto.Name = "idConcepto";
            this.idConcepto.Visible = false;
            // 
            // idFactura
            // 
            this.idFactura.DataPropertyName = "id_factura";
            this.idFactura.HeaderText = "idFactura";
            this.idFactura.Name = "idFactura";
            this.idFactura.Visible = false;
            // 
            // idOrden
            // 
            this.idOrden.DataPropertyName = "id_orden";
            this.idOrden.HeaderText = "idOrden";
            this.idOrden.Name = "idOrden";
            this.idOrden.Visible = false;
            // 
            // idTipo
            // 
            this.idTipo.DataPropertyName = "id_tipo";
            this.idTipo.HeaderText = "idTipo";
            this.idTipo.Name = "idTipo";
            this.idTipo.Visible = false;
            // 
            // colfconcepto
            // 
            this.colfconcepto.DataPropertyName = "concepto";
            this.colfconcepto.HeaderText = "Concepto";
            this.colfconcepto.Name = "colfconcepto";
            this.colfconcepto.Width = 210;
            // 
            // colfimporte
            // 
            this.colfimporte.DataPropertyName = "importe";
            this.colfimporte.HeaderText = "Importe";
            this.colfimporte.Name = "colfimporte";
            this.colfimporte.Width = 70;
            // 
            // dgDetalleAct
            // 
            this.dgDetalleAct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetalleAct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colConcepto,
            this.colAImporte,
            this.colImporteTotal});
            this.dgDetalleAct.Location = new System.Drawing.Point(52, 49);
            this.dgDetalleAct.Name = "dgDetalleAct";
            this.dgDetalleAct.Size = new System.Drawing.Size(345, 109);
            this.dgDetalleAct.TabIndex = 36;
            // 
            // colConcepto
            // 
            this.colConcepto.DataPropertyName = "concepto";
            this.colConcepto.HeaderText = "Concepto";
            this.colConcepto.Name = "colConcepto";
            this.colConcepto.Width = 209;
            // 
            // colAImporte
            // 
            this.colAImporte.DataPropertyName = "Importe";
            this.colAImporte.HeaderText = "Importe";
            this.colAImporte.Name = "colAImporte";
            this.colAImporte.Width = 70;
            // 
            // colImporteTotal
            // 
            this.colImporteTotal.DataPropertyName = "importeTotal";
            this.colImporteTotal.HeaderText = "ImporteTotal";
            this.colImporteTotal.Name = "colImporteTotal";
            this.colImporteTotal.Visible = false;
            // 
            // txtFechaFut
            // 
            this.txtFechaFut.Location = new System.Drawing.Point(434, 164);
            this.txtFechaFut.Name = "txtFechaFut";
            this.txtFechaFut.Size = new System.Drawing.Size(81, 20);
            this.txtFechaFut.TabIndex = 35;
            // 
            // txtFechaAct
            // 
            this.txtFechaAct.Location = new System.Drawing.Point(434, 19);
            this.txtFechaAct.Name = "txtFechaAct";
            this.txtFechaAct.Size = new System.Drawing.Size(81, 20);
            this.txtFechaAct.TabIndex = 34;
            // 
            // txtNroFacturaFut
            // 
            this.txtNroFacturaFut.Location = new System.Drawing.Point(116, 164);
            this.txtNroFacturaFut.Name = "txtNroFacturaFut";
            this.txtNroFacturaFut.Size = new System.Drawing.Size(81, 20);
            this.txtNroFacturaFut.TabIndex = 33;
            // 
            // txtNroFacturaAct
            // 
            this.txtNroFacturaAct.Location = new System.Drawing.Point(114, 18);
            this.txtNroFacturaAct.Name = "txtNroFacturaAct";
            this.txtNroFacturaAct.Size = new System.Drawing.Size(81, 20);
            this.txtNroFacturaAct.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Fecha Facturación:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Nº Factura:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(403, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Total:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(63, 326);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(315, 23);
            this.progressBar1.TabIndex = 28;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(486, 326);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(384, 326);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 25;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // gbPeriodos
            // 
            this.gbPeriodos.Controls.Add(this.dgFacturar);
            this.gbPeriodos.Location = new System.Drawing.Point(12, 88);
            this.gbPeriodos.Name = "gbPeriodos";
            this.gbPeriodos.Size = new System.Drawing.Size(561, 175);
            this.gbPeriodos.TabIndex = 1;
            this.gbPeriodos.TabStop = false;
            this.gbPeriodos.Text = "Períodos";
            // 
            // dgFacturar
            // 
            this.dgFacturar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFacturar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.periodo,
            this.Factura,
            this.ImporteTotal,
            this.ImporteNeto,
            this.IVA,
            this.FechaFacturacion,
            this.consumo});
            this.dgFacturar.Location = new System.Drawing.Point(6, 19);
            this.dgFacturar.Name = "dgFacturar";
            this.dgFacturar.Size = new System.Drawing.Size(549, 150);
            this.dgFacturar.TabIndex = 0;
            this.dgFacturar.SelectionChanged += new System.EventHandler(this.dgFacturar_SelectionChanged);
            // 
            // periodo
            // 
            this.periodo.DataPropertyName = "id_periodo";
            this.periodo.HeaderText = "Periodo";
            this.periodo.Name = "periodo";
            // 
            // Factura
            // 
            this.Factura.DataPropertyName = "id_factura";
            this.Factura.HeaderText = "Factura";
            this.Factura.Name = "Factura";
            // 
            // ImporteTotal
            // 
            this.ImporteTotal.DataPropertyName = "importeTotal";
            this.ImporteTotal.HeaderText = "ImporteTotal";
            this.ImporteTotal.Name = "ImporteTotal";
            // 
            // ImporteNeto
            // 
            this.ImporteNeto.DataPropertyName = "importeNeto";
            this.ImporteNeto.HeaderText = "ImporteNeto";
            this.ImporteNeto.Name = "ImporteNeto";
            // 
            // IVA
            // 
            this.IVA.DataPropertyName = "iva";
            this.IVA.HeaderText = "IVA";
            this.IVA.Name = "IVA";
            // 
            // FechaFacturacion
            // 
            this.FechaFacturacion.DataPropertyName = "FechaFacturacion";
            this.FechaFacturacion.HeaderText = "Fecha Facturación";
            this.FechaFacturacion.Name = "FechaFacturacion";
            // 
            // consumo
            // 
            this.consumo.DataPropertyName = "consumo";
            this.consumo.HeaderText = "Consumo";
            this.consumo.Name = "consumo";
            // 
            // gbReferencias
            // 
            this.gbReferencias.Controls.Add(this.label5);
            this.gbReferencias.Controls.Add(this.label4);
            this.gbReferencias.Controls.Add(this.lblPagoParcial);
            this.gbReferencias.Controls.Add(this.lblPrescripta);
            this.gbReferencias.Controls.Add(this.pictureBox3);
            this.gbReferencias.Controls.Add(this.lblPagada);
            this.gbReferencias.Controls.Add(this.pictureBox2);
            this.gbReferencias.Controls.Add(this.pictureBox4);
            this.gbReferencias.Controls.Add(this.pictureBox6);
            this.gbReferencias.Controls.Add(this.pictureBox1);
            this.gbReferencias.Location = new System.Drawing.Point(17, 277);
            this.gbReferencias.Name = "gbReferencias";
            this.gbReferencias.Size = new System.Drawing.Size(315, 70);
            this.gbReferencias.TabIndex = 1;
            this.gbReferencias.TabStop = false;
            this.gbReferencias.Text = "Referencias";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Impaga refacturable";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(21, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Impaga no refacturable";
            // 
            // lblPagoParcial
            // 
            this.lblPagoParcial.AutoSize = true;
            this.lblPagoParcial.BackColor = System.Drawing.Color.Yellow;
            this.lblPagoParcial.ForeColor = System.Drawing.Color.Black;
            this.lblPagoParcial.Location = new System.Drawing.Point(21, 19);
            this.lblPagoParcial.Name = "lblPagoParcial";
            this.lblPagoParcial.Size = new System.Drawing.Size(67, 13);
            this.lblPagoParcial.TabIndex = 0;
            this.lblPagoParcial.Text = "Pago Parcial";
            // 
            // lblPrescripta
            // 
            this.lblPrescripta.AutoSize = true;
            this.lblPrescripta.BackColor = System.Drawing.Color.LightPink;
            this.lblPrescripta.Location = new System.Drawing.Point(223, 19);
            this.lblPrescripta.Name = "lblPrescripta";
            this.lblPrescripta.Size = new System.Drawing.Size(54, 13);
            this.lblPrescripta.TabIndex = 2;
            this.lblPrescripta.Text = "Prescripta";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.LightPink;
            this.pictureBox3.Location = new System.Drawing.Point(203, 16);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 20);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // lblPagada
            // 
            this.lblPagada.AutoSize = true;
            this.lblPagada.BackColor = System.Drawing.Color.LightGreen;
            this.lblPagada.Location = new System.Drawing.Point(131, 19);
            this.lblPagada.Name = "lblPagada";
            this.lblPagada.Size = new System.Drawing.Size(50, 13);
            this.lblPagada.TabIndex = 1;
            this.lblPagada.Text = "Pagada  ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightGreen;
            this.pictureBox2.Location = new System.Drawing.Point(105, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 20);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(154, 35);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(149, 20);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox6.Location = new System.Drawing.Point(6, 35);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(150, 20);
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox1.Location = new System.Drawing.Point(6, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 20);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // bgBotones
            // 
            this.bgBotones.Controls.Add(this.btnSalir);
            this.bgBotones.Controls.Add(this.btnRefacturar);
            this.bgBotones.Location = new System.Drawing.Point(338, 277);
            this.bgBotones.Name = "bgBotones";
            this.bgBotones.Size = new System.Drawing.Size(235, 70);
            this.bgBotones.TabIndex = 2;
            this.bgBotones.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(119, 19);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(103, 38);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRefacturar
            // 
            this.btnRefacturar.Location = new System.Drawing.Point(10, 19);
            this.btnRefacturar.Name = "btnRefacturar";
            this.btnRefacturar.Size = new System.Drawing.Size(103, 38);
            this.btnRefacturar.TabIndex = 0;
            this.btnRefacturar.Text = "Refacturar";
            this.btnRefacturar.UseVisualStyleBackColor = true;
            this.btnRefacturar.Click += new System.EventHandler(this.btnRefacturar_Click);
            // 
            // frmReFacturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 374);
            this.Controls.Add(this.pDetalles);
            this.Controls.Add(this.bgBotones);
            this.Controls.Add(this.gbSocio);
            this.Controls.Add(this.gbPeriodos);
            this.Controls.Add(this.gbReferencias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReFacturar";
            this.Text = "Re-Facturar";
            this.Load += new System.EventHandler(this.frmReFacturar_Load);
            this.gbSocio.ResumeLayout(false);
            this.gbSocio.PerformLayout();
            this.pDetalles.ResumeLayout(false);
            this.gbRefacturar.ResumeLayout(false);
            this.gbRefacturar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleFut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalleAct)).EndInit();
            this.gbPeriodos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgFacturar)).EndInit();
            this.gbReferencias.ResumeLayout(false);
            this.gbReferencias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bgBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSocio;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.MaskedTextBox mtxtNumero;
        private System.Windows.Forms.GroupBox gbPeriodos;
        private System.Windows.Forms.DataGridView dgFacturar;
        private System.Windows.Forms.GroupBox gbReferencias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPagoParcial;
        private System.Windows.Forms.Label lblPrescripta;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblPagada;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox bgBotones;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRefacturar;
        private System.Windows.Forms.Panel pDetalles;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteNeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFacturacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumo;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox gbRefacturar;
        private System.Windows.Forms.TextBox txtFechaFut;
        private System.Windows.Forms.TextBox txtFechaAct;
        private System.Windows.Forms.TextBox txtNroFacturaFut;
        private System.Windows.Forms.TextBox txtNroFacturaAct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgDetalleFut;
        private System.Windows.Forms.DataGridView dgDetalleAct;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalFut;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotalAct;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConcepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAImporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImporteTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn idConcepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfconcepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfimporte;
    }
}