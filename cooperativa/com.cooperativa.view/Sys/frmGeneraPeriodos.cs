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

namespace com.cooperativa.view.Sys
{
    public partial class frmGeneraPeriodos : Form
    {
        #region << Eventos >>
        public frmGeneraPeriodos()
        {
            InitializeComponent();
        }
        private void frmPeriodos_Load(object sender, EventArgs e)
        {
            Inicializar();
        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {
           Generar();
        }
        #endregion

        #region << Metodos >>
        private void Inicializar() {
            this.txtDiasEntre.Text = "";
            this.txtPrimerVenc.Text = "";
            this.mtbDesde.Text = "";
            this.mtbHasta.Text = "";
            CargarVencimientos();

        }
        private void CargarVencimientos() {
            SysConfigImplement oSysConfigImplement = new SysConfigImplement();
            sys_configuracion oSysDiaPrimerVencimiento = new sys_configuracion();
            sys_configuracion oSysUltimoPeriodo = new sys_configuracion();
            sys_configuracion oSysDíasEntreVenc2 = new sys_configuracion(); 
            oSysDiaPrimerVencimiento = oSysConfigImplement.GetByNombre("DiaPrimerVencimiento");
            oSysDíasEntreVenc2 = oSysConfigImplement.GetByNombre("DíasEntreVenc2");
            oSysUltimoPeriodo = oSysConfigImplement.GetByNombre("UltimoPeriodo");
            this.mtbDesde.Text = oSysUltimoPeriodo.valor;
            this.txtDiasEntre.Text = oSysDíasEntreVenc2.valor;
            this.txtPrimerVenc.Text = oSysDiaPrimerVencimiento.valor;
            this.mtbDesde.Enabled = false;
            this.txtDiasEntre.Enabled = false;
            this.txtPrimerVenc.Enabled = false;
        }
        private void Generar() {
            string UltimoPeriodo="";
            pgbProgreso.Value = 0;
            pgbProgreso.Minimum = 0;
            pgbProgreso.Visible = true;
            DateTime StartDate = new DateTime(int.Parse(this.mtbDesde.Text.Substring(0, 4)),int.Parse( this.mtbDesde.Text.Substring(5, 2)), 1);
            DateTime EndDate = new DateTime(int.Parse(this.mtbHasta.Text.Substring(0, 4)), int.Parse(this.mtbHasta.Text.Substring(5, 2)), 1);
            //Calculo diferencia de meses para utilizar en la barra de progreso
            pgbProgreso.Maximum = Math.Abs((EndDate.Month - StartDate.Month) + 12 * (EndDate.Year - StartDate.Year));
            int MonthInterval = 1;
            PeriodosImplement oPeriodoImplement = new PeriodosImplement();
            SysConfigImplement oSysConfigImplement = new SysConfigImplement();
            sys_configuracion oSysUltimoPeriodo = new sys_configuracion();
            oSysUltimoPeriodo = oSysConfigImplement.GetByNombre("UltimoPeriodo");
            UltimoPeriodo = oSysUltimoPeriodo.valor;
            //voy sumando meses hasta llegar a iguales fechas
            while (StartDate.AddMonths(MonthInterval) <= EndDate)
            {
                StartDate = StartDate.AddMonths(MonthInterval);
                periodos oPeriodo = new periodos();
                oPeriodo.id_periodo = StartDate.Date.ToString("yyyyMMdd").Substring(0,6);
                DateTime PrimerVencimiento = DateTime.Parse(oPeriodo.id_periodo.Substring(0, 4) + "/" + oPeriodo.id_periodo.Substring(4, 2)+"/" + this.txtPrimerVenc.Text);
                // incremento el dia mientra no sea fin de semana(se puede agregar para feriados - primer vencimiento
                while (PrimerVencimiento.DayOfWeek == DayOfWeek.Saturday || PrimerVencimiento.DayOfWeek == DayOfWeek.Sunday)
                {
                    PrimerVencimiento=PrimerVencimiento.Date.AddDays(1);
                }
                DateTime segundoVencimiento = PrimerVencimiento.Date.AddDays(int.Parse(this.txtDiasEntre.Text));
                // incremento el dia mientra no sea fin de semana(se puede agregar para feriados - segundo vencimiento
                while (segundoVencimiento.DayOfWeek == DayOfWeek.Saturday || segundoVencimiento.DayOfWeek == DayOfWeek.Sunday)
                {
                    segundoVencimiento = segundoVencimiento.Date.AddDays(1);
                }
                oPeriodo.fecha_primer_venc = PrimerVencimiento;
                oPeriodo.fecha_segundo_venc = segundoVencimiento;
                oPeriodo.fecha_tercer_venc = null;
                oPeriodo.fecha_facturacion = null;
                oPeriodo.facturado = false;
                oPeriodoImplement.Save(oPeriodo);
                UltimoPeriodo=oPeriodo.id_periodo;
                pgbProgreso.Value += 1;   
            }
          
            if (oSysUltimoPeriodo.valor != UltimoPeriodo)
            {
                oSysUltimoPeriodo.valor = UltimoPeriodo;
                oSysConfigImplement.Update(oSysUltimoPeriodo);
                MessageBox.Show("La Generación se realizo Exitosamente");
                Inicializar();
            }
            else {
                MessageBox.Show("La Generación fue nula");
            }
        }
        #endregion 
    }
}
