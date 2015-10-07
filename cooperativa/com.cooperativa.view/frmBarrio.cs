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
    public partial class frmBarrio : Form
    {
        #region << PROPIEDADES >>
        BarrioImplement oBarrioImplement = new BarrioImplement();
        bool _eliminoBarrio;
        #endregion

        #region << EVENTOS >>
        public frmBarrio()
        {
            InitializeComponent();
        }

        private void frmBarrio_Load(object sender, EventArgs e)
        {
            Inicializar();
            _eliminoBarrio = false;
        }
        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            NuevoBarrio();
        }
        private void tsbModificar_Click(object sender, EventArgs e)
        {
            ModificarBarrio();
        }
        private void toolStripButtonAceptar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }
        private void tsbEliminar_Click(object sender, EventArgs e)
        {
         Eliminar();
        }
        private void tsbImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }
        private void dgvBarrio_SelectionChanged(object sender, EventArgs e)
        {
            CargarSeleccion();
        }        
        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                Guardar();
            }
        }        
        #endregion

        #region << METODOS >>
        private void Inicializar()
        {
            this.txtNombre.Enabled = false;
            CargarGrid();
        }
        private void CargarSeleccion()
        {
            if (!_eliminoBarrio)
            {
                cod_barrios oBarrio = new cod_barrios();
             
                DataGridViewRow row = this.dgvBarrio.CurrentRow;
                int id = Convert.ToInt32(row.Cells[0].Value);
                oBarrio = oBarrioImplement.Get(id);

                this.lblCodigo.Text = oBarrio.id_barrio.ToString();
                this.txtNombre.Text = oBarrio.barrio;
                this.txtNombre.Enabled = false;
                Deshabilitar();
            }
        }
        private void CargarGrid()
        {
            this.dgvBarrio.DataSource = oBarrioImplement.Buscar("");
            this.dgvBarrio.Enabled = true;
            _eliminoBarrio = false;
        }       
       
        private void Guardar()
        {
            cod_barrios oBarrio = new cod_barrios();

            if (this.lblCodigo.Text == "")
            {
                oBarrio.barrio = this.txtNombre.Text;
                oBarrioImplement.Save(oBarrio);
            }
            else
            {

                DataGridViewRow row = this.dgvBarrio.CurrentRow;
                int id = Convert.ToInt32(row.Cells[0].Value);
                oBarrio = oBarrioImplement.Get(id);
                oBarrio.barrio = this.txtNombre.Text;
                oBarrioImplement.Update(oBarrio);
            }
            Deshabilitar();
            Limpiar();
            CargarGrid();

        }
        private void Cancelar()
        {
            this.dgvBarrio.Enabled = true;
            Limpiar();
            Deshabilitar();
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

        private void NuevoBarrio()
        {
            HabilitarBotones();
            Limpiar();            
            this.txtNombre.Enabled = true;
            this.txtNombre.Focus();
        }
        private void ModificarBarrio()
        {
            HabilitarBotones();
            this.txtNombre.Enabled = true;
            cod_barrios oBarrio = new cod_barrios();

            DataGridViewRow row = this.dgvBarrio.CurrentRow;
            int id = Convert.ToInt32(row.Cells[0].Value);
            oBarrio = oBarrioImplement.Get(id);
           
            this.lblCodigo.Text = oBarrio.id_barrio.ToString();
            this.txtNombre.Text = oBarrio.barrio;
            this.dgvBarrio.Enabled = false;
        }
        private void Imprimir()
        {
          //XX  BarrioImplement oBarrioImplement = new BarrioImplement();
            SysConfigImplement oSysConfigImplement = new SysConfigImplement();
            Reportes.frmReportes frmRpt = new Reportes.frmReportes();
            Reportes.rptBarrios rpt = new Reportes.rptBarrios();
            //Cargo el Data Set
            DataSet ds = new DataSet("Generico");
            ds.Tables.Add(oSysConfigImplement.GetEncabezadoDT("Encabezado"));
            ds.Tables[0].TableName = "dtEncabezado";
            ds.Tables.Add(oBarrioImplement.GetByBarrioDT(""));
            ds.Tables[1].TableName = "dtBarrios";
            rpt.SetDataSource(ds);
            frmRpt.crvGenerico.ReportSource = rpt;
            frmRpt.Show();
        }
        private void Eliminar()
        {
            if (this.dgvBarrio.CurrentRow != null)
            {
                _eliminoBarrio = true;
                DataGridViewRow row = this.dgvBarrio.CurrentRow;
                int id = Convert.ToInt32(row.Cells[0].Value);
              //XX  BarrioImplement oBarrioImplement = new BarrioImplement();

                oBarrioImplement.Delete(id);

                Limpiar();

                CargarGrid();
            }
        }
        private void Limpiar() {
            this.txtNombre.Text = "";
            this.txtNombre.Enabled = false;
            this.lblCodigo.Text = "";
        }        
        #endregion
    }
}
