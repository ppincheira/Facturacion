using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using com.cooperativa.implement.dao;
using com.cooperativa.implement;

namespace com.cooperativa.view.Facturacion
{
    public partial class frmResumenFacturacion : Form
    {   
     
        enum Meses { Enero = 1, Febrero = 2, Marzo=3, Abril=4, Mayo=5, Junio=6, Julio=7, Agosto=8, Septiembre=9, Octubre=10, Noviembre=11, Diciembre=12 }

        public frmResumenFacturacion()
        {
            InitializeComponent();
        }

        #region << EVENTOS >>

        private void frmResumenFacturacion_Load(object sender, EventArgs e)
        {
            Inicializar();
        }
        private void rbEspecificarBarrio_CheckedChanged(object sender, EventArgs e)
        {
            this.cmbBarrios.Enabled = true;
        }

        private void rbEspecificarZonas_CheckedChanged(object sender, EventArgs e)
        {
            this.cmbZonas.Enabled = true;
        }

        private void rbTodosBarrios_CheckedChanged(object sender, EventArgs e)
        {
            this.cmbBarrios.Enabled = false;
            this.cmbBarrios.SelectedValue = 0;
        }

        private void rbTodasZonas_CheckedChanged(object sender, EventArgs e)
        {
            this.cmbZonas.Enabled = false;
            this.cmbZonas.SelectedValue = 0;
        }
        private void rbConceptoBZ_CheckedChanged(object sender, EventArgs e)
        {
            this.PanelBZ.Enabled = true;
        }

        private void rbFacturacionBZ_CheckedChanged(object sender, EventArgs e)
        {
            this.PanelBZ.Enabled = true;
        }

        private void rbGeneralConcepto_CheckedChanged(object sender, EventArgs e)
        {
            this.PanelBZ.Enabled = false;
        }

        private void rbGneralTarifa_CheckedChanged(object sender, EventArgs e)
        {
            this.PanelBZ.Enabled = false;
        }

        private void rbGeneralBarrio_CheckedChanged(object sender, EventArgs e)
        {
            this.PanelBZ.Enabled = false;
        }

        private void rbSubDiario_CheckedChanged(object sender, EventArgs e)
        {
            this.PanelBZ.Enabled = false;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Generar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
           Salir();
        }

        #endregion

        #region << METODOS >>

        private void Inicializar()
        {
            CargarAnios();
            CargarMeses();
            CargarBarrios();
            CargarZonas();
            this.cmbBarrios.Enabled = false;
            this.cmbZonas.Enabled = false;
            this.PanelBZ.Enabled = false;
        }

