namespace com.cooperativa.view
{
    partial class frmAccionesAM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccionesAM));
            this.gbAccion = new System.Windows.Forms.GroupBox();
            this.txtCuotasAbonadas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtImporteTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValorCuotas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCuotas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbAccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAccion
            // 
            this.gbAccion.Controls.Add(this.txtCuotasAbonadas);
            this.gbAccion.Controls.Add(this.label5);
            this.gbAccion.Controls.Add(this.txtImporteTotal);
            this.gbAccion.Controls.Add(this.label4);
            this.gbAccion.Controls.Add(this.txtValorCuotas);
            this.gbAccion.Controls.Add(this.label3);
            this.gbAccion.Controls.Add(this.txtCuotas);
            this.gbAccion.Controls.Add(this.label2);
            this.gbAccion.Controls.Add(this.dtpFecha);
            this.gbAccion.Controls.Add(this.label1);
            this.gbAccion.Location = new System.Drawing.Point(8, 12);
            this.gbAccion.Name = "gbAccion";
            this.gbAccion.Size = new System.Drawing.Size(220, 154);
            this.gbAccion.TabIndex = 0;
            this.gbAccion.TabStop = false;
            this.gbAccion.Text = "Acción";
            // 
            // txtCuotasAbonadas
            // 
            this.txtCuotasAbonadas.Location = new System.Drawing.Point(124, 118);
            this.txtCuotasAbonadas.Name = "txtCuotasAbonadas";
            this.txtCuotasAbonadas.Size = new System.Drawing.Size(83, 20);
            this.txtCuotasAbonadas.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Cuotas abonadas:";
            // 
            // txtImporteTotal
            // 
            this.txtImporteTotal.Location = new System.Drawing.Point(124, 66);
            this.txtImporteTotal.Name = "txtImporteTotal";
            this.txtImporteTotal.Size = new System.Drawing.Size(83, 20);
            this.txtImporteTotal.TabIndex = 3;
            this.txtImporteTotal.TextChanged += new System.EventHandler(this.txtImporteTotal_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Importe total:";
            // 
            // txtValorCuotas
            // 
            this.txtValorCuotas.Enabled = false;
            this.txtValorCuotas.Location = new System.Drawing.Point(124, 92);
            this.txtValorCuotas.Name = "txtValorCuotas";
            this.txtValorCuotas.Size = new System.Drawing.Size(83, 20);
            this.txtValorCuotas.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Valor cuotas:";
            // 
            // txtCuotas
            // 
            this.txtCuotas.Location = new System.Drawing.Point(124, 40);
            this.txtCuotas.Name = "txtCuotas";
            this.txtCuotas.Size = new System.Drawing.Size(83, 20);
            this.txtCuotas.TabIndex = 2;
            this.txtCuotas.TextChanged += new System.EventHandler(this.txtCuotas_TextChanged);
            this.txtCuotas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuotas_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Cuotas:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(124, 15);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(83, 20);
            this.dtpFecha.TabIndex = 1;
            this.dtpFecha.Value = new System.DateTime(2013, 11, 30, 16, 40, 25, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha de Suscripción:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(8, 173);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(96, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(132, 173);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmAccionesAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 205);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gbAccion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAccionesAM";
            this.Text = "frmAccionesAM";
            this.Load += new System.EventHandler(this.frmAccionesAM_Load);
            this.gbAccion.ResumeLayout(false);
            this.gbAccion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAccion;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtCuotasAbonadas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtImporteTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValorCuotas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCuotas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}