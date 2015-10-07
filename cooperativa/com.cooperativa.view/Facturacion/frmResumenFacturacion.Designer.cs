namespace com.cooperativa.view.Facturacion
{
    partial class frmResumenFacturacion
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
            this.gbPeriodos = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAnio = new System.Windows.Forms.ComboBox();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbgeneral2 = new System.Windows.Forms.GroupBox();
            this.rbGeneralConcepto = new System.Windows.Forms.RadioButton();
            this.rbGneralTarifa = new System.Windows.Forms.RadioButton();
            this.rbGeneralBarrio = new System.Windows.Forms.RadioButton();
            this.rbSubDiario = new System.Windows.Forms.RadioButton();
            this.PanelBZ = new System.Windows.Forms.GroupBox();
            this.cmbBarrios = new System.Windows.Forms.ComboBox();
            this.rbTodosBarrios = new System.Windows.Forms.RadioButton();
            this.rbEspecificarBarrio = new System.Windows.Forms.RadioButton();
            this.cmbZonas = new System.Windows.Forms.ComboBox();
            this.rbTodasZonas = new System.Windows.Forms.RadioButton();
            this.rbEspecificarZonas = new System.Windows.Forms.RadioButton();
            this.rbConceptoBZ = new System.Windows.Forms.RadioButton();
            this.rbFacturacionBZ = new System.Windows.Forms.RadioButton();
            this.gbPeriodos.SuspendLayout();
            this.gbgeneral2.SuspendLayout();
            this.PanelBZ.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPeriodos
            // 
            this.gbPeriodos.Controls.Add(this.label2);
            this.gbPeriodos.Controls.Add(this.label1);
            this.gbPeriodos.Controls.Add(this.cmbAnio);
            this.gbPeriodos.Controls.Add(this.cmbMes);
            this.gbPeriodos.Location = new System.Drawing.Point(12, 3);
            this.gbPeriodos.Name = "gbPeriodos";
            this.gbPeriodos.Size = new System.Drawing.Size(433, 74);
            this.gbPeriodos.TabIndex = 0;
            this.gbPeriodos.TabStop = false;
            this.gbPeriodos.Text = "Periodo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Año";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mes";
            // 
            // cmbAnio
            // 
            this.cmbAnio.FormattingEnabled = true;
            this.cmbAnio.Location = new System.Drawing.Point(271, 29);
            this.cmbAnio.Name = "cmbAnio";
            this.cmbAnio.Size = new System.Drawing.Size(70, 21);
            this.cmbAnio.TabIndex = 1;
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(72, 29);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(121, 21);
            this.cmbMes.TabIndex = 0;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(202, 392);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(128, 23);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar Informe";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(351, 392);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gbgeneral2
            // 
            this.gbgeneral2.Controls.Add(this.rbGeneralConcepto);
            this.gbgeneral2.Controls.Add(this.rbGneralTarifa);
            this.gbgeneral2.Controls.Add(this.rbGeneralBarrio);
            this.gbgeneral2.Controls.Add(this.rbSubDiario);
            this.gbgeneral2.Controls.Add(this.PanelBZ);
            this.gbgeneral2.Controls.Add(this.rbConceptoBZ);
            this.gbgeneral2.Controls.Add(this.rbFacturacionBZ);
            this.gbgeneral2.Location = new System.Drawing.Point(12, 85);
            this.gbgeneral2.Name = "gbgeneral2";
            this.gbgeneral2.Size = new System.Drawing.Size(433, 302);
            this.gbgeneral2.TabIndex = 12;
            this.gbgeneral2.TabStop = false;
            this.gbgeneral2.Text = "Tipo Listado";
            // 
            // rbGeneralConcepto
            // 
            this.rbGeneralConcepto.AutoSize = true;
            this.rbGeneralConcepto.Location = new System.Drawing.Point(11, 19);
            this.rbGeneralConcepto.Name = "rbGeneralConcepto";
            this.rbGeneralConcepto.Size = new System.Drawing.Size(174, 17);
            this.rbGeneralConcepto.TabIndex = 16;
            this.rbGeneralConcepto.TabStop = true;
            this.rbGeneralConcepto.Text = "Resumen general por concepto";
            this.rbGeneralConcepto.UseVisualStyleBackColor = true;
            this.rbGeneralConcepto.CheckedChanged += new System.EventHandler(this.rbGeneralConcepto_CheckedChanged);
            // 
            // rbGneralTarifa
            // 
            this.rbGneralTarifa.AutoSize = true;
            this.rbGneralTarifa.Location = new System.Drawing.Point(11, 42);
            this.rbGneralTarifa.Name = "rbGneralTarifa";
            this.rbGneralTarifa.Size = new System.Drawing.Size(152, 17);
            this.rbGneralTarifa.TabIndex = 17;
            this.rbGneralTarifa.TabStop = true;
            this.rbGneralTarifa.Text = "Resumen general por tarifa";
            this.rbGneralTarifa.UseVisualStyleBackColor = true;
            this.rbGneralTarifa.CheckedChanged += new System.EventHandler(this.rbGneralTarifa_CheckedChanged);
            // 
            // rbGeneralBarrio
            // 
            this.rbGeneralBarrio.AutoSize = true;
            this.rbGeneralBarrio.Location = new System.Drawing.Point(11, 65);
            this.rbGeneralBarrio.Name = "rbGeneralBarrio";
            this.rbGeneralBarrio.Size = new System.Drawing.Size(155, 17);
            this.rbGeneralBarrio.TabIndex = 18;
            this.rbGeneralBarrio.TabStop = true;
            this.rbGeneralBarrio.Text = "Resumen general por barrio";
            this.rbGeneralBarrio.UseVisualStyleBackColor = true;
            this.rbGeneralBarrio.CheckedChanged += new System.EventHandler(this.rbGeneralBarrio_CheckedChanged);
            // 
            // rbSubDiario
            // 
            this.rbSubDiario.AutoSize = true;
            this.rbSubDiario.Location = new System.Drawing.Point(11, 88);
            this.rbSubDiario.Name = "rbSubDiario";
            this.rbSubDiario.Size = new System.Drawing.Size(143, 17);
            this.rbSubDiario.TabIndex = 19;
            this.rbSubDiario.TabStop = true;
            this.rbSubDiario.Text = "Subdiario de Facturación";
            this.rbSubDiario.UseVisualStyleBackColor = true;
            this.rbSubDiario.CheckedChanged += new System.EventHandler(this.rbSubDiario_CheckedChanged);
            // 
            // PanelBZ
            // 
            this.PanelBZ.Controls.Add(this.cmbBarrios);
            this.PanelBZ.Controls.Add(this.rbTodosBarrios);
            this.PanelBZ.Controls.Add(this.rbEspecificarBarrio);
            this.PanelBZ.Controls.Add(this.cmbZonas);
            this.PanelBZ.Controls.Add(this.rbTodasZonas);
            this.PanelBZ.Controls.Add(this.rbEspecificarZonas);
            this.PanelBZ.Location = new System.Drawing.Point(21, 157);
            this.PanelBZ.Name = "PanelBZ";
            this.PanelBZ.Size = new System.Drawing.Size(373, 131);
            this.PanelBZ.TabIndex = 15;
            this.PanelBZ.TabStop = false;
            // 
            // cmbBarrios
            // 
            this.cmbBarrios.FormattingEnabled = true;
            this.cmbBarrios.Location = new System.Drawing.Point(138, 39);
            this.cmbBarrios.Name = "cmbBarrios";
            this.cmbBarrios.Size = new System.Drawing.Size(217, 21);
            this.cmbBarrios.TabIndex = 10;
            // 
            // rbTodosBarrios
            // 
            this.rbTodosBarrios.AutoSize = true;
            this.rbTodosBarrios.Location = new System.Drawing.Point(11, 17);
            this.rbTodosBarrios.Name = "rbTodosBarrios";
            this.rbTodosBarrios.Size = new System.Drawing.Size(105, 17);
            this.rbTodosBarrios.TabIndex = 11;
            this.rbTodosBarrios.TabStop = true;
            this.rbTodosBarrios.Text = "Todos los barrios";
            this.rbTodosBarrios.UseVisualStyleBackColor = true;
            // 
            // rbEspecificarBarrio
            // 
            this.rbEspecificarBarrio.AutoSize = true;
            this.rbEspecificarBarrio.Location = new System.Drawing.Point(11, 43);
            this.rbEspecificarBarrio.Name = "rbEspecificarBarrio";
            this.rbEspecificarBarrio.Size = new System.Drawing.Size(121, 17);
            this.rbEspecificarBarrio.TabIndex = 12;
            this.rbEspecificarBarrio.TabStop = true;
            this.rbEspecificarBarrio.Text = "Especificar un barrio";
            this.rbEspecificarBarrio.UseVisualStyleBackColor = true;
            this.rbEspecificarBarrio.CheckedChanged += new System.EventHandler(this.rbEspecificarBarrio_CheckedChanged);
            // 
            // cmbZonas
            // 
            this.cmbZonas.FormattingEnabled = true;
            this.cmbZonas.Location = new System.Drawing.Point(140, 92);
            this.cmbZonas.Name = "cmbZonas";
            this.cmbZonas.Size = new System.Drawing.Size(215, 21);
            this.cmbZonas.TabIndex = 8;
            // 
            // rbTodasZonas
            // 
            this.rbTodasZonas.AutoSize = true;
            this.rbTodasZonas.Location = new System.Drawing.Point(11, 69);
            this.rbTodasZonas.Name = "rbTodasZonas";
            this.rbTodasZonas.Size = new System.Drawing.Size(102, 17);
            this.rbTodasZonas.TabIndex = 8;
            this.rbTodasZonas.TabStop = true;
            this.rbTodasZonas.Text = "Todas las zonas";
            this.rbTodasZonas.UseVisualStyleBackColor = true;
            // 
            // rbEspecificarZonas
            // 
            this.rbEspecificarZonas.AutoSize = true;
            this.rbEspecificarZonas.Location = new System.Drawing.Point(11, 92);
            this.rbEspecificarZonas.Name = "rbEspecificarZonas";
            this.rbEspecificarZonas.Size = new System.Drawing.Size(124, 17);
            this.rbEspecificarZonas.TabIndex = 9;
            this.rbEspecificarZonas.TabStop = true;
            this.rbEspecificarZonas.Text = "Especificar una zona";
            this.rbEspecificarZonas.UseVisualStyleBackColor = true;
            this.rbEspecificarZonas.CheckedChanged += new System.EventHandler(this.rbEspecificarZonas_CheckedChanged);
            // 
            // rbConceptoBZ
            // 
            this.rbConceptoBZ.AutoSize = true;
            this.rbConceptoBZ.Location = new System.Drawing.Point(11, 111);
            this.rbConceptoBZ.Name = "rbConceptoBZ";
            this.rbConceptoBZ.Size = new System.Drawing.Size(218, 17);
            this.rbConceptoBZ.TabIndex = 4;
            this.rbConceptoBZ.TabStop = true;
            this.rbConceptoBZ.Text = "Resumen por concepto por barrio o zona";
            this.rbConceptoBZ.UseVisualStyleBackColor = true;
            this.rbConceptoBZ.CheckedChanged += new System.EventHandler(this.rbConceptoBZ_CheckedChanged);
            // 
            // rbFacturacionBZ
            // 
            this.rbFacturacionBZ.AutoSize = true;
            this.rbFacturacionBZ.Location = new System.Drawing.Point(11, 134);
            this.rbFacturacionBZ.Name = "rbFacturacionBZ";
            this.rbFacturacionBZ.Size = new System.Drawing.Size(223, 17);
            this.rbFacturacionBZ.TabIndex = 5;
            this.rbFacturacionBZ.TabStop = true;
            this.rbFacturacionBZ.Text = "Resumen de facturacion por barrio o zona";
            this.rbFacturacionBZ.UseVisualStyleBackColor = true;
            this.rbFacturacionBZ.CheckedChanged += new System.EventHandler(this.rbFacturacionBZ_CheckedChanged);
            // 
            // frmResumenFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 422);
            this.Controls.Add(this.gbgeneral2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.gbPeriodos);
            this.Name = "frmResumenFacturacion";
            this.Text = "frmResumenFacturacion";
            this.Load += new System.EventHandler(this.frmResumenFacturacion_Load);
            this.gbPeriodos.ResumeLayout(false);
            this.gbPeriodos.PerformLayout();
            this.gbgeneral2.ResumeLayout(false);
            this.gbgeneral2.PerformLayout();
            this.PanelBZ.ResumeLayout(false);
            this.PanelBZ.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPeriodos;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAnio;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.GroupBox gbgeneral2;
        private System.Windows.Forms.RadioButton rbGeneralConcepto;
        private System.Windows.Forms.RadioButton rbGneralTarifa;
        private System.Windows.Forms.RadioButton rbGeneralBarrio;
        private System.Windows.Forms.RadioButton rbSubDiario;
        private System.Windows.Forms.GroupBox PanelBZ;
        private System.Windows.Forms.ComboBox cmbZonas;
        private System.Windows.Forms.RadioButton rbTodasZonas;
        private System.Windows.Forms.RadioButton rbEspecificarZonas;
        private System.Windows.Forms.RadioButton rbConceptoBZ;
        private System.Windows.Forms.RadioButton rbFacturacionBZ;
        private System.Windows.Forms.ComboBox cmbBarrios;
        private System.Windows.Forms.RadioButton rbTodosBarrios;
        private System.Windows.Forms.RadioButton rbEspecificarBarrio;
    }
}