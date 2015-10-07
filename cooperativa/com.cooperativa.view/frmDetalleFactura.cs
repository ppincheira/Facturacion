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
    public partial class frmDetalleFactura : Form
    {
        #region << PROPIEDADES >>

        int _idFactura;
        string _user;

        #endregion

        #region << EVENTOS >>

        public frmDetalleFactura(string usuario, int idFactura)
        {
            InitializeComponent();
            _idFactura = idFactura;
            _user = usuario;
        }

        private void frmDetalleFactura_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region << METODOS >>

        private void Inicializar()
        {

            FacturasImplement oFacturasImplement = new FacturasImplement();
            facturas oFacturas = new facturas();
            oFacturas = oFacturasImplement.Get(_idFactura);
            txtFactura.Text = oFacturas.id_factura.ToString();
            txtPeriodo.Text = oFacturas.id_periodo.ToString().Substring(4,2) + "/" + oFacturas.id_periodo.ToString().Substring(0,4);
            txtFehaFacturacion.Text = "";
            
            txtFechaVencimiento.Text = "";
            EstadosPagoImplement oEstadosPagoImplement = new EstadosPagoImplement();
            cod_estados_pago oCod_Estados_Pago = new cod_estados_pago();
            int idEstado = (int)oFacturas.id_estadoPago;
            oCod_Estados_Pago=oEstadosPagoImplement.Get(idEstado);
            txtEstado.Text = oCod_Estados_Pago.estado_pago;
            txtFechaPago.Text = oFacturas.fechaPago.ToString();
            socios_mediciones oSociosMediciones = new socios_mediciones();
            SocioMedicionImplement oSocioMedicionImplement = new SocioMedicionImplement();
            oSociosMediciones = oSocioMedicionImplement.Get((int)oFacturas.id_medicion);
            txtM3Consumidos.Text = oSociosMediciones.consumo.ToString();

            cargarGrillaConceptos();

            txtImporteTotal.Text = oFacturas.importeTotal.ToString();
            txtCobrado.Text = oFacturas.cobrado.ToString();

        }

        private void cargarGrillaConceptos()
        {
            FacturasDetallesImplement oFacturasDetallesImplement = new FacturasDetallesImplement();
            this.dgvConceptos.DataSource = oFacturasDetallesImplement.GetByIdFacturaDT(_idFactura);
            this.dgvConceptos.Enabled = true;
        }

        #endregion
    }
}
