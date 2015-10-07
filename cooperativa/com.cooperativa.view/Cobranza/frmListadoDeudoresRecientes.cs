using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using com.cooperativa.implement;

namespace com.cooperativa.view.Cobranza
{
    public partial class frmListadoDeudoresRecientes : Form
    {

        #region << EVENTOS >>
        public frmListadoDeudoresRecientes()
        {
            InitializeComponent();
        }
        private void frmListadoDeudoresRecientes_Load(object sender, EventArgs e)
        {
            Inicializar();
        }
        private void btnFiltro_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerarListado_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     
        #endregion


        #region << METODOS >>

        private void Inicializar() {
            CargarBarrios();
            Ocultar13();
            OcultarFecha();
        }

        private void CargarBarrios()
        {
            BarrioImplement oBarrioImplement = new BarrioImplement();
            oBarrioImplement.CargarCombo(this.cmbBarrio, "Seleccione Barrio");
        }

        private void Ocultar23() {
            this.cmbBarrio.Enabled = false;
            this.cmbBarrio.SelectedValue = 0;
            this.btnFiltro.Enabled = false;
        }
        private void Ocultar13()
        {
            this.cmbBarrio.Enabled = true;
            this.cmbBarrio.SelectedValue = 0;
            this.btnFiltro.Enabled = false;
        }
        private void Ocultar12()
        {
            this.cmbBarrio.Enabled = false;
            this.cmbBarrio.SelectedValue = 0;
            this.btnFiltro.Enabled = true;
        }

        private void OcultarFecha() {

            this.dtpFecha.Enabled = false;
            this.dtpFecha.Text = "";
        }

        private void HabilitarFecha() {
            this.dtpFecha.Enabled = true;
            this.dtpFecha.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
        }
        #endregion

        private void rbtnTodosBarrios_CheckedChanged(object sender, EventArgs e)
        {
            Ocultar23();
        }

        private void rbtnSelecionaBarrio_CheckedChanged(object sender, EventArgs e)
        {
            Ocultar13();
        }

        private void rbtnFiltro_CheckedChanged(object sender, EventArgs e)
        {
            Ocultar12();
        }

        private void rbtnFHoy_CheckedChanged(object sender, EventArgs e)
        {
            OcultarFecha();
        }

        private void rbtnFAl_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarFecha();
        }

    }
}
