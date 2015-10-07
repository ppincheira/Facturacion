using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using com.cooperativa.implement;
using com.cooperativa.services;
namespace com.cooperativa.view
{
    public partial class frmEstadoConexion : Form
    {

        #region << EVENTOS >>
        public frmEstadoConexion()
        {
            InitializeComponent();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            NuevoEstadoSocio();
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            ModificarEstadoSocio();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {

        }

        private void tsbImprimir_Click(object sender, EventArgs e)
        {

        }

        private void tsbAceptar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void frmEstadoConexion_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void dgvEstadoSocio_SelectionChanged(object sender, EventArgs e)
        {
            CargarSeleccion();
        }
        #endregion
        #region << METODOS >>


        private void Inicializar()
        {
            CargarGrid();
            CargarFactura();
            this.gbEstadoConexion.Enabled = false;
        }

        private void CargarFactura() {
            List<Item> lista = new List<Item>();
            lista.Add(new Item("Si", 0));
            lista.Add(new Item("No", 1));
            Utilidades oUtil = new Utilidades();
            oUtil.CargarCombo(cmbFacturar, lista, "value", "name", "");
                
        }
        private void CargarSeleccion()
        {
            cod_estados_socios oEstadoSocio = new cod_estados_socios();
            EstadoSocioImplement oEstadoSocioImplement = new EstadoSocioImplement();
            DataGridViewRow row = this.dgvEstadoSocio.CurrentRow;
            int id = Convert.ToInt32(row.Cells[0].Value);
            oEstadoSocio = oEstadoSocioImplement.Get(id);
            this.lblCodigo.Text = oEstadoSocio.id_estado_socio.ToString();
            this.txtNombre.Text = oEstadoSocio.estado_socio;
            this.cmbFacturar.SelectedValue = oEstadoSocio.facturar.Value? "1":"0";
            this.chkSeleccionable.Checked = oEstadoSocio.seleccionable.Value;
            this.chkFechaFin.Checked = oEstadoSocio.requiere_fin.Value;
            this.txtMeses.Text = oEstadoSocio.duracion_meses.ToString();
            this.gbEstadoConexion.Enabled = false;
            Deshabilitar();
        }

        private void Guardar()
        {
            cod_estados_socios oEstadoSocio = new cod_estados_socios();
            EstadoSocioImplement oEstadoSocioImplement = new EstadoSocioImplement();
            
            if (this.lblCodigo.Text == "")
            {
                oEstadoSocio.estado_socio = this.txtNombre.Text;
                oEstadoSocio.facturar = this.cmbFacturar.SelectedValue.ToString() == "0" ? false : true;
                oEstadoSocio.seleccionable = this.chkSeleccionable.Checked;
                oEstadoSocio.requiere_fin = this.chkFechaFin.Checked;
                oEstadoSocio.duracion_meses = this.txtMeses.Text==""?0:int.Parse(this.txtMeses.Text);
                oEstadoSocioImplement.Save(oEstadoSocio);
            }
            else
            {

                DataGridViewRow row = this.dgvEstadoSocio.CurrentRow;
                int id = Convert.ToInt32(row.Cells[0].Value);
                oEstadoSocio = oEstadoSocioImplement.Get(id);
                oEstadoSocio.estado_socio = this.txtNombre.Text;
                oEstadoSocio.facturar = this.cmbFacturar.SelectedValue == "0" ? false : true;
                oEstadoSocio.seleccionable = this.chkSeleccionable.Checked;
                oEstadoSocio.requiere_fin = this.chkFechaFin.Checked;
                oEstadoSocio.duracion_meses = this.txtMeses.Text == "" ? 0 : int.Parse(this.txtMeses.Text);
                oEstadoSocioImplement.Update(oEstadoSocio);
            }
            Deshabilitar();
            Limpiar();
            CargarGrid();

        }

        private void Limpiar() {
            this.lblCodigo.Text = "";
            this.txtNombre.Text = "";
            this.txtMeses.Text = "";
            this.cmbFacturar.SelectedValue = "0";
            this.chkSeleccionable.Checked = false;
            this.chkFechaFin.Checked = false;
            this.chkFechaFin.Checked = false;
            this.txtMeses.Text = "";
        }

        private void HabilitarBotones()
        {
            this.tsbAceptar.Enabled = true;
            this.tsbCancelar.Enabled = true;
            this.tsbNuevo.Enabled = false;
            this.tsbModificar.Enabled = false;
            this.tsbEliminar.Enabled = false;
            this.tsbImprimir.Enabled = false;
        }
        private void Deshabilitar()
        {
            this.tsbAceptar.Enabled = false;
            this.tsbCancelar.Enabled = false;
            this.tsbNuevo.Enabled = true;
            this.tsbModificar.Enabled = true;
            this.tsbEliminar.Enabled = true;
            this.tsbImprimir.Enabled = true;
        }
        private void Cancelar()
        {
            this.dgvEstadoSocio.Enabled = true;
            Limpiar();
            this.gbEstadoConexion.Enabled = false;
            Deshabilitar();
        }

        private void NuevoEstadoSocio()
        {
            HabilitarBotones();
            Limpiar();
            this.gbEstadoConexion.Enabled = true;
        }

        private void ModificarEstadoSocio()
        {
            HabilitarBotones();
            this.gbEstadoConexion.Enabled = true;
            cod_estados_socios oEstadoSocio = new cod_estados_socios();
            EstadoSocioImplement oEstadoSocioImplement = new EstadoSocioImplement();
            DataGridViewRow row = this.dgvEstadoSocio.CurrentRow;
            int id = Convert.ToInt32(row.Cells[0].Value);
            oEstadoSocio = oEstadoSocioImplement.Get(id);
            this.lblCodigo.Text = oEstadoSocio.id_estado_socio.ToString();
            this.txtNombre.Text = oEstadoSocio.estado_socio;
            this.cmbFacturar.SelectedValue = oEstadoSocio.facturar;
            this.chkSeleccionable.Checked = oEstadoSocio.seleccionable.Value;
            this.dgvEstadoSocio.Enabled = false;
        }
        private void CargarGrid()
        {
            EstadoSocioImplement oEstadoSocioImplement = new EstadoSocioImplement();

            this.dgvEstadoSocio.DataSource = oEstadoSocioImplement.Buscar("");
            this.dgvEstadoSocio.Enabled = true;

        }
        #endregion

    }
}