        private void Salir() {
            this.Close();
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

        private void CargarBarrios()
        {
            BarrioImplement oBarrioImplement = new BarrioImplement();
            oBarrioImplement.CargarCombo(this.cmbBarrios, "Seleccione Barrio");
        }

        private void CargarZonas()
        {
            ZonaImplement oZonaImplement = new ZonaImplement();
            oZonaImplement.CargarCombo(this.cmbZonas, "Seleccione Zona");
        }

        private void Generar() {

            if (this.rbGeneralConcepto.Checked) {
                ImprimirConceptos();
            }
            if (this.rbGneralTarifa.Checked) {
                ImprimirTarifas();
            }
            if (this.rbGeneralBarrio.Checked) {
                ImprimirBarrios();
            }
            if (this.rbSubDiario.Checked) {
                ImprimirSubDiarios();
            }
            if (this.rbConceptoBZ.Checked)
            {
                ImprimirConceptoBarrio();
            }
            if (this.rbFacturacionBZ.Checked)
            {
                if ((this.rbTodosBarrios.Checked) || (this.rbEspecificarBarrio.Checked))
                    ImprimirFacturacionBZ();

                if ((this.rbTodasZonas.Checked) || (this.rbEspecificarZonas.Checked))
                    ImprimirFacturacionZB();
            }
        }

        private void ImprimirConceptos() {

            FacturasImplement oFacturaImplement = new FacturasImplement();
            SysConfigImplement oSysConfigImplement = new SysConfigImplement();
            view.Reportes.frmReportes frmRpt = new view.Reportes.frmReportes();
            Facturacion.Reportes.rptResumenXConcepto rpt = new Reportes.rptResumenXConcepto();
            //Cargo el Data Set
            DataSet ds = new DataSet("dsResumen");
            ds.Tables.Add(oSysConfigImplement.GetEncabezadoDT("Encabezado"));
            ds.Tables[0].TableName = "dtEncabezado";
            ds.Tables.Add(oFacturaImplement.GetResumenFacturacionPorConcepto(this.cmbAnio.SelectedValue.ToString()+this.cmbMes.SelectedValue.ToString(),108000));
            ds.Tables[1].TableName = "dtXConceptos";
            rpt.SetDataSource(ds);
            frmRpt.crvGenerico.ReportSource = rpt;
            frmRpt.Show();
        }

        private void ImprimirTarifas()
        {

            FacturasImplement oFacturaImplement = new FacturasImplement();
            SysConfigImplement oSysConfigImplement = new SysConfigImplement();
            view.Reportes.frmReportes frmRpt = new view.Reportes.frmReportes();
            Facturacion.Reportes.rptResumenXTarifa rpt = new Reportes.rptResumenXTarifa();
            //Cargo el Data Set
            DataSet ds = new DataSet("dsResumen");
            ds.Tables.Add(oSysConfigImplement.GetEncabezadoDT("Encabezado"));
            ds.Tables[0].TableName = "dtEncabezado";
            ds.Tables.Add(oFacturaImplement.GetResumenFacturacionPorTarifas(this.cmbAnio.SelectedValue.ToString() + this.cmbMes.SelectedValue.ToString(), 108000));
            ds.Tables[1].TableName = "dtXTarifas";
            rpt.SetDataSource(ds);
            frmRpt.crvGenerico.ReportSource = rpt;
            frmRpt.Show();
        }

        private void ImprimirBarrios()
        {

            FacturasImplement oFacturaImplement = new FacturasImplement();
            SysConfigImplement oSysConfigImplement = new SysConfigImplement();
            view.Reportes.frmReportes frmRpt = new view.Reportes.frmReportes();
            Facturacion.Reportes.rptResumenXBarrio rpt = new Reportes.rptResumenXBarrio();
            //Cargo el Data Set
            DataSet ds = new DataSet("dsResumen");
            ds.Tables.Add(oSysConfigImplement.GetEncabezadoDT("Encabezado"));
            ds.Tables[0].TableName = "dtEncabezado";
            ds.Tables.Add(oFacturaImplement.GetResumenFacturacionPorBarrios(this.cmbAnio.SelectedValue.ToString() + this.cmbMes.SelectedValue.ToString(), 108000));
            ds.Tables[1].TableName = "dtXBarrios";
            rpt.SetDataSource(ds);
            frmRpt.crvGenerico.ReportSource = rpt;
            frmRpt.Show();
        }

        private void ImprimirSubDiarios() {
            FacturasImplement oFacturaImplement = new FacturasImplement();
            SysConfigImplement oSysConfigImplement = new SysConfigImplement();
            view.Reportes.frmReportes frmRpt = new view.Reportes.frmReportes();
            Facturacion.Reportes.rptResumenSubDiario rpt = new Reportes.rptResumenSubDiario();
            //Cargo el Data Set
            DataSet ds = new DataSet("dsResumen");
            ds.Tables.Add(oSysConfigImplement.GetEncabezadoDT("Encabezado"));
            ds.Tables[0].TableName = "dtEncabezado";
            ds.Tables.Add(oFacturaImplement.GetResumenFacturacionSubDiarios(this.cmbAnio.SelectedValue.ToString() + this.cmbMes.SelectedValue.ToString()));
            ds.Tables[1].TableName = "dtSubDiario";
            rpt.SetDataSource(ds);
            frmRpt.crvGenerico.ReportSource = rpt;
            frmRpt.Show();
        }

        private void ImprimirConceptoBarrio()
        {
            FacturasImplement oFacturaImplement = new FacturasImplement();
            SysConfigImplement oSysConfigImplement = new SysConfigImplement();
            view.Reportes.frmReportes frmRpt = new view.Reportes.frmReportes();
            Facturacion.Reportes.rptResumenXConceptoXBarrio rpt = new Reportes.rptResumenXConceptoXBarrio();
            //Cargo el Data Set
            DataSet ds = new DataSet("dsResumen");
            ds.Tables.Add(oSysConfigImplement.GetEncabezadoDT("Encabezado"));
            ds.Tables[0].TableName = "dtEncabezado";
            ds.Tables.Add(oFacturaImplement.GetResumenFacturacionPorConceptoPorBarrios(this.cmbAnio.SelectedValue.ToString() + this.cmbMes.SelectedValue.ToString(), 108000,int.Parse(this.cmbBarrios.SelectedValue.ToString())));
            ds.Tables[1].TableName = "dtResumenXConceptoXBarrio";
            rpt.SetDataSource(ds);
            frmRpt.crvGenerico.ReportSource = rpt;
            frmRpt.Show();
        }



        private void ImprimirFacturacionBZ()
        {
            FacturasImplement oFacturaImplement = new FacturasImplement();
            SysConfigImplement oSysConfigImplement = new SysConfigImplement();
            view.Reportes.frmReportes frmRpt = new view.Reportes.frmReportes();
            Facturacion.Reportes.rptResumenFacturacionXBarrioXzona rpt = new Reportes.rptResumenFacturacionXBarrioXzona();
            //Cargo el Data Set
            DataSet ds = new DataSet("dsResumen");
            ds.Tables.Add(oSysConfigImplement.GetEncabezadoDT("Encabezado"));
            ds.Tables[0].TableName = "dtEncabezado";
            ds.Tables.Add(oFacturaImplement.GetResumenFacturacionPorBarriosPorZonas(this.cmbAnio.SelectedValue.ToString() + this.cmbMes.SelectedValue.ToString(),int.Parse(this.cmbBarrios.SelectedValue.ToString()), int.Parse(this.cmbZonas.SelectedValue.ToString())));
            ds.Tables[1].TableName = "dtResumenFacturacionXBXC";
            rpt.SetDataSource(ds);
            frmRpt.crvGenerico.ReportSource = rpt;
            frmRpt.Show();
        }



        private void ImprimirFacturacionZB()
        {
            FacturasImplement oFacturaImplement = new FacturasImplement();
            SysConfigImplement oSysConfigImplement = new SysConfigImplement();
            view.Reportes.frmReportes frmRpt = new view.Reportes.frmReportes();
            Facturacion.Reportes.rptResumenFacturacionXzonaXBarrio rpt = new Reportes.rptResumenFacturacionXzonaXBarrio();
            //Cargo el Data Set
            DataSet ds = new DataSet("dsResumen");
            ds.Tables.Add(oSysConfigImplement.GetEncabezadoDT("Encabezado"));
            ds.Tables[0].TableName = "dtEncabezado";
            ds.Tables.Add(oFacturaImplement.GetResumenFacturacionPorBarriosPorZonas(this.cmbAnio.SelectedValue.ToString() + this.cmbMes.SelectedValue.ToString(),int.Parse(this.cmbBarrios.SelectedValue.ToString()), int.Parse(this.cmbZonas.SelectedValue.ToString())));
            ds.Tables[1].TableName = "dtResumenFacturacionXBXC";
            rpt.SetDataSource(ds);
            frmRpt.crvGenerico.ReportSource = rpt;
            frmRpt.Show();
        }
        #endregion


   

    }
}
