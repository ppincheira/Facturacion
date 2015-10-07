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
    public partial class frmSociosIntimados : Form
    {
        public frmSociosIntimados()
        {
            InitializeComponent();
        }

        private void frmSociosIntimados_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void Inicializar()
        {
            CargarBarrios();
            CargarTipoIntimacion();
            CargarAnios();
        }

        private void CargarBarrios()
        {
            BarrioImplement oBarrioImplement = new BarrioImplement();
            oBarrioImplement.CargarCombo(this.cmbBarrio, "Seleccione Barrio");
        }

        private void CargarTipoIntimacion()
        {
            TipoIntimacionImplement oTipoIntimacionImplement = new TipoIntimacionImplement();
            oTipoIntimacionImplement.CargarCombo(this.cmbTipoIntimacion, "Seleccione tipo intimacion");
        }

        private void CargarAnios()
        {
            cmbAnio.Items.Clear();

            //Incluir dos items Hombre y Mujer
            cmbAnio.Items.Add(new KeyValuePair<int, int>(2000, 2000));
            cmbAnio.Items.Add(new KeyValuePair<int, int>(2001, 2001));
            cmbAnio.Items.Add(new KeyValuePair<int, int>(2002, 2002));
            cmbAnio.Items.Add(new KeyValuePair<int, int>(2003, 2003));
            cmbAnio.Items.Add(new KeyValuePair<int, int>(2004, 2004));
            cmbAnio.Items.Add(new KeyValuePair<int, int>(2005, 2005));
            cmbAnio.Items.Add(new KeyValuePair<int, int>(2006, 2006));
            cmbAnio.Items.Add(new KeyValuePair<int, int>(2007, 2007));
            cmbAnio.Items.Add(new KeyValuePair<int, int>(2008, 2008));
            cmbAnio.Items.Add(new KeyValuePair<int, int>(2009, 2009));
            cmbAnio.Items.Add(new KeyValuePair<int, int>(2010, 2010));
            cmbAnio.Items.Add(new KeyValuePair<int, int>(2011, 2011));
            cmbAnio.Items.Add(new KeyValuePair<int, int>(2012, 2012));
            cmbAnio.Items.Add(new KeyValuePair<int, int>(2013, 2013));
            cmbAnio.Items.Add(new KeyValuePair<int, int>(2014, 2014));
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

        private void rbSociosPagareFirmado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSociosPagareFirmado.Checked)
                cmbAnio.Enabled = true;
            else
            {
                cmbAnio.Enabled = false;

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
