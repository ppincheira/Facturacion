namespace com.cooperativa.view.Rutas
{
    partial class frmImprimirHojaRuta
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.gbCombos = new System.Windows.Forms.GroupBox();
            this.cmbRuta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBarrios = new System.Windows.Forms.ComboBox();
            this.rbUnaHojaRutaBarrio = new System.Windows.Forms.RadioButton();
            this.rbTodasHojasRutasBarrio = new System.Windows.Forms.RadioButton();
            this.rbTodasHojasRutas = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.gbCombos.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnImprimir);
            this.groupBox1.Controls.Add(this.gbCombos);
            this.groupBox1.Controls.Add(this.rbUnaHojaRutaBarrio);
            this.groupBox1.Controls.Add(this.rbTodasHojasRutasBarrio);
            this.groupBox1.Controls.Add(this.rbTodasHojasRutas);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 252);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Impresión de hojas de ruta";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(322, 213);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(403, 213);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 7;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // gbCombos
            // 
            this.gbCombos.Controls.Add(this.cmbRuta);
            this.gbCombos.Controls.Add(this.label2);
            this.gbCombos.Controls.Add(this.label1);
            this.gbCombos.Controls.Add(this.cmbBarrios);
            this.gbCombos.Location = new System.Drawing.Point(26, 138);
            this.gbCombos.Name = "gbCombos";
            this.gbCombos.Size = new System.Drawing.Size(452, 54);
            this.gbCombos.TabIndex = 6;
            this.gbCombos.TabStop = false;
            // 
            // cmbRuta
            // 
            this.cmbRuta.Enabled = false;
            this.cmbRuta.FormattingEnabled = true;
            this.cmbRuta.Location = new System.Drawing.Point(331, 19);
            this.cmbRuta.Name = "cmbRuta";
            this.cmbRuta.Size = new System.Drawing.Size(100, 21);
            this.cmbRuta.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ruta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Barrio:";
            // 
            // cmbBarrios
            // 
            this.cmbBarrios.Enabled = false;
            this.cmbBarrios.FormattingEnabled = true;
            this.cmbBarrios.Location = new System.Drawing.Point(62, 19);
            this.cmbBarrios.Name = "cmbBarrios";
            this.cmbBarrios.Size = new System.Drawing.Size(217, 21);
            this.cmbBarrios.TabIndex = 11;
            this.cmbBarrios.SelectedIndexChanged += new System.EventHandler(this.cmbBarrios_SelectedIndexChanged);
            // 
            // rbUnaHojaRutaBarrio
            // 
            this.rbUnaHojaRutaBarrio.AutoSize = true;
            this.rbUnaHojaRutaBarrio.Location = new System.Drawing.Point(26, 94);
            this.rbUnaHojaRutaBarrio.Name = "rbUnaHojaRutaBarrio";
            this.rbUnaHojaRutaBarrio.Size = new System.Drawing.Size(199, 17);
            this.rbUnaHojaRutaBarrio.TabIndex = 5;
            this.rbUnaHojaRutaBarrio.TabStop = true;
            this.rbUnaHojaRutaBarrio.Text = "Imprimir una hoja de ruta de un barrio";
            this.rbUnaHojaRutaBarrio.UseVisualStyleBackColor = true;
            this.rbUnaHojaRutaBarrio.CheckedChanged += new System.EventHandler(this.rbUnaHojaRutaBarrio_CheckedChanged);
            // 
            // rbTodasHojasRutasBarrio
            // 
            this.rbTodasHojasRutasBarrio.AutoSize = true;
            this.rbTodasHojasRutasBarrio.Location = new System.Drawing.Point(26, 62);
            this.rbTodasHojasRutasBarrio.Name = "rbTodasHojasRutasBarrio";
            this.rbTodasHojasRutasBarrio.Size = new System.Drawing.Size(233, 17);
            this.rbTodasHojasRutasBarrio.TabIndex = 4;
            this.rbTodasHojasRutasBarrio.TabStop = true;
            this.rbTodasHojasRutasBarrio.Text = "Imprimir todas las hojas de rutas de un barrio";
            this.rbTodasHojasRutasBarrio.UseVisualStyleBackColor = true;
            this.rbTodasHojasRutasBarrio.CheckedChanged += new System.EventHandler(this.rbTodasHojasRutasBarrio_CheckedChanged);
            // 
            // rbTodasHojasRutas
            // 
            this.rbTodasHojasRutas.AutoSize = true;
            this.rbTodasHojasRutas.Location = new System.Drawing.Point(26, 30);
            this.rbTodasHojasRutas.Name = "rbTodasHojasRutas";
            this.rbTodasHojasRutas.Size = new System.Drawing.Size(169, 17);
            this.rbTodasHojasRutas.TabIndex = 3;
            this.rbTodasHojasRutas.TabStop = true;
            this.rbTodasHojasRutas.Text = "Imprimir todas las hojas de ruta";
            this.rbTodasHojasRutas.UseVisualStyleBackColor = true;
            this.rbTodasHojasRutas.CheckedChanged += new System.EventHandler(this.rbTodasHojasRutas_CheckedChanged);
            // 
            // frmImprimirHojaRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 292);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmImprimirHojaRuta";
            this.Text = "Impresión de hojas de ruta";
            this.Load += new System.EventHandler(this.frmImprimirHojaRuta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbCombos.ResumeLayout(false);
            this.gbCombos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbCombos;
        private System.Windows.Forms.RadioButton rbUnaHojaRutaBarrio;
        private System.Windows.Forms.RadioButton rbTodasHojasRutasBarrio;
        private System.Windows.Forms.RadioButton rbTodasHojasRutas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.ComboBox cmbRuta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBarrios;

    }
}