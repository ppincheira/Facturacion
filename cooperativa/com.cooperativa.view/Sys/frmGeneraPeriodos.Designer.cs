namespace com.cooperativa.view.Sys
{
    partial class frmGeneraPeriodos
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
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pgbProgreso = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrimerVenc = new System.Windows.Forms.TextBox();
            this.txtDiasEntre = new System.Windows.Forms.TextBox();
            this.mtbDesde = new System.Windows.Forms.MaskedTextBox();
            this.mtbHasta = new System.Windows.Forms.MaskedTextBox();
            this.gbPeriodos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPeriodos
            // 
            this.gbPeriodos.Controls.Add(this.mtbHasta);
            this.gbPeriodos.Controls.Add(this.mtbDesde);
            this.gbPeriodos.Controls.Add(this.txtDiasEntre);
            this.gbPeriodos.Controls.Add(this.txtPrimerVenc);
            this.gbPeriodos.Controls.Add(this.btnGenerar);
            this.gbPeriodos.Controls.Add(this.label5);
            this.gbPeriodos.Controls.Add(this.label4);
            this.gbPeriodos.Controls.Add(this.pgbProgreso);
            this.gbPeriodos.Controls.Add(this.label3);
            this.gbPeriodos.Controls.Add(this.label1);
            this.gbPeriodos.Location = new System.Drawing.Point(12, 12);
            this.gbPeriodos.Name = "gbPeriodos";
            this.gbPeriodos.Size = new System.Drawing.Size(459, 250);
            this.gbPeriodos.TabIndex = 0;
            this.gbPeriodos.TabStop = false;
            this.gbPeriodos.Text = "Periodos";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(171, 151);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(110, 23);
            this.btnGenerar.TabIndex = 32;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Dias Entre Vencimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Periodo Hasta:";
            // 
            // pgbProgreso
            // 
            this.pgbProgreso.Location = new System.Drawing.Point(38, 194);
            this.pgbProgreso.Name = "pgbProgreso";
            this.pgbProgreso.Size = new System.Drawing.Size(383, 23);
            this.pgbProgreso.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Periodo Desde:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Primer Vencimiento:";
            // 
            // txtPrimerVenc
            // 
            this.txtPrimerVenc.Location = new System.Drawing.Point(111, 80);
            this.txtPrimerVenc.Name = "txtPrimerVenc";
            this.txtPrimerVenc.Size = new System.Drawing.Size(52, 20);
            this.txtPrimerVenc.TabIndex = 33;
            // 
            // txtDiasEntre
            // 
            this.txtDiasEntre.Location = new System.Drawing.Point(344, 77);
            this.txtDiasEntre.Name = "txtDiasEntre";
            this.txtDiasEntre.Size = new System.Drawing.Size(52, 20);
            this.txtDiasEntre.TabIndex = 34;
            // 
            // mtbDesde
            // 
            this.mtbDesde.Location = new System.Drawing.Point(113, 35);
            this.mtbDesde.Mask = "0000-00";
            this.mtbDesde.Name = "mtbDesde";
            this.mtbDesde.Size = new System.Drawing.Size(50, 20);
            this.mtbDesde.TabIndex = 38;
            // 
            // mtbHasta
            // 
            this.mtbHasta.Location = new System.Drawing.Point(344, 35);
            this.mtbHasta.Mask = "0000-00";
            this.mtbHasta.Name = "mtbHasta";
            this.mtbHasta.Size = new System.Drawing.Size(50, 20);
            this.mtbHasta.TabIndex = 39;
            // 
            // frmGeneraPeriodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 274);
            this.Controls.Add(this.gbPeriodos);
            this.Name = "frmGeneraPeriodos";
            this.Text = "Periodos";
            this.Load += new System.EventHandler(this.frmPeriodos_Load);
            this.gbPeriodos.ResumeLayout(false);
            this.gbPeriodos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPeriodos;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar pgbProgreso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiasEntre;
        private System.Windows.Forms.TextBox txtPrimerVenc;
        private System.Windows.Forms.MaskedTextBox mtbHasta;
        private System.Windows.Forms.MaskedTextBox mtbDesde;
    }
}