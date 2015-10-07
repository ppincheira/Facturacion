namespace com.cooperativa.view
{
    partial class frmSociosEnSituacionEspecial
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGenerarListado = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbDescendente = new System.Windows.Forms.RadioButton();
            this.rbAscendente = new System.Windows.Forms.RadioButton();
            this.rbBarrioNombre = new System.Windows.Forms.RadioButton();
            this.rbBarrioYNroSocio = new System.Windows.Forms.RadioButton();
            this.rbApellidoNombre = new System.Windows.Forms.RadioButton();
            this.rbNumeroSocio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCrearFiltro = new System.Windows.Forms.Button();
            this.cmbBarrio = new System.Windows.Forms.ComboBox();
            this.rbFiltros = new System.Windows.Forms.RadioButton();
            this.rbSeleccionarBarrio = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSalir);
            this.groupBox4.Controls.Add(this.btnGenerarListado);
            this.groupBox4.Location = new System.Drawing.Point(385, 151);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(319, 58);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(167, 19);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(136, 33);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGenerarListado
            // 
            this.btnGenerarListado.Location = new System.Drawing.Point(23, 19);
            this.btnGenerarListado.Name = "btnGenerarListado";
            this.btnGenerarListado.Size = new System.Drawing.Size(119, 33);
            this.btnGenerarListado.TabIndex = 0;
            this.btnGenerarListado.Text = "Generar listado";
            this.btnGenerarListado.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.rbBarrioNombre);
            this.groupBox2.Controls.Add(this.rbBarrioYNroSocio);
            this.groupBox2.Controls.Add(this.rbApellidoNombre);
            this.groupBox2.Controls.Add(this.rbNumeroSocio);
            this.groupBox2.Location = new System.Drawing.Point(372, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 133);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ordenar por...";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbDescendente);
            this.groupBox5.Controls.Add(this.rbAscendente);
            this.groupBox5.Location = new System.Drawing.Point(194, 30);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCrearFiltro);
            this.groupBox1.Controls.Add(this.cmbBarrio);
            this.groupBox1.Controls.Add(this.rbFiltros);
            this.groupBox1.Controls.Add(this.rbSeleccionarBarrio);
            this.groupBox1.Controls.Add(this.rbTodos);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 197);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generar listado de...";
            // 
            // btnCrearFiltro
            // 
            this.btnCrearFiltro.Enabled = false;
            this.btnCrearFiltro.Location = new System.Drawing.Point(153, 100);
            this.btnCrearFiltro.Name = "btnCrearFiltro";
            this.btnCrearFiltro.Size = new System.Drawing.Size(122, 28);
            this.btnCrearFiltro.TabIndex = 10;
            this.btnCrearFiltro.Text = "Crear filtro >>>";
            this.btnCrearFiltro.UseVisualStyleBackColor = true;
            // 
            // cmbBarrio
            // 
            this.cmbBarrio.Enabled = false;
            this.cmbBarrio.FormattingEnabled = true;
            this.cmbBarrio.Location = new System.Drawing.Point(153, 68);
            this.cmbBarrio.Name = "cmbBarrio";
            this.cmbBarrio.Size = new System.Drawing.Size(195, 21);
            this.cmbBarrio.TabIndex = 11;
            // 
            // rbFiltros
            // 
            this.rbFiltros.AutoSize = true;
            this.rbFiltros.Location = new System.Drawing.Point(22, 105);
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
            this.rbSeleccionarBarrio.Location = new System.Drawing.Point(22, 68);
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
            this.rbTodos.Location = new System.Drawing.Point(22, 30);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(55, 17);
            this.rbTodos.TabIndex = 6;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // frmSociosEnSituacionEspecial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 222);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSociosEnSituacionEspecial";
            this.Text = "Socios en situación especial";
            this.Load += new System.EventHandler(this.frmSociosEnSituacionEspecial_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGenerarListado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbDescendente;
        private System.Windows.Forms.RadioButton rbAscendente;
        private System.Windows.Forms.RadioButton rbBarrioNombre;
        private System.Windows.Forms.RadioButton rbBarrioYNroSocio;
        private System.Windows.Forms.RadioButton rbApellidoNombre;
        private System.Windows.Forms.RadioButton rbNumeroSocio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCrearFiltro;
        private System.Windows.Forms.ComboBox cmbBarrio;
        private System.Windows.Forms.RadioButton rbFiltros;
        private System.Windows.Forms.RadioButton rbSeleccionarBarrio;
        private System.Windows.Forms.RadioButton rbTodos;
    }
}