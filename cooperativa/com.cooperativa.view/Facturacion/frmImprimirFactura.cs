using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using com.cooperativa.implement;
using com.cooperativa.services;
using com.cooperativa.implement.dao;

namespace com.cooperativa.view.Facturacion
{
    public partial class frmImprimirFactura : Form
    {
        #region << EVENTOS >>
        public frmImprimirFactura()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnSeleccionFacturas_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLeyendas_Click(object sender, EventArgs e)
        {

        }

        private void frmImprimirFactura_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void rbSelFacturasReImp_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarSeleccion();
            HabilitarChkImprimir();
        }
        private void rbPeriodoCompleto_CheckedChanged(object sender, EventArgs e)
        {
            DeshabilitarSeleccion();
            DeshabilitarCheck();
        }

        private void rbFacturasUnaZona_CheckedChanged(object sender, EventArgs e)
        {
            DeshabilitarSeleccion();
            DeshabilitarCheck();
            DeshabilitarBarrio();
            HabilitarZona();
        }

        private void rbFacturasBarrio_CheckedChanged(object sender, EventArgs e)
        {
            DeshabilitarCheck();
            DeshabilitarSeleccion();
            DeshabilitarZona();
            HabilitarBarrio();
            HabilitarchkZonasImprimir();
           
        }

        private void chkPeriodoHasta_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkPeriodoHasta.Checked)
                this.cmbPeriodoHasta.Enabled = true;
            else
                this.cmbPeriodoHasta.Enabled = false;
        }

        #endregion


        #region << METODOS >>

        private void Inicializar()
        {
            CargarBarrios();
            CargarZonas();
            CargarOrdenar();
            CargarPeriodos();
            HabilitarPeriodoHasta();
        }
        private void HabilitarZona() {
            this.cmbZonas.Enabled = true;
        }


        private void HabilitarBarrio() {
            this.cmbBarrios.Enabled = true;
        }

        private void HabilitarPeriodoHasta() {
            this.chkPeriodoHasta.Checked = true;
        }

        private void HabilitarChkImprimir() {
            this.chkSinRecargo.Enabled = true;
        }

        private void HabilitarchkZonasImprimir(){
            this.chkZonasNoImprimen.Enabled = true;
        }
        private void HabilitarSeleccion()
        {
            this.gbSeleccionar.Visible = true;
        }
        private void DeshabilitarBarrio() {
            this.cmbBarrios.Enabled = false;
        }
        private void  DeshabilitarZona(){
            this.cmbZonas.Enabled = false;
        }
        private void DeshabilitarSeleccion()
        {
            this.gbSeleccionar.Visible = false;
        }
        private void DeshabilitarCheck() {
            this.chkSinRecargo.Enabled = false;
            this.chkZonasNoImprimen.Enabled = false;
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

        private void CargarOrdenar()
        {
            List<Item> lista = new List<Item>();
            lista.Add(new Item("Seleccione Orden", 0));
            lista.Add(new Item("Barrio - Manzana -Lote", 1));
            lista.Add(new Item("Nº de Socio", 2));
            lista.Add(new Item("Nº de Factura", 3));
            this.cmbOrdenar.DisplayMember = "Name";
            this.cmbOrdenar.ValueMember = "Value";
            this.cmbOrdenar.DataSource = lista;
        }

        private void CargarPeriodos() {
            PeriodosImplement oPeriodosImplement = new PeriodosImplement();
            oPeriodosImplement.CargarComboUltimosPeriodos(ref cmbPeriodoDesde, "Seleccionar Periodo Desde");

            oPeriodosImplement.CargarComboUltimosPeriodos(ref cmbPeriodoHasta, "Seleccionar Periodo Hasta");
            this.cmbPeriodoHasta.SelectedIndex = this.cmbPeriodoHasta.Items.Count-1;
        }


        #endregion




    

     
    }
}
