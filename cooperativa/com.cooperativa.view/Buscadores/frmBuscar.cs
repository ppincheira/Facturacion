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
using System.Collections;

namespace com.cooperativa.view.Buscadores
{
    public partial class frmBuscar : Form
    {
        #region << PROPIEDADES >>
        string  _IVAs ="";
        string _Categorias = "";
        string _EstadosConexion = "";
        string _ZonaFacturacion = "";
        string _Tarifas = "";
        string _SituacionEspecial = "";

        string _Barrios = "";
        string _Calles = "";
        string _Provincias = "";
        string _BarriosLegal = "";
        string _CallesLegal = "";
        string _Localidad = "";

        string _Rutas = "";
        string _Orden = "";
        string _Entidades = "";

        DataTable _DataSocios;

        #endregion

        #region << EVENTOS >>
        public frmBuscar()
        {
            InitializeComponent();
        }

        private void frmBuscar_Load(object sender, EventArgs e)
        {
            Inicializar();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            #region <<Datos Socio>>
            
            if (panelIVA.Visible)
            {
                _IVAs = "";
                panelIVA.Visible = false;
                for (int i = 0; i < chkListIVA.Items.Count; i++)
                {
                    if (chkListIVA.GetItemChecked(i))
                    {
                        _IVAs = _IVAs + "'" + chkListIVA.Items[i].ToString() + "',";
                    }
                }

                txtIVAs.Text = _IVAs;
            }
            
            if (panelCategorias.Visible)
            {
                _Categorias = "";
                panelCategorias.Visible = false;
                for (int i = 0; i < chkListCategorias.Items.Count; i++)
                {
                    if (chkListCategorias.GetItemChecked(i))
                    {
                        _Categorias = _Categorias + "'" + chkListCategorias.Items[i].ToString().Trim() + "',";
                    }
                }

                txtCategorias.Text = _Categorias;
            }
            
            if (panelEstadoConexion.Visible)
            {
                _EstadosConexion = "";
                panelEstadoConexion.Visible = false;
                for (int i = 0; i < chkListEstadoConexion.Items.Count; i++)
                {
                    if (chkListEstadoConexion.GetItemChecked(i))
                    {
                        _EstadosConexion = _EstadosConexion + "'" + chkListEstadoConexion.Items[i].ToString() + "',";
                    }
                }

                txtEstadoConexion.Text = _EstadosConexion;
            }
            
            if (panelSituacionEsp.Visible)
            {
                _SituacionEspecial = "";
                panelSituacionEsp.Visible = false;
                for (int i = 0; i < chkListSituacionEsp.Items.Count; i++)
                {
                    if (chkListSituacionEsp.GetItemChecked(i))
                    {
                        _SituacionEspecial = _SituacionEspecial + "'" + chkListSituacionEsp.Items[i].ToString() + "',";
                    }
                }

                txtSituacionEsp.Text = _SituacionEspecial;
            }
            
            if (panelTarifa.Visible)
            {
                _Tarifas = "";
                panelTarifa.Visible = false;
                for (int i = 0; i < chkListTarifa.Items.Count; i++)
                {
                    if (chkListTarifa.GetItemChecked(i))
                    {
                        _Tarifas = _Tarifas + "'" + chkListTarifa.Items[i].ToString().Replace("'", "''").Trim() + "',";
                    }
                }

                txtTarifa.Text = _Tarifas;
            }
            
            if (panelZonaFacturacion.Visible)
            {
                _ZonaFacturacion = "";
                panelZonaFacturacion.Visible = false;
                for (int i = 0; i < chkListZonaFacturacion.Items.Count; i++)
                {
                    if (chkListZonaFacturacion.GetItemChecked(i))
                    {
                        _ZonaFacturacion = _ZonaFacturacion + "'" + chkListZonaFacturacion.Items[i].ToString() + "',";
                    }
                }

                txtZonaFacturacion.Text = _ZonaFacturacion;
            }
            #endregion

            #region <<Datos Varios>>
            

            if (panelBarrio.Visible)
            {
                _Barrios = "";
                txtBarrio.Text = "";
                panelBarrio.Visible = false;
                for (int i = 0; i < chkListBarrio.Items.Count; i++)
                {
                    if (chkListBarrio.GetItemChecked(i))
                    {
                        _Barrios = _Barrios + "'" + ((cod_barrios)(chkListBarrio.Items[i])).id_barrio.ToString() + "',";
                        txtBarrio.Text = txtBarrio.Text + ((cod_barrios)(chkListBarrio.Items[i])).barrio + ",";
                    }
                }


            }

            if (panelCalle.Visible)
            {
                _Calles = "";
                txtCalle.Text = "";
                panelCalle.Visible = false;
                for (int i = 0; i < chkListCalle.Items.Count; i++)
                {
                    if (chkListCalle.GetItemChecked(i))
                    {
                        _Calles = _Calles + "'" + ((cod_calles)(chkListCalle.Items[i])).id_calle.ToString() + "',";
                        txtCalle.Text = txtCalle.Text + ((cod_calles)(chkListCalle.Items[i])).calle + ",";
                    }
                }


            }
            
            if (panelProvincia.Visible)
            {
                _Provincias = "";
                txtProvincia.Text = "";
                panelProvincia.Visible = false;
                for (int i = 0; i < chkListProvincia.Items.Count; i++)
                {
                    if (chkListProvincia.GetItemChecked(i))
                    {
                        _Provincias = _Provincias + "'" + ((cod_provincias)(chkListProvincia.Items[i])).id_provincia.ToString() + "',";
                        txtProvincia.Text = txtProvincia.Text + ((cod_provincias)(chkListProvincia.Items[i])).provincia + ",";
                    }
                }


            }
           
            if (panelBarrioLegal.Visible)
            {
                _BarriosLegal = "";
                txtBarrioLegal.Text = "";
                panelBarrioLegal.Visible = false;
                for (int i = 0; i < chkListBarrioLegal.Items.Count; i++)
                {
                    if (chkListBarrioLegal.GetItemChecked(i))
                    {
                        _BarriosLegal = _BarriosLegal + "'" + ((cod_barrios)(chkListBarrioLegal.Items[i])).id_barrio.ToString() + "',";
                        txtBarrioLegal.Text = txtBarrioLegal.Text + ((cod_barrios)(chkListBarrioLegal.Items[i])).barrio + ",";
                    }
                }


            }
           
            if (panelCalleLegal.Visible)
            {
                _CallesLegal = "";
                txtCalleLegal.Text = "";
                panelCalleLegal.Visible = false;
                for (int i = 0; i < chkListCalleLegal.Items.Count; i++)
                {
                    if (chkListCalle.GetItemChecked(i))
                    {
                        _CallesLegal = _CallesLegal + "'" + ((cod_calles)(chkListCalleLegal.Items[i])).id_calle.ToString() + "',";
                        txtCalleLegal.Text = txtCalleLegal.Text + ((cod_calles)(chkListCalleLegal.Items[i])).calle + ",";
                    }
                }
            }

            if (panelLocalidad.Visible)
            {
                _Localidad = "";
                txtLocalidad.Text = "";
                panelLocalidad.Visible = false;
                for (int i = 0; i < chkListLocalidad.Items.Count; i++)
                {
                    if (chkListLocalidad.GetItemChecked(i))
                    {
                        _Localidad = _Localidad + "'" + ((cod_localidades)(chkListLocalidad.Items[i])).id_localidad.ToString() + "',";
                        txtLocalidad.Text = txtLocalidad.Text + ((cod_localidades)(chkListLocalidad.Items[i])).localidad + ",";
                    }
                }
            }
            #endregion

            #region <<Datos Catastral>>
            

            if (panelEntidad.Visible)
            {
                _Entidades = "";
                txtEntidad.Text = "";
                panelEntidad.Visible = false;
                for (int i = 0; i < chkListEntidad.Items.Count; i++)
                {
                    if (chkListEntidad.GetItemChecked(i))
                    {
                        _Entidades = _Entidades + "'" + ((cod_prestador)(chkListEntidad.Items[i])).id_prestador.ToString() + "',";
                        txtEntidad.Text = txtEntidad.Text + ((cod_prestador)(chkListEntidad.Items[i])).prestador + ",";
                    }
                }
            }
            #endregion

            SocioImplement oSocioImplement = new SocioImplement();
            string _CodigoSocio = "";
            if(mtxtNumero.Text.Length>=6)
                _CodigoSocio = this.mtxtNumero.Text.Substring(0, 6);
             string _SubcodigoSocio = "";
             if (mtxtNumero.Text.Length >= 9)
                _SubcodigoSocio = this.mtxtNumero.Text.Substring(7, 2);

            _DataSocios = oSocioImplement.SociosGetByFilters(_IVAs, _Categorias, _EstadosConexion, _SituacionEspecial, _Tarifas,
                    _ZonaFacturacion, _CodigoSocio, _SubcodigoSocio, this.txtNombre.Text, this.mtxtDocumento.Text, this.mtxtCuit.Text,
                    this.dtpFecha.Text, _Barrios, _Calles, _Provincias, _BarriosLegal, _CallesLegal, _Localidad, _Entidades,
                    txtDcDistrito.Text, txtDcAltura.Text, txtDLCP.Text, txtDlAltura.Text, mtbLNomenclarura.Text, txtLManzana.Text, 
                    txtLLote.Text, txtMedidor.Text);
            this.dgSocios.DataSource = _DataSocios;
        }

        

