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
    public partial class frmMediciones : Form
    {
        #region << PROPIEDADES >>

        int _idSocio;

        #endregion

        #region << EVENTOS >>

        public frmMediciones(int idSocio)
        {
            InitializeComponent();
            _idSocio = idSocio;
        }

        private void frmMediciones_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        #endregion

        #region << EVENTOS >>

        private void Inicializar()
        {
            socios oSocio = new socios();
            SocioImplement oSocioImplement = new SocioImplement();
            SocioConexionImplement oSocioConexionImplement = new SocioConexionImplement();
            oSocio = oSocioImplement.Get(_idSocio);
            this.txtCodigoSocio.Text = oSocio.codigo_socio;
            this.txtSubcodigoSocio.Text= oSocio.subcodigo_socio;
            this.txtNombreSocio.Text = oSocio.nombre;
            this.txtMedidor.Text = oSocioConexionImplement.Get(_idSocio).medidor;
            CargarGrilla();
        }

        private void CargarGrilla()
        {

            SocioMedicionImplement oSocioMedicionImplement = new SocioMedicionImplement();
            this.dvMediciones.DataSource = oSocioMedicionImplement.GetByIdSocioDT(_idSocio);
        }

        #endregion
    }
}
