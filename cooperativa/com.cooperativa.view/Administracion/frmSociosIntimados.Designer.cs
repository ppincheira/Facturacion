namespace com.cooperativa.view
{
    partial class frmSociosIntimados
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
            this.rbBarrioNombre = new System.Windows.Forms.RadioButton();
            this.rbBarrioYNroSocio = new System.Windows.Forms.RadioButton();
            this.rbApellidoNombre = new System.Windows.Forms.RadioButton();
            this.rbNumeroSocio = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbTipoIntimacion = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbRangoMeses = new System.Windows.Forms.RadioButton();
            this.rbEntreDosFechas = new System.Windows.Forms.RadioButton();
            this.rbMesDeterminado = new System.Windows.Forms.RadioButton();
            this.rbFechaEspecifica = new System.Windows.Forms.RadioButton();
            this.rbTodas = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cmbAnio = new System.Windows.Forms.ComboBox();
            this.rbSociosSinPagareFirmado = new System.Windows.Forms.RadioButton();
            this.rbSociosPagareFirmado = new System.Windows.Forms.RadioButton();
            this.rbTodosLosSocios = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.rbTipo3 = new System.Windows.Forms.RadioButton();
            this.rbTipo2 = new System.Windows.Forms.RadioButton();
            this.rbBasico = new System.Windows.Forms.RadioButton();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGenerarListado = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(321, 133);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generar listado de...";
            // 
            // btnCrearFiltro
            // 
            this.btnCrearFiltro.Enabled = false;
            this.btnCrearFiltro.Location = new System.Drawing.Point(128, 105);
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
            this.cmbBarrio.Location = new System.Drawing.Point(128, 66);
            this.cmbBarrio.Name = "cmbBarrio";
            this.cmbBarrio.Size = new System.Drawing.Size(187, 21);
            this.cmbBarrio.TabIndex = 11;
            // 
            // rbFiltros
            // 
            this.rbFiltros.AutoSize = true;
            this.rbFiltros.Location = new System.Drawing.Point(7, 105);
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
            this.rbSeleccionarBarrio.Location = new System.Drawing.Point(7, 67);
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
            this.rbTodos.Location = new System.Drawing.Point(7, 30);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(55, 17);
            this.rbTodos.TabIndex = 6;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.rbBarrioNombre);
            this.groupBox2.Controls.Add(this.rbBarrioYNroSocio);
            this.groupBox2.Controls.Add(this.rbApellidoNombre);
            this.groupBox2.Controls.Add(this.rbNumeroSocio);
            this.groupBox2.Location = new System.Drawing.Point(339, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 133);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ordenar por...";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbDescendente);
            this.groupBox5.Controls.Add(this.rbAscendente);
            this.groupBox5.Location = new System.Drawing.Point(171, 30);
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
            // rbBarrioNombre
            // 
            this.rbBarrioNombre.AutoSize = true;
            this.rbBarrioNombre.Location = new System.Drawing.Point(23, 105);
            this.rbBarrioNombre.Name = "rbBarrioNombre";
            this.rbBarrioNombre.Size = new System.Drawing.Size(98, 17);
            this.rbBarrioNombre.TabIndex = 3;
            this.rbBarrioNombre.Text = "Barrio y nombre";
            this.rbBarrioNombre.UseVisualStyleBackColor = true;
            // 
            // rbBarrioYNroSocio
            // 
            this.rbBarrioYNroSocio.AutoSize = true;
            this.rbBarrioYNroSocio.Location = new System.Drawing.Point(23, 76);
            this.rbBarrioYNroSocio.Name = "rbBarrioYNroSocio";
            this.rbBarrioYNroSocio.Size = new System.Drawing.Size(108, 17);
            this.rbBarrioYNroSocio.TabIndex = 2;
            this.rbBarrioYNroSocio.Text = "Barrio y Nro socio";
            this.rbBarrioYNroSocio.UseVisualStyleBackColor = true;
            // 
            // rbApellidoNombre
            // 
            this.rbApellidoNombre.AutoSize = true;
            this.rbApellidoNombre.Location = new System.Drawing.Point(23, 53);
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
            this.rbNumeroSocio.Location = new System.Drawing.Point(23, 30);
            this.rbNumeroSocio.Name = "rbNumeroSocio";
            this.rbNumeroSocio.Size = new System.Drawing.Size(105, 17);
            this.rbNumeroSocio.TabIndex = 0;
            this.rbNumeroSocio.TabStop = true;
            this.rbNumeroSocio.Text = "Numero de socio";
            this.rbNumeroSocio.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbTipoIntimacion);
            this.groupBox3.Location = new System.Drawing.Point(12, 145);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 72);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo de intimacion";
            // 
            // cmbTipoIntimacion
            // 
            this.cmbTipoIntimacion.FormattingEnabled = true;
            this.cmbTipoIntimacion.Location = new System.Drawing.Point(22, 30);
            this.cmbTipoIntimacion.Name = "cmbTipoIntimacion";
            this.cmbTipoIntimacion.Size = new System.Drawing.Size(277, 21);
            this.cmbTipoIntimacion.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbRangoMeses);
            this.groupBox4.Controls.Add(this.rbEntreDosFechas);
            this.groupBox4.Controls.Add(this.rbMesDeterminado);
            this.groupBox4.Controls.Add(this.rbFechaEspecifica);
            this.groupBox4.Controls.Add(this.rbTodas);
            this.groupBox4.Location = new System.Drawing.Point(12, 223);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(321, 190);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fecha de intimacion";
            // 
            // rbRangoMeses
            // 
            this.rbRangoMeses.AutoSize = true;
            this.rbRangoMeses.Location = new System.Drawing.Point(22, 125);
            this.rbRangoMeses.Name = "rbRangoMeses";
            this.rbRangoMeses.Size = new System.Drawing.Size(105, 17);
            this.rbRangoMeses.TabIndex = 4;
            this.rbRangoMeses.Text = "Rango de meses";
            this.rbRangoMeses.UseVisualStyleBackColor = true;
            // 
            // rbEntreDosFechas
            // 
            this.rbEntreDosFechas.AutoSize = true;
            this.rbEntreDosFechas.Location = new System.Drawing.Point(22, 102);
            this.rbEntreDosFechas.Name = "rbEntreDosFechas";
            this.rbEntreDosFechas.Size = new System.Drawing.Size(105, 17);
            this.rbEntreDosFechas.TabIndex = 3;
            this.rbEntreDosFechas.Text = "Entre dos fechas";
            this.rbEntreDosFechas.UseVisualStyleBackColor = true;
            // 
            // rbMesDeterminado
            // 
            this.rbMesDeterminado.AutoSize = true;
            this.rbMesDeterminado.Location = new System.Drawing.Point(22, 79);
            this.rbMesDeterminado.Name = "rbMesDeterminado";
            this.rbMesDeterminado.Size = new System.Drawing.Size(122, 17);
            this.rbMesDeterminado.TabIndex = 2;
            this.rbMesDeterminado.Text = "Un mes determinado";
            this.rbMesDeterminado.UseVisualStyleBackColor = true;
            // 
            // rbFechaEspecifica
            // 
            this.rbFechaEspecifica.AutoSize = true;
            this.rbFechaEspecifica.Location = new System.Drawing.Point(21, 56);
            this.rbFechaEspecifica.Name = "rbFechaEspecifica";
            this.rbFechaEspecifica.Size = new System.Drawing.Size(126, 17);
            this.rbFechaEspecifica.TabIndex = 1;
            this.rbFechaEspecifica.Text = "Una fecha especifica";
            this.rbFechaEspecifica.UseVisualStyleBackColor = true;
            // 
            // rbTodas
            // 
            this.rbTodas.AutoSize = true;
            this.rbTodas.Checked = true;
            this.rbTodas.Location = new System.Drawing.Point(22, 33);
            this.rbTodas.Name = "rbTodas";
            this.rbTodas.Size = new System.Drawing.Size(55, 17);
            this.rbTodas.TabIndex = 0;
            this.rbTodas.TabStop = true;
            this.rbTodas.Text = "Todas";
            this.rbTodas.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cmbAnio);
            this.groupBox6.Controls.Add(this.rbSociosSinPagareFirmado);
            this.groupBox6.Controls.Add(this.rbSociosPagareFirmado);
            this.groupBox6.Controls.Add(this.rbTodosLosSocios);
            this.groupBox6.Location = new System.Drawing.Point(339, 146);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(319, 97);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Otras opciones";
            // 
            // cmbAnio
            // 
            this.cmbAnio.Enabled = false;
            this.cmbAnio.FormattingEnabled = true;
            this.cmbAnio.Location = new System.Drawing.Point(171, 45);
            this.cmbAnio.Name = "cmbAnio";
            this.cmbAnio.Size = new System.Drawing.Size(121, 21);
            this.cmbAnio.TabIndex = 4;
            // 
            // rbSociosSinPagareFirmado
            // 
            this.rbSociosSinPagareFirmado.AutoSize = true;
            this.rbSociosSinPagareFirmado.Location = new System.Drawing.Point(23, 72);
            this.rbSociosSinPagareFirmado.Name = "rbSociosSinPagareFirmado";
            this.rbSociosSinPagareFirmado.Size = new System.Drawing.Size(146, 17);
            this.rbSociosSinPagareFirmado.TabIndex = 2;
            this.rbSociosSinPagareFirmado.Text = "Socios sin pagaré firmado";
            this.rbSociosSinPagareFirmado.UseVisualStyleBackColor = true;
            // 
            // rbSociosPagareFirmado
            // 
            this.rbSociosPagareFirmado.AutoSize = true;
            this.rbSociosPagareFirmado.Location = new System.Drawing.Point(23, 49);
            this.rbSociosPagareFirmado.Name = "rbSociosPagareFirmado";
            this.rbSociosPagareFirmado.Size = new System.Drawing.Size(151, 17);
            this.rbSociosPagareFirmado.TabIndex = 1;
            this.rbSociosPagareFirmado.Text = "Socios con pagaré firmado";
            this.rbSociosPagareFirmado.UseVisualStyleBackColor = true;
            this.rbSociosPagareFirmado.CheckedChanged += new System.EventHandler(this.rbSociosPagareFirmado_CheckedChanged);
            // 
            // rbTodosLosSocios
            // 
            this.rbTodosLosSocios.AutoSize = true;
            this.rbTodosLosSocios.Checked = true;
            this.rbTodosLosSocios.Location = new System.Drawing.Point(23, 24);
            this.rbTodosLosSocios.Name = "rbTodosLosSocios";
            this.rbTodosLosSocios.Size = new System.Drawing.Size(104, 17);
            this.rbTodosLosSocios.TabIndex = 0;
            this.rbTodosLosSocios.TabStop = true;
            this.rbTodosLosSocios.Text = "Todos los socios";
            this.rbTodosLosSocios.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.rbTipo3);
            this.groupBox7.Controls.Add(this.rbTipo2);
            this.groupBox7.Controls.Add(this.rbBasico);
            this.groupBox7.Location = new System.Drawing.Point(339, 244);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(319, 123);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Tipo de reporte";
            // 
            // rbTipo3
            // 
            this.rbTipo3.AutoSize = true;
            this.rbTipo3.Enabled = false;
            this.rbTipo3.Location = new System.Drawing.Point(23, 83);
            this.rbTipo3.Name = "rbTipo3";
            this.rbTipo3.Size = new System.Drawing.Size(126, 17);
            this.rbTipo3.TabIndex = 2;
            this.rbTipo3.Text = "Tipo 3 (no disponible)";
            this.rbTipo3.UseVisualStyleBackColor = true;
            // 
            // rbTipo2
            // 
            this.rbTipo2.AutoSize = true;
            this.rbTipo2.Enabled = false;
            this.rbTipo2.Location = new System.Drawing.Point(23, 60);
            this.rbTipo2.Name = "rbTipo2";
            this.rbTipo2.Size = new System.Drawing.Size(126, 17);
            this.rbTipo2.TabIndex = 1;
            this.rbTipo2.Text = "Tipo 2 (no disponible)";
            this.rbTipo2.UseVisualStyleBackColor = true;
            // 
            // rbBasico
            // 
            this.rbBasico.AutoSize = true;
            this.rbBasico.Checked = true;
            this.rbBasico.Location = new System.Drawing.Point(23, 37);
            this.rbBasico.Name = "rbBasico";
            this.rbBasico.Size = new System.Drawing.Size(235, 17);
            this.rbBasico.TabIndex = 0;
            this.rbBasico.TabStop = true;
            this.rbBasico.Text = "Básico (socio, domicilio, fecha de intimación)";
            this.rbBasico.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnSalir);
            this.groupBox8.Controls.Add(this.btnGenerarListado);
            this.groupBox8.Location = new System.Drawing.Point(339, 370);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(319, 43);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(167, 13);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(136, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGenerarListado
            // 
            this.btnGenerarListado.Location = new System.Drawing.Point(23, 13);
            this.btnGenerarListado.Name = "btnGenerarListado";
            this.btnGenerarListado.Size = new System.Drawing.Size(119, 23);
            this.btnGenerarListado.TabIndex = 0;
            this.btnGenerarListado.Text = "Generar listado";
            this.btnGenerarListado.UseVisualStyleBackColor = true;
            // 
            // frmSociosIntimados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 420);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSociosIntimados";
            this.Text = "Listado de socios intimados por deudas";
            this.Load += new System.EventHandler(this.frmSociosIntimados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCrearFiltro;
        private System.Windows.Forms.ComboBox cmbBarrio;
        private System.Windows.Forms.RadioButton rbFiltros;
        private System.Windows.Forms.RadioButton rbSeleccionarBarrio;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbDescendente;
        private System.Windows.Forms.RadioButton rbAscendente;
        private System.Windows.Forms.RadioButton rbBarrioNombre;
        private System.Windows.Forms.RadioButton rbBarrioYNroSocio;
        private System.Windows.Forms.RadioButton rbApellidoNombre;
        private System.Windows.Forms.RadioButton rbNumeroSocio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbTipoIntimacion;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbRangoMeses;
        private System.Windows.Forms.RadioButton rbEntreDosFechas;
        private System.Windows.Forms.RadioButton rbMesDeterminado;
        private System.Windows.Forms.RadioButton rbFechaEspecifica;
        private System.Windows.Forms.RadioButton rbTodas;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cmbAnio;
        private System.Windows.Forms.RadioButton rbSociosSinPagareFirmado;
        private System.Windows.Forms.RadioButton rbSociosPagareFirmado;
        private System.Windows.Forms.RadioButton rbTodosLosSocios;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton rbTipo3;
        private System.Windows.Forms.RadioButton rbTipo2;
        private System.Windows.Forms.RadioButton rbBasico;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGenerarListado;
    }
}