using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using com.cooperativa.implement;

namespace com.cooperativa.view.Rutas
{
    public partial class frmImprimirHojaRuta : Form
    {
        #region << EVENTOS >>
        public frmImprimirHojaRuta()
        {
            InitializeComponent();
        }

        private void frmImprimirHojaRuta_Load(object sender, EventArgs e)
        {
            Inicializar();
        }
        private void cmbBarrios_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarRutas( int.Parse(this.cmbBarrios.SelectedValue.ToString()));
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }
        private void rbUnaHojaRutaBarrio_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarBarrios();
            HabilitarRutas();
        }

        private void rbTodasHojasRutasBarrio_CheckedChanged(object sender, EventArgs e)
        {
            Deshabilitar();
            this.cmbBarrios.SelectedValue = 0;
            HabilitarBarrios();
        }

        private void rbTodasHojasRutas_CheckedChanged(object sender, EventArgs e)
        {
            Deshabilitar();
        }
        #endregion

        #region << METODOS >>

        private void Inicializar() {

            CargarBarrios();
        }

        private void CargarBarrios()
        {
            BarrioImplement oBarrioImplement = new BarrioImplement();
            oBarrioImplement.CargarCombo(this.cmbBarrios, "Seleccione Barrio");
        }

        private void CargarRutas(int idBarrio) {
            BarrioImplement oBarrioImplement = new BarrioImplement();
            oBarrioImplement.CargarComboRutas(this.cmbRuta,idBarrio);
        }
        private void HabilitarBarrios() {
            this.cmbBarrios.Enabled = true;
        }
        private void HabilitarRutas() {
            this.cmbRuta.Enabled = true;


        }
        private void Deshabilitar() {
            this.cmbBarrios.SelectedValue = 0;
            this.cmbBarrios.Enabled = false;
            this.cmbRuta.SelectedValue = 0;
        }

        private void Imprimir() {

            MessageBox.Show( "El trabajo con rutas se encuentra actualmente sin uso \n de "+
           " ser necesario se puede habilitar.", "Impresión no disponible", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        #endregion


   





   
    }
}
