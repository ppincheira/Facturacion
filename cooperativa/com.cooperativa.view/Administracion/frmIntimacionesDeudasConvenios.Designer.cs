namespace com.cooperativa.view
{
    partial class frmIntimacionesDeudasConvenios
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
            this.gpGenerar = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCopias = new System.Windows.Forms.TextBox();
            this.btnCrearFiltro = new System.Windows.Forms.Button();
            this.cmbBarrio = new System.Windows.Forms.ComboBox();
            this.rbIntimacionBlanco = new System.Windows.Forms.RadioButton();
            this.rbFiltros = new System.Windows.Forms.RadioButton();
            this.rbSeleccionarBarrio = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbCuotasVencidas = new System.Windows.Forms.GroupBox();
            this.rbTodosLosConvenios = new System.Windows.Forms.RadioButton();
            this.rbConveniosFirmados = new System.Windows.Forms.RadioButton();
            this.chkImprimirSoloDeuda = new System.Windows.Forms.CheckBox();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkExcluirSocios = new System.Windows.Forms.CheckBox();
            this.rbConveniosNoVolcados = new System.Windows.Forms.RadioButton();
            this.rbCuotasConveniosVencidas = new System.Windows.Forms.RadioButton();
            this.rbFacturasVencidas = new System.Windows.Forms.RadioButton();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gpGenerar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbCuotasVencidas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpGenerar
            // 
            this.gpGenerar.Controls.Add(this.label3);
            this.gpGenerar.Controls.Add(this.txtCopias);
            this.gpGenerar.Controls.Add(this.btnCrearFiltro);
            this.gpGenerar.Controls.Add(this.cmbBarrio);
            this.gpGenerar.Controls.Add(this.rbIntimacionBlanco);
            this.gpGenerar.Controls.Add(this.rbFiltros);
            this.gpGenerar.Controls.Add(this.rbSeleccionarBarrio);
            this.gpGenerar.Controls.Add(this.rbTodos);
            this.gpGenerar.Location = new System.Drawing.Point(12, 12);
            this.gpGenerar.Name = "gpGenerar";
            this.gpGenerar.Size = new System.Drawing.Size(348, 319);
            this.gpGenerar.TabIndex = 0;
            this.gpGenerar.TabStop = false;
            this.gpGenerar.Text = "Generar avisos de deuda de ...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Copias";
            // 
            // txtCopias
            // 
            this.txtCopias.Enabled = false;
            this.txtCopias.Location = new System.Drawing.Point(167, 161);
            this.txtCopias.Name = "txtCopias";
            this.txtCopias.Size = new System.Drawing.Size(61, 20);
            this.txtCopias.TabIndex = 14;
            // 
            // btnCrearFiltro
            // 
            this.btnCrearFiltro.Enabled = false;
            this.btnCrearFiltro.Location = new System.Drawing.Point(134, 113);
            this.btnCrearFiltro.Name = "btnCrearFiltro";
            this.btnCrearFiltro.Size = new System.Drawing.Size(115, 23);
            this.btnCrearFiltro.TabIndex = 5;
            this.btnCrearFiltro.Text = "Crear filtro >>>";
            this.btnCrearFiltro.UseVisualStyleBackColor = true;
            // 
            // cmbBarrio
            // 
            this.cmbBarrio.Enabled = false;
            this.cmbBarrio.FormattingEnabled = true;
            this.cmbBarrio.Location = new System.Drawing.Point(134, 67);
            this.cmbBarrio.Name = "cmbBarrio";
            this.cmbBarrio.Size = new System.Drawing.Size(208, 21);
            this.cmbBarrio.TabIndex = 5;
            // 
            // rbIntimacionBlanco
            // 
            this.rbIntimacionBlanco.AutoSize = true;
            this.rbIntimacionBlanco.Location = new System.Drawing.Point(13, 161);
            this.rbIntimacionBlanco.Name = "rbIntimacionBlanco";
            this.rbIntimacionBlanco.Size = new System.Drawing.Size(123, 17);
            this.rbIntimacionBlanco.TabIndex = 3;
            this.rbIntimacionBlanco.TabStop = true;
            this.rbIntimacionBlanco.Text = "Intimacion en blanco";
            this.rbIntimacionBlanco.UseVisualStyleBackColor = true;
            this.rbIntimacionBlanco.CheckedChanged += new System.EventHandler(this.rbIntimacionBlanco_CheckedChanged);
            // 
            // rbFiltros
            // 
            this.rbFiltros.AutoSize = true;
            this.rbFiltros.Location = new System.Drawing.Point(13, 113);
            this.rbFiltros.Name = "rbFiltros";
            this.rbFiltros.Size = new System.Drawing.Size(107, 17);
            this.rbFiltros.TabIndex = 2;
            this.rbFiltros.TabStop = true;
            this.rbFiltros.Text = "Filtros avanzados";
            this.rbFiltros.UseVisualStyleBackColor = true;
            this.rbFiltros.CheckedChanged += new System.EventHandler(this.rbFiltros_CheckedChanged);
            // 
            // rbSeleccionarBarrio
            // 
            this.rbSeleccionarBarrio.AutoSize = true;
            this.rbSeleccionarBarrio.Location = new System.Drawing.Point(13, 69);
            this.rbSeleccionarBarrio.Name = "rbSeleccionarBarrio";
            this.rbSeleccionarBarrio.Size = new System.Drawing.Size(125, 17);
            this.rbSeleccionarBarrio.TabIndex = 1;
            this.rbSeleccionarBarrio.TabStop = true;
            this.rbSeleccionarBarrio.Text = "Seleccionar un barrio";
            this.rbSeleccionarBarrio.UseVisualStyleBackColor = true;
            this.rbSeleccionarBarrio.CheckedChanged += new System.EventHandler(this.rbSeleccionarBarrio_CheckedChanged);
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Location = new System.Drawing.Point(13, 27);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(55, 17);
            this.rbTodos.TabIndex = 0;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gbCuotasVencidas);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.chkExcluirSocios);
            this.groupBox2.Controls.Add(this.rbConveniosNoVolcados);
            this.groupBox2.Controls.Add(this.rbCuotasConveniosVencidas);
            this.groupBox2.Controls.Add(this.rbFacturasVencidas);
            this.groupBox2.Location = new System.Drawing.Point(377, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 319);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Análisis de deuda para intimación";
            // 
            // gbCuotasVencidas
            // 
            this.gbCuotasVencidas.Controls.Add(this.rbTodosLosConvenios);
            this.gbCuotasVencidas.Controls.Add(this.rbConveniosFirmados);
            this.gbCuotasVencidas.Controls.Add(this.chkImprimirSoloDeuda);
            this.gbCuotasVencidas.Controls.Add(this.txtHasta);
            this.gbCuotasVencidas.Controls.Add(this.label2);
            this.gbCuotasVencidas.Controls.Add(this.txtDesde);
            this.gbCuotasVencidas.Enabled = false;
            this.gbCuotasVencidas.Location = new System.Drawing.Point(54, 96);
            this.gbCuotasVencidas.Name = "gbCuotasVencidas";
            this.gbCuotasVencidas.Size = new System.Drawing.Size(215, 121);
            this.gbCuotasVencidas.TabIndex = 15;
            this.gbCuotasVencidas.TabStop = false;
            this.gbCuotasVencidas.Visible = false;
            // 
            // rbTodosLosConvenios
            // 
            this.rbTodosLosConvenios.AutoSize = true;
            this.rbTodosLosConvenios.Location = new System.Drawing.Point(6, 10);
            this.rbTodosLosConvenios.Name = "rbTodosLosConvenios";
            this.rbTodosLosConvenios.Size = new System.Drawing.Size(123, 17);
            this.rbTodosLosConvenios.TabIndex = 9;
            this.rbTodosLosConvenios.TabStop = true;
            this.rbTodosLosConvenios.Text = "Todos los convenios";
            this.rbTodosLosConvenios.UseVisualStyleBackColor = true;
            // 
            // rbConveniosFirmados
            // 
            this.rbConveniosFirmados.AutoSize = true;
            this.rbConveniosFirmados.Location = new System.Drawing.Point(6, 33);
            this.rbConveniosFirmados.Name = "rbConveniosFirmados";
            this.rbConveniosFirmados.Size = new System.Drawing.Size(163, 17);
            this.rbConveniosFirmados.TabIndex = 10;
            this.rbConveniosFirmados.TabStop = true;
            this.rbConveniosFirmados.Text = "Convenios firmados desde el ";
            this.rbConveniosFirmados.UseVisualStyleBackColor = true;
            this.rbConveniosFirmados.CheckedChanged += new System.EventHandler(this.rbConveniosFirmados_CheckedChanged);
            // 
            // chkImprimirSoloDeuda
            // 
            this.chkImprimirSoloDeuda.AutoSize = true;
            this.chkImprimirSoloDeuda.Location = new System.Drawing.Point(6, 88);
            this.chkImprimirSoloDeuda.Name = "chkImprimirSoloDeuda";
            this.chkImprimirSoloDeuda.Size = new System.Drawing.Size(163, 17);
            this.chkImprimirSoloDeuda.TabIndex = 13;
            this.chkImprimirSoloDeuda.Text = "Imprimir solo deuda convenio";
            this.chkImprimirSoloDeuda.UseVisualStyleBackColor = true;
            // 
            // txtHasta
            // 
            this.txtHasta.Enabled = false;
            this.txtHasta.Location = new System.Drawing.Point(148, 61);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(61, 20);
            this.txtHasta.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "hasta el";
            // 
            // txtDesde
            // 
            this.txtDesde.Enabled = false;
            this.txtDesde.Location = new System.Drawing.Point(37, 61);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(61, 20);
            this.txtDesde.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "(No se incluyen facturas que aún no han vencido)";
            // 
            // chkExcluirSocios
            // 
            this.chkExcluirSocios.AutoSize = true;
            this.chkExcluirSocios.Location = new System.Drawing.Point(60, 50);
            this.chkExcluirSocios.Name = "chkExcluirSocios";
            this.chkExcluirSocios.Size = new System.Drawing.Size(259, 17);
            this.chkExcluirSocios.TabIndex = 8;
            this.chkExcluirSocios.Text = "Excluir socios con cuotas de convenios vencidas";
            this.chkExcluirSocios.UseVisualStyleBackColor = true;
            // 
            // rbConveniosNoVolcados
            // 
            this.rbConveniosNoVolcados.AutoSize = true;
            this.rbConveniosNoVolcados.Location = new System.Drawing.Point(24, 223);
            this.rbConveniosNoVolcados.Name = "rbConveniosNoVolcados";
            this.rbConveniosNoVolcados.Size = new System.Drawing.Size(139, 17);
            this.rbConveniosNoVolcados.TabIndex = 7;
            this.rbConveniosNoVolcados.TabStop = true;
            this.rbConveniosNoVolcados.Text = "Convenios no volcados ";
            this.rbConveniosNoVolcados.UseVisualStyleBackColor = true;
            // 
            // rbCuotasConveniosVencidas
            // 
            this.rbCuotasConveniosVencidas.AutoSize = true;
            this.rbCuotasConveniosVencidas.Location = new System.Drawing.Point(36, 73);
            this.rbCuotasConveniosVencidas.Name = "rbCuotasConveniosVencidas";
            this.rbCuotasConveniosVencidas.Size = new System.Drawing.Size(166, 17);
            this.rbCuotasConveniosVencidas.TabIndex = 5;
            this.rbCuotasConveniosVencidas.TabStop = true;
            this.rbCuotasConveniosVencidas.Text = "Cuotas de convenio vencidas";
            this.rbCuotasConveniosVencidas.UseVisualStyleBackColor = true;
            this.rbCuotasConveniosVencidas.CheckedChanged += new System.EventHandler(this.rbCuotasConveniosVencidas_CheckedChanged);
            // 
            // rbFacturasVencidas
            // 
            this.rbFacturasVencidas.AutoSize = true;
            this.rbFacturasVencidas.Location = new System.Drawing.Point(36, 27);
            this.rbFacturasVencidas.Name = "rbFacturasVencidas";
            this.rbFacturasVencidas.Size = new System.Drawing.Size(112, 17);
            this.rbFacturasVencidas.TabIndex = 4;
            this.rbFacturasVencidas.TabStop = true;
            this.rbFacturasVencidas.Text = "Facturas vencidas";
            this.rbFacturasVencidas.UseVisualStyleBackColor = true;
            this.rbFacturasVencidas.CheckedChanged += new System.EventHandler(this.rbFacturasVencidas_CheckedChanged);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Enabled = false;
            this.btnAnterior.Location = new System.Drawing.Point(264, 358);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(129, 30);
            this.btnAnterior.TabIndex = 2;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(446, 358);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(133, 30);
            this.btnSiguiente.TabIndex = 3;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(617, 358);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(135, 30);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmIntimacionesDeudasConvenios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 403);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gpGenerar);
            this.Name = "frmIntimacionesDeudasConvenios";
            this.Text = "Asistente para intimaciones por Deuda";
            this.Load += new System.EventHandler(this.frmIntimacionesDeudasConvenios_Load);
            this.gpGenerar.ResumeLayout(false);
            this.gpGenerar.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbCuotasVencidas.ResumeLayout(false);
            this.gbCuotasVencidas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpGenerar;
        private System.Windows.Forms.RadioButton rbIntimacionBlanco;
        private System.Windows.Forms.RadioButton rbFiltros;
        private System.Windows.Forms.RadioButton rbSeleccionarBarrio;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkImprimirSoloDeuda;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbConveniosFirmados;
        private System.Windows.Forms.RadioButton rbTodosLosConvenios;
        private System.Windows.Forms.CheckBox chkExcluirSocios;
        private System.Windows.Forms.RadioButton rbConveniosNoVolcados;
        private System.Windows.Forms.RadioButton rbCuotasConveniosVencidas;
        private System.Windows.Forms.RadioButton rbFacturasVencidas;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cmbBarrio;
        private System.Windows.Forms.Button btnCrearFiltro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCopias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbCuotasVencidas;
    }
}