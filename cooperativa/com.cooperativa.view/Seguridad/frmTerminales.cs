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

namespace com.cooperativa.view.Seguridad
{
    public partial class frmTerminales : Form
    {
        public frmTerminales()
        {
            InitializeComponent();
        }

        private void frmTerminales_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void Inicializar()
        {
            CargarTerminales();

        }

        private void CargarTerminales()
        {
            TerminalesImplement oTerminalesImplement = new TerminalesImplement();
            oTerminalesImplement.CargarLista(lstTerminales);
        }

       

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            TerminalesImplement oTerminalesImplement = new TerminalesImplement();
            seg_terminales oseg_terminales = new seg_terminales();
            oseg_terminales.terminal = txtNombreEquipo.Text;
            oseg_terminales.intento_nro = 0;
            oseg_terminales.habilitada = chkHabilitada.Checked;
            oseg_terminales.fecha_bloqueo = null;
            oseg_terminales.bloqueada = false;
            oTerminalesImplement.Save(oseg_terminales);

            CargarTerminales();

            txtIDTerminal.Text = "";
            txtNombreEquipo.Text = "";
            chkHabilitada.Checked = false;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            TerminalesImplement oTerminalesImplement = new TerminalesImplement();
            
            oTerminalesImplement.Delete(int.Parse(txtIDTerminal.Text));
            CargarTerminales();

            txtIDTerminal.Text = "";
            txtNombreEquipo.Text = "";
            chkHabilitada.Checked = false;
           
        }

        private void lstTerminales_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idTerminal = (int)lstTerminales.SelectedValue;
            TerminalesImplement oTerminalesImplement = new TerminalesImplement();
            seg_terminales oseg_terminales = new seg_terminales();
            oseg_terminales = oTerminalesImplement.Get(idTerminal);
            txtNombreEquipo.Text = oseg_terminales.terminal;
            txtIDTerminal.Text = oseg_terminales.id_terminal.ToString();
            chkHabilitada.Checked = (oseg_terminales.habilitada == null) ? false : (bool)oseg_terminales.habilitada;

        }

      
    }
}
