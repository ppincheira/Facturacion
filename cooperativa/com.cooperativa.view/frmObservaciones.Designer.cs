namespace com.cooperativa.view
{
    partial class frmObservaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmObservaciones));
            this.btnDesbloquear = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tpObservaciones = new System.Windows.Forms.TabPage();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtNuevaNota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnAgregarObservaciones = new System.Windows.Forms.Button();
            this.tpCodene = new System.Windows.Forms.TabPage();
            this.gbCodene = new System.Windows.Forms.GroupBox();
            this.lblCOCodigo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpCOFechaResolucion = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpCoFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.btnCOCancelar = new System.Windows.Forms.Button();
            this.btnCoAceptar = new System.Windows.Forms.Button();
            this.tsMenuCodene = new System.Windows.Forms.ToolStrip();
            this.btnCONuevo = new System.Windows.Forms.ToolStripButton();
            this.btnCOModificar = new System.Windows.Forms.ToolStripButton();
            this.btnCOEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnCOImprimir = new System.Windows.Forms.ToolStripButton();
            this.dgvCOCodene = new System.Windows.Forms.DataGridView();
            this.id_codene = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_socio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpProceso = new System.Windows.Forms.TabPage();
            this.btnPJAceptar = new System.Windows.Forms.Button();
            this.btnPJCancelar = new System.Windows.Forms.Button();
            this.tsMenuPJ = new System.Windows.Forms.ToolStrip();
            this.btnPJNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnPJModificar = new System.Windows.Forms.ToolStripButton();
            this.btnPJEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnPJImprimir = new System.Windows.Forms.ToolStripButton();
            this.gbProcesoJudicial = new System.Windows.Forms.GroupBox();
            this.lblPJCodigo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaResolucion = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPJEstado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPJEstudio = new System.Windows.Forms.ComboBox();
            this.dgvPJProceso = new System.Windows.Forms.DataGridView();
            this.id_proceso_judicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estudio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_estudio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaResolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_socioC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbControl.SuspendLayout();
            this.tpObservaciones.SuspendLayout();
            this.panelAdd.SuspendLayout();
            this.tpCodene.SuspendLayout();
            this.gbCodene.SuspendLayout();
            this.tsMenuCodene.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCOCodene)).BeginInit();
            this.tpProceso.SuspendLayout();
            this.tsMenuPJ.SuspendLayout();
            this.gbProcesoJudicial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPJProceso)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDesbloquear
            // 
            this.btnDesbloquear.Location = new System.Drawing.Point(6, 320);
            this.btnDesbloquear.Name = "btnDesbloquear";
            this.btnDesbloquear.Size = new System.Drawing.Size(117, 23);
            this.btnDesbloquear.TabIndex = 4;
            this.btnDesbloquear.Text = "Desbloquear edición";
            this.btnDesbloquear.UseVisualStyleBackColor = true;
            this.btnDesbloquear.Click += new System.EventHandler(this.btnDesbloquear_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(140, 320);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(103, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar Cambios";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(415, 382);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(103, 23);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.tpObservaciones);
            this.tbControl.Controls.Add(this.tpCodene);
            this.tbControl.Controls.Add(this.tpProceso);
            this.tbControl.Location = new System.Drawing.Point(1, 12);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(519, 367);
            this.tbControl.TabIndex = 9;
            this.tbControl.Tag = "";
            // 
            // tpObservaciones
            // 
            this.tpObservaciones.Controls.Add(this.panelAdd);
            this.tpObservaciones.Controls.Add(this.txtObservaciones);
            this.tpObservaciones.Controls.Add(this.btnGuardar);
            this.tpObservaciones.Controls.Add(this.btnAgregarObservaciones);
            this.tpObservaciones.Controls.Add(this.btnDesbloquear);
            this.tpObservaciones.Location = new System.Drawing.Point(4, 22);
            this.tpObservaciones.Name = "tpObservaciones";
            this.tpObservaciones.Padding = new System.Windows.Forms.Padding(3);
            this.tpObservaciones.Size = new System.Drawing.Size(511, 341);
            this.tpObservaciones.TabIndex = 0;
            this.tpObservaciones.Text = "OBSERVACIONES";
            this.tpObservaciones.UseVisualStyleBackColor = true;
            // 
            // panelAdd
            // 
            this.panelAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.panelAdd.Controls.Add(this.btnCancelar);
            this.panelAdd.Controls.Add(this.btnAceptar);
            this.panelAdd.Controls.Add(this.txtNuevaNota);
            this.panelAdd.Controls.Add(this.label1);
            this.panelAdd.Location = new System.Drawing.Point(19, 124);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(478, 107);
            this.panelAdd.TabIndex = 12;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(392, 78);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(311, 78);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtNuevaNota
            // 
            this.txtNuevaNota.Location = new System.Drawing.Point(8, 24);
            this.txtNuevaNota.Multiline = true;
            this.txtNuevaNota.Name = "txtNuevaNota";
            this.txtNuevaNota.Size = new System.Drawing.Size(459, 50);
            this.txtNuevaNota.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nueva  nota para Observaciones";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(6, 68);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(499, 246);
            this.txtObservaciones.TabIndex = 11;
            // 
            // btnAgregarObservaciones
            // 
            this.btnAgregarObservaciones.Location = new System.Drawing.Point(6, 6);
            this.btnAgregarObservaciones.Name = "btnAgregarObservaciones";
            this.btnAgregarObservaciones.Size = new System.Drawing.Size(149, 52);
            this.btnAgregarObservaciones.TabIndex = 8;
            this.btnAgregarObservaciones.Text = "Agregar Nota a observaciones";
            this.btnAgregarObservaciones.UseVisualStyleBackColor = true;
            this.btnAgregarObservaciones.Click += new System.EventHandler(this.btnAgregarObservaciones_Click);
            // 
            // tpCodene
            // 
            this.tpCodene.Controls.Add(this.gbCodene);
            this.tpCodene.Controls.Add(this.btnCOCancelar);
            this.tpCodene.Controls.Add(this.btnCoAceptar);
            this.tpCodene.Controls.Add(this.tsMenuCodene);
            this.tpCodene.Controls.Add(this.dgvCOCodene);
            this.tpCodene.Location = new System.Drawing.Point(4, 22);
            this.tpCodene.Name = "tpCodene";
            this.tpCodene.Size = new System.Drawing.Size(511, 341);
            this.tpCodene.TabIndex = 2;
            this.tpCodene.Text = "CODENE";
            this.tpCodene.UseVisualStyleBackColor = true;
            // 
            // gbCodene
            // 
            this.gbCodene.Controls.Add(this.lblCOCodigo);
            this.gbCodene.Controls.Add(this.label9);
            this.gbCodene.Controls.Add(this.label7);
            this.gbCodene.Controls.Add(this.dtpCOFechaResolucion);
            this.gbCodene.Controls.Add(this.label6);
            this.gbCodene.Controls.Add(this.dtpCoFechaAlta);
            this.gbCodene.Location = new System.Drawing.Point(14, 29);
            this.gbCodene.Name = "gbCodene";
            this.gbCodene.Size = new System.Drawing.Size(486, 99);
            this.gbCodene.TabIndex = 28;
            this.gbCodene.TabStop = false;
            // 
            // lblCOCodigo
            // 
            this.lblCOCodigo.AutoSize = true;
            this.lblCOCodigo.Location = new System.Drawing.Point(88, 27);
            this.lblCOCodigo.Name = "lblCOCodigo";
            this.lblCOCodigo.Size = new System.Drawing.Size(0, 13);
            this.lblCOCodigo.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Codigo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Fecha de Resolución:";
            // 
            // dtpCOFechaResolucion
            // 
            this.dtpCOFechaResolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCOFechaResolucion.Location = new System.Drawing.Point(392, 57);
            this.dtpCOFechaResolucion.Name = "dtpCOFechaResolucion";
            this.dtpCOFechaResolucion.Size = new System.Drawing.Size(83, 20);
            this.dtpCOFechaResolucion.TabIndex = 26;
            this.dtpCOFechaResolucion.Value = new System.DateTime(2013, 11, 30, 16, 40, 25, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Fecha de Alta:";
            // 
            // dtpCoFechaAlta
            // 
            this.dtpCoFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCoFechaAlta.Location = new System.Drawing.Point(88, 56);
            this.dtpCoFechaAlta.Name = "dtpCoFechaAlta";
            this.dtpCoFechaAlta.Size = new System.Drawing.Size(83, 20);
            this.dtpCoFechaAlta.TabIndex = 24;
            this.dtpCoFechaAlta.Value = new System.DateTime(2013, 11, 30, 16, 40, 25, 0);
            // 
            // btnCOCancelar
            // 
            this.btnCOCancelar.Location = new System.Drawing.Point(425, 1);
            this.btnCOCancelar.Name = "btnCOCancelar";
            this.btnCOCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCOCancelar.TabIndex = 27;
            this.btnCOCancelar.Text = "&Cancelar";
            this.btnCOCancelar.UseVisualStyleBackColor = true;
            this.btnCOCancelar.Click += new System.EventHandler(this.btnCOCancelar_Click);
            // 
            // btnCoAceptar
            // 
            this.btnCoAceptar.Location = new System.Drawing.Point(344, 1);
            this.btnCoAceptar.Name = "btnCoAceptar";
            this.btnCoAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnCoAceptar.TabIndex = 25;
            this.btnCoAceptar.Text = "&Aceptar";
            this.btnCoAceptar.UseVisualStyleBackColor = true;
            this.btnCoAceptar.Click += new System.EventHandler(this.btnCoAceptar_Click);
            // 
            // tsMenuCodene
            // 
            this.tsMenuCodene.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCONuevo,
            this.btnCOModificar,
            this.btnCOEliminar,
            this.btnCOImprimir});
            this.tsMenuCodene.Location = new System.Drawing.Point(0, 0);
            this.tsMenuCodene.Name = "tsMenuCodene";
            this.tsMenuCodene.Size = new System.Drawing.Size(511, 25);
            this.tsMenuCodene.TabIndex = 26;
            this.tsMenuCodene.Text = "toolStrip1";
            // 
            // btnCONuevo
            // 
            this.btnCONuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCONuevo.Image = global::com.cooperativa.view.Properties.Resources.nuevo32;
            this.btnCONuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCONuevo.Name = "btnCONuevo";
            this.btnCONuevo.Size = new System.Drawing.Size(23, 22);
            this.btnCONuevo.Text = "Nuevo";
            this.btnCONuevo.ToolTipText = "Nuevo";
            this.btnCONuevo.Click += new System.EventHandler(this.btnCONuevo_Click);
            // 
            // btnCOModificar
            // 
            this.btnCOModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCOModificar.Image = global::com.cooperativa.view.Properties.Resources.editar32;
            this.btnCOModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCOModificar.Name = "btnCOModificar";
            this.btnCOModificar.Size = new System.Drawing.Size(23, 22);
            this.btnCOModificar.Text = "Editar";
            this.btnCOModificar.Click += new System.EventHandler(this.btnCOModificar_Click);
            // 
            // btnCOEliminar
            // 
            this.btnCOEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCOEliminar.Image = global::com.cooperativa.view.Properties.Resources.eliminar32;
            this.btnCOEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCOEliminar.Name = "btnCOEliminar";
            this.btnCOEliminar.Size = new System.Drawing.Size(23, 22);
            this.btnCOEliminar.Text = "Eliminar";
            this.btnCOEliminar.Click += new System.EventHandler(this.btnCOEliminar_Click);
            // 
            // btnCOImprimir
            // 
            this.btnCOImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCOImprimir.Image = global::com.cooperativa.view.Properties.Resources.imprimir32;
            this.btnCOImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCOImprimir.Name = "btnCOImprimir";
            this.btnCOImprimir.Size = new System.Drawing.Size(23, 22);
            this.btnCOImprimir.Text = "Imprimir";
            this.btnCOImprimir.Click += new System.EventHandler(this.btnCOImprimir_Click);
            // 
            // dgvCOCodene
            // 
            this.dgvCOCodene.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCOCodene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCOCodene.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_codene,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.id_socio});
            this.dgvCOCodene.Location = new System.Drawing.Point(14, 133);
            this.dgvCOCodene.MultiSelect = false;
            this.dgvCOCodene.Name = "dgvCOCodene";
            this.dgvCOCodene.ReadOnly = true;
            this.dgvCOCodene.Size = new System.Drawing.Size(486, 176);
            this.dgvCOCodene.TabIndex = 24;
            this.dgvCOCodene.SelectionChanged += new System.EventHandler(this.dgvCOCodene_SelectionChanged);
            // 
            // id_codene
            // 
            this.id_codene.DataPropertyName = "id_codene";
            this.id_codene.HeaderText = "id_codene";
            this.id_codene.Name = "id_codene";
            this.id_codene.ReadOnly = true;
            this.id_codene.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "fechaAlta";
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha Alta";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "fechaBaja";
            this.dataGridViewTextBoxColumn4.HeaderText = "Fecha Resolución";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // id_socio
            // 
            this.id_socio.DataPropertyName = "id_socio";
            this.id_socio.HeaderText = "id_socio";
            this.id_socio.Name = "id_socio";
            this.id_socio.ReadOnly = true;
            this.id_socio.Visible = false;
            // 
            // tpProceso
            // 
            this.tpProceso.Controls.Add(this.btnPJAceptar);
            this.tpProceso.Controls.Add(this.btnPJCancelar);
            this.tpProceso.Controls.Add(this.tsMenuPJ);
            this.tpProceso.Controls.Add(this.gbProcesoJudicial);
            this.tpProceso.Controls.Add(this.dgvPJProceso);
            this.tpProceso.Location = new System.Drawing.Point(4, 22);
            this.tpProceso.Name = "tpProceso";
            this.tpProceso.Padding = new System.Windows.Forms.Padding(3);
            this.tpProceso.Size = new System.Drawing.Size(511, 341);
            this.tpProceso.TabIndex = 1;
            this.tpProceso.Text = "PROCESO JUDICIAL";
            this.tpProceso.UseVisualStyleBackColor = true;
            // 
            // btnPJAceptar
            // 
            this.btnPJAceptar.Location = new System.Drawing.Point(342, 3);
            this.btnPJAceptar.Name = "btnPJAceptar";
            this.btnPJAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnPJAceptar.TabIndex = 24;
            this.btnPJAceptar.Text = "&Aceptar";
            this.btnPJAceptar.UseVisualStyleBackColor = true;
            this.btnPJAceptar.Click += new System.EventHandler(this.btnPJAceptar_Click);
            // 
            // btnPJCancelar
            // 
            this.btnPJCancelar.Location = new System.Drawing.Point(423, 3);
            this.btnPJCancelar.Name = "btnPJCancelar";
            this.btnPJCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnPJCancelar.TabIndex = 25;
            this.btnPJCancelar.Text = "&Cancelar";
            this.btnPJCancelar.UseVisualStyleBackColor = true;
            // 
            // tsMenuPJ
            // 
            this.tsMenuPJ.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPJNuevo,
            this.btnPJModificar,
            this.btnPJEliminar,
            this.btnPJImprimir});
            this.tsMenuPJ.Location = new System.Drawing.Point(3, 3);
            this.tsMenuPJ.Name = "tsMenuPJ";
            this.tsMenuPJ.Size = new System.Drawing.Size(505, 25);
            this.tsMenuPJ.TabIndex = 28;
            this.tsMenuPJ.Text = "toolStrip1";
            // 
            // btnPJNuevo
            // 
            this.btnPJNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPJNuevo.Image = global::com.cooperativa.view.Properties.Resources.nuevo32;
            this.btnPJNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPJNuevo.Name = "btnPJNuevo";
            this.btnPJNuevo.Size = new System.Drawing.Size(23, 22);
            this.btnPJNuevo.Text = "Nuevo";
            this.btnPJNuevo.Click += new System.EventHandler(this.btnPJNuevo_Click);
            // 
            // btnPJModificar
            // 
            this.btnPJModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPJModificar.Image = global::com.cooperativa.view.Properties.Resources.editar32;
            this.btnPJModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPJModificar.Name = "btnPJModificar";
            this.btnPJModificar.Size = new System.Drawing.Size(23, 22);
            this.btnPJModificar.Text = "Editar";
            this.btnPJModificar.Click += new System.EventHandler(this.btnPJModificar_Click);
            // 
            // btnPJEliminar
            // 
            this.btnPJEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPJEliminar.Image = global::com.cooperativa.view.Properties.Resources.eliminar32;
            this.btnPJEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPJEliminar.Name = "btnPJEliminar";
            this.btnPJEliminar.Size = new System.Drawing.Size(23, 22);
            this.btnPJEliminar.Text = "Eliminar";
            this.btnPJEliminar.Click += new System.EventHandler(this.btnPJEliminar_Click);
            // 
            // btnPJImprimir
            // 
            this.btnPJImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPJImprimir.Image = global::com.cooperativa.view.Properties.Resources.imprimir32;
            this.btnPJImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPJImprimir.Name = "btnPJImprimir";
            this.btnPJImprimir.Size = new System.Drawing.Size(23, 22);
            this.btnPJImprimir.Text = "Imprimir";
            this.btnPJImprimir.Click += new System.EventHandler(this.btnPJImprimir_Click);
            // 
            // gbProcesoJudicial
            // 
            this.gbProcesoJudicial.Controls.Add(this.lblPJCodigo);
            this.gbProcesoJudicial.Controls.Add(this.label8);
            this.gbProcesoJudicial.Controls.Add(this.label5);
            this.gbProcesoJudicial.Controls.Add(this.dtpFechaResolucion);
            this.gbProcesoJudicial.Controls.Add(this.label4);
            this.gbProcesoJudicial.Controls.Add(this.dtpFecha);
            this.gbProcesoJudicial.Controls.Add(this.label3);
            this.gbProcesoJudicial.Controls.Add(this.cmbPJEstado);
            this.gbProcesoJudicial.Controls.Add(this.label2);
            this.gbProcesoJudicial.Controls.Add(this.cmbPJEstudio);
            this.gbProcesoJudicial.Location = new System.Drawing.Point(9, 30);
            this.gbProcesoJudicial.Name = "gbProcesoJudicial";
            this.gbProcesoJudicial.Size = new System.Drawing.Size(489, 128);
            this.gbProcesoJudicial.TabIndex = 27;
            this.gbProcesoJudicial.TabStop = false;
            // 
            // lblPJCodigo
            // 
            this.lblPJCodigo.AutoSize = true;
            this.lblPJCodigo.Location = new System.Drawing.Point(84, 16);
            this.lblPJCodigo.Name = "lblPJCodigo";
            this.lblPJCodigo.Size = new System.Drawing.Size(0, 13);
            this.lblPJCodigo.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Codigo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Fecha de Resolución:";
            // 
            // dtpFechaResolucion
            // 
            this.dtpFechaResolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaResolucion.Location = new System.Drawing.Point(362, 92);
            this.dtpFechaResolucion.Name = "dtpFechaResolucion";
            this.dtpFechaResolucion.Size = new System.Drawing.Size(83, 20);
            this.dtpFechaResolucion.TabIndex = 28;
            this.dtpFechaResolucion.Value = new System.DateTime(2013, 11, 30, 16, 40, 25, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Fecha de Alta:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(86, 91);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(83, 20);
            this.dtpFecha.TabIndex = 26;
            this.dtpFecha.Value = new System.DateTime(2013, 11, 30, 16, 40, 25, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Estado:";
            // 
            // cmbPJEstado
            // 
            this.cmbPJEstado.FormattingEnabled = true;
            this.cmbPJEstado.Location = new System.Drawing.Point(359, 49);
            this.cmbPJEstado.Name = "cmbPJEstado";
            this.cmbPJEstado.Size = new System.Drawing.Size(121, 21);
            this.cmbPJEstado.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Estudio:";
            // 
            // cmbPJEstudio
            // 
            this.cmbPJEstudio.FormattingEnabled = true;
            this.cmbPJEstudio.Location = new System.Drawing.Point(86, 49);
            this.cmbPJEstudio.Name = "cmbPJEstudio";
            this.cmbPJEstudio.Size = new System.Drawing.Size(121, 21);
            this.cmbPJEstudio.TabIndex = 22;
            // 
            // dgvPJProceso
            // 
            this.dgvPJProceso.AllowUserToAddRows = false;
            this.dgvPJProceso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPJProceso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPJProceso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_proceso_judicial,
            this.estudio,
            this.id_estudio,
            this.estado,
            this.fechaAlta,
            this.fechaResolucion,
            this.id_socioC});
            this.dgvPJProceso.Location = new System.Drawing.Point(9, 165);
            this.dgvPJProceso.Name = "dgvPJProceso";
            this.dgvPJProceso.ReadOnly = true;
            this.dgvPJProceso.Size = new System.Drawing.Size(486, 150);
            this.dgvPJProceso.TabIndex = 22;
            this.dgvPJProceso.SelectionChanged += new System.EventHandler(this.dgvPJProceso_SelectionChanged);
            // 
            // id_proceso_judicial
            // 
            this.id_proceso_judicial.DataPropertyName = "id_proceso_judicial";
            this.id_proceso_judicial.HeaderText = "id_proceso_judicial";
            this.id_proceso_judicial.Name = "id_proceso_judicial";
            this.id_proceso_judicial.ReadOnly = true;
            this.id_proceso_judicial.Visible = false;
            // 
            // estudio
            // 
            this.estudio.DataPropertyName = "estudio";
            this.estudio.HeaderText = "Estudio";
            this.estudio.Name = "estudio";
            this.estudio.ReadOnly = true;
            // 
            // id_estudio
            // 
            this.id_estudio.DataPropertyName = "id_estudio";
            this.id_estudio.HeaderText = "id_estudio";
            this.id_estudio.Name = "id_estudio";
            this.id_estudio.ReadOnly = true;
            this.id_estudio.Visible = false;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // fechaAlta
            // 
            this.fechaAlta.DataPropertyName = "fechaAlta";
            this.fechaAlta.HeaderText = "Fecha Alta";
            this.fechaAlta.Name = "fechaAlta";
            this.fechaAlta.ReadOnly = true;
            // 
            // fechaResolucion
            // 
            this.fechaResolucion.DataPropertyName = "fechaResolucion";
            this.fechaResolucion.HeaderText = "Fecha Resolución";
            this.fechaResolucion.Name = "fechaResolucion";
            this.fechaResolucion.ReadOnly = true;
            // 
            // id_socioC
            // 
            this.id_socioC.DataPropertyName = "id_socio";
            this.id_socioC.HeaderText = "id_socio";
            this.id_socioC.Name = "id_socioC";
            this.id_socioC.ReadOnly = true;
            this.id_socioC.Visible = false;
            // 
            // frmObservaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 409);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.tbControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmObservaciones";
            this.Text = "frmObservaciones";
            this.Load += new System.EventHandler(this.frmObservaciones_Load);
            this.tbControl.ResumeLayout(false);
            this.tpObservaciones.ResumeLayout(false);
            this.tpObservaciones.PerformLayout();
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.tpCodene.ResumeLayout(false);
            this.tpCodene.PerformLayout();
            this.gbCodene.ResumeLayout(false);
            this.gbCodene.PerformLayout();
            this.tsMenuCodene.ResumeLayout(false);
            this.tsMenuCodene.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCOCodene)).EndInit();
            this.tpProceso.ResumeLayout(false);
            this.tpProceso.PerformLayout();
            this.tsMenuPJ.ResumeLayout(false);
            this.tsMenuPJ.PerformLayout();
            this.gbProcesoJudicial.ResumeLayout(false);
            this.gbProcesoJudicial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPJProceso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDesbloquear;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tpObservaciones;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtNuevaNota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnAgregarObservaciones;
        private System.Windows.Forms.TabPage tpProceso;
        private System.Windows.Forms.TabPage tpCodene;
        private System.Windows.Forms.DataGridView dgvPJProceso;
        private System.Windows.Forms.Button btnCoAceptar;
        private System.Windows.Forms.Button btnPJCancelar;
        private System.Windows.Forms.Button btnPJAceptar;
        private System.Windows.Forms.GroupBox gbProcesoJudicial;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.DateTimePicker dtpFechaResolucion;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPJEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPJEstudio;
        private System.Windows.Forms.Label lblPJCodigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStrip tsMenuPJ;
        private System.Windows.Forms.ToolStripButton btnPJNuevo;
        private System.Windows.Forms.ToolStripButton btnPJModificar;
        private System.Windows.Forms.ToolStripButton btnPJEliminar;
        private System.Windows.Forms.ToolStripButton btnPJImprimir;
        private System.Windows.Forms.ToolStrip tsMenuCodene;
        private System.Windows.Forms.ToolStripButton btnCONuevo;
        private System.Windows.Forms.ToolStripButton btnCOModificar;
        private System.Windows.Forms.ToolStripButton btnCOEliminar;
        private System.Windows.Forms.ToolStripButton btnCOImprimir;
        private System.Windows.Forms.Button btnCOCancelar;
        private System.Windows.Forms.GroupBox gbCodene;
        private System.Windows.Forms.Label lblCOCodigo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.DateTimePicker dtpCOFechaResolucion;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.DateTimePicker dtpCoFechaAlta;
        private System.Windows.Forms.DataGridView dgvCOCodene;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_codene;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_socio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_proceso_judicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn estudio;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_estudio;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaResolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_socioC;
    }
}