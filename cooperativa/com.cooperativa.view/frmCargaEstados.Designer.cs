namespace com.cooperativa.view
{
    partial class frmCargaEstados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargaEstados));
            this.gbMostrar = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxRutas = new System.Windows.Forms.ComboBox();
            this.cboxBarrios = new System.Windows.Forms.ComboBox();
            this.cBoxOrdenes = new System.Windows.Forms.ComboBox();
            this.gbFiltrar = new System.Windows.Forms.GroupBox();
            this.chkbSinEstadoActual = new System.Windows.Forms.CheckBox();
            this.gbOrdenarPor = new System.Windows.Forms.GroupBox();
            this.cBoxOrdenarPor = new System.Windows.Forms.ComboBox();
            this.gbDatosSocios = new System.Windows.Forms.GroupBox();
            this.txtBarrio = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtOrden = new System.Windows.Forms.TextBox();
            this.Label36 = new System.Windows.Forms.Label();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.Label37 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.mtxtNumero = new System.Windows.Forms.MaskedTextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.gbMostrar.SuspendLayout();
            this.gbFiltrar.SuspendLayout();
            this.gbOrdenarPor.SuspendLayout();
            this.gbDatosSocios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMostrar
            // 
            this.gbMostrar.Controls.Add(this.label3);
            this.gbMostrar.Controls.Add(this.label1);
            this.gbMostrar.Controls.Add(this.label2);
            this.gbMostrar.Controls.Add(this.cBoxRutas);
            this.gbMostrar.Controls.Add(this.cboxBarrios);
            this.gbMostrar.Controls.Add(this.cBoxOrdenes);
            this.gbMostrar.Location = new System.Drawing.Point(12, 12);
            this.gbMostrar.Name = "gbMostrar";
            this.gbMostrar.Size = new System.Drawing.Size(300, 82);
            this.gbMostrar.TabIndex = 5;
            this.gbMostrar.TabStop = false;
            this.gbMostrar.Text = "Mostrar...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Orden:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ruta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Barrio:";
            // 
            // cBoxRutas
            // 
            this.cBoxRutas.FormattingEnabled = true;
            this.cBoxRutas.Location = new System.Drawing.Point(53, 51);
            this.cBoxRutas.Name = "cBoxRutas";
            this.cBoxRutas.Size = new System.Drawing.Size(90, 21);
            this.cBoxRutas.TabIndex = 20;
            this.cBoxRutas.SelectedIndexChanged += new System.EventHandler(this.cbRutas_SelectedIndexChanged);
            // 
            // cboxBarrios
            // 
            this.cboxBarrios.FormattingEnabled = true;
            this.cboxBarrios.Location = new System.Drawing.Point(54, 18);
            this.cboxBarrios.Name = "cboxBarrios";
            this.cboxBarrios.Size = new System.Drawing.Size(240, 21);
            this.cboxBarrios.TabIndex = 10;
            this.cboxBarrios.SelectedIndexChanged += new System.EventHandler(this.cboxBarrios_SelectedIndexChanged);
            // 
            // cBoxOrdenes
            // 
            this.cBoxOrdenes.FormattingEnabled = true;
            this.cBoxOrdenes.Location = new System.Drawing.Point(204, 51);
            this.cBoxOrdenes.Name = "cBoxOrdenes";
            this.cBoxOrdenes.Size = new System.Drawing.Size(90, 21);
            this.cBoxOrdenes.TabIndex = 30;
            // 
            // gbFiltrar
            // 
            this.gbFiltrar.Controls.Add(this.chkbSinEstadoActual);
            this.gbFiltrar.Location = new System.Drawing.Point(318, 12);
            this.gbFiltrar.Name = "gbFiltrar";
            this.gbFiltrar.Size = new System.Drawing.Size(157, 82);
            this.gbFiltrar.TabIndex = 6;
            this.gbFiltrar.TabStop = false;
            this.gbFiltrar.Text = "Filtrar...";
            // 
            // chkbSinEstadoActual
            // 
            this.chkbSinEstadoActual.AutoSize = true;
            this.chkbSinEstadoActual.Location = new System.Drawing.Point(8, 21);
            this.chkbSinEstadoActual.Name = "chkbSinEstadoActual";
            this.chkbSinEstadoActual.Size = new System.Drawing.Size(141, 43);
            this.chkbSinEstadoActual.TabIndex = 40;
            this.chkbSinEstadoActual.Text = "Ver sólo los socios a los \r\nque les falta cargar \r\nel estado de lectura";
            this.chkbSinEstadoActual.UseVisualStyleBackColor = true;
            // 
            // gbOrdenarPor
            // 
            this.gbOrdenarPor.Controls.Add(this.cBoxOrdenarPor);
            this.gbOrdenarPor.Location = new System.Drawing.Point(481, 12);
            this.gbOrdenarPor.Name = "gbOrdenarPor";
            this.gbOrdenarPor.Size = new System.Drawing.Size(200, 82);
            this.gbOrdenarPor.TabIndex = 7;
            this.gbOrdenarPor.TabStop = false;
            this.gbOrdenarPor.Text = "Ordenar por...";
            // 
            // cBoxOrdenarPor
            // 
            this.cBoxOrdenarPor.FormattingEnabled = true;
            this.cBoxOrdenarPor.Location = new System.Drawing.Point(6, 32);
            this.cBoxOrdenarPor.Name = "cBoxOrdenarPor";
            this.cBoxOrdenarPor.Size = new System.Drawing.Size(188, 21);
            this.cBoxOrdenarPor.TabIndex = 50;
            this.cBoxOrdenarPor.SelectedIndexChanged += new System.EventHandler(this.cBoxOrdenarPor_SelectedIndexChanged);
            // 
            // gbDatosSocios
            // 
            this.gbDatosSocios.Controls.Add(this.txtBarrio);
            this.gbDatosSocios.Controls.Add(this.txtEstado);
            this.gbDatosSocios.Controls.Add(this.txtOrden);
            this.gbDatosSocios.Controls.Add(this.Label36);
            this.gbDatosSocios.Controls.Add(this.txtRuta);
            this.gbDatosSocios.Controls.Add(this.Label37);
            this.gbDatosSocios.Controls.Add(this.txtNombre);
            this.gbDatosSocios.Controls.Add(this.label4);
            this.gbDatosSocios.Controls.Add(this.Label8);
            this.gbDatosSocios.Controls.Add(this.mtxtNumero);
            this.gbDatosSocios.Controls.Add(this.Label14);
            this.gbDatosSocios.Controls.Add(this.Label7);
            this.gbDatosSocios.Enabled = false;
            this.gbDatosSocios.Location = new System.Drawing.Point(12, 100);
            this.gbDatosSocios.Name = "gbDatosSocios";
            this.gbDatosSocios.Size = new System.Drawing.Size(669, 86);
            this.gbDatosSocios.TabIndex = 8;
            this.gbDatosSocios.TabStop = false;
            this.gbDatosSocios.Text = "Datos del Socios";
            // 
            // txtBarrio
            // 
            this.txtBarrio.Location = new System.Drawing.Point(224, 53);
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.Size = new System.Drawing.Size(210, 20);
            this.txtBarrio.TabIndex = 90;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(63, 53);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(58, 20);
            this.txtEstado.TabIndex = 80;
            // 
            // txtOrden
            // 
            this.txtOrden.Location = new System.Drawing.Point(604, 53);
            this.txtOrden.Name = "txtOrden";
            this.txtOrden.Size = new System.Drawing.Size(58, 20);
            this.txtOrden.TabIndex = 110;
            // 
            // Label36
            // 
            this.Label36.AutoSize = true;
            this.Label36.Location = new System.Drawing.Point(565, 57);
            this.Label36.Name = "Label36";
            this.Label36.Size = new System.Drawing.Size(36, 13);
            this.Label36.TabIndex = 42;
            this.Label36.Text = "Orden";
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(488, 53);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(58, 20);
            this.txtRuta.TabIndex = 100;
            // 
            // Label37
            // 
            this.Label37.AutoSize = true;
            this.Label37.Location = new System.Drawing.Point(440, 57);
            this.Label37.Name = "Label37";
            this.Label37.Size = new System.Drawing.Size(45, 13);
            this.Label37.TabIndex = 40;
            this.Label37.Text = "Ruta N°";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(224, 24);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(439, 20);
            this.txtNombre.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Estado";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(172, 27);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(44, 13);
            this.Label8.TabIndex = 18;
            this.Label8.Text = "Nombre";
            // 
            // mtxtNumero
            // 
            this.mtxtNumero.Location = new System.Drawing.Point(63, 24);
            this.mtxtNumero.Mask = "000000/00";
            this.mtxtNumero.Name = "mtxtNumero";
            this.mtxtNumero.Size = new System.Drawing.Size(83, 20);
            this.mtxtNumero.TabIndex = 60;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(182, 57);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(34, 13);
            this.Label14.TabIndex = 20;
            this.Label14.Text = "Barrio";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(11, 27);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(44, 13);
            this.Label7.TabIndex = 16;
            this.Label7.Text = "Número";
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(12, 192);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.Size = new System.Drawing.Size(669, 235);
            this.dgvDatos.TabIndex = 120;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            // 
            // frmCargaEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 439);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.gbDatosSocios);
            this.Controls.Add(this.gbOrdenarPor);
            this.Controls.Add(this.gbFiltrar);
            this.Controls.Add(this.gbMostrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(710, 477);
            this.Name = "frmCargaEstados";
            this.Text = "Carga de Toma Estados";
            this.Load += new System.EventHandler(this.frmCargaEstados_Load);
            this.gbMostrar.ResumeLayout(false);
            this.gbMostrar.PerformLayout();
            this.gbFiltrar.ResumeLayout(false);
            this.gbFiltrar.PerformLayout();
            this.gbOrdenarPor.ResumeLayout(false);
            this.gbDatosSocios.ResumeLayout(false);
            this.gbDatosSocios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMostrar;
        private System.Windows.Forms.GroupBox gbFiltrar;
        private System.Windows.Forms.GroupBox gbOrdenarPor;
        private System.Windows.Forms.ComboBox cBoxRutas;
        private System.Windows.Forms.ComboBox cboxBarrios;
        private System.Windows.Forms.ComboBox cBoxOrdenes;
        private System.Windows.Forms.ComboBox cBoxOrdenarPor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkbSinEstadoActual;
        private System.Windows.Forms.GroupBox gbDatosSocios;
        internal System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.MaskedTextBox mtxtNumero;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtOrden;
        internal System.Windows.Forms.Label Label36;
        internal System.Windows.Forms.TextBox txtRuta;
        internal System.Windows.Forms.Label Label37;
        internal System.Windows.Forms.TextBox txtEstado;
        internal System.Windows.Forms.TextBox txtBarrio;
        private System.Windows.Forms.DataGridView dgvDatos;
    }
}