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
    public partial class frmCuentaCorriente : Form
    {



        #region << PROPIEDADES >>

        int _idSocio;
        string _user;
        #endregion
        #region << EVENTOS >>

        public frmCuentaCorriente(string usuario, int idSocio)
        {
            InitializeComponent();
            _idSocio = idSocio;
            _user = usuario;
        }

        private void frmCuentaCorriente_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        #endregion

        #region << EVENTOS >>

        private void Inicializar()
        {
            socios oSocio = new socios();
            SocioImplement oSocioImplement = new SocioImplement();
            oSocio = oSocioImplement.Get(_idSocio);
            this.mtxtNumero.Text = oSocio.codigo_socio + "-" + oSocio.subcodigo_socio;
            this.txtNombre.Text = oSocio.nombre;
            CargarGrilla();
        }

        private void CargarGrilla()
        {

            CuentaCorrienteImplement oCuentasCorrientesImplement = new CuentaCorrienteImplement();
            this.dgvCuentas.DataSource = oCuentasCorrientesImplement.GetByIdSocio(_idSocio);
        }

        #endregion
    }
}
