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
    public partial class frmConcepto : Form
    {
        #region << PROPIEDADES >>
        ConceptoImplement oConceptoImplement = new ConceptoImplement();
        private bool _elimino;
        #endregion

        #region << EVENTOS >>
        public frmConcepto()
        {
            InitializeComponent();
        }

        private void frmConcepto_Load(object sender, EventArgs e)
        {
            Inicializar();
        }        
        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            NuevoConcepto();
        }
        private void tsbModificar_Click(object sender, EventArgs e)
        {
            ModificarConcepto();
        }
        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
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
            this.gbDatos.Enabled = false;
            CargarGrid();
        }
        private void CargarSeleccion()
        {
            if (!_elimino)
            {
                cod_conceptos oConceptos = new cod_conceptos();

                DataGridViewRow row = this.dgvConceptos.CurrentRow;
                int id = Convert.ToInt32(row.Cells[0].Value);
                oConceptos = oConceptoImplement.Get(id);

                //ver los atributos y cargarlos
                this.lblCodigo.Text = oConceptos.id_concepto.ToString();
                this.txtDescripcion.Text = oConceptos.concepto;
                this.txtDescripcion.Enabled = false;

                //this.txtDuracion.Text= oConceptos.?
                this.txtVariable.Text = oConceptos.variable.ToString();
                //this.txtVigenciaDesde.Text = oConceptos.?
                this.chkAplicaCargo.Checked = (bool) oConceptos.aplicar_recargo;
                this.chkAplicaIva.Checked = (bool)oConceptos.aplicar_iva;
                this.chkAplicaDescuento.Checked = (bool)oConceptos.aplicar_descuento;
                 
                //this.cmbAplicacion.SelectedValue = oConceptos.¿?
                //this.cmbEstado.SelectedValue = oConceptos.?
                this.cmbFormula.SelectedValue = oConceptos.id_formula;
                this.cmbSigno.SelectedValue = oConceptos.tipo_signo;
                                
                DeshabilitarBotones();
            }
        }
        private void CargarGrid()
        {
            this.dgvConceptos.DataSource = oConceptoImplement.Buscar("");
            this.dgvConceptos.Enabled = true;
            _elimino = false;
        }
        
        private void Guardar()
        {
            cod_conceptos oConceptos = new cod_conceptos();
            ConceptoImplement oConceptoImplement = new ConceptoImplement();
            if (this.lblCodigo.Text == "")
            {
                
                oConceptos.concepto = this.txtDescripcion.Text;
                
                oConceptos.id_formula = this.cmbFormula.SelectedIndex;
                oConceptos.variable = Decimal.Parse(this.txtVariable.Text);
                //oConceptos. = this.cmbAplicacion.SelectedIndex;
                //oConceptos. = this.txtVigenciaDesde.Text;
                //oConceptos. = this.cmbEstado.SelectedIndex;
                oConceptos.tipo_signo = this.cmbSigno.SelectedIndex;
                //oConceptos. = this.txtDuracion.Text;

                oConceptos.aplicar_iva = this.chkAplicaIva.Checked;
                oConceptos.aplicar_recargo = this.chkAplicaCargo.Checked;
                oConceptos.aplicar_descuento = this.chkAplicaDescuento.Checked;

                oConceptoImplement.Save(oConceptos);
            }
            else
            {
                DataGridViewRow row = this.dgvConceptos.CurrentRow;
                int id = Convert.ToInt32(row.Cells[0].Value);
                oConceptos = oConceptoImplement.Get(id);
            //    oCalle.calle = this.txtNombre.Text;
            //    oCalle.normalizado = this.txtNormalizado.Text;

                oConceptoImplement.Update(oConceptos);
            }
            DeshabilitarBotones();
            Limpiar();
            CargarGrid();
        }
        private void Cancelar()
        {
            Limpiar();
            DeshabilitarBotones();
            this.gbDatos.Enabled = false;
            this.dgvConceptos.Enabled = true;
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
        private void DeshabilitarBotones()
        {
            this.tsbAceptar.Enabled = false;
            this.tsbCancelar.Enabled = false;

            this.tsbNuevo.Enabled = true;
            this.tsbModificar.Enabled = true;
            this.tsbEliminar.Enabled = true;
            this.tsbImprimir.Enabled = true;
        }
      
        private void NuevoConcepto()
        {
            HabilitarBotones();
            this.gbDatos.Enabled = true;
            this.txtDescripcion.Enabled = true;

            Limpiar();
            this.dgvConceptos.Enabled = false;
        }
        private void ModificarConcepto()
        {
            HabilitarBotones();
            this.gbDatos.Enabled = true;
            cod_conceptos oConceptos = new cod_conceptos();
            ConceptoImplement oConceptoImplement = new ConceptoImplement();
            DataGridViewRow row = this.dgvConceptos.CurrentRow;
            
            int id = Convert.ToInt32(row.Cells[0].Value);
            oConceptos = oConceptoImplement.Get(id);

            this.lblCodigo.Text = oConceptos.id_concepto.ToString();

            //this.txtDescripcion.Text = oConceptos.concepto.ToString();
            //this.txtDescripcion.Enabled = false;

            //this.cmbFormula.SelectedIndex = -1;
            //this.txtVariable.Text = oConceptos.variable.ToString();
            //this.cmbAplicacion.SelectedIndex = -1;
            //this.txtVigenciaDesde.Text = string.Empty;
            //this.cmbEstado.SelectedIndex = -1;
            //this.cmbSigno.SelectedIndex = -1;
            //this.txtDuracion.Text = string.Empty;

            //this.chkAplicaIva.Checked = (bool) oConceptos.aplicar_iva;
            //this.chkAplicaCargo.Checked = (bool)oConceptos.aplicar_recargo;
            //this.chkAplicaDescuento.Checked = (bool)oConceptos.aplicar_descuento;

            //this.dgvConceptos.Enabled = false;
        }
        private void Eliminar()
        {
            //if (this.dgvBarrio.CurrentRow != null)
            //{
            //    _eliminoBarrio = true;
            //    DataGridViewRow row = this.dgvBarrio.CurrentRow;
            //    int id = Convert.ToInt32(row.Cells[0].Value);
            //    oBarrioImplement.Delete(id);

            //    Limpiar();

            //    CargarGrid();
            //}
        }
        private void Imprimir()
        {
        //    //XX  BarrioImplement oBarrioImplement = new BarrioImplement();
        //    SysConfigImplement oSysConfigImplement = new SysConfigImplement();
        //    Reportes.frmReportes frmRpt = new Reportes.frmReportes();
        //    Reportes.rptBarrios rpt = new Reportes.rptBarrios();
        //    //Cargo el Data Set
        //    DataSet ds = new DataSet("Generico");
        //    ds.Tables.Add(oSysConfigImplement.GetEncabezadoDT("Encabezado"));
        //    ds.Tables[0].TableName = "dtEncabezado";
        //    ds.Tables.Add(oBarrioImplement.GetByBarrioDT(""));
        //    ds.Tables[1].TableName = "dtBarrios";
        //    rpt.SetDataSource(ds);
        //    frmRpt.crvGenerico.ReportSource = rpt;
        //    frmRpt.Show();
        }
        private void Limpiar()
        {
            this.txtDescripcion.Text = "";
            this.lblCodigo.Text = "";

            this.txtDescripcion.Text = string.Empty;
            this.cmbFormula.SelectedIndex = -1;
            this.txtVariable.Text = string.Empty;
            this.cmbAplicacion.SelectedIndex=-1;
            this.txtVigenciaDesde.Text=string.Empty;
            this.cmbEstado.SelectedIndex = -1;
            this.cmbSigno.SelectedIndex = -1;
            this.txtDuracion.Text=string.Empty;

            this.chkAplicaIva.Checked = false;
            this.chkAplicaCargo.Checked = false;
            this.chkAplicaDescuento.Checked = false;
        }        
        #endregion

    }
}
