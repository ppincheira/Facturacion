using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using com.cooperativa.implement;

namespace com.cooperativa.view.Administracion
{
    public partial class frmAsistenteIntimacionesPorDeuda : Form
    {
        public class Item

        {
            public string Name {get; set;}
            public int Value{get; set;}


            public Item(string name, int value)

            {

            Name = name;

            Value = value;

            }

            public override string ToString()

            {

            return Name;

            }

        }

        #region << PROPIEDADES >>
        string _Panel_0_1 = "";
        string _Panel_0_EstimacionEnBlanco = "";
        string _Panel_1_1 = "";
        int _iCantConv;
        decimal _iTotalConv;
        #endregion

        #region <<EVENTOS>>

        public frmAsistenteIntimacionesPorDeuda()
        {
            InitializeComponent();
        }

        private void frmAsistenteIntimacionesPorDeuda_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            if (pnl0.Visible)
            {
                pnl0.Visible = false;
                pnl1.Visible = true;
                btnAnterior.Enabled = true;


            }
            else
            {
                if (pnl1.Visible)
                {

                    pnl1.Visible = false;
                    pnl2.Visible = true;
                }
                else
                {
                    CrearFiltrosPNL0();
                    CrearFiltrosPNL1();
                    CrearFiltrosPNL2();


                    string test = _Panel_0_1 + _Panel_1_1;
                    //Llegue a la ultima y di siguiente
                    //se realizaria el informe.

                    //pnl0.Visible = true;
                    //pnl2.Visible = false;
                    //btnAnterior.Enabled = false;
                }

            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (pnl1.Visible)
            {
                pnl0.Visible = true;
                pnl1.Visible = false;
                btnAnterior.Enabled = false;
            }
            else
            {
                if (pnl2.Visible)
                {
                    pnl1.Visible = true;
                    pnl2.Visible = false;
                }
                else
                {

                }

            }
        }

        private void pnl0RbtSeleccionarUnBarrio_CheckedChanged(object sender, EventArgs e)
        {
            if (pnl0RbtSeleccionarUnBarrio.Checked)
                pnl0CmbBarrios.Enabled = true;
            else
                pnl0CmbBarrios.Enabled = false;
        }

        private void pnl0RbtFiltrosAvanzados_CheckedChanged(object sender, EventArgs e)
        {
            if (pnl0RbtFiltrosAvanzados.Checked)
                pnl0BtnCrearFiltro.Enabled = true;
            else
                pnl0BtnCrearFiltro.Enabled = false;
        }

        private void pnl0RbtFacturasVencidas_CheckedChanged(object sender, EventArgs e)
        {
            if (pnl0RbtFacturasVencidas.Checked)
                pnl0ChkExcluirSocios.Enabled = true;
            else
                pnl0ChkExcluirSocios.Enabled = false;
        }

        private void pnl0RbtConveniosFirmadosDesde_CheckedChanged(object sender, EventArgs e)
        {
            if (pnl0RbtConveniosFirmadosDesde.Checked)
            {
                pnl0DtpFechaDesde.Enabled = true;
                pnl0DtpFechaHasta.Enabled = true;
            }
            else
            {
                pnl0DtpFechaDesde.Enabled = false;
                pnl0DtpFechaHasta.Enabled = false;
            }
        }

        private void pnl2UnicoAvisoIntPre_CheckedChanged(object sender, EventArgs e)
        {
            if (pnl2UnicoAvisoIntPre.Checked)
            {
                pnl2GbGastosAdministrativos.Enabled = true;
            }
            else
            {
                pnl2GbGastosAdministrativos.Enabled = false;
            }
        }

        private void pnl0RbtCuotasConvenioVencidas_CheckedChanged(object sender, EventArgs e)
        {
            if (pnl0RbtCuotasConvenioVencidas.Checked)
            {
                pnl0GbCuotasVencidas.Enabled = true;
            }
            else
            {
                pnl0GbCuotasVencidas.Enabled = false;
            }
        }

