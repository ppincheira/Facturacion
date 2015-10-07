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
    public partial class frmAccionesAM : Form
    {
        #region << PROPIEDADES >>
        int _idSocio;
        int _idAccion;
        #endregion

        #region << EVENTOS >>
        public frmAccionesAM(int idSocio)
        {

            InitializeComponent();
            _idSocio = idSocio;
        }

        public frmAccionesAM(int idSocio, int idAccion)
        {

            InitializeComponent();
            _idSocio = idSocio;
            _idAccion = idAccion;
        }

        private void frmAccionesAM_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void txtCuotas_KeyPress(object sender, KeyPressEventArgs e)
        {
            Commons oCommons = new Commons();
            oCommons.ValidarNumeroEntero(sender, e);
        }

        private void txtCuotas_TextChanged(object sender, EventArgs e)
        {
            CalcularValorCuotas();
        }

        private void txtImporteTotal_TextChanged(object sender, EventArgs e)
        {
            CalcularValorCuotas();
        }

        #endregion

        #region << METODOS >>

        private void Inicializar() {
            if (_idAccion == 0)
            {
                Limpiar();
            }
            else
            {
                AccionImplement oAccionImplement = new AccionImplement();
                acciones oAccion = new acciones();
                oAccion = oAccionImplement.Get(_idAccion);
                this.txtCuotas.Text = oAccion.cuotas.ToString();
                this.txtCuotasAbonadas.Text = (oAccion.cuotas - oAccion.pendientes).ToString();
                this.txtImporteTotal.Text = oAccion.importe.ToString();
                this.txtValorCuotas.Text = oAccion.valor_cuota.ToString();
            }
        }

        private void Limpiar() {
            this.txtCuotas.Text = "";
            this.txtCuotasAbonadas.Text = "";
            this.txtImporteTotal.Text = "";
            this.txtValorCuotas.Text = "";
        }

        private void Guardar() {
            AccionImplement oAccionImplement=new AccionImplement();
            acciones oAccion = new acciones();

            string Mensaje;
            Mensaje = "";
            if (this.txtCuotas.Text.Length == 0) { Mensaje += "Falta ingresar cuotas." + Environment.NewLine; };
            if (this.dtpFecha.Text.Length == 0) { Mensaje += "Falta ingresar fecha." + Environment.NewLine; };
            if (this.txtImporteTotal.Text.Length == 0) { Mensaje += "Falta ingresar importe total." + Environment.NewLine; };
            if (this.txtCuotasAbonadas.Text.Length == 0) { Mensaje += "Falta ingresar cuotas abonadas." + Environment.NewLine; };
          
            //txtValorCuotas

            if (Mensaje.Length > 0)
            {
                frmVentanaInformativa ofrmVentanaInformativa = new frmVentanaInformativa(Mensaje);
                ofrmVentanaInformativa.ShowDialog();
            }
            else
            {
                oAccion.cuotas = int.Parse(this.txtCuotas.Text);
                oAccion.fecha = DateTime.Parse(this.dtpFecha.Text);
                oAccion.importe = Decimal.Parse(this.txtImporteTotal.Text);
                oAccion.finalizado = false;
                oAccion.id_socio = _idSocio;
                oAccion.valor_cuota = Decimal.Parse(this.txtValorCuotas.Text);
                
                if (_idAccion == 0)
                {
                    oAccion.facturadas = int.Parse(this.txtCuotasAbonadas.Text);
                    oAccion.pendientes = oAccion.cuotas - oAccion.facturadas;
                    if (oAccion.facturadas == oAccion.cuotas)
                        oAccion.finalizado = true;
                    oAccionImplement.Save(oAccion);
                    this.Close();
                }
                else
                {
                    oAccion.facturadas = int.Parse(this.txtCuotasAbonadas.Text);
                    oAccion.pendientes = oAccion.cuotas - oAccion.facturadas;
                    if (oAccion.facturadas == oAccion.cuotas)
                        oAccion.finalizado = true;
                    oAccion.id_accion=_idAccion;
                    oAccionImplement.Update(oAccion);
                    this.Close();
                }
            }

           

           

        }

        private void CalcularValorCuotas() { 
        
            if( (this.txtCuotas.Text!="") && (this.txtImporteTotal.Text!="")){

                if (txtCuotas.Text != "0")
                    this.txtValorCuotas.Text = (decimal.Parse(this.txtImporteTotal.Text) / decimal.Parse(this.txtCuotas.Text)).ToString();
                else
                    this.txtValorCuotas.Text = this.txtImporteTotal.Text;
            }
        
        }

        private void Cancelar() {
            this.Close();
        }

        #endregion

        

  
    }
}
