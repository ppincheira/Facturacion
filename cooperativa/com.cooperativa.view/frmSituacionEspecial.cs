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
    public partial class frmSituacionEspecial : Form
    {
        #region << EVENTOS >>
        public frmSituacionEspecial()
        {
            InitializeComponent();
        }

        private void dgvSituacion_SelectionChanged(object sender, EventArgs e)
        {
            CargarSeleccion();
        }

        private void frmSituacionEspecial_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            NuevaSituacion();
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            ModificarSituacion();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {

        }

        private void tsbImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }
        #endregion


        #region << METODOS >>


        private void Inicializar()
        {
            CargarGrid();
            this.gbSituacion.Enabled = false;

        }
        private void CargarSeleccion()
        {
            cod_situacion_especial oSituacion = new cod_situacion_especial();
            SituacionEspecialImplement oSituacionImplement = new SituacionEspecialImplement();
            
            DataGridViewRow row = this.dgvSituacion.CurrentRow;
            int id = Convert.ToInt32(row.Cells[0].Value);
            oSituacion = oSituacionImplement.Get(id);
            this.lblCodigo.Text = oSituacion.id_situacion_especial.ToString();
            this.txtNombre.Text = oSituacion.situacion_especial;
            this.gbSituacion.Enabled = false;
            Deshabilitar();
        }

        private void Guardar()
        {
            cod_situacion_especial oSituacion = new cod_situacion_especial();
            SituacionEspecialImplement oSituacionImplement = new SituacionEspecialImplement();
            if (this.lblCodigo.Text == "")
            {
                oSituacion.situacion_especial= this.txtNombre.Text;
                oSituacionImplement.Save(oSituacion);
            }
            else
            {
                DataGridViewRow row = this.dgvSituacion.CurrentRow;
                int id = Convert.ToInt32(row.Cells[0].Value);
                oSituacion = oSituacionImplement.Get(id);
                oSituacion.situacion_especial = this.txtNombre.Text;
                oSituacionImplement.Update(oSituacion);
            }
            Deshabilitar();
            this.txtNombre.Text = "";
            CargarGrid();
        }

        private void HabilitarBotones()
        {
            this.btnAceptar.Enabled = true;
            this.btnCancelar.Enabled = true;
            this.tsMenu.Enabled = false;
        }
        private void Deshabilitar()
        {
            this.btnCancelar.Enabled = false;
            this.btnAceptar.Enabled = false;
            this.tsMenu.Enabled = true;

        }
        private void Cancelar()
        {
            this.dgvSituacion.Enabled = true;
            this.txtNombre.Text = "";
            this.gbSituacion.Enabled = false;
            this.lblCodigo.Text = "";
            Deshabilitar();
        }

        private void NuevaSituacion()
        {
            HabilitarBotones();
            this.txtNombre.Text = "";
            this.gbSituacion.Enabled = true;
            this.lblCodigo.Text = "";
        }

        private void ModificarSituacion()
        {
            HabilitarBotones();
            this.gbSituacion.Enabled = true;
            cod_situacion_especial oSituacion = new cod_situacion_especial();
            SituacionEspecialImplement oSituacionImplement = new SituacionEspecialImplement();
            DataGridViewRow row = this.dgvSituacion.CurrentRow;
            int id = Convert.ToInt32(row.Cells[0].Value);
            oSituacion = oSituacionImplement.Get(id);
            this.lblCodigo.Text = oSituacion.id_situacion_especial.ToString();
            this.txtNombre.Text = oSituacion.situacion_especial;
            this.dgvSituacion.Enabled = false;
        }
        private void CargarGrid()
        {
            SituacionEspecialImplement oSituacionImplement = new SituacionEspecialImplement();
            this.dgvSituacion.DataSource = oSituacionImplement.Buscar("");
            this.dgvSituacion.Enabled = true;

        }
        #endregion
    }
}