        private void pnl0RbtIntimacionEnBlanco_CheckedChanged(object sender, EventArgs e)
        {
            if (pnl0RbtIntimacionEnBlanco.Checked)
            {
                txtIntimacionBlancoCopias.Enabled = true;
            }
            else
            {
                txtIntimacionBlancoCopias.Enabled = true;
            }
           
        }

        private void pnl2ChkIncluirGastosAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (pnl2ChkIncluirGastosAdmin.Checked)
            {
                pnl2TxtImporteGastosAdm.Enabled = true;
            }
            else
            {
                pnl2TxtImporteGastosAdm.Enabled = false;
            }
        }

        private void pnl2ChkIncluirReconexion_CheckedChanged(object sender, EventArgs e)
        {
            if (pnl2ChkIncluirReconexion.Checked)
            {
                pnl2TxtImporteCostoRec.Enabled = true;
            }
            else
            {
                pnl2TxtImporteCostoRec.Enabled = false;
            }
        }

        private void pnl1RbtTodosLosSocios_CheckedChanged(object sender, EventArgs e)
        {
            if (pnl1RbtTodosLosSocios.Checked)
            {
                pnl1CmbCondicion.Enabled = false;
                pnl1TxtImporte.Enabled = false;
            }
            else
            {
                pnl1CmbCondicion.Enabled = true;
                pnl1TxtImporte.Enabled = true;
            }
        }

