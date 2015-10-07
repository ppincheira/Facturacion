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
    public partial class frmCargaEstados : Form
    {

        #region << PROPIEDADES >>
        //XXXImplement oXXXImplement = new XXXImplement();
        //bool _elimino
        #endregion

        #region << EVENTOS >>

        public frmCargaEstados()
        {
            InitializeComponent();
        }

        private void frmCargaEstados_Load(object sender, EventArgs e)
        {
            Inicializar();           
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {

        }
        private void tsbModificar_Click(object sender, EventArgs e)
        {

        }
        private void tsbEliminar_Click(object sender, EventArgs e)
        {

        }
        private void tsbImprimir_Click(object sender, EventArgs e)
        {

        }
        private void tsbAceptar_Click(object sender, EventArgs e)
        {

        }
        private void tsbCancelar_Click(object sender, EventArgs e)
        {

        }
       
        private void cbRutas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion
        
        #region << METODOS >>
        private void CargarCboxBarrios()
        {
            BarrioImplement oBarrioImplement = new BarrioImplement();
            oBarrioImplement.CargarCombo(this.cboxBarrios, "<Todos los Barrios>");
        }
        private void CargarCboxRutas()
        {
            //...

        }
        private void CargarCboxOrdenes()
        {
            //...
        }
        
        private void CargarCboxOrdenarPor()
        {
            //TODO: veridicar este hardcodeo
            List<Item> lista = new List<Item>();

            lista.Add(new Item("Nombre", 1));
            lista.Add(new Item("Número de Socio", 2));
            lista.Add(new Item("Barrio, Ruta y Orden", 3));

            cBoxOrdenarPor.DisplayMember = "Name";
            cBoxOrdenarPor.ValueMember = "Value";
            cBoxOrdenarPor.DataSource = lista;
       }
        
        #endregion

        #region << METODOS >>
        private void Inicializar()
        {
            CargarCboxBarrios();
            CargarCboxRutas();
            CargarCboxOrdenes();
            CargarCboxOrdenarPor();

            this.cBoxRutas.Enabled = false;
            this.cBoxOrdenes.Enabled = false;


            CargarGrid();
        }
        private void CargarSeleccion()
        {
            //cod_barrios oBarrio = new cod_barrios();

            //DataGridViewRow row = this.dgvBarrio.CurrentRow;
            //int id = Convert.ToInt32(row.Cells[0].Value);
            //oBarrio = oBarrioImplement.Get(id);

            //this.lblCodigo.Text = oBarrio.id_barrio.ToString();
            //this.txtNombre.Text = oBarrio.barrio;
            //this.txtNombre.Enabled = false;
            //Deshabilitar();
            
        }
        private void CargarGrid()
        {
            //this.dgvBarrio.DataSource = oBarrioImplement.Buscar("");
            //this.dgvBarrio.Enabled = true;
            //_eliminoBarrio = false;

            SocioMedicionImplement oSocioMedicionImplement = new SocioMedicionImplement();
                    
     
            string strAuxBarrio = this.cboxBarrios.SelectedValue.ToString();
            string strAuxOrden;
            if (this.cBoxOrdenarPor.SelectedValue != null)
                strAuxOrden = this.cBoxOrdenarPor.SelectedValue.ToString();
            else 
                strAuxOrden = "1";

            this.dgvDatos.DataSource = oSocioMedicionImplement.GetByFilterDT(int.Parse(strAuxBarrio),
                                                                                this.chkbSinEstadoActual.Checked,
                                                                                int.Parse(strAuxOrden));
           

        }
       
        #endregion

        private void cboxBarrios_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CargarGrid();
        }

        private void cBoxOrdenarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CargarGrid();
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
