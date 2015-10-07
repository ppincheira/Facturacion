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
    public partial class frmResumenDiario : Form
    {
        #region << PROPIEDADES >>
        enum Meses { Enero = 1, Febrero = 2, Marzo = 3, Abril = 4, Mayo = 5, Junio = 6, Julio = 7, Agosto = 8, Septiembre = 9, Octubre = 10, Noviembre = 11, Diciembre = 12 }
        #endregion
        #region << EVENTOS >>
        
        public frmResumenDiario()
        {
            InitializeComponent();
        }

        private void frmResumenDiario_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void btnGenerarResumen_Click(object sender, EventArgs e)
        {

        }

        private void btnResumenCanon_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }
        private void rbtnDia_CheckedChanged(object sender, EventArgs e)
        {
            OcultarDosTres();
        }
        private void rbtDiaUno_CheckedChanged(object sender, EventArgs e)
        {
            OcultarUnoTres();
        }

        private void rbtnMes_CheckedChanged(object sender, EventArgs e)
        {
            OcultarUnoDos();
        }
        private void rbtnCajasSeparado_CheckedChanged(object sender, EventArgs e)
        {
            OcultarCanon();
        }

        private void rbtnCajasJuntas_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarCanon();
        }
        #endregion
        #region << METODOS >>
        private void Salir() {
            this.Close();
        }

        private void Inicializar() {
            CargarAnios();
            CargarMeses();
            OcultarDosTres();
            OcultarCanon();
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

        private void OcultarDosTres() {
            this.dtpFecha.Enabled = true;
            this.dtpFecha.Text = DateTime.Now.Date.ToString();
            this.dtpFechaUno.Enabled = false;
            this.dtpFechaUno.Text = "";
            this.dtpFechaDos.Text = "";
            this.dtpFechaDos.Enabled = false;
            this.cmbMes.Enabled = false;
            this.cmbMes.SelectedValue = 0;
            this.cmbAnio.Enabled = false;
            this.cmbAnio.SelectedValue = 0;
        }

        private void OcultarUnoTres() {
         
            this.dtpFechaUno.Enabled = true;
            this.dtpFechaUno.Text = DateTime.Now.Date.ToString();
            this.dtpFechaDos.Enabled = true;
            this.dtpFechaDos.Text = DateTime.Now.Date.ToString();

            this.dtpFecha.Enabled = false;
            this.dtpFecha.Text = "";
            this.cmbMes.Enabled = false;
            this.cmbMes.SelectedValue = 0;
            this.cmbAnio.Enabled = false;
            this.cmbAnio.SelectedValue = 0;

        }

        private void OcultarUnoDos() {

            this.cmbMes.Enabled = true;
            this.cmbMes.SelectedValue = 0;
            this.cmbAnio.Enabled = true;
            this.cmbAnio.SelectedValue = 0;
            this.dtpFecha.Text = "";
            this.dtpFecha.Enabled = false;
            this.dtpFechaUno.Text = "";
            this.dtpFechaUno.Enabled = false;
            this.dtpFechaDos.Text = "";
            this.dtpFechaDos.Enabled = false;
        }

        private void OcultarCanon() {
     
            this.btnResumenCanon.Enabled = false;
            this.gbEmitir.Enabled = true;
        }

        private void HabilitarCanon() {
            this.gbEmitir.Enabled = false;
            this.btnResumenCanon.Enabled = true;
        
        }
        #endregion



     






    }
}
