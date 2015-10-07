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
    public partial class frmZona : Form
    {
        #region << EVENTOS >>
        public frmZona()
        {
            InitializeComponent();
        }


        private void frmZona_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            NuevaZona();
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            ModificarZona();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {

        }

        private void tsbImprimir_Click(object sender, EventArgs e)
        {

        }


        private void dgvZona_SelectionChanged(object sender, EventArgs e)
        {
            CargarSeleccion();
        }
        #endregion

        #region << METODOS >>


        private void Inicializar() {

            CargarGrid();
            this.txtNombre.Enabled = false;
            this.chkImprimir.Enabled = false;
        }
        private void CargarSeleccion()
        {
            cod_zonas oZona = new cod_zonas();
            ZonaImplement oZonaImplement = new ZonaImplement();
            DataGridViewRow row = this.dgvZona.CurrentRow;
            int id = Convert.ToInt32(row.Cells[0].Value);
            oZona = oZonaImplement.Get(id);
            this.lblCodigo.Text = oZona.id_zona.ToString();
            this.txtNombre.Text = oZona.zona;
            this.chkImprimir.Checked = oZona.imprimir.Value;
            this.txtNombre.Enabled = false;
            Deshabilitar();
        }

        private void Guardar()
        {
            ZonaImplement oZonaImplement = new ZonaImplement();
            cod_zonas oZona = new cod_zonas();

            
            if (this.lblCodigo.Text == "")
            {
                oZona.zona = this.txtNombre.Text;
                oZona.imprimir=this.chkImprimir.Checked;
                oZonaImplement.Save(oZona);
            }
            else
            {

                DataGridViewRow row = this.dgvZona.CurrentRow;
                int id = Convert.ToInt32(row.Cells[0].Value);
                oZona = oZonaImplement.Get(id);
                oZona.zona = this.txtNombre.Text;
                oZona.imprimir = this.chkImprimir.Checked;
                oZonaImplement.Update(oZona);
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
            this.dgvZona.Enabled = true;
            this.txtNombre.Text = "";
            this.txtNombre.Enabled = false;
            this.chkImprimir.Enabled = false;
            this.lblCodigo.Text = "";
            Deshabilitar();
        }

        private void NuevaZona()
        {
            HabilitarBotones();
            this.txtNombre.Text = "";
            this.txtNombre.Enabled = true;
            this.chkImprimir.Enabled = true;
            this.chkImprimir.Checked = false;
            this.lblCodigo.Text = "";
        }

        private void ModificarZona()
        {
            HabilitarBotones();
            this.txtNombre.Enabled = true;
            this.chkImprimir.Enabled=true;
            cod_zonas oZona = new cod_zonas();
            ZonaImplement oZonaImplement=new ZonaImplement();
            DataGridViewRow row = this.dgvZona.CurrentRow;
            int id = Convert.ToInt32(row.Cells[0].Value);
            oZona = oZonaImplement.Get(id);
            this.lblCodigo.Text = oZona.id_zona.ToString();
            this.txtNombre.Text = oZona.zona;
            this.chkImprimir.Checked = oZona.imprimir.Value;
            this.dgvZona.Enabled = false;
        }
        private void CargarGrid()
        {
            ZonaImplement oZonaImplement = new ZonaImplement();
            this.dgvZona.DataSource = oZonaImplement.Buscar("");
            this.dgvZona.Enabled = true;
        }
        #endregion

    }
}
