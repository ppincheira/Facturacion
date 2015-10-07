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
    public partial class frmEstadoPJ : Form
    {
        #region << EVENTOS >>
        public frmEstadoPJ()
        {
            InitializeComponent();
        }


        private void frmEstadoPJ_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            NuevaEstado();
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            ModificarEstado();
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


        private void dgvstado_SelectionChanged(object sender, EventArgs e)
        {
            CargarSeleccion();
        }
        #endregion
        #region << METODOS >>


        private void Inicializar()
        {
            CargarGrid();
            this.gbEstado.Enabled = false;

        }
        private void CargarSeleccion()
        {
            cod_estados_pj oEstadoPJ = new cod_estados_pj();
            EstadoPJImplement oEstadosPJImplement = new EstadoPJImplement();
            DataGridViewRow row = this.dgvstado.CurrentRow;
            int id = Convert.ToInt32(row.Cells[0].Value);
            oEstadoPJ = oEstadosPJImplement.Get(id);

            this.lblCodigo.Text = oEstadoPJ.id_cod_estado_pj.ToString();
            this.txtNombre.Text = oEstadoPJ.descripcion;
            this.gbEstado.Enabled = false;
            Deshabilitar();
        }

        private void Guardar()
        {
            cod_estados_pj oEstadoPJ = new cod_estados_pj();
            EstadoPJImplement oEstadosPJImplement = new EstadoPJImplement();
            if (this.lblCodigo.Text == "")
            {

                oEstadoPJ.descripcion = this.txtNombre.Text;
                oEstadosPJImplement.Save(oEstadoPJ);
            }
            else
            {
                DataGridViewRow row = this.dgvstado.CurrentRow;
                int id = Convert.ToInt32(row.Cells[0].Value);
                oEstadoPJ = oEstadosPJImplement.Get(id);
                oEstadoPJ.descripcion = this.txtNombre.Text;
                oEstadosPJImplement.Update(oEstadoPJ);
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
            this.dgvstado.Enabled = true;
            this.txtNombre.Text = "";
            this.gbEstado.Enabled = false;
            this.lblCodigo.Text = "";
            Deshabilitar();
        }

        private void NuevaEstado()
        {
            HabilitarBotones();
            this.txtNombre.Text = "";
            this.gbEstado.Enabled = true;
            this.lblCodigo.Text = "";
        }

        private void ModificarEstado()
        {
            HabilitarBotones();
            this.gbEstado.Enabled = true;
            cod_estados_pj oEstadoPJ = new cod_estados_pj();
            EstadoPJImplement oEstadosPJImplement = new EstadoPJImplement();
            DataGridViewRow row = this.dgvstado.CurrentRow;
            int id = Convert.ToInt32(row.Cells[0].Value);
            oEstadoPJ = oEstadosPJImplement.Get(id);
            this.lblCodigo.Text = oEstadoPJ.id_cod_estado_pj.ToString();
            this.txtNombre.Text = oEstadoPJ.descripcion;
            this.dgvstado.Enabled = false;
        }

        private void CargarGrid()
        {
            EstadoPJImplement oEstadosPJImplement = new EstadoPJImplement();
            this.dgvstado.DataSource = oEstadosPJImplement.Buscar("");
            this.dgvstado.Enabled = true;
        }

        #endregion


    }
}
