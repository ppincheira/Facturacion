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
    public partial class frmTipoDocumento : Form
    {
        public frmTipoDocumento()
        {
            InitializeComponent();
        }
        #region << EVENTOS >>

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            NuevoDocumento();
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            ModificarDocumento();
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



        private void dgvDocumento_SelectionChanged(object sender, EventArgs e)
        {
            CargarSeleccion();
        }

        private void frmTipoDocumento_Load(object sender, EventArgs e)
        {
            Inicializar();
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
            cod_documentos oDocumento = new cod_documentos();
            DocumentoImplement oDocumentoImplement = new DocumentoImplement();

            DataGridViewRow row = this.dgvDocumento.CurrentRow;
            int id = Convert.ToInt32(row.Cells[0].Value);
            oDocumento = oDocumentoImplement.Get(id);
            this.lblCodigo.Text = oDocumento.id_documento.ToString();
            this.txtNombre.Text = oDocumento.documento;
            this.txtNombre.Enabled = false;
            Deshabilitar();
        }

        private void Guardar()
        {

            DocumentoImplement oDocumentoImplement = new DocumentoImplement();
            cod_documentos oDocumento = new cod_documentos();

            if (this.lblCodigo.Text == "")
            {
                oDocumento.documento = this.txtNombre.Text;
                oDocumentoImplement.Save(oDocumento);
            }
            else
            {

                DataGridViewRow row = this.dgvDocumento.CurrentRow;
                int id = Convert.ToInt32(row.Cells[0].Value);
                oDocumento = oDocumentoImplement.Get(id);
                oDocumento.documento = this.txtNombre.Text;
                oDocumentoImplement.Update(oDocumento);
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
            this.dgvDocumento.Enabled = true;
            this.txtNombre.Text = "";
            this.txtNombre.Enabled = false;
            this.lblCodigo.Text = "";
            Deshabilitar();
        }

        private void NuevoDocumento()
        {
            HabilitarBotones();
            this.txtNombre.Text = "";
            this.txtNombre.Enabled = true;
            this.lblCodigo.Text = "";
        }

        private void ModificarDocumento()
        {
            HabilitarBotones();
            this.txtNombre.Enabled = true;

            cod_documentos oDocumento = new cod_documentos();
            DocumentoImplement oDocumentoImplement = new DocumentoImplement();
            DataGridViewRow row = this.dgvDocumento.CurrentRow;
            int id = Convert.ToInt32(row.Cells[0].Value);
            oDocumento = oDocumentoImplement.Get(id);
            this.lblCodigo.Text = oDocumento.id_documento.ToString();
            this.txtNombre.Text = oDocumento.documento;
            this.dgvDocumento.Enabled = false;
        }
        private void CargarGrid()
        {
            DocumentoImplement oDocumentoImplement = new DocumentoImplement();
            this.dgvDocumento.DataSource = oDocumentoImplement.Buscar("");
            this.dgvDocumento.Enabled = true;

        }
        #endregion



    }
}
