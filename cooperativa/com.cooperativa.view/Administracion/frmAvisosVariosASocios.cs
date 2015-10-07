using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using com.cooperativa.implement;

namespace com.cooperativa.view
{
    public partial class frmAvisosVariosASocios : Form
    {

        #region << EVENTOS >>
        public frmAvisosVariosASocios()
        {
            InitializeComponent();
        }

        private void frmAvisosVariosASocios_Load(object sender, EventArgs e)
        {
            Inicializar();
        }


        private void rbSeleccionarBarrio_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSeleccionarBarrio.Checked)
                cmbBarrio.Enabled = true;
            else
            {
                cmbBarrio.Enabled = false;

            }
        }

        private void rbFiltros_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFiltros.Checked)
                btnCrearFiltro.Enabled = true;
            else
            {
                btnCrearFiltro.Enabled = false;

            }
        }

        private void rbSociosQueAdeudan_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSociosQueAdeudan.Checked)
                txtPeriodos.Enabled = true;
            else
            {
                txtPeriodos.Enabled = false;
                txtPeriodos.Text = "1";
            }
        }

        private void rbUsarSiguienteTexto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUsarSiguienteTexto.Checked)
                txtTextoAviso.Enabled = true;
            else
            {
                txtTextoAviso.Enabled = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


        #region << METODOS >>

        private void Inicializar()
        {
            CargarBarrios();
            txtPeriodos.Text = "1";
        }

        private void CargarBarrios()
        {
            BarrioImplement oBarrioImplement = new BarrioImplement();
            oBarrioImplement.CargarCombo(this.cmbBarrio, "Seleccione Barrio");
        }
        #endregion

    }
}
