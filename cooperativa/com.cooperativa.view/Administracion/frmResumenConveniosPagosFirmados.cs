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
    public partial class frmResumenConveniosPagosFirmados : Form
    {
        #region << EVENTOS >>
        public frmResumenConveniosPagosFirmados()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmResumenConveniosPagosFirmados_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void chkFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkFecha.Checked)
                this.cmbFecha.Enabled = true;
            else
            {
                this.cmbFecha.Enabled = false;
                CargarFecha();
            }
        }

        private void rbFiltrarConvenios_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarCheck();
        }

        private void chkCuotas_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkCuotas.Checked)
                this.cmbCuotas.Enabled = true;
            else
            {
                this.cmbCuotas.Enabled = false;
                CargarCuotas();
            }
        }

        private void chkEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkEstado.Checked)
                this.cmbEstado.Enabled = true;
            else
            {
                this.cmbEstado.Enabled = false;
                CargarEstados();
            }
        }

        private void chkImporteConv_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkImporteConv.Checked)
                this.cmbImporteConv.Enabled = true;
            else
            {
                this.cmbImporteConv.Enabled = false;
                CargarImporteConvenio();
            }
        }

        private void chkImporteCuota_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkImporteCuota.Checked)
                this.cmbImporteCuota.Enabled = true;
            else
            {
                this.cmbImporteCuota.Enabled = false;
                CargarImporteCuota();
            }
        }

        private void chkTipo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkTipo.Checked)
                this.cmbTipo.Enabled = true;
            else
            {
                this.cmbTipo.Enabled = false;
                CargarTipoConvenio();
            }
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            DesabilitarCheck();
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region << Metodos >>
        private void Inicializar()
        {
            CargarCuotas();
            CargarEstados();
            CargarFecha();
            CargarImporteConvenio();
            CargarImporteCuota();
            CargarTipoConvenio();
        }

        private void CargarFecha()
        {

            DataTable dtOpciones = new DataTable();
            dtOpciones.Columns.Add("numero", typeof(string));
            dtOpciones.Columns.Add("opcion", typeof(string));
            dtOpciones.Rows.Add("01", "Entre dos fechas");
            dtOpciones.Rows.Add("02", "Desde el Día");
            dtOpciones.Rows.Add("03", "Hasta el Día");
            this.cmbFecha.DataSource = dtOpciones;
            this.cmbFecha.ValueMember = "numero";
            this.cmbFecha.DisplayMember = "opcion";
        }

        private void CargarCuotas()
        {

            DataTable dtOpciones = new DataTable();
            dtOpciones.Columns.Add("numero", typeof(string));
            dtOpciones.Columns.Add("opcion", typeof(string));
            dtOpciones.Rows.Add("01", "Entre dos cantidades");
            dtOpciones.Rows.Add("02", "Menos de");
            dtOpciones.Rows.Add("03", "Más de");
            this.cmbCuotas.DataSource = dtOpciones;
            this.cmbCuotas.ValueMember = "numero";
            this.cmbCuotas.DisplayMember = "opcion";
        }

        private void CargarEstados()
        {

            DataTable dtOpciones = new DataTable();
            dtOpciones.Columns.Add("numero", typeof(string));
            dtOpciones.Columns.Add("opcion", typeof(string));
            dtOpciones.Rows.Add("01", "Finalizados");
            dtOpciones.Rows.Add("02", "Sin Finalizar");
            this.cmbEstado.DataSource = dtOpciones;
            this.cmbEstado.ValueMember = "numero";
            this.cmbEstado.DisplayMember = "opcion";
        }


        private void CargarImporteConvenio()
        {

            DataTable dtOpciones = new DataTable();
            dtOpciones.Columns.Add("numero", typeof(string));
            dtOpciones.Columns.Add("opcion", typeof(string));
            dtOpciones.Rows.Add("01", "Entre dos importes");
            dtOpciones.Rows.Add("02", "Menos de");
            dtOpciones.Rows.Add("03", "Más de");
            this.cmbImporteConv.DataSource = dtOpciones;
            this.cmbImporteConv.ValueMember = "numero";
            this.cmbImporteConv.DisplayMember = "opcion";
        }


        private void CargarImporteCuota()
        {

            DataTable dtOpciones = new DataTable();
            dtOpciones.Columns.Add("numero", typeof(string));
            dtOpciones.Columns.Add("opcion", typeof(string));
            dtOpciones.Rows.Add("01", "Entre dos importes");
            dtOpciones.Rows.Add("02", "Menos de");
            dtOpciones.Rows.Add("03", "Más de");
            this.cmbImporteCuota.DataSource = dtOpciones;
            this.cmbImporteCuota.ValueMember = "numero";
            this.cmbImporteCuota.DisplayMember = "opcion";
        }


        private void CargarTipoConvenio()
        {

            DataTable dtOpciones = new DataTable();
            dtOpciones.Columns.Add("numero", typeof(string));
            dtOpciones.Columns.Add("opcion", typeof(string));
            dtOpciones.Rows.Add("01", "Normal");
            dtOpciones.Rows.Add("02", "Judiciales");
            dtOpciones.Rows.Add("03", "No volcados");
            dtOpciones.Rows.Add("04", "Moratoria");
            this.cmbTipo.DataSource = dtOpciones;
            this.cmbTipo.ValueMember = "numero";
            this.cmbTipo.DisplayMember = "opcion";
        }

        private void DesabilitarCheck()
        {
            this.chkFecha.Enabled = false;
            this.chkCuotas.Enabled = false;
            this.chkEstado.Enabled = false;
            this.chkImporteConv.Enabled = false;
            this.chkImporteCuota.Enabled = false;
            this.chkTipo.Enabled = false;
        }

        private void HabilitarCheck()
        {
            this.chkFecha.Enabled = true;
            this.chkCuotas.Enabled = true;
            this.chkEstado.Enabled = true;
            this.chkImporteConv.Enabled = true;
            this.chkImporteCuota.Enabled = true;
            this.chkTipo.Enabled = true;
        }


        #endregion 
    }
}
