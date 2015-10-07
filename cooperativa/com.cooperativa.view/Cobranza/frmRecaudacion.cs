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

namespace com.cooperativa.view.Cobranza
{
    public partial class frmRecaudacion : Form
    {
        #region << EVENTOS >>

        public frmRecaudacion()
        {
            InitializeComponent();
        }
        private void frmRecaudacion_Load(object sender, EventArgs e)
        {
            Inicializar();
        }
        private void rbtnTotasCajas_CheckedChanged(object sender, EventArgs e)
        {
            this.OcultarCaja();
        }
        private void rbtnPorCaja_CheckedChanged(object sender, EventArgs e)
        {
            this.OcultarCaja();
        }
        private void rbtnCaja_CheckedChanged(object sender, EventArgs e)
        {
            CargarCajasActivas();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void btnGenerarListado_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region << METODOS >>


        private void Inicializar() {

            OcultarCaja();
        }
        private void Salir() {
            this.Close();
        }

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
        private void MostrarCaja() {
            this.cmbCaja.Enabled = true;
        }

        private void OcultarCaja() {
            this.cmbCaja.Enabled = false;
        }
        #endregion

    

 

    


    }
}
