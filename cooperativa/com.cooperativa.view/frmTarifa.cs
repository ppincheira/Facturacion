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
    public partial class frmTarifa : Form
    {
        #region << PROPIEDADES >>
        TarifaImplement oTarifaImplement = new TarifaImplement();
        bool _eliminoTarifa;
        #endregion

        #region << EVENTOS >>
        public frmTarifa()
        {
            InitializeComponent();
        }

        private void frmTarifa_Load(object sender, EventArgs e)
        {
            Inicializar();
            _eliminoTarifa = false;
        }
        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            NuevaTarifa();
        }
        private void tsbModificar_Click(object sender, EventArgs e)
        {
            ModificarTarifa();
        }
        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            EliminarTarifa();
        }
        private void tsbImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }
        private void tsbAceptar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }
        private void dgvTarifa_SelectionChanged(object sender, EventArgs e)
        {
            CargarSeleccion();
        }
        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                Guardar();
            }
        }
        #endregion

        #region << METODOS >>
        private void Inicializar()
        {
            this.gbTarifa.Enabled = false;
            CargarGrid();
        }
        private void CargarSeleccion()
        {
            if (!_eliminoTarifa)
            {
                tarifas oTarifa = new tarifas();

                DataGridViewRow row = this.dgvTarifa.CurrentRow;
                int id = Convert.ToInt32(row.Cells[1].Value);
                oTarifa = oTarifaImplement.Get(id);

                this.lblCodigo.Text = oTarifa.id_tarifa.ToString();
                this.txtTarifa.Text = oTarifa.tarifa;
                this.txtAbreviatura.Text = oTarifa.abreviatura;
                this.txtCargoFijo.Text = oTarifa.cargo_fijo.ToString();
                this.txtM3.Text = oTarifa.valor_m3.ToString();
                this.txtAbono.Text = oTarifa.abono.ToString();
                this.chkTarifaActiva.Checked = oTarifa.activa.Value;
                this.chkAplicarRecargo.Checked = oTarifa.recargo_minimo.Value;
                this.chkBonicacion.Checked = oTarifa.bonificacion.Value;
                this.CHKUsuarioResidencial.Checked = oTarifa.usuario_residencial.Value;
                this.chkVencimiento.Checked = oTarifa.requiere_fin.Value;
                this.txtMeses.Text = oTarifa.meses_venc.ToString();
                Deshabilitar();
            }
        }
        private void CargarGrid()
        {
            //TarifaImplement oTarifaImplement = new TarifaImplement();
            this.dgvTarifa.DataSource = oTarifaImplement.Buscar("");
            this.dgvTarifa.Enabled = true;
            _eliminoTarifa= false;
        }
       
        private void Guardar()
        {

            TarifaImplement oTarifaImplement = new TarifaImplement();
            tarifas oTarifa = new tarifas();

            if (this.lblCodigo.Text == "")
            {
                oTarifa.tarifa = this.txtTarifa.Text;
                oTarifa.abreviatura = this.txtAbreviatura.Text;
                oTarifa.cargo_fijo = this.txtCargoFijo.Text == "" ? 0 : decimal.Parse(this.txtCargoFijo.Text);
                oTarifa.valor_m3 = this.txtM3.Text == "" ? 0 : decimal.Parse(this.txtM3.Text);
                oTarifa.abono = this.txtAbono.Text == "" ? 0 : decimal.Parse(this.txtAbono.Text);
                oTarifa.activa = this.chkTarifaActiva.Checked;
                oTarifa.recargo_minimo = this.chkAplicarRecargo.Checked;
                oTarifa.bonificacion = this.chkBonicacion.Checked;
                oTarifa.usuario_residencial = this.CHKUsuarioResidencial.Checked;
                oTarifa.requiere_fin = this.chkVencimiento.Checked;
                oTarifa.meses_venc = this.txtMeses.Text == "" ? 0 : int.Parse(this.txtMeses.Text);
                oTarifaImplement.Save(oTarifa);
            }
            else
            {

                DataGridViewRow row = this.dgvTarifa.CurrentRow;
                int id = Convert.ToInt32(row.Cells[1].Value);
                oTarifa = oTarifaImplement.Get(id);
                oTarifa.tarifa = this.txtTarifa.Text;
                oTarifa.abreviatura = this.txtAbreviatura.Text;
                oTarifa.cargo_fijo = this.txtCargoFijo.Text == "" ? 0 : decimal.Parse(this.txtCargoFijo.Text);
                oTarifa.valor_m3 = this.txtM3.Text == "" ? 0 : decimal.Parse(this.txtM3.Text);
                oTarifa.abono = this.txtAbono.Text == "" ? 0 : decimal.Parse(this.txtAbono.Text);
                oTarifa.activa = this.chkTarifaActiva.Checked;
                oTarifa.recargo_minimo = this.chkAplicarRecargo.Checked;
                oTarifa.bonificacion = this.chkBonicacion.Checked;
                oTarifa.usuario_residencial = this.CHKUsuarioResidencial.Checked;
                oTarifa.requiere_fin = this.chkVencimiento.Checked;
                oTarifa.meses_venc = this.txtMeses.Text == "" ? 0 : int.Parse(this.txtMeses.Text);
                oTarifaImplement.Update(oTarifa);
            }
            this.gbTarifa.Enabled = false;
            Deshabilitar();
            Limpiar();
            CargarGrid();

        }
        private void Cancelar()
        {
            this.gbTarifa.Enabled = false;
            this.dgvTarifa.Enabled = true;
            Limpiar();
            Deshabilitar();
        }
        private void Limpiar()
        {
            this.lblCodigo.Text = "";
            this.txtTarifa.Text = "";
            this.txtAbreviatura.Text = "";
            this.txtCargoFijo.Text = "";
            this.txtM3.Text = "";
            this.txtAbono.Text = "";
            this.chkTarifaActiva.Checked = false;
            this.chkAplicarRecargo.Checked = false;
            this.chkBonicacion.Checked = false;
            this.CHKUsuarioResidencial.Checked = false;
            this.chkVencimiento.Checked = false;
            this.txtMeses.Text = "";

        }
        private void HabilitarBotones()
        {
            this.tsbAceptar.Enabled = true;
            this.tsbCancelar.Enabled = true;

            this.tsbNuevo.Enabled = false;
            this.tsbModificar.Enabled = false;
            this.tsbEliminar.Enabled = false;
            this.tsbImprimir.Enabled = false;
        }
        private void Deshabilitar()
        {
            this.tsbAceptar.Enabled = false;
            this.tsbCancelar.Enabled = false;

            this.tsbNuevo.Enabled = true;
            this.tsbModificar.Enabled = true;
            this.tsbEliminar.Enabled = true;
            this.tsbImprimir.Enabled = true;
        }

        private void NuevaTarifa()
        {
            this.gbTarifa.Enabled = true;
            HabilitarBotones();
            Limpiar();
        }
        private void ModificarTarifa()
        {
            HabilitarBotones();
            this.gbTarifa.Enabled = true;

            tarifas oTarifa = new tarifas();
            TarifaImplement oTarifaImplement = new TarifaImplement();
            DataGridViewRow row = this.dgvTarifa.CurrentRow;
            int id = Convert.ToInt32(row.Cells[1].Value);
            oTarifa = oTarifaImplement.Get(id);
           
            this.lblCodigo.Text = oTarifa.id_tarifa.ToString();
            this.txtTarifa.Text = oTarifa.tarifa;
            this.txtAbreviatura.Text = oTarifa.abreviatura;
            this.txtCargoFijo.Text = oTarifa.cargo_fijo.ToString();
            this.txtM3.Text = oTarifa.valor_m3.ToString();
            this.txtAbono.Text = oTarifa.abono.ToString();
            this.chkTarifaActiva.Checked = oTarifa.activa.Value;
            this.chkAplicarRecargo.Checked = oTarifa.recargo_minimo.Value;
            this.chkBonicacion.Checked = oTarifa.bonificacion.Value;
            this.CHKUsuarioResidencial.Checked = oTarifa.usuario_residencial.Value;
            this.chkVencimiento.Checked = oTarifa.requiere_fin.Value;
            this.dgvTarifa.Enabled = false;
        }
        private void EliminarTarifa()
        {
            if (this.dgvTarifa.CurrentRow != null)
            {
                _eliminoTarifa = true;
                DataGridViewRow row = this.dgvTarifa.CurrentRow;
                int id = Convert.ToInt32(row.Cells[1].Value);
                
                oTarifaImplement.Delete(id);

                Limpiar();

                CargarGrid();
            }
        }
        private void Imprimir()
        {
            SysConfigImplement oSysConfigImplement = new SysConfigImplement();
            Reportes.frmReportes frmRpt = new Reportes.frmReportes();
            Reportes.rptBarrios rpt = new Reportes.rptBarrios();
            //Cargo el Data Set
            DataSet ds = new DataSet("Generico");
            ds.Tables.Add(oSysConfigImplement.GetEncabezadoDT("Encabezado"));
            ds.Tables[0].TableName = "dtEncabezado";
            ds.Tables.Add(oTarifaImplement.GetByTarifaDT(""));
            ds.Tables[1].TableName = "dtTarifas";
            rpt.SetDataSource(ds);
            frmRpt.crvGenerico.ReportSource = rpt;
            frmRpt.Show();
        }
        #endregion
    }
}