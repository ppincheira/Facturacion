namespace com.cooperativa.view
{
    partial class frmFacturasSeleccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturasSeleccion));
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.id_factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.FechaVenc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiasVenc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbSocio = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtSubCodigo = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnSeleccionarTodas = new System.Windows.Forms.Button();
            this.btnDeseleccionarTodas = new System.Windows.Forms.Button();
            this.btnInvertirSeleccion = new System.Windows.Forms.Button();
            this.lblFactursAdeudadas = new System.Windows.Forms.Label();
            this.gbFaturas = new System.Windows.Forms.GroupBox();
            this.txtSelec = new System.Windows.Forms.TextBox();
            this.txtTotalFacturas = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSelec = new System.Windows.Forms.Label();
            this.gbImportes = new System.Windows.Forms.GroupBox();
            this.txtTotalImporte = new System.Windows.Forms.TextBox();
            this.txtRecargo = new System.Windows.Forms.TextBox();
            this.txtSRecargo = new System.Windows.Forms.TextBox();
            this.lblTotalImportes = new System.Windows.Forms.Label();
            this.lblRecargo = new System.Windows.Forms.Label();
            this.lblSRecargo = new System.Windows.Forms.Label();
            this.gbRecargoDiario = new System.Windows.Forms.GroupBox();
            this.txtRecargoDiario = new System.Windows.Forms.TextBox();
            this.lblRecargoDiario = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.gbSocio.SuspendLayout();
            this.gbFaturas.SuspendLayout();
            this.gbImportes.SuspendLayout();
            this.gbRecargoDiario.SuspendLayout();
            this.SuspendLayout();
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
            this.FechaVenc,
            this.DiasVenc});
            this.dgvFacturas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvFacturas.Location = new System.Drawing.Point(12, 118);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.ReadOnly = true;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvFacturas.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacturas.Size = new System.Drawing.Size(787, 295);
            this.dgvFacturas.TabIndex = 6;
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
            this.FechaFact.Visible = false;
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
            // FechaVenc
            // 
            this.FechaVenc.DataPropertyName = "FechaVenc";
            this.FechaVenc.HeaderText = "Fecha Venc";
            this.FechaVenc.Name = "FechaVenc";
            this.FechaVenc.ReadOnly = true;
            // 
            // DiasVenc
            // 
            this.DiasVenc.DataPropertyName = "DiasVenc";
            this.DiasVenc.HeaderText = "Dias Venc.";
            this.DiasVenc.Name = "DiasVenc";
            this.DiasVenc.ReadOnly = true;
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
            this.gbSocio.TabIndex = 7;
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
            // btnSeleccionarTodas
            // 
            this.btnSeleccionarTodas.Location = new System.Drawing.Point(576, 12);
            this.btnSeleccionarTodas.Name = "btnSeleccionarTodas";
            this.btnSeleccionarTodas.Size = new System.Drawing.Size(223, 23);
            this.btnSeleccionarTodas.TabIndex = 8;
            this.btnSeleccionarTodas.Text = "Seleccionar Todas";
            this.btnSeleccionarTodas.UseVisualStyleBackColor = true;
            this.btnSeleccionarTodas.Click += new System.EventHandler(this.btnSeleccionarTodas_Click);
            // 
            // btnDeseleccionarTodas
            // 
            this.btnDeseleccionarTodas.Location = new System.Drawing.Point(576, 41);
            this.btnDeseleccionarTodas.Name = "btnDeseleccionarTodas";
            this.btnDeseleccionarTodas.Size = new System.Drawing.Size(223, 23);
            this.btnDeseleccionarTodas.TabIndex = 9;
            this.btnDeseleccionarTodas.Text = "Deseleccionar Todas";
            this.btnDeseleccionarTodas.UseVisualStyleBackColor = true;
            this.btnDeseleccionarTodas.Click += new System.EventHandler(this.btnDeseleccionarTodas_Click);
            // 
            // btnInvertirSeleccion
            // 
            this.btnInvertirSeleccion.Location = new System.Drawing.Point(576, 70);
            this.btnInvertirSeleccion.Name = "btnInvertirSeleccion";
            this.btnInvertirSeleccion.Size = new System.Drawing.Size(223, 23);
            this.btnInvertirSeleccion.TabIndex = 10;
            this.btnInvertirSeleccion.Text = "Invertir Seleccion";
            this.btnInvertirSeleccion.UseVisualStyleBackColor = true;
            this.btnInvertirSeleccion.Click += new System.EventHandler(this.btnInvertirSeleccion_Click);
            // 
            // lblFactursAdeudadas
            // 
            this.lblFactursAdeudadas.AutoSize = true;
            this.lblFactursAdeudadas.Location = new System.Drawing.Point(12, 90);
            this.lblFactursAdeudadas.Name = "lblFactursAdeudadas";
            this.lblFactursAdeudadas.Size = new System.Drawing.Size(173, 13);
            this.lblFactursAdeudadas.TabIndex = 11;
            this.lblFactursAdeudadas.Text = "Facturas Adeudadas (actualizadas)";
            // 
            // gbFaturas
            // 
            this.gbFaturas.Controls.Add(this.txtSelec);
            this.gbFaturas.Controls.Add(this.txtTotalFacturas);
            this.gbFaturas.Controls.Add(this.lblTotal);
            this.gbFaturas.Controls.Add(this.lblSelec);
            this.gbFaturas.Location = new System.Drawing.Point(10, 419);
            this.gbFaturas.Name = "gbFaturas";
            this.gbFaturas.Size = new System.Drawing.Size(175, 77);
            this.gbFaturas.TabIndex = 12;
            this.gbFaturas.TabStop = false;
            this.gbFaturas.Text = "Facturas";
            // 
            // txtSelec
            // 
            this.txtSelec.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSelec.Location = new System.Drawing.Point(93, 42);
            this.txtSelec.Name = "txtSelec";
            this.txtSelec.ReadOnly = true;
            this.txtSelec.Size = new System.Drawing.Size(58, 20);
            this.txtSelec.TabIndex = 6;
            // 
            // txtTotalFacturas
            // 
            this.txtTotalFacturas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTotalFacturas.Location = new System.Drawing.Point(15, 42);
            this.txtTotalFacturas.Name = "txtTotalFacturas";
            this.txtTotalFacturas.ReadOnly = true;
            this.txtTotalFacturas.Size = new System.Drawing.Size(58, 20);
            this.txtTotalFacturas.TabIndex = 5;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(24, 26);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total";
            // 
            // lblSelec
            // 
            this.lblSelec.AutoSize = true;
            this.lblSelec.Location = new System.Drawing.Point(107, 26);
            this.lblSelec.Name = "lblSelec";
            this.lblSelec.Size = new System.Drawing.Size(37, 13);
            this.lblSelec.TabIndex = 1;
            this.lblSelec.Text = "Selec.";
            // 
            // gbImportes
            // 
            this.gbImportes.Controls.Add(this.txtTotalImporte);
            this.gbImportes.Controls.Add(this.txtRecargo);
            this.gbImportes.Controls.Add(this.txtSRecargo);
            this.gbImportes.Controls.Add(this.lblTotalImportes);
            this.gbImportes.Controls.Add(this.lblRecargo);
            this.gbImportes.Controls.Add(this.lblSRecargo);
            this.gbImportes.Location = new System.Drawing.Point(204, 419);
            this.gbImportes.Name = "gbImportes";
            this.gbImportes.Size = new System.Drawing.Size(258, 77);
            this.gbImportes.TabIndex = 13;
            this.gbImportes.TabStop = false;
            this.gbImportes.Text = "Importes";
            // 
            // txtTotalImporte
            // 
            this.txtTotalImporte.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTotalImporte.Location = new System.Drawing.Point(185, 42);
            this.txtTotalImporte.Name = "txtTotalImporte";
            this.txtTotalImporte.ReadOnly = true;
            this.txtTotalImporte.Size = new System.Drawing.Size(58, 20);
            this.txtTotalImporte.TabIndex = 9;
            // 
            // txtRecargo
            // 
            this.txtRecargo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRecargo.Location = new System.Drawing.Point(104, 42);
            this.txtRecargo.Name = "txtRecargo";
            this.txtRecargo.ReadOnly = true;
            this.txtRecargo.Size = new System.Drawing.Size(58, 20);
            this.txtRecargo.TabIndex = 8;
            // 
            // txtSRecargo
            // 
            this.txtSRecargo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSRecargo.Location = new System.Drawing.Point(22, 42);
            this.txtSRecargo.Name = "txtSRecargo";
            this.txtSRecargo.ReadOnly = true;
            this.txtSRecargo.Size = new System.Drawing.Size(57, 20);
            this.txtSRecargo.TabIndex = 7;
            // 
            // lblTotalImportes
            // 
            this.lblTotalImportes.AutoSize = true;
            this.lblTotalImportes.Location = new System.Drawing.Point(199, 26);
            this.lblTotalImportes.Name = "lblTotalImportes";
            this.lblTotalImportes.Size = new System.Drawing.Size(31, 13);
            this.lblTotalImportes.TabIndex = 4;
            this.lblTotalImportes.Text = "Total";
            // 
            // lblRecargo
            // 
            this.lblRecargo.AutoSize = true;
            this.lblRecargo.Location = new System.Drawing.Point(114, 26);
            this.lblRecargo.Name = "lblRecargo";
            this.lblRecargo.Size = new System.Drawing.Size(48, 13);
            this.lblRecargo.TabIndex = 3;
            this.lblRecargo.Text = "Recargo";
            // 
            // lblSRecargo
            // 
            this.lblSRecargo.AutoSize = true;
            this.lblSRecargo.Location = new System.Drawing.Point(19, 26);
            this.lblSRecargo.Name = "lblSRecargo";
            this.lblSRecargo.Size = new System.Drawing.Size(60, 13);
            this.lblSRecargo.TabIndex = 2;
            this.lblSRecargo.Text = "S/Recargo";
            // 
            // gbRecargoDiario
            // 
            this.gbRecargoDiario.Controls.Add(this.txtRecargoDiario);
            this.gbRecargoDiario.Controls.Add(this.lblRecargoDiario);
            this.gbRecargoDiario.Location = new System.Drawing.Point(468, 419);
            this.gbRecargoDiario.Name = "gbRecargoDiario";
            this.gbRecargoDiario.Size = new System.Drawing.Size(93, 77);
            this.gbRecargoDiario.TabIndex = 13;
            this.gbRecargoDiario.TabStop = false;
            // 
            // txtRecargoDiario
            // 
            this.txtRecargoDiario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtRecargoDiario.Location = new System.Drawing.Point(17, 42);
            this.txtRecargoDiario.Name = "txtRecargoDiario";
            this.txtRecargoDiario.ReadOnly = true;
            this.txtRecargoDiario.Size = new System.Drawing.Size(58, 20);
            this.txtRecargoDiario.TabIndex = 10;
            // 
            // lblRecargoDiario
            // 
            this.lblRecargoDiario.AutoSize = true;
            this.lblRecargoDiario.Location = new System.Drawing.Point(11, 26);
            this.lblRecargoDiario.Name = "lblRecargoDiario";
            this.lblRecargoDiario.Size = new System.Drawing.Size(78, 13);
            this.lblRecargoDiario.TabIndex = 5;
            this.lblRecargoDiario.Text = "Recargo Diario";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(656, 457);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(143, 39);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmFacturasSeleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 511);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gbImportes);
            this.Controls.Add(this.gbRecargoDiario);
            this.Controls.Add(this.gbFaturas);
            this.Controls.Add(this.lblFactursAdeudadas);
            this.Controls.Add(this.btnInvertirSeleccion);
            this.Controls.Add(this.btnDeseleccionarTodas);
            this.Controls.Add(this.btnSeleccionarTodas);
            this.Controls.Add(this.gbSocio);
            this.Controls.Add(this.dgvFacturas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFacturasSeleccion";
            this.Text = "Facturas Seleccion";
            this.Load += new System.EventHandler(this.frmFacturasSeleccion_Load);
            this.VisibleChanged += new System.EventHandler(this.frmFacturasSeleccion_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.gbSocio.ResumeLayout(false);
            this.gbSocio.PerformLayout();
            this.gbFaturas.ResumeLayout(false);
            this.gbFaturas.PerformLayout();
            this.gbImportes.ResumeLayout(false);
            this.gbImportes.PerformLayout();
            this.gbRecargoDiario.ResumeLayout(false);
            this.gbRecargoDiario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.GroupBox gbSocio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtSubCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnSeleccionarTodas;
        private System.Windows.Forms.Button btnDeseleccionarTodas;
        private System.Windows.Forms.Button btnInvertirSeleccion;
        private System.Windows.Forms.Label lblFactursAdeudadas;
        private System.Windows.Forms.GroupBox gbFaturas;
        private System.Windows.Forms.GroupBox gbImportes;
        private System.Windows.Forms.GroupBox gbRecargoDiario;
        private System.Windows.Forms.TextBox txtSelec;
        private System.Windows.Forms.TextBox txtTotalFacturas;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSelec;
        private System.Windows.Forms.TextBox txtTotalImporte;
        private System.Windows.Forms.TextBox txtRecargo;
        private System.Windows.Forms.TextBox txtSRecargo;
        private System.Windows.Forms.Label lblTotalImportes;
        private System.Windows.Forms.Label lblRecargo;
        private System.Windows.Forms.Label lblSRecargo;
        private System.Windows.Forms.TextBox txtRecargoDiario;
        private System.Windows.Forms.Label lblRecargoDiario;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFact;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVenc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiasVenc;
    }
}