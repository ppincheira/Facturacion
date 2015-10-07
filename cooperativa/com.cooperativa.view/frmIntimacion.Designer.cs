namespace com.cooperativa.view
{
    partial class frmIntimacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIntimacion));
            this.dgvIntimacion = new System.Windows.Forms.DataGridView();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Intimacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Socio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.mCalendarFecha = new System.Windows.Forms.MonthCalendar();
            this.cmbTipoIntimacion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntimacion)).BeginInit();
            this.panelAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvIntimacion
            // 
            this.dgvIntimacion.AllowUserToAddRows = false;
            this.dgvIntimacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIntimacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIntimacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.id_Intimacion,
            this.id_Socio,
            this.Fecha});
            this.dgvIntimacion.Location = new System.Drawing.Point(12, 12);
            this.dgvIntimacion.Name = "dgvIntimacion";
            this.dgvIntimacion.Size = new System.Drawing.Size(380, 252);
            this.dgvIntimacion.TabIndex = 0;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // id_Intimacion
            // 
            this.id_Intimacion.DataPropertyName = "id_intimacion";
            this.id_Intimacion.HeaderText = "id_Intimacion";
            this.id_Intimacion.Name = "id_Intimacion";
            this.id_Intimacion.Visible = false;
            // 
            // id_Socio
            // 
            this.id_Socio.DataPropertyName = "id_socio";
            this.id_Socio.HeaderText = "id_Socio";
            this.id_Socio.Name = "id_Socio";
            this.id_Socio.Visible = false;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(12, 270);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(107, 23);
            this.btnQuitar.TabIndex = 1;
            this.btnQuitar.Text = "&Quitar Marca";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(147, 270);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(103, 23);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "&Nueva Intimación";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(285, 270);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(107, 23);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.txtFecha);
            this.panelAdd.Controls.Add(this.btnCancelar);
            this.panelAdd.Controls.Add(this.btnAceptar);
            this.panelAdd.Controls.Add(this.mCalendarFecha);
            this.panelAdd.Controls.Add(this.cmbTipoIntimacion);
            this.panelAdd.Controls.Add(this.label2);
            this.panelAdd.Controls.Add(this.label1);
            this.panelAdd.Location = new System.Drawing.Point(12, 1);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(380, 263);
            this.panelAdd.TabIndex = 4;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(96, 50);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(235, 237);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(96, 237);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(80, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // mCalendarFecha
            // 
            this.mCalendarFecha.Location = new System.Drawing.Point(96, 72);
            this.mCalendarFecha.Name = "mCalendarFecha";
            this.mCalendarFecha.TabIndex = 4;
            this.mCalendarFecha.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mCalendarFecha_DateChanged);
            // 
            // cmbTipoIntimacion
            // 
            this.cmbTipoIntimacion.FormattingEnabled = true;
            this.cmbTipoIntimacion.Location = new System.Drawing.Point(96, 12);
            this.cmbTipoIntimacion.Name = "cmbTipoIntimacion";
            this.cmbTipoIntimacion.Size = new System.Drawing.Size(256, 21);
            this.cmbTipoIntimacion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo Intimación:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha:";
            // 
            // frmIntimacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 305);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.dgvIntimacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIntimacion";
            this.Text = "frmIntimacion";
            this.Load += new System.EventHandler(this.frmIntimacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntimacion)).EndInit();
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIntimacion;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.MonthCalendar mCalendarFecha;
        private System.Windows.Forms.ComboBox cmbTipoIntimacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Intimacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Socio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
    }
}