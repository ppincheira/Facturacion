namespace com.cooperativa.view.Cobranza
{
    partial class frmAnalisisUsuariosSocios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnalisisUsuariosSocios));
            this.gbAnalisis = new System.Windows.Forms.GroupBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.rbtnDesde = new System.Windows.Forms.RadioButton();
            this.rbtn6 = new System.Windows.Forms.RadioButton();
            this.rbtn3 = new System.Windows.Forms.RadioButton();
            this.rbtn12 = new System.Windows.Forms.RadioButton();
            this.rbtn24 = new System.Windows.Forms.RadioButton();
            this.gbGenerar = new System.Windows.Forms.GroupBox();
            this.cmbTarifa = new System.Windows.Forms.ComboBox();
            this.cmbZona = new System.Windows.Forms.ComboBox();
            this.cmbBarrio = new System.Windows.Forms.ComboBox();
            this.rbtnTarifa = new System.Windows.Forms.RadioButton();
            this.rbtnZona = new System.Windows.Forms.RadioButton();
            this.rbtnBarrio = new System.Windows.Forms.RadioButton();
            this.rbtnTotalidadSyU = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGenerarListado = new System.Windows.Forms.Button();
            this.gbAnalisis.SuspendLayout();
            this.gbGenerar.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAnalisis
            // 
            this.gbAnalisis.Controls.Add(this.dtpHasta);
            this.gbAnalisis.Controls.Add(this.label1);
            this.gbAnalisis.Controls.Add(this.dtpDesde);
            this.gbAnalisis.Controls.Add(this.rbtnDesde);
            this.gbAnalisis.Controls.Add(this.rbtn6);
            this.gbAnalisis.Controls.Add(this.rbtn3);
            this.gbAnalisis.Controls.Add(this.rbtn12);
            this.gbAnalisis.Controls.Add(this.rbtn24);
            this.gbAnalisis.Location = new System.Drawing.Point(371, 12);
            this.gbAnalisis.Name = "gbAnalisis";
            this.gbAnalisis.Size = new System.Drawing.Size(325, 168);
            this.gbAnalisis.TabIndex = 3;
            this.gbAnalisis.TabStop = false;
            this.gbAnalisis.Text = "Alcance de análisis...";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(215, 118);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(101, 20);
            this.dtpHasta.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "hasta";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(68, 121);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(101, 20);
            this.dtpDesde.TabIndex = 7;
            // 
            // rbtnDesde
            // 
            this.rbtnDesde.AutoSize = true;
            this.rbtnDesde.Location = new System.Drawing.Point(6, 121);
            this.rbtnDesde.Name = "rbtnDesde";
            this.rbtnDesde.Size = new System.Drawing.Size(56, 17);
            this.rbtnDesde.TabIndex = 6;
            this.rbtnDesde.Text = "Desde";
            this.rbtnDesde.UseVisualStyleBackColor = true;
            this.rbtnDesde.CheckedChanged += new System.EventHandler(this.rbtnDesde_CheckedChanged);
            // 
            // rbtn6
            // 
            this.rbtn6.AutoSize = true;
            this.rbtn6.Location = new System.Drawing.Point(6, 75);
            this.rbtn6.Name = "rbtn6";
            this.rbtn6.Size = new System.Drawing.Size(101, 17);
            this.rbtn6.TabIndex = 5;
            this.rbtn6.Text = "Ultimos 6 meses";
            this.rbtn6.UseVisualStyleBackColor = true;
            this.rbtn6.CheckedChanged += new System.EventHandler(this.rbtn6_CheckedChanged);
            // 
            // rbtn3
            // 
            this.rbtn3.AutoSize = true;
            this.rbtn3.Location = new System.Drawing.Point(6, 98);
            this.rbtn3.Name = "rbtn3";
            this.rbtn3.Size = new System.Drawing.Size(101, 17);
            this.rbtn3.TabIndex = 4;
            this.rbtn3.Text = "Ultimos 3 meses";
            this.rbtn3.UseVisualStyleBackColor = true;
            this.rbtn3.CheckedChanged += new System.EventHandler(this.rbtn3_CheckedChanged);
            // 
            // rbtn12
            // 
            this.rbtn12.AutoSize = true;
            this.rbtn12.Checked = true;
            this.rbtn12.Location = new System.Drawing.Point(6, 52);
            this.rbtn12.Name = "rbtn12";
            this.rbtn12.Size = new System.Drawing.Size(107, 17);
            this.rbtn12.TabIndex = 3;
            this.rbtn12.TabStop = true;
            this.rbtn12.Text = "Ultimos 12 meses";
            this.rbtn12.UseVisualStyleBackColor = true;
            this.rbtn12.CheckedChanged += new System.EventHandler(this.rbtn12_CheckedChanged);
            // 
            // rbtn24
            // 
            this.rbtn24.AutoSize = true;
            this.rbtn24.Location = new System.Drawing.Point(6, 29);
            this.rbtn24.Name = "rbtn24";
            this.rbtn24.Size = new System.Drawing.Size(107, 17);
            this.rbtn24.TabIndex = 2;
            this.rbtn24.Text = "Ultimos 24 meses";
            this.rbtn24.UseVisualStyleBackColor = true;
            this.rbtn24.CheckedChanged += new System.EventHandler(this.rbtn24_CheckedChanged);
            // 
            // gbGenerar
            // 
            this.gbGenerar.Controls.Add(this.cmbTarifa);
            this.gbGenerar.Controls.Add(this.cmbZona);
            this.gbGenerar.Controls.Add(this.cmbBarrio);
            this.gbGenerar.Controls.Add(this.rbtnTarifa);
            this.gbGenerar.Controls.Add(this.rbtnZona);
            this.gbGenerar.Controls.Add(this.rbtnBarrio);
            this.gbGenerar.Controls.Add(this.rbtnTotalidadSyU);
            this.gbGenerar.Location = new System.Drawing.Point(12, 12);
            this.gbGenerar.Name = "gbGenerar";
            this.gbGenerar.Size = new System.Drawing.Size(351, 168);
            this.gbGenerar.TabIndex = 2;
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
            // rbtnTotalidadSyU
            // 
            this.rbtnTotalidadSyU.AutoSize = true;
            this.rbtnTotalidadSyU.Checked = true;
            this.rbtnTotalidadSyU.Location = new System.Drawing.Point(6, 29);
            this.rbtnTotalidadSyU.Name = "rbtnTotalidadSyU";
            this.rbtnTotalidadSyU.Size = new System.Drawing.Size(178, 17);
            this.rbtnTotalidadSyU.TabIndex = 0;
            this.rbtnTotalidadSyU.TabStop = true;
            this.rbtnTotalidadSyU.Text = "La totalidad de socios y usuarios";
            this.rbtnTotalidadSyU.UseVisualStyleBackColor = true;
            this.rbtnTotalidadSyU.CheckedChanged += new System.EventHandler(this.rbtnTotalidadSyU_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSalir);
            this.groupBox4.Controls.Add(this.btnGenerarListado);
            this.groupBox4.Location = new System.Drawing.Point(371, 186);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(325, 60);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(209, 17);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(107, 31);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGenerarListado
            // 
            this.btnGenerarListado.Location = new System.Drawing.Point(6, 17);
            this.btnGenerarListado.Name = "btnGenerarListado";
            this.btnGenerarListado.Size = new System.Drawing.Size(151, 31);
            this.btnGenerarListado.TabIndex = 0;
            this.btnGenerarListado.Text = "Generar Listado";
            this.btnGenerarListado.UseVisualStyleBackColor = true;
            this.btnGenerarListado.Click += new System.EventHandler(this.btnGenerarListado_Click);
            // 
            // frmAnalisisUsuariosSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 249);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gbAnalisis);
            this.Controls.Add(this.gbGenerar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAnalisisUsuariosSocios";
            this.Text = "Análisis de usuarios / Socios";
            this.Load += new System.EventHandler(this.frmAnalisisUsuariosSocios_Load);
            this.gbAnalisis.ResumeLayout(false);
            this.gbAnalisis.PerformLayout();
            this.gbGenerar.ResumeLayout(false);
            this.gbGenerar.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAnalisis;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.RadioButton rbtnDesde;
        private System.Windows.Forms.RadioButton rbtn6;
        private System.Windows.Forms.RadioButton rbtn3;
        private System.Windows.Forms.RadioButton rbtn12;
        private System.Windows.Forms.RadioButton rbtn24;
        private System.Windows.Forms.GroupBox gbGenerar;
        private System.Windows.Forms.ComboBox cmbTarifa;
        private System.Windows.Forms.ComboBox cmbZona;
        private System.Windows.Forms.ComboBox cmbBarrio;
        private System.Windows.Forms.RadioButton rbtnTarifa;
        private System.Windows.Forms.RadioButton rbtnZona;
        private System.Windows.Forms.RadioButton rbtnBarrio;
        private System.Windows.Forms.RadioButton rbtnTotalidadSyU;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGenerarListado;
    }
}