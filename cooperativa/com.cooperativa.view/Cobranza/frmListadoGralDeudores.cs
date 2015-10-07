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
    public partial class frmListadoGralDeudores : Form
    {
   
        #region << EVENTOS >>
        public frmListadoGralDeudores()
        {
            InitializeComponent();
        }
        private void frmListadoGralDeudores_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void rbtnTodosBarrios_CheckedChanged(object sender, EventArgs e)
        {
            OcultarListado();
        }

        private void rbtnSelecionaBarrio_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarBarrio();
        }

        private void rbtnFiltro_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarFiltro();
        }

        private void rbtnDistritosElectorales_CheckedChanged(object sender, EventArgs e)
        {
            OcultarListado();
        }

        private void rbtnTodosBarriosDistritos_CheckedChanged(object sender, EventArgs e)
        {
            OcultarListado();
        }

        private void rbtnATodosSocios_CheckedChanged(object sender, EventArgs e)
        {
            Ocultar234();
        }

        private void rbtnAAdeudan_CheckedChanged(object sender, EventArgs e)
        {
            Ocultar134();
        }

        private void rbtnADeudaPesos_CheckedChanged(object sender, EventArgs e)
        {
            Ocultar124();
        }

        private void rbtnDeudaConvenio_CheckedChanged(object sender, EventArgs e)
        {
            Ocultar123();
        }

        private void rbtnTodosConvenios_CheckedChanged(object sender, EventArgs e)
        {
            OcultarConvenios();
        }

        private void rbtnConveniosFirmados_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarConvenios();
        }

        private void rbtnTodosCategoria_CheckedChanged(object sender, EventArgs e)
        {
            OcultarCategorias();
        }
        private void rbtnSeleccionaCategoria_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarCategorias();
        }


        private void rbtnFHoy_CheckedChanged(object sender, EventArgs e)
        {
            OcultarFecha();
        }

        private void rbtnFAl_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarFecha();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void rbtnVSistema_CheckedChanged(object sender, EventArgs e)
        {
            OcultarPorcentaje();
        }

        private void rbtnVRecargo_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarPorcentaje();
        }

        private void rbtnVSinRecargo_CheckedChanged(object sender, EventArgs e)
        {
            OcultarPorcentaje();
        }

   
        #endregion
        #region << METODOS >>
        private void Inicializar() {
            CargarBarrios();
            CargarCategorias();
            CargarComparadorDos();
            CargarComparadorUno();
            HabilitarBarrio();
            Ocultar234();
            OcultarCategorias();
            OcultarFecha();
            OcultarPorcentaje();
        }

        private void CargarBarrios()
        {
            BarrioImplement oBarrioImplement = new BarrioImplement();
            oBarrioImplement.CargarCombo(this.cmbBarrio, "Seleccione Barrio");
        }

        private void CargarCategorias() {
            CategoriaImplement oCategoriaImplement = new CategoriaImplement();
            oCategoriaImplement.CargarCombo(ref this.cmbCategoria, "Seleccione Categoria");
        }

        private void CargarComparadorUno() {

            DataTable dtOpciones = new DataTable();
            dtOpciones.Columns.Add("numero", typeof(string));
            dtOpciones.Columns.Add("opcion", typeof(string));
            dtOpciones.Rows.Add("01", "Más de");
            dtOpciones.Rows.Add("02", "Menos de");
            dtOpciones.Rows.Add("03", "Igual a");

            this.cmbOpciones.DataSource = dtOpciones;
            this.cmbOpciones.ValueMember = "numero";
            this.cmbOpciones.DisplayMember = "opcion";
        }

        private void CargarComparadorDos()
        {

            DataTable dtOpciones = new DataTable();
            dtOpciones.Columns.Add("numero", typeof(string));
            dtOpciones.Columns.Add("opcion", typeof(string));
            dtOpciones.Rows.Add("01", "Mayor que");
            dtOpciones.Rows.Add("02", "Menor que");
            dtOpciones.Rows.Add("03", "Igual a");

            this.cmbOpcionesDos.DataSource = dtOpciones;
            this.cmbOpcionesDos.ValueMember = "numero";
            this.cmbOpcionesDos.DisplayMember = "opcion";
        }

        private void HabilitarBarrio() {
            this.cmbBarrio.Enabled = true;
            this.btnFiltro.Enabled = false;
        }

        private void HabilitarFiltro (){ 
            this.cmbBarrio.Enabled=false;
            this.btnFiltro.Enabled=true;
        }

        private void OcultarListado() {
            this.cmbBarrio.Enabled = false;
            this.btnFiltro.Enabled = false;
        }

        private void Ocultar234() { 
        
            this.cmbOpciones.Enabled=false;
            this.txtPeriodos.Enabled=false;
            this.txtPeriodos.Text="";
            this.cmbOpcionesDos.Enabled=false;
            this.txtPesos.Enabled=false;
            this.txtPesos.Text="";
            this.gbDeudaConvenio.Enabled=false;
        }
        private void Ocultar134() {
            this.cmbOpciones.Enabled = true;
            this.txtPeriodos.Enabled = true;
            this.txtPeriodos.Text = "";
            this.cmbOpcionesDos.Enabled = false;
            this.txtPesos.Enabled = false;
            this.txtPesos.Text = "";
            this.gbDeudaConvenio.Enabled = false;
        
        }

        private void Ocultar124() {
            this.cmbOpciones.Enabled = false;
            this.txtPeriodos.Enabled = false;
            this.txtPeriodos.Text = "";
            this.cmbOpcionesDos.Enabled = true;
            this.txtPesos.Enabled = true;
            this.txtPesos.Text = "";
            this.gbDeudaConvenio.Enabled = false;
        }

        private void Ocultar123() {

            this.cmbOpciones.Enabled = false;
            this.txtPeriodos.Enabled = false;
            this.txtPeriodos.Text = "";
            this.cmbOpcionesDos.Enabled = false;
            this.txtPesos.Enabled = false;
            this.txtPesos.Text = "";
            this.gbDeudaConvenio.Enabled = true;
            OcultarConvenios();
        
        }


        private void OcultarConvenios() {
            dtpADesde.Enabled = false;
            dtpAHasta.Enabled = false;
            dtpADesde.Text="";
            dtpAHasta.Text = "";
            
        }

        private void HabilitarConvenios() {

            dtpADesde.Enabled = true;
            dtpAHasta.Enabled = true;
            dtpADesde.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
            dtpAHasta.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
        }

        private void OcultarCategorias() {

            this.cmbCategoria.Enabled = false;
            this.cmbCategoria.SelectedValue = 0;
        }

        private void HabilitarCategorias() {
            this.cmbCategoria.Enabled = true;
        }

        private void OcultarFecha() {
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Text = "";
        }

        private void HabilitarFecha() {
            this.dtpFecha.Enabled = true;
            this.dtpFecha.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
        
        }
        private void OcultarPorcentaje() {
            this.txtPorcentaje.Enabled = false;
            this.txtPorcentaje.Text = "";
        }

        private void HabilitarPorcentaje() {
            this.txtPorcentaje.Enabled = true;
            this.txtPorcentaje.Text = "";
        }
        #endregion

 

        
        



  
        
    }
}
