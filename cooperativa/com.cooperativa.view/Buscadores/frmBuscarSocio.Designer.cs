namespace com.cooperativa.view.Buscadores
{
    partial class frmBuscarSocio
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lbCampos = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSocios = new System.Windows.Forms.DataGridView();
            this.bgBotones = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.cmbInstruccion = new System.Windows.Forms.ComboBox();
            this.CodSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manzana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomenclatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_socio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios)).BeginInit();
            this.bgBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texto de busqueda:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(138, 17);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(330, 20);
            this.txtBusqueda.TabIndex = 1;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // lbCampos
            // 
            this.lbCampos.FormattingEnabled = true;
            this.lbCampos.Location = new System.Drawing.Point(12, 80);
            this.lbCampos.Name = "lbCampos";
            this.lbCampos.Size = new System.Drawing.Size(120, 199);
            this.lbCampos.TabIndex = 2;
            this.lbCampos.SelectedIndexChanged += new System.EventHandler(this.lbCampos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buscar en el campo..:";
            // 
            // dgvSocios
            // 
            this.dgvSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSocios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodSocio,
            this.SubCod,
            this.Nombre,
            this.Documento,
            this.Barrio,
            this.zona,
            this.Manzana,
            this.Lote,
            this.Calle,
            this.Nro,
            this.Ruta,
            this.orden,
            this.nomenclatura,
            this.Medidor,
            this.cuit,
            this.Observaciones,
            this.id_socio});
            this.dgvSocios.Location = new System.Drawing.Point(138, 80);
            this.dgvSocios.Name = "dgvSocios";
            this.dgvSocios.Size = new System.Drawing.Size(499, 199);
            this.dgvSocios.TabIndex = 4;
            this.dgvSocios.SelectionChanged += new System.EventHandler(this.dgvSocios_SelectionChanged);
            // 
            // bgBotones
            // 
            this.bgBotones.Controls.Add(this.btnSalir);
            this.bgBotones.Controls.Add(this.btnSeleccionar);
            this.bgBotones.Location = new System.Drawing.Point(404, 285);
            this.bgBotones.Name = "bgBotones";
            this.bgBotones.Size = new System.Drawing.Size(233, 58);
            this.bgBotones.TabIndex = 5;
            this.bgBotones.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(119, 10);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(103, 38);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(10, 10);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(103, 38);
            this.btnSeleccionar.TabIndex = 0;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // cmbInstruccion
            // 
            this.cmbInstruccion.FormattingEnabled = true;
            this.cmbInstruccion.Location = new System.Drawing.Point(474, 17);
            this.cmbInstruccion.Name = "cmbInstruccion";
            this.cmbInstruccion.Size = new System.Drawing.Size(163, 21);
            this.cmbInstruccion.TabIndex = 6;
            // 
            // CodSocio
            // 
            this.CodSocio.DataPropertyName = "codigo_socio";
            this.CodSocio.HeaderText = "CodSocio";
            this.CodSocio.Name = "CodSocio";
            // 
            // SubCod
            // 
            this.SubCod.DataPropertyName = "subcodigo_socio";
            this.SubCod.HeaderText = "SubCod";
            this.SubCod.Name = "SubCod";
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Documento
            // 
            this.Documento.DataPropertyName = "documento";
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            // 
            // Barrio
            // 
            this.Barrio.DataPropertyName = "barrio";
            this.Barrio.HeaderText = "Barrio";
            this.Barrio.Name = "Barrio";
            // 
            // zona
            // 
            this.zona.DataPropertyName = "zona";
            this.zona.HeaderText = "Zona";
            this.zona.Name = "zona";
            // 
            // Manzana
            // 
            this.Manzana.DataPropertyName = "manzana";
            this.Manzana.HeaderText = "Manzana";
            this.Manzana.Name = "Manzana";
            // 
            // Lote
            // 
            this.Lote.DataPropertyName = "lote";
            this.Lote.HeaderText = "Lote";
            this.Lote.Name = "Lote";
            // 
            // Calle
            // 
            this.Calle.DataPropertyName = "calle";
            this.Calle.HeaderText = "Calle";
            this.Calle.Name = "Calle";
            // 
            // Nro
            // 
            this.Nro.DataPropertyName = "calle_altura";
            this.Nro.HeaderText = "Nro";
            this.Nro.Name = "Nro";
            // 
            // Ruta
            // 
            this.Ruta.DataPropertyName = "ruta_reparto";
            this.Ruta.HeaderText = "Ruta";
            this.Ruta.Name = "Ruta";
            // 
            // orden
            // 
            this.orden.DataPropertyName = "orden_reparto";
            this.orden.HeaderText = "Orden";
            this.orden.Name = "orden";
            // 
            // nomenclatura
            // 
            this.nomenclatura.DataPropertyName = "nomenclatura";
            this.nomenclatura.HeaderText = "Nomenclatura";
            this.nomenclatura.Name = "nomenclatura";
            // 
            // Medidor
            // 
            this.Medidor.DataPropertyName = "medidor";
            this.Medidor.HeaderText = "Medidor";
            this.Medidor.Name = "Medidor";
            // 
            // cuit
            // 
            this.cuit.DataPropertyName = "cuit";
            this.cuit.HeaderText = "CUIT";
            this.cuit.Name = "cuit";
            // 
            // Observaciones
            // 
            this.Observaciones.DataPropertyName = "observaciones";
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            // 
            // id_socio
            // 
            this.id_socio.DataPropertyName = "id_socio";
            this.id_socio.HeaderText = "id_socio";
            this.id_socio.Name = "id_socio";
            // 
            // frmBuscarSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 345);
            this.Controls.Add(this.cmbInstruccion);
            this.Controls.Add(this.bgBotones);
            this.Controls.Add(this.dgvSocios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbCampos);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label1);
            this.Name = "frmBuscarSocio";
            this.Text = "Buscar Socio";
            this.Load += new System.EventHandler(this.frmBuscarSocio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios)).EndInit();
            this.bgBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ListBox lbCampos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSocios;
        private System.Windows.Forms.GroupBox bgBotones;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.ComboBox cmbInstruccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn zona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manzana;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomenclatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medidor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_socio;
    }
}