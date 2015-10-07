using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using com.cooperativa.services;
using com.cooperativa.implement;
using com.cooperativa.implement.dao;

namespace com.cooperativa.view.Configuracion
{
    public partial class frmGestionMoratorias : Form
    {

        #region << PROPIEDADES >>
      
        bool _inicializado = false;
        int _idMoratoria=0; 
        #endregion

        #region << EVENTOS >>

        public frmGestionMoratorias()
        {
            InitializeComponent();
        }

        private void frmGestionMoratorias_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MoratoriasImplement oMoratoriasImplement = new MoratoriasImplement();
            if (_idMoratoria > 0)
            {
                if (oMoratoriasImplement.TieneConvenios(_idMoratoria))
                {
                    frmVentanaInformativa oFrmVentanaInformativa = new frmVentanaInformativa("Esta moratoria no puede editarse por que ya cuenta con convenios realizados para la misma.");
                    oFrmVentanaInformativa.ShowDialog();
                }
                else
                {
                    frmConfiguracionesPestanias oFrmConvenioMora = new frmConfiguracionesPestanias(_idMoratoria);
                    if (oFrmConvenioMora.ShowDialog() == DialogResult.OK)
                    {
                        CargarAnios();
                    }
                  
                }
            }

           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MoratoriasImplement oMoratoriasImplement = new MoratoriasImplement();
            if (_idMoratoria > 0)
            {
                if (oMoratoriasImplement.TieneConvenios(_idMoratoria))
                {
                    frmVentanaInformativa oFrmVentanaInformativa = new frmVentanaInformativa("Esta moratoria no puede eliminarse por que ya cuenta con convenios realizados para la misma.");
                    oFrmVentanaInformativa.ShowDialog();
                }
                else
                {

                    DetallesMoratoriaImplement oDetallesMoratoriaImplement = new DetallesMoratoriaImplement();
                    oDetallesMoratoriaImplement.DeleteByIdMoratoria(_idMoratoria);
                    oMoratoriasImplement.Delete(_idMoratoria);
                    CargarGrillaMoratorias();
                }
            }
        }

        private void cmbAnio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_inicializado)
                CargarGrillaMoratorias();
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            frmConfiguracionesPestanias oFrmConvenioMora = new frmConfiguracionesPestanias(0);
            if (oFrmConvenioMora.ShowDialog() == DialogResult.OK)
            {
                CargarAnios();
            }
        }

        private void dgvMoratorias_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dgvMoratorias.CurrentRow;
            if (row != null)
            {
                _idMoratoria = Convert.ToInt32(row.Cells[0].Value);
            }
        }

        #endregion

        #region << METODOS >>

        private void Inicializar()
        {
            CargarAnios();
        }

        private void CargarAnios()
        {
            PeriodosImplement oPerdiodosImplement = new PeriodosImplement();
            DataTable dt = new DataTable();
            dt = oPerdiodosImplement.GetAnios();
            string ultimoPeriodo = oPerdiodosImplement.GetUltimoPeriodo();
            dt.Rows.Add("Seleccione...");
            cmbAnio.DataSource = dt;
            cmbAnio.DisplayMember = "periodo";
            cmbAnio.ValueMember = "periodo";

            cmbAnio.SelectedValue = ultimoPeriodo.Substring(0, 4);
            CargarGrillaMoratorias();
            _inicializado = true;
        }

        private void CargarGrillaMoratorias()
        { 
            MoratoriasImplement oMoratoriasImplement = new MoratoriasImplement();
            dgvMoratorias.DataSource = oMoratoriasImplement.GetAllByAnioDT(cmbAnio.SelectedValue.ToString());
        }

        #endregion

       

       

       
       
    }
}
