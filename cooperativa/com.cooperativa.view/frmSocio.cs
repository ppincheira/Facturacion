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
namespace com.cooperativa.view
{
    public partial class frmSocio : Form
    {
        #region << PROPIEDADES >>
        int _idSocio;
        int _idInf;
        int _idSup;
        int _indice;
        bool _origenBuscar = false;
        DataTable _DataSocios;

        #endregion
        #region << EVENTOS >>

        public frmSocio()
        {
            InitializeComponent();
        }

        public frmSocio(DataTable dtsocios)
        {
            _DataSocios = dtsocios;
            _origenBuscar = true;
            InitializeComponent();
        }

        private void frmSocio_Load(object sender, EventArgs e)
        {
            try
            {
                Inicializar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en "+ ex.Source +" Mensaje: "+ex.Message+" -- "+ex.InnerException);
            
            }
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                NuevoSocio();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en "+ ex.Source +"Mensaje: "+ex.Message);
            
            }
            
        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {
            try{
                ModificarSocio();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message + "--"+ex.InnerException);

            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            try { 
                //Revisar si se puede y bajo que condicciones.
                   }
            catch (Exception ex)
            {
                MessageBox.Show("Error en "+ ex.Source +" Mensaje: "+ex.Message);
            
            }
        }

        private void tsbImprimir_Click(object sender, EventArgs e)
        {
            try { }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message);

            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                #region <Validacion>
                    string Mensaje;
                    Mensaje = "";
                    if (txtNombre.Text.Length == 0) { Mensaje += "Falta Ingresar el nombre del socio." + Environment.NewLine; };
                    if (int.Parse(cmbTipoDni.SelectedValue.ToString()) == 0) { Mensaje += "Falta el tipo de documento del socio." + Environment.NewLine; };
                    if (mtxtDocumento.Text.Length == 0) { Mensaje += "Falta el numero de documento del socio." + Environment.NewLine; };
                    if (int.Parse(cmbIVA.SelectedValue.ToString()) == 0) { Mensaje += "Falta el tipo de IVA." + Environment.NewLine; };
                    if (int.Parse(cmbCategoria.SelectedValue.ToString()) == 0) { Mensaje += "Falta la categoria de conexion." + Environment.NewLine; };
                    if (int.Parse(cmbEstadoConexion.SelectedValue.ToString()) == 0) { Mensaje += "Falta el estado de conexion." + Environment.NewLine; };

                    if (int.Parse(cmbTarifa.SelectedValue.ToString()) == 0) { Mensaje += "Falta el tipo de tarifa." + Environment.NewLine; };
                    if (int.Parse(cmbZona.SelectedValue.ToString()) == 0) { Mensaje += "Falta la zona de facturacion." + Environment.NewLine; };
                    if (int.Parse(cmbDcBarrio.SelectedValue.ToString()) == 0) { Mensaje += "Falta el barrio de la conexion." + Environment.NewLine; };
                    if (int.Parse(cmbDcCalle.SelectedValue.ToString()) == 0) { Mensaje += "Falta el codigo de la calle de conexion." + Environment.NewLine; };
                    if (txtDcDistrito.Text.Length == 0) { Mensaje += "Falta el districto electoral." + Environment.NewLine; };
                    

                    if (int.Parse(cmbDlProvincia.SelectedValue.ToString()) == 0) { Mensaje += "Falta provincia de residencia legal." + Environment.NewLine; };
                    if (int.Parse(cmbDLLocalidad.SelectedValue.ToString()) == 0) { Mensaje += "Falta localidad de residencia legal." + Environment.NewLine; };
                    if (int.Parse(cmbDlBarrio.SelectedValue.ToString()) == 0) { Mensaje += "Falta barrio de residencia legal." + Environment.NewLine; };
                    if (int.Parse(cmbDlCalle.SelectedValue.ToString()) == 0) { Mensaje += "Falta calle de residencia legal." + Environment.NewLine; };
                    if (txtDlAltura.Text.Length == 0) { Mensaje += "Falta altura de residencia legal." + Environment.NewLine; };
                    if (txtDLCP.Text.Length == 0) { Mensaje += "Falta codigo postal de residencia legal." + Environment.NewLine; };

                    if (mtbLNomenclarura.Text.Length == 0) { Mensaje += "Falta nomenclatura catastral." + Environment.NewLine; }
                    if (txtLManzana.Text.Length == 0) { Mensaje += "Falta la identificacion de la manzana." + Environment.NewLine; };
                    if (txtLLote.Text.Length == 0) { Mensaje += "Falta la identificacion del lote." + Environment.NewLine; };

                    if (int.Parse(cmbDTTipoConexion.SelectedValue.ToString()) == 0) { Mensaje += "Falta el tipo de conexion." + Environment.NewLine; };
                #endregion
                if (Mensaje.Length > 0)
                {
                    frmVentanaInformativa ofrmVentanaInformativa = new frmVentanaInformativa(Mensaje);
                    ofrmVentanaInformativa.ShowDialog();
                }
                else {
                    Guardar();
                    Inicializar();
                    Deshabilitar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try{
                Cancelar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message);

            }
        }