        #region << Datos Socios>>

        private void btnCmbIVA_Click(object sender, EventArgs e)
        {
            _IVAs = "";
            if (panelIVA.Visible)
            {
                panelIVA.Visible = false;
                for (int i = 0; i < chkListIVA.Items.Count; i++)
                {
                    if (chkListIVA.GetItemChecked(i))
                    {
                        _IVAs = _IVAs + "'" + chkListIVA.Items[i].ToString() + "',";
                    }
                }

                txtIVAs.Text = _IVAs;
            }
            else
                panelIVA.Visible = true;
           

        }

        private void btnCmbCategorias_Click(object sender, EventArgs e)
        {
            _Categorias = "";
            if (panelCategorias.Visible)
            {
                panelCategorias.Visible = false;
                for (int i = 0; i < chkListCategorias.Items.Count; i++)
                {
                    if (chkListCategorias.GetItemChecked(i))
                    {
                        _Categorias = _Categorias + "'" + chkListCategorias.Items[i].ToString().Trim() + "',";
                    }
                }

                txtCategorias.Text = _Categorias;
            }
            else
                panelCategorias.Visible = true;
        }

        private void btnCmbEstadoConexion_Click(object sender, EventArgs e)
        {
            _EstadosConexion = "";
            if (panelEstadoConexion.Visible)
            {
                panelEstadoConexion.Visible = false;
                for (int i = 0; i < chkListEstadoConexion.Items.Count; i++)
                {
                    if (chkListEstadoConexion.GetItemChecked(i))
                    {
                        _EstadosConexion = _EstadosConexion + "'" + chkListEstadoConexion.Items[i].ToString() + "',";
                    }
                }

                txtEstadoConexion.Text = _EstadosConexion;
            }
            else
                panelEstadoConexion.Visible = true;
        }

