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
    public partial class frmPadronDeSociosPorDistrito : Form
    {
        public frmPadronDeSociosPorDistrito()
        {
            InitializeComponent();
        }

        private void rbSoloElDistrito_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSoloElDistrito.Checked)
                txtDistrito.Enabled = true;
            else
            {
                txtDistrito.Enabled = false;
                txtDistrito.Text = "";

            }
        }

        private void rbTituloManual_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTituloManual.Checked)
                txtTitulo.Enabled = true;
            else
            {
                txtTitulo.Enabled = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    

      
    }
}
