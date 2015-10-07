using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using com.cooperativa.implement.dao;
using com.cooperativa.implement;

namespace com.cooperativa.view
{
    public partial class frmConvenioNuevo : Form
    {
        #region << PROPIEDADES >>
        int _idSocio;
        List<int> _ListaFacturas = new List<int>();
        Decimal _FacturasNoCanceladas = 0;
        Decimal _ImporteFacturasSeleccionadasTotal = 0;
        Decimal _ImporteSinInteres = 0;
        Decimal _ImporteRecargos = 0;
        Decimal _ImporteDeuda = 0;
        int _CantidadCuotas = 0;
        int _CantidadCuotasCanceladas = 0;
        Decimal _ImporteCuota = 0;
        Decimal _CanonMunicipal = 0;
        Decimal _ConveniosNoCancelados = 0;
        Decimal _totalCobrado = 0;
        enum Cajas {ConvAbogado = 5, ConvRefinanciado = 7 , ConvMoratoria=4}
        bool _convenioMora = false;
        #endregion

        #region << EVENTOS >>

        public frmConvenioNuevo(int idSocio)
        {
            InitializeComponent();
            _idSocio = idSocio;
        }

        #region <<ConvenioNuevo>>
        private void frmConvenioNuevo_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            AbrirFacturasSeleccion();
        }

        private void btnNota_Click(object sender, EventArgs e)
        {
            frmVentanaInformativa f = new frmVentanaInformativa("Descuentos preautorizados a partir del 15/09/2005" + Environment.NewLine +
                "1 Pago:           Sin interés" + Environment.NewLine + "2 a 6 Pagos:          50 % de descuento" + Environment.NewLine +
                "7 a 12 Pagos:         25 % de descuento" + Environment.NewLine + "Más de 12 pagos:     Sin descuento" + Environment.NewLine +
                Environment.NewLine + "No se permiten convenios que no sean por el total de la deuda");
            f.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            GuardarNuevoConvenio();
        }

        private void btnCrearConvenio_Click(object sender, EventArgs e)
        {
            frmConvenioPago f = new frmConvenioPago(_idSocio, _ImporteDeuda, _CantidadCuotas, _ImporteCuota, 
                                                    mtxtFechaConvenio.Text, _CanonMunicipal);
            f.Text = "Nuevo Convenio";
            f.Show();
        }

        private void nudCuotas_ValueChanged(object sender, EventArgs e)
        {
            _CantidadCuotas = (int)nudCuotas.Value;
            _ImporteCuota = _ImporteDeuda / nudCuotas.Value;
            txtValorCuotas.Text = Math.Round(_ImporteCuota, 2).ToString();
        }

        private void nudCuotasAbonadas_ValueChanged(object sender, EventArgs e)
        {
            _CantidadCuotasCanceladas = (int)nudCuotasAbonadas.Value;
        }

        private void rbtnNormal_CheckedChanged(object sender, EventArgs e)
        {
            txtDescuento.Enabled = false;
            _FacturasNoCanceladas = _ImporteFacturasSeleccionadasTotal;
            CargarDatos();
        }

        private void rbtnSinInteres_CheckedChanged(object sender, EventArgs e)
        {
            txtDescuento.Enabled = false;
            _FacturasNoCanceladas = _ImporteSinInteres;
            CargarDatos();
        }

        private void rbtnCobroDescuento_CheckedChanged(object sender, EventArgs e)
        {
            txtDescuento.Enabled = true;
            if (txtDescuento.Text.Length == 0)
            { 
                txtDescuento.Text="0";
                _FacturasNoCanceladas = _ImporteSinInteres + (_ImporteRecargos - (_ImporteRecargos * (decimal.Parse(txtDescuento.Text) / 100)));
                CargarDatos();
            }
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();
            if (txtDescuento.Text.Length == 0)
            {
                txtDescuento.Text = "0";
            }
            else {
                if (decimal.Parse(txtDescuento.Text) > 50)
                {
                    result = MessageBox.Show("Esta seguro que desea efectuar un descuento superior al 50%?", "", MessageBoxButtons.YesNo);
                }
                else {
                    _FacturasNoCanceladas = _ImporteSinInteres + (_ImporteRecargos - (_ImporteRecargos * (decimal.Parse(txtDescuento.Text) / 100)));
                }
            }
            if (result == DialogResult.Yes)
            {
                _FacturasNoCanceladas = _ImporteSinInteres + (_ImporteRecargos - (_ImporteRecargos * (decimal.Parse(txtDescuento.Text) / 100)));
            }
            else {
                if (txtDescuento.Text.Length == 0)
                {
                    txtDescuento.Text = "0";
                }
            }
            CargarDatos();
        }

