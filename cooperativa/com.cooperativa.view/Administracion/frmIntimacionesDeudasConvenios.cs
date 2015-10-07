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
    public partial class frmIntimacionesDeudasConvenios : Form
    {
        public frmIntimacionesDeudasConvenios()
        {
            InitializeComponent();
        }

        private void frmIntimacionesDeudasConvenios_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void Inicializar()
        {
            CargarBarrios();            
        }

        private void CargarBarrios()
        {
            BarrioImplement oBarrioImplement = new BarrioImplement();
            oBarrioImplement.CargarCombo(this.cmbBarrio, "Seleccione Barrio");
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

        private void rbIntimacionBlanco_CheckedChanged(object sender, EventArgs e)
        {
            if (rbIntimacionBlanco.Checked)
                txtCopias.Enabled = true;
            else
            {
                txtCopias.Enabled = false;
                txtCopias.Text = "";

            }
        }

        private void rbFacturasVencidas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFacturasVencidas.Checked)
                chkExcluirSocios.Enabled = true;
            else
            {
                chkExcluirSocios.Enabled = false;
                chkExcluirSocios.Checked = false;

            }
        }

        private void rbCuotasConveniosVencidas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCuotasConveniosVencidas.Checked)
                gbCuotasVencidas.Enabled = true;
            else
            {
                gbCuotasVencidas.Enabled = false;
            }
        }

        private void rbConveniosFirmados_CheckedChanged(object sender, EventArgs e)
        {
            if (rbConveniosFirmados.Checked)
            {
                txtDesde.Enabled = true;
                txtHasta.Enabled = true;
            }
            else
            {
                txtDesde.Enabled = false;
                txtHasta.Enabled = false;
                txtDesde.Text = "";
                txtHasta.Text = "";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
       
    }
}
