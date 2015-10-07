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
    public partial class frmTipoConexion : Form
    {
        public frmTipoConexion()
        {
            InitializeComponent();
        }
        #region << EVENTOS >>
        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            NuevaConexion();
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            ModificarConexion();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {

        }

        private void tsbImprimir_Click(object sender, EventArgs e)
        {

        }

        private void dgvConexion_SelectionChanged(object sender, EventArgs e)
        {
            CargarSeleccion();
        }

        private void frmTipoConexion_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
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
            cod_conexiones oConexion = new cod_conexiones();
            ConexionImplement oConexionImplement = new ConexionImplement();


            DataGridViewRow row = this.dgvConexion.CurrentRow;
            int id = Convert.ToInt32(row.Cells[0].Value);
            oConexion = oConexionImplement.Get(id);
            this.lblCodigo.Text = oConexion.id_conexion.ToString();
            this.txtNombre.Text = oConexion.conexion;
            this.txtNombre.Enabled = false;
            Deshabilitar();
        }

        private void Guardar()
        {

            ConexionImplement oConexionImplement = new ConexionImplement();
            cod_conexiones oConexion = new cod_conexiones();

            if (this.lblCodigo.Text == "")
            {
                oConexion.conexion = this.txtNombre.Text;
                oConexionImplement.Save(oConexion);
            }
            else
            {

                DataGridViewRow row = this.dgvConexion.CurrentRow;
                int id = Convert.ToInt32(row.Cells[0].Value);
                oConexion = oConexionImplement.Get(id);
                oConexion.conexion = this.txtNombre.Text;
                oConexionImplement.Update(oConexion);
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
            this.dgvConexion.Enabled = true;
            this.txtNombre.Text = "";
            this.txtNombre.Enabled = false;
            this.lblCodigo.Text = "";
            Deshabilitar();
        }

        private void NuevaConexion()
        {
            HabilitarBotones();
            this.txtNombre.Text = "";
            this.txtNombre.Enabled = true;
            this.lblCodigo.Text = "";
        }

        private void ModificarConexion()
        {
            HabilitarBotones();
            this.txtNombre.Enabled = true;
            cod_conexiones oConexion = new cod_conexiones();
            ConexionImplement oConexionImplement = new ConexionImplement();
            DataGridViewRow row = this.dgvConexion.CurrentRow;
            int id = Convert.ToInt32(row.Cells[0].Value);
            oConexion = oConexionImplement.Get(id);
            this.lblCodigo.Text = oConexion.id_conexion.ToString();
            this.txtNombre.Text = oConexion.conexion;
            this.dgvConexion.Enabled = false;
        }

        private void CargarGrid()
        {
            ConexionImplement oConexionImplement = new ConexionImplement();
            this.dgvConexion.DataSource = oConexionImplement.Buscar("");
            this.dgvConexion.Enabled = true;
        }

        #endregion

    }
}
