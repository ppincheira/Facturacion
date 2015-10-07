using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using com.cooperativa.implement.dao;

namespace com.cooperativa.view.Cobranza
{
    public partial class frmListadoCobranzasAFIP : Form
    {


        #region << EVENTOS >>

        public frmListadoCobranzasAFIP()
        {
            InitializeComponent();
        }

        private void frmListadoCobranzasAFIP_Load(object sender, EventArgs e)
        {
            Inicializar();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerarListado_Click(object sender, EventArgs e)
        {

        }
        private void rbtnFecha_CheckedChanged(object sender, EventArgs e)
        {
            OcultarMesAnio();
        }
        private void rbtnMes_CheckedChanged(object sender, EventArgs e)
        {
            OcultarPeriodos();
        }

        #endregion


        #region << METODOS >>

        private void Inicializar()
        {
            CargarAnios();
            CargarMeses();
            OcultarPeriodos();
        }
        private void CargarAnios()
        {
            PeriodosImplement oPerdiodosImplement = new PeriodosImplement();
            DataTable dt = new DataTable();
            dt = oPerdiodosImplement.GetAnios();
            string ultimoPeriodo = oPerdiodosImplement.GetUltimoPeriodo();
            dt.Rows.Add("Seleccione...");
            cmbAnio.DataSource = dt;
            cmbAnio.DisplayMember = "periodo";
            cmbAnio.ValueMember = "periodo";
            cmbAnio.SelectedValue = ultimoPeriodo.Substring(0, 4);
        }

        private void CargarMeses()
        {
            DataTable dtMeses = new DataTable();
            dtMeses.Columns.Add("numero", typeof(string));
            dtMeses.Columns.Add("mes", typeof(string));
            dtMeses.Rows.Add("01", "Enero");
            dtMeses.Rows.Add("02", "Febrero");
            dtMeses.Rows.Add("03", "Marzo");
            dtMeses.Rows.Add("04", "Abril");
            dtMeses.Rows.Add("05", "Mayo");
            dtMeses.Rows.Add("06", "Junio");
            dtMeses.Rows.Add("07", "Julio");
            dtMeses.Rows.Add("08", "Agosto");
            dtMeses.Rows.Add("09", "Septiembre");
            dtMeses.Rows.Add("10", "Octubre");
            dtMeses.Rows.Add("11", "Noviembre");
            dtMeses.Rows.Add("12", "Diciembre");
            cmbMes.DataSource = dtMeses;
            cmbMes.ValueMember = "numero";
            cmbMes.DisplayMember = "mes";
        }
        #endregion



        private void OcultarPeriodos() {
            this.dtpFechaDesde.Enabled = false;
            this.dtpFechaHasta.Enabled = false;
            this.cmbAnio.Enabled = true;
            this.cmbMes.Enabled = true;
        
        }

        private void OcultarMesAnio() {
            this.cmbAnio.Enabled = false;
            this.cmbMes.Enabled = false;
            this.dtpFechaDesde.Enabled = true;
            this.dtpFechaHasta.Enabled = true;
            
        }

  
    }
}
