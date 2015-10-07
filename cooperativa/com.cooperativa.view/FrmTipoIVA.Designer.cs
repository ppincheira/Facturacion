namespace com.cooperativa.view
{
    partial class FrmTipoIVA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTipoIVA));
            this.gbTipoIva = new System.Windows.Forms.GroupBox();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.Label12 = new System.Windows.Forms.Label();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.chkCreditoFiscal = new System.Windows.Forms.CheckBox();
            this.txtAlicuota = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTipoIva = new System.Windows.Forms.DataGridView();
            this.id_Impuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vigencia_desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vigencia_hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credito_fiscal = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsbImprimir = new System.Windows.Forms.ToolStripButton();
            this.gbTipoIva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoIva)).BeginInit();
            this.tsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTipoIva
            // 
            this.gbTipoIva.Controls.Add(this.dtpFechaHasta);
            this.gbTipoIva.Controls.Add(this.label4);
            this.gbTipoIva.Controls.Add(this.dtpFechaDesde);
            this.gbTipoIva.Controls.Add(this.Label12);
            this.gbTipoIva.Controls.Add(this.chkActivo);
            this.gbTipoIva.Controls.Add(this.chkCreditoFiscal);
            this.gbTipoIva.Controls.Add(this.txtAlicuota);
            this.gbTipoIva.Controls.Add(this.label3);
            this.gbTipoIva.Controls.Add(this.lblCodigo);
            this.gbTipoIva.Controls.Add(this.txtNombre);
            this.gbTipoIva.Controls.Add(this.label2);
            this.gbTipoIva.Controls.Add(this.label1);
            this.gbTipoIva.Location = new System.Drawing.Point(12, 42);
            this.gbTipoIva.Name = "gbTipoIva";
            this.gbTipoIva.Size = new System.Drawing.Size(519, 148);
            this.gbTipoIva.TabIndex = 9;
            this.gbTipoIva.TabStop = false;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(427, 78);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(83, 20);
            this.dtpFechaHasta.TabIndex = 21;
            this.dtpFechaHasta.Value = new System.DateTime(2013, 12, 28, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Fecha Hasta:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(252, 78);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(83, 20);
            this.dtpFechaDesde.TabIndex = 19;
            this.dtpFechaDesde.Value = new System.DateTime(2013, 12, 28, 0, 0, 0, 0);
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(171, 82);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(74, 13);
            this.Label12.TabIndex = 18;
            this.Label12.Text = "Fecha Desde:";
            this.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(192, 112);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(56, 17);
            this.chkActivo.TabIndex = 7;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // chkCreditoFiscal
            // 
            this.chkCreditoFiscal.AutoSize = true;
            this.chkCreditoFiscal.Location = new System.Drawing.Point(94, 112);
            this.chkCreditoFiscal.Name = "chkCreditoFiscal";
            this.chkCreditoFiscal.Size = new System.Drawing.Size(89, 17);
            this.chkCreditoFiscal.TabIndex = 6;
            this.chkCreditoFiscal.Text = "Credito Fiscal";
            this.chkCreditoFiscal.UseVisualStyleBackColor = true;
            // 
            // txtAlicuota
            // 
            this.txtAlicuota.Location = new System.Drawing.Point(98, 78);
            this.txtAlicuota.Name = "txtAlicuota";
            this.txtAlicuota.Size = new System.Drawing.Size(62, 20);
            this.txtAlicuota.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Alicuota:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(72, 20);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(0, 13);
            this.lblCodigo.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(94, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(416, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // dgvTipoIva
            // 
            this.dgvTipoIva.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvTipoIva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoIva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Impuesto,
            this.Impuesto,
            this.Porcentaje,
            this.vigencia_desde,
            this.vigencia_hasta,
            this.credito_fiscal,
            this.Activo});
            this.dgvTipoIva.Location = new System.Drawing.Point(12, 202);
            this.dgvTipoIva.Name = "dgvTipoIva";
            this.dgvTipoIva.ReadOnly = true;
            this.dgvTipoIva.Size = new System.Drawing.Size(697, 231);
            this.dgvTipoIva.TabIndex = 7;
            this.dgvTipoIva.SelectionChanged += new System.EventHandler(this.dgvTipoIva_SelectionChanged);
            // 
            // id_Impuesto
            // 
            this.id_Impuesto.DataPropertyName = "id_impuesto";
            this.id_Impuesto.HeaderText = "Codigo";
            this.id_Impuesto.Name = "id_Impuesto";
            this.id_Impuesto.ReadOnly = true;
            this.id_Impuesto.Width = 50;
            // 
            // Impuesto
            // 
            this.Impuesto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Impuesto.DataPropertyName = "Impuesto";
            this.Impuesto.HeaderText = "Impuesto";
            this.Impuesto.Name = "Impuesto";
            this.Impuesto.ReadOnly = true;
            // 
            // Porcentaje
            // 
            this.Porcentaje.DataPropertyName = "porcentaje";
            this.Porcentaje.HeaderText = "Porcentaje";
            this.Porcentaje.Name = "Porcentaje";
            this.Porcentaje.ReadOnly = true;
            this.Porcentaje.Width = 80;
            // 
            // vigencia_desde
            // 
            this.vigencia_desde.DataPropertyName = "vigencia_desde";
            this.vigencia_desde.HeaderText = "FechaD.";
            this.vigencia_desde.Name = "vigencia_desde";
            this.vigencia_desde.ReadOnly = true;
            this.vigencia_desde.Width = 80;
            // 
            // vigencia_hasta
            // 
            this.vigencia_hasta.DataPropertyName = "vigencia_hasta";
            this.vigencia_hasta.HeaderText = "FechaH.";
            this.vigencia_hasta.Name = "vigencia_hasta";
            this.vigencia_hasta.ReadOnly = true;
            this.vigencia_hasta.Width = 80;
            // 
            // credito_fiscal
            // 
            this.credito_fiscal.DataPropertyName = "credito_fiscal";
            this.credito_fiscal.HeaderText = "Cred.Fis.";
            this.credito_fiscal.Name = "credito_fiscal";
            this.credito_fiscal.ReadOnly = true;
            this.credito_fiscal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.credito_fiscal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.credito_fiscal.Width = 80;
            // 
            // Activo
            // 
            this.Activo.DataPropertyName = "Activo";
            this.Activo.HeaderText = "Ativo";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Activo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Activo.Width = 80;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(456, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(375, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // tsMenu
            // 
            this.tsMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.tsMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbModificar,
            this.tsbEliminar,
            this.tsbImprimir});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(156, 39);
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
            // FrmTipoIVA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 445);
            this.Controls.Add(this.gbTipoIva);
            this.Controls.Add(this.dgvTipoIva);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tsMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(739, 483);
            this.Name = "FrmTipoIVA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tipo de IVA";
            this.Load += new System.EventHandler(this.FrmTipoIVA_Load);
            this.gbTipoIva.ResumeLayout(false);
            this.gbTipoIva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoIva)).EndInit();
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTipoIva;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTipoIva;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.ToolStripButton tsbImprimir;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.CheckBox chkCreditoFiscal;
        private System.Windows.Forms.TextBox txtAlicuota;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.DateTimePicker dtpFechaHasta;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.DateTimePicker dtpFechaDesde;
        internal System.Windows.Forms.Label Label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Impuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Impuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn vigencia_desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn vigencia_hasta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn credito_fiscal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activo;
    }
}