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
    public partial class frmIntimacion : Form
    {
        #region << PROPIEDADES >>
        int _idSocio;
        #endregion
        #region << EVENTOS >>
        public frmIntimacion(int idSocio)
        {
            InitializeComponent();
            _idSocio = idSocio;
        }
        private void frmIntimacion_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Tenga en cuenta que la marca de socio intimado debe quitarse unicamente cuando el socio haya"
                + Environment.NewLine +  " regularizado su situación con la cooperativa." + Environment.NewLine + Environment.NewLine 
                + " Quitar la marca de intimado no elimina el historial de intimaciones." + Environment.NewLine + Environment.NewLine 
                + " Está seguro que desea quitar la marca de entimado al socio ?", "Quitando Marca",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                QuitarMarca();

          
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevaIntimacion();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CancelarAdd();
        }

        private void mCalendarFecha_DateChanged(object sender, DateRangeEventArgs e)
        {
            this.txtFecha.Text = mCalendarFecha.SelectionEnd.ToShortDateString();
        }

        #endregion

        #region << METODOS >>


        private void Inicializar() {
            TipoIntimacionImplement oTipoIntimacionImplement = new TipoIntimacionImplement();
            oTipoIntimacionImplement.CargarCombo(this.cmbTipoIntimacion, "Seleccione Tipo Intimación");
            CargarGrilla(_idSocio);
            this.panelAdd.Visible = false;
        }

        private void CancelarAdd()
        {
            this.cmbTipoIntimacion.SelectedValue = 0;
            this.txtFecha.Text = "";
            this.panelAdd.Visible = false;
        }

        private void CargarGrilla(int idSocio) {
            IntimacionImplement oIntimacionImplement = new IntimacionImplement();
            this.dgvIntimacion.DataSource = oIntimacionImplement.GetByidSocioDT(idSocio);
        }

        private void NuevaIntimacion() {

            this.panelAdd.Visible = true;
        }

        private void Guardar() {
            intimacion oIntimacion = new intimacion();
            IntimacionImplement oIntimacionImplement = new IntimacionImplement();
            string Mensaje;
            Mensaje = "";
            if (this.txtFecha.Text.Length == 0) { Mensaje += "Falta ingresar fecha." + Environment.NewLine; };
            if (int.Parse(cmbTipoIntimacion.SelectedValue.ToString()) == 0) { Mensaje += "Falta tipo de intimacion." + Environment.NewLine; };

            if (Mensaje.Length > 0)
            {
                frmVentanaInformativa ofrmVentanaInformativa = new frmVentanaInformativa(Mensaje);
                ofrmVentanaInformativa.ShowDialog();
            }
            else
            {
                oIntimacion.fecha = DateTime.Parse(this.txtFecha.Text);
                oIntimacion.id_socio = _idSocio;
                oIntimacion.tipo = int.Parse(this.cmbTipoIntimacion.SelectedValue.ToString());
                oIntimacionImplement.Save(oIntimacion);
                CargarGrilla(_idSocio);
                this.panelAdd.Visible = false;
                //Asigno Marca para el Socio
                socios_varios oSocioVarios = new socios_varios();
                SocioVariosImplement oSocioVarioImplement = new SocioVariosImplement();
                oSocioVarios = oSocioVarioImplement.Get(_idSocio);
                oSocioVarios.intimado = true;
                oSocioVarioImplement.Update(oSocioVarios);
                this.panelAdd.Visible = false;
            }
            
            
            
        }

        private void QuitarMarca() {
            socios_varios oSocioVarios = new socios_varios();
            SocioVariosImplement oSocioVarioImplement = new SocioVariosImplement();
            oSocioVarios = oSocioVarioImplement.Get(_idSocio);
            oSocioVarios.intimado = false;
            oSocioVarioImplement.Update(oSocioVarios);
            this.panelAdd.Visible = false;
        }

        #endregion
    }
}
