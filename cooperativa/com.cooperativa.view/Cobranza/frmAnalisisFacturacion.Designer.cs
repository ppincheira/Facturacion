namespace com.cooperativa.view.Cobranza
{
    partial class frmAnalisisFacturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnalisisFacturacion));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTarifa = new System.Windows.Forms.ComboBox();
            this.cmbZona = new System.Windows.Forms.ComboBox();
            this.cmbBarrio = new System.Windows.Forms.ComboBox();
            this.rbtnTarifa = new System.Windows.Forms.RadioButton();
            this.rbtnZona = new System.Windows.Forms.RadioButton();
            this.rbtnBarrio = new System.Windows.Forms.RadioButton();
            this.rbtnFacturacionCompleta = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.rbtnPeriodo = new System.Windows.Forms.RadioButton();
            this.rbtn3 = new System.Windows.Forms.RadioButton();
            this.rbtn6 = new System.Windows.Forms.RadioButton();
            this.rbtn12 = new System.Windows.Forms.RadioButton();
            this.rbtn24 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtnNoSocios = new System.Windows.Forms.RadioButton();
            this.rbtnSocios = new System.Windows.Forms.RadioButton();
            this.rbtnSociosNoSocios = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGenerarListado = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTarifa);
            this.groupBox1.Controls.Add(this.cmbZona);
            this.groupBox1.Controls.Add(this.cmbBarrio);
            this.groupBox1.Controls.Add(this.rbtnTarifa);
            this.groupBox1.Controls.Add(this.rbtnZona);
            this.groupBox1.Controls.Add(this.rbtnBarrio);
            this.groupBox1.Controls.Add(this.rbtnFacturacionCompleta);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generar Informe de ...";
            // 
            // cmbTarifa
            // 
            this.cmbTarifa.FormattingEnabled = true;
            this.cmbTarifa.Location = new System.Drawing.Point(137, 118);
            this.cmbTarifa.Name = "cmbTarifa";
            this.cmbTarifa.Size = new System.Drawing.Size(230, 21);
            this.cmbTarifa.TabIndex = 6;
            // 
            // cmbZona
            // 
            this.cmbZona.FormattingEnabled = true;
            this.cmbZona.Location = new System.Drawing.Point(137, 90);
            this.cmbZona.Name = "cmbZona";
            this.cmbZona.Size = new System.Drawing.Size(230, 21);
            this.cmbZona.TabIndex = 5;
            // 
            // cmbBarrio
            // 
            this.cmbBarrio.FormattingEnabled = true;
            this.cmbBarrio.Location = new System.Drawing.Point(137, 63);
            this.cmbBarrio.Name = "cmbBarrio";
            this.cmbBarrio.Size = new System.Drawing.Size(230, 21);
            this.cmbBarrio.TabIndex = 4;
            // 
            // rbtnTarifa
            // 
            this.rbtnTarifa.AutoSize = true;
            this.rbtnTarifa.Location = new System.Drawing.Point(11, 119);
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
            this.rbtnZona.Location = new System.Drawing.Point(11, 91);
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
            this.rbtnBarrio.Location = new System.Drawing.Point(11, 63);
            this.rbtnBarrio.Name = "rbtnBarrio";
            this.rbtnBarrio.Size = new System.Drawing.Size(125, 17);
            this.rbtnBarrio.TabIndex = 1;
            this.rbtnBarrio.Text = "Seleccionar un barrio";
            this.rbtnBarrio.UseVisualStyleBackColor = true;
            this.rbtnBarrio.CheckedChanged += new System.EventHandler(this.rbtnBarrio_CheckedChanged);
            // 
            // rbtnFacturacionCompleta
            // 
            this.rbtnFacturacionCompleta.AutoSize = true;
            this.rbtnFacturacionCompleta.Checked = true;
            this.rbtnFacturacionCompleta.Location = new System.Drawing.Point(11, 40);
            this.rbtnFacturacionCompleta.Name = "rbtnFacturacionCompleta";
            this.rbtnFacturacionCompleta.Size = new System.Drawing.Size(178, 17);
            this.rbtnFacturacionCompleta.TabIndex = 0;
            this.rbtnFacturacionCompleta.TabStop = true;
            this.rbtnFacturacionCompleta.Text = "La facturación completa del mes";
            this.rbtnFacturacionCompleta.UseVisualStyleBackColor = true;
            this.rbtnFacturacionCompleta.CheckedChanged += new System.EventHandler(this.rbtnFacturacionCompleta_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpHasta);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtpDesde);
            this.groupBox2.Controls.Add(this.rbtnPeriodo);
            this.groupBox2.Controls.Add(this.rbtn3);
            this.groupBox2.Controls.Add(this.rbtn6);
            this.groupBox2.Controls.Add(this.rbtn12);
            this.groupBox2.Controls.Add(this.rbtn24);
            this.groupBox2.Location = new System.Drawing.Point(389, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 154);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alcance del análisis";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(193, 120);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(95, 20);
            this.dtpHasta.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "hasta";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(59, 120);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(95, 20);
            this.dtpDesde.TabIndex = 5;
            // 
            // rbtnPeriodo
            // 
            this.rbtnPeriodo.AutoSize = true;
            this.rbtnPeriodo.Location = new System.Drawing.Point(6, 120);
            this.rbtnPeriodo.Name = "rbtnPeriodo";
            this.rbtnPeriodo.Size = new System.Drawing.Size(59, 17);
            this.rbtnPeriodo.TabIndex = 4;
            this.rbtnPeriodo.Text = "Desde ";
            this.rbtnPeriodo.UseVisualStyleBackColor = true;
            this.rbtnPeriodo.CheckedChanged += new System.EventHandler(this.rbtnPeriodo_CheckedChanged);
            // 
            // rbtn3
            // 
            this.rbtn3.AutoSize = true;
            this.rbtn3.Location = new System.Drawing.Point(6, 93);
            this.rbtn3.Name = "rbtn3";
            this.rbtn3.Size = new System.Drawing.Size(101, 17);
            this.rbtn3.TabIndex = 3;
            this.rbtn3.Text = "Ultimos 3 meses";
            this.rbtn3.UseVisualStyleBackColor = true;
            this.rbtn3.CheckedChanged += new System.EventHandler(this.rbtn3_CheckedChanged);
            // 
            // rbtn6
            // 
            this.rbtn6.AutoSize = true;
            this.rbtn6.Location = new System.Drawing.Point(6, 68);
            this.rbtn6.Name = "rbtn6";
            this.rbtn6.Size = new System.Drawing.Size(101, 17);
            this.rbtn6.TabIndex = 2;
            this.rbtn6.Text = "Ultimos 6 meses";
            this.rbtn6.UseVisualStyleBackColor = true;
            this.rbtn6.CheckedChanged += new System.EventHandler(this.rbtn6_CheckedChanged);
            // 
            // rbtn12
            // 
            this.rbtn12.AutoSize = true;
            this.rbtn12.Checked = true;
            this.rbtn12.Location = new System.Drawing.Point(6, 42);
            this.rbtn12.Name = "rbtn12";
            this.rbtn12.Size = new System.Drawing.Size(107, 17);
            this.rbtn12.TabIndex = 1;
            this.rbtn12.TabStop = true;
            this.rbtn12.Text = "Ultimos 12 meses";
            this.rbtn12.UseVisualStyleBackColor = true;
            this.rbtn12.CheckedChanged += new System.EventHandler(this.rbtn12_CheckedChanged);
            // 
            // rbtn24
            // 
            this.rbtn24.AutoSize = true;
            this.rbtn24.Location = new System.Drawing.Point(6, 17);
            this.rbtn24.Name = "rbtn24";
            this.rbtn24.Size = new System.Drawing.Size(107, 17);
            this.rbtn24.TabIndex = 0;
            this.rbtn24.Text = "Ultimos 24 meses";
            this.rbtn24.UseVisualStyleBackColor = true;
            this.rbtn24.CheckedChanged += new System.EventHandler(this.rbtn24_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtnNoSocios);
            this.groupBox3.Controls.Add(this.rbtnSocios);
            this.groupBox3.Controls.Add(this.rbtnSociosNoSocios);
            this.groupBox3.Location = new System.Drawing.Point(8, 164);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(375, 58);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Incluir";
            // 
            // rbtnNoSocios
            // 
            this.rbtnNoSocios.AutoSize = true;
            this.rbtnNoSocios.Location = new System.Drawing.Point(277, 22);
            this.rbtnNoSocios.Name = "rbtnNoSocios";
            this.rbtnNoSocios.Size = new System.Drawing.Size(77, 17);
            this.rbtnNoSocios.TabIndex = 10;
            this.rbtnNoSocios.Text = "No Socios ";
            this.rbtnNoSocios.UseVisualStyleBackColor = true;
            // 
            // rbtnSocios
            // 
            this.rbtnSocios.AutoSize = true;
            this.rbtnSocios.Location = new System.Drawing.Point(159, 22);
            this.rbtnSocios.Name = "rbtnSocios";
            this.rbtnSocios.Size = new System.Drawing.Size(60, 17);
            this.rbtnSocios.TabIndex = 9;
            this.rbtnSocios.Text = "Socios ";
            this.rbtnSocios.UseVisualStyleBackColor = true;
            // 
            // rbtnSociosNoSocios
            // 
            this.rbtnSociosNoSocios.AutoSize = true;
            this.rbtnSociosNoSocios.Checked = true;
            this.rbtnSociosNoSocios.Location = new System.Drawing.Point(11, 22);
            this.rbtnSociosNoSocios.Name = "rbtnSociosNoSocios";
            this.rbtnSociosNoSocios.Size = new System.Drawing.Size(115, 17);
            this.rbtnSociosNoSocios.TabIndex = 8;
            this.rbtnSociosNoSocios.TabStop = true;
            this.rbtnSociosNoSocios.Text = "Socios y No socios";
            this.rbtnSociosNoSocios.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSalir);
            this.groupBox4.Controls.Add(this.btnGenerarListado);
            this.groupBox4.Location = new System.Drawing.Point(389, 163);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(294, 58);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(206, 15);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(82, 31);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGenerarListado
            // 
            this.btnGenerarListado.Location = new System.Drawing.Point(6, 15);
            this.btnGenerarListado.Name = "btnGenerarListado";
            this.btnGenerarListado.Size = new System.Drawing.Size(131, 31);
            this.btnGenerarListado.TabIndex = 0;
            this.btnGenerarListado.Text = "Generar Listado";
            this.btnGenerarListado.UseVisualStyleBackColor = true;
            this.btnGenerarListado.Click += new System.EventHandler(this.btnGenerarListado_Click);
            // 
            // frmAnalisisFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 225);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAnalisisFacturacion";
            this.Text = "Análisis de facturación / Cobranzas";
            this.Load += new System.EventHandler(this.frmAnalisisFacturacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTarifa;
        private System.Windows.Forms.ComboBox cmbZona;
        private System.Windows.Forms.ComboBox cmbBarrio;
        private System.Windows.Forms.RadioButton rbtnTarifa;
        private System.Windows.Forms.RadioButton rbtnZona;
        private System.Windows.Forms.RadioButton rbtnBarrio;
        private System.Windows.Forms.RadioButton rbtnFacturacionCompleta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.RadioButton rbtnPeriodo;
        private System.Windows.Forms.RadioButton rbtn3;
        private System.Windows.Forms.RadioButton rbtn6;
        private System.Windows.Forms.RadioButton rbtn12;
        private System.Windows.Forms.RadioButton rbtn24;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtnNoSocios;
        private System.Windows.Forms.RadioButton rbtnSocios;
        private System.Windows.Forms.RadioButton rbtnSociosNoSocios;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGenerarListado;
    }
}