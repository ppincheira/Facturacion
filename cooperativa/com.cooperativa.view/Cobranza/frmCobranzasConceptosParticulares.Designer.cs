namespace com.cooperativa.view.Cobranza
{
    partial class frmCobranzasConceptosParticulares
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
            this.cmbHasta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDesde = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbOrdena = new System.Windows.Forms.GroupBox();
            this.gbOrdenar = new System.Windows.Forms.GroupBox();
            this.rbtnDescendente = new System.Windows.Forms.RadioButton();
            this.rbtnAscendente = new System.Windows.Forms.RadioButton();
            this.rbtnONroFactura = new System.Windows.Forms.RadioButton();
            this.rbtnOCodigoSocio = new System.Windows.Forms.RadioButton();
            this.rbtnOApeNom = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkListConceptoParticular = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGenerarListado = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbOrdena.SuspendLayout();
            this.gbOrdenar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbHasta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbDesde);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Periodo";
            // 
            // cmbHasta
            // 
            this.cmbHasta.FormattingEnabled = true;
            this.cmbHasta.Location = new System.Drawing.Point(60, 63);
            this.cmbHasta.Name = "cmbHasta";
            this.cmbHasta.Size = new System.Drawing.Size(181, 21);
            this.cmbHasta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasta:";
            // 
            // cmbDesde
            // 
            this.cmbDesde.FormattingEnabled = true;
            this.cmbDesde.Location = new System.Drawing.Point(61, 25);
            this.cmbDesde.Name = "cmbDesde";
            this.cmbDesde.Size = new System.Drawing.Size(181, 21);
            this.cmbDesde.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde:";
            // 
            // gbOrdena
            // 
            this.gbOrdena.Controls.Add(this.gbOrdenar);
            this.gbOrdena.Controls.Add(this.rbtnONroFactura);
            this.gbOrdena.Controls.Add(this.rbtnOCodigoSocio);
            this.gbOrdena.Controls.Add(this.rbtnOApeNom);
            this.gbOrdena.Location = new System.Drawing.Point(12, 138);
            this.gbOrdena.Name = "gbOrdena";
            this.gbOrdena.Size = new System.Drawing.Size(257, 106);
            this.gbOrdena.TabIndex = 3;
            this.gbOrdena.TabStop = false;
            this.gbOrdena.Text = "Ordena por...";
            // 
            // gbOrdenar
            // 
            this.gbOrdenar.Controls.Add(this.rbtnDescendente);
            this.gbOrdenar.Controls.Add(this.rbtnAscendente);
            this.gbOrdenar.Location = new System.Drawing.Point(128, 9);
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
            // rbtnONroFactura
            // 
            this.rbtnONroFactura.AutoSize = true;
            this.rbtnONroFactura.Location = new System.Drawing.Point(17, 74);
            this.rbtnONroFactura.Name = "rbtnONroFactura";
            this.rbtnONroFactura.Size = new System.Drawing.Size(96, 17);
            this.rbtnONroFactura.TabIndex = 11;
            this.rbtnONroFactura.Text = "Nro. de factura";
            this.rbtnONroFactura.UseVisualStyleBackColor = true;
            // 
            // rbtnOCodigoSocio
            // 
            this.rbtnOCodigoSocio.AutoSize = true;
            this.rbtnOCodigoSocio.Location = new System.Drawing.Point(17, 51);
            this.rbtnOCodigoSocio.Name = "rbtnOCodigoSocio";
            this.rbtnOCodigoSocio.Size = new System.Drawing.Size(101, 17);
            this.rbtnOCodigoSocio.TabIndex = 10;
            this.rbtnOCodigoSocio.Text = "Codigo de socio";
            this.rbtnOCodigoSocio.UseVisualStyleBackColor = true;
            // 
            // rbtnOApeNom
            // 
            this.rbtnOApeNom.AutoSize = true;
            this.rbtnOApeNom.Checked = true;
            this.rbtnOApeNom.Location = new System.Drawing.Point(18, 28);
            this.rbtnOApeNom.Name = "rbtnOApeNom";
            this.rbtnOApeNom.Size = new System.Drawing.Size(108, 17);
            this.rbtnOApeNom.TabIndex = 9;
            this.rbtnOApeNom.TabStop = true;
            this.rbtnOApeNom.Text = "Apellido y nombre";
            this.rbtnOApeNom.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkListConceptoParticular);
            this.groupBox2.Location = new System.Drawing.Point(275, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 232);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Concepto particular";
            // 
            // chkListConceptoParticular
            // 
            this.chkListConceptoParticular.FormattingEnabled = true;
            this.chkListConceptoParticular.Location = new System.Drawing.Point(6, 19);
            this.chkListConceptoParticular.Name = "chkListConceptoParticular";
            this.chkListConceptoParticular.Size = new System.Drawing.Size(244, 199);
            this.chkListConceptoParticular.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSalir);
            this.groupBox3.Controls.Add(this.btnGenerarListado);
            this.groupBox3.Location = new System.Drawing.Point(12, 250);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(519, 60);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(374, 19);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(139, 29);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGenerarListado
            // 
            this.btnGenerarListado.Location = new System.Drawing.Point(17, 19);
            this.btnGenerarListado.Name = "btnGenerarListado";
            this.btnGenerarListado.Size = new System.Drawing.Size(150, 29);
            this.btnGenerarListado.TabIndex = 0;
            this.btnGenerarListado.Text = "Generar Listado";
            this.btnGenerarListado.UseVisualStyleBackColor = true;
            this.btnGenerarListado.Click += new System.EventHandler(this.btnGenerarListado_Click);
            // 
            // frmCobranzasConceptosParticulares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 320);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbOrdena);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCobranzasConceptosParticulares";
            this.Text = "Cobranzas de conceptos particulares";
            this.Load += new System.EventHandler(this.frmCobranzasConceptosParticulares_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbOrdena.ResumeLayout(false);
            this.gbOrdena.PerformLayout();
            this.gbOrdenar.ResumeLayout(false);
            this.gbOrdenar.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbOrdena;
        private System.Windows.Forms.GroupBox gbOrdenar;
        private System.Windows.Forms.RadioButton rbtnDescendente;
        private System.Windows.Forms.RadioButton rbtnAscendente;
        private System.Windows.Forms.RadioButton rbtnONroFactura;
        private System.Windows.Forms.RadioButton rbtnOCodigoSocio;
        private System.Windows.Forms.RadioButton rbtnOApeNom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox chkListConceptoParticular;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGenerarListado;
    }
}