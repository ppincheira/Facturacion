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
    public partial class frmListadoGralSocioSinDeuda : Form
    {


        #region << EVENTOS >>
        public frmListadoGralSocioSinDeuda()
        {
            InitializeComponent();
        }

        private void btnGenerarListado_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListadoGralSocioSinDeuda_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void rbtnSelecionaBarrio_CheckedChanged(object sender, EventArgs e)
        {
            Ocultar13();
        }

        private void rbtnFiltro_CheckedChanged(object sender, EventArgs e)
        {
            Ocultar12();
        }
        private void rbtnTodosBarrios_CheckedChanged(object sender, EventArgs e)
        {
            Ocultar23();
        }

        #endregion


        #region << METODOS >>

        private void Inicializar()
        {
            CargarBarrios();
            Ocultar13();
        }

        private void CargarBarrios()
        {
            BarrioImplement oBarrioImplement = new BarrioImplement();
            oBarrioImplement.CargarCombo(this.cmbBarrio, "Seleccione Barrio");
        }

        private void Ocultar23()
        {
            this.cmbBarrio.Enabled = false;
            this.btnFiltro.Enabled = false;
        }

        private void Ocultar13()
        {
            this.cmbBarrio.Enabled = true;
            this.btnFiltro.Enabled = false;
        }

        private void Ocultar12()
        {
            this.cmbBarrio.Enabled = false;
            this.btnFiltro.Enabled = true;
        }
        #endregion

  


    }
}
