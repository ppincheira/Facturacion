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
    public partial class frmConvenioPago : Form
    {

        #region << PROPIEDADES >>
        int _idSocio;
        List<int> _ListaFacturas = new List<int>();
        Decimal _ImporteDeuda = 0;
        int _CantidadCuotas = 0;
        Decimal _ImporteCuota = 0;
        DateTime _FechaConvenio;
        Decimal _CanonMunicipal=0;
        enum Meses { Enero =1, Febrero=2, Marzo=3, Abril=4, Mayo=5, Junio=6, Julio=7, Agosto=8, Septiembre=9, Octubre=10, Noviembre=11, Diciembre=12 };

        #endregion

        #region << EVENTOS >>
        public frmConvenioPago(int idSocio, Decimal importeDeuda, int cantCuotas, Decimal importeCuota, string fechaConvenio, Decimal canonMunicipal)
        {
            InitializeComponent();
            _idSocio = idSocio;
            _ImporteDeuda = importeDeuda;
            _CantidadCuotas = cantCuotas;
            _ImporteCuota = importeCuota;
            _FechaConvenio = DateTime.Parse(fechaConvenio);
            _CanonMunicipal = canonMunicipal;
        }

        private void frmConvenioPago_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void btnReciboCanonMunicipal_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimirPagare_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimirConvenio_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
        #region << METODOS >>

        private void Inicializar()
        {
            socios oSocios = new socios();
            SocioImplement oSociosImplement = new SocioImplement();

            socios_lote oSocioLote = new socios_lote();
            SocioLoteImplement oSocioLoteImplement = new SocioLoteImplement();
            oSocioLote = oSocioLoteImplement.Get(_idSocio);

            socios_conexion oSocioConexion = new socios_conexion();
            SocioConexionImplement oSocioConexionImplement = new SocioConexionImplement();
            oSocioConexion = oSocioConexionImplement.Get(_idSocio);

            socios_varios oSocioVarios = new socios_varios();
            SocioVariosImplement oSocioVariosImplement = new SocioVariosImplement();
            oSocioVarios = oSocioVariosImplement.Get(_idSocio);
            
            
            oSocios = oSociosImplement.Get(_idSocio);
            txtCodigo.Text = oSocios.codigo_socio;
            txtFechaConvenio.Text = _FechaConvenio.ToShortDateString();
            txtNombre.Text = oSocios.nombre;
            cod_documentos oCodDocumentos = new cod_documentos();
            DocumentoImplement oDocumentosImplement = new DocumentoImplement();
            if(oSocios.tipo_documento!=null)
                txtTipoDocumento.Text = oDocumentosImplement.Get((int)oSocios.tipo_documento).documento;
            txtDocumento.Text = oSocios.documento.ToString();

            CalleImplement oCalleImplement = new CalleImplement();
           
            BarrioImplement oBarrioImplement = new BarrioImplement();
            LocalidadImplement oLocalidadImplement = new LocalidadImplement();

            if (oSocioConexion.calle!=null & (int)oSocioConexion.calle!=0)
                txtDomicilioReal.Text = oCalleImplement.Get((int)oSocioConexion.calle).calle + " " + oSocioConexion.calle_altura;
            if (oSocioLote.localidad!=null &(int)oSocioLote.localidad != 0)
                txtCiudadReal.Text = oLocalidadImplement.Get((int)oSocioLote.localidad).localidad;
            if (oSocioLote.calle!=null & (int)oSocioLote.calle != 0)
                txtDomicilioLegal.Text = oCalleImplement.Get((int)oSocioLote.calle).calle + " " + oSocioLote.calle_altura;
            if (oSocioLote.localidad!=null & (int)oSocioLote.localidad != 0)
                txtCiudadLegal.Text = oLocalidadImplement.Get((int)oSocioLote.localidad).localidad;
            txtLote.Text = oSocioLote.lote;
            txtManzana.Text = oSocioLote.manzana;
            if (oSocioLote.barrio!=null & (int)oSocioLote.barrio != 0)
                txtBarrio.Text = oBarrioImplement.Get((int)oSocioLote.barrio).barrio;

            txtImporteDeuda.Text = _ImporteDeuda.ToString();
            txtValorCuotas.Text = _ImporteCuota.ToString();
            txtCantidadCuotas.Text = _CantidadCuotas.ToString();
            txtImporteCanonMunicipal.Text = _CanonMunicipal.ToString();


            FacturasImplement oFacturasImplement = new FacturasImplement();
            string sPeriodo = oFacturasImplement.GetUltimoPeriodoFacturadoBySocio(_idSocio);
            int anio = int.Parse(sPeriodo.Substring(0,3));
            int mes = int.Parse(sPeriodo.Substring(4,5));
            DateTime fechaPeriodo = new DateTime(anio, mes, 1);
            DateTime fechaDesde = fechaPeriodo.AddMonths(1);
            DateTime fechaHasta = fechaPeriodo.AddMonths(_CantidadCuotas);
            Meses mesDesde = (Meses)fechaDesde.Month;
            Meses mesHasta = (Meses)fechaHasta.Month;
            txtDesdeMes.Text = mesDesde.ToString();
            txtMesHasta.Text = mesHasta.ToString();
            txtDesdeAnio.Text = fechaDesde.Year.ToString();
            txtAnioHasta.Text = fechaHasta.Year.ToString();
        }

        #endregion
    }
}
