namespace com.cooperativa.view.Facturacion
{
    partial class frmImprimirFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImprimirFactura));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbProgreso = new System.Windows.Forms.ProgressBar();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnLeyendas = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkPeriodoHasta = new System.Windows.Forms.CheckBox();
            this.cmbPeriodoHasta = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPeriodoDesde = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOrdenar = new System.Windows.Forms.ComboBox();
            this.cmbZonas = new System.Windows.Forms.ComboBox();
            this.cmbBarrios = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbSeleccionar = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSeleccionFacturas = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mtxtNumero = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkImprimirTexto = new System.Windows.Forms.CheckBox();
            this.chkZonasNoImprimen = new System.Windows.Forms.CheckBox();
            this.chkSinRecargo = new System.Windows.Forms.CheckBox();
            this.rbSelFacturasReImp = new System.Windows.Forms.RadioButton();
            this.rbFacturasBarrio = new System.Windows.Forms.RadioButton();
            this.rbFacturasUnaZona = new System.Windows.Forms.RadioButton();
            this.rbPeriodoCompleto = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbSeleccionar.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnImprimir);
            this.groupBox1.Controls.Add(this.btnLeyendas);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 414);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Impresión de facturas";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.pbProgreso);
            this.groupBox6.Location = new System.Drawing.Point(7, 316);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(637, 68);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Grado de Avance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(593, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "100%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "0%";
            // 
            // pbProgreso
            // 
            this.pbProgreso.Location = new System.Drawing.Point(14, 37);
            this.pbProgreso.Name = "pbProgreso";
            this.pbProgreso.Size = new System.Drawing.Size(611, 23);
            this.pbProgreso.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(569, 274);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(488, 274);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnLeyendas
            // 
            this.btnLeyendas.Location = new System.Drawing.Point(7, 274);
            this.btnLeyendas.Name = "btnLeyendas";
            this.btnLeyendas.Size = new System.Drawing.Size(75, 23);
            this.btnLeyendas.TabIndex = 3;
            this.btnLeyendas.Text = "&Leyendas";
            this.btnLeyendas.UseVisualStyleBackColor = true;
            this.btnLeyendas.Click += new System.EventHandler(this.btnLeyendas_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkPeriodoHasta);
            this.groupBox5.Controls.Add(this.cmbPeriodoHasta);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.cmbPeriodoDesde);
            this.groupBox5.Location = new System.Drawing.Point(326, 151);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(318, 117);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Periodos";
            // 
            // chkPeriodoHasta
            // 
            this.chkPeriodoHasta.AutoSize = true;
            this.chkPeriodoHasta.Location = new System.Drawing.Point(52, 52);
            this.chkPeriodoHasta.Name = "chkPeriodoHasta";
            this.chkPeriodoHasta.Size = new System.Drawing.Size(54, 17);
            this.chkPeriodoHasta.TabIndex = 8;
            this.chkPeriodoHasta.Text = "Hasta";
            this.chkPeriodoHasta.UseVisualStyleBackColor = true;
            this.chkPeriodoHasta.CheckedChanged += new System.EventHandler(this.chkPeriodoHasta_CheckedChanged);
            // 
            // cmbPeriodoHasta
            // 
            this.cmbPeriodoHasta.FormattingEnabled = true;
            this.cmbPeriodoHasta.Location = new System.Drawing.Point(135, 48);
            this.cmbPeriodoHasta.Name = "cmbPeriodoHasta";
            this.cmbPeriodoHasta.Size = new System.Drawing.Size(157, 21);
            this.cmbPeriodoHasta.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Periodo Desde:";
            // 
            // cmbPeriodoDesde
            // 
            this.cmbPeriodoDesde.FormattingEnabled = true;
            this.cmbPeriodoDesde.Location = new System.Drawing.Point(135, 21);
            this.cmbPeriodoDesde.Name = "cmbPeriodoDesde";
            this.cmbPeriodoDesde.Size = new System.Drawing.Size(157, 21);
            this.cmbPeriodoDesde.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.cmbOrdenar);
            this.groupBox4.Controls.Add(this.cmbZonas);
            this.groupBox4.Controls.Add(this.cmbBarrios);
            this.groupBox4.Location = new System.Drawing.Point(7, 151);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(313, 117);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Alcance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ordenar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Zona:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Barrio:";
            // 
            // cmbOrdenar
            // 
            this.cmbOrdenar.FormattingEnabled = true;
            this.cmbOrdenar.Location = new System.Drawing.Point(84, 78);
            this.cmbOrdenar.Name = "cmbOrdenar";
            this.cmbOrdenar.Size = new System.Drawing.Size(223, 21);
            this.cmbOrdenar.TabIndex = 2;
            // 
            // cmbZonas
            // 
            this.cmbZonas.Enabled = false;
            this.cmbZonas.FormattingEnabled = true;
            this.cmbZonas.Location = new System.Drawing.Point(84, 50);
            this.cmbZonas.Name = "cmbZonas";
            this.cmbZonas.Size = new System.Drawing.Size(223, 21);
            this.cmbZonas.TabIndex = 1;
            // 
            // cmbBarrios
            // 
            this.cmbBarrios.Enabled = false;
            this.cmbBarrios.FormattingEnabled = true;
            this.cmbBarrios.Location = new System.Drawing.Point(84, 23);
            this.cmbBarrios.Name = "cmbBarrios";
            this.cmbBarrios.Size = new System.Drawing.Size(223, 21);
            this.cmbBarrios.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gbSeleccionar);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.chkZonasNoImprimen);
            this.groupBox2.Controls.Add(this.chkSinRecargo);
            this.groupBox2.Controls.Add(this.rbSelFacturasReImp);
            this.groupBox2.Controls.Add(this.rbFacturasBarrio);
            this.groupBox2.Controls.Add(this.rbFacturasUnaZona);
            this.groupBox2.Controls.Add(this.rbPeriodoCompleto);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(644, 122);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // gbSeleccionar
            // 
            this.gbSeleccionar.Controls.Add(this.label11);
            this.gbSeleccionar.Controls.Add(this.btnSeleccionFacturas);
            this.gbSeleccionar.Controls.Add(this.textBox1);
            this.gbSeleccionar.Controls.Add(this.label10);
            this.gbSeleccionar.Controls.Add(this.txtNombre);
            this.gbSeleccionar.Controls.Add(this.label7);
            this.gbSeleccionar.Controls.Add(this.label8);
            this.gbSeleccionar.Controls.Add(this.mtxtNumero);
            this.gbSeleccionar.Controls.Add(this.btnBuscar);
            this.gbSeleccionar.Controls.Add(this.label9);
            this.gbSeleccionar.Controls.Add(this.txtBusqueda);
            this.gbSeleccionar.Location = new System.Drawing.Point(15, 42);
            this.gbSeleccionar.Name = "gbSeleccionar";
            this.gbSeleccionar.Size = new System.Drawing.Size(644, 120);
            this.gbSeleccionar.TabIndex = 7;
            this.gbSeleccionar.TabStop = false;
            this.gbSeleccionar.Text = "Seleccionar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Estados de socio:";
            // 
            // btnSeleccionFacturas
            // 
            this.btnSeleccionFacturas.Location = new System.Drawing.Point(481, 72);
            this.btnSeleccionFacturas.Name = "btnSeleccionFacturas";
            this.btnSeleccionFacturas.Size = new System.Drawing.Size(152, 23);
            this.btnSeleccionFacturas.TabIndex = 16;
            this.btnSeleccionFacturas.Text = "Seleccionar Facturas";
            this.btnSeleccionFacturas.UseVisualStyleBackColor = true;
            this.btnSeleccionFacturas.Click += new System.EventHandler(this.btnSeleccionFacturas_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(373, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(39, 20);
            this.textBox1.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(263, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Facturas a reimprimir:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(266, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(290, 20);
            this.txtNombre.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(213, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nombre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Número:";
            // 
            // mtxtNumero
            // 
            this.mtxtNumero.Location = new System.Drawing.Point(115, 46);
            this.mtxtNumero.Mask = "000000/00";
            this.mtxtNumero.Name = "mtxtNumero";
            this.mtxtNumero.Size = new System.Drawing.Size(83, 20);
            this.mtxtNumero.TabIndex = 10;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(481, 17);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar Socio";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Búsqueda rápida:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(115, 18);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(235, 20);
            this.txtBusqueda.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkImprimirTexto);
            this.groupBox3.Location = new System.Drawing.Point(320, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(318, 50);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // chkImprimirTexto
            // 
            this.chkImprimirTexto.AutoSize = true;
            this.chkImprimirTexto.Location = new System.Drawing.Point(9, 17);
            this.chkImprimirTexto.Name = "chkImprimirTexto";
            this.chkImprimirTexto.Size = new System.Drawing.Size(301, 17);
            this.chkImprimirTexto.TabIndex = 7;
            this.chkImprimirTexto.Text = "Imprimir texto \"PAGO UNICAMENTE EN COOPERATIVA\"";
            this.chkImprimirTexto.UseVisualStyleBackColor = true;
            // 
            // chkZonasNoImprimen
            // 
            this.chkZonasNoImprimen.AutoSize = true;
            this.chkZonasNoImprimen.Enabled = false;
            this.chkZonasNoImprimen.Location = new System.Drawing.Point(38, 90);
            this.chkZonasNoImprimen.Name = "chkZonasNoImprimen";
            this.chkZonasNoImprimen.Size = new System.Drawing.Size(259, 17);
            this.chkZonasNoImprimen.TabIndex = 5;
            this.chkZonasNoImprimen.Text = "Incluir las zonas que regularmente no se imprimen";
            this.chkZonasNoImprimen.UseVisualStyleBackColor = true;
            // 
            // chkSinRecargo
            // 
            this.chkSinRecargo.AutoSize = true;
            this.chkSinRecargo.Enabled = false;
            this.chkSinRecargo.Location = new System.Drawing.Point(378, 42);
            this.chkSinRecargo.Name = "chkSinRecargo";
            this.chkSinRecargo.Size = new System.Drawing.Size(157, 17);
            this.chkSinRecargo.TabIndex = 4;
            this.chkSinRecargo.Text = "Imprimir facturas sin recargo";
            this.chkSinRecargo.UseVisualStyleBackColor = true;
            // 
            // rbSelFacturasReImp
            // 
            this.rbSelFacturasReImp.AutoSize = true;
            this.rbSelFacturasReImp.Location = new System.Drawing.Point(337, 19);
            this.rbSelFacturasReImp.Name = "rbSelFacturasReImp";
            this.rbSelFacturasReImp.Size = new System.Drawing.Size(203, 17);
            this.rbSelFacturasReImp.TabIndex = 3;
            this.rbSelFacturasReImp.TabStop = true;
            this.rbSelFacturasReImp.Text = "Seleccionar la/s factura/s a reimprimir";
            this.rbSelFacturasReImp.UseVisualStyleBackColor = true;
            this.rbSelFacturasReImp.CheckedChanged += new System.EventHandler(this.rbSelFacturasReImp_CheckedChanged);
            // 
            // rbFacturasBarrio
            // 
            this.rbFacturasBarrio.AutoSize = true;
            this.rbFacturasBarrio.Location = new System.Drawing.Point(19, 67);
            this.rbFacturasBarrio.Name = "rbFacturasBarrio";
            this.rbFacturasBarrio.Size = new System.Drawing.Size(205, 17);
            this.rbFacturasBarrio.TabIndex = 2;
            this.rbFacturasBarrio.TabStop = true;
            this.rbFacturasBarrio.Text = "Imprimir todas las facturas de un barrio";
            this.rbFacturasBarrio.UseVisualStyleBackColor = true;
            this.rbFacturasBarrio.CheckedChanged += new System.EventHandler(this.rbFacturasBarrio_CheckedChanged);
            // 
            // rbFacturasUnaZona
            // 
            this.rbFacturasUnaZona.AutoSize = true;
            this.rbFacturasUnaZona.Location = new System.Drawing.Point(19, 43);
            this.rbFacturasUnaZona.Name = "rbFacturasUnaZona";
            this.rbFacturasUnaZona.Size = new System.Drawing.Size(208, 17);
            this.rbFacturasUnaZona.TabIndex = 1;
            this.rbFacturasUnaZona.TabStop = true;
            this.rbFacturasUnaZona.Text = "Imprimir todas las facturas de una zona";
            this.rbFacturasUnaZona.UseVisualStyleBackColor = true;
            this.rbFacturasUnaZona.CheckedChanged += new System.EventHandler(this.rbFacturasUnaZona_CheckedChanged);
            // 
            // rbPeriodoCompleto
            // 
            this.rbPeriodoCompleto.AutoSize = true;
            this.rbPeriodoCompleto.Location = new System.Drawing.Point(19, 20);
            this.rbPeriodoCompleto.Name = "rbPeriodoCompleto";
            this.rbPeriodoCompleto.Size = new System.Drawing.Size(156, 17);
            this.rbPeriodoCompleto.TabIndex = 0;
            this.rbPeriodoCompleto.TabStop = true;
            this.rbPeriodoCompleto.Text = "Imprimir Periodos Completos";
            this.rbPeriodoCompleto.UseVisualStyleBackColor = true;
            this.rbPeriodoCompleto.CheckedChanged += new System.EventHandler(this.rbPeriodoCompleto_CheckedChanged);
            // 
            // frmImprimirFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 438);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmImprimirFactura";
            this.Text = "frmImprimirFactura";
            this.Load += new System.EventHandler(this.frmImprimirFactura_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbSeleccionar.ResumeLayout(false);
            this.gbSeleccionar.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbSeleccionar;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar pbProgreso;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnLeyendas;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chkPeriodoHasta;
        private System.Windows.Forms.ComboBox cmbPeriodoHasta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPeriodoDesde;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOrdenar;
        private System.Windows.Forms.ComboBox cmbZonas;
        private System.Windows.Forms.ComboBox cmbBarrios;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkImprimirTexto;
        private System.Windows.Forms.CheckBox chkZonasNoImprimen;
        private System.Windows.Forms.CheckBox chkSinRecargo;
        private System.Windows.Forms.RadioButton rbSelFacturasReImp;
        private System.Windows.Forms.RadioButton rbFacturasBarrio;
        private System.Windows.Forms.RadioButton rbFacturasUnaZona;
        private System.Windows.Forms.RadioButton rbPeriodoCompleto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSeleccionFacturas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.MaskedTextBox mtxtNumero;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBusqueda;
    }
}