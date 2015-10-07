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

namespace com.cooperativa.view.Cobranza
{
    public partial class frmCobranzasConceptosParticulares : Form
    {


        #region << EVENTOS >>
        public frmCobranzasConceptosParticulares()
        {
            InitializeComponent();
        }

        private void frmCobranzasConceptosParticulares_Load(object sender, EventArgs e)
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
        

        #endregion


        #region << METODOS >>

        private void Inicializar() {
            CargarConceptosParticulares();
            CargarPeriodos();
        }

        private void CargarPeriodos()
        {
            PeriodosImplement oPeriodosImplement = new PeriodosImplement();
            oPeriodosImplement.CargarComboUltimosPeriodos(ref cmbDesde, "Seleccionar Periodo Desde");

            oPeriodosImplement.CargarComboUltimosPeriodos(ref cmbHasta, "Seleccionar Periodo Hasta");
            this.cmbHasta.SelectedIndex = this.cmbHasta.Items.Count - 1;
        }
        private void CargarConceptosParticulares() {

            ConceptoImplement oConceptosImplement = new ConceptoImplement();
            oConceptosImplement.CargarCheckListBox(this.chkListConceptoParticular);
        }

        #endregion


    }
}
