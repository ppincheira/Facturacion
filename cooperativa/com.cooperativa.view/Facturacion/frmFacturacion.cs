using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using com.cooperativa.implement;
using com.cooperativa.implement.dao;
using com.cooperativa.implement.calculos;
using System.Collections;

namespace com.cooperativa.view
{
    public partial class frmFacturacion : Form
    {
        #region <<  PROPIEDADES >>
        DateTime _primerVencimiento;
        int _diasEntreVencimiento;
        #endregion
        #region << EVENTOS >>
        public frmFacturacion()
        {
            InitializeComponent();
        }

        private void frmFacturacion_Load(object sender, EventArgs e)
        {
            try
            {
                Inicializar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message + " -- " + ex.InnerException);

            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Iniciar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            CargarTab();
        }

        #endregion

        #region << METODOS >>

        private void Inicializar()
        {
            this.dtpFecha.Value = DateTime.Now.Date;
            SysConfigImplement oSysConfigImplement = new SysConfigImplement();
            sys_configuracion oSysConfig = new sys_configuracion();
            oSysConfig = oSysConfigImplement.GetByNombre("DiaPrimerVencimiento");
            _primerVencimiento = DateTime.Parse(oSysConfig.valor + "/" + DateTime.Now.Date.Month + "/" + DateTime.Now.Date.Year).AddMonths(1);
            oSysConfig = oSysConfigImplement.GetByNombre("DiasEntreVenc2");
            _diasEntreVencimiento = int.Parse(oSysConfig.valor);
            this.nudCantidad.Value = 2;

            InicializarTab("0");
            InicializarTab("1");
        }
        private void BorrarTabs(int desde, int hasta)
        {
            for (int i = desde; i <= hasta; i++)
            {
                try
                {
                    TabPage tab = (TabPage)this.Controls.Find("tpPeriodos" + i.ToString(), true)[0];
                    this.tcPeriodos.TabPages.Remove(tab);
                }
                catch { }

            }

        }
        private void InicializarTab(string numero)
        {


            TabPage tab = (TabPage)this.Controls.Find("tpPeriodos" + numero.ToString(), true)[0];

            tab.Text = DateTime.Parse(this.dtpFecha.Text).Date.AddMonths(int.Parse(numero)).Date.ToString().Substring(3, 7);
            TextBox textPeriodo = (TextBox)this.Controls.Find("txtPeriodo" + numero.ToString(), true)[0];
            textPeriodo.Text = DateTime.Parse(this.dtpFecha.Text).Date.AddMonths(int.Parse(numero)).Date.ToString().Substring(3, 7);
            textPeriodo.Enabled = false;
            textPeriodo.Font = new Font("Verdana", 14, FontStyle.Bold, GraphicsUnit.Pixel);


            TextBox textPeriodoDesc = (TextBox)this.Controls.Find("txtPeriodoDesc" + numero.ToString(), true)[0];
            textPeriodoDesc.Text = DateTime.Parse(this.dtpFecha.Text).Date.AddMonths(int.Parse(numero)).Date.ToString("MMMM").ToUpper() + " " +
            DateTime.Parse(this.dtpFecha.Text).Date.AddMonths(int.Parse(numero)).Date.Year.ToString();
            textPeriodoDesc.Font = new Font("Verdana", 14, FontStyle.Bold, GraphicsUnit.Pixel);
            textPeriodoDesc.Enabled = false;
            DateTimePicker textPrimerVen = (DateTimePicker)this.Controls.Find("dtpPrimerVencimiento" + numero.ToString(), true)[0];
            textPrimerVen.Value = _primerVencimiento.AddMonths(int.Parse(numero));
            DateTimePicker textSegundoVen = (DateTimePicker)this.Controls.Find("dtpSegundoVencimiento" + numero.ToString(), true)[0];
            textSegundoVen.Value = textPrimerVen.Value.AddDays(_diasEntreVencimiento);
            TextBox txtAviso = (TextBox)this.Controls.Find("txtAviso" + numero.ToString(), true)[0];
            txtAviso.Text = "Recuerde verificar las fechas de vencimiento en todos los meses";
            txtAviso.Enabled = false;

        }
        private void CargarTab()
        {


            switch (int.Parse(this.nudCantidad.Value.ToString()))
            {
                case 1:

                    BorrarTabs(1, 12);
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos0) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos0); InicializarTab("0"); }