        private void btnObservaciones_Click(object sender, EventArgs e)
        {
            try{
            AbrirObservaciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message);

            }
        }

        private void btnConvenios_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirConvenios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message);

            }
        }

        private void btnCuentaCorriente_Click(object sender, EventArgs e)
        {
            try{
                AbrirCuentasCorrientes();
                }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message);

            }
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirFacturas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message);

            }
        }

        private void btnEstadosMedidor_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirEstadosMedidores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message);

            }
        }

        private void btnConceptosParticulares_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirConceptosParticulares();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message);

            }
        }

        private void tsbtnInicio_Click(object sender, EventArgs e)
        {
            try
            {
                _idSocio = _idInf;
                _indice = 0;
                CargarSocio();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message);

            }
        }

        private void tsbtnIzquierda_Click(object sender, EventArgs e)
        {
            try{
            if (_indice > 0)
                _indice = _indice - 1;
            _idSocio = int.Parse(_DataSocios.Rows[_indice]["id_socio"].ToString());
            CargarSocio();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message);

            }
        }

        private void tsbtnDerecha_Click(object sender, EventArgs e)
        {
            try{
            if (_indice < (_DataSocios.Rows.Count-1))
                _indice = _indice + 1;
            _idSocio = int.Parse(_DataSocios.Rows[_indice]["id_socio"].ToString());
            CargarSocio();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message);

            }
        }

        private void tsbtnFin_Click(object sender, EventArgs e)
        {
            try {
                _idSocio = _idSup;
                _indice = _DataSocios.Rows.Count - 1;
                CargarSocio();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message);

            }
        }

        private void btnIntimaciones_Click(object sender, EventArgs e)
        {
            try{
                AbrirIntimacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message);

            }
        }
        private void tsbFiltrar_Click(object sender, EventArgs e)
        {
            try{
            AbrirFiltro();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error en " + ex.Source + "Mensaje: " + ex.Message);

        }
        }

        private void cmbDcBarrio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAcciones_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirAccion();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + "Mensaje: " + ex.Message);

            }
        }

        #endregion
        #region << METODOS >>

        private void Inicializar()
        {
            CargarBusqueda();
            CargarSocios();
            InicializarDatosGenerales();
            InicializarDomicilioConexion();
            InicializarDomicilioLegal();
            InicializarVarios();
            InicializarDatosTecnicos();
            InicializarPagoElectronico();
            if (_idSocio != 0)
                CargarSocio();
            DeshabilitarControles();
        }

        private void CargarBusqueda()
        { 
            var source = new AutoCompleteStringCollection();
            SocioImplement oSocioImplement=new SocioImplement();
            List<string> lista = new List<string>();
            if (_origenBuscar)
                foreach (DataRow dr in _DataSocios.Rows)
                {
                    lista.Add(dr["nombre"].ToString());
                }
            else
                lista = oSocioImplement.GetAllCustomer();
            tsTxtBuscar.AutoCompleteMode=AutoCompleteMode.SuggestAppend;
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            data.AddRange(lista.ToArray());                                                                                                                    
            tsTxtBuscar.AutoCompleteCustomSource = data;
            tsTxtBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void DeshabilitarControles(){
            DeshabilitarDatosTecnicos();
            DeshabilitarDomicilioConexion();
            DeshabilitarDomicilioLegal();
            DeshabilitarLote();
            DeshabilitarGeneral();
            DeshabilitarPagoElectronico();
            DeshabilitarVarios();
        }

        private void HabilitarControles()
        {
            HabilitarBotones();
            HabilitarDatosTecnicos();
            HabilitarDomicilioConexion();
            HabilitarDomicilioLegal();
            HabilitarLote();
            HabilitarGeneral();
            HabilitarPagoElectronico();
            HabilitarVarios();
        }

        private void CargarSocios() {
            SocioImplement oSocioImplement = new SocioImplement();
            if(!_origenBuscar)
                _DataSocios = oSocioImplement.CargarSocios();
            if (_DataSocios.Rows.Count == 0)
            {
                _idSocio = 0;
                _idInf = 0;
                _idSup = 0;
            }
            else
            {
                _idInf = int.Parse(_DataSocios.Rows[0]["id_socio"].ToString());
                _idSup = int.Parse(_DataSocios.Rows[_DataSocios.Rows.Count - 1]["id_socio"].ToString());
                _idSocio = _idInf;
            }
        }

        #region << Domicilio Conexion >>
        private void InicializarDomicilioConexion()
        {
            CargarBarriosDC();
            CargarCallesDC();
        }

        private void LimpiarDomicilioConexion() {
            this.cmbDcBarrio.SelectedValue = 0;
            this.cmbDcCalle.SelectedValue = 0;
            this.txtDcAltura.Text = "";
            this.txtDcDistrito.Text = "";
            this.txtDcDpto.Text = "";
            this.txtDcPiso.Text = "";
        }

        private void DeshabilitarDomicilioConexion() {
            this.cmbDcBarrio.Enabled = false;
            this.cmbDcCalle.Enabled = false;
            this.txtDcAltura.Enabled = false;
            this.txtDcDistrito.Enabled = false;
            this.txtDcDpto.Enabled = false;
            this.txtDcPiso.Enabled = false;
            this.txtAdicDomicilioConexion.Enabled = false;
        }
        private void HabilitarDomicilioConexion()
        {
            this.cmbDcBarrio.Enabled = true;
            this.cmbDcCalle.Enabled = true;
            this.txtDcAltura.Enabled = true;
            this.txtDcDistrito.Enabled = true;
            this.txtDcDpto.Enabled = true;
            this.txtDcPiso.Enabled = true;
            this.txtAdicDomicilioConexion.Enabled = true;
        }
        private void CargarBarriosDC() {
            BarrioImplement oBarrioImplement = new BarrioImplement();
            oBarrioImplement.CargarCombo(this.cmbDcBarrio,"Seleccione Barrio");
        }

        private void CargarCallesDC()
        {
            CalleImplement oCalleImplement = new CalleImplement();
            oCalleImplement.CargarCombo(this.cmbDcCalle, "Seleccionar Calle"); 
        }

        #endregion
        #region << Domicilio Legal >>
        private void InicializarDomicilioLegal() {
            CargarProvinciaDL();
            CargarBarrioDL();
            CargarCallesDL();
            CargarLocalidadesDL();
        }

        private void LimpiarDomicilioLegal() {
            this.cmbDlCalle.SelectedValue = 0;
            this.cmbDlProvincia.SelectedValue = 0;
            this.cmbDlBarrio.SelectedValue = 0;
            this.cmbDLLocalidad.SelectedValue = 0;
            this.txtDlAltura.Text = "";
            this.txtDLCP.Text = "";
            this.txtDLDpto.Text = "";
            this.txtDlPiso.Text = "";
        }

        private void DeshabilitarDomicilioLegal() {
            this.cmbDlCalle.Enabled = false;
            this.cmbDlProvincia.Enabled = false;
            this.cmbDlBarrio.Enabled = false;
            this.cmbDLLocalidad.Enabled = false;
            this.txtDlAltura.Enabled = false;
            this.txtDLCP.Enabled = false;
            this.txtDLDpto.Enabled = false;
            this.txtDlPiso.Enabled = false;
            this.txtAdicDomicilioLegal.Enabled = false;
        }
        private void HabilitarDomicilioLegal()
        {
            this.cmbDlCalle.Enabled = true;
            this.cmbDlProvincia.Enabled = true;
            this.cmbDlBarrio.Enabled = true;
            this.cmbDLLocalidad.Enabled = true;
            this.txtDlAltura.Enabled = true;
            this.txtDLCP.Enabled = true;
            this.txtDLDpto.Enabled = true;
            this.txtDlPiso.Enabled = true;
            this.txtAdicDomicilioLegal.Enabled = true;
        }
        private void CargarCallesDL() {
            CalleImplement oCalleImplement = new CalleImplement();
            oCalleImplement.CargarCombo(this.cmbDlCalle, "Seleccione Calle");
        
        }

        private void CargarLocalidadesDL() {
            LocalidadImplement oLocalidadImplement = new LocalidadImplement();
            oLocalidadImplement.CargarCombo(this.cmbDLLocalidad, "Seleccione Localidad");
        }
        private void CargarProvinciaDL() {

            ProvinciaImplement oProvinciaImplement = new ProvinciaImplement();
            oProvinciaImplement.CargarCombo(this.cmbDlProvincia, "Seleccione Provincia");
        }

        private void CargarBarrioDL() {
            BarrioImplement oBarrioImplement = new BarrioImplement();
            oBarrioImplement.CargarCombo(this.cmbDlBarrio, "Seleccione Barrio");
        }

      
        #endregion
        #region << Lote >>
        private void DeshabilitarLote() {
            this.mtbLNomenclarura.Enabled = false;
            this.txtLManzana.Enabled = false;
            this.txtLRuta.Enabled = false;
            this.txtLOrden.Enabled = false;
        }

        private void LimpiarLote()
        {
            this.mtbLNomenclarura.Text = "";
            this.txtLManzana.Text = "";
            this.txtLRuta.Text = "";
            this.txtLOrden.Text = "";
        }

        private void HabilitarLote()
        {
            this.mtbLNomenclarura.Enabled = true;
            this.txtLManzana.Enabled = true;
            this.txtLRuta.Enabled = true;
            this.txtLOrden.Enabled = true;
        }
        #endregion
        #region << Varios >>

        private void InicializarVarios() {
            CargarTipoDocV();
        }

        private void CargarTipoDocV() {
            DocumentoImplement oDocumentoImplement = new DocumentoImplement();
            oDocumentoImplement.CargarCombo(ref this.cmbVTipoDoc, "Seleccione");
        }

        private void LimpiarDatosVarios() {
            this.cmbVTipoDoc.SelectedValue = 0;
            this.txtVProfesion.Text = "";
            this.txtVNombreConyuge.Text = "";
            this.mtxtVDocumento.Text = "";
            this.txtVNumSocioLuz.Text = "";
            this.dtpVFechaAlta.Value = DateTime.Now;
            this.txtVNumSocioLuz.Text = "";
        
        }
        private void DeshabilitarVarios() {
            this.cmbVTipoDoc.Enabled = false;
            this.txtVProfesion.Enabled = false;
            this.txtVNombreConyuge.Enabled = false;
            this.mtxtVDocumento.Enabled = false;
            this.txtVNumSocioLuz.Enabled = false;
            this.dtpVFechaAlta.Enabled = false;
            this.txtVNumSocioLuz.Enabled = false;

        }

        private void HabilitarVarios()
        {
            this.cmbVTipoDoc.Enabled = true;
            this.txtVProfesion.Enabled = true;
            this.txtVNombreConyuge.Enabled = true;
            this.mtxtVDocumento.Enabled = true;
            this.txtVNumSocioLuz.Enabled = true;
            this.dtpVFechaAlta.Enabled = true;
            this.txtVNumSocioLuz.Enabled = true;
        }
        #endregion
        #region << Datos Tecnicos >>
        private void InicializarDatosTecnicos() {
            CargarMedianeraDT();
            CargarTipoConexionDT();
            CargarTipoMaterialDT();
        }

        private void LimpiarDatosTecnicos() {
            this.cmbDTMedianera.SelectedIndex = 0;
            this.cmbDTTipoConexion.SelectedIndex = 0;
            this.cmbDTTipoMaterial.SelectedIndex = 0;
            this.txtDTNumero.Text = "";
            this.txtDTMarca.Text = "";
            this.txtDTEstados.Text = "";
            this.txtDTUltimaLectura.Text = "";
            this.txtDTDistanciaMedianera.Text = "";
            this.txtDTDistanciaLinea.Text = "";
            this.txtDTProfondidad.Text = "";
            this.txtDTDiametro.Text = "";
        }

        private void DeshabilitarDatosTecnicos() {
            this.cmbDTMedianera.Enabled = false;
            this.cmbDTTipoConexion.Enabled = false;
            this.cmbDTTipoMaterial.Enabled = false;
            this.txtDTNumero.Enabled = false;
            this.txtDTMarca.Enabled = false;
            this.txtDTEstados.Enabled = false;
            this.txtDTUltimaLectura.Enabled = false;
            this.txtDTDistanciaMedianera.Enabled = false;
            this.txtDTDistanciaLinea.Enabled = false;
            this.txtDTProfondidad.Enabled = false;
            this.txtDTDiametro.Enabled = false;
        }
        private void HabilitarDatosTecnicos()
        {
            this.cmbDTMedianera.Enabled = true;
            this.cmbDTTipoConexion.Enabled = true;
            this.cmbDTTipoMaterial.Enabled = true;
            this.txtDTNumero.Enabled = true;
            this.txtDTMarca.Enabled = true;
            this.txtDTEstados.Enabled = true;
            this.txtDTUltimaLectura.Enabled = true;
            this.txtDTDistanciaMedianera.Enabled = true;
            this.txtDTDistanciaLinea.Enabled = true;
            this.txtDTProfondidad.Enabled = true;
            this.txtDTDiametro.Enabled = true;
        }
        private void CargarMedianeraDT() {
            MedianeraImplement oMedianeraImplement = new MedianeraImplement();
            oMedianeraImplement.CargarCombo(this.cmbDTMedianera, "Seleccione Medianera");
        }

        private void CargarTipoConexionDT() {
            ConexionImplement oConexionImplement = new ConexionImplement();
            oConexionImplement.CargarCombo(this.cmbDTTipoConexion, "Tipo Conexion");
        }

        private void CargarTipoMaterialDT() {

            MaterialImplement oMaterialImplement = new MaterialImplement();
            oMaterialImplement.CargarCombo(this.cmbDTTipoMaterial, "Seleccione Material");
        }
        #endregion
        #region << Pago Electronico >>
        private void InicializarPagoElectronico() {
            CargarPrestadorPE();
        }

        private void CargarPrestadorPE() { 
            PrestadorImplement oPrestadorImplement=new PrestadorImplement();
            oPrestadorImplement.CargarCombo(this.cmbPEEntidad, "Seleccione Prestador");
            
        }

        private void LimpiarPagoElectronico() {
            this.cmbPEEntidad.SelectedIndex = 0;
            this.txtPECBU.Text = "";
        }
        private void DeshabilitarPagoElectronico() {
            this.cmbPEEntidad.Enabled = false;
            this.txtPECBU.Enabled = false;
        }
        private void HabilitarPagoElectronico()
        {
            this.cmbPEEntidad.Enabled = true;
            this.txtPECBU.Enabled = true;
        }
        #endregion
        #region << Datos Generales >>
        private void InicializarDatosGenerales() {
       
            CargarTipoDocumento();
            CargarIva();
            CargarEstadoConexion();
            cmbEstadoConexion.SelectedValue = 0;
            CargarTarifa();
            CargarZonaFacturacion();
            CargarSituacionEspecial();
            CargarCategoria();
        }
        private void LimpiarGeneral(){
            this.cmbTipoDni.SelectedValue = 0;
            this.cmbIVA.SelectedValue = 0;
            this.cmbEstadoConexion.SelectedValue = 0;
            this.cmbTarifa.SelectedValue = 0;
            this.cmbZona.SelectedValue = 0;
            this.cmbSituacionEsp.SelectedValue = 0;
            this.cmbCategoria.SelectedValue = 0;
            this.mtxtNumero.Text = "";
            this.txtNombre.Text = "";
            this.mtxtDocumento.Text = "";
            this.mtxtCuit.Text="";
            this.dtpFecha.Value = DateTime.Now;
        }

        private void DeshabilitarGeneral() {

            this.cmbTipoDni.Enabled = false;
            this.cmbIVA.Enabled = false;
            this.cmbEstadoConexion.Enabled = false;
            this.cmbTarifa.Enabled = false;
            this.cmbZona.Enabled = false;
            this.cmbSituacionEsp.Enabled = false;
            this.cmbCategoria.Enabled = false;
            this.mtxtNumero.Enabled = false;
            this.txtNombre.Enabled = false;
            this.mtxtDocumento.Enabled = false;
            this.mtxtCuit.Enabled = false;
            this.dtpFecha.Enabled = false;

        }


        private void HabilitarGeneral()
        {
            this.cmbTipoDni.Enabled = true;
            this.cmbIVA.Enabled = true;
            this.cmbEstadoConexion.Enabled = true;
            this.cmbTarifa.Enabled = true;
            this.cmbZona.Enabled = true;
            this.cmbSituacionEsp.Enabled = true;
            this.cmbCategoria.Enabled = true;
            this.mtxtNumero.Enabled = true;
            this.txtNombre.Enabled = true;
            this.mtxtDocumento.Enabled = true;
            this.mtxtCuit.Enabled = true;
            this.dtpFecha.Enabled = true;
        }
        
        private void CargarCategoria() {
            CategoriaImplement oCategoriaImplement = new CategoriaImplement();
            oCategoriaImplement.CargarCombo(ref this.cmbCategoria, "Seleccione");
        }
        private void CargarSituacionEspecial()
        {
            SituacionEspecialImplement oSituacionEspecial = new SituacionEspecialImplement();
            oSituacionEspecial.CargarCombo(this.cmbSituacionEsp, "Seleccione..");
        }

        private void CargarZonaFacturacion()
        {
            ZonaImplement oZonaImplement = new ZonaImplement();
            oZonaImplement.CargarCombo(this.cmbZona, "Seleccione..");
        }

        private void CargarTarifa()
        {
            TarifaImplement oTarifaImplement = new TarifaImplement();
            oTarifaImplement.CargarCombo(this.cmbTarifa, "Seleccione..");
        }

        private void CargarEstadoConexion()
        {
            EstadoSocioImplement oEstadoSocioImplement = new EstadoSocioImplement();
            oEstadoSocioImplement.CargarCombo(this.cmbEstadoConexion, "Seleccione");
        }

        private void CargarIva()
        {
            ImpuestoImplement oImpuestoImplement = new ImpuestoImplement();
            oImpuestoImplement.CargarCombo(this.cmbIVA, "Seleccione..");
        }


        private void CargarTipoDocumento()
        {
            this.cmbTipoDni.Enabled = true;
          DocumentoImplement oDocumentoImplement=new DocumentoImplement();
          oDocumentoImplement.CargarCombo(ref this.cmbTipoDni, "Seleccione..");
        }

        #endregion

        private void Cancelar() {

            Deshabilitar();
            DeshabilitarControles();
        }

        private void CargarSocio() {

            SocioImplement oSocioImplement = new SocioImplement();
            socios oSocio = new socios();
            oSocio = oSocioImplement.Get(_idSocio);

            socios_lote oSocioLote = new socios_lote();
            SocioLoteImplement oSocioLoteImplement = new SocioLoteImplement();
            oSocioLote = oSocioLoteImplement.Get(_idSocio);

            socios_conexion oSocioConexion = new socios_conexion();
            SocioConexionImplement oSocioConexionImplement = new SocioConexionImplement();
            oSocioConexion = oSocioConexionImplement.Get(_idSocio);

            socios_varios oSocioVarios = new socios_varios();
            SocioVariosImplement oSocioVariosImplement = new SocioVariosImplement();
            oSocioVarios = oSocioVariosImplement.Get(_idSocio);
            this.mtxtNumero.Text = oSocio.codigo_socio +  oSocio.subcodigo_socio;
            this.txtNombre.Text = oSocio.nombre;
            this.cmbTipoDni.SelectedValue = oSocio.tipo_documento;
            if (this.cmbTipoDni.SelectedValue == null) this.cmbTipoDni.SelectedValue = 0;//Esto es cuando asigno algo que el combo no contiene
            if (oSocio.documento!=null)
                this.mtxtDocumento.Text = oSocio.documento.ToString();
            if (oSocio.fecha_alta != null)
                if (oSocio.fecha_alta != DateTime.Parse("01/01/1900"))
                    this.dtpFecha.Text = oSocio.fecha_alta.ToString();
            this.cmbEstadoConexion.SelectedValue = (oSocio.estado == null) ? 0 : oSocio.estado;
            if (this.cmbEstadoConexion.SelectedValue == null) this.cmbEstadoConexion.SelectedValue = 0;
            this.txtFinalizaEstado.Text = oSocio.fin_estado;
            this.cmbTarifa.SelectedValue = (oSocio.tarifa == null) ? 0 : oSocio.tarifa;
            if (this.cmbTarifa.SelectedValue == null) this.cmbTarifa.SelectedValue = 0;
            this.txtFinalizaTarifa.Text = oSocio.fin_tarifa;
            this.cmbIVA.SelectedValue = oSocio.iva;
            if (this.cmbIVA.SelectedValue == null) this.cmbIVA.SelectedValue = 0;
            this.mtxtCuit.Text = oSocio.cuit;
            this.cmbCategoria.SelectedValue = oSocio.categoria;
            if (this.cmbCategoria.SelectedValue == null) this.cmbCategoria.SelectedValue = 0;

            ///**************************** DOMICILIO CONEXION*****************************/

            this.cmbDcBarrio.SelectedValue =oSocioConexion.barrio;
            if (this.cmbDcBarrio.SelectedValue == null) this.cmbDcBarrio.SelectedValue = 0;
            this.cmbDcCalle.SelectedValue = oSocioConexion.calle;
            if (this.cmbDcCalle.SelectedValue == null) this.cmbDcCalle.SelectedValue = 0;
            this.txtDcAltura.Text = oSocioConexion.calle_altura;
            this.txtDcPiso.Text = oSocioConexion.piso;
            this.txtDcDpto.Text = oSocioConexion.dpto;
            this.txtDcDistrito.Text = (oSocioConexion.distrito_electoral == null) ? "" : oSocioConexion.distrito_electoral.ToString();
            this.cmbZona.SelectedValue = (oSocioConexion.zona == null) ? 0 : oSocioConexion.zona;
            if (this.cmbZona.SelectedValue == null) this.cmbZona.SelectedValue = 0;
            this.txtAdicDomicilioConexion.Text = oSocioConexion.adic_domicilio;

            ///**************************** DOMICILIO LEGAL *******************************/
            this.cmbDlProvincia.SelectedValue = oSocioLote.provincia;
            if (this.cmbDlProvincia.SelectedValue == null) this.cmbDlProvincia.SelectedValue = 0;
            this.cmbDlBarrio.SelectedValue = oSocioLote.barrio;
            if (this.cmbDlBarrio.SelectedValue == null) this.cmbDlBarrio.SelectedValue = 0;
            this.cmbDlCalle.SelectedValue = oSocioLote.calle;
            if (this.cmbDlCalle.SelectedValue == null) this.cmbDlCalle.SelectedValue = 0;
            this.cmbDLLocalidad.SelectedValue = oSocioLote.localidad;
            if (this.cmbDLLocalidad.SelectedValue == null) this.cmbDLLocalidad.SelectedValue = 0;
            this.txtDLCP.Text = oSocioLote.cp.ToString();
            this.txtDlAltura.Text = oSocioLote.calle_altura;
            this.txtDlPiso.Text = oSocioLote.piso;
            this.txtDLDpto.Text = oSocioLote.dpto;
            this.txtAdicDomicilioLegal.Text = oSocioLote.adic_domicilio;

            /*************************** VARIOS *****************************/
            this.txtVProfesion.Text = oSocioVarios.profesion;
            this.txtVNombreConyuge.Text = oSocioVarios.conyuge_nombre;
            this.cmbVTipoDoc.SelectedValue = oSocioVarios.conyuge_tipo_documento;
            if (this.cmbVTipoDoc.SelectedValue == null) this.cmbVTipoDoc.SelectedValue = 0;
            this.mtxtVDocumento.Text = oSocioVarios.conyuge_documento.ToString();
            this.txtVNumSocioLuz.Text = oSocioVarios.id_coop_luz;
            this.dtpVFechaAlta.Text = oSocioVarios.fecha_convenio_coop_luz;
            this.cmbSituacionEsp.SelectedValue = oSocioVarios.situacion_especial;
            if (this.cmbSituacionEsp.SelectedValue == null) this.cmbSituacionEsp.SelectedValue = 0;
            /************************** LOTE ***************************/

            this.mtbLNomenclarura.Text = oSocioLote.nomenclatura;
            this.txtLManzana.Text = oSocioLote.manzana;
            this.txtLLote.Text = oSocioLote.lote;
            this.txtLRuta.Text = oSocioLote.ruta_reparto.ToString();
            this.txtLOrden.Text = oSocioLote.orden_reparto.ToString();
            
            /*********************** DATOS TECNICOS **********************/
            socios_mediciones oSocioMedicion = new socios_mediciones();
            SocioMedicionImplement oSocioMedicionImplement = new SocioMedicionImplement();
            oSocioMedicion = oSocioMedicionImplement.ultimaMedicion(_idSocio);
            this.txtDTNumero.Text = oSocioConexion.medidor;
            this.txtDTMarca.Text = oSocioConexion.marca_medidor;
            ///VER
            this.txtDTEstados.Text = oSocioMedicion == null ? "" : oSocioMedicion.consumo.ToString();
            this.txtDTUltimaLectura.Text = oSocioMedicion == null ? "" : oSocioMedicion.lectura.ToString();

            this.txtDTDistanciaMedianera.Text = oSocioConexion.ubicacion_servicio.ToString();
            this.cmbDTMedianera.SelectedValue = oSocioConexion.medianera;
            if (this.cmbDTMedianera.SelectedValue == null) this.cmbDTMedianera.SelectedValue = 0;
            this.cmbDTTipoConexion.SelectedValue = oSocioConexion.tipo_conexion;
            if (this.cmbDTTipoConexion.SelectedValue == null) this.cmbDTTipoConexion.SelectedValue = 0;
            this.txtDTDistanciaLinea.Text = oSocioConexion.distancia_a_red.ToString();
            this.txtDTProfondidad.Text = oSocioConexion.profundidad_red.ToString();
            this.cmbDTTipoMaterial.SelectedValue = oSocioConexion.tipo_material;
            if (this.cmbDTTipoMaterial.SelectedValue == null) this.cmbDTTipoMaterial.SelectedValue = 0;
            this.txtDTDiametro.Text = oSocioConexion.diametro_red.ToString();

            //VER
            CargarBanderas(oSocioVarios);
        }

        private void CargarBanderas(socios_varios oSocioVarios ) {
                ConvenioImplement oConvenioImplement = new ConvenioImplement();
                ProcesoJudicialImplement oProcesoJudicialImplement=new ProcesoJudicialImplement();
                IntimacionImplement oIntimacionImplement=new IntimacionImplement();
                this.lblConvenioNoVolcado.Visible = (!oConvenioImplement.ConvenioVolcado(_idSocio));
                // Muestra el cartel [CO] = "En CODENE"
                //this.lblEnCodene.Visible=(bool)oSocioVarios.codene;
                // Muestra el cartel [PJ] = "En proceso judicial"
                this.lblEnProcJudicial.Visible = oProcesoJudicialImplement.Estado(_idSocio);
                // Muestra el cartel [IT] = "Intimado"
                if (oSocioVarios.intimado == null)
                    this.lblIntimado.Visible = false;
                else
                    this.lblIntimado.Visible = (bool)oSocioVarios.intimado;
                if (this.lblIntimado.Visible)
                {
                    string msjIntimado = "El socio ha sido intimado por deuda el " + oIntimacionImplement.GetByIdSocioUltimo(_idSocio).fecha;
                    this.toolTip.SetToolTip(this.lblIntimado, "lblIntimado");
                }
                    
                string msjFaltante=VerificarInformacionFaltante(_idSocio);
                this.lblInfoFaltante.Visible = (msjFaltante != "");
        
        }

        private string VerificarInformacionFaltante(int idSocio) {
            string msj = "";


            return msj;
        
        }

        private void HabilitarBotones()
        {
            this.tsbAceptar.Enabled = true;
            this.tsbCancelar.Enabled = true;
            //this.tsMenu.Enabled = false;
            this.tsbNuevo.Enabled = false;
            this.tsbModificar.Enabled = false;
            this.tsbEliminar.Enabled = false;
            this.tsbImprimir.Enabled = false;
        }
        private void Deshabilitar()
        {
            this.tsbAceptar.Enabled = false;
            this.tsbCancelar.Enabled = false;
            //this.tsMenu.Enabled = true;
            this.tsbNuevo.Enabled = true;
            this.tsbModificar.Enabled = true;
            this.tsbEliminar.Enabled = true;
            this.tsbImprimir.Enabled = true;
        }

        private void NuevoSocio() {
            _idSocio=0;
            HabilitarBotones();
            OcultarBusqueda();
            HabilitarControles();
            Limpiar();
        }

        private void OcultarBusqueda(){
            this.tsTxtBuscar.Text = "";
            this.tsTxtBuscar.Visible = false;
            this.tsLblBuscar.Visible = false;
        }

        private void Limpiar() {
            this.tsTxtBuscar.Text = "";
            LimpiarGeneral();
            LimpiarPagoElectronico();
            LimpiarDatosTecnicos();
            LimpiarDatosVarios();
            LimpiarDomicilioLegal();
            LimpiarDomicilioConexion();
            LimpiarLote();
        }
        private void ModificarSocio() {
            HabilitarControles();
            CargarSocio();
        }
        private void Guardar() {
            bool Actualizar=false;
            if (_idSocio!=0)
                Actualizar=true;

                socios oSocio = new socios();
                SocioImplement oSocioImplement = new SocioImplement();
                
                oSocio.codigo_socio = this.mtxtNumero.Text.Substring(0, 6);
                oSocio.subcodigo_socio = this.mtxtNumero.Text.Substring(7, 2);
                oSocio.nombre = this.txtNombre.Text;
                if (!(int.Parse(this.cmbTipoDni.SelectedValue.ToString()) == 0)) oSocio.tipo_documento = int.Parse(this.cmbTipoDni.SelectedValue.ToString());
                oSocio.documento = int.Parse(this.mtxtDocumento.Text);
                oSocio.fecha_alta = this.dtpFecha.Value;
                if (!(int.Parse(this.cmbEstadoConexion.SelectedValue.ToString()) == 0)) oSocio.estado = int.Parse(this.cmbEstadoConexion.SelectedValue.ToString());
                oSocio.fin_estado = this.txtFinalizaEstado.Text;
                if (!(int.Parse(this.cmbTarifa.SelectedValue.ToString()) == 0)) oSocio.tarifa = int.Parse(this.cmbTarifa.SelectedValue.ToString());
                oSocio.fin_tarifa = this.txtFinalizaTarifa.Text;
                if (!(int.Parse(this.cmbIVA.SelectedValue.ToString()) == 0)) oSocio.iva = int.Parse(this.cmbIVA.SelectedValue.ToString());
                oSocio.cuit = this.mtxtCuit.Text;
                if (!(int.Parse(this.cmbCategoria.SelectedValue.ToString()) == 0)) oSocio.categoria = int.Parse(this.cmbCategoria.SelectedValue.ToString());
                
                oSocio.observaciones = "";
                
                if (!Actualizar)
                    _idSocio = oSocioImplement.Save(oSocio);
                else
                {
                    oSocio.id_socio = _idSocio;
                    oSocioImplement.Update(oSocio);
                }

                /****************************SOCIO CONEXION*****************************/
                socios_conexion oSocioConexion = new socios_conexion();
                SocioConexionImplement oSocioConexionImplement = new SocioConexionImplement();
                oSocioConexion.id_Socio = _idSocio;
                oSocioConexion.ubicacion_servicio = this.txtDTDistanciaMedianera.Text == "" ? 0 : float.Parse(this.txtDTDistanciaMedianera.Text.Replace(".", ","));
                oSocioConexion.medianera = int.Parse(this.cmbDTMedianera.SelectedValue.ToString());
                oSocioConexion.tipo_conexion = int.Parse(this.cmbDTTipoConexion.SelectedValue.ToString());
                oSocioConexion.distancia_a_red = this.txtDTDistanciaLinea.Text == "" ? 0 : float.Parse(this.txtDTDistanciaLinea.Text.Replace(".", ","));
                oSocioConexion.profundidad_red = this.txtDTProfondidad.Text == "" ? 0 : float.Parse(this.txtDTProfondidad.Text.Replace(".", ","));
                oSocioConexion.tipo_material = int.Parse(this.cmbDTTipoMaterial.SelectedValue.ToString());
                oSocioConexion.diametro_red = this.txtDTDiametro.Text == "" ? 0 : float.Parse(this.txtDTDiametro.Text.Replace(".", ","));
                oSocioConexion.medidor = this.txtDTNumero.Text;
                oSocioConexion.marca_medidor = this.txtDTMarca.Text;
                oSocioConexion.barrio = int.Parse(this.cmbDcBarrio.SelectedValue.ToString());
                oSocioConexion.calle = int.Parse(this.cmbDcCalle.SelectedValue.ToString());
                oSocioConexion.calle_altura = this.txtDcAltura.Text;
                oSocioConexion.piso = this.txtDcPiso.Text;
                oSocioConexion.dpto = this.txtDcDpto.Text;
                oSocioConexion.distrito_electoral = this.txtDcDistrito.Text == "" ? 0 : int.Parse(this.txtDcDistrito.Text);
                oSocioConexion.zona = int.Parse(this.cmbZona.SelectedValue.ToString());
                oSocioConexion.adic_domicilio = this.txtAdicDomicilioConexion.Text;
                
                if (!Actualizar)
                    oSocioConexionImplement.Save(oSocioConexion);
                else
                    oSocioConexionImplement.Update(oSocioConexion);


                /************************** SOCIO LOTE ***************************/
                socios_lote oSocioLote = new socios_lote();
                SocioLoteImplement oSocioLoteImplement = new SocioLoteImplement();
                oSocioLote.id_Socio = _idSocio;
                oSocioLote.barrio = int.Parse(this.cmbDlBarrio.SelectedValue.ToString());
                oSocioLote.manzana = this.txtLManzana.Text;
                oSocioLote.lote = this.txtLLote.Text;
                oSocioLote.calle = int.Parse(this.cmbDlCalle.SelectedValue.ToString());
                oSocioLote.calle_altura = this.txtDlAltura.Text;
                oSocioLote.piso = this.txtDlPiso.Text;
                oSocioLote.dpto = this.txtDLDpto.Text;
                oSocioLote.nomenclatura = this.mtbLNomenclarura.Text;
                oSocioLote.ruta_reparto = this.txtLRuta.Text == "" ? -1 : int.Parse(this.txtLRuta.Text);
                oSocioLote.orden_reparto = this.txtLOrden.Text == "" ? -1 : int.Parse(this.txtLOrden.Text);
                oSocioLote.cp = this.txtDLCP.Text;
                oSocioLote.localidad = int.Parse(this.cmbDLLocalidad.SelectedValue.ToString());
                oSocioLote.provincia = int.Parse(this.cmbDlProvincia.SelectedValue.ToString());
                oSocioLote.adic_domicilio = this.txtAdicDomicilioLegal.Text;

                if (!Actualizar)
                    oSocioLoteImplement.Save(oSocioLote);
                else
                    oSocioLoteImplement.Update(oSocioLote);
                

                /*************************** SOCIO VARIOS *****************************/
                socios_varios oSocioVarios = new socios_varios();
                SocioVariosImplement oSocioVariosmplement = new SocioVariosImplement();
                oSocioVarios.id_socio = _idSocio;
                oSocioVarios.profesion = this.txtVProfesion.Text;
                oSocioVarios.conyuge_nombre = this.txtVNombreConyuge.Text;
                oSocioVarios.conyuge_tipo_documento =  int.Parse(this.cmbVTipoDoc.SelectedValue.ToString());
                oSocioVarios.conyuge_documento = this.mtxtVDocumento.Text == "" ? -1 : int.Parse(this.mtxtVDocumento.Text);
                oSocioVarios.id_coop_luz = this.txtVNumSocioLuz.Text;//ver
                oSocioVarios.fecha_convenio_coop_luz = this.dtpVFechaAlta.Text;
                oSocioVarios.situacion_especial =  int.Parse(this.cmbSituacionEsp.SelectedValue.ToString());
                if (!Actualizar)
                    oSocioVariosmplement.Save(oSocioVarios);
                else
                    oSocioVariosmplement.Update(oSocioVarios);
        }

        private void AbrirObservaciones()
        {
 
            if (_idSocio == 0)
                Guardar();

            frmObservaciones f = new frmObservaciones("admin", _idSocio);
            f.Text = "Observaciones";
            f.Show();

        }

        private void AbrirFacturas()
        {
            frmFacturas f = new frmFacturas(_idSocio);
            f.Text = "Facturas";
            f.Show();
        }

        private void AbrirConvenios()
        {
            frmConvenios f = new frmConvenios(_idSocio);
            f.Text = "Convenios";
            f.Show();
        }

        private void AbrirCuentasCorrientes()
        {

            if (_idSocio == 0)
                Guardar();
            frmCuentaCorriente f = new frmCuentaCorriente("admin", _idSocio);
            f.Text = "Cuentas Corrientes";
            f.Show();
        }
        private void AbrirIntimacion()
        {
            //_idSocio = ;
            if (_idSocio == 0)
                Guardar();
            frmIntimacion f = new frmIntimacion(_idSocio);
            f.Text = "Intimaciones";
            f.Show();
        }

        private void AbrirConceptosParticulares()
        {
            //_idSocio = ;
            if (_idSocio == 0)
                Guardar();
            frmConceptosParticulares f = new frmConceptosParticulares(_idSocio);
            f.Text = "Conceptos Particulares";
            f.Show();
        }

        private void AbrirFiltro() {
            
            FrmFiltro f = new FrmFiltro();
            f.Text = "Filtro";
            f.Show();
        
        }

        private void AbrirAccion() {
            frmAcciones f = new frmAcciones(_idSocio);
            f.Text = "Acciones";
            f.Show(); 
        }

        private void AbrirEstadosMedidores()
        {
            frmMediciones f = new frmMediciones(_idSocio);
            f.Text = "Mediciones";
            f.Show();
        }

        private void BuscarSocio(string filtroBuscar)
        { 
            SocioImplement oSocioImplement = new SocioImplement();
            int idSocio = oSocioImplement.ObtenerIdSocioByFilter(filtroBuscar);
            _idSocio = idSocio;
            _indice = 0;
            if (_idSocio > 0)
            {
                for (int index = 0; index < _DataSocios.Rows.Count; index++)
                {
                    if (int.Parse(_DataSocios.Rows[index]["id_socio"].ToString()) == _idSocio)
                    {
                        _indice = index;
                        break;
                    }
                }

                CargarSocio();
            }
        }
        #endregion

        private void tsbAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                #region <Validacion>
                string Mensaje;
                Mensaje = "";
                if (txtNombre.Text.Length == 0) { Mensaje += "Falta Ingresar el nombre del socio." + Environment.NewLine; };
                if (int.Parse(cmbTipoDni.SelectedValue.ToString()) == 0) { Mensaje += "Falta el tipo de documento del socio." + Environment.NewLine; };
                if (mtxtDocumento.Text.Length == 0) { Mensaje += "Falta el numero de documento del socio." + Environment.NewLine; };
                if (int.Parse(cmbIVA.SelectedValue.ToString()) == 0) { Mensaje += "Falta el tipo de IVA." + Environment.NewLine; };
                if (int.Parse(cmbCategoria.SelectedValue.ToString()) == 0) { Mensaje += "Falta la categoria de conexion." + Environment.NewLine; };
                if (int.Parse(cmbEstadoConexion.SelectedValue.ToString()) == 0) { Mensaje += "Falta el estado de conexion." + Environment.NewLine; };

                if (int.Parse(cmbTarifa.SelectedValue.ToString()) == 0) { Mensaje += "Falta el tipo de tarifa." + Environment.NewLine; };
                if (int.Parse(cmbZona.SelectedValue.ToString()) == 0) { Mensaje += "Falta la zona de facturacion." + Environment.NewLine; };
                if (int.Parse(cmbDcBarrio.SelectedValue.ToString()) == 0) { Mensaje += "Falta el barrio de la conexion." + Environment.NewLine; };
                if (int.Parse(cmbDcCalle.SelectedValue.ToString()) == 0) { Mensaje += "Falta el codigo de la calle de conexion." + Environment.NewLine; };
                if (txtDcDistrito.Text.Length == 0) { Mensaje += "Falta el districto electoral." + Environment.NewLine; };


                if (int.Parse(cmbDlProvincia.SelectedValue.ToString()) == 0) { Mensaje += "Falta provincia de residencia legal." + Environment.NewLine; };
                if (int.Parse(cmbDLLocalidad.SelectedValue.ToString()) == 0) { Mensaje += "Falta localidad de residencia legal." + Environment.NewLine; };
                if (int.Parse(cmbDlBarrio.SelectedValue.ToString()) == 0) { Mensaje += "Falta barrio de residencia legal." + Environment.NewLine; };
                if (int.Parse(cmbDlCalle.SelectedValue.ToString()) == 0) { Mensaje += "Falta calle de residencia legal." + Environment.NewLine; };
                if (txtDlAltura.Text.Length == 0) { Mensaje += "Falta altura de residencia legal." + Environment.NewLine; };
                if (txtDLCP.Text.Length == 0) { Mensaje += "Falta codigo postal de residencia legal." + Environment.NewLine; };

                if (mtbLNomenclarura.Text.Length == 0) { Mensaje += "Falta nomenclatura catastral." + Environment.NewLine; }
                if (txtLManzana.Text.Length == 0) { Mensaje += "Falta la identificacion de la manzana." + Environment.NewLine; };
                if (txtLLote.Text.Length == 0) { Mensaje += "Falta la identificacion del lote." + Environment.NewLine; };

                if (int.Parse(cmbDTTipoConexion.SelectedValue.ToString()) == 0) { Mensaje += "Falta el tipo de conexion." + Environment.NewLine; };
                #endregion
                if (Mensaje.Length > 0)
                {
                    frmVentanaInformativa ofrmVentanaInformativa = new frmVentanaInformativa(Mensaje);
                    ofrmVentanaInformativa.ShowDialog();
                }
                else
                {
                    Guardar();
                    Inicializar();
                    Deshabilitar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message);
            }
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                Cancelar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en " + ex.Source + " Mensaje: " + ex.Message);

            }
        }

        private void tsTxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BuscarSocio(tsTxtBuscar.Text);
            }
        }

        private void tsTxtBuscar_Click(object sender, EventArgs e)
        {

        }

        private void tsTxtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                BuscarSocio(tsTxtBuscar.Text);
            }
        }

        private void txtDTDistanciaMedianera_KeyPress(object sender, KeyPressEventArgs e)
        {
            Commons commons = new Commons();
            commons.ValidarNumeroDecimal(sender, e, txtDTDistanciaMedianera);
        }

        private void txtDTDistanciaLinea_KeyPress(object sender, KeyPressEventArgs e)
        {
            Commons commons = new Commons();
            commons.ValidarNumeroDecimal(sender, e, txtDTDistanciaLinea);
        }

        private void txtDTProfondidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Commons commons = new Commons();
            commons.ValidarNumeroDecimal(sender, e, txtDTProfondidad);
        }

        private void txtDTDiametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            Commons commons = new Commons();
            commons.ValidarNumeroDecimal(sender, e, txtDTDiametro);
        }

     

      

        
    }
}
