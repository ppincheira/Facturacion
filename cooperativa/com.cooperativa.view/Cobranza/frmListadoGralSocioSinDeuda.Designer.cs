namespace com.cooperativa.view.Cobranza
{
    partial class frmListadoGralSocioSinDeuda
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGenerarListado = new System.Windows.Forms.Button();
            this.gbOrdena = new System.Windows.Forms.GroupBox();
            this.gbOrdenar = new System.Windows.Forms.GroupBox();
            this.rbtnDescendente = new System.Windows.Forms.RadioButton();
            this.rbtnAscendente = new System.Windows.Forms.RadioButton();
            this.rbtnOBaMzaLo = new System.Windows.Forms.RadioButton();
            this.rbtnOApeNom = new System.Windows.Forms.RadioButton();
            this.rbtnONumeroSocio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.rbtnFiltro = new System.Windows.Forms.RadioButton();
            this.cmbBarrio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnSelecionaBarrio = new System.Windows.Forms.RadioButton();
            this.rbtnTodosBarrios = new System.Windows.Forms.RadioButton();
            this.groupBox4.SuspendLayout();
            this.gbOrdena.SuspendLayout();
            this.gbOrdenar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSalir);
            this.groupBox4.Controls.Add(this.btnGenerarListado);
            this.groupBox4.Location = new System.Drawing.Point(310, 100);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(347, 60);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(214, 17);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(116, 31);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGenerarListado
            // 
            this.btnGenerarListado.Location = new System.Drawing.Point(17, 17);
            this.btnGenerarListado.Name = "btnGenerarListado";
            this.btnGenerarListado.Size = new System.Drawing.Size(163, 31);
            this.btnGenerarListado.TabIndex = 0;
            this.btnGenerarListado.Text = "Generar Listado";
            this.btnGenerarListado.UseVisualStyleBackColor = true;
            this.btnGenerarListado.Click += new System.EventHandler(this.btnGenerarListado_Click);
            // 
            // gbOrdena
            // 
            this.gbOrdena.Controls.Add(this.gbOrdenar);
            this.gbOrdena.Controls.Add(this.rbtnOBaMzaLo);
            this.gbOrdena.Controls.Add(this.rbtnOApeNom);
            this.gbOrdena.Controls.Add(this.rbtnONumeroSocio);
            this.gbOrdena.Location = new System.Drawing.Point(310, 13);
            this.gbOrdena.Name = "gbOrdena";
            this.gbOrdena.Size = new System.Drawing.Size(347, 83);
            this.gbOrdena.TabIndex = 8;
            this.gbOrdena.TabStop = false;
            this.gbOrdena.Text = "Ordena por...";
            // 
            // gbOrdenar
            // 
            this.gbOrdenar.Controls.Add(this.rbtnDescendente);
            this.gbOrdenar.Controls.Add(this.rbtnAscendente);
            this.gbOrdenar.Location = new System.Drawing.Point(208, 7);
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
            // rbtnOBaMzaLo
            // 
            this.rbtnOBaMzaLo.AutoSize = true;
            this.rbtnOBaMzaLo.Checked = true;
            this.rbtnOBaMzaLo.Location = new System.Drawing.Point(18, 16);
            this.rbtnOBaMzaLo.Name = "rbtnOBaMzaLo";
            this.rbtnOBaMzaLo.Size = new System.Drawing.Size(134, 17);
            this.rbtnOBaMzaLo.TabIndex = 11;
            this.rbtnOBaMzaLo.TabStop = true;
            this.rbtnOBaMzaLo.Text = "Barrio, Manzana y Lote";
            this.rbtnOBaMzaLo.UseVisualStyleBackColor = true;
            // 
            // rbtnOApeNom
            // 
            this.rbtnOApeNom.AutoSize = true;
            this.rbtnOApeNom.Location = new System.Drawing.Point(17, 61);
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
            this.rbtnONumeroSocio.Location = new System.Drawing.Point(18, 39);
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
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 147);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generar Listado de ...";
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(145, 98);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(104, 25);
            this.btnFiltro.TabIndex = 7;
            this.btnFiltro.Text = "Crear filtro >>>";
            this.btnFiltro.UseVisualStyleBackColor = true;
            // 
            // rbtnFiltro
            // 
            this.rbtnFiltro.AutoSize = true;
            this.rbtnFiltro.Location = new System.Drawing.Point(16, 102);
            this.rbtnFiltro.Name = "rbtnFiltro";
            this.rbtnFiltro.Size = new System.Drawing.Size(102, 17);
            this.rbtnFiltro.TabIndex = 4;
            this.rbtnFiltro.Text = "Filtro avanzados";
            this.rbtnFiltro.UseVisualStyleBackColor = true;
            this.rbtnFiltro.CheckedChanged += new System.EventHandler(this.rbtnFiltro_CheckedChanged);
            // 
            // cmbBarrio
            // 
            this.cmbBarrio.FormattingEnabled = true;
            this.cmbBarrio.Location = new System.Drawing.Point(76, 66);
            this.cmbBarrio.Name = "cmbBarrio";
            this.cmbBarrio.Size = new System.Drawing.Size(173, 21);
            this.cmbBarrio.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Barrio:";
            // 
            // rbtnSelecionaBarrio
            // 
            this.rbtnSelecionaBarrio.AutoSize = true;
            this.rbtnSelecionaBarrio.Checked = true;
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
            this.rbtnTodosBarrios.Text = "Todos los barrios";
            this.rbtnTodosBarrios.UseVisualStyleBackColor = true;
            this.rbtnTodosBarrios.CheckedChanged += new System.EventHandler(this.rbtnTodosBarrios_CheckedChanged);
            // 
            // frmListadoGralSocioSinDeuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 171);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gbOrdena);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmListadoGralSocioSinDeuda";
            this.Text = "Listado general de socios sin deuda";
            this.Load += new System.EventHandler(this.frmListadoGralSocioSinDeuda_Load);
            this.groupBox4.ResumeLayout(false);
            this.gbOrdena.ResumeLayout(false);
            this.gbOrdena.PerformLayout();
            this.gbOrdenar.ResumeLayout(false);
            this.gbOrdenar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGenerarListado;
        private System.Windows.Forms.GroupBox gbOrdena;
        private System.Windows.Forms.GroupBox gbOrdenar;
        private System.Windows.Forms.RadioButton rbtnDescendente;
        private System.Windows.Forms.RadioButton rbtnAscendente;
        private System.Windows.Forms.RadioButton rbtnOBaMzaLo;
        private System.Windows.Forms.RadioButton rbtnOApeNom;
        private System.Windows.Forms.RadioButton rbtnONumeroSocio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.RadioButton rbtnFiltro;
        private System.Windows.Forms.ComboBox cmbBarrio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnSelecionaBarrio;
        private System.Windows.Forms.RadioButton rbtnTodosBarrios;
    }
}