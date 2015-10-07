using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using com.cooperativa.implement;
using System.Collections;
using com.cooperativa.implement.dao;
using com.cooperativa.implement.calculos;

namespace com.cooperativa.view.Facturacion
{
    public partial class frmReFacturar : Form
    {
        #region << PROPIEDADES >>

        int _idFactura;
        int _idSocio;
        string _periodo;
        DataTable _TablaGrilla;
        #endregion
        #region << EVENTOS >>
        facturas _oFactura;
        public frmReFacturar()
        {
            InitializeComponent();
        }

        private void frmReFacturar_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirBuscador();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message);

            }
        }

        private void btnRefacturar_Click(object sender, EventArgs e)
        {
            CargarFacturas();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Refacturar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.pDetalles.Visible = false;
        }

        private void dgFacturar_SelectionChanged(object sender, EventArgs e)
        {
            if (((System.Windows.Forms.BaseCollection)(this.dgFacturar.SelectedRows)).Count > 0)
                        _idFactura = int.Parse(this.dgFacturar.Rows[this.dgFacturar.SelectedRows[0].Index].Cells[1].Value.ToString());
        }

        #endregion


        #region << GRILLA REFACTURAR >>

        DataColumn id_detalle;
        DataColumn id_concepto;
        DataColumn id_factura;
        DataColumn id_Orden;
        DataColumn id_Tipo;
        DataColumn concepto;
        DataColumn importe;
        DataColumn importeTotal;

        private void InicializarGrilla()
        {
            facturas_detalles oDetalle = new facturas_detalles();
            _TablaGrilla = new DataTable("TablaGrilla");
            id_detalle = new DataColumn("id_detalle", System.Type.GetType("System.Int32"));
            id_concepto = new DataColumn("id_concepto", System.Type.GetType("System.Int32"));
            id_factura = new DataColumn("id_factura", System.Type.GetType("System.Int32"));
            id_Orden = new DataColumn("id_Orden", System.Type.GetType("System.Int32"));
            id_Tipo = new DataColumn("id_Tipo", System.Type.GetType("System.Int32"));
            concepto = new DataColumn("concepto", System.Type.GetType("System.String"));
            importe = new DataColumn("importe", System.Type.GetType("System.Double"));
            
            _TablaGrilla.Columns.Add(id_detalle);
            _TablaGrilla.Columns.Add(id_concepto);
            _TablaGrilla.Columns.Add(id_factura);
            _TablaGrilla.Columns.Add(id_Orden);
            _TablaGrilla.Columns.Add(id_Tipo);
            _TablaGrilla.Columns.Add(concepto);
            _TablaGrilla.Columns.Add(importe);
       
        }


        public void AgregarDetalle(facturas_detalles oFacturaDetalle)
        {
            cod_conceptos oConcepto = new cod_conceptos();
            ConceptoImplement oConceptoImpl = new ConceptoImplement();
            oConcepto = oConceptoImpl.Get(oFacturaDetalle.id_concepto.Value);
            DataRow registro = _TablaGrilla.NewRow();
            registro["id_detalle"] = oFacturaDetalle.id_detalle;
            registro["id_concepto"] = oFacturaDetalle.id_concepto;
            registro["id_factura"] = oFacturaDetalle.id_factura;
            registro["id_orden"] = oFacturaDetalle.idOrden;
            registro["id_Tipo"] = oFacturaDetalle.idTipo;
            registro["concepto"] = oConcepto.concepto;
            registro["importe"] = Math.Round(oFacturaDetalle.importe, 2); 
            _TablaGrilla.Rows.Add(registro);
            this.dgDetalleFut.DataSource = _TablaGrilla;
        }
        /*
         *  
         * this.grdFacturacionServicio.DataSource = _TablaGrilla;
            this.grdFacturacionServicio.DataBind();
            this.ddlServicio.SelectedValue = "0";
         * 
         * 
         */

        #endregion

        #region << METODOS >>

        private void AbrirBuscador()
        {
            Buscadores.frmBuscarSocio f = new Buscadores.frmBuscarSocio();
            f.Text = "Facturas Seleccion";
            if (f.ShowDialog() == DialogResult.OK)
            {
                _idSocio=int.Parse(f.ValorRetorno);
                ObtenerFacturasSocio();
            }
        }

        private void Inicializar() {
            this.pDetalles.Visible = false;
            this.gbRefacturar.Visible = false;
            InicializarGrilla();
        }

        private void ObtenerFacturasSocio() {
            socios oSocio = new socios();
            SocioImplement oSocioImplement = new SocioImplement();
            oSocio = oSocioImplement.Get(_idSocio);
            this.mtxtNumero.Text = oSocio.codigo_socio + oSocio.subcodigo_socio;
            this.txtNombre.Text = oSocio.nombre;
            FacturasImplement oFacturaImplement = new FacturasImplement();
            this.dgFacturar.DataSource = oFacturaImplement.GetByIdSocio(_idSocio);
        
        }

        private void CargarFacturas() {
            this.pDetalles.Visible = true;
            this.gbRefacturar.Visible = true;
            facturas oFactura = new facturas();
            FacturasImplement oFacturaImplement = new FacturasImplement();
            socios oSocio=new socios();
            SocioImplement oSocioImplement = new SocioImplement();
            oSocio = oSocioImplement.Get(_idSocio);
            tarifas oTarifa=new tarifas();
            TarifaImplement oTarifaImplement=new TarifaImplement();
            cod_impuestos oCodImpuesto = new cod_impuestos();
            ImpuestoImplement oImpuestoImplement = new ImpuestoImplement();
            oCodImpuesto = oImpuestoImplement.Get(oSocio.iva.Value);
            oFactura = oFacturaImplement.Get(_idFactura);
            oTarifa=oTarifaImplement.Get(oSocio.tarifa.Value);
            this.txtNroFacturaAct.Text = oFactura.id_factura.ToString();
            _periodo = oFactura.id_factura.ToString();
            this.txtFechaAct.Text = oFactura.id_periodo.ToString();
            CargarFactura(_idFactura);
            this.txtTotalAct.Text = sumarFilas(ref this.dgDetalleAct,"colAImporte").ToString();
            CargarFacturaFutura(_periodo,_idSocio);
            this.txtTotalFut.Text = sumarFilas(ref this.dgDetalleFut,"colFImporte").ToString();
        }


        private decimal sumarFilas(ref DataGridView gridView, string columna) {
            decimal sumatoria = 0;
            //Método con el que recorreremos todas las filas de nuestro Datagridview
            foreach (DataGridViewRow row in gridView.Rows)
            {
            //Aquí seleccionaremos la columna que contiene los datos numericos.
                sumatoria += Convert.ToDecimal(row.Cells[columna].Value);
            }
            //Por ultimo asignamos el resultado a el texto de nuestro Label
            return sumatoria;
        }
        private void CargarFactura(int idFactura) {
            CalculosFactura oCalculoFactura = new CalculosFactura();
            this.dgDetalleAct.DataSource = oCalculoFactura.GetFacturasDetalles(idFactura);
            

        }

        private void CargarFacturaFutura(string periodo, int idSocio)
        {
            decimal NetoConIVA = 0;
            decimal NetoSinIVA = 0;
            int idMedidor = 0;
            facturas oFactura = new facturas();
            FacturasImplement oFacturaImplement = new FacturasImplement();
            oFactura = oFacturaImplement.Get(_idFactura);
            _oFactura = new facturas();
            _oFactura.id_socio = _idSocio;
            //oFactura.id_medicion Ver como soluciono el idMedicion
            _oFactura.id_estadoPago = 1;//Impaga
            _oFactura.id_tarifa = 0;//aun no se carga
            _oFactura.id_convenio = 0;//Aun no se carga
            _oFactura.fechaPago = null;
            _oFactura.cobrado = 0;
            _oFactura.neto1 = 0;
            _oFactura.neto2 = 0;
            _oFactura.importeNeto = 0;
            _oFactura.importeTotal = 0;
            _oFactura.id_medicion = 0;

            // obtengo solo los conceptos activos
            IList listaConceptos = new ConceptoImplement().GetActivosAll();
            SocioConexionImplement oSocioConexionImpl = new SocioConexionImplement();
            DataTable DTUsuariosAFacturar = oSocioConexionImpl.GetSociosAFacturar(periodo, idSocio);
            if (DTUsuariosAFacturar.Rows[0]["medidor"].ToString() != "")
            {
                socios_mediciones oSocioMedicionActual = new socios_mediciones();
                SocioMedicionImplement oSocioMedicionImplement = new SocioMedicionImplement();
                oSocioMedicionActual = oSocioMedicionImplement.ultimaMedicion(int.Parse(DTUsuariosAFacturar.Rows[0]["id_socio"].ToString()));
                socios_mediciones oSocioMedicionNew = new socios_mediciones();
                oSocioMedicionNew.fecha_lectura = null;
                oSocioMedicionNew.id_socio = _idSocio;
                decimal consumo = 0;
                if (oSocioMedicionActual != null)
                {
                    consumo = (decimal)decimal.Parse((oSocioMedicionActual.consumo * 0.75).ToString());
                    oSocioMedicionNew.consumo = (int)Math.Truncate(consumo);
                    oSocioMedicionNew.lectura = oSocioMedicionActual.lectura + oSocioMedicionNew.consumo;
                }
                else
                {
                    oSocioMedicionNew.consumo = 0;
                    oSocioMedicionNew.lectura = 0;
                }
                idMedidor = oSocioMedicionImplement.Save(oSocioMedicionNew);
            }

            _oFactura.id_medicion = idMedidor;//Cargo 0 si no tiene medidor
            // recorre toda la base de conceptos

            foreach (cod_conceptos oConcepto in listaConceptos)
            {
                bool CorrespondeFacturar = false;

                if (_oFactura.id_medicion.Value != 0)
                {
                    //SocioMedicionImplement oSosioMedicionImpl = new SocioMedicionImplement();
                    //socios_mediciones oSocioMedicion = new socios_mediciones();
                    //oSocioMedicion = oSosioMedicionImpl.Get(oFactura.id_medicion.Value);
                }
                acciones oAccion = new acciones();
                conceptos_particulares oConceptoParticular = new conceptos_particulares();
                conceptosParticularesImplement oConceptoParticularImplement = new conceptosParticularesImplement();
                AccionImplement oAccionesImplement = new AccionImplement();

                if (oConcepto.aplicacion == 2)
                { // si concepto Particular

                    oConceptoParticular = oConceptoParticularImplement.GetByFilter(idSocio, oConcepto.id_concepto, _oFactura.id_periodo);
                    if (oConceptoParticular != null)
                    {
                        CorrespondeFacturar = true;
                    }
                    else
                    {
                        // No encontrado entonces no corresponde facturar
                        CorrespondeFacturar = false;
                    }
                }
                else
                {
                    //Concepto Activo y no particular entonces corresponde facturar
                    CorrespondeFacturar = true;
                }

                if (CorrespondeFacturar)
                {

                    facturas_detalles oDetalle = new facturas_detalles();
                    FacturasDetallesImplement oFacturasDetallesImplement = new FacturasDetallesImplement();
                    //ConvenioImplement oConvenioImplement = new ConvenioImplement();
                    CalculosFacturacionFormulas oCalculosFacturacionFormulas = new CalculosFacturacionFormulas();
                    oDetalle = oCalculosFacturacionFormulas.getDetalle(idSocio, decimal.Parse(DTUsuariosAFacturar.Rows[0]["cargo_fijo"].ToString()), decimal.Parse(DTUsuariosAFacturar.Rows[0]["abono"].ToString()), decimal.Parse(DTUsuariosAFacturar.Rows[0]["valor_m3"].ToString()), oConcepto, _oFactura, oConceptoParticular);
                    if (oDetalle.importe != 0)
                        AgregarDetalle(oDetalle);
                    // Calcula los subtotales separados para los conceptos con y sin IVA
                    if (oConcepto.aplicar_iva.Value)
                        NetoConIVA = NetoConIVA + oDetalle.importe;
                    else NetoSinIVA = NetoSinIVA + oDetalle.importe;
                    // Calcula los campos Neto1 y Neto2 utilizados en los
                    // cálculos de intereses
                    if (oConcepto.aplicar_recargo.Value)
                        oFactura.neto1 = oFactura.neto1.Value + Convert.ToSingle(oDetalle.importe);
                    else
                        oFactura.neto2 = oFactura.neto2.Value + Convert.ToSingle(oDetalle.importe);
                }
            }
            cod_conceptos oConceptoIVA = new cod_conceptos();
            ConceptoImplement oConceptoImplement = new ConceptoImplement();
            facturas_detalles oDetalleFac = new facturas_detalles();
            oConceptoIVA = oConceptoImplement.Get(23);//concepto IVA es el 23
            oDetalleFac.id_concepto = oConceptoIVA.id_concepto;
            oDetalleFac.id_factura = 0;
            oDetalleFac.idOrden = oConceptoIVA.orden_concepto;
            oDetalleFac.idTipo = 0;
            oDetalleFac.importe = decimal.Round(NetoConIVA * decimal.Parse(DTUsuariosAFacturar.Rows[0]["iva"].ToString()) / 100, 2);
            AgregarDetalle(oDetalleFac);
        }

        private void Refacturar() {
            facturas oFactura = new facturas();
            FacturasImplement oFacImplement = new FacturasImplement();
            oFactura = oFacImplement.Get(_idFactura);
            facturas oFacturaNew = new facturas();
            FacturasImplement oFacImplementNew = new FacturasImplement();
           // oFacturaNew.
            foreach (DataRow row in _TablaGrilla.Rows){

                //registro["id_detalle"] = oFacturaDetalle.id_detalle;
                //registro["id_concepto"] = oFacturaDetalle.id_concepto;
                //registro["id_factura"] = oFacturaDetalle.id_factura;
                //registro["id_orden"] = oFacturaDetalle.idOrden;
                //registro["id_Tipo"] = oFacturaDetalle.idTipo;
                //registro["concepto"] = oConcepto.concepto;
                //registro["importe"] = Math.Round(oFacturaDetalle.importe, 2); 
                
            }
        }
        private void Refacturar1()
        {
            decimal NetoConIVA = 0;
            decimal NetoSinIVA = 0;
            decimal SubTotal = 0;
            SocioConexionImplement oSocioConexionImplement = new SocioConexionImplement();
            DataTable DTMedidores = oSocioConexionImplement.GetEstadosMedidores();
            IList listaConceptos = new ConceptoImplement().GetActivosAll();
            DataTable DTUsuariosAFacturar = oSocioConexionImplement.GetSociosAFacturar(_periodo, _idSocio);
            _oFactura = new facturas();
            _oFactura.id_socio = _idSocio;
            //oFactura.id_medicion Ver como soluciono el idMedicion
            _oFactura.id_estadoPago = 1;//Impaga
            _oFactura.id_tarifa = 0;//aun no se carga
            _oFactura.id_convenio = 0;//Aun no se carga
            _oFactura.fechaPago = null;
            _oFactura.cobrado = 0;
            _oFactura.neto1 = 0;
            _oFactura.neto2 = 0;
            _oFactura.importeNeto = 0;
            _oFactura.importeTotal = 0;
            _oFactura.id_medicion = 0;
            if (DTUsuariosAFacturar.Rows[0]["medidor"].ToString() != "")
            {
                //preguntar como hago con la medicion?
                //socios_mediciones oSocioMedicionActual = new socios_mediciones();
                //SocioMedicionImplement oSocioMedicionImplement = new SocioMedicionImplement();
                //oSocioMedicionActual = oSocioMedicionImplement.ultimaMedicion(_idSocio);
                //socios_mediciones oSocioMedicionNew = new socios_mediciones();
                //oSocioMedicionNew.fecha_lectura = null;
                //oSocioMedicionNew.id_socio =_idSocio;
                NetoConIVA = 0;
                NetoSinIVA = 0;
                foreach (cod_conceptos oConcepto in listaConceptos)
                {
                    bool CorrespondeFacturar = false;
                    if (DTUsuariosAFacturar.Rows[0]["medidor"].ToString() != "")
                    {
                        //SocioMedicionImplement oSosioMedicionImpl = new SocioMedicionImplement();
                        //socios_mediciones oSocioMedicion = new socios_mediciones();
                        //oSocioMedicion = oSosioMedicionImpl.Get(oFactura.id_medicion.Value);
                    }
                    acciones oAccion = new acciones();
                    conceptos_particulares oConceptoParticular = new conceptos_particulares();
                    conceptosParticularesImplement oConceptoParticularImplement = new conceptosParticularesImplement();
                    AccionImplement oAccionesImplement = new AccionImplement();

                    if (oConcepto.aplicacion == 2)
                    { // si concepto Particular
                        oConceptoParticular = oConceptoParticularImplement.GetByFilter(_idSocio, oConcepto.id_concepto, _periodo);
                        if (oConceptoParticular != null)
                        {
                            CorrespondeFacturar = true;
                        }
                        else
                        {
                            // No encontrado entonces no corresponde facturar
                            CorrespondeFacturar = false;
                        }
                    }
                    else
                    {
                        //Concepto Activo y no particular entonces corresponde facturar
                        CorrespondeFacturar = true;
                    }

                    if (CorrespondeFacturar)
                    {
                        facturas_detalles oDetalle = new facturas_detalles();
                        FacturasDetallesImplement oFacturasDetallesImplement = new FacturasDetallesImplement();
                        //ConvenioImplement oConvenioImplement = new ConvenioImplement();
                        CalculosFacturacionFormulas oCalculosFacturacionFormulas = new CalculosFacturacionFormulas();
                        oDetalle = oCalculosFacturacionFormulas.getDetalle(_idSocio, decimal.Parse(DTUsuariosAFacturar.Rows[0]["cargo_fijo"].ToString()), decimal.Parse(DTUsuariosAFacturar.Rows[0]["abono"].ToString()), decimal.Parse(DTUsuariosAFacturar.Rows[0]["valor_m3"].ToString()), oConcepto, _oFactura, oConceptoParticular);
                        if (oDetalle.importe != 0)

                            AgregarDetalle(oDetalle);
                      
                        // Calcula los subtotales separados para los conceptos con y sin IVA
                        if (oConcepto.aplicar_iva.Value)
                            NetoConIVA = NetoConIVA + oDetalle.importe;
                        else NetoSinIVA = NetoSinIVA + oDetalle.importe;
                        // Calcula los campos Neto1 y Neto2 utilizados en los
                        // cálculos de intereses
                        if (oConcepto.aplicar_recargo.Value)
                            _oFactura.neto1 = _oFactura.neto1.Value + Convert.ToSingle(oDetalle.importe);
                        else
                            _oFactura.neto2 = _oFactura.neto2.Value + Convert.ToSingle(oDetalle.importe);


                    }
                }

                // Obtiene el subtotal general como suma de los
                // subtotales parciales con y sin IVA
                SubTotal = NetoConIVA + NetoSinIVA;
                // Redondea el subtotal a dos dígitos
                SubTotal = decimal.Round(SubTotal, 2);
                // Registra el subtotal general
                _oFactura.importeNeto = Convert.ToSingle(SubTotal);
                // Calcula IVA (sólo para los conceptos que corresponde)
                facturas_detalles oFacDetalle = new facturas_detalles();
                FacturasDetallesImplement oFacDetalleImplement = new FacturasDetallesImplement();

                cod_conceptos oConceptoIVA = new cod_conceptos();
                ConceptoImplement oConceptoImplement = new ConceptoImplement();

                oConceptoIVA = oConceptoImplement.Get(23);//concepto IVA es el 23
                oFacDetalle.id_concepto = oConceptoIVA.id_concepto;
                oFacDetalle.id_factura = 0;
                oFacDetalle.idOrden = oConceptoIVA.orden_concepto;
                oFacDetalle.idTipo = 0;
                oFacDetalle.importe = decimal.Round(NetoConIVA * decimal.Parse(DTUsuariosAFacturar.Rows[0]["iva"].ToString()) / 100, 2);
                AgregarDetalle(oFacDetalle);
                
                // Calcula Total
                _oFactura.importeTotal = _oFactura.importeNeto.Value + Convert.ToSingle(oFacDetalle.importe); //este ahi que ver el tipo de dato
                
                //// Generar entradas en la base de CuentasCorrientes
                //CuentaCorrienteImplement oCuentaCorrienteImplement = new CuentaCorrienteImplement();
                //cuentas_corrientes oCuentaCorriente = new cuentas_corrientes();

                //oCuentaCorriente.fecha = DateTime.Now;
                //oCuentaCorriente.id_factura = _idFactura;
                //oCuentaCorriente.id_movimiento = 1;
                //oCuentaCorriente.id_socio = _idSocio;
                //oCuentaCorriente.importe_credito = 0;
                //oCuentaCorriente.importe_saldo = 0;
                //oCuentaCorriente.importe_debito = Convert.ToDecimal(oFactura.importeTotal);
                //oCuentaCorriente.id_cobranza = 0;
                //oCuentaCorrienteImplement.Save(oCuentaCorriente);


            }
        }

        #endregion

     




    }
}
