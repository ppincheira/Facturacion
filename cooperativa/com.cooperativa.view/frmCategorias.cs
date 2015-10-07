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
    public partial class frmCategorias : Form
    {
        #region << EVENTOS >>
        public frmCategorias()
        {
            InitializeComponent();         
        }

        private void dgvCategoria_SelectionChanged(object sender, EventArgs e)
        {
            CargarSeleccion();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            NuevaCategoria();
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            ModificarCategoria();
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

     
        #endregion

        #region << METODOS >>


        private void Inicializar()
        {
            CargarGrid();
            this.gbCategorias.Enabled = false;

        }
        private void CargarSeleccion()
        {
            cod_categorias oCategorias=new cod_categorias();
            CategoriaImplement oCategoriaImplement=new CategoriaImplement();
            DataGridViewRow row = this.dgvCategoria.CurrentRow;
            int id = Convert.ToInt32(row.Cells[0].Value);
            oCategorias=oCategoriaImplement.Get(id);
            this.lblCodigo.Text = oCategorias.id_categoria.ToString();
            this.txtNombre.Text = oCategorias.categoria;
            this.gbCategorias.Enabled = false;
            Deshabilitar();
        }

        private void Guardar()
        {
            cod_categorias oCategoria=new cod_categorias();
            CategoriaImplement oCategoriaImplement=new CategoriaImplement();
            if (this.lblCodigo.Text == "")
            {
                oCategoria.categoria=this.txtNombre.Text;
                oCategoriaImplement.Save(oCategoria);
            }
            else
            {
                DataGridViewRow row = this.dgvCategoria.CurrentRow;
                int id = Convert.ToInt32(row.Cells[0].Value);
                oCategoria = oCategoriaImplement.Get(id);
                oCategoria.categoria = this.txtNombre.Text;
                oCategoriaImplement.Update(oCategoria);
            }
            Deshabilitar();
            this.txtNombre.Text = "";
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
            this.dgvCategoria.Enabled = true;
            this.txtNombre.Text = "";
            this.gbCategorias.Enabled = false;
            this.lblCodigo.Text = "";
            Deshabilitar();
        }

        private void NuevaCategoria()
        {
            HabilitarBotones();
            this.txtNombre.Text = "";
            this.gbCategorias.Enabled = true;
            this.lblCodigo.Text = "";
        }

        private void ModificarCategoria()
        {
            HabilitarBotones();
            this.gbCategorias.Enabled = true;
            cod_categorias oCategoria=new cod_categorias();
            CategoriaImplement oCategoriaImplement=new CategoriaImplement();
            DataGridViewRow row = this.dgvCategoria.CurrentRow;
            int id = Convert.ToInt32(row.Cells[0].Value);
            oCategoria = oCategoriaImplement.Get(id);
            this.lblCodigo.Text = oCategoria.id_categoria.ToString();
            this.txtNombre.Text = oCategoria.categoria;
            this.dgvCategoria.Enabled = false;
        }
        private void CargarGrid()
        {
            CategoriaImplement oCategoriaImplement=new CategoriaImplement();
            this.dgvCategoria.DataSource = oCategoriaImplement.Buscar("");
            this.dgvCategoria.Enabled = true;
        }
        private void Eliminar() {
            CategoriaImplement oCategoriaImplement = new CategoriaImplement();
            foreach (DataGridViewRow item in this.dgvCategoria.SelectedRows)
            {
             //   oCategoriaImplement.Delete(id);
                dgvCategoria.Rows.RemoveAt(item.Index);
            }
        //    if (this.dgvCategoria.SelectedRows.Count >0)
        //    {
        //      //  _eliminoBarrio = true;
        //        DataGridViewRow row = this.dgvCategoria.CurrentRow;
        //        int id = Convert.ToInt32(row.Cells[0].Value);
        //        oCategoriaImplement.Delete(id);
        //        dgvCategoria.Rows.RemoveAt(dgvCategoria.CurrentRow.Index);
        //        CargarGrid();
        //    }
        }
        private void Imprimir()
        {
            CategoriaImplement oCategoriaImplement = new CategoriaImplement();
            SysConfigImplement oSysConfigImplement = new SysConfigImplement();
            Reportes.frmReportes frmRpt = new Reportes.frmReportes();
            Reportes.rptCategorias rpt = new Reportes.rptCategorias();
            //Cargo el Data Set
            DataSet ds = new DataSet("Generico");
            ds.Tables.Add(oSysConfigImplement.GetEncabezadoDT("Encabezado"));
            ds.Tables[0].TableName = "dtEncabezado";
            ds.Tables.Add(oCategoriaImplement.GetByCategoriaDT(""));
            ds.Tables[1].TableName = "dtCategorias";
            rpt.SetDataSource(ds);
            frmRpt.crvGenerico.ReportSource = rpt;
            frmRpt.Show();

        }
        #endregion

   

    }
}
