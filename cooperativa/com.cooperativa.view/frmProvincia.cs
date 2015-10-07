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
    public partial class frmProvincia : Form
    {
        #region << EVENTOS >>
        public frmProvincia()
        {
            InitializeComponent();
        }
        private void frmProvincia_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }
        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            NuevoProvincia();
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            ModificarProvincia();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {

        }

        private void tsbImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void dgvProvincia_SelectionChanged(object sender, EventArgs e)
        {
            CargarSeleccion();
        }

        #endregion

        #region << METODOS >>

        private void CargarSeleccion()
        {
            cod_provincias oProvincia = new cod_provincias();
            ProvinciaImplement oProvinciaImplement = new ProvinciaImplement();
            DataGridViewRow row = this.dgvProvincia.CurrentRow;
            int id = Convert.ToInt32(row.Cells[0].Value);
            oProvincia = oProvinciaImplement.Get(id);
            this.lblCodigo.Text = oProvincia.id_provincia.ToString();
            this.txtNombre.Text = oProvincia.provincia;
            this.txtNombre.Enabled = false;
            Deshabilitar();
        }

        private void Guardar()
        {
            ProvinciaImplement oProvinciaImplement = new ProvinciaImplement();
            cod_provincias oProvincia = new cod_provincias();

            if (this.lblCodigo.Text == "")
            {
                oProvincia.provincia = this.txtNombre.Text;
                oProvinciaImplement.Save(oProvincia);
            }
            else
            {

                DataGridViewRow row = this.dgvProvincia.CurrentRow;
                int id = Convert.ToInt32(row.Cells[0].Value);
                oProvincia = oProvinciaImplement.Get(id);
                oProvincia.provincia = this.txtNombre.Text;
                oProvinciaImplement.Update(oProvincia);
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
            this.dgvProvincia.Enabled = true;
            this.txtNombre.Text = "";
            this.txtNombre.Enabled = false;
            this.lblCodigo.Text = "";
            Deshabilitar();
        }

        private void NuevoProvincia()
        {
            HabilitarBotones();
            this.txtNombre.Text = "";
            this.txtNombre.Enabled = true;
            this.lblCodigo.Text = "";
        }

        private void ModificarProvincia()
        {
            HabilitarBotones();
            this.txtNombre.Enabled = true;
          
            cod_provincias oProvincia=new cod_provincias();
            ProvinciaImplement oProvinciaImplement=new ProvinciaImplement();

            DataGridViewRow row = this.dgvProvincia.CurrentRow;
            int id = Convert.ToInt32(row.Cells[0].Value);
            oProvincia=oProvinciaImplement.Get(id);
            this.lblCodigo.Text = oProvincia.id_provincia.ToString();
            this.txtNombre.Text = oProvincia.provincia;
            this.dgvProvincia.Enabled = false;
        }

        private void CargarGrid()
        {
            ProvinciaImplement oProvinciaImplement = new ProvinciaImplement();
            this.dgvProvincia.DataSource = oProvinciaImplement.Buscar("");
            this.dgvProvincia.Enabled = true;
        }


        private void Imprimir()
        {
            ProvinciaImplement oProvinciaImplement = new ProvinciaImplement();
            SysConfigImplement oSysConfigImplement = new SysConfigImplement();
            Reportes.frmReportes frmRpt = new Reportes.frmReportes();
            Reportes.rptProvincias rpt = new Reportes.rptProvincias();
            //Cargo el Data Set
            DataSet ds = new DataSet("Generico");
            ds.Tables.Add(oSysConfigImplement.GetEncabezadoDT("Encabezado"));
            ds.Tables[0].TableName = "dtEncabezado";
            ds.Tables.Add(oProvinciaImplement.GetByProvinciaDT(""));
            ds.Tables[1].TableName = "dtProvincias";
            rpt.SetDataSource(ds);
            frmRpt.crvGenerico.ReportSource = rpt;
            frmRpt.Show();
        }

        #endregion





    }
}