        private void chkConvenioAbogado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkConvenioAbogado.Checked)
            {
                cmbCaja.SelectedValue = (int)Cajas.ConvAbogado;
                cmbCaja.Enabled = false;
            }
            else
            {
                if (_ConveniosNoCancelados > 0)
                {
                    cmbCaja.SelectedValue = (int)Cajas.ConvRefinanciado;
                    cmbCaja.Enabled = false;
                }
                else
                {
                    cmbCaja.Enabled = true;
                }
            }

            DialogResult result = new DialogResult();
            if (chkConvenioAbogado.Checked)
            {
                result = MessageBox.Show("Los convenios judiciales no se incluyen en la facturación" + Environment.NewLine +
                    "Este convenio se realizó por via judicial?", "", MessageBoxButtons.YesNo);
            }

            if (chkConvenioAbogado.Checked && result == DialogResult.Yes)
            {
                //lo dejo marcado
            }
            else
            {
                if (chkConvenioAbogado.Checked)
                {
                    //dije q no lo desmarco
                    chkConvenioAbogado.Checked = false;
                }
            }

        }

        #endregion

        #region <<Convenio Moratoria>>

        private void rbFacturarTodas_CheckedChanged(object sender, EventArgs e)
        {
            txtCuotasAbonadasMora.Text = "0";
        }

        private void rbPagaPrimerCuota_CheckedChanged(object sender, EventArgs e)
        {
            txtCuotasAbonadasMora.Text = "1";
            _CantidadCuotasCanceladas = 1;
        }

        private void dgvCuotasMora_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dgvCuotasMora.CurrentRow;
            if (row != null)
            {
                _CantidadCuotas = Convert.ToInt32(row.Cells[0].Value);
                _ImporteDeuda = Convert.ToDecimal(row.Cells[3].Value);
                _ImporteCuota = Convert.ToDecimal(row.Cells[4].Value);
                _CanonMunicipal =0;
            }
        }

        private void btnCrearConvenioPagoMoratoria_Click(object sender, EventArgs e)
        {
            frmConvenioPago f = new frmConvenioPago(_idSocio, _ImporteDeuda, _CantidadCuotas, _ImporteCuota,
                                                    dtpFechaConvenio.Text, _CanonMunicipal);
            f.Text = "Nuevo Convenio";
            f.Show();
            btnAceptarMoratoria.Enabled = true;
        }

        private void tbnCancelarMoratoria_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptarMoratoria_Click(object sender, EventArgs e)
        {
            GuardarNuevoConvenio();
        }

        #endregion


        #endregion

        #region << METODOS >>

        private void Inicializar()
        {
            MoratoriasImplement oMoratoriasImplement = new MoratoriasImplement();
            if (oMoratoriasImplement.ExisteMoratoria(DateTime.Today, DateTime.Today,0))
            {
                ((Control)tabConvenioPago).Enabled = false;
                ((Control)tabMoratoria).Enabled = true;
                tabConvenio.SelectTab(1);
                _convenioMora = true;
                InicializarConvenioMoratoria();
            }
            else {
                ((Control)tabConvenioPago).Enabled = true;
                ((Control)tabMoratoria).Enabled = false;
                tabConvenio.SelectTab(0);
                InicializarConvenioNuevo();
            }
            
        }

        #region <<Convenio Nuevo>>

        private void InicializarConvenioNuevo()
        {
            rbtnNormal.Checked = true;
            mtxtFechaConvenio.Text = DateTime.Today.ToString();
            mtxtFechaCaja.Text = DateTime.Today.ToString();
            this.cmbCaja.Enabled = true;
            CajasImplement oCajasImplement = new CajasImplement();
            oCajasImplement.CargarComboConvenio(ref this.cmbCaja, "Seleccione..");
            CargarDatos();
            if (_ConveniosNoCancelados > 0)
            {
                if (!chkConvenioAbogado.Checked)
                {
                    cmbCaja.SelectedValue = (int)Cajas.ConvRefinanciado;
                    cmbCaja.Enabled = false;
                }
            }
            else
            {
                if (!chkConvenioAbogado.Checked)
                {
                    cmbCaja.Enabled = true;
                }
            }
        }

        private void AbrirFacturasSeleccion()
        {
            frmFacturasSeleccion f = new frmFacturasSeleccion(_idSocio);
            FacturasImplement oFacturasImplement = new FacturasImplement();
            f.Text = "Facturas Seleccion";
            CalculosConvenio oCalculosConvenio = new CalculosConvenio();
            if (f.ShowDialog() == DialogResult.OK)
            {
                _ListaFacturas = f.rowSeleccion; //lee la propiedad
                _ImporteFacturasSeleccionadasTotal = f.TotalFacturasImporte;
                _CanonMunicipal = f.CanonMunicipal;
                _ConveniosNoCancelados = oCalculosConvenio.ObtenerImporteConvenioAdeudado(_idSocio);
                _ImporteSinInteres = f.ImporteSinInteres;
                _ImporteRecargos = f.ImporteRecargos;
                _FacturasNoCanceladas = _ImporteFacturasSeleccionadasTotal;

                lbFacturas.Items.Clear();
                foreach (int i in _ListaFacturas)
                {
                    lbFacturas.Items.Add(i.ToString());
                    _totalCobrado = _totalCobrado + (decimal)oFacturasImplement.Get(i).cobrado;
                }

                CargarDatos();
            }
            //f.Show();
        }

        private void CargarDatos()
        {
            
            FacturasImplement oFacturasImplement= new FacturasImplement();
            CalculosConvenio oCalculosConvenio = new CalculosConvenio();
            foreach (int i in _ListaFacturas)
            {
                _totalCobrado = _totalCobrado + (decimal)oFacturasImplement.Get(i).cobrado;
            }
            txtFacNoCanceladas.Text = (_FacturasNoCanceladas - _totalCobrado).ToString(); //Preguntar
            _ConveniosNoCancelados = oCalculosConvenio.ObtenerImporteConvenioAdeudado(_idSocio);

            txtConvNoCancelados.Text = _ConveniosNoCancelados.ToString();
            Decimal _conveniosNoVolcados = 0;
            txtConvNoVolcados.Text = _conveniosNoVolcados.ToString();
            Decimal _costoFinanciero = 0;
            txtCostoFinanciero.Text = _costoFinanciero.ToString();
            Decimal _gastosAdministrativos = 0;
            txtGastosAdministrativos.Text = _gastosAdministrativos.ToString();
            Decimal _reconexion = 0;
            txtReconexion.Text = _reconexion.ToString();

            txtCanonMunicipal.Text = _CanonMunicipal.ToString();
            _ImporteDeuda = (_FacturasNoCanceladas + _ConveniosNoCancelados + _conveniosNoVolcados + _gastosAdministrativos + _reconexion
                                - _totalCobrado - _CanonMunicipal);
            txtImporteTotal.Text = _ImporteDeuda.ToString();
            nudCuotas.Value = 1;
            _CantidadCuotas = (int)nudCuotas.Value;
            _ImporteCuota = _ImporteDeuda / nudCuotas.Value;
            txtValorCuotas.Text = Math.Round(_ImporteCuota, 2).ToString();

        }

        private void GuardarNuevoConvenio()
        {
            convenios oConvenio = new convenios();
            ConvenioImplement oConvenioImplement = new ConvenioImplement();

            //Cancelo el adeudado
            oConvenioImplement.CancelarAdeudado(_idSocio);

            oConvenio.id_socio = _idSocio;
            oConvenio.fecha_convenio=dtpFechaConvenio.Value;
            oConvenio.importe_total = _ImporteDeuda;
            oConvenio.valor_cuota= _ImporteCuota;
            oConvenio.cuotas= _CantidadCuotas;
            oConvenio.facturadas= _CantidadCuotasCanceladas;
            oConvenio.pendientes= _CantidadCuotas - _CantidadCuotasCanceladas;
            oConvenio.finalizado= (_CantidadCuotas==_CantidadCuotasCanceladas);
            oConvenio.iva_facturas=0;//VER
            oConvenio.cuota_iva=0;//VER
            oConvenio.convenio_judicial=(chkConvenioAbogado.Checked);
            oConvenio.porcentaje_descuento_recargo=0;//VER
            oConvenio.importe_descuento_recargo=0;//VER
            oConvenio.tipo_descuento_recargo=-1;
            oConvenio.id_usuario=null;
            oConvenio.id_terminal=null;
            oConvenio.fecha_registro = DateTime.Today;
            oConvenio.moratoria = _convenioMora;
            int idConvenio=oConvenioImplement.Save(oConvenio);

            FacturasImplement oFacturasImplement = new FacturasImplement();
            facturas oFacturas = new facturas();
            foreach(int i in _ListaFacturas)
            {
                oFacturas = oFacturasImplement.Get(i);
                oFacturas.id_convenio = idConvenio;
                oFacturasImplement.Update(oFacturas);
            }

            DialogResult = DialogResult.OK;
            this.Close();
        }

        #endregion

        #region <<COnvenio Moratoria>>

        private void InicializarConvenioMoratoria()
        {
            rbPagaPrimerCuota.Checked = true;
            _CantidadCuotasCanceladas = 1;
            dtpFechaConvenio.Text = DateTime.Today.ToString();
      
            CajasImplement oCajasImplement = new CajasImplement();
            oCajasImplement.CargarComboConvenio(ref this.cmbCajaMoratoria, "Seleccione..");
            CargarDatosMoratoria();
            cmbCajaMoratoria.SelectedValue = (int)Cajas.ConvMoratoria;
            cmbCajaMoratoria.Enabled=false;
        }

        private void CargarDatosMoratoria()
        {

            FacturasImplement oFacturasImplement = new FacturasImplement();
            CalculosConvenio oCalculosConvenio = new CalculosConvenio();
       
            _ConveniosNoCancelados = oCalculosConvenio.ObtenerImporteConvenioAdeudado(_idSocio);

            DataTable dtFacturas = oFacturasImplement.GetByIdSocioSinConvenioDT(_idSocio, 1, 1);
            txtFactAdeudadasMora.Text = dtFacturas.Rows.Count.ToString();
            Decimal valorTotalSinInteres = 0;
            Decimal valorInteresesMora = 0;
            foreach (DataRow dr in dtFacturas.Rows)
            {
                #region <Control Valores Vacios>
                decimal Neto = 0;
                decimal IVA = 0;
                decimal Cobrado = 0;
                decimal Recargo=0;
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

                valorTotalSinInteres = valorTotalSinInteres + (Neto + IVA - Cobrado);
                valorInteresesMora = valorInteresesMora + (Recargo + IVARecargo);
            }

            Decimal ImporteTotalSinInteresMora =valorTotalSinInteres + _ConveniosNoCancelados;
            txtTotalSinInteresMora.Text =ImporteTotalSinInteresMora.ToString();
            Decimal ImporteInteresesMora = valorInteresesMora;
            txtImporteInteresesMora.Text = ImporteInteresesMora.ToString();
            txtTotalMoratoria.Text = (ImporteTotalSinInteresMora + ImporteInteresesMora).ToString();
            txtCuotasAbonadasMora.Text = "1";
            txtDescPagoContadoMora.Text = "5%";
            txtCantMaxCuotasMora.Text = "-";

            facturas oFacturas = new facturas();
            oFacturas = oFacturasImplement.GetUltimaFactura(_idSocio);
            DataTable oFacturasDetallesDT = new DataTable();
            FacturasDetallesImplement oFacturasDetallesImplements = new FacturasDetallesImplement();
            oFacturasDetallesDT = oFacturasDetallesImplements.GetAllByIdFacturaDT(oFacturas.id_factura);
            decimal valorUltimaFactura =0;
            foreach(DataRow dr in oFacturasDetallesDT.Rows)
            {
                int _idConcepto = int.Parse(dr["id_concepto"].ToString());
                if(_idConcepto==1 | _idConcepto==2 | _idConcepto==3 |_idConcepto==8)
                {
                    valorUltimaFactura = valorUltimaFactura + decimal.Parse(dr["importe"].ToString());
                }
            }

            decimal valorMinimoCuota = Math.Round((valorUltimaFactura / 2), 2);
            txtValorMinimoCuotaMora.Text=valorMinimoCuota.ToString();

            int maxCantCuotas = (int)((ImporteTotalSinInteresMora + ImporteInteresesMora) / valorMinimoCuota);
            //Pregunto por si la moratoria tiene limitacion, si no la tiene cambio la cant max de cuotas por minimo monto
            //por la max cant de cuotas por moratoria directamente

            MoratoriasImplement oMoratoriasImplement = new MoratoriasImplement();
            DataTable cuotasDT = new DataTable();
            DateTime fechaConv = dtpFechaConvenio.Value;

            cuotasDT = oMoratoriasImplement.GetTablaCuotasConvenioMoratoria(maxCantCuotas, fechaConv, ImporteTotalSinInteresMora, ImporteInteresesMora);
            txtCantMaxCuotasMora.Text = cuotasDT.Rows.Count.ToString();//esta tabla trae la cantidad de cuotas previendo limitacion con valor minimo

            dgvCuotasMora.DataSource = cuotasDT;
        }

        #endregion

       

       
      
       
        
        #endregion


    }
}
