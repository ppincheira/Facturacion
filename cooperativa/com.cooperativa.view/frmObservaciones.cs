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
    public partial class frmObservaciones : Form
    {

        #region << PROPIEDADES >>

        int _idSocio;
        string _user;
        bool _eliminoC;
        bool _eliminoPJ;
        #endregion
        
        #region << EVENTOS >>
       
        public frmObservaciones(string usuario, int idSocio)
        {
            InitializeComponent();
            _idSocio = idSocio;
            _user = usuario;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmObservaciones_Load(object sender, EventArgs e)
        {
            Inicializar();
            _eliminoC = false;
            _eliminoPJ = false;
        }

        #region Event-Observaciones
 

        private void btnAgregarObservaciones_Click(object sender, EventArgs e)
        {
            AgregarNota();
        }
        private void btnDesbloquear_Click(object sender, EventArgs e)
        {
            if (btnDesbloquear.Text == "Desbloquear edición")
                DesbloquearEdicion();
            else
                BloquearEdicion();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarObservaciones();
            BloquearEdicion();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            GuardarNota();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CancelarNota();
        }

        #endregion

   

        #region Event-ProcesoJudicial

        private void btnPJNuevo_Click(object sender, EventArgs e)
        {
            NuevoProcesoJudicial();
        }

        private void btnPJModificar_Click(object sender, EventArgs e)
        {
            ModificarProcesoJudicial();
        }

        private void btnPJEliminar_Click(object sender, EventArgs e)
        {
            EliminarProcesoJudicial();
        }

        private void btnPJImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnPJAceptar_Click(object sender, EventArgs e)
        {
            GuardarProcesoJudicial();
        }

       
        private void dgvPJProceso_SelectionChanged(object sender, EventArgs e)
        {
            CargarSeleccionProcesoJudicial();
        }
  
        #endregion


        #region Event-CODENE
        private void btnCONuevo_Click(object sender, EventArgs e)
        {
            NuevoCodene();
        }

        private void btnCOModificar_Click(object sender, EventArgs e)
        {
            ModificarCodene();
        }

        private void btnCOEliminar_Click(object sender, EventArgs e)
        {
            EliminarCodene();
        }

        private void btnCOImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnCOCancelar_Click(object sender, EventArgs e)
        {
            CancelarCodene();
        }


        private void dgvCOCodene_SelectionChanged(object sender, EventArgs e)
        {
            CargarSeleccionCodene();
        }

        private void btnCoAceptar_Click(object sender, EventArgs e)
        {
            GuardarCodene();
        }


        #endregion  
        #endregion

        #region << METODOS >>
        private void Inicializar()
        {
            this.panelAdd.Visible = false;
            BloquearEdicion();
            CargarObservaciones();
            CargarEstudio();
            CargarEstado();

            DeshabilitarCodene();
            LimpiarCodene();
            CargarGridCodene();

            cargarGrillaPJ();

        }

        #region <Observaciones>

        private void CargarObservaciones()
        {
            SocioImplement oSocioImplement = new SocioImplement();
            socios oSocios = new socios();
            oSocios = oSocioImplement.Get(_idSocio);
            txtObservaciones.Text = oSocios.observaciones;
        }

        private void CancelarNota() {
            this.txtNuevaNota.Text = "";
            this.panelAdd.Visible = false;
        }

        private void DesbloquearEdicion() {
            this.txtObservaciones.Enabled = true;
            btnDesbloquear.Text = "Bloquear edición";
        }

        private void BloquearEdicion()
        {
            this.txtObservaciones.Enabled = false;
            btnDesbloquear.Text = "Desbloquear edición";
        }

        private void CargarEstudio() {
            EstudioImplement oEstudioImplement = new EstudioImplement();
            oEstudioImplement.CargarCombo(this.cmbPJEstudio, "Seleccione Estudio");
        }

        private void CargarEstado(){
            EstadoPJImplement oEstadoPJImplement = new EstadoPJImplement();
            oEstadoPJImplement.CargarCombo(this.cmbPJEstado, "Seleccione Estado");

        }
        private void AgregarNota() {
            this.panelAdd.Visible = true;
            this.txtObservaciones.Enabled = false;
        }

        private void GuardarNota() { 
        
            this.txtObservaciones.Text=this.txtObservaciones.Text + "[" + _user + " " +
            DateTime.Now + " " +  "]: " + this.txtNuevaNota.Text + "\r\n";
            this.txtNuevaNota.Text = "";
            this.panelAdd.Visible = false;
        }

        private void GuardarObservaciones() {

            SocioImplement oSocioImplement = new SocioImplement();
            socios oSocio = new socios();
            oSocio = oSocioImplement.Get(_idSocio);
            oSocio.observaciones = this.txtObservaciones.Text;
            oSocioImplement.Update(oSocio);
            
        }
        #endregion

        #region <ProcesoJudicial>
    

        private void cargarGrillaPJ() {
            ProcesoJudicialImplement oProcesoJudicialImplement = new ProcesoJudicialImplement();
            this.dgvPJProceso.DataSource = oProcesoJudicialImplement.GetByIdSocioDT(_idSocio);
            this.dgvPJProceso.Enabled = true;
            _eliminoPJ = false;
        }

        private void CargarSeleccionProcesoJudicial()
        {
            if (!_eliminoPJ)
            {
                proceso_judicial oProcesoJudicial = new proceso_judicial();
                ProcesoJudicialImplement oProcesoJudicialImplement = new ProcesoJudicialImplement();
                DataGridViewRow row = this.dgvPJProceso.CurrentRow;
                int id = Convert.ToInt32(row.Cells[0].Value);
                oProcesoJudicial = oProcesoJudicialImplement.Get(id);
                this.lblPJCodigo.Text = oProcesoJudicial.id_proceso_judicial.ToString();
                this.cmbPJEstudio.SelectedValue = oProcesoJudicial.id_Estudio;
                this.cmbPJEstado.SelectedValue = oProcesoJudicial.estado;
                this.dtpFecha.Text = oProcesoJudicial.fechaAlta.ToString();
                this.dtpFechaResolucion.Text = oProcesoJudicial.fechaResolucion.ToString();
                this.gbProcesoJudicial.Enabled = false;
                Deshabilitar();
            }
        }

        private void GuardarProcesoJudicial()
        {
            proceso_judicial oProcesoJudicial = new proceso_judicial();
            ProcesoJudicialImplement oProcesoJudicialImplement = new ProcesoJudicialImplement();
            if (this.lblPJCodigo.Text == "")
            {
                oProcesoJudicial.id_Estudio = int.Parse(this.cmbPJEstudio.SelectedValue.ToString());
                oProcesoJudicial.id_Socio = _idSocio;
                oProcesoJudicial.fechaAlta = this.dtpFecha.Value;
                oProcesoJudicial.estado = int.Parse(this.cmbPJEstado.SelectedValue.ToString());
                oProcesoJudicial.fechaResolucion = this.dtpFechaResolucion.Value;
                oProcesoJudicialImplement.Save(oProcesoJudicial);
            }
            else
            {
                DataGridViewRow row = this.dgvPJProceso.CurrentRow;
                int id = Convert.ToInt32(row.Cells[0].Value);
                oProcesoJudicial = oProcesoJudicialImplement.Get(id);
                oProcesoJudicial.id_Estudio = int.Parse(this.cmbPJEstudio.SelectedValue.ToString());
                oProcesoJudicial.id_Socio = _idSocio;
                oProcesoJudicial.fechaAlta = this.dtpFecha.Value;
                oProcesoJudicial.estado = int.Parse(this.cmbPJEstado.SelectedValue.ToString());
                oProcesoJudicial.fechaResolucion = this.dtpFechaResolucion.Value;
                oProcesoJudicialImplement.Update(oProcesoJudicial);
                
            }
            Deshabilitar();
            LimpiarPJ();
            cargarGrillaPJ();
        }

        private void LimpiarPJ() {
            this.cmbPJEstado.SelectedValue = "0";
            this.cmbPJEstudio.SelectedValue = "0";
            this.dtpFecha.Text = "";
            this.dtpFechaResolucion.Text = "";
            this.lblPJCodigo.Text = "";
        
        }

        private void HabilitarBotones()
        {
            this.btnPJAceptar.Enabled = true;
            this.btnPJCancelar.Enabled = true;
            this.tsMenuPJ.Enabled = false;
        }
       
        private void Deshabilitar()
        {
            this.btnPJCancelar.Enabled = false;
            this.btnPJAceptar.Enabled = false;
            this.tsMenuPJ.Enabled = true;

        }
        private void Cancelar()
        {
            this.dgvPJProceso.Enabled = true;
            LimpiarPJ();
            this.gbProcesoJudicial.Enabled = false;
            Deshabilitar();
        }

        private void NuevoProcesoJudicial()
        {
            HabilitarBotones();
            LimpiarPJ();
            this.gbProcesoJudicial.Enabled = true;
        }

        private void ModificarProcesoJudicial()
        {
            HabilitarBotones();
            this.gbProcesoJudicial.Enabled = true;
            proceso_judicial oProcesoJudicial = new proceso_judicial();
            ProcesoJudicialImplement oProcesoJudicialImplement = new ProcesoJudicialImplement();
            DataGridViewRow row = this.dgvPJProceso.CurrentRow;
            int id = Convert.ToInt32(row.Cells[0].Value);
            oProcesoJudicial = oProcesoJudicialImplement.Get(id);
            this.lblPJCodigo.Text = oProcesoJudicial.id_proceso_judicial.ToString();
            this.cmbPJEstudio.SelectedValue = oProcesoJudicial.id_Estudio;
            this.cmbPJEstado.SelectedValue = oProcesoJudicial.estado;
            this.dtpFecha.Text = oProcesoJudicial.fechaAlta.ToString();
            this.dtpFechaResolucion.Text = oProcesoJudicial.fechaResolucion.ToString();
            this.dgvPJProceso.Enabled = false;
        }

        //private void CargarGrid()
        //{
        //    ProcesoJudicialImplement oProcesoJudicialImplement = new ProcesoJudicialImplement();
        //    this.dgvPJProceso.DataSource = oProcesoJudicialImplement.GetAll();
        //    this.dgvPJProceso.Enabled = true;
        //}

        private void EliminarProcesoJudicial()
        {
            if (this.dgvPJProceso.CurrentRow != null)
            {
                _eliminoPJ = true;
                DataGridViewRow row = this.dgvPJProceso.CurrentRow;
                int id = Convert.ToInt32(row.Cells[0].Value);
                ProcesoJudicialImplement oProcesoJudicialImplement = new ProcesoJudicialImplement();
                oProcesoJudicialImplement.Delete(id);
                Deshabilitar();
                LimpiarPJ();
                _eliminoPJ = true;
                cargarGrillaPJ();
            }

        }

        #endregion

        #region <Codene>

        private void cargarGrillaCodene()
        {
            CodeneImplement oCodeneImplement = new CodeneImplement();
            this.dgvCOCodene.DataSource = oCodeneImplement.GetByIdSocio(_idSocio);
            this.dgvPJProceso.Enabled = false;
        }

        private void CargarSeleccionCodene()
        {
            if (!_eliminoC)
            {
                codene oCodene = new codene();
                CodeneImplement oCodeneImplement = new CodeneImplement();
                DataGridViewRow row = this.dgvCOCodene.CurrentRow;
                int id = Convert.ToInt32(row.Cells[0].Value);
                oCodene = oCodeneImplement.Get(id);

                this.lblCOCodigo.Text = oCodene.id_codene.ToString();
                this.dtpCoFechaAlta.Text = oCodene.fechaAlta.ToString();
                this.dtpCOFechaResolucion.Text = oCodene.FechaBaja.ToString();
                this.gbCodene.Enabled = false;
                DeshabilitarCodene();
            }
        }

        private void GuardarCodene()
        {
            codene oCodene = new codene();
            CodeneImplement oCodeneImplement = new CodeneImplement();
            if (this.lblCOCodigo.Text == "")
            {

                oCodene.fechaAlta = dtpCoFechaAlta.Value;
                oCodene.FechaBaja = dtpCOFechaResolucion.Value;
                oCodene.id_socio = _idSocio;
                oCodeneImplement.Save(oCodene);
            }
            else
            {
                DataGridViewRow row = this.dgvCOCodene.CurrentRow;
                int id = Convert.ToInt32(row.Cells[0].Value);
                oCodene = oCodeneImplement.Get(id);
                oCodene.id_socio = _idSocio;
                oCodene.fechaAlta = dtpCoFechaAlta.Value;
                oCodene.FechaBaja = dtpCOFechaResolucion.Value;
                oCodeneImplement.Update(oCodene);

            }
            DeshabilitarCodene();
            LimpiarCodene();
            CargarGridCodene();
        }

        private void EliminarCodene()
        {
            if (this.dgvCOCodene.CurrentRow != null)
            {
                _eliminoC = true;
                DataGridViewRow row = this.dgvCOCodene.CurrentRow;
                int id = Convert.ToInt32(row.Cells[0].Value);
                CodeneImplement oCodeneImplement = new CodeneImplement();
                
                oCodeneImplement.Delete(id);
                DeshabilitarCodene();
                LimpiarCodene();
                
                CargarGridCodene();
            }
            
        }


        private void LimpiarCodene()
        {

            this.dtpCoFechaAlta.Text = "";
            this.dtpCOFechaResolucion.Text = "";
            this.lblCOCodigo.Text = "";

        }
        private void HabilitarBotonesCO()
        {
            this.btnCoAceptar.Enabled = true;
            this.btnCOCancelar.Enabled = true;
            this.tsMenuCodene.Enabled = false;
        }
        private void DeshabilitarCodene()
        {
            this.btnCOCancelar.Enabled = false;
            this.btnCoAceptar.Enabled = false;
            this.tsMenuCodene.Enabled = true;

        }
        private void CancelarCodene()
        {
            this.dgvCOCodene.Enabled = true;
            LimpiarCodene();
            this.gbCodene.Enabled = false;
            DeshabilitarCodene();
        }

        private void NuevoCodene()
        {
            HabilitarBotonesCO();
            LimpiarCodene();
            this.gbCodene.Enabled = true;
        }

        private void ModificarCodene()
        {
            HabilitarBotonesCO();
            this.gbCodene.Enabled = true;
            codene oCodene = new codene();
            CodeneImplement oCodeneImplement = new CodeneImplement();
            DataGridViewRow row = this.dgvCOCodene.CurrentRow;
            int id = Convert.ToInt32(row.Cells[0].Value);
            oCodene = oCodeneImplement.Get(id);
            this.lblCOCodigo.Text = oCodene.id_codene.ToString();
            this.dtpCoFechaAlta.Value = oCodene.fechaAlta.Value;
            this.dtpCOFechaResolucion.Value = oCodene.FechaBaja.Value;
            this.dgvCOCodene.Enabled = false;
        }

        private void CargarGridCodene()
        {
             CodeneImplement oCodeneImplement = new CodeneImplement();
             this.dgvCOCodene.DataSource = oCodeneImplement.GetByIdSocio(_idSocio);
             this.dgvCOCodene.Enabled = true;
             _eliminoC = false;
        }

        #endregion

        
        #endregion








    }
}
