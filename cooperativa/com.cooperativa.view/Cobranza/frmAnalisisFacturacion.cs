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
    public partial class frmAnalisisFacturacion : Form
    {


        #region << EVENTOS >>
        public frmAnalisisFacturacion()
        {
            InitializeComponent();
        }

        private void frmAnalisisFacturacion_Load(object sender, EventArgs e)
        {
            Inicializar();
        }
        private void rbtnFacturacionCompleta_CheckedChanged(object sender, EventArgs e)
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

        private void rbtn24_CheckedChanged(object sender, EventArgs e)
        {
            OcultarPeriodos();
        }
        private void rbtn12_CheckedChanged(object sender, EventArgs e)
        {
            OcultarPeriodos();
        }
        private void rbtn6_CheckedChanged(object sender, EventArgs e)
        {
            OcultarPeriodos();
        }
        private void rbtn3_CheckedChanged(object sender, EventArgs e)
        {
            OcultarPeriodos();
        }
        private void rbtnPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarPeriodos();
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
            OcultaI234();
            OcultarPeriodos();
            CargarBarrios();
            CargarTarifas();
            CargarZonas();
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

        private void CargarTarifas() {
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

    



  
    }
}
