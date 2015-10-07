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
    public partial class frmEstudio : Form
    {
        #region << EVENTOS >>
        public frmEstudio()
        {
            InitializeComponent();
        }
        private void frmEstudio_Load(object sender, EventArgs e)
        {
            Inicializar();
        }
        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            NuevoEstudio();
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            ModificarEstudio();
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

        private void dgvEstudio_SelectionChanged(object sender, EventArgs e)
        {
            CargarSeleccion();
        }
        #endregion

        #region << METODOS >>


        private void Inicializar()
        {
            CargarGrid();
            this.gbEstudio.Enabled = false;

        }
        private void CargarSeleccion()
        {
            cod_estudios oEstudio = new cod_estudios();
            EstudioImplement oEstudioImplement = new EstudioImplement();

            DataGridViewRow row = this.dgvEstudio.CurrentRow;
            int id = Convert.ToInt32(row.Cells[0].Value);
            oEstudio = oEstudioImplement.Get(id);
            this.lblCodigo.Text = oEstudio.id_estudio.ToString();
            this.txtNombre.Text = oEstudio.descripcion;
            this.txtDireccion.Text = oEstudio.direccion;
            this.txtTelefono.Text = oEstudio.telefono;
            this.txtContacto.Text = oEstudio.contacto;
            this.gbEstudio.Enabled = false;
            Deshabilitar();
        }

        private void Guardar()
        {
            cod_estudios oEstudio = new cod_estudios();
            EstudioImplement oEstudioImplement = new EstudioImplement();

            if (this.lblCodigo.Text == "")
            {
                oEstudio.descripcion = this.txtNombre.Text;
                oEstudio.direccion = this.txtDireccion.Text;
                oEstudio.contacto = this.txtContacto.Text;
                oEstudio.telefono = this.txtTelefono.Text;
                oEstudioImplement.Save(oEstudio);
            }
            else
            {
                DataGridViewRow row = this.dgvEstudio.CurrentRow;
                int id = Convert.ToInt32(row.Cells[0].Value);
                oEstudio = oEstudioImplement.Get(id);
                oEstudio.descripcion = this.txtNombre.Text;
                oEstudio.direccion = this.txtDireccion.Text;
                oEstudio.contacto = this.txtContacto.Text;
                oEstudio.telefono = this.txtTelefono.Text;
                oEstudioImplement.Update(oEstudio);

            }
            Deshabilitar();
            Limpiar();
            CargarGrid();
        }

        private void Limpiar() {
            this.lblCodigo.Text = "";
            this.txtNombre.Text = "";
            this.txtDireccion.Text = "";
            this.txtTelefono.Text = "";
            this.txtContacto.Text = "";
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
            this.dgvEstudio.Enabled = true;
            this.txtNombre.Text = "";
            this.gbEstudio.Enabled = false;
            Limpiar();
            Deshabilitar();
        }

        private void NuevoEstudio()
        {
            HabilitarBotones();
            this.gbEstudio.Enabled = true;
            Limpiar();
        }

        private void ModificarEstudio()
        {
            HabilitarBotones();
            this.gbEstudio.Enabled = true;
            cod_estudios oEstudio = new cod_estudios();
            EstudioImplement oEstudioImplement = new EstudioImplement();
            DataGridViewRow row = this.dgvEstudio.CurrentRow;
            int id = Convert.ToInt32(row.Cells[0].Value);
            oEstudio = oEstudioImplement.Get(id);

            this.lblCodigo.Text = oEstudio.id_estudio.ToString();
            this.txtNombre.Text = oEstudio.descripcion;
            this.txtDireccion.Text = oEstudio.direccion;
            this.txtTelefono.Text = oEstudio.telefono;
            this.dgvEstudio.Enabled = false;
        }
        private void CargarGrid()
        {
            EstudioImplement oEstudioImplement = new EstudioImplement();
            this.dgvEstudio.DataSource = oEstudioImplement.Buscar("");
            this.dgvEstudio.Enabled = true;
        }
        #endregion

 
    }
}
