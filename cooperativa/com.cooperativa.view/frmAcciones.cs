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
    public partial class frmAcciones : Form
    {

        #region << PROPIEDADES >>
        int _idSocio;
        int _idAccion;
        bool _eliminoAccion;
        string _user;
        #endregion

        #region << EVENTOS >>

        public frmAcciones(int idSocio)
        {
            InitializeComponent();
            _idSocio = idSocio;
        }
        

        private void frmAcciones_Load(object sender, EventArgs e)
        {
            Inicializar();
            _eliminoAccion = false;
        }

        private void dgvAcciones_SelectionChanged(object sender, EventArgs e)
        {
            CargarSeleccionSuscripcion();
        }

        private void btnNuevaSuscripcion_Click(object sender, EventArgs e)
        {
            NuevaSuscripcion();
        }

        private void btnModificarSuscripcion_Click(object sender, EventArgs e)
        {
            ModificarSuscripcion();
        }

        private void btnEliminarSuscripcion_Click(object sender, EventArgs e)
        {
            EliminarSuscripcion();
        }

        #endregion
        #region << METODOS >>


        private void Inicializar()
        {
            socios oSocio = new socios();
            SocioImplement oSocioImplement = new SocioImplement();
            oSocio = oSocioImplement.Get(_idSocio);
            this.mtxtNumero.Text = oSocio.codigo_socio + "-" + oSocio.subcodigo_socio;
            this.mtxtNumero.Enabled = false;
            this.txtNombre.Text = oSocio.nombre;
            this.txtNombre.Enabled = false;
            _idAccion = 0;
            CargarGrilla();
        }

        private void CargarGrilla() {
            AccionImplement oAccionImplement=new AccionImplement();
            this.dgvAcciones.DataSource = oAccionImplement.CargarAcciones(_idSocio);
        }

        private void NuevaSuscripcion()
        {
            frmAccionesAM f = new frmAccionesAM(_idSocio);
            f.Text = "Nueva Acción";
            f.ShowDialog();
            CargarGrilla();
        }

        private void ModificarSuscripcion() 
        {
            if (_idAccion != 0)
            {
                frmAccionesAM f = new frmAccionesAM(_idSocio, _idAccion);
                f.Text = "Nueva Acción";
                f.ShowDialog();
                CargarGrilla();
            }
        }

        private void EliminarSuscripcion()
        {
            if (this.dgvAcciones.CurrentRow != null)
            {
                _eliminoAccion = true;
                DataGridViewRow row = this.dgvAcciones.CurrentRow;
                int id = Convert.ToInt32(row.Cells[0].Value);
                AccionImplement oAccionImplement = new AccionImplement();

                oAccionImplement.Delete(id);
                
                CargarGrilla();
            }
        }

        private void CargarSeleccionSuscripcion()
        {
            DataGridViewRow row = this.dgvAcciones.CurrentRow;
           _idAccion = Convert.ToInt32(row.Cells[0].Value);
        }

        #endregion

       


    }
}
