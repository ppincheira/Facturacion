using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using com.cooperativa.implement;
using com.cooperativa.implement.dao;
namespace com.cooperativa.view
{
    public partial class frmLogin : Form
    {
        int _Intentos = 0;
        int _ID_USUARIO = 0;

        public int getIDUSUARIO()
        {
            return _ID_USUARIO;
        }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.txtNombreUsuario.Text = "admin";
            this.txtPassword.Text = "1";
            this.txtTerminal.Text = "CAELO";
            //identificarterminal por algun dato en configuracion?

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            _Intentos = _Intentos + 1;
            if (txtNombreUsuario.Text.Length > 0 & txtPassword.Text.Length > 0)
            {
                UsuariosImplement oUsuariosImplement = new UsuariosImplement();
                if (oUsuariosImplement.ExisteUsuario(txtNombreUsuario.Text))
                {
                    _ID_USUARIO = oUsuariosImplement.GetByUserName(txtNombreUsuario.Text).id_usuario;

                    if(oUsuariosImplement.EsValido(txtNombreUsuario.Text, txtPassword.Text))
                    {
                        
                        //Obtengo terminal por el txt; verifico si esta habilitada
                        //si esta bloqueada miro si tiene fecha de bloqueo, si hace mas de un dia
                        //la habilito y limpio la fecha de bloqueo
                        //si no, aviso q esta momentaneamente bloqueado
                        frmMenu f = new frmMenu(this);
                        Hide();
                        f.Show();
                    }
                    else{
                        if (_Intentos >= 3)
                        {
                            MessageBox.Show("Se ha excedido el número máximo de intentos para registrarse en \n" +
                                            "el sistema, esta terminal ha sido bloqueada por lo cuál deberá \n" +
                                            "solicitar al administrador del sistema que la habilite.\n" +
                                            "Terminal bloqueada");

                            //Bloquear terminal por id identificado por configuracion?
                        }
                        else
                        {
                            MessageBox.Show("Usuario Invalido.");
                        }
                    }
                }
                
            }
            

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  
    }
}
