namespace com.cooperativa.view
{
    partial class frmSociosEnProcesoJudicial
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCrearFiltro = new System.Windows.Forms.Button();
            this.cmbBarrio = new System.Windows.Forms.ComboBox();
            this.rbFiltros = new System.Windows.Forms.RadioButton();
            this.rbSeleccionarBarrio = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbDescendente = new System.Windows.Forms.RadioButton();
            this.rbAscendente = new System.Windows.Forms.RadioButton();
            this.rbImporteConvenio = new System.Windows.Forms.RadioButton();
            this.rbCantidadCuotas = new System.Windows.Forms.RadioButton();
            this.rbFechaConvenio = new System.Windows.Forms.RadioButton();
            this.rbNombreBarrio = new System.Windows.Forms.RadioButton();
            this.rbApellidoNombre = new System.Windows.Forms.RadioButton();
            this.rbNumeroSocio = new System.Windows.Forms.RadioButton();
            this.gbIncluir = new System.Windows.Forms.GroupBox();
            this.rbSociosProcJudConConvFinalizados = new System.Windows.Forms.RadioButton();
            this.rbSociosProcJudConConvSinFin = new System.Windows.Forms.RadioButton();
            this.rbSociosProcJudConConv = new System.Windows.Forms.RadioButton();
            this.rbSociosProcJudSinConv = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGenerarListado = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.gbIncluir.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCrearFiltro);
            this.groupBox1.Controls.Add(this.cmbBarrio);
            this.groupBox1.Controls.Add(this.rbFiltros);
            this.groupBox1.Controls.Add(this.rbSeleccionarBarrio);
            this.groupBox1.Controls.Add(this.rbTodos);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generar listado de...";
            // 
            // btnCrearFiltro
            // 
            this.btnCrearFiltro.Enabled = false;
            this.btnCrearFiltro.Location = new System.Drawing.Point(153, 91);
            this.btnCrearFiltro.Name = "btnCrearFiltro";
            this.btnCrearFiltro.Size = new System.Drawing.Size(138, 23);
            this.btnCrearFiltro.TabIndex = 10;
            this.btnCrearFiltro.Text = "Crear filtro >>>";
            this.btnCrearFiltro.UseVisualStyleBackColor = true;
            // 
            // cmbBarrio
            // 
            this.cmbBarrio.Enabled = false;
            this.cmbBarrio.FormattingEnabled = true;
            this.cmbBarrio.Location = new System.Drawing.Point(153, 59);
            this.cmbBarrio.Name = "cmbBarrio";
            this.cmbBarrio.Size = new System.Drawing.Size(195, 21);
            this.cmbBarrio.TabIndex = 11;
            // 
            // rbFiltros
            // 
            this.rbFiltros.AutoSize = true;
            this.rbFiltros.Location = new System.Drawing.Point(22, 94);
            this.rbFiltros.Name = "rbFiltros";
            this.rbFiltros.Size = new System.Drawing.Size(107, 17);
            this.rbFiltros.TabIndex = 8;
            this.rbFiltros.Text = "Filtros avanzados";
            this.rbFiltros.UseVisualStyleBackColor = true;
            this.rbFiltros.CheckedChanged += new System.EventHandler(this.rbFiltros_CheckedChanged);
            // 
            // rbSeleccionarBarrio
            // 
            this.rbSeleccionarBarrio.AutoSize = true;
            this.rbSeleccionarBarrio.Location = new System.Drawing.Point(22, 63);
            this.rbSeleccionarBarrio.Name = "rbSeleccionarBarrio";
            this.rbSeleccionarBarrio.Size = new System.Drawing.Size(125, 17);
            this.rbSeleccionarBarrio.TabIndex = 7;
            this.rbSeleccionarBarrio.Text = "Seleccionar un barrio";
            this.rbSeleccionarBarrio.UseVisualStyleBackColor = true;
            this.rbSeleccionarBarrio.CheckedChanged += new System.EventHandler(this.rbSeleccionarBarrio_CheckedChanged);
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Checked = true;
            this.rbTodos.Location = new System.Drawing.Point(22, 31);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(105, 17);
            this.rbTodos.TabIndex = 6;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos los barrios";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.rbImporteConvenio);
            this.groupBox2.Controls.Add(this.rbCantidadCuotas);
            this.groupBox2.Controls.Add(this.rbFechaConvenio);
            this.groupBox2.Controls.Add(this.rbNombreBarrio);
            this.groupBox2.Controls.Add(this.rbApellidoNombre);
            this.groupBox2.Controls.Add(this.rbNumeroSocio);
            this.groupBox2.Location = new System.Drawing.Point(372, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 167);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ordenar por...";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbDescendente);
            this.groupBox5.Controls.Add(this.rbAscendente);
            this.groupBox5.Location = new System.Drawing.Point(168, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(132, 92);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ordenar en forma...";
            // 
            // rbDescendente
            // 
            this.rbDescendente.AutoSize = true;
            this.rbDescendente.Location = new System.Drawing.Point(19, 57);
            this.rbDescendente.Name = "rbDescendente";
            this.rbDescendente.Size = new System.Drawing.Size(89, 17);
            this.rbDescendente.TabIndex = 1;
            this.rbDescendente.Text = "Descendente";
            this.rbDescendente.UseVisualStyleBackColor = true;
            // 
            // rbAscendente
            // 
            this.rbAscendente.AutoSize = true;
            this.rbAscendente.Checked = true;
            this.rbAscendente.Location = new System.Drawing.Point(19, 23);
            this.rbAscendente.Name = "rbAscendente";
            this.rbAscendente.Size = new System.Drawing.Size(82, 17);
            this.rbAscendente.TabIndex = 0;
            this.rbAscendente.TabStop = true;
            this.rbAscendente.Text = "Ascendente";
            this.rbAscendente.UseVisualStyleBackColor = true;
            // 
            // rbImporteConvenio
            // 
            this.rbImporteConvenio.AutoSize = true;
            this.rbImporteConvenio.Location = new System.Drawing.Point(20, 111);
            this.rbImporteConvenio.Name = "rbImporteConvenio";
            this.rbImporteConvenio.Size = new System.Drawing.Size(124, 17);
            this.rbImporteConvenio.TabIndex = 5;
            this.rbImporteConvenio.Text = "Importe del convenio";
            this.rbImporteConvenio.UseVisualStyleBackColor = true;
            // 
            // rbCantidadCuotas
            // 
            this.rbCantidadCuotas.AutoSize = true;
            this.rbCantidadCuotas.Location = new System.Drawing.Point(20, 134);
            this.rbCantidadCuotas.Name = "rbCantidadCuotas";
            this.rbCantidadCuotas.Size = new System.Drawing.Size(181, 17);
            this.rbCantidadCuotas.TabIndex = 4;
            this.rbCantidadCuotas.Text = "Cantidad de cuotas del convenio";
            this.rbCantidadCuotas.UseVisualStyleBackColor = true;
            // 
            // rbFechaConvenio
            // 
            this.rbFechaConvenio.AutoSize = true;
            this.rbFechaConvenio.Location = new System.Drawing.Point(20, 88);
            this.rbFechaConvenio.Name = "rbFechaConvenio";
            this.rbFechaConvenio.Size = new System.Drawing.Size(119, 17);
            this.rbFechaConvenio.TabIndex = 3;
            this.rbFechaConvenio.Text = "Fecha del convenio";
            this.rbFechaConvenio.UseVisualStyleBackColor = true;
            // 
            // rbNombreBarrio
            // 
            this.rbNombreBarrio.AutoSize = true;
            this.rbNombreBarrio.Location = new System.Drawing.Point(20, 65);
            this.rbNombreBarrio.Name = "rbNombreBarrio";
            this.rbNombreBarrio.Size = new System.Drawing.Size(106, 17);
            this.rbNombreBarrio.TabIndex = 2;
            this.rbNombreBarrio.Text = "Nombre de barrio";
            this.rbNombreBarrio.UseVisualStyleBackColor = true;
            // 
            // rbApellidoNombre
            // 
            this.rbApellidoNombre.AutoSize = true;
            this.rbApellidoNombre.Location = new System.Drawing.Point(20, 42);
            this.rbApellidoNombre.Name = "rbApellidoNombre";
            this.rbApellidoNombre.Size = new System.Drawing.Size(108, 17);
            this.rbApellidoNombre.TabIndex = 1;
            this.rbApellidoNombre.Text = "Apellido y nombre";
            this.rbApellidoNombre.UseVisualStyleBackColor = true;
            // 
            // rbNumeroSocio
            // 
            this.rbNumeroSocio.AutoSize = true;
            this.rbNumeroSocio.Checked = true;
            this.rbNumeroSocio.Location = new System.Drawing.Point(20, 19);
            this.rbNumeroSocio.Name = "rbNumeroSocio";
            this.rbNumeroSocio.Size = new System.Drawing.Size(105, 17);
            this.rbNumeroSocio.TabIndex = 0;
            this.rbNumeroSocio.TabStop = true;
            this.rbNumeroSocio.Text = "Numero de socio";
            this.rbNumeroSocio.UseVisualStyleBackColor = true;
            // 
            // gbIncluir
            // 
            this.gbIncluir.Controls.Add(this.rbSociosProcJudConConvFinalizados);
            this.gbIncluir.Controls.Add(this.rbSociosProcJudConConvSinFin);
            this.gbIncluir.Controls.Add(this.rbSociosProcJudConConv);
            this.gbIncluir.Controls.Add(this.rbSociosProcJudSinConv);
            this.gbIncluir.Location = new System.Drawing.Point(12, 185);
            this.gbIncluir.Name = "gbIncluir";
            this.gbIncluir.Size = new System.Drawing.Size(475, 118);
            this.gbIncluir.TabIndex = 1;
            this.gbIncluir.TabStop = false;
            this.gbIncluir.Text = "Incluir...";
            // 
            // rbSociosProcJudConConvFinalizados
            // 
            this.rbSociosProcJudConConvFinalizados.AutoSize = true;
            this.rbSociosProcJudConConvFinalizados.Location = new System.Drawing.Point(22, 88);
            this.rbSociosProcJudConConvFinalizados.Name = "rbSociosProcJudConConvFinalizados";
            this.rbSociosProcJudConConvFinalizados.Size = new System.Drawing.Size(273, 17);
            this.rbSociosProcJudConConvFinalizados.TabIndex = 3;
            this.rbSociosProcJudConConvFinalizados.Text = "Socios en proceso judicial con convenios finalizados";
            this.rbSociosProcJudConConvFinalizados.UseVisualStyleBackColor = true;
            // 
            // rbSociosProcJudConConvSinFin
            // 
            this.rbSociosProcJudConConvSinFin.AutoSize = true;
            this.rbSociosProcJudConConvSinFin.Location = new System.Drawing.Point(22, 65);
            this.rbSociosProcJudConConvSinFin.Name = "rbSociosProcJudConConvSinFin";
            this.rbSociosProcJudConConvSinFin.Size = new System.Drawing.Size(275, 17);
            this.rbSociosProcJudConConvSinFin.TabIndex = 2;
            this.rbSociosProcJudConConvSinFin.Text = "Socios en proceso judicial con convenios sin finalizar";
            this.rbSociosProcJudConConvSinFin.UseVisualStyleBackColor = true;
            // 
            // rbSociosProcJudConConv
            // 
            this.rbSociosProcJudConConv.AutoSize = true;
            this.rbSociosProcJudConConv.Checked = true;
            this.rbSociosProcJudConConv.Location = new System.Drawing.Point(22, 42);
            this.rbSociosProcJudConConv.Name = "rbSociosProcJudConConv";
            this.rbSociosProcJudConConv.Size = new System.Drawing.Size(256, 17);
            this.rbSociosProcJudConConv.TabIndex = 1;
            this.rbSociosProcJudConConv.TabStop = true;
            this.rbSociosProcJudConConv.Text = "Socios en proceso judicial con convenios (todos)";
            this.rbSociosProcJudConConv.UseVisualStyleBackColor = true;
            // 
            // rbSociosProcJudSinConv
            // 
            this.rbSociosProcJudSinConv.AutoSize = true;
            this.rbSociosProcJudSinConv.Location = new System.Drawing.Point(22, 19);
            this.rbSociosProcJudSinConv.Name = "rbSociosProcJudSinConv";
            this.rbSociosProcJudSinConv.Size = new System.Drawing.Size(216, 17);
            this.rbSociosProcJudSinConv.TabIndex = 0;
            this.rbSociosProcJudSinConv.Text = "Socios en proceso judicial sin convenios";
            this.rbSociosProcJudSinConv.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSalir);
            this.groupBox4.Controls.Add(this.btnGenerarListado);
            this.groupBox4.Location = new System.Drawing.Point(493, 185);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(198, 118);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(34, 74);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(136, 31);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGenerarListado
            // 
            this.btnGenerarListado.Location = new System.Drawing.Point(34, 27);
            this.btnGenerarListado.Name = "btnGenerarListado";
            this.btnGenerarListado.Size = new System.Drawing.Size(136, 32);
            this.btnGenerarListado.TabIndex = 0;
            this.btnGenerarListado.Text = "Generar listado";
            this.btnGenerarListado.UseVisualStyleBackColor = true;
            // 
            // frmSociosEnProcesoJudicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 311);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gbIncluir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSociosEnProcesoJudicial";
            this.Text = "Listado de Socios en Proceso Judicial";
            this.Load += new System.EventHandler(this.frmSociosEnProcesoJudicial_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.gbIncluir.ResumeLayout(false);
            this.gbIncluir.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbIncluir;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCrearFiltro;
        private System.Windows.Forms.ComboBox cmbBarrio;
        private System.Windows.Forms.RadioButton rbFiltros;
        private System.Windows.Forms.RadioButton rbSeleccionarBarrio;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbImporteConvenio;
        private System.Windows.Forms.RadioButton rbCantidadCuotas;
        private System.Windows.Forms.RadioButton rbFechaConvenio;
        private System.Windows.Forms.RadioButton rbNombreBarrio;
        private System.Windows.Forms.RadioButton rbApellidoNombre;
        private System.Windows.Forms.RadioButton rbNumeroSocio;
        private System.Windows.Forms.RadioButton rbDescendente;
        private System.Windows.Forms.RadioButton rbAscendente;
        private System.Windows.Forms.RadioButton rbSociosProcJudConConvFinalizados;
        private System.Windows.Forms.RadioButton rbSociosProcJudConConvSinFin;
        private System.Windows.Forms.RadioButton rbSociosProcJudConConv;
        private System.Windows.Forms.RadioButton rbSociosProcJudSinConv;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGenerarListado;
    }
}