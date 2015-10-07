namespace com.cooperativa.view
{
    partial class FrmFiltro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFiltro));
            this.dgvBusqueda = new System.Windows.Forms.DataGridView();
            this.lbCampos = new System.Windows.Forms.ListBox();
            this.rbIgual = new System.Windows.Forms.RadioButton();
            this.rbNoEnLista = new System.Windows.Forms.RadioButton();
            this.rbEnLista = new System.Windows.Forms.RadioButton();
            this.rbEntre2 = new System.Windows.Forms.RadioButton();
            this.rbContenido = new System.Windows.Forms.RadioButton();
            this.rbMayorIgual = new System.Windows.Forms.RadioButton();
            this.rbMayor = new System.Windows.Forms.RadioButton();
            this.rbMenorIgual = new System.Windows.Forms.RadioButton();
            this.rbMenor = new System.Windows.Forms.RadioButton();
            this.rbDistinto = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorUno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbBotones = new System.Windows.Forms.GroupBox();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbBotonAceptar = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtValorDos = new System.Windows.Forms.TextBox();
            this.txtValorTres = new System.Windows.Forms.TextBox();
            this.txtValorCuatro = new System.Windows.Forms.TextBox();
            this.txtValorCinco = new System.Windows.Forms.TextBox();
            this.txtValorSeis = new System.Windows.Forms.TextBox();
            this.txtValorSiete = new System.Windows.Forms.TextBox();
            this.txtValorOcho = new System.Windows.Forms.TextBox();
            this.txtValorNueve = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).BeginInit();
            this.gbBotones.SuspendLayout();
            this.gbBotonAceptar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBusqueda
            // 
            this.dgvBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusqueda.Location = new System.Drawing.Point(15, 238);
            this.dgvBusqueda.Name = "dgvBusqueda";
            this.dgvBusqueda.Size = new System.Drawing.Size(565, 115);
            this.dgvBusqueda.TabIndex = 0;
            // 
            // lbCampos
            // 
            this.lbCampos.FormattingEnabled = true;
            this.lbCampos.Location = new System.Drawing.Point(15, 27);
            this.lbCampos.Name = "lbCampos";
            this.lbCampos.Size = new System.Drawing.Size(141, 173);
            this.lbCampos.TabIndex = 1;
            this.lbCampos.SelectedIndexChanged += new System.EventHandler(this.lbCampos_SelectedIndexChanged);
            // 
            // rbIgual
            // 
            this.rbIgual.AutoSize = true;
            this.rbIgual.Location = new System.Drawing.Point(178, 26);
            this.rbIgual.Name = "rbIgual";
            this.rbIgual.Size = new System.Drawing.Size(48, 17);
            this.rbIgual.TabIndex = 2;
            this.rbIgual.TabStop = true;
            this.rbIgual.Text = "Igual";
            this.rbIgual.UseVisualStyleBackColor = true;
            this.rbIgual.CheckedChanged += new System.EventHandler(this.rbIgual_CheckedChanged);
            // 
            // rbNoEnLista
            // 
            this.rbNoEnLista.AutoSize = true;
            this.rbNoEnLista.Location = new System.Drawing.Point(178, 179);
            this.rbNoEnLista.Name = "rbNoEnLista";
            this.rbNoEnLista.Size = new System.Drawing.Size(79, 17);
            this.rbNoEnLista.TabIndex = 3;
            this.rbNoEnLista.TabStop = true;
            this.rbNoEnLista.Text = "No en Lista";
            this.rbNoEnLista.UseVisualStyleBackColor = true;
            this.rbNoEnLista.CheckedChanged += new System.EventHandler(this.rbNoEnLista_CheckedChanged);
            // 
            // rbEnLista
            // 
            this.rbEnLista.AutoSize = true;
            this.rbEnLista.Location = new System.Drawing.Point(178, 162);
            this.rbEnLista.Name = "rbEnLista";
            this.rbEnLista.Size = new System.Drawing.Size(63, 17);
            this.rbEnLista.TabIndex = 4;
            this.rbEnLista.TabStop = true;
            this.rbEnLista.Text = "En Lista";
            this.rbEnLista.UseVisualStyleBackColor = true;
            this.rbEnLista.CheckedChanged += new System.EventHandler(this.rbEnLista_CheckedChanged);
            // 
            // rbEntre2
            // 
            this.rbEntre2.AutoSize = true;
            this.rbEntre2.Location = new System.Drawing.Point(178, 145);
            this.rbEntre2.Name = "rbEntre2";
            this.rbEntre2.Size = new System.Drawing.Size(110, 17);
            this.rbEntre2.TabIndex = 5;
            this.rbEntre2.TabStop = true;
            this.rbEntre2.Text = "Entre Dos Valores";
            this.rbEntre2.UseVisualStyleBackColor = true;
            this.rbEntre2.CheckedChanged += new System.EventHandler(this.rbEntre2_CheckedChanged);
            // 
            // rbContenido
            // 
            this.rbContenido.AutoSize = true;
            this.rbContenido.Location = new System.Drawing.Point(178, 128);
            this.rbContenido.Name = "rbContenido";
            this.rbContenido.Size = new System.Drawing.Size(73, 17);
            this.rbContenido.TabIndex = 6;
            this.rbContenido.TabStop = true;
            this.rbContenido.Text = "Contenido";
            this.rbContenido.UseVisualStyleBackColor = true;
            this.rbContenido.CheckedChanged += new System.EventHandler(this.rbContenido_CheckedChanged);
            // 
            // rbMayorIgual
            // 
            this.rbMayorIgual.AutoSize = true;
            this.rbMayorIgual.Location = new System.Drawing.Point(178, 111);
            this.rbMayorIgual.Name = "rbMayorIgual";
            this.rbMayorIgual.Size = new System.Drawing.Size(89, 17);
            this.rbMayorIgual.TabIndex = 7;
            this.rbMayorIgual.TabStop = true;
            this.rbMayorIgual.Text = "Mayor o Igual";
            this.rbMayorIgual.UseVisualStyleBackColor = true;
            this.rbMayorIgual.CheckedChanged += new System.EventHandler(this.rbMayorIgual_CheckedChanged);
            // 
            // rbMayor
            // 
            this.rbMayor.AutoSize = true;
            this.rbMayor.Location = new System.Drawing.Point(178, 94);
            this.rbMayor.Name = "rbMayor";
            this.rbMayor.Size = new System.Drawing.Size(54, 17);
            this.rbMayor.TabIndex = 8;
            this.rbMayor.TabStop = true;
            this.rbMayor.Text = "Mayor";
            this.rbMayor.UseVisualStyleBackColor = true;
            this.rbMayor.CheckedChanged += new System.EventHandler(this.rbMayor_CheckedChanged);
            // 
            // rbMenorIgual
            // 
            this.rbMenorIgual.AutoSize = true;
            this.rbMenorIgual.Location = new System.Drawing.Point(178, 77);
            this.rbMenorIgual.Name = "rbMenorIgual";
            this.rbMenorIgual.Size = new System.Drawing.Size(90, 17);
            this.rbMenorIgual.TabIndex = 9;
            this.rbMenorIgual.TabStop = true;
            this.rbMenorIgual.Text = "Menor o Igual";
            this.rbMenorIgual.UseVisualStyleBackColor = true;
            this.rbMenorIgual.CheckedChanged += new System.EventHandler(this.rbMenorIgual_CheckedChanged);
            // 
            // rbMenor
            // 
            this.rbMenor.AutoSize = true;
            this.rbMenor.Location = new System.Drawing.Point(178, 60);
            this.rbMenor.Name = "rbMenor";
            this.rbMenor.Size = new System.Drawing.Size(55, 17);
            this.rbMenor.TabIndex = 10;
            this.rbMenor.TabStop = true;
            this.rbMenor.Text = "Menor";
            this.rbMenor.UseVisualStyleBackColor = true;
            this.rbMenor.CheckedChanged += new System.EventHandler(this.rbMenor_CheckedChanged);
            // 
            // rbDistinto
            // 
            this.rbDistinto.AutoSize = true;
            this.rbDistinto.Location = new System.Drawing.Point(178, 43);
            this.rbDistinto.Name = "rbDistinto";
            this.rbDistinto.Size = new System.Drawing.Size(60, 17);
            this.rbDistinto.TabIndex = 11;
            this.rbDistinto.TabStop = true;
            this.rbDistinto.Text = "Distinto";
            this.rbDistinto.UseVisualStyleBackColor = true;
            this.rbDistinto.CheckedChanged += new System.EventHandler(this.rbDistinto_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Campos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Operador";
            // 
            // txtValorUno
            // 
            this.txtValorUno.Location = new System.Drawing.Point(305, 27);
            this.txtValorUno.Name = "txtValorUno";
            this.txtValorUno.Size = new System.Drawing.Size(113, 20);
            this.txtValorUno.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Valor/es";
            // 
            // gbBotones
            // 
            this.gbBotones.Controls.Add(this.btnBorrarTodo);
            this.gbBotones.Controls.Add(this.btnBorrar);
            this.gbBotones.Controls.Add(this.btnAgregar);
            this.gbBotones.Location = new System.Drawing.Point(424, 16);
            this.gbBotones.Name = "gbBotones";
            this.gbBotones.Size = new System.Drawing.Size(156, 134);
            this.gbBotones.TabIndex = 16;
            this.gbBotones.TabStop = false;
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.Location = new System.Drawing.Point(17, 90);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(124, 23);
            this.btnBorrarTodo.TabIndex = 2;
            this.btnBorrarTodo.Text = "&BorrarTodo";
            this.btnBorrarTodo.UseVisualStyleBackColor = true;
            this.btnBorrarTodo.Click += new System.EventHandler(this.btnBorrarTodo_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(17, 58);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(124, 23);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.Text = "&Borrar Condición";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(17, 26);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(124, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "&Agregar Condición";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gbBotonAceptar
            // 
            this.gbBotonAceptar.Controls.Add(this.btnAceptar);
            this.gbBotonAceptar.Location = new System.Drawing.Point(424, 156);
            this.gbBotonAceptar.Name = "gbBotonAceptar";
            this.gbBotonAceptar.Size = new System.Drawing.Size(156, 53);
            this.gbBotonAceptar.TabIndex = 17;
            this.gbBotonAceptar.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(17, 18);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(124, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtValorDos
            // 
            this.txtValorDos.Location = new System.Drawing.Point(305, 47);
            this.txtValorDos.Name = "txtValorDos";
            this.txtValorDos.Size = new System.Drawing.Size(113, 20);
            this.txtValorDos.TabIndex = 18;
            this.txtValorDos.Visible = false;
            // 
            // txtValorTres
            // 
            this.txtValorTres.Location = new System.Drawing.Point(305, 67);
            this.txtValorTres.Name = "txtValorTres";
            this.txtValorTres.Size = new System.Drawing.Size(113, 20);
            this.txtValorTres.TabIndex = 19;
            this.txtValorTres.Visible = false;
            // 
            // txtValorCuatro
            // 
            this.txtValorCuatro.Location = new System.Drawing.Point(305, 87);
            this.txtValorCuatro.Name = "txtValorCuatro";
            this.txtValorCuatro.Size = new System.Drawing.Size(113, 20);
            this.txtValorCuatro.TabIndex = 20;
            this.txtValorCuatro.Visible = false;
            // 
            // txtValorCinco
            // 
            this.txtValorCinco.Location = new System.Drawing.Point(305, 107);
            this.txtValorCinco.Name = "txtValorCinco";
            this.txtValorCinco.Size = new System.Drawing.Size(113, 20);
            this.txtValorCinco.TabIndex = 21;
            this.txtValorCinco.Visible = false;
            // 
            // txtValorSeis
            // 
            this.txtValorSeis.Location = new System.Drawing.Point(305, 127);
            this.txtValorSeis.Name = "txtValorSeis";
            this.txtValorSeis.Size = new System.Drawing.Size(113, 20);
            this.txtValorSeis.TabIndex = 22;
            this.txtValorSeis.Visible = false;
            // 
            // txtValorSiete
            // 
            this.txtValorSiete.Location = new System.Drawing.Point(305, 147);
            this.txtValorSiete.Name = "txtValorSiete";
            this.txtValorSiete.Size = new System.Drawing.Size(113, 20);
            this.txtValorSiete.TabIndex = 23;
            this.txtValorSiete.Visible = false;
            // 
            // txtValorOcho
            // 
            this.txtValorOcho.Location = new System.Drawing.Point(305, 167);
            this.txtValorOcho.Name = "txtValorOcho";
            this.txtValorOcho.Size = new System.Drawing.Size(113, 20);
            this.txtValorOcho.TabIndex = 24;
            this.txtValorOcho.Visible = false;
            // 
            // txtValorNueve
            // 
            this.txtValorNueve.Location = new System.Drawing.Point(305, 187);
            this.txtValorNueve.Name = "txtValorNueve";
            this.txtValorNueve.Size = new System.Drawing.Size(113, 20);
            this.txtValorNueve.TabIndex = 25;
            this.txtValorNueve.Visible = false;
            // 
            // FrmFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 371);
            this.Controls.Add(this.txtValorNueve);
            this.Controls.Add(this.txtValorOcho);
            this.Controls.Add(this.txtValorSiete);
            this.Controls.Add(this.txtValorSeis);
            this.Controls.Add(this.txtValorCinco);
            this.Controls.Add(this.txtValorCuatro);
            this.Controls.Add(this.txtValorTres);
            this.Controls.Add(this.txtValorDos);
            this.Controls.Add(this.gbBotonAceptar);
            this.Controls.Add(this.gbBotones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValorUno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbDistinto);
            this.Controls.Add(this.rbMenor);
            this.Controls.Add(this.rbMenorIgual);
            this.Controls.Add(this.rbMayor);
            this.Controls.Add(this.rbMayorIgual);
            this.Controls.Add(this.rbContenido);
            this.Controls.Add(this.rbEntre2);
            this.Controls.Add(this.rbEnLista);
            this.Controls.Add(this.rbNoEnLista);
            this.Controls.Add(this.rbIgual);
            this.Controls.Add(this.lbCampos);
            this.Controls.Add(this.dgvBusqueda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(612, 409);
            this.Name = "FrmFiltro";
            this.Text = "Filtro y Busqueda";
            this.Load += new System.EventHandler(this.FrmFiltro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).EndInit();
            this.gbBotones.ResumeLayout(false);
            this.gbBotonAceptar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBusqueda;
        private System.Windows.Forms.ListBox lbCampos;
        private System.Windows.Forms.RadioButton rbIgual;
        private System.Windows.Forms.RadioButton rbNoEnLista;
        private System.Windows.Forms.RadioButton rbEnLista;
        private System.Windows.Forms.RadioButton rbEntre2;
        private System.Windows.Forms.RadioButton rbContenido;
        private System.Windows.Forms.RadioButton rbMayorIgual;
        private System.Windows.Forms.RadioButton rbMayor;
        private System.Windows.Forms.RadioButton rbMenorIgual;
        private System.Windows.Forms.RadioButton rbMenor;
        private System.Windows.Forms.RadioButton rbDistinto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorUno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbBotones;
        private System.Windows.Forms.Button btnBorrarTodo;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox gbBotonAceptar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtValorDos;
        private System.Windows.Forms.TextBox txtValorTres;
        private System.Windows.Forms.TextBox txtValorCuatro;
        private System.Windows.Forms.TextBox txtValorCinco;
        private System.Windows.Forms.TextBox txtValorSeis;
        private System.Windows.Forms.TextBox txtValorSiete;
        private System.Windows.Forms.TextBox txtValorOcho;
        private System.Windows.Forms.TextBox txtValorNueve;
    }
}