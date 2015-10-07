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
    public partial class frmTipoIntimacion : Form
    {
        #region << EVENTOS >>
        public frmTipoIntimacion()
        {
            InitializeComponent();
        }

        private void frmTipoIntimacion_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            NuevoTipoIntimacion();
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            ModificarTipoIntimacion();
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

        private void dgvTipoIntimacion_SelectionChanged(object sender, EventArgs e)
        {
            CargarSeleccion();
        }
        #endregion

        #region << METODOS >>


        private void Inicializar()
        {
            CargarGrid();
            this.gbIntimacion.Enabled = false;

        }
        private void CargarSeleccion()
        {
            cod_intimaciones oIntimidacion = new cod_intimaciones();
            TipoIntimacionImplement oTipoIntimidacionImplement = new TipoIntimacionImplement();
            DataGridViewRow row = this.dgvTipoIntimacion.CurrentRow;
            int id = Convert.ToInt32(row.Cells[0].Value);
            oIntimidacion = oTipoIntimidacionImplement.Get(id);
            this.lblCodigo.Text = oIntimidacion.id_intimacion.ToString();
            this.txtNombre.Text = oIntimidacion.intimacion;
            this.gbIntimacion.Enabled = false;
            Deshabilitar();
        }

        private void Guardar()
        {
            cod_intimaciones oIntimidacion = new cod_intimaciones();
            TipoIntimacionImplement oTipoIntimidacionImplement = new TipoIntimacionImplement();
            if (this.lblCodigo.Text == "")
            {
                oIntimidacion.intimacion = this.txtNombre.Text;
                oTipoIntimidacionImplement.Save(oIntimidacion);
            }
            else
            {
                DataGridViewRow row = this.dgvTipoIntimacion.CurrentRow;
                int id = Convert.ToInt32(row.Cells[0].Value);
                oIntimidacion = oTipoIntimidacionImplement.Get(id);
                oIntimidacion.intimacion = this.txtNombre.Text;
                oTipoIntimidacionImplement.Update(oIntimidacion);
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
            this.dgvTipoIntimacion.Enabled = true;
            this.txtNombre.Text = "";
            
            this.gbIntimacion.Enabled = false;
            this.lblCodigo.Text = "";
            Deshabilitar();
        }

        private void NuevoTipoIntimacion()
        {
            HabilitarBotones();
            this.txtNombre.Text = "";
            
            this.gbIntimacion.Enabled = true;
            this.lblCodigo.Text = "";
        }

        private void ModificarTipoIntimacion()
        {
            HabilitarBotones();
            this.gbIntimacion.Enabled = true;
            cod_intimaciones oIntimidacion = new cod_intimaciones();
            TipoIntimacionImplement oTipoIntimidacionImplement = new TipoIntimacionImplement();
            DataGridViewRow row = this.dgvTipoIntimacion.CurrentRow;
            int id = Convert.ToInt32(row.Cells[0].Value);
            oIntimidacion= oTipoIntimidacionImplement.Get(id);
            this.lblCodigo.Text = oIntimidacion.id_intimacion.ToString();
            this.txtNombre.Text = oIntimidacion.intimacion;
            this.gbIntimacion.Enabled = false;
        }

        private void CargarGrid()
        {
            TipoIntimacionImplement oTipoIntimidacionImplement = new TipoIntimacionImplement();
            this.dgvTipoIntimacion.DataSource = oTipoIntimidacionImplement.Buscar("");
            this.dgvTipoIntimacion.Enabled = true;
        }

        #endregion
    }
}
