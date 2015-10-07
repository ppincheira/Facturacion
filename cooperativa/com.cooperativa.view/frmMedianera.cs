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
    public partial class frmMedianera : Form
    {
        #region << EVENTOS >>
        public frmMedianera()
        {
            InitializeComponent();
        }

        private void frmMedianera_Load(object sender, EventArgs e)
        {
            Inicializar();

        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            NuevaMedinera();
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            ModificarMedianera();
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

        private void dgvMedianera_SelectionChanged(object sender, EventArgs e)
        {
            CargarSeleccion();
        }
        #endregion

        #region << METODOS >>


        private void Inicializar()
        {
            CargarGrid();
            this.txtNombre.Enabled = false;

        }
        private void CargarSeleccion()
        {

            cod_medianeras oMedianera = new cod_medianeras();
            MedianeraImplement oMedianeraImplement = new MedianeraImplement();

            DataGridViewRow row = this.dgvMedianera.CurrentRow;
            int id = Convert.ToInt32(row.Cells[0].Value);
            oMedianera = oMedianeraImplement.Get(id);
            this.lblCodigo.Text = oMedianera.id_medianera.ToString();
            this.txtNombre.Text = oMedianera.medianera;
            this.txtNombre.Enabled = false;
            Deshabilitar();
        }

        private void Guardar()
        {
            MedianeraImplement oMedianeraImplement = new MedianeraImplement();
            cod_medianeras oMedianera = new cod_medianeras();

            if (this.lblCodigo.Text == "")
            {
                oMedianera.medianera = this.txtNombre.Text;
                oMedianeraImplement.Save(oMedianera);
            }
            else
            {

                DataGridViewRow row = this.dgvMedianera.CurrentRow;
                int id = Convert.ToInt32(row.Cells[0].Value);
                oMedianera = oMedianeraImplement.Get(id);
                oMedianera.medianera = this.txtNombre.Text;
                oMedianeraImplement.Update(oMedianera);
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
            this.dgvMedianera.Enabled = true;
            this.txtNombre.Text = "";
            this.txtNombre.Enabled = false;
            this.lblCodigo.Text = "";
            Deshabilitar();
        }

        private void NuevaMedinera()
        {
            HabilitarBotones();
            this.txtNombre.Text = "";
            this.txtNombre.Enabled = true;
            this.lblCodigo.Text = "";
        }

        private void ModificarMedianera()
        {
            HabilitarBotones();
            this.txtNombre.Enabled = true;
            cod_medianeras oMedianera = new cod_medianeras();
            MedianeraImplement oMedianeraImplement = new MedianeraImplement();
            DataGridViewRow row = this.dgvMedianera.CurrentRow;
            int id = Convert.ToInt32(row.Cells[0].Value);
            oMedianera = oMedianeraImplement.Get(id);
            this.lblCodigo.Text = oMedianera.id_medianera.ToString();
            this.txtNombre.Text = oMedianera.medianera;
            this.dgvMedianera.Enabled = false;
        }
        private void CargarGrid()
        {
            MedianeraImplement oMedianeraImplement = new MedianeraImplement();
            this.dgvMedianera.DataSource = oMedianeraImplement.Buscar("");
            this.dgvMedianera.Enabled = true;

        }
        #endregion


    }
}