        private void btncmbSituacionEsp_Click(object sender, EventArgs e)
        {

            _SituacionEspecial = "";
            if (panelSituacionEsp.Visible)
            {
                panelSituacionEsp.Visible = false;
                for (int i = 0; i < chkListSituacionEsp.Items.Count; i++)
                {
                    if (chkListSituacionEsp.GetItemChecked(i))
                    {
                        _SituacionEspecial = _SituacionEspecial + "'" + chkListSituacionEsp.Items[i].ToString() + "',";
                    }
                }

                txtSituacionEsp.Text = _SituacionEspecial;
            }
            else
                panelSituacionEsp.Visible = true;

        }

        private void btnCmbTarifa_Click(object sender, EventArgs e)
        {
            _Tarifas = "";
            if (panelTarifa.Visible)
            {
                panelTarifa.Visible = false;
                for (int i = 0; i < chkListTarifa.Items.Count; i++)
                {
                    if (chkListTarifa.GetItemChecked(i))
                    {
                        _Tarifas = _Tarifas + "'" + chkListTarifa.Items[i].ToString().Replace("'", "''").Trim() + "',";
                    }
                }

                txtTarifa.Text = _Tarifas;
            }
            else
                panelTarifa.Visible = true;

        }

        private void btnCmbZonaFacturacion_Click(object sender, EventArgs e)
        {
            _ZonaFacturacion = "";
            if (panelZonaFacturacion.Visible)
            {
                panelZonaFacturacion.Visible = false;
                for (int i = 0; i < chkListZonaFacturacion.Items.Count; i++)
                {
                    if (chkListZonaFacturacion.GetItemChecked(i))
                    {
                        _ZonaFacturacion = _ZonaFacturacion + "'" + chkListZonaFacturacion.Items[i].ToString() + "',";
                    }
                }

                txtZonaFacturacion.Text = _ZonaFacturacion;
            }
            else
                panelZonaFacturacion.Visible = true;
        }

