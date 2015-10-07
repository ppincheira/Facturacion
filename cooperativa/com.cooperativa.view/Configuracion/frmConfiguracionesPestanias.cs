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
    public partial class frmConfiguracionesPestanias : Form
    {

        #region << PROPIEDADES >>

        DataTable _dtDetallesMoratoria = new DataTable();
        int _primeraCuota = 1;

        int _idMoratoria = 0;
        #endregion

        #region << EVENTOS >>

        
        public frmConfiguracionesPestanias()
        {
            InitializeComponent();
        }

        public frmConfiguracionesPestanias(int idMoratoria)
        {
            InitializeComponent();
            _idMoratoria = idMoratoria;

        }

        private void frmConfiguracionesPestanias_Load(object sender, EventArgs e)
        {
            Inicializar();
        }


        #region <Moratoria>

            private void tsbAceptar_Click(object sender, EventArgs e)
            {
                #region <validacion>

                string Mensaje;
                Mensaje = "";
                if (dtpFechaInicial.Text.Length == 0) { Mensaje += "Falta fecha inicial." + Environment.NewLine; };
                if (dtpFechafinal.Text.Length == 0) { Mensaje += "Falta fecha final." + Environment.NewLine; };

                if (Mensaje.Length == 0)
                {
                    if (DateTime.Parse(dtpFechaInicial.Text) > DateTime.Parse(dtpFechafinal.Text))
                    {
                        Mensaje += "Fecha inicial debe ser menor a fecha final." + Environment.NewLine;
                    }

                }

                if (txtCantCuotas.Text.Length == 0) { Mensaje += "Falta cantidad cuotas." + Environment.NewLine; };

                if (_dtDetallesMoratoria.Rows.Count == 0) { Mensaje += "Debe ingresar algun detalle." + Environment.NewLine; };
                #endregion
                if (Mensaje.Length > 0)
                {
                    frmVentanaInformativa ofrmVentanaInformativa = new frmVentanaInformativa(Mensaje);
                    ofrmVentanaInformativa.ShowDialog();
                }
                else
                {
                    GuardarMoratoria();
                   
                }
              
            }

            private void btnAgregar_Click(object sender, EventArgs e)
            {
                #region <validacion vacio>
                string Mensaje;
                Mensaje = "";
                if (txtCuotaDesde.Text.Length == 0) { Mensaje += "Falta cuota inicial." + Environment.NewLine; };
                if (txtCuotaHasta.Text.Length == 0) { Mensaje += "Falta cuota final." + Environment.NewLine; };
                if (txtCantCuotas.Text.Length == 0) { Mensaje += "Falta cuota final." + Environment.NewLine; };

                if (Mensaje.Length == 0)
                {
                    if (int.Parse(txtCuotaDesde.Text) > int.Parse(txtCuotaHasta.Text))
                    {
                        Mensaje += "Cuota inicial debe ser menor a cuota final." + Environment.NewLine;
                    }
                    if (int.Parse(txtCuotaHasta.Text) > int.Parse(txtCantCuotas.Text))
                    {
                        Mensaje += "El limite de cuotas es " + txtCantCuotas.Text + Environment.NewLine;
                    }
                }

                if (txtDescuento.Text.Length == 0) { Mensaje += "Falta descuento." + Environment.NewLine; };

                #endregion
                if (Mensaje.Length > 0)
                {
                    frmVentanaInformativa ofrmVentanaInformativa = new frmVentanaInformativa(Mensaje);
                    ofrmVentanaInformativa.ShowDialog();
                }
                else
                {
                    AgregarDetalleMoratoria();
                }
            }

            private void btnEliminarUltimo_Click(object sender, EventArgs e)
            {
                if (_dtDetallesMoratoria.Rows.Count > 0)
                {
                    int indexUltimo = _dtDetallesMoratoria.Rows.Count - 1;

                    if (int.Parse(_dtDetallesMoratoria.Rows[indexUltimo]["iddetalles_moratoria"].ToString()) > 0)
                    {
                        DetallesMoratoriaImplement oDetallesMoratoriaImplement = new DetallesMoratoriaImplement();
                        oDetallesMoratoriaImplement.Delete(int.Parse(_dtDetallesMoratoria.Rows[indexUltimo]["iddetalles_moratoria"].ToString()));
                    }
                    _dtDetallesMoratoria.Rows.RemoveAt(indexUltimo);
                    dgvDetallesMoratoria.DataSource = _dtDetallesMoratoria;
                    if (_dtDetallesMoratoria.Rows.Count == 0)
                    {
                        _primeraCuota = 1;
                        txtCuotaDesde.Text = _primeraCuota.ToString();
                    }
                    else {
                        _primeraCuota = int.Parse(_dtDetallesMoratoria.Rows[indexUltimo - 1]["cuota_hasta"].ToString()) + 1;
                        txtCuotaDesde.Text = _primeraCuota.ToString();
                    }
                }
            }

            private void txtCantCuotas_KeyPress(object sender, KeyPressEventArgs e)
            {
                Commons oCommons = new Commons();
                oCommons.ValidarNumeroEntero(sender, e);
            }

            private void txtCuotaDesde_KeyPress(object sender, KeyPressEventArgs e)
            {
                Commons oCommons = new Commons();
                oCommons.ValidarNumeroEntero(sender, e);
            }

            private void txtCuotaHasta_KeyPress(object sender, KeyPressEventArgs e)
            {
                Commons oCommons = new Commons();
                oCommons.ValidarNumeroEntero(sender, e);
            }

            private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
            {
                Commons oCommons = new Commons();
                oCommons.ValidarNumeroDecimal(sender, e, this.txtDescuento);
            }

            private void tsbCancelar_Click(object sender, EventArgs e)
            {
                Inicializar();
            }
        
            #endregion

        #endregion

        #region << METODOS >>

        private void Inicializar()
        {
            _dtDetallesMoratoria.Clear();
            _dtDetallesMoratoria = new DataTable();
            _dtDetallesMoratoria.Columns.AddRange(new DataColumn[5] { new DataColumn("iddetalles_moratoria", typeof(int)),  
                            new DataColumn("idmoratoria", typeof(int)),  
                            new DataColumn("cuota_desde",typeof(int)),
                            new DataColumn("cuota_hasta",typeof(decimal)),
                            new DataColumn("descuento",typeof(int))});
            txtCuotaDesde.Text = "1";
            txtCuotaDesde.Enabled = false;
            txtCantCuotas.Text = "";
            chkLimitar.Checked = false;
            txtCuotaHasta.Text = "";
            txtDescuento.Text = "";
            InicializarLeyendas();

            if (_idMoratoria > 0)
            { 
                //Editar
                CargarMoratoria();
            }
        }    
           
        #region <Moratoria>

            private void CargarMoratoria() 
            {
                moratorias oMoratorias = new moratorias();
                MoratoriasImplement oMoratoriasImplement = new MoratoriasImplement();
                oMoratorias = oMoratoriasImplement.Get(_idMoratoria);
                dtpFechaInicial.Value = (DateTime)oMoratorias.vigencia_desde;
                dtpFechafinal.Value = (DateTime)oMoratorias.vigencia_hasta;
                txtCantCuotas.Text = oMoratorias.cantidad_cuotas_max.ToString();
                chkLimitar.Checked = (bool)oMoratorias.limitar;

                DetallesMoratoriaImplement oDetallesMoratoriaImplement = new DetallesMoratoriaImplement();
                _dtDetallesMoratoria = oDetallesMoratoriaImplement.GetAllByIdMoratoria(_idMoratoria);
                dgvDetallesMoratoria.DataSource = _dtDetallesMoratoria;

                int indexUltimo = _dtDetallesMoratoria.Rows.Count - 1;
                _primeraCuota = int.Parse(_dtDetallesMoratoria.Rows[indexUltimo]["cuota_hasta"].ToString()) + 1;
                txtCuotaDesde.Text = _primeraCuota.ToString();

            }

            private void AgregarDetalleMoratoria()
            {
                _primeraCuota = int.Parse(txtCuotaHasta.Text) + 1;
                _dtDetallesMoratoria.Rows.Add(0, _idMoratoria, int.Parse(txtCuotaDesde.Text), int.Parse(txtCuotaHasta.Text), decimal.Parse(txtDescuento.Text.Replace(".", ",")));
                dgvDetallesMoratoria.DataSource = _dtDetallesMoratoria;
                txtCuotaDesde.Text = _primeraCuota.ToString();
                txtCuotaHasta.Text = "";
                txtDescuento.Text = "";
            }

            private void GuardarMoratoria()
            {
                //verificar si hay una moratoria q cruce fechas
                MoratoriasImplement oMoratoriasImplement = new MoratoriasImplement();
                bool existeMoratoria = oMoratoriasImplement.ExisteMoratoria(DateTime.Parse(dtpFechaInicial.Text), DateTime.Parse(dtpFechafinal.Text), _idMoratoria);
                if (!existeMoratoria)
                {
                    moratorias oMoratoria = new moratorias();
                    oMoratoria.vigencia_desde = DateTime.Parse(dtpFechaInicial.Text);
                    oMoratoria.vigencia_hasta = DateTime.Parse(dtpFechafinal.Text);
                    oMoratoria.cantidad_cuotas_max = int.Parse(txtCantCuotas.Text);
                    oMoratoria.limitar = chkLimitar.Checked;
                    if (_idMoratoria > 0)
                    {
                        oMoratoria.idmoratorias = _idMoratoria;
                        oMoratoriasImplement.Update(oMoratoria);
                    }
                    else
                    {
                        _idMoratoria = oMoratoriasImplement.Save(oMoratoria);
                    }
                    DetallesMoratoriaImplement oDetallesMoratoriaImplement = new DetallesMoratoriaImplement();
                    int ultimaCuota = 1;
                    foreach(DataRow dr in _dtDetallesMoratoria.Rows)
                    {
                        if (int.Parse(dr["iddetalles_moratoria"].ToString()) == 0)
                        {
                            detalles_moratoria oDetallesMoratoria = new detalles_moratoria();
                            oDetallesMoratoria.idmoratoria = _idMoratoria;
                            oDetallesMoratoria.cuota_desde = int.Parse(dr["cuota_desde"].ToString());
                            oDetallesMoratoria.cuota_hasta = int.Parse(dr["cuota_hasta"].ToString());
                            oDetallesMoratoria.descuento = decimal.Parse(dr["descuento"].ToString());
                            oDetallesMoratoriaImplement.Save(oDetallesMoratoria);
                            ultimaCuota = int.Parse(dr["cuota_hasta"].ToString());
                        }
                    }
                    int indexUltimo = _dtDetallesMoratoria.Rows.Count - 1;
                    ultimaCuota = int.Parse(_dtDetallesMoratoria.Rows[indexUltimo]["cuota_hasta"].ToString());
                    if (ultimaCuota < oMoratoria.cantidad_cuotas_max)
                    {
                        detalles_moratoria oDetallesMoratoria = new detalles_moratoria();
                        oDetallesMoratoria.idmoratoria = _idMoratoria;
                        oDetallesMoratoria.cuota_desde = ultimaCuota+1;
                        oDetallesMoratoria.cuota_hasta = oMoratoria.cantidad_cuotas_max;
                        oDetallesMoratoria.descuento = 0;
                        oDetallesMoratoriaImplement.Save(oDetallesMoratoria);
                    }
                    Inicializar();
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else {
                    frmVentanaInformativa ofrmVentanaInformativa = new frmVentanaInformativa("Existe una moratoria que comprende alguna de las fechas ingresadas.");
                    ofrmVentanaInformativa.ShowDialog();
                }



            }

            #endregion

        #region <Leyendas>
            private void InicializarLeyendas() { 
                SysConfigImplement oSysConfigImplement=new SysConfigImplement();
                this.txtObsComun.Text = oSysConfigImplement.GetByNombre("ObsComun").valor;
                this.txtObsDeuda.Text = oSysConfigImplement.GetByNombre("ObsDeuda").valor;
                this.txtObsDeuda2.Text = oSysConfigImplement.GetByNombre("ObsDeuda2").valor;
            }

            private void GuardarLeyendas() {
                SysConfigImplement oSysConfigImplement = new SysConfigImplement();
                sys_configuracion oSysObsComun = new sys_configuracion();
                oSysObsComun = oSysConfigImplement.GetByNombre("ObsComun");
                oSysObsComun.valor=this.txtObsComun.Text;
                oSysConfigImplement.Save(oSysObsComun);

                sys_configuracion oSysObsDeuda = new sys_configuracion();
                oSysObsDeuda = oSysConfigImplement.GetByNombre("ObsDeuda");
                oSysObsDeuda.valor = this.txtObsDeuda.Text;
                oSysConfigImplement.Save(oSysObsDeuda);

                sys_configuracion oSysObsDeuda2 = new sys_configuracion();
                oSysObsDeuda2 = oSysConfigImplement.GetByNombre("ObsDeuda2");
                oSysObsDeuda2.valor = this.txtObsDeuda2.Text;
                oSysConfigImplement.Save(oSysObsDeuda2);
            }


        #endregion

























        #endregion



    }
}