        private void pnl1CmbCondicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if condicion
            pnl1TxtImporteHasta.Visible = true;
            pnl1TxtImporteHasta.Enabled = true;
            pnl1LblY.Visible = true;
        }

        private void pnl1ChkFiltrarPorEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (pnl1ChkFiltrarPorEstado.Checked)
            {
                pnl1CmbEstado.Enabled = true;
            }
            else
            {
                pnl1CmbEstado.Enabled = false;
            }
        }

        private void pnl0BtnCrearFiltro_Click(object sender, EventArgs e)
        {
           // Reportes.frmFiltrarDeudores f = new Reportes.frmFiltrarDeudores();

          //  f.Show();
        }

        private void pnl1ChkIncluirSociosDeudaSigPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            if (pnl1ChkIncluirSociosDeudaSigPeriodo.Checked)
            {
                pnl1IncluirCmbMesDesde.Enabled = true;
                pnl1IncluirCmbAnioHasta.Enabled = true;
                pnl1IncluirCmbMesHasta.Enabled = true;
                pnl1IncluirCmbAnioDesde.Enabled = true;
            }
            else
            {
                pnl1IncluirCmbMesDesde.Enabled = false;
                pnl1IncluirCmbAnioHasta.Enabled = false;
                pnl1IncluirCmbMesHasta.Enabled = false;
                pnl1IncluirCmbAnioDesde.Enabled = false;
            }
        }

        private void pnl1ChkExcluirSociosDeudaSigPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            if (pnl1ChkIncluirSociosDeudaSigPeriodo.Checked)
            {
                pnl1ExcluirCmbMesDesde.Enabled = true;
                pnl1ExcluirCmbAnioHasta.Enabled = true;
                pnl1ExcluirCmbMesHasta.Enabled = true;
                pnl1ExcluirCmbAnioDesde.Enabled = true;
            }
            else
            {
                pnl1ExcluirCmbMesDesde.Enabled = false;
                pnl1ExcluirCmbAnioHasta.Enabled = false;
                pnl1ExcluirCmbMesHasta.Enabled = false;
                pnl1ExcluirCmbAnioDesde.Enabled = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion

        #region <<METODOS>>

        private void Inicializar()
        {
            CargarBarrios();
            CargarPnl1Condiciones();
            CargarPnl1Estados();
            CargarPeriodos();
            
        }

        private void CrearFiltrosPNL0()
        {
            if (pnl0RbtSeleccionarUnBarrio.Checked)
                _Panel_0_1 = " AND " + pnl0CmbBarrios.SelectedValue + "= Socios_conexion.barrio ";
            else
                if (pnl0RbtIntimacionEnBlanco.Checked)
                    _Panel_0_EstimacionEnBlanco = txtIntimacionBlancoCopias.Text;

            if (pnl0RbtFacturasVencidas.Checked)
            {
                _Panel_0_1 = _Panel_0_1 + " AND socios.id_socio in (" +
           " select id_socio from facturas f inner join periodos p on f.id_periodo=p.id_periodo " +
           " where f.id_estadoPago=1 and p.fecha_primer_venc<curdate() ";

                if (pnl0ChkExcluirSocios.Checked)
                    _Panel_0_1 = _Panel_0_1 + " and id_convenio=0)";
                else
                    _Panel_0_1 = _Panel_0_1 + ")";

            }
            else
            {
                if (pnl0RbtCuotasConvenioVencidas.Checked)
                {
                    if (pnl0RbtTodosLosConvenios.Checked)
                        _Panel_0_1 = _Panel_0_1 + " AND socios.id_socio in (" +
           " select id_socio from facturas f inner join periodos p on f.id_periodo=p.id_periodo " +
           " inner join convenios conv on conv.id_convenio=f.id_convenio " +
           " where f.id_estadoPago=1 and p.fecha_primer_venc<curdate() and id_convenio>0  ";

                    else
                    {
                        if (pnl0RbtConveniosFirmadosDesde.Checked)
                            _Panel_0_1 = _Panel_0_1 + " conv.fecha_convenio >= " + pnl0DtpFechaDesde.Text + " and conv.fecha_convenio<= " + pnl0DtpFechaHasta.Text + ")";
                        else
                            _Panel_0_1 = _Panel_0_1 + ")";
                    }
                }
                else
                {
                    if (pnl0RbtConveniosNoVolcados.Checked)
                    {
                        //convenios no volcados sin finalizar

                    }
                }
            }


        }

        private void CrearFiltrosPNL1()
        {
            string condicion = "";
            if (pnl1RbtCantidadCuotas.Checked)
            {

                if (pnl1CmbCondicion.SelectedValue.ToString() == "0")
                    condicion = " and convenios.cuotas-Convenios.facturadas>=" + pnl1TxtImporte.Text;
                else
                    if (pnl1CmbCondicion.SelectedValue.ToString() == "1")
                        condicion = " and convenios.cuotas-Convenios.facturadas<" + pnl1TxtImporte.Text;
                    else
                        condicion = " and ( convenios.cuotas-Convenios.facturadas>" + pnl1TxtImporte.Text + "and  convenios.cuotas-Convenios.facturadas< " + pnl1TxtImporteHasta.Text;
            }

            else
            {
                if (pnl1RbtImporteDeuda.Checked)
                {
                    if (pnl1CmbCondicion.SelectedValue.ToString() == "0")
                        condicion = " and (convenios.cuotas-Convenios.facturadas)*convenios.valor_cuota>=" + pnl1TxtImporte.Text;
                    else
                        if (pnl1CmbCondicion.SelectedValue.ToString() == "1")
                            condicion = " and (convenios.cuotas-Convenios.facturadas)*convenios.valor_cuota<" + pnl1TxtImporte.Text;
                        else
                            condicion = " and ( convenios.cuotas-Convenios.facturadas)*convenios.valor_cuota>" + pnl1TxtImporte.Text + " and   ( convenios.cuotas-Convenios.facturadas)*convenios.valor_cuota< " + pnl1TxtImporteHasta.Text;
                }
            }


            _Panel_0_1 = _Panel_0_1 + condicion;
            if (pnl1ChkFiltrarPorEstado.Checked)
            {
                _Panel_0_1 = _Panel_0_1 + " and cod_estados_socios.id_estado_socio= " + pnl1CmbEstado.SelectedValue;
            }

            if (pnl1ChkIncluirSociosDeudaSigPeriodo.Checked)
            {
                _Panel_0_1 = _Panel_0_1 + " and convenios.id_periodo>=" + pnl1IncluirCmbAnioDesde + pnl1IncluirCmbMesDesde;
                _Panel_0_1 = _Panel_0_1 + " and convenios.id_periodo<=" + pnl1IncluirCmbAnioHasta + pnl1IncluirCmbMesHasta;
            }
            if (pnl1ChkExcluirSociosDeudaSigPeriodo.Checked)
            {
                _Panel_0_1 = _Panel_0_1 + " and convenios.id_periodo<" + pnl1IncluirCmbAnioDesde + pnl1IncluirCmbMesDesde;
                _Panel_0_1 = _Panel_0_1 + " and convenios.id_periodo>" + pnl1IncluirCmbAnioHasta + pnl1IncluirCmbMesHasta;
            }
        }

        private void CrearFiltrosPNL2()
        {

        }

        private void CargarBarrios()
        {
            BarrioImplement oBarrioImplement = new BarrioImplement();
            oBarrioImplement.CargarCombo(this.pnl0CmbBarrios, "Seleccione Barrio");
        }

        private void CargarPnl1Condiciones()
        { 
            
            List<Item> lista = new List<Item>();

            lista.Add(new Item("Mayor o igual que", 0));
            lista.Add(new Item("Menor que", 1));
            lista.Add(new Item("Entre los valores", 2));
            pnl1CmbCondicion.DisplayMember = "Name";
            pnl1CmbCondicion.ValueMember = "Value";
            pnl1CmbCondicion.DataSource = lista;
        }

        private void CargarPnl1Estados()
        {
            EstadoSocioImplement oEstadoSocioImplement = new EstadoSocioImplement();
            oEstadoSocioImplement.CargarCombo(this.pnl1CmbEstado, "Seleccione Estado");
        }

        private void CargarPeriodos()
        {

            List<Item> listaMes = new List<Item>();

            listaMes.Add(new Item("01", 1));
            listaMes.Add(new Item("02", 2));
            listaMes.Add(new Item("03", 3));
            listaMes.Add(new Item("04", 4));
            listaMes.Add(new Item("05", 5));
            listaMes.Add(new Item("06", 6));
            listaMes.Add(new Item("07", 7));
            listaMes.Add(new Item("08", 8));
            listaMes.Add(new Item("09", 9));
            listaMes.Add(new Item("10", 10));
            listaMes.Add(new Item("11", 11));
            listaMes.Add(new Item("12", 12));

            pnl1IncluirCmbMesDesde.DisplayMember = "Name";
            pnl1IncluirCmbMesDesde.ValueMember = "Value";
            pnl1IncluirCmbMesDesde.DataSource = listaMes;

            pnl1ExcluirCmbMesDesde.DisplayMember = "Name";
            pnl1ExcluirCmbMesDesde.ValueMember = "Value";
            pnl1ExcluirCmbMesDesde.DataSource = listaMes;

            List<Item> listaAnio = new List<Item>();

            listaAnio.Add(new Item("2020", 0));
            listaAnio.Add(new Item("2019", 1));
            listaAnio.Add(new Item("2018", 2));
            listaAnio.Add(new Item("2017", 3));
            listaAnio.Add(new Item("2016", 4));
            listaAnio.Add(new Item("2015", 5));
            listaAnio.Add(new Item("2014", 6));
            listaAnio.Add(new Item("2013", 7));
            listaAnio.Add(new Item("2012", 8));
            listaAnio.Add(new Item("2011", 9));
            listaAnio.Add(new Item("2010", 10));
            listaAnio.Add(new Item("2009", 11));

            pnl1IncluirCmbAnioDesde.DisplayMember = "Name";
            pnl1IncluirCmbAnioDesde.ValueMember = "Value";
            pnl1IncluirCmbAnioDesde.DataSource = listaMes;

            pnl1ExcluirCmbAnioDesde.DisplayMember = "Name";
            pnl1ExcluirCmbAnioDesde.ValueMember = "Value";
            pnl1ExcluirCmbAnioDesde.DataSource = listaMes;

        }

        #endregion

  

       

       

        

       

       

   
      
       

      
    }
}