        #endregion

        #region <<Datos Varios>>

        private void btnCmbBarrio_Click(object sender, EventArgs e)
        {
            _Barrios = "";
            
            if (panelBarrio.Visible)
            {
                txtBarrio.Text = "";
                panelBarrio.Visible = false;
                for (int i = 0; i < chkListBarrio.Items.Count; i++)
                {
                    if (chkListBarrio.GetItemChecked(i))
                    {
                        _Barrios = _Barrios + "'" + ((cod_barrios)(chkListBarrio.Items[i])).id_barrio.ToString() + "',";
                        txtBarrio.Text = txtBarrio.Text + ((cod_barrios)(chkListBarrio.Items[i])).barrio + ",";
                    }
                }

               
            }
            else
                panelBarrio.Visible = true;
        }

        private void btnCmbCalle_Click(object sender, EventArgs e)
        {
            _Calles = "";

            if (panelCalle.Visible)
            {
                txtCalle.Text = "";
                panelCalle.Visible = false;
                for (int i = 0; i < chkListCalle.Items.Count; i++)
                {
                    if (chkListCalle.GetItemChecked(i))
                    {
                        _Calles = _Calles + "'" + ((cod_calles)(chkListCalle.Items[i])).id_calle.ToString() + "',";
                        txtCalle.Text = txtCalle.Text + ((cod_calles)(chkListCalle.Items[i])).calle + ",";
                    }
                }


            }
            else
                panelCalle.Visible = true;
        }

        private void btnCmbProvincia_Click(object sender, EventArgs e)
        {
            _Provincias = "";

            if (panelProvincia.Visible)
            {
                txtProvincia.Text = "";
                panelProvincia.Visible = false;
                for (int i = 0; i < chkListProvincia.Items.Count; i++)
                {
                    if (chkListProvincia.GetItemChecked(i))
                    {
                        _Provincias = _Provincias + "'" + ((cod_provincias)(chkListProvincia.Items[i])).id_provincia.ToString() + "',";
                        txtProvincia.Text = txtProvincia.Text + ((cod_provincias)(chkListProvincia.Items[i])).provincia + ",";
                    }
                }


            }
            else
                panelProvincia.Visible = true;
        }

        private void btnCmbBarrioLegal_Click(object sender, EventArgs e)
        {
            _BarriosLegal = "";

            if (panelBarrioLegal.Visible)
            {
                txtBarrioLegal.Text = "";
                panelBarrioLegal.Visible = false;
                for (int i = 0; i < chkListBarrioLegal.Items.Count; i++)
                {
                    if (chkListBarrioLegal.GetItemChecked(i))
                    {
                        _BarriosLegal = _BarriosLegal + "'" + ((cod_barrios)(chkListBarrioLegal.Items[i])).id_barrio.ToString() + "',";
                        txtBarrioLegal.Text = txtBarrioLegal.Text + ((cod_barrios)(chkListBarrioLegal.Items[i])).barrio + ",";
                    }
                }


            }
            else
                panelBarrioLegal.Visible = true;
        }

        private void btnCalleLegal_Click(object sender, EventArgs e)
        {
            _CallesLegal = "";

            if (panelCalleLegal.Visible)
            {
                txtCalleLegal.Text = "";
                panelCalleLegal.Visible = false;
                for (int i = 0; i < chkListCalleLegal.Items.Count; i++)
                {
                    if (chkListCalle.GetItemChecked(i))
                    {
                        _CallesLegal = _CallesLegal + "'" + ((cod_calles)(chkListCalleLegal.Items[i])).id_calle.ToString() + "',";
                        txtCalleLegal.Text = txtCalleLegal.Text + ((cod_calles)(chkListCalleLegal.Items[i])).calle + ",";
                    }
                }


            }
            else
                panelCalleLegal.Visible = true;
        }

