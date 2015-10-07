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
    public partial class frmSociosCodene : Form
    {

        #region << EVENTOS >>
        public frmSociosCodene()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSociosCodene_Load(object sender, EventArgs e)
        {
            Inicializar();
        }
        private void rbSeleccionarBarrio_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSeleccionarBarrio.Checked)
                cmbBarrio.Enabled = true;
            else
            {
                cmbBarrio.Enabled = false;

            }
        }

        private void rbFiltros_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFiltros.Checked)
                btnCrearFiltro.Enabled = true;
            else
            {
                btnCrearFiltro.Enabled = false;

            }
        }
        #endregion


        #region << METODOS >>
        private void Inicializar()
        {
            CargarBarrios();
        }

        private void CargarBarrios()
        {
            BarrioImplement oBarrioImplement = new BarrioImplement();
            oBarrioImplement.CargarCombo(this.cmbBarrio, "Seleccione Barrio");
        }


        #endregion

        

     

       

        
    }
}
