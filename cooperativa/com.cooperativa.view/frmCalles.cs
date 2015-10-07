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
    public partial class frmCalles : Form
    {
        #region << EVENTOS >>
        public frmCalles()
        {
            InitializeComponent();
        }

        private void frmCalles_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            NuevaCalle();
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            ModificarCalle();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {

        }

        private void tsbImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void tsbAceptar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void dgvCalle_SelectionChanged(object sender, EventArgs e)
        {
            CargarSeleccion();
        }

        #endregion

        #region << METODOS >>
        
        private void Inicializar()
        {
            CargarGrid();
            this.gbCalle.Enabled = false;

        }
        private void CargarSeleccion()
        {
            cod_calles oCalle = new cod_calles();
            CalleImplement oCalleImplement=new CalleImplement();
            DataGridViewRow row = this.dgvCalle.CurrentRow;
            int id = Convert.ToInt32(row.Cells[0].Value);
            oCalle=oCalleImplement.Get(id);

            this.lblCodigo.Text = oCalle.id_calle.ToString();
            this.txtNombre.Text = oCalle.calle;
            this.txtNormalizado.Text = oCalle.normalizado;
            this.gbCalle.Enabled = false;
            Deshabilitar();
        }

        private void Guardar()
        {
            cod_calles oCalle = new cod_calles();
            CalleImplement oCalleImplement = new CalleImplement();
            if (this.lblCodigo.Text == "")
            {
                oCalle.calle = this.txtNombre.Text;
                oCalle.normalizado = this.txtNormalizado.Text;
                oCalleImplement.Save(oCalle);
            }
            else
            {
                DataGridViewRow row = this.dgvCalle.CurrentRow;
                int id = Convert.ToInt32(row.Cells[0].Value);
                oCalle = oCalleImplement.Get(id);
                oCalle.calle = this.txtNombre.Text;
                oCalle.normalizado = this.txtNormalizado.Text;
                oCalleImplement.Update(oCalle);
            }
            Deshabilitar();
            this.txtNombre.Text = "";
            this.txtNormalizado.Text = "";
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
            this.dgvCalle.Enabled = true;
            this.txtNombre.Text = "";
            this.txtNormalizado.Text = "";
            this.gbCalle.Enabled = false;
            this.lblCodigo.Text = "";
            Deshabilitar();
        }

        private void NuevaCalle()
        {
            HabilitarBotones();
            this.txtNombre.Text = "";
            this.txtNormalizado.Text = "";
            this.gbCalle.Enabled = true;
            this.lblCodigo.Text = "";
        }

        private void ModificarCalle()
        {
            HabilitarBotones();
            this.gbCalle.Enabled = true;
            cod_calles oCalle = new cod_calles();
            CalleImplement oCalleImplement = new CalleImplement();
            DataGridViewRow row = this.dgvCalle.CurrentRow;
            int id = Convert.ToInt32(row.Cells[0].Value);
            oCalle = oCalleImplement.Get(id);
            this.lblCodigo.Text = oCalle.id_calle.ToString();
            this.txtNombre.Text = oCalle.calle;
            this.txtNormalizado.Text = oCalle.normalizado;
            this.dgvCalle.Enabled = false;
        }

        private void CargarGrid()
        {
            CalleImplement oCalleImplement = new CalleImplement();
            this.dgvCalle.DataSource = oCalleImplement.Buscar("");
            this.dgvCalle.Enabled = true;
        }

        private void Imprimir() {
            CalleImplement oCalleImplement = new CalleImplement();
            SysConfigImplement oSysConfigImplement = new SysConfigImplement();
            Reportes.frmReportes frmRpt= new Reportes.frmReportes();
            Reportes.rptCalles rpt = new Reportes.rptCalles();
            //Cargo el Data Set
            DataSet ds = new DataSet("Generico");
            ds.Tables.Add(oSysConfigImplement.GetEncabezadoDT("Encabezado"));
            ds.Tables[0].TableName="dtEncabezado";
            ds.Tables.Add(oCalleImplement.GetByNombreDT(""));
            ds.Tables[1].TableName = "dtCalles";
            rpt.SetDataSource(ds);
            frmRpt.crvGenerico.ReportSource = rpt;
            frmRpt.Show();

        }
        #endregion

    }
}
