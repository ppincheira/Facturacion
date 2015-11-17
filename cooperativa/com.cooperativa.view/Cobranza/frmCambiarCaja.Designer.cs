namespace com.cooperativa.view.Cobranza
{
    partial class frmCambiarCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCambiarCaja));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCajaActual = new System.Windows.Forms.TextBox();
            this.cmbCajaNueva = new System.Windows.Forms.ComboBox();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCajaActualDescripcion = new System.Windows.Forms.TextBox();
            this.txtCajaNuevaDescripcion = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de caja actual";
            // 
            // txtCajaActual
            // 
            this.txtCajaActual.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCajaActual.Location = new System.Drawing.Point(161, 23);
            this.txtCajaActual.Name = "txtCajaActual";
            this.txtCajaActual.ReadOnly = true;
            this.txtCajaActual.Size = new System.Drawing.Size(67, 20);
            this.txtCajaActual.TabIndex = 1;
            // 
            // cmbCajaNueva
            // 
            this.cmbCajaNueva.FormattingEnabled = true;
            this.cmbCajaNueva.Location = new System.Drawing.Point(161, 63);
            this.cmbCajaNueva.Name = "cmbCajaNueva";
            this.cmbCajaNueva.Size = new System.Drawing.Size(67, 21);
            this.cmbCajaNueva.TabIndex = 2;
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(143, 112);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(89, 31);
            this.btnCambiar.TabIndex = 3;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nuevo número de caja";
            // 
            // txtCajaActualDescripcion
            // 
            this.txtCajaActualDescripcion.Location = new System.Drawing.Point(234, 23);
            this.txtCajaActualDescripcion.Name = "txtCajaActualDescripcion";
            this.txtCajaActualDescripcion.ReadOnly = true;
            this.txtCajaActualDescripcion.Size = new System.Drawing.Size(201, 20);
            this.txtCajaActualDescripcion.TabIndex = 5;
            // 
            // txtCajaNuevaDescripcion
            // 
            this.txtCajaNuevaDescripcion.Location = new System.Drawing.Point(234, 64);
            this.txtCajaNuevaDescripcion.Name = "txtCajaNuevaDescripcion";
            this.txtCajaNuevaDescripcion.ReadOnly = true;
            this.txtCajaNuevaDescripcion.Size = new System.Drawing.Size(201, 20);
            this.txtCajaNuevaDescripcion.TabIndex = 6;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(269, 112);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 31);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCambiarCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 160);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtCajaNuevaDescripcion);
            this.Controls.Add(this.txtCajaActualDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.cmbCajaNueva);
            this.Controls.Add(this.txtCajaActual);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCambiarCaja";
            this.Text = "frmCambiarCaja";
            this.Load += new System.EventHandler(this.frmCambiarCaja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCajaActual;
        private System.Windows.Forms.ComboBox cmbCajaNueva;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCajaActualDescripcion;
        private System.Windows.Forms.TextBox txtCajaNuevaDescripcion;
        private System.Windows.Forms.Button btnCancelar;
    }
}