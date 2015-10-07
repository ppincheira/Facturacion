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
    public partial class FrmTipoIVA : Form
    {
        #region << Eventos >>

        public FrmTipoIVA()
        {
            InitializeComponent();
        }

        private void FrmTipoIVA_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            NuevoTipoIva();
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            ModificarTipoIva();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {

        }

        private void tsbImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void dgvTipoIva_SelectionChanged(object sender, EventArgs e)
        {
            CargarSeleccion();
        }
        #endregion

        #region << METODOS >>

        private void Inicializar()
        {
            CargarGrid();
            this.gbTipoIva.Enabled = false;
        }
        private void CargarSeleccion()
        {
            cod_impuestos oImpuesto = new cod_impuestos();
            ImpuestoImplement oImpuestoImplement = new ImpuestoImplement();
            
            DataGridViewRow row = this.dgvTipoIva.CurrentRow;
            int id = Convert.ToInt32(row.Cells[0].Value);
            oImpuesto = oImpuestoImplement.Get(id);
            this.lblCodigo.Text = oImpuesto.id_impuesto.ToString();
            this.txtNombre.Text = oImpuesto.impuesto;
            this.dtpFechaDesde.Text = oImpuesto.vigencia_desde.ToString();
            this.dtpFechaHasta.Text = oImpuesto.vigencia_hasta.ToString();
            this.txtAlicuota.Text = oImpuesto.porcentaje.ToString();
            this.chkActivo.Checked = oImpuesto.activo.Value;
            this.chkCreditoFiscal.Checked = oImpuesto.credito_fiscal.Value;
            Deshabilitar();
        }

        private void Guardar()
        {
            ImpuestoImplement oImpuestoImplement = new ImpuestoImplement();
            cod_impuestos oImpuesto = new cod_impuestos();

            if (this.lblCodigo.Text == "")
            {
                oImpuesto.impuesto = this.txtNombre.Text;
                oImpuesto.porcentaje = decimal.Parse(this.txtAlicuota.Text);
                oImpuesto.vigencia_desde =DateTime.Parse( this.dtpFechaDesde.Text);
                oImpuesto.vigencia_hasta = DateTime.Parse(this.dtpFechaHasta.Text);
                oImpuesto.activo = this.chkActivo.Checked;
                oImpuesto.credito_fiscal = this.chkCreditoFiscal.Checked;
                oImpuestoImplement.Save(oImpuesto);
            }
            else
            {

                DataGridViewRow row = this.dgvTipoIva.CurrentRow;
                int id = Convert.ToInt32(row.Cells[0].Value);
                oImpuesto = oImpuestoImplement.Get(id);
                oImpuesto.impuesto = this.txtNombre.Text;
                oImpuesto.porcentaje = Decimal.Parse(this.txtAlicuota.Text);
                oImpuesto.vigencia_desde = DateTime.Parse(this.dtpFechaDesde.Text);
                oImpuesto.vigencia_hasta = DateTime.Parse(this.dtpFechaHasta.Text);
                oImpuesto.activo = this.chkActivo.Checked;
                oImpuesto.credito_fiscal = this.chkCreditoFiscal.Checked;
                oImpuestoImplement.Update(oImpuesto);
            }
            Deshabilitar();
     
            CargarGrid();

        }

        private void HabilitarBotones()
        {
            this.btnAceptar.Enabled = true;
            this.btnCancelar.Enabled = true;
            this.tsMenu.Enabled = false;
        }
        private void Deshabilitar()
        {
            this.btnCancelar.Enabled = false;
            this.btnAceptar.Enabled = false;
            this.tsMenu.Enabled = true;

        }
        private void Cancelar()
        {
            this.dgvTipoIva.Enabled = true;
            this.txtNombre.Text = "";
            this.txtNombre.Enabled = false;
            this.lblCodigo.Text = "";
            Deshabilitar();
        }

        private void NuevoTipoIva()
        {
            HabilitarBotones();
            this.gbTipoIva.Enabled = true;
            this.txtNombre.Text = "";
            this.txtNombre.Enabled = true;
            this.lblCodigo.Text = "";
        }

        private void ModificarTipoIva()
        {
            HabilitarBotones();
            this.gbTipoIva.Enabled = true;
            cod_impuestos oImpuesto = new cod_impuestos();
            ImpuestoImplement oImpuestoImplement = new ImpuestoImplement();
            DataGridViewRow row = this.dgvTipoIva.CurrentRow;
            int id = Convert.ToInt32(row.Cells[0].Value);
            oImpuesto = oImpuestoImplement.Get(id);
            this.lblCodigo.Text = oImpuesto.id_impuesto.ToString();
            this.txtNombre.Text = oImpuesto.impuesto;
            this.txtAlicuota.Text = oImpuesto.porcentaje.ToString();
            this.dtpFechaDesde.Text = oImpuesto.vigencia_desde.ToString();
            this.dtpFechaHasta.Text = oImpuesto.vigencia_hasta.ToString();
            this.chkActivo.Checked = oImpuesto.activo.Value;
            this.chkCreditoFiscal.Checked = oImpuesto.credito_fiscal.Value;
            this.gbTipoIva.Enabled = false;
        }

        private void CargarGrid()
        {
            ImpuestoImplement oImpuestoImplement = new ImpuestoImplement();
            this.dgvTipoIva.DataSource = oImpuestoImplement.GetAll();
            this.dgvTipoIva.Enabled = true;
        }

        #endregion


       

    }
}
