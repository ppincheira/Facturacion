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
    public partial class frmCambiarCaja : Form
    {
        string _caja;
        int _idFactura;

        public frmCambiarCaja()
        {
            InitializeComponent();
        }

        public frmCambiarCaja(int idFactura)
        {
            InitializeComponent();
            _idFactura = idFactura;
            


        }

        private void frmCambiarCaja_Load(object sender, EventArgs e)
        {
            CajasImplement oCajasImplement = new CajasImplement();
            cobranzas oCobranza = new cobranzas();
            CobranzasImplement oCobranzasImplement = new CobranzasImplement();
            oCobranza = oCobranzasImplement.GetByIdFactura(_idFactura);
            _caja = oCobranza.id_caja.ToString();

            txtCajaActual.Text = _caja;
            txtCajaActualDescripcion.Text = oCajasImplement.Get(int.Parse(_caja)).caja;
            CargarCajasActivas();
        }

        private void cmbCajaNueva_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarCaja();
        }

        private void CargarCajasActivas()
        {
            CajasImplement oCajasImplement = new CajasImplement();
            IList ListaCajas = oCajasImplement.GetAllActivas();
            cod_cajas oCaja = new cod_cajas();
            cmbCajaNueva.DisplayMember = "id_caja";
            cmbCajaNueva.ValueMember = "id_caja";
            cmbCajaNueva.DataSource = ListaCajas;

            MostrarCaja();
        }

        private void MostrarCaja()
        {
            CajasImplement oCajasImplement = new CajasImplement();
            txtCajaNuevaDescripcion.Text = oCajasImplement.Get(int.Parse(cmbCajaNueva.SelectedValue.ToString())).caja;
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            FacturasImplement oFacturasImplement = new FacturasImplement();
            cobranzas oCobranza = new cobranzas();
            CobranzasImplement oCobranzasImplement = new CobranzasImplement();
            if (oFacturasImplement.ExisteCobranza(_idFactura))
            {
                oCobranza = oCobranzasImplement.GetByIdFactura(_idFactura);
                if (oCobranza != null)
                {
                    oCobranza.id_caja = int.Parse(cmbCajaNueva.SelectedValue.ToString());
                    oCobranzasImplement.Update(oCobranza);
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
