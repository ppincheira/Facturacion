using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using com.cooperativa.implement.dao;
using com.cooperativa.implement;
using com.cooperativa.services;

namespace com.cooperativa.view.Buscadores
{
    public partial class frmBuscarSocio : Form
    {

        #region << Propiedades >>
        public string ValorRetorno { get; set; }
        public int ValorIdRetorno { get; set; }
        #endregion
        #region << Eventos >>
        public frmBuscarSocio()
        {
            InitializeComponent();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
           Seleccionar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        } 
  
        private void dgvSocios_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                ValorRetorno = this.dgvSocios.Rows[this.dgvSocios.SelectedRows[0].Index].Cells[0].Value.ToString();
                ValorIdRetorno = int.Parse(this.dgvSocios.Rows[this.dgvSocios.SelectedRows[0].Index].Cells[0].Value.ToString());
            }
            catch { }
        }
        private void lbCampos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void frmBuscarSocio_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        #endregion

        #region << Metodos >>
        private void Inicializar() {
            ValorRetorno = "";
            CargarCamposDeBusqueda();
            CargarComboInstruccion();
            this.cmbInstruccion.SelectedIndex =0;
            Buscar();
        }

        private void CargarComboInstruccion() {
            List<Item> lista = new List<Item>();
            lista.Add(new Item("Que esté contenido", 1));
            lista.Add(new Item("Que comience con", 2));
            lista.Add(new Item("Que termine con", 3));
            this.cmbInstruccion.DisplayMember = "Name";
            this.cmbInstruccion.ValueMember = "Value";
            this.cmbInstruccion.DataSource = lista;
        
        }
        private void CargarCamposDeBusqueda() {
            List<Item> lista = new List<Item>();
            lista.Add(new Item("CodSocio", 1));
            lista.Add(new Item("SubCod", 2));
            lista.Add(new Item("Nombre", 3));
            lista.Add(new Item("Documento", 4));
            lista.Add(new Item("Zona", 5));
            lista.Add(new Item("Manzana", 6));
            lista.Add(new Item("Lote", 7));
            lista.Add(new Item("Calle", 8));
            lista.Add(new Item("Nro", 9));
            lista.Add(new Item("Ruta", 10));
            lista.Add(new Item("Orden", 11));
            lista.Add(new Item("Nomenclatura", 12));
            lista.Add(new Item("Medidor", 13));
            lista.Add(new Item("CUIT", 14));
            lista.Add(new Item("Obs", 15));
            this.lbCampos.DataSource = lista;
           
         
        }


        private void Buscar() {
            if (this.cmbInstruccion.SelectedValue != null)
            {
                SocioImplement oSocioImplement = new SocioImplement();
                int idCampo = ((com.cooperativa.services.Item)(this.lbCampos.SelectedValue)).Value;
                this.dgvSocios.DataSource = oSocioImplement.SocioGetAllByOrder(int.Parse(this.cmbInstruccion.SelectedValue.ToString()), idCampo, this.txtBusqueda.Text);
            }
        }

        private void Seleccionar() {
            if (ValorRetorno != "")
                DialogResult = DialogResult.OK; //cierra el formulario    
            else
                DialogResult = DialogResult.No;
            this.Close();
        }

        private void Cerrar()
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
   
        #endregion

   

   



    }
}
