namespace com.cooperativa.view
{
    partial class frmEstadoConexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstadoConexion));
            this.gbEstadoConexion = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMeses = new System.Windows.Forms.TextBox();
            this.chkFechaFin = new System.Windows.Forms.CheckBox();
            this.chkSeleccionable = new System.Windows.Forms.CheckBox();
            this.cmbFacturar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEstadoSocio = new System.Windows.Forms.DataGridView();
            this.id_estado_socio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_socio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Facturar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requiere_fin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.seleccionable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.duracion_meses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsbImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAceptar = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.gbEstadoConexion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoSocio)).BeginInit();
            this.tsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEstadoConexion
            // 
            this.gbEstadoConexion.Controls.Add(this.label4);
            this.gbEstadoConexion.Controls.Add(this.txtMeses);
            this.gbEstadoConexion.Controls.Add(this.chkFechaFin);
            this.gbEstadoConexion.Controls.Add(this.chkSeleccionable);
            this.gbEstadoConexion.Controls.Add(this.cmbFacturar);
            this.gbEstadoConexion.Controls.Add(this.label3);
            this.gbEstadoConexion.Controls.Add(this.lblCodigo);
            this.gbEstadoConexion.Controls.Add(this.txtNombre);
            this.gbEstadoConexion.Controls.Add(this.label2);
            this.gbEstadoConexion.Controls.Add(this.label1);
            this.gbEstadoConexion.Location = new System.Drawing.Point(12, 42);
            this.gbEstadoConexion.Name = "gbEstadoConexion";
            this.gbEstadoConexion.Size = new System.Drawing.Size(361, 135);
            this.gbEstadoConexion.TabIndex = 9;
            this.gbEstadoConexion.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Meses";
            // 
            // txtMeses
            // 
            this.txtMeses.Location = new System.Drawing.Point(200, 96);
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.Size = new System.Drawing.Size(57, 20);
            this.txtMeses.TabIndex = 8;
            // 
            // chkFechaFin
            // 
            this.chkFechaFin.AutoSize = true;
            this.chkFechaFin.Location = new System.Drawing.Point(25, 99);
            this.chkFechaFin.Name = "chkFechaFin";
            this.chkFechaFin.Size = new System.Drawing.Size(141, 17);
            this.chkFechaFin.TabIndex = 7;
            this.chkFechaFin.Text = "Tiene vencimiento a los ";
            this.chkFechaFin.UseVisualStyleBackColor = true;
            // 
            // chkSeleccionable
            // 
            this.chkSeleccionable.AutoSize = true;
            this.chkSeleccionable.Location = new System.Drawing.Point(200, 77);
            this.chkSeleccionable.Name = "chkSeleccionable";
            this.chkSeleccionable.Size = new System.Drawing.Size(93, 17);
            this.chkSeleccionable.TabIndex = 6;
            this.chkSeleccionable.Text = "Seleccionable";
            this.chkSeleccionable.UseVisualStyleBackColor = true;
            // 
            // cmbFacturar
            // 
            this.cmbFacturar.FormattingEnabled = true;
            this.cmbFacturar.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cmbFacturar.Location = new System.Drawing.Point(75, 72);
            this.cmbFacturar.Name = "cmbFacturar";
            this.cmbFacturar.Size = new System.Drawing.Size(62, 21);
            this.cmbFacturar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Facturar:";
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
            this.txtNombre.Location = new System.Drawing.Point(75, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(280, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
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
            // dgvEstadoSocio
            // 
            this.dgvEstadoSocio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstadoSocio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEstadoSocio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadoSocio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_estado_socio,
            this.estado_socio,
            this.Facturar,
            this.requiere_fin,
            this.seleccionable,
            this.duracion_meses});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEstadoSocio.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEstadoSocio.Location = new System.Drawing.Point(11, 183);
            this.dgvEstadoSocio.Name = "dgvEstadoSocio";
            this.dgvEstadoSocio.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstadoSocio.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEstadoSocio.Size = new System.Drawing.Size(696, 242);
            this.dgvEstadoSocio.TabIndex = 7;
            this.dgvEstadoSocio.SelectionChanged += new System.EventHandler(this.dgvEstadoSocio_SelectionChanged);
            // 
            // id_estado_socio
            // 
            this.id_estado_socio.DataPropertyName = "id_estado_socio";
            this.id_estado_socio.HeaderText = "Codigo";
            this.id_estado_socio.Name = "id_estado_socio";
            this.id_estado_socio.ReadOnly = true;
            this.id_estado_socio.Width = 50;
            // 
            // estado_socio
            // 
            this.estado_socio.DataPropertyName = "estado_socio";
            this.estado_socio.HeaderText = "Estado";
            this.estado_socio.Name = "estado_socio";
            this.estado_socio.ReadOnly = true;
            this.estado_socio.Width = 200;
            // 
            // Facturar
            // 
            this.Facturar.DataPropertyName = "facturar";
            this.Facturar.HeaderText = "Facturar";
            this.Facturar.Name = "Facturar";
            this.Facturar.ReadOnly = true;
            // 
            // requiere_fin
            // 
            this.requiere_fin.DataPropertyName = "requiere_fin";
            this.requiere_fin.HeaderText = "requiere_fin";
            this.requiere_fin.Name = "requiere_fin";
            this.requiere_fin.ReadOnly = true;
            this.requiere_fin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.requiere_fin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // seleccionable
            // 
            this.seleccionable.DataPropertyName = "seleccionable";
            this.seleccionable.HeaderText = "seleccionable";
            this.seleccionable.Name = "seleccionable";
            this.seleccionable.ReadOnly = true;
            // 
            // duracion_meses
            // 
            this.duracion_meses.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.duracion_meses.DataPropertyName = "duracion_meses";
            this.duracion_meses.HeaderText = "duracion_meses";
            this.duracion_meses.Name = "duracion_meses";
            this.duracion_meses.ReadOnly = true;
            this.duracion_meses.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.duracion_meses.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.tsMenu.Size = new System.Drawing.Size(719, 39);
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
            // frmEstadoConexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 437);
            this.Controls.Add(this.gbEstadoConexion);
            this.Controls.Add(this.dgvEstadoSocio);
            this.Controls.Add(this.tsMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(735, 475);
            this.Name = "frmEstadoConexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estados de Socios";
            this.Load += new System.EventHandler(this.frmEstadoConexion_Load);
            this.gbEstadoConexion.ResumeLayout(false);
            this.gbEstadoConexion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoSocio)).EndInit();
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEstadoConexion;
        private System.Windows.Forms.CheckBox chkSeleccionable;
        private System.Windows.Forms.ComboBox cmbFacturar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEstadoSocio;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.ToolStripButton tsbImprimir;
        private System.Windows.Forms.CheckBox chkFechaFin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMeses;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_estado_socio;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_socio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Facturar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn requiere_fin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn seleccionable;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracion_meses;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbAceptar;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
    }
}