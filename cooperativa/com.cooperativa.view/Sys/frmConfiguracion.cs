using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using com.cooperativa.implement;

namespace com.cooperativa.view.Sys
{
    public partial class frmConfiguracion : Form
    {
        

        #region << EVENTOS >>
        public frmConfiguracion()
        {
            InitializeComponent();
        }
        private void frmConfiguracion_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            NuevaConfig();
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            ModificarConfig();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
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

        private void dgvConfig_SelectionChanged(object sender, EventArgs e)
        {
            CargarSeleccion();
        }
  

        #endregion

        #region << METODOS >>
        
        private void Inicializar()
        {
            CargarGrid();
            this.gbConfig.Enabled = false;

        }
        private void CargarSeleccion()
        {
            sys_configuracion oSysConfig = new sys_configuracion();
            SysConfigImplement oSysConfigImplement = new SysConfigImplement();
            DataGridViewRow row = this.dgvConfig.CurrentRow;
            int id = Convert.ToInt32(row.Cells[0].Value);
            oSysConfig = oSysConfigImplement.Get(id);

            this.lblCodigo.Text = oSysConfig.id_configuracion.ToString();
            this.txtNombre.Text = oSysConfig.nombre;
            this.txtValor.Text = oSysConfig.valor;
            this.txtObsevacion.Text = oSysConfig.observacion;
            this.gbConfig.Enabled = false;
            Deshabilitar();
        }

        private void Guardar()
        {
            sys_configuracion oSysConfig = new sys_configuracion();
            SysConfigImplement oSysConfigImplement = new SysConfigImplement();
            if (this.lblCodigo.Text == "")
            {
                oSysConfig.nombre = this.txtNombre.Text;
                oSysConfig.valor = this.txtValor.Text;
                oSysConfig.observacion = this.txtObsevacion.Text;
                oSysConfigImplement.Save(oSysConfig);
            }
            else
            {
                DataGridViewRow row = this.dgvConfig.CurrentRow;
                int id = Convert.ToInt32(row.Cells[0].Value);
                oSysConfig = oSysConfigImplement.Get(id);
                oSysConfig.nombre = this.txtNombre.Text;
                oSysConfig.valor = this.txtValor.Text;
                oSysConfig.observacion = this.txtObsevacion.Text;
                oSysConfigImplement.Update(oSysConfig);
            }
            Deshabilitar();
            this.txtNombre.Text = "";
            this.txtValor.Text = "";
            this.txtObsevacion.Text = "";
            CargarGrid();
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
            this.dgvConfig.Enabled = true;
            this.txtNombre.Text = "";
            this.txtValor.Text = "";
            this.txtObsevacion.Text = "";
            this.gbConfig.Enabled = false;
            this.lblCodigo.Text = "";
            Deshabilitar();
        }

        private void NuevaConfig()
        {
            HabilitarBotones();
            this.txtNombre.Text = "";
            this.txtValor.Text = "";
            this.txtObsevacion.Text = "";
            this.gbConfig.Enabled = true;
            this.lblCodigo.Text = "";
        }

        private void ModificarConfig()
        {
            HabilitarBotones();
            this.gbConfig.Enabled = true;
            sys_configuracion oSysConfig = new sys_configuracion();
            SysConfigImplement oSysConfigImplement = new SysConfigImplement();
            DataGridViewRow row = this.dgvConfig.CurrentRow;
            int id = Convert.ToInt32(row.Cells[0].Value);
            oSysConfig = oSysConfigImplement.Get(id);
            this.lblCodigo.Text = oSysConfig.id_configuracion.ToString();
            this.txtNombre.Text = oSysConfig.nombre;
            this.txtValor.Text = oSysConfig.valor;
            this.txtObsevacion.Text = oSysConfig.observacion;
            this.dgvConfig.Enabled = false;
        }

        private void CargarGrid()
        {
            SysConfigImplement oSysConfigImplement = new SysConfigImplement();
            this.dgvConfig.DataSource = oSysConfigImplement.Buscar("");
            this.dgvConfig.Enabled = true;
        }

     
        #endregion

   
  

     

    }
}
