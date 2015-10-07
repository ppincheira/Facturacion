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
    public partial class frmAnalisisDeudor : Form
    {


        #region << EVENTOS >>

        public frmAnalisisDeudor()
        {
            InitializeComponent();
        }

        private void frmAnalisisDeudor_Load(object sender, EventArgs e)
        {
            Inicializar();
        }
        private void rbtnSociosUsuario_CheckedChanged(object sender, EventArgs e)
        {
            OcultaI234();
        }
        private void rbtnBarrio_CheckedChanged(object sender, EventArgs e)
        {
            OcultarI134();
        }
        private void rbtnZona_CheckedChanged(object sender, EventArgs e)
        {
            OcultarI124();
        }
        private void rbtnTarifa_CheckedChanged(object sender, EventArgs e)
        {
            OcultarI123();
        }
        private void rbtn36_CheckedChanged(object sender, EventArgs e)
        {
            OcultarPeriodos();
        }
        private void rbtnA24_CheckedChanged(object sender, EventArgs e)
        {
            OcultarPeriodos();
        }
        private void rbtnA12_CheckedChanged(object sender, EventArgs e)
        {
            OcultarPeriodos();
        }
        private void rbtnA6_CheckedChanged(object sender, EventArgs e)
        {
            OcultarPeriodos();
        }
        private void rbtnA3_CheckedChanged(object sender, EventArgs e)
        {
            OcultarPeriodos();
        }

        private void rbtnAPeriodos_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarPeriodos();
        }

        #endregion


        #region << METODOS >>

        private void Inicializar()
        {
            CargarBarrios();
            CargarTarifas();
            CargarZonas();
            OcultaI234();
            OcultarPeriodos();

        }
        private void CargarBarrios()
        {
            BarrioImplement oBarrioImplement = new BarrioImplement();
            oBarrioImplement.CargarCombo(this.cmbBarrio, "Seleccione Barrio");
        }
        private void CargarZonas()
        {
            ZonaImplement oZonaImplement = new ZonaImplement();
            oZonaImplement.CargarCombo(this.cmbZona, "Seleccione Zona");
        }
        private void CargarTarifas()
        {
            TarifaImplement oTarifaImplement = new TarifaImplement();
            oTarifaImplement.CargarCombo(this.cmbTarifa, "Seleccione Tarifa");
        }

        private void OcultaI234()
        {
            this.cmbBarrio.Enabled = false;
            this.cmbTarifa.Enabled = false;
            this.cmbZona.Enabled = false;
        }
        private void OcultarI134()
        {
            this.cmbBarrio.Enabled = true;
            this.cmbTarifa.Enabled = false;
            this.cmbZona.Enabled = false;
        }
        private void OcultarI124()
        {
            this.cmbBarrio.Enabled = false;
            this.cmbTarifa.Enabled = false;
            this.cmbZona.Enabled = true;
        }

        private void OcultarI123()
        {
            this.cmbBarrio.Enabled = false;
            this.cmbTarifa.Enabled = true;
            this.cmbZona.Enabled = false;
        }
        private void OcultarPeriodos()
        {
            this.dtpDesde.Enabled = false;
            this.dtpHasta.Enabled = false;
        }

        private void HabilitarPeriodos()
        {
            this.dtpDesde.Enabled = true;
            this.dtpHasta.Enabled = true;
        }
        #endregion

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerarListado_Click(object sender, EventArgs e)
        {

        }


    }
}
