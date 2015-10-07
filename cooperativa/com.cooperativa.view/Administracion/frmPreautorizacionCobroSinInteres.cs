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
    public partial class frmPreautorizacionCobroSinInteres : Form
    {
        #region << EVENTOS >>
        public frmPreautorizacionCobroSinInteres()
        {
            InitializeComponent();
        }

        private void frmPreautorizacionCobroSinInteres_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region << METODOS >>

        private void Inicializar() {
            CargarOrden();
        }

        private void CargarOrden() {
            DataTable dtOrden = new DataTable();
            dtOrden.Columns.Add("id", typeof(string));
            dtOrden.Columns.Add("orden", typeof(string));
            dtOrden.Rows.Add("01", "Codigo Socio");
            dtOrden.Rows.Add("02", "Nombre");
            dtOrden.Rows.Add("03", "Fecha");
            this.cmbOrden.DataSource = dtOrden;
            this.cmbOrden.ValueMember = "id";
            this.cmbOrden.DisplayMember = "orden";
        }

        #endregion

        private void tsbNuevo_Click(object sender, EventArgs e)
        {

        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {

        }

        private void tsbImprimir_Click(object sender, EventArgs e)
        {

        }
    }
}
