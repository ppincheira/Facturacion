using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using com.cooperativa.implement;
using com.cooperativa.implement.dao;

namespace com.cooperativa.view
{
    public partial class frmConceptosParticulares : Form
    {

        #region << PROPIEDADES >>
        bool _eliminoCP;
        int _idSocio;

        #endregion

        #region << EVENTOS >>

        public frmConceptosParticulares(int idSocio)
        {
            InitializeComponent();
            _idSocio = idSocio;
        }

        private void frmConceptosParticulares_Load(object sender, EventArgs e)
        {
            Inicializar();
            _eliminoCP = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarConceptoParticular();
            btnActualizar.Visible = false;
            CargarGrillaConceptosParticulares();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvConceptosPart_SelectionChanged(object sender, EventArgs e)
        {
            CargarDatosConceptoParticular();
            btnActualizar.Visible = false;
        }

        private void txtImporte_TextChanged(object sender, EventArgs e)
        {
            btnActualizar.Visible = true;
        }

        private void cmbPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnActualizar.Visible = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarConceptoComoParticular();
            btnActualizar.Visible = false;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            _eliminoCP = true;
            conceptos_particulares oConceptosParticulares = new conceptos_particulares();
            conceptosParticularesImplement oConceptosParticularesimplement = new conceptosParticularesImplement();

            DataGridViewRow row = this.dgvConceptosPart.CurrentRow;
            if (row != null)
            {
                int id = Convert.ToInt32(row.Cells[0].Value);

                oConceptosParticularesimplement.Delete(id);
            }
            CargarGrillaConceptosParticulares();
        }

        #endregion

        #region << METODOS >>

        private void Inicializar()
        {
            CargarGrillaConceptos();
            CargarGrillaConceptosParticulares();
            CargarComboPeriodos();
            btnActualizar.Visible = false;
        }

        private void CargarComboPeriodos()
        {
            this.cmbPeriodo.Enabled = true;
            PeriodosImplement oPeriodosImplement = new PeriodosImplement();
            oPeriodosImplement.CargarCombo(ref this.cmbPeriodo, "Seleccione..");
        }

        private void CargarGrillaConceptos()
        {
            ConceptoImplement oConceptoImplement = new ConceptoImplement();

            this.dgvConceptos.DataSource = oConceptoImplement.GetAllDT();
            this.dgvConceptos.Enabled = true;
            btnActualizar.Visible = false;
            //_eliminoC = false;
        }

        private void CargarGrillaConceptosParticulares()
        {
            conceptosParticularesImplement oConceptosParticularesImplement = new conceptosParticularesImplement();

            this.dgvConceptosPart.DataSource = oConceptosParticularesImplement.GetByIdSocioDT(_idSocio);
            this.dgvConceptosPart.Enabled = true;
            btnActualizar.Visible = false;
            _eliminoCP = false;
        }

        private void CargarDatosConceptoParticular()
        {
            if (!_eliminoCP)
            {
                conceptos_particulares oConceptosParticulares = new conceptos_particulares();
                conceptosParticularesImplement oConceptosParticularesimplement = new conceptosParticularesImplement();

                DataGridViewRow row = this.dgvConceptosPart.CurrentRow;
                int id = Convert.ToInt32(row.Cells[0].Value);
                oConceptosParticulares = oConceptosParticularesimplement.Get(id);
                this.txtImporte.Text = oConceptosParticulares.importe.ToString();
                this.cmbPeriodo.SelectedValue = oConceptosParticulares.id_periodo;
            }
        }

        private void ActualizarConceptoParticular()
        {
            conceptos_particulares oConceptosParticulares = new conceptos_particulares();
            conceptosParticularesImplement oConceptosParticularesimplement = new conceptosParticularesImplement();
            DataGridViewRow row = this.dgvConceptosPart.CurrentRow;
            int id = Convert.ToInt32(row.Cells[0].Value);
            oConceptosParticulares = oConceptosParticularesimplement.Get(id);
            oConceptosParticulares.id_periodo = this.cmbPeriodo.SelectedValue.ToString();
            oConceptosParticulares.importe = Decimal.Parse(this.txtImporte.Text);
            oConceptosParticularesimplement.Update(oConceptosParticulares);
            btnActualizar.Visible = false;
        }

        private void AgregarConceptoComoParticular()
        {
            cod_conceptos oCod_Conceptos = new cod_conceptos();
            ConceptoImplement oConceptoImplement = new ConceptoImplement();

            conceptos_particulares oConceptosParticulares = new conceptos_particulares();
            conceptosParticularesImplement oConceptosParticularesimplement = new conceptosParticularesImplement();
            PeriodosImplement oPeriodosImplement = new PeriodosImplement();

            string nuevoPeriodo = oPeriodosImplement.GetUltimoPeriodo();
            if (nuevoPeriodo != "")
            {
                DataGridViewRow rowconcepto = this.dgvConceptos.CurrentRow;
                int idConcepto = Convert.ToInt32(rowconcepto.Cells[0].Value);
                oCod_Conceptos = oConceptoImplement.Get(idConcepto);

                oConceptosParticulares.id_concepto = idConcepto;
                oConceptosParticulares.id_socio = _idSocio;
                //oConceptosParticulares.id_factura = oCod_Conceptos.;
                oConceptosParticulares.id_periodo = nuevoPeriodo;
                oConceptosParticulares.importe = decimal.Parse(oCod_Conceptos.variable.ToString());
                oConceptosParticulares.detalles = oCod_Conceptos.concepto;
                oConceptosParticulares.facturado = false;

                oConceptosParticularesimplement.Save(oConceptosParticulares);
                this.txtImporte.Text = oConceptosParticulares.importe.ToString();
                this.cmbPeriodo.SelectedValue = oConceptosParticulares.id_periodo;
            }
            CargarGrillaConceptosParticulares();
            btnActualizar.Visible = false;
        }

        #endregion

        

       
        

       

        

        
        

        
    }
}
