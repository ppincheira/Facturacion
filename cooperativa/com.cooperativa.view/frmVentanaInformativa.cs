using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace com.cooperativa.view
{
    public partial class frmVentanaInformativa : Form
    {
        string _mensaje;
        public frmVentanaInformativa(String oMensaje)
        {
            InitializeComponent();
            _mensaje = oMensaje;
        }

        private void frmVentanaInformativa_Load(object sender, EventArgs e)
        {
            lblMensaje.Text = _mensaje;
        }

    }
}
