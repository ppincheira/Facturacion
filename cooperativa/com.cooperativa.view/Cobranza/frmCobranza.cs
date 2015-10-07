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
using System.Collections;

namespace com.cooperativa.view.Cobranza
{
    public partial class frmCobranza : Form
    {
        #region <<PROPIEDADES>>

        DateTime _cargandoCajaDia;
        bool _fechaCobroDistinta;
        int _idFactura;
        int _idSocio;
        int _facturaCobrada;
        bool _existeCobranza = false;

        #endregion

        #region <<EVENTOS>>

        public frmCobranza()
        {
            InitializeComponent();
        }

        private void frmCobranza_Load(object sender, EventArgs e)
        {
            dtpFechaCaja.Text = DateTime.Today.ToShortDateString();
            _cargandoCajaDia = DateTime.Today;
            CargarCajasActivas();
        }

        private void cmbCaja_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarCaja();
            if (_existeCobranza)
            {
                //muestro ventana para cambiar caja
                frmCambiarCaja frm = new frmCambiarCaja(_idFactura);
                frm.ShowDialog();

            }
        }

        private void txtNroFactura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CargarDatos();
                cmbCaja.Focus();
            }
        }


        private void txtNroFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            Commons oCommons = new Commons();

            oCommons.ValidarNumeroEntero(sender, e);
        }

        private void cmbCaja_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                dtpFechaCaja.Focus();
                if (dtpFechaCaja.Value != DateTime.Today)
                {
                    if (_existeCobranza)
                    {
                        //muestro ventana para cambiar caja
                        frmCambiarCaja frm = new frmCambiarCaja(_idFactura);
                        frm.ShowDialog();

                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("La fecha de caja no es la del día de hoy, desea continuar cargando la caja del día " +
                        dtpFechaCaja.Text, "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (result.Equals(DialogResult.OK))
                        {
                            _cargandoCajaDia = dtpFechaCaja.Value;
                        }
                        else
                        {
                            _cargandoCajaDia = DateTime.Today;
                            dtpFechaCaja.Value = _cargandoCajaDia;
                        }
                    }
                }

            }
        }

        private void dtpFechaCaja_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FacturasImplement oFacturasImplement = new FacturasImplement();
                if (oFacturasImplement.ExisteFactura(_idFactura))
                {
                    if (dtpFechaCobro.Visible && dtpFechaCobro.Enabled)
                    {
                        dtpFechaCobro.Focus();
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Se completará el proceso de cobranza", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (result.Equals(DialogResult.OK))
                        {
                            GuardarCobranza();
                            LimpiarCampos();
                        }
                        else
                        {
                            //nada
                        }
                    }
                }
            }
        }

        private void dtpFechaCobro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FacturasImplement oFacturasImplement = new FacturasImplement();
                if (oFacturasImplement.ExisteFactura(_idFactura))
                {
                    DialogResult result = MessageBox.Show("Se completará el proceso de cobranza", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result.Equals(DialogResult.OK))
                    {
                        GuardarCobranza();
                        LimpiarCampos();
                    }
                    else
                    {
                        //nada
                    }
                }
            }
        }

        private void dtpFechaCaja_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaCaja.Value != DateTime.Today) 
            {
                DialogResult result = MessageBox.Show("La fecha de caja no es la del día de hoy, desea continuar cargando la caja del día " +
                dtpFechaCaja.Text, "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    _cargandoCajaDia = dtpFechaCaja.Value;
                }
                else
                {
                    _cargandoCajaDia = DateTime.Today;
                    dtpFechaCaja.Value = _cargandoCajaDia;
                }
            }
        }

        #endregion

        #region <<METODOS>>

        private void CargarCajasActivas()
        {
            CajasImplement oCajasImplement = new CajasImplement();
            IList ListaCajas = oCajasImplement.GetAllActivas();
            cod_cajas oCaja = new cod_cajas();
            cmbCaja.DisplayMember = "id_caja";
            cmbCaja.ValueMember = "id_caja";
            cmbCaja.DataSource = ListaCajas;

            MostrarCaja();
        }

        private void MostrarCaja()
        {
            CajasImplement oCajasImplement = new CajasImplement();
            txtNombreCaja.Text = oCajasImplement.Get(int.Parse(cmbCaja.SelectedValue.ToString())).caja;
            _fechaCobroDistinta = (bool)oCajasImplement.Get(int.Parse(cmbCaja.SelectedValue.ToString())).fecha_cobro_distinta;

            if (_fechaCobroDistinta)
            {
                lblFechaCobro.Visible = true;
                dtpFechaCobro.Visible = true;
                dtpFechaCobro.Enabled = true;
            }
            else {
                lblFechaCobro.Visible = false;
                dtpFechaCobro.Visible = false;
                dtpFechaCobro.Enabled = false;
            }

        }

        private void CargarDatos()
        {
            if (txtNroFactura.Text.Length > 0) { 
            
                facturas oFacturas = new facturas();
                socios oSocio = new socios();
                SocioImplement oSocioImplement = new SocioImplement();
                FacturasImplement oFacturasImplement = new FacturasImplement();
                PeriodosImplement oPeriodosImplement = new PeriodosImplement();
                FacturasDetallesImplement oFacturasDetallesImplement = new FacturasDetallesImplement();
                _idFactura = int.Parse(txtNroFactura.Text);
                if (oFacturasImplement.ExisteFactura(_idFactura))
                {
                    oFacturas = oFacturasImplement.Get(int.Parse(txtNroFactura.Text));
                    oSocio = oSocioImplement.Get((int)oFacturas.id_socio);
                    _idSocio = oSocio.id_socio;
                    txtCodigoSubCodSocio.Text = oSocio.codigo_socio + "/" + oSocio.subcodigo_socio;
                    txtNombreSocio.Text = oSocio.nombre;
                    txtVencimiento.Text = ((DateTime)oPeriodosImplement.Get(oFacturas.id_periodo).fecha_primer_venc).ToShortDateString();
                    //facturado = neto + iva
                    DataTable detallesFacturaDT = oFacturasImplement.GetByIdFacturaDT(oFacturas.id_factura);
                    decimal _totalFacturado = 0;
                    decimal _importeTotal = 0;
                    decimal _convenio = 0;
                    decimal _acciones = 0;
                    foreach (DataRow dr in detallesFacturaDT.Rows)
                    {
                        //IVA = decimal.Parse(dr["IVA"].ToString());
                        _totalFacturado = _totalFacturado + decimal.Parse(dr["Neto"].ToString()) + decimal.Parse(dr["IVA"].ToString());
                        _importeTotal = _importeTotal + decimal.Parse(dr["Total"].ToString());
                        _convenio = _convenio + decimal.Parse(dr["Convenio"].ToString());
                        _acciones = _acciones + decimal.Parse(dr["Acciones"].ToString());
                    }

                    txtFacturado.Text = _totalFacturado.ToString();
                    txtCobrado.Text = oFacturas.cobrado.ToString();
                    txtResto.Text = (_totalFacturado - (decimal.Parse(oFacturas.cobrado.ToString()))).ToString();
                    txtDescuento.Text = "0";
                    CalculosFactura oCalculosFacturas = new CalculosFactura();
                    txtRecargo.Text = (oCalculosFacturas.CalcularRecargo(oFacturas.id_factura) + oCalculosFacturas.CalcularIVARecargo(oFacturas.id_factura)).ToString();
                    txtTotal.Text = (_importeTotal - (decimal)oFacturas.cobrado - decimal.Parse(txtDescuento.Text)).ToString();
                    txtConvenio.Text = _convenio.ToString();
                    txtAcciones.Text = _acciones.ToString();


                    CobranzasImplement oCobranzasImplement = new CobranzasImplement();

                    txtFactIngresadas.Text = oCobranzasImplement.GetFacturas(dtpFechaCaja.Value).ToString();

                    txtTotalCobrado.Text = _importeTotal.ToString();
                    txtTotalFactura.Text = _importeTotal.ToString(); ;
                    txtDiferencia.Text = (decimal.Parse(txtTotalFactura.Text) - decimal.Parse(txtTotalCobrado.Text)).ToString();
                }
                else { 
                    //si esta con cobranza entonces seria para cambiar la caja
                    if (oFacturasImplement.ExisteCobranza(_idFactura))
                    {
                        _existeCobranza = true;
                    }
                    else
                    {
                        _existeCobranza = false;
                    }
                }
            }
        }

        private void GuardarCobranza()
        {
            facturas oFacturas = new facturas();
            socios oSocio = new socios();
            SocioImplement oSocioImplement = new SocioImplement();
            FacturasImplement oFacturasImplement = new FacturasImplement();
            PeriodosImplement oPeriodosImplement = new PeriodosImplement();
            FacturasDetallesImplement oFacturasDetallesImplement = new FacturasDetallesImplement();

            oFacturas = oFacturasImplement.Get(int.Parse(txtNroFactura.Text));
            oFacturas.id_estadoPago = 3;
            oFacturasImplement.Update(oFacturas);

            cobranzas oCobranza = new cobranzas();
            oCobranza.id_caja = int.Parse(cmbCaja.SelectedValue.ToString());
            oCobranza.id_factura = _idFactura;
            oCobranza.id_recibo = 0;
            oCobranza.id_socio = _idSocio;
            oCobranza.importe = decimal.Parse(txtTotalCobrado.Text);
            oCobranza.descuento_convenio = 0;
            oCobranza.iva_descuento_convenio = 0;
            oCobranza.fecha_cobro = dtpFechaCaja.Value;
            oCobranza.id_terminal = 0;//VER
            oCobranza.fecha_registro = DateTime.Now;
            CobranzasImplement oCobranzasImplement = new CobranzasImplement();
            oCobranzasImplement.Save(oCobranza);
        }

        private void LimpiarCampos()
        {
            _idFactura = 0;
            _idSocio = 0;
            txtCodigoSubCodSocio.Text ="";
            txtNombreSocio.Text = "";
            txtVencimiento.Text = "";

            txtFacturado.Text = "";
            txtCobrado.Text = "";
            txtResto.Text = "";
            txtDescuento.Text = "";
            txtRecargo.Text = "";
            txtTotal.Text = ""; ;
            txtConvenio.Text = "";
            txtAcciones.Text = "";

            txtFactIngresadas.Text = "";

            txtTotalCobrado.Text = "";
            txtTotalFactura.Text = ""; ;
            txtDiferencia.Text = "";
        }

        #endregion

       
    }
}