        private void btnCmbLocalidad_Click(object sender, EventArgs e)
        {
            _Localidad = "";

            if (panelLocalidad.Visible)
            {
                txtLocalidad.Text = "";
                panelLocalidad.Visible = false;
                for (int i = 0; i < chkListLocalidad.Items.Count; i++)
                {
                    if (chkListLocalidad.GetItemChecked(i))
                    {
                        _Localidad = _Localidad + "'" + ((cod_localidades)(chkListLocalidad.Items[i])).id_localidad.ToString() + "',";
                        txtLocalidad.Text = txtLocalidad.Text + ((cod_localidades)(chkListLocalidad.Items[i])).localidad + ",";
                    }
                }


            }
            else
                panelLocalidad.Visible = true;
        }

        #endregion

        #region <<Datos Catastral>>

        private void btnCmbRuta_Click(object sender, EventArgs e)
        {
            //_Rutas = "";

            //if (panelRuta.Visible)
            //{
            //    txtRuta.Text = "";
            //    panelRuta.Visible = false;
            //    for (int i = 0; i < chkListRuta.Items.Count; i++)
            //    {
            //        if (chkListRuta.GetItemChecked(i))
            //        {
            //            _Rutas = _Rutas + "'" + (()(chkListRuta.Items[i])).id_localidad.ToString() + "',";
            //            txtRuta.Text = txtRuta.Text + ((cod_localidades)(chkListRuta.Items[i])).localidad + ",";
            //        }
            //    }


            //}
            //else
            //    panelRuta.Visible = true;
        }

        private void btnCmbOrden_Click(object sender, EventArgs e)
        {

        }

        private void btnCmbEntidad_Click(object sender, EventArgs e)
        {
            _Entidades = "";

            if (panelEntidad.Visible)
            {
                txtEntidad.Text = "";
                panelEntidad.Visible = false;
                for (int i = 0; i < chkListEntidad.Items.Count; i++)
                {
                    if (chkListEntidad.GetItemChecked(i))
                    {
                        _Entidades = _Entidades + "'" + ((cod_prestador)(chkListEntidad.Items[i])).id_prestador.ToString() + "',";
                        txtEntidad.Text = txtEntidad.Text + ((cod_prestador)(chkListEntidad.Items[i])).prestador + ",";
                    }
                }


            }
            else
                panelEntidad.Visible = true;
        }

        #endregion

        #endregion

        #region << METODOS >>

        private void Inicializar() {
            



            #region <<Datos Socios>>

            panelIVA.Visible = false;
            panelCategorias.Visible = false;
            panelEstadoConexion.Visible = false;
            panelSituacionEsp.Visible = false;
            panelZonaFacturacion.Visible = false;
            panelTarifa.Visible = false;

            CargarIVAs();
            CargarCategorias();
            CargarEstadosConexion();
            CargarTarifas();
            CargarZonasFacturacion();
            CargarSituacionesEspeciales();
            #endregion

            #region <<Datos Varios>>

            panelBarrio.Visible = false;
            panelCalle.Visible = false;
            panelBarrioLegal.Visible = false;
            panelCalleLegal.Visible = false;
            panelProvincia.Visible = false;
            panelLocalidad.Visible = false;

            CargarBarrios();
            CargarCalles();
            CargarProvincias();
            CargarBarriosLegal();
            CargarCallesLegal();
            CargarLocalidades();

            #endregion

            #region <<Datos Catastral>>
            panelRuta.Visible = false;
            panelOrden.Visible = false;
            panelEntidad.Visible = false;

            CargarEntidades();
            #endregion

        }

        #region <<Datos Socios>>

        private void CargarIVAs()
        {
            ImpuestoImplement oImpuestoImplement = new ImpuestoImplement();
            cod_impuestos oCod_impuestos = new cod_impuestos();
            List<cod_impuestos> _listImpuestos = oImpuestoImplement.GetAll();

            
            foreach(cod_impuestos impuestos in _listImpuestos)
            {
                chkListIVA.Items.Add(impuestos.impuesto);
            }
               
        }

        private void CargarCategorias()
        {
            CategoriaImplement oCategoriaImplement = new CategoriaImplement();
            List<cod_categorias> _listCategorias = oCategoriaImplement.GetAll();


            foreach (cod_categorias categoria in _listCategorias)
            {
                chkListCategorias.Items.Add(categoria.categoria);
            }
        }
        
