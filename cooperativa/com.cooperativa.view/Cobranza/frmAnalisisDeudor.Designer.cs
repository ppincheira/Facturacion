namespace com.cooperativa.view.Cobranza
{
    partial class frmAnalisisDeudor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnalisisDeudor));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGenerarListado = new System.Windows.Forms.Button();
            this.gbIncluir = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMargen = new System.Windows.Forms.TextBox();
            this.rbtnNoSocio = new System.Windows.Forms.RadioButton();
            this.rbtnSocio = new System.Windows.Forms.RadioButton();
            this.rbtnSyNS = new System.Windows.Forms.RadioButton();
            this.gbGenerar = new System.Windows.Forms.GroupBox();
            this.cmbTarifa = new System.Windows.Forms.ComboBox();
            this.cmbZona = new System.Windows.Forms.ComboBox();
            this.cmbBarrio = new System.Windows.Forms.ComboBox();
            this.rbtnTarifa = new System.Windows.Forms.RadioButton();
            this.rbtnZona = new System.Windows.Forms.RadioButton();
            this.rbtnBarrio = new System.Windows.Forms.RadioButton();
            this.rbtnSociosUsuario = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn36 = new System.Windows.Forms.RadioButton();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.rbtnAPeriodos = new System.Windows.Forms.RadioButton();
            this.rbtnA6 = new System.Windows.Forms.RadioButton();
            this.rbtnA3 = new System.Windows.Forms.RadioButton();
            this.rbtnA12 = new System.Windows.Forms.RadioButton();
            this.rbtnA24 = new System.Windows.Forms.RadioButton();
            this.groupBox4.SuspendLayout();
            this.gbIncluir.SuspendLayout();
            this.gbGenerar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSalir);
            this.groupBox4.Controls.Add(this.btnGenerarListado);
            this.groupBox4.Location = new System.Drawing.Point(375, 188);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(325, 67);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(209, 20);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(107, 31);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGenerarListado
            // 
            this.btnGenerarListado.Location = new System.Drawing.Point(6, 20);
            this.btnGenerarListado.Name = "btnGenerarListado";
            this.btnGenerarListado.Size = new System.Drawing.Size(151, 31);
            this.btnGenerarListado.TabIndex = 0;
            this.btnGenerarListado.Text = "Generar Informe";
            this.btnGenerarListado.UseVisualStyleBackColor = true;
            this.btnGenerarListado.Click += new System.EventHandler(this.btnGenerarListado_Click);
            // 
            // gbIncluir
            // 
            this.gbIncluir.Controls.Add(this.label4);
            this.gbIncluir.Controls.Add(this.label3);
            this.gbIncluir.Controls.Add(this.txtMargen);
            this.gbIncluir.Controls.Add(this.rbtnNoSocio);
            this.gbIncluir.Controls.Add(this.rbtnSocio);
            this.gbIncluir.Controls.Add(this.rbtnSyNS);
            this.gbIncluir.Location = new System.Drawing.Point(12, 188);
            this.gbIncluir.Name = "gbIncluir";
            this.gbIncluir.Size = new System.Drawing.Size(351, 69);
            this.gbIncluir.TabIndex = 17;
            this.gbIncluir.TabStop = false;
            this.gbIncluir.Text = "Incluir...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "periodos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Margen de variación a buscar";
            // 
            // txtMargen
            // 
            this.txtMargen.Location = new System.Drawing.Point(160, 40);
            this.txtMargen.Name = "txtMargen";
            this.txtMargen.Size = new System.Drawing.Size(48, 20);
            this.txtMargen.TabIndex = 10;
            this.txtMargen.Text = "3";
            // 
            // rbtnNoSocio
            // 
            this.rbtnNoSocio.AutoSize = true;
            this.rbtnNoSocio.Location = new System.Drawing.Point(257, 17);
            this.rbtnNoSocio.Name = "rbtnNoSocio";
            this.rbtnNoSocio.Size = new System.Drawing.Size(74, 17);
            this.rbtnNoSocio.TabIndex = 9;
            this.rbtnNoSocio.Text = "No Socios";
            this.rbtnNoSocio.UseVisualStyleBackColor = true;
            // 
            // rbtnSocio
            // 
            this.rbtnSocio.AutoSize = true;
            this.rbtnSocio.Location = new System.Drawing.Point(163, 17);
            this.rbtnSocio.Name = "rbtnSocio";
            this.rbtnSocio.Size = new System.Drawing.Size(57, 17);
            this.rbtnSocio.TabIndex = 8;
            this.rbtnSocio.Text = "Socios";
            this.rbtnSocio.UseVisualStyleBackColor = true;
            // 
            // rbtnSyNS
            // 
            this.rbtnSyNS.AutoSize = true;
            this.rbtnSyNS.Checked = true;
            this.rbtnSyNS.Location = new System.Drawing.Point(6, 17);
            this.rbtnSyNS.Name = "rbtnSyNS";
            this.rbtnSyNS.Size = new System.Drawing.Size(117, 17);
            this.rbtnSyNS.TabIndex = 7;
            this.rbtnSyNS.TabStop = true;
            this.rbtnSyNS.Text = "Socios y No Socios";
            this.rbtnSyNS.UseVisualStyleBackColor = true;
            // 
            // gbGenerar
            // 
            this.gbGenerar.Controls.Add(this.cmbTarifa);
            this.gbGenerar.Controls.Add(this.cmbZona);
            this.gbGenerar.Controls.Add(this.cmbBarrio);
            this.gbGenerar.Controls.Add(this.rbtnTarifa);
            this.gbGenerar.Controls.Add(this.rbtnZona);
            this.gbGenerar.Controls.Add(this.rbtnBarrio);
            this.gbGenerar.Controls.Add(this.rbtnSociosUsuario);
            this.gbGenerar.Location = new System.Drawing.Point(12, 12);
            this.gbGenerar.Name = "gbGenerar";
            this.gbGenerar.Size = new System.Drawing.Size(351, 168);
            this.gbGenerar.TabIndex = 15;
            this.gbGenerar.TabStop = false;
            this.gbGenerar.Text = "Generar informe de...";
            // 
            // cmbTarifa
            // 
            this.cmbTarifa.FormattingEnabled = true;
            this.cmbTarifa.Location = new System.Drawing.Point(137, 131);
            this.cmbTarifa.Name = "cmbTarifa";
            this.cmbTarifa.Size = new System.Drawing.Size(204, 21);
            this.cmbTarifa.TabIndex = 6;
            // 
            // cmbZona
            // 
            this.cmbZona.FormattingEnabled = true;
            this.cmbZona.Location = new System.Drawing.Point(137, 91);
            this.cmbZona.Name = "cmbZona";
            this.cmbZona.Size = new System.Drawing.Size(204, 21);
            this.cmbZona.TabIndex = 5;
            // 
            // cmbBarrio
            // 
            this.cmbBarrio.FormattingEnabled = true;
            this.cmbBarrio.Location = new System.Drawing.Point(137, 58);
            this.cmbBarrio.Name = "cmbBarrio";
            this.cmbBarrio.Size = new System.Drawing.Size(204, 21);
            this.cmbBarrio.TabIndex = 4;
            // 
            // rbtnTarifa
            // 
            this.rbtnTarifa.AutoSize = true;
            this.rbtnTarifa.Location = new System.Drawing.Point(6, 131);
            this.rbtnTarifa.Name = "rbtnTarifa";
            this.rbtnTarifa.Size = new System.Drawing.Size(128, 17);
            this.rbtnTarifa.TabIndex = 3;
            this.rbtnTarifa.Text = "Seleccionar una tarifa";
            this.rbtnTarifa.UseVisualStyleBackColor = true;
            this.rbtnTarifa.CheckedChanged += new System.EventHandler(this.rbtnTarifa_CheckedChanged);
            // 
            // rbtnZona
            // 
            this.rbtnZona.AutoSize = true;
            this.rbtnZona.Location = new System.Drawing.Point(6, 95);
            this.rbtnZona.Name = "rbtnZona";
            this.rbtnZona.Size = new System.Drawing.Size(128, 17);
            this.rbtnZona.TabIndex = 2;
            this.rbtnZona.Text = "Seleccionar una zona";
            this.rbtnZona.UseVisualStyleBackColor = true;
            this.rbtnZona.CheckedChanged += new System.EventHandler(this.rbtnZona_CheckedChanged);
            // 
            // rbtnBarrio
            // 
            this.rbtnBarrio.AutoSize = true;
            this.rbtnBarrio.Location = new System.Drawing.Point(6, 62);
            this.rbtnBarrio.Name = "rbtnBarrio";
            this.rbtnBarrio.Size = new System.Drawing.Size(125, 17);
            this.rbtnBarrio.TabIndex = 1;
            this.rbtnBarrio.Text = "Seleccionar un barrio";
            this.rbtnBarrio.UseVisualStyleBackColor = true;
            this.rbtnBarrio.CheckedChanged += new System.EventHandler(this.rbtnBarrio_CheckedChanged);
            // 
            // rbtnSociosUsuario
            // 
            this.rbtnSociosUsuario.AutoSize = true;
            this.rbtnSociosUsuario.Checked = true;
            this.rbtnSociosUsuario.Location = new System.Drawing.Point(6, 29);
            this.rbtnSociosUsuario.Name = "rbtnSociosUsuario";
            this.rbtnSociosUsuario.Size = new System.Drawing.Size(155, 17);
            this.rbtnSociosUsuario.TabIndex = 0;
            this.rbtnSociosUsuario.TabStop = true;
            this.rbtnSociosUsuario.Text = "El total de socios y usuarios";
            this.rbtnSociosUsuario.UseVisualStyleBackColor = true;
            this.rbtnSociosUsuario.CheckedChanged += new System.EventHandler(this.rbtnSociosUsuario_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn36);
            this.groupBox1.Controls.Add(this.dtpHasta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpDesde);
            this.groupBox1.Controls.Add(this.rbtnAPeriodos);
            this.groupBox1.Controls.Add(this.rbtnA6);
            this.groupBox1.Controls.Add(this.rbtnA3);
            this.groupBox1.Controls.Add(this.rbtnA12);
            this.groupBox1.Controls.Add(this.rbtnA24);
            this.groupBox1.Location = new System.Drawing.Point(369, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 168);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alcance de análisis...";
            // 
            // rbtn36
            // 
            this.rbtn36.AutoSize = true;
            this.rbtn36.Checked = true;
            this.rbtn36.Location = new System.Drawing.Point(6, 20);
            this.rbtn36.Name = "rbtn36";
            this.rbtn36.Size = new System.Drawing.Size(107, 17);
            this.rbtn36.TabIndex = 10;
            this.rbtn36.TabStop = true;
            this.rbtn36.Text = "Ultimos 36 meses";
            this.rbtn36.UseVisualStyleBackColor = true;
            this.rbtn36.CheckedChanged += new System.EventHandler(this.rbtn36_CheckedChanged);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(215, 135);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(101, 20);
            this.dtpHasta.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "hasta";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(68, 135);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(101, 20);
            this.dtpDesde.TabIndex = 7;
            // 
            // rbtnAPeriodos
            // 
            this.rbtnAPeriodos.AutoSize = true;
            this.rbtnAPeriodos.Location = new System.Drawing.Point(6, 135);
            this.rbtnAPeriodos.Name = "rbtnAPeriodos";
            this.rbtnAPeriodos.Size = new System.Drawing.Size(56, 17);
            this.rbtnAPeriodos.TabIndex = 6;
            this.rbtnAPeriodos.Text = "Desde";
            this.rbtnAPeriodos.UseVisualStyleBackColor = true;
            this.rbtnAPeriodos.CheckedChanged += new System.EventHandler(this.rbtnAPeriodos_CheckedChanged);
            // 
            // rbtnA6
            // 
            this.rbtnA6.AutoSize = true;
            this.rbtnA6.Location = new System.Drawing.Point(6, 89);
            this.rbtnA6.Name = "rbtnA6";
            this.rbtnA6.Size = new System.Drawing.Size(101, 17);
            this.rbtnA6.TabIndex = 5;
            this.rbtnA6.Text = "Ultimos 6 meses";
            this.rbtnA6.UseVisualStyleBackColor = true;
            this.rbtnA6.CheckedChanged += new System.EventHandler(this.rbtnA6_CheckedChanged);
            // 
            // rbtnA3
            // 
            this.rbtnA3.AutoSize = true;
            this.rbtnA3.Location = new System.Drawing.Point(6, 112);
            this.rbtnA3.Name = "rbtnA3";
            this.rbtnA3.Size = new System.Drawing.Size(101, 17);
            this.rbtnA3.TabIndex = 4;
            this.rbtnA3.Text = "Ultimos 3 meses";
            this.rbtnA3.UseVisualStyleBackColor = true;
            this.rbtnA3.CheckedChanged += new System.EventHandler(this.rbtnA3_CheckedChanged);
            // 
            // rbtnA12
            // 
            this.rbtnA12.AutoSize = true;
            this.rbtnA12.Location = new System.Drawing.Point(6, 66);
            this.rbtnA12.Name = "rbtnA12";
            this.rbtnA12.Size = new System.Drawing.Size(107, 17);
            this.rbtnA12.TabIndex = 3;
            this.rbtnA12.Text = "Ultimos 12 meses";
            this.rbtnA12.UseVisualStyleBackColor = true;
            this.rbtnA12.CheckedChanged += new System.EventHandler(this.rbtnA12_CheckedChanged);
            // 
            // rbtnA24
            // 
            this.rbtnA24.AutoSize = true;
            this.rbtnA24.Location = new System.Drawing.Point(6, 43);
            this.rbtnA24.Name = "rbtnA24";
            this.rbtnA24.Size = new System.Drawing.Size(107, 17);
            this.rbtnA24.TabIndex = 2;
            this.rbtnA24.Text = "Ultimos 24 meses";
            this.rbtnA24.UseVisualStyleBackColor = true;
            this.rbtnA24.CheckedChanged += new System.EventHandler(this.rbtnA24_CheckedChanged);
            // 
            // frmAnalisisDeudor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 267);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gbIncluir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbGenerar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAnalisisDeudor";
            this.Text = "Detectar cambios de estado de Deudor/No Deudor";
            this.Load += new System.EventHandler(this.frmAnalisisDeudor_Load);
            this.groupBox4.ResumeLayout(false);
            this.gbIncluir.ResumeLayout(false);
            this.gbIncluir.PerformLayout();
            this.gbGenerar.ResumeLayout(false);
            this.gbGenerar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGenerarListado;
        private System.Windows.Forms.GroupBox gbIncluir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMargen;
        private System.Windows.Forms.RadioButton rbtnNoSocio;
        private System.Windows.Forms.RadioButton rbtnSocio;
        private System.Windows.Forms.RadioButton rbtnSyNS;
        private System.Windows.Forms.GroupBox gbGenerar;
        private System.Windows.Forms.ComboBox cmbTarifa;
        private System.Windows.Forms.ComboBox cmbZona;
        private System.Windows.Forms.ComboBox cmbBarrio;
        private System.Windows.Forms.RadioButton rbtnTarifa;
        private System.Windows.Forms.RadioButton rbtnZona;
        private System.Windows.Forms.RadioButton rbtnBarrio;
        private System.Windows.Forms.RadioButton rbtnSociosUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn36;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.RadioButton rbtnAPeriodos;
        private System.Windows.Forms.RadioButton rbtnA6;
        private System.Windows.Forms.RadioButton rbtnA3;
        private System.Windows.Forms.RadioButton rbtnA12;
        private System.Windows.Forms.RadioButton rbtnA24;
    }
}