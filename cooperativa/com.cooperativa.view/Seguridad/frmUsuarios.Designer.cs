namespace com.cooperativa.view.Seguridad
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.lstBUsuarios = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAnularCambios = new System.Windows.Forms.Button();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.btnNuevoUsuario = new System.Windows.Forms.Button();
            this.chkOpcionesMantenimiento = new System.Windows.Forms.CheckBox();
            this.chkJudicialCodene = new System.Windows.Forms.CheckBox();
            this.chkListadosPadrones = new System.Windows.Forms.CheckBox();
            this.chkAutorizarConvenios = new System.Windows.Forms.CheckBox();
            this.chkAutorizarCobroSI = new System.Windows.Forms.CheckBox();
            this.chkAdministracionSeguridad = new System.Windows.Forms.CheckBox();
            this.chkConfigurar = new System.Windows.Forms.CheckBox();
            this.chkRepararOptimizar = new System.Windows.Forms.CheckBox();
            this.chkAvisosDeudaListadosCorte = new System.Windows.Forms.CheckBox();
            this.chkListadosReportesCobranza = new System.Windows.Forms.CheckBox();
            this.chkCobranzas = new System.Windows.Forms.CheckBox();
            this.chkImpresion = new System.Windows.Forms.CheckBox();
            this.chkFacturacionAnulacion = new System.Windows.Forms.CheckBox();
            this.chkModificarDatos = new System.Windows.Forms.CheckBox();
            this.chkUsuarioHabilitado = new System.Windows.Forms.CheckBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBUsuarios
            // 
            this.lstBUsuarios.FormattingEnabled = true;
            this.lstBUsuarios.Location = new System.Drawing.Point(9, 43);
            this.lstBUsuarios.Name = "lstBUsuarios";
            this.lstBUsuarios.Size = new System.Drawing.Size(184, 225);
            this.lstBUsuarios.TabIndex = 0;
            this.lstBUsuarios.SelectedIndexChanged += new System.EventHandler(this.lstBUsuarios_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuarios";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.chkOpcionesMantenimiento);
            this.groupBox1.Controls.Add(this.chkJudicialCodene);
            this.groupBox1.Controls.Add(this.chkListadosPadrones);
            this.groupBox1.Controls.Add(this.chkAutorizarConvenios);
            this.groupBox1.Controls.Add(this.chkAutorizarCobroSI);
            this.groupBox1.Controls.Add(this.chkAdministracionSeguridad);
            this.groupBox1.Controls.Add(this.chkConfigurar);
            this.groupBox1.Controls.Add(this.chkRepararOptimizar);
            this.groupBox1.Controls.Add(this.chkAvisosDeudaListadosCorte);
            this.groupBox1.Controls.Add(this.chkListadosReportesCobranza);
            this.groupBox1.Controls.Add(this.chkCobranzas);
            this.groupBox1.Controls.Add(this.chkImpresion);
            this.groupBox1.Controls.Add(this.chkFacturacionAnulacion);
            this.groupBox1.Controls.Add(this.chkModificarDatos);
            this.groupBox1.Controls.Add(this.chkUsuarioHabilitado);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtLogin);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lstBUsuarios);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 556);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "(Nombre para registrarse en el sistema)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(216, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Permisos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(425, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(216, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(216, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nombre completo de usuario";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Controls.Add(this.btnAnularCambios);
            this.groupBox2.Controls.Add(this.btnGuardarCambios);
            this.groupBox2.Controls.Add(this.btnModificarUsuario);
            this.groupBox2.Controls.Add(this.btnNuevoUsuario);
            this.groupBox2.Location = new System.Drawing.Point(9, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 268);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(22, 224);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(142, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnAnularCambios
            // 
            this.btnAnularCambios.Enabled = false;
            this.btnAnularCambios.Location = new System.Drawing.Point(22, 178);
            this.btnAnularCambios.Name = "btnAnularCambios";
            this.btnAnularCambios.Size = new System.Drawing.Size(142, 23);
            this.btnAnularCambios.TabIndex = 3;
            this.btnAnularCambios.Text = "Anular cambios";
            this.btnAnularCambios.UseVisualStyleBackColor = true;
            this.btnAnularCambios.Click += new System.EventHandler(this.btnAnularCambios_Click);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Enabled = false;
            this.btnGuardarCambios.Location = new System.Drawing.Point(22, 132);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(142, 23);
            this.btnGuardarCambios.TabIndex = 2;
            this.btnGuardarCambios.Text = "Guardar cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.Location = new System.Drawing.Point(22, 84);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(142, 23);
            this.btnModificarUsuario.TabIndex = 1;
            this.btnModificarUsuario.Text = "Modificar usuario";
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.Location = new System.Drawing.Point(22, 38);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(142, 23);
            this.btnNuevoUsuario.TabIndex = 0;
            this.btnNuevoUsuario.Text = "Nuevo usuario";
            this.btnNuevoUsuario.UseVisualStyleBackColor = true;
            this.btnNuevoUsuario.Click += new System.EventHandler(this.btnNuevoUsuario_Click);
            // 
            // chkOpcionesMantenimiento
            // 
            this.chkOpcionesMantenimiento.AutoSize = true;
            this.chkOpcionesMantenimiento.Enabled = false;
            this.chkOpcionesMantenimiento.Location = new System.Drawing.Point(219, 527);
            this.chkOpcionesMantenimiento.Name = "chkOpcionesMantenimiento";
            this.chkOpcionesMantenimiento.Size = new System.Drawing.Size(220, 17);
            this.chkOpcionesMantenimiento.TabIndex = 35;
            this.chkOpcionesMantenimiento.Text = "Opiones mantenimiento (exclusivo admin)";
            this.chkOpcionesMantenimiento.UseVisualStyleBackColor = true;
            // 
            // chkJudicialCodene
            // 
            this.chkJudicialCodene.AutoSize = true;
            this.chkJudicialCodene.Enabled = false;
            this.chkJudicialCodene.Location = new System.Drawing.Point(219, 504);
            this.chkJudicialCodene.Name = "chkJudicialCodene";
            this.chkJudicialCodene.Size = new System.Drawing.Size(194, 17);
            this.chkJudicialCodene.TabIndex = 34;
            this.chkJudicialCodene.Text = "Socio en proceso judicial/CODENE";
            this.chkJudicialCodene.UseVisualStyleBackColor = true;
            // 
            // chkListadosPadrones
            // 
            this.chkListadosPadrones.AutoSize = true;
            this.chkListadosPadrones.Enabled = false;
            this.chkListadosPadrones.Location = new System.Drawing.Point(219, 481);
            this.chkListadosPadrones.Name = "chkListadosPadrones";
            this.chkListadosPadrones.Size = new System.Drawing.Size(169, 17);
            this.chkListadosPadrones.TabIndex = 33;
            this.chkListadosPadrones.Text = "Listados y Padrones de socios";
            this.chkListadosPadrones.UseVisualStyleBackColor = true;
            // 
            // chkAutorizarConvenios
            // 
            this.chkAutorizarConvenios.AutoSize = true;
            this.chkAutorizarConvenios.Enabled = false;
            this.chkAutorizarConvenios.Location = new System.Drawing.Point(219, 458);
            this.chkAutorizarConvenios.Name = "chkAutorizarConvenios";
            this.chkAutorizarConvenios.Size = new System.Drawing.Size(222, 17);
            this.chkAutorizarConvenios.TabIndex = 32;
            this.chkAutorizarConvenios.Text = "Aut. convenios s/interes, BPN, PagoFacil";
            this.chkAutorizarConvenios.UseVisualStyleBackColor = true;
            // 
            // chkAutorizarCobroSI
            // 
            this.chkAutorizarCobroSI.AutoSize = true;
            this.chkAutorizarCobroSI.Enabled = false;
            this.chkAutorizarCobroSI.Location = new System.Drawing.Point(219, 435);
            this.chkAutorizarCobroSI.Name = "chkAutorizarCobroSI";
            this.chkAutorizarCobroSI.Size = new System.Drawing.Size(147, 17);
            this.chkAutorizarCobroSI.TabIndex = 31;
            this.chkAutorizarCobroSI.Text = "Autorizar cobro sin interes";
            this.chkAutorizarCobroSI.UseVisualStyleBackColor = true;
            // 
            // chkAdministracionSeguridad
            // 
            this.chkAdministracionSeguridad.AutoSize = true;
            this.chkAdministracionSeguridad.Enabled = false;
            this.chkAdministracionSeguridad.Location = new System.Drawing.Point(219, 412);
            this.chkAdministracionSeguridad.Name = "chkAdministracionSeguridad";
            this.chkAdministracionSeguridad.Size = new System.Drawing.Size(163, 17);
            this.chkAdministracionSeguridad.TabIndex = 30;
            this.chkAdministracionSeguridad.Text = "Administracion  de Seguridad";
            this.chkAdministracionSeguridad.UseVisualStyleBackColor = true;
            // 
            // chkConfigurar
            // 
            this.chkConfigurar.AutoSize = true;
            this.chkConfigurar.Enabled = false;
            this.chkConfigurar.Location = new System.Drawing.Point(219, 389);
            this.chkConfigurar.Name = "chkConfigurar";
            this.chkConfigurar.Size = new System.Drawing.Size(114, 17);
            this.chkConfigurar.TabIndex = 29;
            this.chkConfigurar.Text = "Configurar Sistema";
            this.chkConfigurar.UseVisualStyleBackColor = true;
            // 
            // chkRepararOptimizar
            // 
            this.chkRepararOptimizar.AutoSize = true;
            this.chkRepararOptimizar.Enabled = false;
            this.chkRepararOptimizar.Location = new System.Drawing.Point(219, 366);
            this.chkRepararOptimizar.Name = "chkRepararOptimizar";
            this.chkRepararOptimizar.Size = new System.Drawing.Size(235, 17);
            this.chkRepararOptimizar.TabIndex = 28;
            this.chkRepararOptimizar.Text = "Reparar/Optimizar/Respaldo Base de Datos";
            this.chkRepararOptimizar.UseVisualStyleBackColor = true;
            // 
            // chkAvisosDeudaListadosCorte
            // 
            this.chkAvisosDeudaListadosCorte.AutoSize = true;
            this.chkAvisosDeudaListadosCorte.Enabled = false;
            this.chkAvisosDeudaListadosCorte.Location = new System.Drawing.Point(219, 343);
            this.chkAvisosDeudaListadosCorte.Name = "chkAvisosDeudaListadosCorte";
            this.chkAvisosDeudaListadosCorte.Size = new System.Drawing.Size(194, 17);
            this.chkAvisosDeudaListadosCorte.TabIndex = 27;
            this.chkAvisosDeudaListadosCorte.Text = "Avisos de Deuda/Listados de Corte";
            this.chkAvisosDeudaListadosCorte.UseVisualStyleBackColor = true;
            // 
            // chkListadosReportesCobranza
            // 
            this.chkListadosReportesCobranza.AutoSize = true;
            this.chkListadosReportesCobranza.Enabled = false;
            this.chkListadosReportesCobranza.Location = new System.Drawing.Point(219, 320);
            this.chkListadosReportesCobranza.Name = "chkListadosReportesCobranza";
            this.chkListadosReportesCobranza.Size = new System.Drawing.Size(186, 17);
            this.chkListadosReportesCobranza.TabIndex = 26;
            this.chkListadosReportesCobranza.Text = "Listados y Reportes de cobranzas";
            this.chkListadosReportesCobranza.UseVisualStyleBackColor = true;
            // 
            // chkCobranzas
            // 
            this.chkCobranzas.AutoSize = true;
            this.chkCobranzas.Enabled = false;
            this.chkCobranzas.Location = new System.Drawing.Point(219, 299);
            this.chkCobranzas.Name = "chkCobranzas";
            this.chkCobranzas.Size = new System.Drawing.Size(146, 17);
            this.chkCobranzas.TabIndex = 25;
            this.chkCobranzas.Text = "Cobranza/Cierre de cajas";
            this.chkCobranzas.UseVisualStyleBackColor = true;
            // 
            // chkImpresion
            // 
            this.chkImpresion.AutoSize = true;
            this.chkImpresion.Enabled = false;
            this.chkImpresion.Location = new System.Drawing.Point(219, 276);
            this.chkImpresion.Name = "chkImpresion";
            this.chkImpresion.Size = new System.Drawing.Size(193, 17);
            this.chkImpresion.TabIndex = 24;
            this.chkImpresion.Text = "Impresion/Reimpresion de Facturas";
            this.chkImpresion.UseVisualStyleBackColor = true;
            // 
            // chkFacturacionAnulacion
            // 
            this.chkFacturacionAnulacion.AutoSize = true;
            this.chkFacturacionAnulacion.Enabled = false;
            this.chkFacturacionAnulacion.Location = new System.Drawing.Point(219, 253);
            this.chkFacturacionAnulacion.Name = "chkFacturacionAnulacion";
            this.chkFacturacionAnulacion.Size = new System.Drawing.Size(226, 17);
            this.chkFacturacionAnulacion.TabIndex = 23;
            this.chkFacturacionAnulacion.Text = "Facturacion/Anulacion de Fact./Resumen";
            this.chkFacturacionAnulacion.UseVisualStyleBackColor = true;
            // 
            // chkModificarDatos
            // 
            this.chkModificarDatos.AutoSize = true;
            this.chkModificarDatos.Enabled = false;
            this.chkModificarDatos.Location = new System.Drawing.Point(219, 230);
            this.chkModificarDatos.Name = "chkModificarDatos";
            this.chkModificarDatos.Size = new System.Drawing.Size(229, 17);
            this.chkModificarDatos.TabIndex = 22;
            this.chkModificarDatos.Text = "Modificar datos (socios, tarifas, barrios, etc)";
            this.chkModificarDatos.UseVisualStyleBackColor = true;
            // 
            // chkUsuarioHabilitado
            // 
            this.chkUsuarioHabilitado.AutoSize = true;
            this.chkUsuarioHabilitado.Enabled = false;
            this.chkUsuarioHabilitado.Location = new System.Drawing.Point(219, 207);
            this.chkUsuarioHabilitado.Name = "chkUsuarioHabilitado";
            this.chkUsuarioHabilitado.Size = new System.Drawing.Size(110, 17);
            this.chkUsuarioHabilitado.TabIndex = 21;
            this.chkUsuarioHabilitado.Text = "Usuario habilitado";
            this.chkUsuarioHabilitado.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(419, 143);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(34, 20);
            this.txtID.TabIndex = 9;
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(219, 143);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(183, 20);
            this.txtPassword.TabIndex = 8;
            // 
            // txtLogin
            // 
            this.txtLogin.Enabled = false;
            this.txtLogin.Location = new System.Drawing.Point(219, 93);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(234, 20);
            this.txtLogin.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(219, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(234, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 559);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUsuarios";
            this.Text = "frmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAnularCambios;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Button btnNuevoUsuario;
        private System.Windows.Forms.CheckBox chkOpcionesMantenimiento;
        private System.Windows.Forms.CheckBox chkJudicialCodene;
        private System.Windows.Forms.CheckBox chkListadosPadrones;
        private System.Windows.Forms.CheckBox chkAutorizarConvenios;
        private System.Windows.Forms.CheckBox chkAutorizarCobroSI;
        private System.Windows.Forms.CheckBox chkAdministracionSeguridad;
        private System.Windows.Forms.CheckBox chkConfigurar;
        private System.Windows.Forms.CheckBox chkRepararOptimizar;
        private System.Windows.Forms.CheckBox chkAvisosDeudaListadosCorte;
        private System.Windows.Forms.CheckBox chkListadosReportesCobranza;
        private System.Windows.Forms.CheckBox chkCobranzas;
        private System.Windows.Forms.CheckBox chkImpresion;
        private System.Windows.Forms.CheckBox chkFacturacionAnulacion;
        private System.Windows.Forms.CheckBox chkModificarDatos;
        private System.Windows.Forms.CheckBox chkUsuarioHabilitado;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
    }
}