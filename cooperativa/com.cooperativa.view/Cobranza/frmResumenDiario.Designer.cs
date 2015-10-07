namespace com.cooperativa.view.Cobranza
{
    partial class frmResumenDiario
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbAnio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.rbtnMes = new System.Windows.Forms.RadioButton();
            this.dtpFechaDos = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaUno = new System.Windows.Forms.DateTimePicker();
            this.rbtDiaUno = new System.Windows.Forms.RadioButton();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.rbtnDia = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnCajasJuntas = new System.Windows.Forms.RadioButton();
            this.rbtnCajasSeparado = new System.Windows.Forms.RadioButton();
            this.gbEmitir = new System.Windows.Forms.GroupBox();
            this.chkIncluirDetalle = new System.Windows.Forms.CheckBox();
            this.rbtCobradoAdmin = new System.Windows.Forms.RadioButton();
            this.rbtnTodasCobranzas = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnResumenCanon = new System.Windows.Forms.Button();
            this.btnGenerarResumen = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbEmitir.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbAnio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbMes);
            this.groupBox1.Controls.Add(this.rbtnMes);
            this.groupBox1.Controls.Add(this.dtpFechaDos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpFechaUno);
            this.groupBox1.Controls.Add(this.rbtDiaUno);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.rbtnDia);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emitir resumen...";
            // 
            // cmbAnio
            // 
            this.cmbAnio.FormattingEnabled = true;
            this.cmbAnio.Location = new System.Drawing.Point(248, 66);
            this.cmbAnio.Name = "cmbAnio";
            this.cmbAnio.Size = new System.Drawing.Size(101, 21);
            this.cmbAnio.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "del año";
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(85, 66);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(109, 21);
            this.cmbMes.TabIndex = 7;
            // 
            // rbtnMes
            // 
            this.rbtnMes.AutoSize = true;
            this.rbtnMes.Location = new System.Drawing.Point(21, 66);
            this.rbtnMes.Name = "rbtnMes";
            this.rbtnMes.Size = new System.Drawing.Size(61, 17);
            this.rbtnMes.TabIndex = 6;
            this.rbtnMes.Text = "del mes";
            this.rbtnMes.UseVisualStyleBackColor = true;
            this.rbtnMes.CheckedChanged += new System.EventHandler(this.rbtnMes_CheckedChanged);
            // 
            // dtpFechaDos
            // 
            this.dtpFechaDos.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDos.Location = new System.Drawing.Point(248, 43);
            this.dtpFechaDos.Name = "dtpFechaDos";
            this.dtpFechaDos.Size = new System.Drawing.Size(101, 20);
            this.dtpFechaDos.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "al día";
            // 
            // dtpFechaUno
            // 
            this.dtpFechaUno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaUno.Location = new System.Drawing.Point(85, 43);
            this.dtpFechaUno.Name = "dtpFechaUno";
            this.dtpFechaUno.Size = new System.Drawing.Size(109, 20);
            this.dtpFechaUno.TabIndex = 3;
            // 
            // rbtDiaUno
            // 
            this.rbtDiaUno.AutoSize = true;
            this.rbtDiaUno.Location = new System.Drawing.Point(21, 43);
            this.rbtDiaUno.Name = "rbtDiaUno";
            this.rbtDiaUno.Size = new System.Drawing.Size(58, 17);
            this.rbtDiaUno.TabIndex = 2;
            this.rbtDiaUno.Text = "del día";
            this.rbtDiaUno.UseVisualStyleBackColor = true;
            this.rbtDiaUno.CheckedChanged += new System.EventHandler(this.rbtDiaUno_CheckedChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(85, 17);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(109, 20);
            this.dtpFecha.TabIndex = 1;
            // 
            // rbtnDia
            // 
            this.rbtnDia.AutoSize = true;
            this.rbtnDia.Checked = true;
            this.rbtnDia.Location = new System.Drawing.Point(21, 20);
            this.rbtnDia.Name = "rbtnDia";
            this.rbtnDia.Size = new System.Drawing.Size(58, 17);
            this.rbtnDia.TabIndex = 0;
            this.rbtnDia.TabStop = true;
            this.rbtnDia.Text = "del día";
            this.rbtnDia.UseVisualStyleBackColor = true;
            this.rbtnDia.CheckedChanged += new System.EventHandler(this.rbtnDia_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnCajasJuntas);
            this.groupBox2.Controls.Add(this.rbtnCajasSeparado);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 61);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de resumen";
            // 
            // rbtnCajasJuntas
            // 
            this.rbtnCajasJuntas.AutoSize = true;
            this.rbtnCajasJuntas.Location = new System.Drawing.Point(246, 25);
            this.rbtnCajasJuntas.Name = "rbtnCajasJuntas";
            this.rbtnCajasJuntas.Size = new System.Drawing.Size(130, 17);
            this.rbtnCajasJuntas.TabIndex = 11;
            this.rbtnCajasJuntas.Text = "Todas las cajas juntas";
            this.rbtnCajasJuntas.UseVisualStyleBackColor = true;
            this.rbtnCajasJuntas.CheckedChanged += new System.EventHandler(this.rbtnCajasJuntas_CheckedChanged);
            // 
            // rbtnCajasSeparado
            // 
            this.rbtnCajasSeparado.AutoSize = true;
            this.rbtnCajasSeparado.Checked = true;
            this.rbtnCajasSeparado.Location = new System.Drawing.Point(21, 25);
            this.rbtnCajasSeparado.Name = "rbtnCajasSeparado";
            this.rbtnCajasSeparado.Size = new System.Drawing.Size(164, 17);
            this.rbtnCajasSeparado.TabIndex = 10;
            this.rbtnCajasSeparado.TabStop = true;
            this.rbtnCajasSeparado.Text = "Todas las cajas por separado";
            this.rbtnCajasSeparado.UseVisualStyleBackColor = true;
            this.rbtnCajasSeparado.CheckedChanged += new System.EventHandler(this.rbtnCajasSeparado_CheckedChanged);
            // 
            // gbEmitir
            // 
            this.gbEmitir.Controls.Add(this.chkIncluirDetalle);
            this.gbEmitir.Controls.Add(this.rbtCobradoAdmin);
            this.gbEmitir.Controls.Add(this.rbtnTodasCobranzas);
            this.gbEmitir.Location = new System.Drawing.Point(12, 185);
            this.gbEmitir.Name = "gbEmitir";
            this.gbEmitir.Size = new System.Drawing.Size(213, 117);
            this.gbEmitir.TabIndex = 2;
            this.gbEmitir.TabStop = false;
            this.gbEmitir.Text = "Emitir resumen de caja de...";
            // 
            // chkIncluirDetalle
            // 
            this.chkIncluirDetalle.AutoSize = true;
            this.chkIncluirDetalle.Checked = true;
            this.chkIncluirDetalle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncluirDetalle.Location = new System.Drawing.Point(21, 74);
            this.chkIncluirDetalle.Name = "chkIncluirDetalle";
            this.chkIncluirDetalle.Size = new System.Drawing.Size(186, 17);
            this.chkIncluirDetalle.TabIndex = 14;
            this.chkIncluirDetalle.Text = "Incluir detalle completo de recibos";
            this.chkIncluirDetalle.UseVisualStyleBackColor = true;
            // 
            // rbtCobradoAdmin
            // 
            this.rbtCobradoAdmin.AutoSize = true;
            this.rbtCobradoAdmin.Location = new System.Drawing.Point(21, 51);
            this.rbtCobradoAdmin.Name = "rbtCobradoAdmin";
            this.rbtCobradoAdmin.Size = new System.Drawing.Size(129, 17);
            this.rbtCobradoAdmin.TabIndex = 13;
            this.rbtCobradoAdmin.Text = "Lo cobrado por Admin";
            this.rbtCobradoAdmin.UseVisualStyleBackColor = true;
            // 
            // rbtnTodasCobranzas
            // 
            this.rbtnTodasCobranzas.AutoSize = true;
            this.rbtnTodasCobranzas.Checked = true;
            this.rbtnTodasCobranzas.Location = new System.Drawing.Point(21, 28);
            this.rbtnTodasCobranzas.Name = "rbtnTodasCobranzas";
            this.rbtnTodasCobranzas.Size = new System.Drawing.Size(123, 17);
            this.rbtnTodasCobranzas.TabIndex = 12;
            this.rbtnTodasCobranzas.TabStop = true;
            this.rbtnTodasCobranzas.Text = "Todas las cobranzas";
            this.rbtnTodasCobranzas.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSalir);
            this.groupBox4.Controls.Add(this.btnResumenCanon);
            this.groupBox4.Controls.Add(this.btnGenerarResumen);
            this.groupBox4.Location = new System.Drawing.Point(231, 185);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(172, 117);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(18, 80);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(139, 29);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnResumenCanon
            // 
            this.btnResumenCanon.Location = new System.Drawing.Point(18, 47);
            this.btnResumenCanon.Name = "btnResumenCanon";
            this.btnResumenCanon.Size = new System.Drawing.Size(139, 29);
            this.btnResumenCanon.TabIndex = 1;
            this.btnResumenCanon.Text = "Resumen Canon";
            this.btnResumenCanon.UseVisualStyleBackColor = true;
            this.btnResumenCanon.Click += new System.EventHandler(this.btnResumenCanon_Click);
            // 
            // btnGenerarResumen
            // 
            this.btnGenerarResumen.Location = new System.Drawing.Point(18, 13);
            this.btnGenerarResumen.Name = "btnGenerarResumen";
            this.btnGenerarResumen.Size = new System.Drawing.Size(139, 29);
            this.btnGenerarResumen.TabIndex = 0;
            this.btnGenerarResumen.Text = "Generar Resúmen";
            this.btnGenerarResumen.UseVisualStyleBackColor = true;
            this.btnGenerarResumen.Click += new System.EventHandler(this.btnGenerarResumen_Click);
            // 
            // frmResumenDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 314);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gbEmitir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmResumenDiario";
            this.Text = "Resumen diario de Cobranzas";
            this.Load += new System.EventHandler(this.frmResumenDiario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbEmitir.ResumeLayout(false);
            this.gbEmitir.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbAnio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.RadioButton rbtnMes;
        private System.Windows.Forms.DateTimePicker dtpFechaDos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaUno;
        private System.Windows.Forms.RadioButton rbtDiaUno;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.RadioButton rbtnDia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnCajasJuntas;
        private System.Windows.Forms.RadioButton rbtnCajasSeparado;
        private System.Windows.Forms.GroupBox gbEmitir;
        private System.Windows.Forms.CheckBox chkIncluirDetalle;
        private System.Windows.Forms.RadioButton rbtCobradoAdmin;
        private System.Windows.Forms.RadioButton rbtnTodasCobranzas;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnResumenCanon;
        private System.Windows.Forms.Button btnGenerarResumen;
    }
}