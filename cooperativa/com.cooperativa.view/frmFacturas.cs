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
using System.Threading;

namespace com.cooperativa.view
{
    public partial class frmFacturas : Form
    {
        #region << PROPIEDADES >>
        int _idSocio;
        int _idAccion;
        int _idFactura;
        int _mostrarImpagas;
        int _mostrarValoresActualizados;

        DataTable _facturasNoAct;
        DataTable _facturasAct;
        DataTable _facturasNoActImp;
        DataTable _facturasActImp;
        int valor;
   
        #endregion

        #region << EVENTOS >>
        public frmFacturas(int idSocio)
        {
            InitializeComponent();
            _idSocio = idSocio;
        }
         
        private void frmFacturas_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void dgvFacturas_SelectionChanged(object sender, EventArgs e  )                   
        {
            CargarSeleccionFactura();
        }

        private void btnDetalleConceptos_Click(object sender, EventArgs e)
        {
            frmDetalleFactura f = new frmDetalleFactura("admin", _idFactura);
            f.Text = "Observaciones";
            f.Show();
        }

        private void chkMostrarImpagas_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarImpagas.Checked)
            {
                _mostrarImpagas = 1;
                
            }
            else
            {
                _mostrarImpagas = 0;
               
            }
            valor = 1;
            CargarGrilla();
        }

        private void chkValoresAct_CheckedChanged(object sender, EventArgs e)
        {

            if (chkValoresAct.Checked)
            {
                _mostrarValoresActualizados = 1;
              
            }
            else
            {
                _mostrarValoresActualizados = 0;
              
            }
            valor = 2;
            CargarTotales();
            CargarGrilla();
        }

        private void btnGenerarInforme_Click(object sender, EventArgs e)
        {
            Imprimir();
        }


        #endregion

        #region << METODOS >>

        private void Inicializar()
        {
            socios oSocio = new socios();
            SocioImplement oSocioImplement = new SocioImplement();
            SocioConexionImplement oSocioConexionImplement = new SocioConexionImplement();
            oSocio = oSocioImplement.Get(_idSocio);
            this.txtCodigo.Text = oSocio.codigo_socio;
            this.txtSubCodigo.Text = oSocio.subcodigo_socio;
            this.txtNombre.Text = oSocio.nombre;
            _mostrarImpagas = 0;
            _mostrarValoresActualizados = 0;
            CargarGrilla();
            CargarTotales();
            Thread t = new Thread(new ThreadStart(InicializarTablaExt));
            t.Start();
            //InicializarTablaExt();
            
        }

        private void CargarTotales()
        {
            FacturasImplement oFacturasImplement = new FacturasImplement();
            txtFactListadas.Text = this.dgvFacturas.Rows.Count.ToString();//oFacturasImplement.GetCountFacturasBySocio(_idSocio, _mostrarImpagas).ToString();
            //txtTotal.Text = Math.Round((decimal)oFacturasImplement.GetTotalFacturasBySocio(_idSocio, _mostrarImpagas),2).ToString();
            //txtRecargo.Text = Math.Round((decimal)oFacturasImplement.GetTotalRecargoBySocio(_idSocio, _mostrarImpagas), 2).ToString();
        }

        private void InicializarTablaExt()
        {
            FacturasImplement oFacturasImplement = new FacturasImplement();
            _facturasAct = oFacturasImplement.GetByIdSocioDT(_idSocio, 0, 1);
            _facturasNoActImp = oFacturasImplement.GetByIdSocioDT(_idSocio, 1, 0);
            _facturasActImp = oFacturasImplement.GetByIdSocioDT(_idSocio, 1, 1);
        }

        private void CargarGrilla()
        {
            FacturasImplement oFacturasImplement = new FacturasImplement();
            DataTable dtFacturas = new DataTable();
            
            if (_mostrarValoresActualizados == 0)
            {
                if (_mostrarImpagas == 0)
                {
                    if (_facturasNoAct == null)
                        _facturasNoAct = oFacturasImplement.GetByIdSocioDT(_idSocio, _mostrarImpagas, _mostrarValoresActualizados);
                   dtFacturas = _facturasNoAct;
                }
                else {
                    dtFacturas = _facturasNoActImp;
                }
                
            }
            else {
                if (_mostrarImpagas == 0)
                {
                    dtFacturas = _facturasAct;
                }
                else {
                    dtFacturas = _facturasActImp;
                }
            }

            if (dtFacturas == null)
            {
                MessageBox.Show("Se estan calculando los datos... espere");
                if (valor == 1)//se clickeo imp
                {
                    chkMostrarImpagas.Checked = !chkMostrarImpagas.Checked;
                }
                else {
                    chkValoresAct.Checked = !chkValoresAct.Checked;
                }
            }
            else
            {
                /*if (_mostrarValoresActualizados == 1)
                {*/
                Decimal valorTotal = 0;
                Decimal valorRecargo = 0;
                foreach (DataRow dr in dtFacturas.Rows)
                {
                    #region <Control Valores Vacios>
                    decimal Neto = 0;
                    decimal IVA = 0;
                    decimal Cobrado = 0;
                    decimal Recargo = 0;
                    decimal IVARecargo = 0;
                    if (dr["Neto"] == null | dr["Neto"].ToString() == "")
                        Neto = 0;
                    else
                        Neto = decimal.Parse(dr["Neto"].ToString());
                    if (dr["IVA"] == null | dr["IVA"].ToString() == "")
                        IVA = 0;
                    else
                        IVA = decimal.Parse(dr["IVA"].ToString());
                    if (dr["Cobrado"] == null | dr["Cobrado"].ToString() == "")
                        Cobrado = 0;
                    else
                        Cobrado = decimal.Parse(dr["Cobrado"].ToString());
                    if (dr["Recargo"] == null | dr["Recargo"].ToString() == "")
                        Recargo = 0;
                    else
                        Recargo = decimal.Parse(dr["Recargo"].ToString());
                    if (dr["IVARecargo"] == null | dr["IVARecargo"].ToString() == "")
                        IVARecargo = 0;
                    else
                        IVARecargo = decimal.Parse(dr["IVARecargo"].ToString());
                    #endregion

                    valorTotal = valorTotal + (Neto + IVA - Cobrado)
                        + Recargo + IVARecargo;

                    valorRecargo = valorRecargo + Recargo;
                }
                txtTotal.Text = Math.Round(valorTotal, 2).ToString();
                txtRecargo.Text = Math.Round(valorRecargo, 2).ToString();
                /*}*/

                this.dgvFacturas.DataSource = dtFacturas;
            }
        }

        private void CargarSeleccionFactura()
        {
            facturas oFacturas = new facturas();
            FacturasImplement oFacturasImplement = new FacturasImplement();
            DataGridViewRow row = this.dgvFacturas.CurrentRow;
            if (row != null)
            {
                _idFactura = Convert.ToInt32(row.Cells[1].Value);
                this.dgvConceptos.DataSource = oFacturasImplement.GetConceptosByIdFactDT(_idFactura);
            }
        }

        private void Imprimir()
        {
            SysConfigImplement oSysConfigImplement = new SysConfigImplement();
            Reportes.frmReportes frmRpt = new Reportes.frmReportes();
            Reportes.rptFacturas rpt = new Reportes.rptFacturas();
            FacturasImplement oFacturasImplement = new FacturasImplement();
            //DataTable dtFacturas=new DataTable();
            //if(_mostrarImpagas ==0)
            //{
            //    if(_mostrarValoresActualizados==0)
            //    {
            //        dtFacturas=_facturasNoAct;
            //    }
            //    else
            //    {
            //        dtFacturas=_facturasAct;
            //    }
            //}
            //else
            //{
            //    if(_mostrarValoresActualizados==0)
            //    {
            //        dtFacturas=_facturasNoActImp;
            //    }
            //    else
            //    {
            //        dtFacturas=_facturasActImp;
            //    }
            //}
                

            DataTable dtFacturas = oFacturasImplement.GetByIdSocioDT(_idSocio, _mostrarImpagas, _mostrarValoresActualizados);
            decimal totalfacturado = 0;
            decimal totalrecargo = 0;
            decimal totalcobrado = 0;
            decimal totaldeuda = 0;
            foreach(DataRow dr in dtFacturas.Rows)
            {
                dr["Total"] = (decimal.Parse(dr["Recargo"].ToString()) + decimal.Parse(dr["IVARecargo"].ToString())) + (decimal.Parse(dr["Neto"].ToString()) + decimal.Parse(dr["IVA"].ToString())) - decimal.Parse(dr["Cobrado"].ToString());
                dr["Neto"] = (decimal.Parse(dr["Neto"].ToString()) + decimal.Parse(dr["IVA"].ToString()));
                dr["Recargo"] = (decimal.Parse(dr["Recargo"].ToString()) + decimal.Parse(dr["IVARecargo"].ToString()));
                
                totalfacturado = totalfacturado + (decimal.Parse(dr["Neto"].ToString()) + decimal.Parse(dr["IVA"].ToString()));
                totalrecargo = totalrecargo + (decimal.Parse(dr["Recargo"].ToString()) + decimal.Parse(dr["IVARecargo"].ToString()));
                totalcobrado = totalcobrado + decimal.Parse(dr["Cobrado"].ToString());
                totaldeuda = totaldeuda + decimal.Parse(dr["Total"].ToString());

            }

            socios oSocio = new socios();
            SocioImplement oSocioImplement = new SocioImplement();
            socios_lote oSocio_lote = new socios_lote();
            SocioLoteImplement oSocio_loteImplement = new SocioLoteImplement();
            tarifas oTarifas = new tarifas();
            TarifaImplement oTarifaImplement = new TarifaImplement();
            cod_barrios oCod_Barrios = new cod_barrios();
            BarrioImplement oBarrioImplement = new BarrioImplement();
            cod_calles oCod_Calles = new  cod_calles();
            CalleImplement oCalleImplement = new CalleImplement();
            oSocio = oSocioImplement.Get(_idSocio);
            oSocio_lote = oSocio_loteImplement.Get(_idSocio);
            string calleAltura = "";
            string manzana = "";
            string lote = "";
            string tarifa = "";
            string barrio = "";
            if(oSocio.tarifa>0)
                tarifa = oTarifaImplement.Get((int)oSocio.tarifa).tarifa;
            if (oSocio_lote != null)
            {
                if (oSocio_lote.barrio > 0)
                    barrio = oBarrioImplement.Get((int)oSocio_lote.barrio).barrio;
                if (oSocio_lote.calle_altura.Length > 0)
                    calleAltura = oSocio_lote.calle_altura;
                if (oSocio_lote.manzana.Length > 0)
                    manzana = oSocio_lote.manzana;
                if (oSocio_lote.lote.Length > 0)
                    lote = oSocio_lote.lote;
            }
            string calle = "";
            if (oSocio_lote.calle != null && oSocio_lote.calle>0)
                calle=oCalleImplement.Get((int)oSocio_lote.calle).calle;

            //Cargo el Data Set
          

            DataSet ds = new DataSet("Generico");
            ds.Tables.Add(oSysConfigImplement.GetEncabezadoDT("Encabezado"));
            ds.Tables[0].TableName = "dtEncabezado";
            ds.Tables.Add(dtFacturas);
            ds.Tables[1].TableName = "dtFacturas";
            rpt.SetDataSource(ds);
            rpt.SetParameterValue("socio", oSocio.codigo_socio + "/" + oSocio.subcodigo_socio + "  " + oSocio.nombre);
            rpt.SetParameterValue("tarifa", tarifa);
            rpt.SetParameterValue("barrio", barrio);
            rpt.SetParameterValue("calle", calle);
            rpt.SetParameterValue("numero", calleAltura);
            rpt.SetParameterValue("manzana", manzana);
            rpt.SetParameterValue("lote",lote);
            rpt.SetParameterValue("totalfacturado", Math.Round(totalfacturado, 2).ToString());
            rpt.SetParameterValue("totalrecargo", Math.Round(totalrecargo, 2).ToString());
            rpt.SetParameterValue("totalcobrado", Math.Round(totalcobrado, 2).ToString());
            rpt.SetParameterValue("totaldeuda", Math.Round(totaldeuda, 2).ToString());
            frmRpt.crvGenerico.ReportSource = rpt;
            frmRpt.Show();
        }

        #endregion
    }
}
