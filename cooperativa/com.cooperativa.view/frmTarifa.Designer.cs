namespace com.cooperativa.view
{
    partial class frmTarifa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTarifa));
            this.gbTarifa = new System.Windows.Forms.GroupBox();
            this.txtMeses = new System.Windows.Forms.TextBox();
            this.chkVencimiento = new System.Windows.Forms.CheckBox();
            this.CHKUsuarioResidencial = new System.Windows.Forms.CheckBox();
            this.chkBonicacion = new System.Windows.Forms.CheckBox();
            this.chkAplicarRecargo = new System.Windows.Forms.CheckBox();
            this.chkTarifaActiva = new System.Windows.Forms.CheckBox();
            this.txtAbono = new System.Windows.Forms.TextBox();
            this.txtM3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCargoFijo = new System.Windows.Forms.TextBox();
            this.txtAbreviatura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtTarifa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTarifa = new System.Windows.Forms.DataGridView();
            this.id_Tarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abreviatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo_fijo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_M3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario_Residencial = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Bonificacion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.recargo_minimo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.requiere_fin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.meses_venc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tipo_abono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsbImprimir = new System.Windows.Forms.ToolStripButton();
            this.tsbAceptar = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.gbTarifa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifa)).BeginInit();
            this.tsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTarifa
            // 
            this.gbTarifa.Controls.Add(this.txtMeses);
            this.gbTarifa.Controls.Add(this.chkVencimiento);
            this.gbTarifa.Controls.Add(this.CHKUsuarioResidencial);
            this.gbTarifa.Controls.Add(this.chkBonicacion);
            this.gbTarifa.Controls.Add(this.chkAplicarRecargo);
            this.gbTarifa.Controls.Add(this.chkTarifaActiva);
            this.gbTarifa.Controls.Add(this.txtAbono);
            this.gbTarifa.Controls.Add(this.txtM3);
            this.gbTarifa.Controls.Add(this.label7);
            this.gbTarifa.Controls.Add(this.label6);
            this.gbTarifa.Controls.Add(this.label5);
            this.gbTarifa.Controls.Add(this.label4);
            this.gbTarifa.Controls.Add(this.txtCargoFijo);
            this.gbTarifa.Controls.Add(this.txtAbreviatura);
            this.gbTarifa.Controls.Add(this.label3);
            this.gbTarifa.Controls.Add(this.lblCodigo);
            this.gbTarifa.Controls.Add(this.txtTarifa);
            this.gbTarifa.Controls.Add(this.label2);
            this.gbTarifa.Controls.Add(this.label1);
            this.gbTarifa.Location = new System.Drawing.Point(12, 42);
            this.gbTarifa.Name = "gbTarifa";
            this.gbTarifa.Size = new System.Drawing.Size(578, 195);
            this.gbTarifa.TabIndex = 9;
            this.gbTarifa.TabStop = false;
            // 
            // txtMeses
            // 
            this.txtMeses.Location = new System.Drawing.Point(490, 100);
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.Size = new System.Drawing.Size(39, 20);
            this.txtMeses.TabIndex = 18;
            // 
            // chkVencimiento
            // 
            this.chkVencimiento.AutoSize = true;
            this.chkVencimiento.Location = new System.Drawing.Point(351, 102);
            this.chkVencimiento.Name = "chkVencimiento";
            this.chkVencimiento.Size = new System.Drawing.Size(141, 17);
            this.chkVencimiento.TabIndex = 17;
            this.chkVencimiento.Text = "Tiene vencimiento a los ";
            this.chkVencimiento.UseVisualStyleBackColor = true;
            // 
            // CHKUsuarioResidencial
            // 
            this.CHKUsuarioResidencial.AutoSize = true;
            this.CHKUsuarioResidencial.Location = new System.Drawing.Point(72, 168);
            this.CHKUsuarioResidencial.Name = "CHKUsuarioResidencial";
            this.CHKUsuarioResidencial.Size = new System.Drawing.Size(265, 17);
            this.CHKUsuarioResidencial.TabIndex = 16;
            this.CHKUsuarioResidencial.Text = "Usuario Residencial (Se descrimina IVA para AFIP)";
            this.CHKUsuarioResidencial.UseVisualStyleBackColor = true;
            // 
            // chkBonicacion
            // 
            this.chkBonicacion.AutoSize = true;
            this.chkBonicacion.Location = new System.Drawing.Point(72, 146);
            this.chkBonicacion.Name = "chkBonicacion";
            this.chkBonicacion.Size = new System.Drawing.Size(181, 17);
            this.chkBonicacion.TabIndex = 15;
            this.chkBonicacion.Text = "Bonificación por pago anticipado";
            this.chkBonicacion.UseVisualStyleBackColor = true;
            // 
            // chkAplicarRecargo
            // 
            this.chkAplicarRecargo.AutoSize = true;
            this.chkAplicarRecargo.Location = new System.Drawing.Point(72, 124);
            this.chkAplicarRecargo.Name = "chkAplicarRecargo";
            this.chkAplicarRecargo.Size = new System.Drawing.Size(102, 17);
            this.chkAplicarRecargo.TabIndex = 14;
            this.chkAplicarRecargo.Text = "Aplicar Recargo";
            this.chkAplicarRecargo.UseVisualStyleBackColor = true;
            // 
            // chkTarifaActiva
            // 
            this.chkTarifaActiva.AutoSize = true;
            this.chkTarifaActiva.Location = new System.Drawing.Point(72, 102);
            this.chkTarifaActiva.Name = "chkTarifaActiva";
            this.chkTarifaActiva.Size = new System.Drawing.Size(238, 17);
            this.chkTarifaActiva.TabIndex = 13;
            this.chkTarifaActiva.Text = "Tarifa Activa(Puede ser asignada a un socio)";
            this.chkTarifaActiva.UseVisualStyleBackColor = true;
            // 
            // txtAbono
            // 
            this.txtAbono.Location = new System.Drawing.Point(489, 73);
            this.txtAbono.Name = "txtAbono";
            this.txtAbono.Size = new System.Drawing.Size(78, 20);
            this.txtAbono.TabIndex = 12;
            // 
            // txtM3
            // 
            this.txtM3.Location = new System.Drawing.Point(267, 73);
            this.txtM3.Name = "txtM3";
            this.txtM3.Size = new System.Drawing.Size(67, 20);
            this.txtM3.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Cargo Fijo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(446, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Abono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(532, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Meses";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor por M3:";
            // 
            // txtCargoFijo
            // 
            this.txtCargoFijo.Location = new System.Drawing.Point(72, 73);
            this.txtCargoFijo.Name = "txtCargoFijo";
            this.txtCargoFijo.Size = new System.Drawing.Size(67, 20);
            this.txtCargoFijo.TabIndex = 6;
            // 
            // txtAbreviatura
            // 
            this.txtAbreviatura.Location = new System.Drawing.Point(489, 45);
            this.txtAbreviatura.Name = "txtAbreviatura";
            this.txtAbreviatura.Size = new System.Drawing.Size(78, 20);
            this.txtAbreviatura.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Abreviatura:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(72, 20);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(0, 13);
            this.lblCodigo.TabIndex = 3;
            // 
            // txtTarifa
            // 
            this.txtTarifa.Location = new System.Drawing.Point(72, 45);
            this.txtTarifa.Name = "txtTarifa";
            this.txtTarifa.Size = new System.Drawing.Size(262, 20);
            this.txtTarifa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tarifa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // dgvTarifa
            // 
            this.dgvTarifa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTarifa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTarifa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarifa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Tarifa,
            this.Tarifa,
            this.abreviatura,
            this.cargo_fijo,
            this.valor_M3,
            this.Abono,
            this.usuario_Residencial,
            this.Bonificacion,
            this.recargo_minimo,
            this.requiere_fin,
            this.meses_venc,
            this.activa,
            this.tipo_abono});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTarifa.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTarifa.Location = new System.Drawing.Point(12, 250);
            this.dgvTarifa.Name = "dgvTarifa";
            this.dgvTarifa.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTarifa.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTarifa.Size = new System.Drawing.Size(706, 231);
            this.dgvTarifa.TabIndex = 7;
            this.dgvTarifa.SelectionChanged += new System.EventHandler(this.dgvTarifa_SelectionChanged);
            // 
            // id_Tarifa
            // 
            this.id_Tarifa.DataPropertyName = "id_Tarifa";
            this.id_Tarifa.HeaderText = "Codigo";
            this.id_Tarifa.Name = "id_Tarifa";
            this.id_Tarifa.ReadOnly = true;
            this.id_Tarifa.Width = 45;
            // 
            // Tarifa
            // 
            this.Tarifa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tarifa.DataPropertyName = "Tarifa";
            this.Tarifa.HeaderText = "Tarifa";
            this.Tarifa.Name = "Tarifa";
            this.Tarifa.ReadOnly = true;
            // 
            // abreviatura
            // 
            this.abreviatura.DataPropertyName = "abreviatura";
            this.abreviatura.HeaderText = "Abrev";
            this.abreviatura.Name = "abreviatura";
            this.abreviatura.ReadOnly = true;
            this.abreviatura.Width = 40;
            // 
            // cargo_fijo
            // 
            this.cargo_fijo.DataPropertyName = "cargo_fijo";
            this.cargo_fijo.HeaderText = "Cargo Fijo";
            this.cargo_fijo.Name = "cargo_fijo";
            this.cargo_fijo.ReadOnly = true;
            this.cargo_fijo.Width = 50;
            // 
            // valor_M3
            // 
            this.valor_M3.DataPropertyName = "valor_M3";
            this.valor_M3.HeaderText = "Valor M3";
            this.valor_M3.Name = "valor_M3";
            this.valor_M3.ReadOnly = true;
            this.valor_M3.Width = 50;
            // 
            // Abono
            // 
            this.Abono.DataPropertyName = "abono";
            this.Abono.HeaderText = "Abono";
            this.Abono.Name = "Abono";
            this.Abono.ReadOnly = true;
            this.Abono.Width = 50;
            // 
            // usuario_Residencial
            // 
            this.usuario_Residencial.DataPropertyName = "usuario_Residencial";
            this.usuario_Residencial.HeaderText = "Residencial";
            this.usuario_Residencial.Name = "usuario_Residencial";
            this.usuario_Residencial.ReadOnly = true;
            this.usuario_Residencial.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.usuario_Residencial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.usuario_Residencial.Width = 50;
            // 
            // Bonificacion
            // 
            this.Bonificacion.DataPropertyName = "bonificacion";
            this.Bonificacion.HeaderText = "Bonificación";
            this.Bonificacion.Name = "Bonificacion";
            this.Bonificacion.ReadOnly = true;
            this.Bonificacion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Bonificacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Bonificacion.Width = 55;
            // 
            // recargo_minimo
            // 
            this.recargo_minimo.DataPropertyName = "recargo_minimo";
            this.recargo_minimo.HeaderText = "Recargo Mínimo";
            this.recargo_minimo.Name = "recargo_minimo";
            this.recargo_minimo.ReadOnly = true;
            this.recargo_minimo.Width = 50;
            // 
            // requiere_fin
            // 
            this.requiere_fin.DataPropertyName = "requiere_fin";
            this.requiere_fin.HeaderText = "Finaliza";
            this.requiere_fin.Name = "requiere_fin";
            this.requiere_fin.ReadOnly = true;
            this.requiere_fin.Width = 50;
            // 
            // meses_venc
            // 
            this.meses_venc.DataPropertyName = "meses_venc";
            this.meses_venc.HeaderText = "Meses Venc";
            this.meses_venc.Name = "meses_venc";
            this.meses_venc.ReadOnly = true;
            this.meses_venc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.meses_venc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.meses_venc.Width = 50;
            // 
            // activa
            // 
            this.activa.DataPropertyName = "activa";
            this.activa.HeaderText = "Tarifa Activa";
            this.activa.Name = "activa";
            this.activa.ReadOnly = true;
            this.activa.Width = 40;
            // 
            // tipo_abono
            // 
            this.tipo_abono.DataPropertyName = "tipo_abono";
            this.tipo_abono.HeaderText = "tipo_abono";
            this.tipo_abono.Name = "tipo_abono";
            this.tipo_abono.ReadOnly = true;
            this.tipo_abono.Visible = false;
            // 
            // tsMenu
            // 
            this.tsMenu.GripMargin = new System.Windows.Forms.Padding(1);
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
            this.tsMenu.Padding = new System.Windows.Forms.Padding(0);
            this.tsMenu.Size = new System.Drawing.Size(729, 39);
            this.tsMenu.TabIndex = 10;
            this.tsMenu.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
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
            // frmTarifa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 495);
            this.Controls.Add(this.tsMenu);
            this.Controls.Add(this.gbTarifa);
            this.Controls.Add(this.dgvTarifa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(745, 533);
            this.Name = "frmTarifa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarifas";
            this.Load += new System.EventHandler(this.frmTarifa_Load);
            this.gbTarifa.ResumeLayout(false);
            this.gbTarifa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarifa)).EndInit();
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTarifa;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtTarifa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTarifa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CHKUsuarioResidencial;
        private System.Windows.Forms.CheckBox chkBonicacion;
        private System.Windows.Forms.CheckBox chkAplicarRecargo;
        private System.Windows.Forms.CheckBox chkTarifaActiva;
        private System.Windows.Forms.TextBox txtAbono;
        private System.Windows.Forms.TextBox txtM3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCargoFijo;
        private System.Windows.Forms.TextBox txtAbreviatura;
        private System.Windows.Forms.TextBox txtMeses;
        private System.Windows.Forms.CheckBox chkVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Tarifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn abreviatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo_fijo;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_M3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abono;
        private System.Windows.Forms.DataGridViewCheckBoxColumn usuario_Residencial;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Bonificacion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn recargo_minimo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn requiere_fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn meses_venc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_abono;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.ToolStripButton tsbImprimir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbAceptar;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
    }
}