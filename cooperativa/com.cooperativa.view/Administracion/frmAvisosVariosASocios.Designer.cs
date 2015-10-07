namespace com.cooperativa.view
{
    partial class frmAvisosVariosASocios
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbNombreApellido = new System.Windows.Forms.RadioButton();
            this.rbNumeroSocio = new System.Windows.Forms.RadioButton();
            this.rbBarrioManzLote = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPeriodos = new System.Windows.Forms.TextBox();
            this.rbSociosSinDeuda = new System.Windows.Forms.RadioButton();
            this.rbSociosQueAdeudan = new System.Windows.Forms.RadioButton();
            this.rbTodosSocios = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCrearAvisos = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtTextoAviso = new System.Windows.Forms.TextBox();
            this.rbUsarSiguienteTexto = new System.Windows.Forms.RadioButton();
            this.rbRegularizarCambioCategoria = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbDescendente = new System.Windows.Forms.RadioButton();
            this.rbAscendente = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(319, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generar avisos para...";
            // 
            // btnCrearFiltro
            // 
            this.btnCrearFiltro.Enabled = false;
            this.btnCrearFiltro.Location = new System.Drawing.Point(132, 74);
            this.btnCrearFiltro.Name = "btnCrearFiltro";
            this.btnCrearFiltro.Size = new System.Drawing.Size(138, 23);
            this.btnCrearFiltro.TabIndex = 16;
            this.btnCrearFiltro.Text = "Crear filtro >>>";
            this.btnCrearFiltro.UseVisualStyleBackColor = true;
            // 
            // cmbBarrio
            // 
            this.cmbBarrio.Enabled = false;
            this.cmbBarrio.FormattingEnabled = true;
            this.cmbBarrio.Location = new System.Drawing.Point(132, 48);
            this.cmbBarrio.Name = "cmbBarrio";
            this.cmbBarrio.Size = new System.Drawing.Size(181, 21);
            this.cmbBarrio.TabIndex = 17;
            // 
            // rbFiltros
            // 
            this.rbFiltros.AutoSize = true;
            this.rbFiltros.Location = new System.Drawing.Point(10, 77);
            this.rbFiltros.Name = "rbFiltros";
            this.rbFiltros.Size = new System.Drawing.Size(107, 17);
            this.rbFiltros.TabIndex = 14;
            this.rbFiltros.Text = "Filtros avanzados";
            this.rbFiltros.UseVisualStyleBackColor = true;
            this.rbFiltros.CheckedChanged += new System.EventHandler(this.rbFiltros_CheckedChanged);
            // 
            // rbSeleccionarBarrio
            // 
            this.rbSeleccionarBarrio.AutoSize = true;
            this.rbSeleccionarBarrio.Checked = true;
            this.rbSeleccionarBarrio.Location = new System.Drawing.Point(10, 48);
            this.rbSeleccionarBarrio.Name = "rbSeleccionarBarrio";
            this.rbSeleccionarBarrio.Size = new System.Drawing.Size(125, 17);
            this.rbSeleccionarBarrio.TabIndex = 13;
            this.rbSeleccionarBarrio.TabStop = true;
            this.rbSeleccionarBarrio.Text = "Seleccionar un barrio";
            this.rbSeleccionarBarrio.UseVisualStyleBackColor = true;
            this.rbSeleccionarBarrio.CheckedChanged += new System.EventHandler(this.rbSeleccionarBarrio_CheckedChanged);
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Location = new System.Drawing.Point(12, 19);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(105, 17);
            this.rbTodos.TabIndex = 12;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos los barrios";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbNombreApellido);
            this.groupBox3.Controls.Add(this.rbNumeroSocio);
            this.groupBox3.Controls.Add(this.rbBarrioManzLote);
            this.groupBox3.Location = new System.Drawing.Point(12, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(146, 94);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ordenar por...";
            // 
            // rbNombreApellido
            // 
            this.rbNombreApellido.AutoSize = true;
            this.rbNombreApellido.Location = new System.Drawing.Point(12, 66);
            this.rbNombreApellido.Name = "rbNombreApellido";
            this.rbNombreApellido.Size = new System.Drawing.Size(109, 17);
            this.rbNombreApellido.TabIndex = 2;
            this.rbNombreApellido.TabStop = true;
            this.rbNombreApellido.Text = "Nombre y apellido";
            this.rbNombreApellido.UseVisualStyleBackColor = true;
            // 
            // rbNumeroSocio
            // 
            this.rbNumeroSocio.AutoSize = true;
            this.rbNumeroSocio.Location = new System.Drawing.Point(12, 43);
            this.rbNumeroSocio.Name = "rbNumeroSocio";
            this.rbNumeroSocio.Size = new System.Drawing.Size(105, 17);
            this.rbNumeroSocio.TabIndex = 1;
            this.rbNumeroSocio.TabStop = true;
            this.rbNumeroSocio.Text = "Numero de socio";
            this.rbNumeroSocio.UseVisualStyleBackColor = true;
            // 
            // rbBarrioManzLote
            // 
            this.rbBarrioManzLote.AutoSize = true;
            this.rbBarrioManzLote.Checked = true;
            this.rbBarrioManzLote.Location = new System.Drawing.Point(12, 20);
            this.rbBarrioManzLote.Name = "rbBarrioManzLote";
            this.rbBarrioManzLote.Size = new System.Drawing.Size(134, 17);
            this.rbBarrioManzLote.TabIndex = 0;
            this.rbBarrioManzLote.TabStop = true;
            this.rbBarrioManzLote.Text = "Barrio, Manzana y Lote";
            this.rbBarrioManzLote.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtPeriodos);
            this.groupBox4.Controls.Add(this.rbSociosSinDeuda);
            this.groupBox4.Controls.Add(this.rbSociosQueAdeudan);
            this.groupBox4.Controls.Add(this.rbTodosSocios);
            this.groupBox4.Location = new System.Drawing.Point(12, 233);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(309, 95);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Preparar avisos para...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "o mas períodos";
            // 
            // txtPeriodos
            // 
            this.txtPeriodos.Enabled = false;
            this.txtPeriodos.Location = new System.Drawing.Point(159, 43);
            this.txtPeriodos.Name = "txtPeriodos";
            this.txtPeriodos.Size = new System.Drawing.Size(41, 20);
            this.txtPeriodos.TabIndex = 3;
            this.txtPeriodos.Text = "1";
            // 
            // rbSociosSinDeuda
            // 
            this.rbSociosSinDeuda.AutoSize = true;
            this.rbSociosSinDeuda.Location = new System.Drawing.Point(11, 66);
            this.rbSociosSinDeuda.Name = "rbSociosSinDeuda";
            this.rbSociosSinDeuda.Size = new System.Drawing.Size(106, 17);
            this.rbSociosSinDeuda.TabIndex = 2;
            this.rbSociosSinDeuda.TabStop = true;
            this.rbSociosSinDeuda.Text = "Socios sin deuda";
            this.rbSociosSinDeuda.UseVisualStyleBackColor = true;
            // 
            // rbSociosQueAdeudan
            // 
            this.rbSociosQueAdeudan.AutoSize = true;
            this.rbSociosQueAdeudan.Location = new System.Drawing.Point(12, 43);
            this.rbSociosQueAdeudan.Name = "rbSociosQueAdeudan";
            this.rbSociosQueAdeudan.Size = new System.Drawing.Size(123, 17);
            this.rbSociosQueAdeudan.TabIndex = 1;
            this.rbSociosQueAdeudan.TabStop = true;
            this.rbSociosQueAdeudan.Text = "Socios que adeudan";
            this.rbSociosQueAdeudan.UseVisualStyleBackColor = true;
            this.rbSociosQueAdeudan.CheckedChanged += new System.EventHandler(this.rbSociosQueAdeudan_CheckedChanged);
            // 
            // rbTodosSocios
            // 
            this.rbTodosSocios.AutoSize = true;
            this.rbTodosSocios.Checked = true;
            this.rbTodosSocios.Location = new System.Drawing.Point(12, 20);
            this.rbTodosSocios.Name = "rbTodosSocios";
            this.rbTodosSocios.Size = new System.Drawing.Size(188, 17);
            this.rbTodosSocios.TabIndex = 0;
            this.rbTodosSocios.TabStop = true;
            this.rbTodosSocios.Text = "Todos los socios (con y sin deuda)";
            this.rbTodosSocios.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnSalir);
            this.groupBox5.Controls.Add(this.btnCrearAvisos);
            this.groupBox5.Location = new System.Drawing.Point(12, 334);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(309, 74);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(165, 30);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(119, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCrearAvisos
            // 
            this.btnCrearAvisos.BackColor = System.Drawing.SystemColors.Control;
            this.btnCrearAvisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearAvisos.Location = new System.Drawing.Point(26, 30);
            this.btnCrearAvisos.Name = "btnCrearAvisos";
            this.btnCrearAvisos.Size = new System.Drawing.Size(120, 23);
            this.btnCrearAvisos.TabIndex = 0;
            this.btnCrearAvisos.Text = "Crear avisos";
            this.btnCrearAvisos.UseVisualStyleBackColor = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtTextoAviso);
            this.groupBox6.Controls.Add(this.rbUsarSiguienteTexto);
            this.groupBox6.Controls.Add(this.rbRegularizarCambioCategoria);
            this.groupBox6.Location = new System.Drawing.Point(337, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(338, 396);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "tipo de reporte";
            // 
            // txtTextoAviso
            // 
            this.txtTextoAviso.Location = new System.Drawing.Point(9, 77);
            this.txtTextoAviso.Multiline = true;
            this.txtTextoAviso.Name = "txtTextoAviso";
            this.txtTextoAviso.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTextoAviso.Size = new System.Drawing.Size(323, 307);
            this.txtTextoAviso.TabIndex = 2;
            // 
            // rbUsarSiguienteTexto
            // 
            this.rbUsarSiguienteTexto.AutoSize = true;
            this.rbUsarSiguienteTexto.Checked = true;
            this.rbUsarSiguienteTexto.Location = new System.Drawing.Point(9, 48);
            this.rbUsarSiguienteTexto.Name = "rbUsarSiguienteTexto";
            this.rbUsarSiguienteTexto.Size = new System.Drawing.Size(192, 17);
            this.rbUsarSiguienteTexto.TabIndex = 1;
            this.rbUsarSiguienteTexto.TabStop = true;
            this.rbUsarSiguienteTexto.Text = "Usar el siguiente texto para el aviso";
            this.rbUsarSiguienteTexto.UseVisualStyleBackColor = true;
            this.rbUsarSiguienteTexto.CheckedChanged += new System.EventHandler(this.rbUsarSiguienteTexto_CheckedChanged);
            // 
            // rbRegularizarCambioCategoria
            // 
            this.rbRegularizarCambioCategoria.AutoSize = true;
            this.rbRegularizarCambioCategoria.Location = new System.Drawing.Point(9, 19);
            this.rbRegularizarCambioCategoria.Name = "rbRegularizarCambioCategoria";
            this.rbRegularizarCambioCategoria.Size = new System.Drawing.Size(177, 17);
            this.rbRegularizarCambioCategoria.TabIndex = 0;
            this.rbRegularizarCambioCategoria.Text = "Regularizar cambio de categoria";
            this.rbRegularizarCambioCategoria.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbDescendente);
            this.groupBox2.Controls.Add(this.rbAscendente);
            this.groupBox2.Location = new System.Drawing.Point(177, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 94);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ordenar en forma...";
            // 
            // rbDescendente
            // 
            this.rbDescendente.AutoSize = true;
            this.rbDescendente.Location = new System.Drawing.Point(19, 46);
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
            // frmAvisosVariosASocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 414);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAvisosVariosASocios";
            this.Text = "Avisos Varios a Socios";
            this.Load += new System.EventHandler(this.frmAvisosVariosASocios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnCrearFiltro;
        private System.Windows.Forms.ComboBox cmbBarrio;
        private System.Windows.Forms.RadioButton rbFiltros;
        private System.Windows.Forms.RadioButton rbSeleccionarBarrio;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbNombreApellido;
        private System.Windows.Forms.RadioButton rbNumeroSocio;
        private System.Windows.Forms.RadioButton rbBarrioManzLote;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbDescendente;
        private System.Windows.Forms.RadioButton rbAscendente;
        private System.Windows.Forms.RadioButton rbSociosSinDeuda;
        private System.Windows.Forms.RadioButton rbSociosQueAdeudan;
        private System.Windows.Forms.RadioButton rbTodosSocios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPeriodos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCrearAvisos;
        private System.Windows.Forms.RadioButton rbUsarSiguienteTexto;
        private System.Windows.Forms.RadioButton rbRegularizarCambioCategoria;
        private System.Windows.Forms.TextBox txtTextoAviso;
    }
}