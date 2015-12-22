namespace Importador
{
    partial class frmImportar
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
            this.btnImportar = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.pgbProgreso = new System.Windows.Forms.ProgressBar();
            this.btnSalir = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.chkLimpiarTablas = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chklbTablas = new System.Windows.Forms.CheckedListBox();
            this.lblTodos = new System.Windows.Forms.Label();
            this.lblNinguno = new System.Windows.Forms.Label();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAcces = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(12, 12);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(75, 23);
            this.btnImportar.TabIndex = 0;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResultado.Location = new System.Drawing.Point(157, 88);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(533, 341);
            this.txtResultado.TabIndex = 1;
            // 
            // pgbProgreso
            // 
            this.pgbProgreso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pgbProgreso.Location = new System.Drawing.Point(93, 12);
            this.pgbProgreso.Name = "pgbProgreso";
            this.pgbProgreso.Size = new System.Drawing.Size(516, 23);
            this.pgbProgreso.TabIndex = 2;
            this.pgbProgreso.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(615, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(154, 72);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(55, 13);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Resultado";
            // 
            // chkLimpiarTablas
            // 
            this.chkLimpiarTablas.AutoSize = true;
            this.chkLimpiarTablas.Checked = true;
            this.chkLimpiarTablas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLimpiarTablas.Location = new System.Drawing.Point(12, 41);
            this.chkLimpiarTablas.Name = "chkLimpiarTablas";
            this.chkLimpiarTablas.Size = new System.Drawing.Size(174, 17);
            this.chkLimpiarTablas.TabIndex = 5;
            this.chkLimpiarTablas.Text = "Limpiar tablas antes de importar";
            this.chkLimpiarTablas.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tablas a importar";
            // 
            // chklbTablas
            // 
            this.chklbTablas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.chklbTablas.CheckOnClick = true;
            this.chklbTablas.FormattingEnabled = true;
            this.chklbTablas.Location = new System.Drawing.Point(12, 88);
            this.chklbTablas.Name = "chklbTablas";
            this.chklbTablas.Size = new System.Drawing.Size(139, 334);
            this.chklbTablas.TabIndex = 8;
            // 
            // lblTodos
            // 
            this.lblTodos.AutoSize = true;
            this.lblTodos.Font = new System.Drawing.Font("Wingdings", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblTodos.Location = new System.Drawing.Point(115, 72);
            this.lblTodos.Name = "lblTodos";
            this.lblTodos.Size = new System.Drawing.Size(19, 15);
            this.lblTodos.TabIndex = 9;
            this.lblTodos.Text = "þ";
            this.lblTodos.Click += new System.EventHandler(this.lblTodos_Click);
            // 
            // lblNinguno
            // 
            this.lblNinguno.AutoSize = true;
            this.lblNinguno.Font = new System.Drawing.Font("Wingdings", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblNinguno.Location = new System.Drawing.Point(132, 72);
            this.lblNinguno.Name = "lblNinguno";
            this.lblNinguno.Size = new System.Drawing.Size(19, 15);
            this.lblNinguno.TabIndex = 10;
            this.lblNinguno.Text = "¨";
            this.lblNinguno.Click += new System.EventHandler(this.lblNinguno_Click);
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(396, 62);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(54, 20);
            this.txtDesde.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Desde:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Hasta:";
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(501, 62);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(54, 20);
            this.txtHasta.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtAcces);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(12, 444);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 35);
            this.panel1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cadena ACCES:";
            // 
            // txtAcces
            // 
            this.txtAcces.Location = new System.Drawing.Point(115, 6);
            this.txtAcces.Name = "txtAcces";
            this.txtAcces.Size = new System.Drawing.Size(560, 20);
            this.txtAcces.TabIndex = 15;
            // 
            // frmImportar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 485);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.lblNinguno);
            this.Controls.Add(this.lblTodos);
            this.Controls.Add(this.chklbTablas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkLimpiarTablas);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pgbProgreso);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnImportar);
            this.Name = "frmImportar";
            this.Text = "Importador de tablas del sistema anterior (Coop.mdb)";
            this.Load += new System.EventHandler(this.frmImportar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.ProgressBar pgbProgreso;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.CheckBox chkLimpiarTablas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox chklbTablas;
        private System.Windows.Forms.Label lblTodos;
        private System.Windows.Forms.Label lblNinguno;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAcces;
        private System.Windows.Forms.Label label6;
    }
}