        private void CargarEstadosConexion()
        {
            EstadoSocioImplement oEstadoSocioImplement = new EstadoSocioImplement();
            List<cod_estados_socios> _listEstadosConexion = oEstadoSocioImplement.GetAll();


            foreach (cod_estados_socios estadoConexion in _listEstadosConexion)
            {
                chkListEstadoConexion.Items.Add(estadoConexion.estado_socio);
            }
        }

        private void CargarTarifas()
        {
            TarifaImplement oTarifaImplement = new TarifaImplement();
            List<tarifas> _listTarifas = oTarifaImplement.GetAll();
            foreach (tarifas tarifa in _listTarifas)
            {
                chkListTarifa.Items.Add(tarifa.tarifa);
            }

        }

        private void CargarZonasFacturacion()
        {
            ZonaImplement oZonaImplement = new ZonaImplement();
            List<cod_zonas> _listZonas = oZonaImplement.GetAll();
            foreach (cod_zonas zona in _listZonas)
            {
                chkListZonaFacturacion.Items.Add(zona.zona);
            }
        }

        private void CargarSituacionesEspeciales()
        {
            SituacionEspecialImplement oSituacionEspecialImplement = new SituacionEspecialImplement();
            List<cod_situacion_especial> _listSituacionEspecial = oSituacionEspecialImplement.GetAll();


            foreach (cod_situacion_especial situacion in _listSituacionEspecial)
            {
                chkListSituacionEsp.Items.Add(situacion.situacion_especial);
            }
        }

        #endregion     

        #region <<Datos Varios>>

        private void CargarBarrios()
        {
            BarrioImplement oBarrioImplement = new BarrioImplement();
            IList ListaBarrios = oBarrioImplement.GetAll();
            chkListBarrio.DataSource = ListaBarrios;
            chkListBarrio.DisplayMember = "barrio";
            chkListBarrio.ValueMember = "id_barrio";
        }

        private void CargarCalles()
        {
            CalleImplement oCalleImplement = new CalleImplement();
            IList ListaCalles = oCalleImplement.GetAll();
            chkListCalle.DataSource = ListaCalles;
            chkListCalle.DisplayMember = "calle";
            chkListCalle.ValueMember = "id_calle";
        }
      
        private void CargarProvincias()
        {
            ProvinciaImplement oProvinciaImplement = new ProvinciaImplement();
            IList ListaProvincias = oProvinciaImplement.GetAll();
            chkListProvincia.DataSource = ListaProvincias;
            chkListProvincia.DisplayMember = "provincia";
            chkListProvincia.ValueMember = "id_provincia";
        }
       
        private void CargarBarriosLegal()
        {
            BarrioImplement oBarrioImplement = new BarrioImplement();
            IList ListaBarrios = oBarrioImplement.GetAll();
            chkListBarrioLegal.DataSource = ListaBarrios;
            chkListBarrioLegal.DisplayMember = "barrio";
            chkListBarrioLegal.ValueMember = "id_barrio";
        }

        private void CargarCallesLegal()
        {
            CalleImplement oCalleImplement = new CalleImplement();
            IList ListaCalles = oCalleImplement.GetAll();
            chkListCalleLegal.DataSource = ListaCalles;
            chkListCalleLegal.DisplayMember = "calle";
            chkListCalleLegal.ValueMember = "id_calle";
        }

        private void CargarLocalidades()
        {
            LocalidadImplement oLocalidadImplement = new LocalidadImplement();
            IList ListaLocalidad = oLocalidadImplement.GetAll();
            chkListLocalidad.DataSource = ListaLocalidad;
            chkListLocalidad.DisplayMember = "localidad";
            chkListLocalidad.ValueMember = "id_localidad";
        }

        #endregion
       
        #region <<Datos Catastral>>

        private void CargarEntidades()
        {
            PrestadorImplement oPrestadorImplement = new PrestadorImplement();
            IList ListaPrestador = oPrestadorImplement.GetAll();
            chkListEntidad.DataSource = ListaPrestador;
            chkListEntidad.DisplayMember = "prestador";
            chkListEntidad.ValueMember = "id_prestador";
        }

        #endregion

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            frmSocio frm = new frmSocio(_DataSocios);
            frm.Text = "Socios";
            frm.Show();
            this.Close();
            
        }

       

        #endregion






    }
}
