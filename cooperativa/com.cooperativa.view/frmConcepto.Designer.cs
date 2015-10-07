namespace com.cooperativa.view
{
    partial class frmConcepto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConcepto));
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.chkAplicaDescuento = new System.Windows.Forms.CheckBox();
            this.chkAplicaCargo = new System.Windows.Forms.CheckBox();
            this.chkAplicaIva = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVigenciaDesde = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbAplicacion = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSigno = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVariable = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbFormula = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvConceptos = new System.Windows.Forms.DataGridView();
            this.id_barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Variable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Signo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aplicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vigencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AplicarIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AplicarRecargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AplicarDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsbImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAceptar = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConceptos)).BeginInit();
            this.tsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.chkAplicaDescuento);
            this.gbDatos.Controls.Add(this.chkAplicaCargo);
            this.gbDatos.Controls.Add(this.chkAplicaIva);
            this.gbDatos.Controls.Add(this.label10);
            this.gbDatos.Controls.Add(this.txtDuracion);
            this.gbDatos.Controls.Add(this.label9);
            this.gbDatos.Controls.Add(this.txtVigenciaDesde);
            this.gbDatos.Controls.Add(this.label8);
            this.gbDatos.Controls.Add(this.cmbAplicacion);
            this.gbDatos.Controls.Add(this.label7);
            this.gbDatos.Controls.Add(this.cmbSigno);
            this.gbDatos.Controls.Add(this.label6);
            this.gbDatos.Controls.Add(this.txtVariable);
            this.gbDatos.Controls.Add(this.label5);
            this.gbDatos.Controls.Add(this.cmbFormula);
            this.gbDatos.Controls.Add(this.label4);
            this.gbDatos.Controls.Add(this.cmbEstado);
            this.gbDatos.Controls.Add(this.label3);
            this.gbDatos.Controls.Add(this.lblCodigo);
            this.gbDatos.Controls.Add(this.txtDescripcion);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Location = new System.Drawing.Point(12, 42);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(615, 181);
            this.gbDatos.TabIndex = 9;
            this.gbDatos.TabStop = false;
            // 
            // chkAplicaDescuento
            // 
            this.chkAplicaDescuento.AutoSize = true;
            this.chkAplicaDescuento.Location = new System.Drawing.Point(438, 154);
            this.chkAplicaDescuento.Name = "chkAplicaDescuento";
            this.chkAplicaDescuento.Size = new System.Drawing.Size(170, 17);
            this.chkAplicaDescuento.TabIndex = 110;
            this.chkAplicaDescuento.Text = "Aplicar descuento al concepto";
            this.chkAplicaDescuento.UseVisualStyleBackColor = true;
            // 
            // chkAplicaCargo
            // 
            this.chkAplicaCargo.AutoSize = true;
            this.chkAplicaCargo.Location = new System.Drawing.Point(261, 154);
            this.chkAplicaCargo.Name = "chkAplicaCargo";
            this.chkAplicaCargo.Size = new System.Drawing.Size(147, 17);
            this.chkAplicaCargo.TabIndex = 100;
            this.chkAplicaCargo.Text = "Aplicar cargo al concepto";
            this.chkAplicaCargo.UseVisualStyleBackColor = true;
            // 
            // chkAplicaIva
            // 
            this.chkAplicaIva.AutoSize = true;
            this.chkAplicaIva.Location = new System.Drawing.Point(94, 154);
            this.chkAplicaIva.Name = "chkAplicaIva";
            this.chkAplicaIva.Size = new System.Drawing.Size(137, 17);
            this.chkAplicaIva.TabIndex = 90;
            this.chkAplicaIva.Text = "Aplicar IVA al concepto";
            this.chkAplicaIva.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(544, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Meses";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(488, 124);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(48, 20);
            this.txtDuracion.TabIndex = 80;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(431, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Duración:";
            // 
            // txtVigenciaDesde
            // 
            this.txtVigenciaDesde.Location = new System.Drawing.Point(320, 124);
            this.txtVigenciaDesde.Name = "txtVigenciaDesde";
            this.txtVigenciaDesde.Size = new System.Drawing.Size(100, 20);
            this.txtVigenciaDesde.TabIndex = 70;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(230, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Vigencia Desde:";
            // 
            // cmbAplicacion
            // 
            this.cmbAplicacion.FormattingEnabled = true;
            this.cmbAplicacion.Items.AddRange(new object[] {
            "Permanente",
            "Temporal",
            "Particular"});
            this.cmbAplicacion.Location = new System.Drawing.Point(86, 124);
            this.cmbAplicacion.Name = "cmbAplicacion";
            this.cmbAplicacion.Size = new System.Drawing.Size(121, 21);
            this.cmbAplicacion.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Aplicación:";
            // 
            // cmbSigno
            // 
            this.cmbSigno.FormattingEnabled = true;
            this.cmbSigno.Location = new System.Drawing.Point(488, 96);
            this.cmbSigno.Name = "cmbSigno";
            this.cmbSigno.Size = new System.Drawing.Size(121, 21);
            this.cmbSigno.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(447, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Signo:";
            // 
            // txtVariable
            // 
            this.txtVariable.Location = new System.Drawing.Point(86, 96);
            this.txtVariable.Name = "txtVariable";
            this.txtVariable.Size = new System.Drawing.Size(100, 20);
            this.txtVariable.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Variable:";
            // 
            // cmbFormula
            // 
            this.cmbFormula.FormattingEnabled = true;
            this.cmbFormula.Location = new System.Drawing.Point(86, 68);
            this.cmbFormula.Name = "cmbFormula";
            this.cmbFormula.Size = new System.Drawing.Size(262, 21);
            this.cmbFormula.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fórmula:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(488, 40);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 21);
            this.cmbEstado.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estado:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(72, 20);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(0, 13);
            this.lblCodigo.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(86, 40);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(262, 20);
            this.txtDescripcion.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // dgvConceptos
            // 
            this.dgvConceptos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConceptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConceptos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_barrio,
            this.concepto,
            this.estado,
            this.formula,
            this.Variable,
            this.Signo,
            this.Aplicacion,
            this.Vigencia,
            this.Duracion,
            this.AplicarIVA,
            this.AplicarRecargo,
            this.AplicarDescuento});
            this.dgvConceptos.Location = new System.Drawing.Point(12, 229);
            this.dgvConceptos.Name = "dgvConceptos";
            this.dgvConceptos.ReadOnly = true;
            this.dgvConceptos.Size = new System.Drawing.Size(710, 200);
            this.dgvConceptos.TabIndex = 120;
            // 
            // id_barrio
            // 
            this.id_barrio.DataPropertyName = "id_concepto";
            this.id_barrio.HeaderText = "Codigo";
            this.id_barrio.Name = "id_barrio";
            this.id_barrio.ReadOnly = true;
            this.id_barrio.Width = 50;
            // 
            // concepto
            // 
            this.concepto.DataPropertyName = "concepto";
            this.concepto.HeaderText = "Descripción";
            this.concepto.Name = "concepto";
            this.concepto.ReadOnly = true;
            this.concepto.Width = 200;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // formula
            // 
            this.formula.DataPropertyName = "formula";
            this.formula.HeaderText = "formula";
            this.formula.Name = "formula";
            this.formula.ReadOnly = true;
            // 
            // Variable
            // 
            this.Variable.DataPropertyName = "variable";
            this.Variable.HeaderText = "Variable";
            this.Variable.Name = "Variable";
            this.Variable.ReadOnly = true;
            // 
            // Signo
            // 
            this.Signo.DataPropertyName = "signo";
            this.Signo.FillWeight = 70F;
            this.Signo.HeaderText = "Signo";
            this.Signo.Name = "Signo";
            this.Signo.ReadOnly = true;
            this.Signo.Width = 70;
            // 
            // Aplicacion
            // 
            this.Aplicacion.DataPropertyName = "aplicacion";
            this.Aplicacion.HeaderText = "Aplicación";
            this.Aplicacion.Name = "Aplicacion";
            this.Aplicacion.ReadOnly = true;
            // 
            // Vigencia
            // 
            this.Vigencia.DataPropertyName = "vigencia";
            this.Vigencia.HeaderText = "Vigencia";
            this.Vigencia.Name = "Vigencia";
            this.Vigencia.ReadOnly = true;
            // 
            // Duracion
            // 
            this.Duracion.DataPropertyName = "duracion";
            this.Duracion.HeaderText = "Duración";
            this.Duracion.Name = "Duracion";
            this.Duracion.ReadOnly = true;
            // 
            // AplicarIVA
            // 
            this.AplicarIVA.DataPropertyName = "aplicariva";
            this.AplicarIVA.HeaderText = "Aplicar IVA";
            this.AplicarIVA.Name = "AplicarIVA";
            this.AplicarIVA.ReadOnly = true;
            // 
            // AplicarRecargo
            // 
            this.AplicarRecargo.DataPropertyName = "aplicarrecargo";
            this.AplicarRecargo.HeaderText = "Aplicar Recargo";
            this.AplicarRecargo.MinimumWidth = 80;
            this.AplicarRecargo.Name = "AplicarRecargo";
            this.AplicarRecargo.ReadOnly = true;
            this.AplicarRecargo.Width = 80;
            // 
            // AplicarDescuento
            // 
            this.AplicarDescuento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AplicarDescuento.DataPropertyName = "aplicarDescuento";
            this.AplicarDescuento.HeaderText = "Aplicar Descuento";
            this.AplicarDescuento.MinimumWidth = 80;
            this.AplicarDescuento.Name = "AplicarDescuento";
            this.AplicarDescuento.ReadOnly = true;
            // 
            // tsMenu
            // 
            this.tsMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbModificar,
            this.tsbEliminar,
            this.tsbImprimir,
            this.toolStripSeparator1,
            this.tsbAceptar,
            this.tsbCancelar});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(734, 39);
            this.tsMenu.TabIndex = 8;
            this.tsMenu.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = global::com.cooperativa.view.Properties.Resources.nuevo32;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(36, 36);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbModificar
            // 
            this.tsbModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModificar.Image = global::com.cooperativa.view.Properties.Resources.editar32;
            this.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Size = new System.Drawing.Size(36, 36);
            this.tsbModificar.Text = "Modificar";
            this.tsbModificar.Click += new System.EventHandler(this.tsbModificar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = global::com.cooperativa.view.Properties.Resources.eliminar32;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(36, 36);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // tsbImprimir
            // 
            this.tsbImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbImprimir.Image = global::com.cooperativa.view.Properties.Resources.imprimir32;
            this.tsbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImprimir.Name = "tsbImprimir";
            this.tsbImprimir.Size = new System.Drawing.Size(36, 36);
            this.tsbImprimir.Text = "Imprimir";
            this.tsbImprimir.Click += new System.EventHandler(this.tsbImprimir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbAceptar
            // 
            this.tsbAceptar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAceptar.Image = global::com.cooperativa.view.Properties.Resources.save;
            this.tsbAceptar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAceptar.Name = "tsbAceptar";
            this.tsbAceptar.Size = new System.Drawing.Size(36, 36);
            this.tsbAceptar.Text = "Aceptar";
            this.tsbAceptar.ToolTipText = "Aceptar";
            this.tsbAceptar.Click += new System.EventHandler(this.tsbAceptar_Click);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCancelar.Image = global::com.cooperativa.view.Properties.Resources.stop;
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(36, 36);
            this.tsbCancelar.Text = "Cancelar";
            this.tsbCancelar.Click += new System.EventHandler(this.tsbCancelar_Click);
            // 
            // frmConcepto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 441);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.dgvConceptos);
            this.Controls.Add(this.tsMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConcepto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conceptos";
            this.Load += new System.EventHandler(this.frmConcepto_Load);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConceptos)).EndInit();
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVigenciaDesde;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbAplicacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSigno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVariable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbFormula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvConceptos;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.ToolStripButton tsbImprimir;
        private System.Windows.Forms.CheckBox chkAplicaIva;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkAplicaDescuento;
        private System.Windows.Forms.CheckBox chkAplicaCargo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbAceptar;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn formula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Variable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Signo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aplicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vigencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn AplicarIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn AplicarRecargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AplicarDescuento;
    }
}