                    break;
                case 2:
                    BorrarTabs(2, 12);
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos0) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos0); InicializarTab("0"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos1) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos1); InicializarTab("1"); }
                    break;
                case 3:
                    BorrarTabs(3, 12);
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos0) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos0); InicializarTab("0"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos1) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos1); InicializarTab("1"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos2) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos2); InicializarTab("2"); }
                    break;
                case 4:
                    BorrarTabs(4, 12);
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos0) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos0); InicializarTab("0"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos1) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos1); InicializarTab("1"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos2) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos2); InicializarTab("2"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos3) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos3); InicializarTab("3"); }
                    break;
                case 5:
                    BorrarTabs(5, 12);
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos0) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos0); InicializarTab("0"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos1) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos1); InicializarTab("1"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos2) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos2); InicializarTab("2"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos3) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos3); InicializarTab("3"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos4) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos4); InicializarTab("4"); }

                    break;
                case 6:
                    BorrarTabs(6, 12);
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos0) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos0); InicializarTab("0"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos1) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos1); InicializarTab("1"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos2) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos2); InicializarTab("2"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos3) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos3); InicializarTab("3"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos4) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos4); InicializarTab("4"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos5) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos5); InicializarTab("5"); }

                    break;
                case 7:
                    BorrarTabs(7, 12);
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos0) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos0); InicializarTab("0"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos1) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos1); InicializarTab("1"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos2) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos2); InicializarTab("2"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos3) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos3); InicializarTab("3"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos4) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos4); InicializarTab("4"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos5) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos5); InicializarTab("5"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos6) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos6); InicializarTab("6"); }
                    break;
                case 8:
                    BorrarTabs(8, 12);
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos0) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos0); InicializarTab("0"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos1) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos1); InicializarTab("1"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos2) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos2); InicializarTab("2"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos3) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos3); InicializarTab("3"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos4) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos4); InicializarTab("4"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos5) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos5); InicializarTab("5"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos6) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos6); InicializarTab("6"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos7) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos7); InicializarTab("7"); }
                    break;
                case 9:
                    BorrarTabs(9, 12);
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos0) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos0); InicializarTab("0"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos1) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos1); InicializarTab("1"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos2) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos2); InicializarTab("2"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos3) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos3); InicializarTab("3"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos4) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos4); InicializarTab("4"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos5) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos5); InicializarTab("5"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos6) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos6); InicializarTab("6"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos7) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos7); InicializarTab("7"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos8) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos8); InicializarTab("8"); }
                    break;
                case 10:
                    BorrarTabs(10, 12);
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos0) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos0); InicializarTab("0"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos1) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos1); InicializarTab("1"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos2) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos2); InicializarTab("2"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos3) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos3); InicializarTab("3"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos4) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos4); InicializarTab("4"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos5) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos5); InicializarTab("5"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos6) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos6); InicializarTab("6"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos7) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos7); InicializarTab("7"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos8) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos8); InicializarTab("8"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos9) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos9); InicializarTab("9"); }
                    break;
                case 11:
                    BorrarTabs(11, 12);
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos0) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos0); InicializarTab("0"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos1) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos1); InicializarTab("1"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos2) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos2); InicializarTab("2"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos3) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos3); InicializarTab("3"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos4) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos4); InicializarTab("4"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos5) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos5); InicializarTab("5"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos6) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos6); InicializarTab("6"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos7) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos7); InicializarTab("7"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos8) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos8); InicializarTab("8"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos9) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos9); InicializarTab("9"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos10) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos10); InicializarTab("10"); }
                    break;
                case 12:

                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos0) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos0); InicializarTab("0"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos1) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos1); InicializarTab("1"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos2) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos2); InicializarTab("2"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos3) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos3); InicializarTab("3"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos4) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos4); InicializarTab("4"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos5) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos5); InicializarTab("5"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos6) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos6); InicializarTab("6"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos7) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos7); InicializarTab("7"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos8) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos8); InicializarTab("8"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos9) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos9); InicializarTab("9"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos10) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos10); InicializarTab("10"); }
                    if (this.tcPeriodos.TabPages.IndexOf(this.tpPeriodos11) == -1) { this.tcPeriodos.TabPages.Add(this.tpPeriodos11); InicializarTab("11"); }
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }
        private void Iniciar()
        {
            sys_configuracion oSysConfig = new sys_configuracion();
            SysConfigImplement oSysConfigImplement = new SysConfigImplement();
            oSysConfig = oSysConfigImplement.GetByNombre("CantVencimientos");
            int CantUsuarios = 0;
            decimal NetoConIVA = 0;
            decimal NetoSinIVA = 0;
            decimal SubTotal = 0;
            switch (int.Parse(oSysConfig.valor))
            {
                case 1:
                    //No hace nada porque el primer se establece por defecto
                    break;
                case 2:
                    for (int i = 1; i <= (int.Parse(this.nudCantidad.Value.ToString())-1 ); i++)
                    {
                        DateTimePicker fecha1 = (DateTimePicker)tcPeriodos.Controls.Find("dtpPrimerVencimiento"+i, true)[0];
                        DateTimePicker fecha2 = (DateTimePicker)tcPeriodos.Controls.Find("dtpSegundoVencimiento" + i, true)[0];
                        if (fecha2.Value <= fecha1.Value)
                        {
                            string msg = "Debe establecer las fechas para los 2 vencimientos y éstas " +
                                       "no pueden ser iguales, controlar fechas indicadas en  el periodo " + (i - 1).ToString();
                            MessageBox.Show(msg);
                        }
                    }

                    break;
                case 3:
                    for (int i = 1; i <= (int.Parse(this.nudCantidad.Value.ToString()) + 1); i++)
                    {
                        DateTimePicker fecha1 = (DateTimePicker)tcPeriodos.Controls.Find("dtpPrimerVencimiento"+i, true)[0];
                        DateTimePicker fecha2 = (DateTimePicker)tcPeriodos.Controls.Find("dtpSegundoVencimiento"+i, true)[0];
                        if (fecha2.Value <= fecha1.Value)
                        {
                            string msg = "Debe establecer las fechas para los 2 vencimientos y éstas " +
                                       "no pueden ser iguales, controlar fechas indicadas en  el periodo " + (i - 1).ToString();
                            MessageBox.Show(msg);
                        }
                    }

                    break;
            }


            // Verificar que se hayan cargado los estados de los medidores

            SocioConexionImplement oSocioConexionImplement = new SocioConexionImplement();
            DataTable DTMedidores = oSocioConexionImplement.GetEstadosMedidores();
            if (DTMedidores.Rows.Count > 0)
            {
                string msg2 = "No se puede efectuar el proceso de facturación porque existen " +
                "socios de servicio medido que no tienen informado el estado del " +
                "medidor. \n El estado del medidor debe ser " +
                "informado siempre, si por algún motivo no se efectuó la lectura, " +
                "coloque un valor estimado en el campo 'Lectura' pero no informe " +
                "la fecha de lectura en el campo 'Fecha Lectura', en la factura " +
                "se informará al socio que el valor de M3 consumidos fué estimado /n" +
                "El proceso de facturación no puede continuar.";
                MessageBox.Show(msg2);
            }

            // Pide confirmar el proceso de facturación
            string msj2 = "";
            if (int.Parse(this.nudCantidad.Value.ToString()) > 1)
            {
                msj2 = "Está Ud. realmente seguro de querer comenzar el proceso de " +
                "facturación ?. \nEste proceso no puede ser " +
                "cancelado y al facturarse más de un período sólo puede " +
                "anularse la facturación del último período pero no de los " +
                "períodos anteriores";
            }
            else
            {
                msj2 = "Está Ud. realmente seguro de querer comenzar el proceso de " +
                "facturación ?. \nEste proceso no puede ser " +
                "cancelado, aunque sí es reversible, es decir que una vez " +
                "finalizado el proceso se puede anular \n toda la facturación " +
                "y volver a efectuarla";
            }
            DialogResult dialogResult = MessageBox.Show(msj2, "Confirmar facturación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Hay que inhabilitar los forms porque el proceso no puede detenerse
                DeshabilitarControles();
                // Guarda la cantidad de usuarios para utilizar la misma cantidad en
                // todos los períodos a facturar


                // obtengo solo los conceptos activos
                IList listaConceptos = new ConceptoImplement().GetActivosAll();
                for (int i = 0; i < (int.Parse(this.nudCantidad.Value.ToString()) ); i++)
                {

                    TextBox textPeriodo = (TextBox)this.Controls.Find("txtPeriodo" + i, true)[0];
                    string idPeriodo = textPeriodo.Text.Substring(3, 4) + textPeriodo.Text.Substring(0, 2);
                    DataTable DTUsuariosAFacturar = oSocioConexionImplement.GetSociosAFacturar(idPeriodo);
                    //Repetir el proceso de facturación para todas las solapas (periodos) seleccionados
                    CantUsuarios = DTUsuariosAFacturar.Rows.Count;
                    this.txtUsuariosAFacturar.Text = CantUsuarios.ToString();
                    this.txtUsuariosFacturados.Text = "0";
                    this.txtUsuariosFaltantes.Text = CantUsuarios.ToString();
                    this.pbEstado.Value = 0;
                    // Cartel indicativo del proceso que se está efectuando
                    this.tcPeriodos.TabIndex = i;
                   
                    // Guarda el número 'ProxFactura' del proceso anterior por si se desea
                    // anular la facturación en curso (obviamente luego que termine)

                    //sys_configuracion oSysProxFacturaAnterior = new sys_configuracion();
                    //oSysProxFacturaAnterior = oSysConfigImplement.GetByNombre("ProxFacturaAnt");
                    //sys_configuracion oSysProxFactura = new sys_configuracion();
                    //oSysProxFactura = oSysConfigImplement.GetByNombre("ProxFactura");
                    //oSysProxFacturaAnterior.valor = oSysProxFactura.valor;
                    //oSysConfigImplement.Update(oSysProxFacturaAnterior);




                    // Guardo las fechas de vencimiento en la tabla periodos
                    periodos oPeriodo = new periodos();
                    PeriodosImplement oPeriodosImplement = new PeriodosImplement();
                    oPeriodo = oPeriodosImplement.Get(idPeriodo);
                    this.txtProceso.Text = "Se esta procesando el periodo " + idPeriodo;
                    this.txtProceso.Visible = true;
                    Application.DoEvents();
                    oPeriodo.fecha_facturacion = this.dtpFecha.Value;
                    DateTimePicker dtpPrimerVenc = (DateTimePicker)this.Controls.Find("dtpPrimerVencimiento" + i, true)[0];
                    oPeriodo.fecha_primer_venc = dtpPrimerVenc.Value;
                    DateTimePicker dtpSegundoVenc = (DateTimePicker)this.Controls.Find("dtpSegundoVencimiento" + i, true)[0];
                    if (dtpSegundoVenc.Value.ToString() != "")
                        oPeriodo.fecha_segundo_venc = dtpSegundoVenc.Value;
                    oPeriodo.fecha_tercer_venc = null;
                    oPeriodo.facturado = true;
                    FacturasImplement oFacturasImplement = new FacturasImplement();
                    int cantUsuario=DTUsuariosAFacturar.Rows.Count;
                    this.pbEstado.Maximum = cantUsuario;
                    for (int j = 0; j < cantUsuario; j++)
                    {
                        this.pbEstado.Value = j;

                        facturas oFactura = new facturas();
                        FacturasImplement oFacturaImplement = new FacturasImplement();
                        oFactura.id_periodo = idPeriodo;
                        oFactura.id_socio = int.Parse(DTUsuariosAFacturar.Rows[j]["id_socio"].ToString());
                        //oFactura.id_medicion Ver como soluciono el idMedicion
                        oFactura.id_estadoPago = 1;//Impaga
                        oFactura.id_tarifa = 0;//aun no se carga
                        oFactura.id_convenio = 0;//Aun no se carga
                        oFactura.fechaPago = null;
                        oFactura.cobrado = 0;
                        oFactura.neto1 = 0;
                        oFactura.neto2 = 0;
                        oFactura.importeNeto = 0;
                        oFactura.importeTotal = 0;
                        int idFactura = 0;
                        idFactura = oFacturasImplement.Save(oFactura);
                            /* Si corresponde calcula los consumos estimados, además transfiere
                             los valores de los campos de datos actuales a los campos de
                             los datos anteriores*/
                        int idMedidor = 0;
                        if (DTUsuariosAFacturar.Rows[j]["medidor"].ToString() != "")
                        {
                                socios_mediciones oSocioMedicionActual = new socios_mediciones();
                                SocioMedicionImplement oSocioMedicionImplement = new SocioMedicionImplement();
                                oSocioMedicionActual = oSocioMedicionImplement.ultimaMedicion(int.Parse(DTUsuariosAFacturar.Rows[j]["id_socio"].ToString()));
                                socios_mediciones oSocioMedicionNew = new socios_mediciones();
                                oSocioMedicionNew.fecha_lectura = null;
                                oSocioMedicionNew.id_socio = int.Parse(DTUsuariosAFacturar.Rows[j]["id_socio"].ToString());

                                if (i <= (int.Parse(this.nudCantidad.Value.ToString()) - 1))
                                {
                                    decimal consumo = 0;
                                    if (oSocioMedicionActual != null)
                                    {
                                        consumo = (decimal)decimal.Parse((oSocioMedicionActual.consumo * 0.75).ToString());
                                        oSocioMedicionNew.consumo = (int)Math.Truncate(consumo);
                                        oSocioMedicionNew.lectura = oSocioMedicionActual.lectura + oSocioMedicionNew.consumo;
                                    }
                                    else {
                                        oSocioMedicionNew.consumo = 0;
                                        oSocioMedicionNew.lectura = 0;
                                    }
                                }
                                else
                                {
                                    oSocioMedicionNew.consumo = 0;
                                    oSocioMedicionNew.lectura = 0;
                                }
                                idMedidor = oSocioMedicionImplement.Save(oSocioMedicionNew);
                            }
                            oFactura.id_medicion = idMedidor;//Cargo 0 si no tiene medidor

                            // Limpia las variables de subtotales con y sin IVA
                            NetoConIVA = 0;
                            NetoSinIVA = 0;
                          
                            //Para cada socio, recorre toda la base de conceptos
                            foreach (cod_conceptos oConcepto in listaConceptos)
                            {
                                bool CorrespondeFacturar = false;

                                if (oFactura.id_medicion.Value != 0)
                                {
                                    //SocioMedicionImplement oSosioMedicionImpl = new SocioMedicionImplement();
                                    //socios_mediciones oSocioMedicion = new socios_mediciones();
                                    //oSocioMedicion = oSosioMedicionImpl.Get(oFactura.id_medicion.Value);
                                }
                                acciones oAccion = new acciones();
                                conceptos_particulares oConceptoParticular = new conceptos_particulares();
                                conceptosParticularesImplement oConceptoParticularImplement = new conceptosParticularesImplement();
                                AccionImplement oAccionesImplement = new AccionImplement();
                             
                                if (oConcepto.aplicacion == 2)
                                { // si concepto Particular
                                     
                                    oConceptoParticular = oConceptoParticularImplement.GetByFilter(int.Parse(DTUsuariosAFacturar.Rows[j]["id_socio"].ToString()), oConcepto.id_concepto, oFactura.id_periodo);
                                    if (oConceptoParticular!=null)
                                    {
                                        CorrespondeFacturar = true;
                                    }
                                    else
                                    {
                                        // No encontrado entonces no corresponde facturar
                                        CorrespondeFacturar = false;
                                    }
                                }
                                else
                                {
                                    //Concepto Activo y no particular entonces corresponde facturar
                                        CorrespondeFacturar = true;
                               }

                                if (CorrespondeFacturar)
								{

                                    facturas_detalles oDetalle = new facturas_detalles();
                                    FacturasDetallesImplement oFacturasDetallesImplement = new FacturasDetallesImplement();
                                    //ConvenioImplement oConvenioImplement = new ConvenioImplement();
                                    CalculosFacturacionFormulas oCalculosFacturacionFormulas = new CalculosFacturacionFormulas();
                                    oDetalle = oCalculosFacturacionFormulas.getDetalle(int.Parse(DTUsuariosAFacturar.Rows[j]["id_socio"].ToString()), decimal.Parse(DTUsuariosAFacturar.Rows[j]["cargo_fijo"].ToString()), decimal.Parse(DTUsuariosAFacturar.Rows[j]["abono"].ToString()), decimal.Parse(DTUsuariosAFacturar.Rows[j]["valor_m3"].ToString()), oConcepto, oFactura, oConceptoParticular);
                                    if (oDetalle.importe != 0)
                                    
                                       oFacturasDetallesImplement.Save(oDetalle);

                                    this.txtUsuariosFacturados.Text = j.ToString();
                                    this.txtUsuariosFaltantes.Text = (int.Parse(this.txtUsuariosAFacturar.Text) - j).ToString();
                                    Application.DoEvents();
                                    // Calcula los subtotales separados para los conceptos con y sin IVA
                                    if (oConcepto.aplicar_iva.Value)
                                        NetoConIVA = NetoConIVA + oDetalle.importe;
                                    else NetoSinIVA = NetoSinIVA + oDetalle.importe;
                                    // Calcula los campos Neto1 y Neto2 utilizados en los
                                    // cálculos de intereses
                                    if (oConcepto.aplicar_recargo.Value)
                                        oFactura.neto1 = oFactura.neto1.Value + Convert.ToSingle(oDetalle.importe);
                                    else
                                        oFactura.neto2 = oFactura.neto2.Value + Convert.ToSingle(oDetalle.importe);


                                }
                            }

                            // Obtiene el subtotal general como suma de los
                            // subtotales parciales con y sin IVA
                            SubTotal = NetoConIVA + NetoSinIVA;
                            // Redondea el subtotal a dos dígitos
                            SubTotal = decimal.Round(SubTotal, 2);
                            // Registra el subtotal general
                            oFactura.importeNeto = Convert.ToSingle(SubTotal);
                            // Calcula IVA (sólo para los conceptos que corresponde)
                            facturas_detalles oFacDetalle=new facturas_detalles();
                            FacturasDetallesImplement oFacDetalleImplement = new FacturasDetallesImplement();

                            cod_conceptos oConceptoIVA=new cod_conceptos();
                            ConceptoImplement oConceptoImplement=new ConceptoImplement();

                            oConceptoIVA=oConceptoImplement.Get(23);//concepto IVA es el 23
                            oFacDetalle.id_concepto=oConceptoIVA.id_concepto;
                            oFacDetalle.id_factura=oFactura.id_factura;
                            oFacDetalle.idOrden=oConceptoIVA.orden_concepto;
                            oFacDetalle.idTipo=0;
                            oFacDetalle.importe= decimal.Round(NetoConIVA *decimal.Parse(DTUsuariosAFacturar.Rows[j]["iva"].ToString())/100,2);
                            oFacDetalleImplement.Save(oFacDetalle);
                            // Calcula Total
                            oFactura.importeTotal = oFactura.importeNeto.Value + Convert.ToSingle( oFacDetalle.importe); //este ahi que ver el tipo de dato
                            oFactura.id_factura = idFactura;
                            oFacturaImplement.Update(oFactura);
                             // Generar entradas en la base de CuentasCorrientes
                            CuentaCorrienteImplement oCuentaCorrienteImplement=new CuentaCorrienteImplement();
                            cuentas_corrientes oCuentaCorriente=new cuentas_corrientes();
                            oCuentaCorriente.fecha=DateTime.Now;
                            oCuentaCorriente.id_factura=idFactura;
                            oCuentaCorriente.id_movimiento=1;
                            oCuentaCorriente.id_socio=int.Parse(DTUsuariosAFacturar.Rows[j]["id_socio"].ToString());
                            oCuentaCorriente.importe_credito=0;
                            oCuentaCorriente.importe_saldo=0;
                            oCuentaCorriente.importe_debito=Convert.ToDecimal(oFactura.importeTotal);
                            oCuentaCorriente.id_cobranza=0;
                            oCuentaCorrienteImplement.Save(oCuentaCorriente);

                       // }



                    }

                }

            }
        }



        private void DeshabilitarControles()
        {

            this.btnIniciar.Enabled = false;
            this.gbDatos.Enabled = false;
            this.gbFinalizaciones.Enabled = false;
            this.tcPeriodos.Enabled = false;
        }


        #endregion










    }
}

