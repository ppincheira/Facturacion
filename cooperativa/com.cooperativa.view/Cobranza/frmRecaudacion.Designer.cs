namespace com.cooperativa.view.Cobranza
{
    partial class frmRecaudacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecaudacion));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCaja = new System.Windows.Forms.ComboBox();
            this.rbtnCaja = new System.Windows.Forms.RadioButton();
            this.rbtnPorCaja = new System.Windows.Forms.RadioButton();
            this.rbtnTotasCajas = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.gbOrdenar = new System.Windows.Forms.GroupBox();
            this.rbtnFactura = new System.Windows.Forms.RadioButton();
            this.rbtnSocio = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtnPorAdmin = new System.Windows.Forms.RadioButton();
            this.rbtnTodasCobranzas = new System.Windows.Forms.RadioButton();
            this.btnGenerarListado = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbOrdenar.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCaja);
            this.groupBox1.Controls.Add(this.rbtnCaja);
            this.groupBox1.Controls.Add(this.rbtnPorCaja);
            this.groupBox1.Controls.Add(this.rbtnTotasCajas);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Listados";
            // 
            // cmbCaja
            // 
            this.cmbCaja.FormattingEnabled = true;
            this.cmbCaja.Location = new System.Drawing.Point(141, 78);
            this.cmbCaja.Name = "cmbCaja";
            this.cmbCaja.Size = new System.Drawing.Size(83, 21);
            this.cmbCaja.TabIndex = 3;
            // 
            // rbtnCaja
            // 
            this.rbtnCaja.AutoSize = true;
            this.rbtnCaja.Location = new System.Drawing.Point(17, 78);
            this.rbtnCaja.Name = "rbtnCaja";
            this.rbtnCaja.Size = new System.Drawing.Size(118, 17);
            this.rbtnCaja.TabIndex = 2;
            this.rbtnCaja.Text = "Listado de una caja";
            this.rbtnCaja.UseVisualStyleBackColor = true;
            this.rbtnCaja.CheckedChanged += new System.EventHandler(this.rbtnCaja_CheckedChanged);
            // 
            // rbtnPorCaja
            // 
            this.rbtnPorCaja.AutoSize = true;
            this.rbtnPorCaja.Checked = true;
            this.rbtnPorCaja.Location = new System.Drawing.Point(17, 55);
            this.rbtnPorCaja.Name = "rbtnPorCaja";
            this.rbtnPorCaja.Size = new System.Drawing.Size(207, 17);
            this.rbtnPorCaja.TabIndex = 1;
            this.rbtnPorCaja.TabStop = true;
            this.rbtnPorCaja.Text = "Listado completo discriminado por caja";
            this.rbtnPorCaja.UseVisualStyleBackColor = true;
            this.rbtnPorCaja.CheckedChanged += new System.EventHandler(this.rbtnPorCaja_CheckedChanged);
            // 
            // rbtnTotasCajas
            // 
            this.rbtnTotasCajas.AutoSize = true;
            this.rbtnTotasCajas.Location = new System.Drawing.Point(17, 32);
            this.rbtnTotasCajas.Name = "rbtnTotasCajas";
            this.rbtnTotasCajas.Size = new System.Drawing.Size(193, 17);
            this.rbtnTotasCajas.TabIndex = 0;
            this.rbtnTotasCajas.Text = "Listado completo de todas las cajas";
            this.rbtnTotasCajas.UseVisualStyleBackColor = true;
            this.rbtnTotasCajas.CheckedChanged += new System.EventHandler(this.rbtnTotasCajas_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpFecha);
            this.groupBox2.Location = new System.Drawing.Point(257, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 72);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Emitir listado del día";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(17, 28);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(108, 20);
            this.dtpFecha.TabIndex = 0;
            this.dtpFecha.Value = new System.DateTime(2015, 5, 8, 18, 41, 31, 0);
            // 
            // gbOrdenar
            // 
            this.gbOrdenar.Controls.Add(this.rbtnFactura);
            this.gbOrdenar.Controls.Add(this.rbtnSocio);
            this.gbOrdenar.Location = new System.Drawing.Point(257, 147);
            this.gbOrdenar.Name = "gbOrdenar";
            this.gbOrdenar.Size = new System.Drawing.Size(145, 99);
            this.gbOrdenar.TabIndex = 2;
            this.gbOrdenar.TabStop = false;
            this.gbOrdenar.Text = "Ordenar por";
            // 
            // rbtnFactura
            // 
            this.rbtnFactura.AutoSize = true;
            this.rbtnFactura.Location = new System.Drawing.Point(17, 42);
            this.rbtnFactura.Name = "rbtnFactura";
            this.rbtnFactura.Size = new System.Drawing.Size(61, 17);
            this.rbtnFactura.TabIndex = 1;
            this.rbtnFactura.Text = "Factura";
            this.rbtnFactura.UseVisualStyleBackColor = true;
            // 
            // rbtnSocio
            // 
            this.rbtnSocio.AutoSize = true;
            this.rbtnSocio.Checked = true;
            this.rbtnSocio.Location = new System.Drawing.Point(17, 19);
            this.rbtnSocio.Name = "rbtnSocio";
            this.rbtnSocio.Size = new System.Drawing.Size(52, 17);
            this.rbtnSocio.TabIndex = 0;
            this.rbtnSocio.TabStop = true;
            this.rbtnSocio.Text = "Socio";
            this.rbtnSocio.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtnPorAdmin);
            this.groupBox3.Controls.Add(this.rbtnTodasCobranzas);
            this.groupBox3.Location = new System.Drawing.Point(12, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(239, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Emitir listado de control de..";
            // 
            // rbtnPorAdmin
            // 
            this.rbtnPorAdmin.AutoSize = true;
            this.rbtnPorAdmin.Location = new System.Drawing.Point(20, 68);
            this.rbtnPorAdmin.Name = "rbtnPorAdmin";
            this.rbtnPorAdmin.Size = new System.Drawing.Size(128, 17);
            this.rbtnPorAdmin.TabIndex = 5;
            this.rbtnPorAdmin.Text = "Lo cobrado por admin";
            this.rbtnPorAdmin.UseVisualStyleBackColor = true;
            // 
            // rbtnTodasCobranzas
            // 
            this.rbtnTodasCobranzas.AutoSize = true;
            this.rbtnTodasCobranzas.Checked = true;
            this.rbtnTodasCobranzas.Location = new System.Drawing.Point(20, 31);
            this.rbtnTodasCobranzas.Name = "rbtnTodasCobranzas";
            this.rbtnTodasCobranzas.Size = new System.Drawing.Size(123, 17);
            this.rbtnTodasCobranzas.TabIndex = 4;
            this.rbtnTodasCobranzas.TabStop = true;
            this.rbtnTodasCobranzas.Text = "Todas las cobranzas";
            this.rbtnTodasCobranzas.UseVisualStyleBackColor = true;
            // 
            // btnGenerarListado
            // 
            this.btnGenerarListado.Location = new System.Drawing.Point(13, 254);
            this.btnGenerarListado.Name = "btnGenerarListado";
            this.btnGenerarListado.Size = new System.Drawing.Size(142, 35);
            this.btnGenerarListado.TabIndex = 4;
            this.btnGenerarListado.Text = "Generar Listado";
            this.btnGenerarListado.UseVisualStyleBackColor = true;
            this.btnGenerarListado.Click += new System.EventHandler(this.btnGenerarListado_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(324, 253);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(78, 36);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmRecaudacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 307);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGenerarListado);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbOrdenar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRecaudacion";
            this.Text = "Planilla para el control de recaudación";
            this.Load += new System.EventHandler(this.frmRecaudacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.gbOrdenar.ResumeLayout(false);
            this.gbOrdenar.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCaja;
        private System.Windows.Forms.RadioButton rbtnCaja;
        private System.Windows.Forms.RadioButton rbtnPorCaja;
        private System.Windows.Forms.RadioButton rbtnTotasCajas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbOrdenar;
        private System.Windows.Forms.RadioButton rbtnFactura;
        private System.Windows.Forms.RadioButton rbtnSocio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtnPorAdmin;
        private System.Windows.Forms.RadioButton rbtnTodasCobranzas;
        private System.Windows.Forms.Button btnGenerarListado;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}