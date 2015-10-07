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
    public partial class FrmFiltro : Form
    {

        #region << PROPIEDADES >>

        DataTable _dtTabla = new DataTable();
        #endregion
        #region <<  EVENTOS >>
        public FrmFiltro()
        {
            InitializeComponent();
        }
        
        private void FrmFiltro_Load(object sender, EventArgs e)
        {
            Inicializar();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarCondicion();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void rbEntre2_CheckedChanged(object sender, EventArgs e)
        {
            EntreDos();
        }


        private void rbIgual_CheckedChanged(object sender, EventArgs e)
        {
            Igual();
        }

        private void rbDistinto_CheckedChanged(object sender, EventArgs e)
        {
            Distinto();
        }

        private void rbMenor_CheckedChanged(object sender, EventArgs e)
        {
            Menor();
        }

        private void rbMenorIgual_CheckedChanged(object sender, EventArgs e)
        {
            MenorIgual();
        }

        private void rbMayor_CheckedChanged(object sender, EventArgs e)
        {
            Mayor();
        }

        private void rbMayorIgual_CheckedChanged(object sender, EventArgs e)
        {
            MayorIgual();
        }

        private void rbContenido_CheckedChanged(object sender, EventArgs e)
        {
            Contenido();
        }

        private void rbEnLista_CheckedChanged(object sender, EventArgs e)
        {
            EnLista();
        }
        private void rbNoEnLista_CheckedChanged(object sender, EventArgs e)
        {
            NoEnLista();
        }
        #endregion

        #region <<  METODOS >>

        private void Inicializar() {
            DataTable dt = new DataTable();
            CargarCampos();
            OcultarCampos();
        }
        private void CargarCampos() {
            SocioImplement oSocioImplement = new SocioImplement();
           
            this.lbCampos.DisplayMember = "column_name";
            this.lbCampos.ValueMember = "data_type";
            this.lbCampos.DataSource = oSocioImplement.GetAllCampos();
        }

        private void HabilitarCampos() {
            this.txtValorUno.Visible = true;
            this.txtValorDos.Visible = true;
            this.txtValorTres.Visible = true;
            this.txtValorCuatro.Visible = true;
            this.txtValorCinco.Visible = true;
            this.txtValorSeis.Visible = true;
            this.txtValorSiete.Visible = true;
            this.txtValorOcho.Visible = true;
            this.txtValorNueve.Visible = true;
        }

        private void OcultarCampos() {

            this.txtValorDos.Visible = false;
            this.txtValorTres.Visible = false;
            this.txtValorCuatro.Visible = false;
            this.txtValorCinco.Visible = false;
            this.txtValorSeis.Visible = false;
            this.txtValorSiete.Visible = false;
            this.txtValorOcho.Visible = false;
            this.txtValorNueve.Visible = false;
        }
        private void Blanquear() {

            this.txtValorUno.Text = "";
            this.txtValorDos.Text = "";
            this.txtValorTres.Text = "";
            this.txtValorCuatro.Text = "";
            this.txtValorCinco.Text = "";
            this.txtValorSeis.Text = "";
            this.txtValorSiete.Text = "";
            this.txtValorOcho.Text = "";
            this.txtValorNueve.Text = "";
        }
        private void EntreDos() {
            if (this.rbEntre2.Checked) {
                Blanquear();
                this.txtValorDos.Visible = true;
                this.txtValorDos.Text = "";
            }
        
        }
        private void Igual() {
            if (this.rbIgual.Checked)
            {
                OcultarCampos();
                Blanquear();
            }
        }
        private void Distinto()
        {
            if (this.rbDistinto.Checked)
            {
                OcultarCampos();
                Blanquear();
            }
        }
        private void Menor()
        {
            if (this.rbMenor.Checked)
            {
                OcultarCampos();
                Blanquear();
            }
        }
        private void MenorIgual()
        {
            if (this.rbMenorIgual.Checked)
            {
                OcultarCampos();
                Blanquear();
            }
        }
        private void Mayor()
        {
            if (this.rbMayor.Checked)
            {
                OcultarCampos();
                Blanquear();
            }
        }

        private void MayorIgual()
        {
            if (this.rbMayorIgual.Checked)
            {
                OcultarCampos();
                Blanquear();
            }
        }

        private void Contenido()
        {
            if (this.rbContenido.Checked)
            {
                OcultarCampos();
                Blanquear();
            }
        }

        private void EnLista() { 
            if (this.rbEnLista.Checked){
                HabilitarCampos();
                Blanquear();
            }
        }

        private void NoEnLista() {
            if (this.rbNoEnLista.Checked)
            {
                HabilitarCampos();
                Blanquear();
            }
        }

        private void AgregarCondicion() {
            NuevaLinea();
            Blanquear();
        }
        /// <summary>
        /// Crea un item de Busqueda en la grilla
        /// </summary>
        private void NuevaLinea()
        {
            string nombre="col-"+this.dgvBusqueda.ColumnCount.ToString();
            _dtTabla.Columns.Add(nombre, typeof(string));
            if (this.dgvBusqueda.DataSource == null)
            {
            
                for (int i = 0; i <11; i++)
                {
                    DataRow fila1;
                    fila1 = _dtTabla.NewRow();
                    fila1[nombre] = "";
                    _dtTabla.Rows.Add(fila1);
                }
             }

            _dtTabla.Rows[0][nombre] = this.lbCampos.Text;
            _dtTabla.Rows[1][nombre] = ObtenerOperador();
            _dtTabla.Rows[2][nombre] = this.txtValorUno.Text;
            if (ObtenerOperador()=="Entre Dos Valores")
                _dtTabla.Rows[3][nombre] = this.txtValorDos.Text;
            if( (ObtenerOperador() == "En la Lista")||(ObtenerOperador() == "No En la Lista"))
            {
                _dtTabla.Rows[3][nombre] = this.txtValorDos.Text;
                _dtTabla.Rows[4][nombre] = this.txtValorTres.Text;
                _dtTabla.Rows[5][nombre] = this.txtValorCuatro.Text;
                _dtTabla.Rows[6][nombre] = this.txtValorCinco.Text;
                _dtTabla.Rows[7][nombre] = this.txtValorSeis.Text;
                _dtTabla.Rows[8][nombre] = this.txtValorSiete.Text;
                _dtTabla.Rows[9][nombre] = this.txtValorOcho.Text;
                _dtTabla.Rows[10][nombre] = this.txtValorNueve.Text;
            }
            this.dgvBusqueda.DataSource = _dtTabla;
           
        }

        RadioButton GetCheckedRadio(Control container)
        {
            foreach (var control in container.Controls)
            {
                RadioButton radio = control as RadioButton;

                if (radio != null && radio.Checked)
                {
                    return radio;
                }
            }

            return null;
        }
        private string ObtenerOperador() {

            string operador = "";
            switch (GetCheckedRadio(this).Name)
            {
                case "rbIgual":
                    operador="Igual";
                    break;
                case "rbDistinto":
                    operador = "Distinto";
                    break;
                case "rbMenor":
                    operador = "Menor";
                    break;
                case "rbMenorIgual":
                    operador = "Menor Igual";
                    break;
                case "rbMayor":
                    operador = "Mayor";
                    break;
                case "rbMayorIgual":
                    operador = "Mayor Igual";
                    break;
                case "rbContenido":
                    operador = "Contenido";
                    break;
                case "rbEntre2":
                    operador = "Entre Dos Valores";
                    break;
                case "rbEnLista":
                    operador = "En la Lista";
                    break;
                case "rbNoEnLista":
                    operador = "No En la Lista";
                    break;
            }
            return operador;
        }
        #endregion

        private void lbCampos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    

  

  

      
    }
}
