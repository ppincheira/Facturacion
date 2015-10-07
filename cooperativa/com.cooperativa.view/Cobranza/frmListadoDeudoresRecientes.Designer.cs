namespace com.cooperativa.view.Cobranza
{
    partial class frmListadoDeudoresRecientes
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
            this.gbOrdena = new System.Windows.Forms.GroupBox();
            this.gbOrdenar = new System.Windows.Forms.GroupBox();
            this.rbtnDescendente = new System.Windows.Forms.RadioButton();
            this.rbtnAscendente = new System.Windows.Forms.RadioButton();
            this.rbtnOImporteAdeudado = new System.Windows.Forms.RadioButton();
            this.rbtnOCantPeiodosAdeudados = new System.Windows.Forms.RadioButton();
            this.rbtnOApeNom = new System.Windows.Forms.RadioButton();
            this.rbtnONumeroSocio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.rbtnFiltro = new System.Windows.Forms.RadioButton();
            this.cmbBarrio = new System.Windows.Forms.ComboBox();
            this.rbtnSelecionaBarrio = new System.Windows.Forms.RadioButton();
            this.rbtnTodosBarrios = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGenerarListado = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.rbtnFAl = new System.Windows.Forms.RadioButton();
            this.rbtnFHoy = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gbOrdena.SuspendLayout();
            this.gbOrdenar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOrdena
            // 
            this.gbOrdena.Controls.Add(this.gbOrdenar);
            this.gbOrdena.Controls.Add(this.rbtnOImporteAdeudado);
            this.gbOrdena.Controls.Add(this.rbtnOCantPeiodosAdeudados);
            this.gbOrdena.Controls.Add(this.rbtnOApeNom);
            this.gbOrdena.Controls.Add(this.rbtnONumeroSocio);
            this.gbOrdena.Location = new System.Drawing.Point(308, 12);
            this.gbOrdena.Name = "gbOrdena";
            this.gbOrdena.Size = new System.Drawing.Size(347, 122);
            this.gbOrdena.TabIndex = 4;
            this.gbOrdena.TabStop = false;
            this.gbOrdena.Text = "Ordena por...";
            // 
            // gbOrdenar
            // 
            this.gbOrdenar.Controls.Add(this.rbtnDescendente);
            this.gbOrdenar.Controls.Add(this.rbtnAscendente);
            this.gbOrdenar.Location = new System.Drawing.Point(207, 26);
            this.gbOrdenar.Name = "gbOrdenar";
            this.gbOrdenar.Size = new System.Drawing.Size(122, 71);
            this.gbOrdenar.TabIndex = 12;
            this.gbOrdenar.TabStop = false;
            this.gbOrdenar.Text = "Ordenar en forma...";
            // 
            // rbtnDescendente
            // 
            this.rbtnDescendente.AutoSize = true;
            this.rbtnDescendente.Location = new System.Drawing.Point(6, 42);
            this.rbtnDescendente.Name = "rbtnDescendente";
            this.rbtnDescendente.Size = new System.Drawing.Size(89, 17);
            this.rbtnDescendente.TabIndex = 14;
            this.rbtnDescendente.TabStop = true;
            this.rbtnDescendente.Text = "Descendente";
            this.rbtnDescendente.UseVisualStyleBackColor = true;
            // 
            // rbtnAscendente
            // 
            this.rbtnAscendente.AutoSize = true;
            this.rbtnAscendente.Checked = true;
            this.rbtnAscendente.Location = new System.Drawing.Point(6, 19);
            this.rbtnAscendente.Name = "rbtnAscendente";
            this.rbtnAscendente.Size = new System.Drawing.Size(82, 17);
            this.rbtnAscendente.TabIndex = 13;
            this.rbtnAscendente.TabStop = true;
            this.rbtnAscendente.Text = "Ascendente";
            this.rbtnAscendente.UseVisualStyleBackColor = true;
            // 
            // rbtnOImporteAdeudado
            // 
            this.rbtnOImporteAdeudado.AutoSize = true;
            this.rbtnOImporteAdeudado.Location = new System.Drawing.Point(17, 95);
            this.rbtnOImporteAdeudado.Name = "rbtnOImporteAdeudado";
            this.rbtnOImporteAdeudado.Size = new System.Drawing.Size(116, 17);
            this.rbtnOImporteAdeudado.TabIndex = 11;
            this.rbtnOImporteAdeudado.TabStop = true;
            this.rbtnOImporteAdeudado.Text = "Importe adeudados";
            this.rbtnOImporteAdeudado.UseVisualStyleBackColor = true;
            // 
            // rbtnOCantPeiodosAdeudados
            // 
            this.rbtnOCantPeiodosAdeudados.AutoSize = true;
            this.rbtnOCantPeiodosAdeudados.Location = new System.Drawing.Point(17, 72);
            this.rbtnOCantPeiodosAdeudados.Name = "rbtnOCantPeiodosAdeudados";
            this.rbtnOCantPeiodosAdeudados.Size = new System.Drawing.Size(180, 17);
            this.rbtnOCantPeiodosAdeudados.TabIndex = 10;
            this.rbtnOCantPeiodosAdeudados.TabStop = true;
            this.rbtnOCantPeiodosAdeudados.Text = "Cantidad de Peiodos Adeudados";
            this.rbtnOCantPeiodosAdeudados.UseVisualStyleBackColor = true;
            // 
            // rbtnOApeNom
            // 
            this.rbtnOApeNom.AutoSize = true;
            this.rbtnOApeNom.Location = new System.Drawing.Point(18, 49);
            this.rbtnOApeNom.Name = "rbtnOApeNom";
            this.rbtnOApeNom.Size = new System.Drawing.Size(108, 17);
            this.rbtnOApeNom.TabIndex = 9;
            this.rbtnOApeNom.TabStop = true;
            this.rbtnOApeNom.Text = "Apellido y nombre";
            this.rbtnOApeNom.UseVisualStyleBackColor = true;
            // 
            // rbtnONumeroSocio
            // 
            this.rbtnONumeroSocio.AutoSize = true;
            this.rbtnONumeroSocio.Checked = true;
            this.rbtnONumeroSocio.Location = new System.Drawing.Point(18, 26);
            this.rbtnONumeroSocio.Name = "rbtnONumeroSocio";
            this.rbtnONumeroSocio.Size = new System.Drawing.Size(107, 17);
            this.rbtnONumeroSocio.TabIndex = 8;
            this.rbtnONumeroSocio.TabStop = true;
            this.rbtnONumeroSocio.Text = "Número de Socio";
            this.rbtnONumeroSocio.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFiltro);
            this.groupBox1.Controls.Add(this.rbtnFiltro);
            this.groupBox1.Controls.Add(this.cmbBarrio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rbtnSelecionaBarrio);
            this.groupBox1.Controls.Add(this.rbtnTodosBarrios);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 122);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generar Listado de ...";
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(145, 83);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(104, 25);
            this.btnFiltro.TabIndex = 7;
            this.btnFiltro.Text = "Crear filtro >>>";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // rbtnFiltro
            // 
            this.rbtnFiltro.AutoSize = true;
            this.rbtnFiltro.Location = new System.Drawing.Point(16, 83);
            this.rbtnFiltro.Name = "rbtnFiltro";
            this.rbtnFiltro.Size = new System.Drawing.Size(102, 17);
            this.rbtnFiltro.TabIndex = 4;
            this.rbtnFiltro.TabStop = true;
            this.rbtnFiltro.Text = "Filtro avanzados";
            this.rbtnFiltro.UseVisualStyleBackColor = true;
            this.rbtnFiltro.CheckedChanged += new System.EventHandler(this.rbtnFiltro_CheckedChanged);
            // 
            // cmbBarrio
            // 
            this.cmbBarrio.FormattingEnabled = true;
            this.cmbBarrio.Location = new System.Drawing.Point(76, 59);
            this.cmbBarrio.Name = "cmbBarrio";
            this.cmbBarrio.Size = new System.Drawing.Size(173, 21);
            this.cmbBarrio.TabIndex = 3;
            // 
            // rbtnSelecionaBarrio
            // 
            this.rbtnSelecionaBarrio.AutoSize = true;
            this.rbtnSelecionaBarrio.Location = new System.Drawing.Point(16, 43);
            this.rbtnSelecionaBarrio.Name = "rbtnSelecionaBarrio";
            this.rbtnSelecionaBarrio.Size = new System.Drawing.Size(125, 17);
            this.rbtnSelecionaBarrio.TabIndex = 1;
            this.rbtnSelecionaBarrio.TabStop = true;
            this.rbtnSelecionaBarrio.Text = "Seleccionar un barrio";
            this.rbtnSelecionaBarrio.UseVisualStyleBackColor = true;
            this.rbtnSelecionaBarrio.CheckedChanged += new System.EventHandler(this.rbtnSelecionaBarrio_CheckedChanged);
            // 
            // rbtnTodosBarrios
            // 
            this.rbtnTodosBarrios.AutoSize = true;
            this.rbtnTodosBarrios.Location = new System.Drawing.Point(16, 20);
            this.rbtnTodosBarrios.Name = "rbtnTodosBarrios";
            this.rbtnTodosBarrios.Size = new System.Drawing.Size(105, 17);
            this.rbtnTodosBarrios.TabIndex = 0;
            this.rbtnTodosBarrios.TabStop = true;
            this.rbtnTodosBarrios.Text = "Todos los barrios";
            this.rbtnTodosBarrios.UseVisualStyleBackColor = true;
            this.rbtnTodosBarrios.CheckedChanged += new System.EventHandler(this.rbtnTodosBarrios_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSalir);
            this.groupBox4.Controls.Add(this.btnGenerarListado);
            this.groupBox4.Location = new System.Drawing.Point(308, 149);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(347, 66);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(213, 22);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(116, 31);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGenerarListado
            // 
            this.btnGenerarListado.Location = new System.Drawing.Point(17, 22);
            this.btnGenerarListado.Name = "btnGenerarListado";
            this.btnGenerarListado.Size = new System.Drawing.Size(163, 31);
            this.btnGenerarListado.TabIndex = 0;
            this.btnGenerarListado.Text = "Generar Listado";
            this.btnGenerarListado.UseVisualStyleBackColor = true;
            this.btnGenerarListado.Click += new System.EventHandler(this.btnGenerarListado_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpFecha);
            this.groupBox3.Controls.Add(this.rbtnFAl);
            this.groupBox3.Controls.Add(this.rbtnFHoy);
            this.groupBox3.Location = new System.Drawing.Point(12, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 66);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Emitir listado a la fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(61, 39);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(95, 20);
            this.dtpFecha.TabIndex = 2;
            // 
            // rbtnFAl
            // 
            this.rbtnFAl.AutoSize = true;
            this.rbtnFAl.Location = new System.Drawing.Point(17, 43);
            this.rbtnFAl.Name = "rbtnFAl";
            this.rbtnFAl.Size = new System.Drawing.Size(37, 17);
            this.rbtnFAl.TabIndex = 1;
            this.rbtnFAl.Text = "Al ";
            this.rbtnFAl.UseVisualStyleBackColor = true;
            this.rbtnFAl.CheckedChanged += new System.EventHandler(this.rbtnFAl_CheckedChanged);
            // 
            // rbtnFHoy
            // 
            this.rbtnFHoy.AutoSize = true;
            this.rbtnFHoy.Checked = true;
            this.rbtnFHoy.Location = new System.Drawing.Point(17, 20);
            this.rbtnFHoy.Name = "rbtnFHoy";
            this.rbtnFHoy.Size = new System.Drawing.Size(86, 17);
            this.rbtnFHoy.TabIndex = 0;
            this.rbtnFHoy.TabStop = true;
            this.rbtnFHoy.Text = "Al dia de hoy";
            this.rbtnFHoy.UseVisualStyleBackColor = true;
            this.rbtnFHoy.CheckedChanged += new System.EventHandler(this.rbtnFHoy_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Barrio:";
            // 
            // frmListadoDeudoresRecientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 224);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbOrdena);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmListadoDeudoresRecientes";
            this.Text = "Listado de deudores recientes";
            this.Load += new System.EventHandler(this.frmListadoDeudoresRecientes_Load);
            this.gbOrdena.ResumeLayout(false);
            this.gbOrdena.PerformLayout();
            this.gbOrdenar.ResumeLayout(false);
            this.gbOrdenar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOrdena;
        private System.Windows.Forms.GroupBox gbOrdenar;
        private System.Windows.Forms.RadioButton rbtnDescendente;
        private System.Windows.Forms.RadioButton rbtnAscendente;
        private System.Windows.Forms.RadioButton rbtnOImporteAdeudado;
        private System.Windows.Forms.RadioButton rbtnOCantPeiodosAdeudados;
        private System.Windows.Forms.RadioButton rbtnOApeNom;
        private System.Windows.Forms.RadioButton rbtnONumeroSocio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.RadioButton rbtnFiltro;
        private System.Windows.Forms.ComboBox cmbBarrio;
        private System.Windows.Forms.RadioButton rbtnSelecionaBarrio;
        private System.Windows.Forms.RadioButton rbtnTodosBarrios;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGenerarListado;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.RadioButton rbtnFAl;
        private System.Windows.Forms.RadioButton rbtnFHoy;
        private System.Windows.Forms.Label label1;

    }
}