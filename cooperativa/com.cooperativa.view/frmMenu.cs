using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using com.cooperativa.implement;
using com.cooperativa.implement.dao;

using System.Windows.Forms;

namespace com.cooperativa.view
{
    public partial class frmMenu : Form
    {
        frmLogin _frmLoginParam;
        usuario _USUARIO = new usuario();
        #region << EVEMTOS >>
        public frmMenu()
        {
            InitializeComponent();
        }

        public frmMenu(frmLogin _frmLogin)
        {
            _frmLoginParam = _frmLogin;
           
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            UsuariosImplement oUsuariosImplement = new UsuariosImplement();
            _USUARIO = oUsuariosImplement.Get(_frmLoginParam.getIDUSUARIO());

            //frmLogin f = new frmLogin();
            //f.MdiParent = this;
            //f.Text = "Login";
            //f.MdiParent = this; 
            //f.Show();
        }

        private void barriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBarrio f = new frmBarrio();
            f.MdiParent = this;
            f.Text = "Barrio";
            f.MdiParent = this; 
            f.Show();
        }

        private void conceptosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConcepto f = new frmConcepto();
            f.MdiParent = this;
            f.Text = "Conceptos";
            f.MdiParent = this; 
            f.Show();

        }

        private void zonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmZona f = new frmZona();
            f.MdiParent = this;
            f.Text = "Zonas";
            f.MdiParent = this;
            f.Show();
        }

        private void provinciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProvincia f = new frmProvincia();
            f.MdiParent = this;
            f.Text = "Provincias";
            f.MdiParent = this; 
            f.Show();
        }

        private void medianerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMedianera f = new frmMedianera();
            f.MdiParent = this;
            f.Text = "Medianeras";
            f.MdiParent = this; 
            f.Show();
        }
        
        private void tiposDeIVAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipoIVA f = new FrmTipoIVA();
            f.MdiParent = this;
            f.Text = "Tipo Iva";
            f.MdiParent = this; 
            f.Show();
        }

        #endregion

        private void tiposDeDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoDocumento f = new frmTipoDocumento();
            f.MdiParent = this;
            f.Text = "Tipo de Documento";
            f.MdiParent = this; 
            f.Show();
        }

        private void tiposDeConexionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoConexion f = new frmTipoConexion();
            f.MdiParent = this;
            f.Text = "Tipo de Conexiones";
            f.MdiParent = this; 
            f.Show();
        }

        private void tarifasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTarifa f = new frmTarifa();
            f.MdiParent = this;
            f.Text = "Tarifas";
            f.MdiParent = this; 
            f.Show();
        }

        private void estadosDeSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadoConexion f = new frmEstadoConexion();
            f.MdiParent = this;
            f.Text = "Estados de Socios";
            f.MdiParent = this; 
            f.Show();
        }

        private void socioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSocio f = new frmSocio();
            f.Text = "Socios";
            f.MdiParent = this;
            f.Show();
        }

        private void SituacionEspecialtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSituacionEspecial f = new frmSituacionEspecial();
            f.MdiParent = this;
            f.Text = "Situacion Especial";
            f.MdiParent = this; 
            f.Show();

        }

        private void CategoriastoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategorias f = new frmCategorias();
            f.MdiParent = this;
            f.Text = "Categorias";
            f.MdiParent = this; 
            f.Show();
        }

        private void nombreDeCallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalles f = new frmCalles();
            f.MdiParent = this;
            f.Text = "Calles";
            f.MdiParent = this; 
            f.Show();
        }

        private void estudioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstudio f = new frmEstudio();
            f.MdiParent = this;
            f.Text = "Estudio";
            f.MdiParent = this; 
            f.Show();
        }

        private void estadoPJToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadoPJ f = new frmEstadoPJ();
            f.MdiParent = this;
            f.Text = "Estados Proceso Judicial";
            f.MdiParent = this; 
            f.Show();
        }

        private void tipoIntimaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoIntimacion f = new frmTipoIntimacion();
            f.MdiParent = this;
            f.Text = "Tipo Intimdacion";
            f.MdiParent = this; 
            f.Show();
        }

        private void procesoFacturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFacturacion f = new frmFacturacion();
            f.MdiParent = this;
            f.Text = "Proceso de Facturación";
            f.MdiParent = this;
            f.Show();
        }

        private void tiposDeMaterialesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEstudio f = new frmEstudio();
            f.MdiParent = this;
            f.Text = "Estudio";
            f.MdiParent = this;
            f.Show();
        }

        private void seleccionarImpresoraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cambiarPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmSocio f = new frmSocio();
            f.Text = "Socios";
            f.MdiParent = this;
            f.Show();
        }

        private void periodosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmSocio f = new frmSocio();
            f.Text = "Socios";
            f.MdiParent = this;
            f.Show();
        }

        private void sysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sys.frmConfiguracion f = new Sys.frmConfiguracion();
            f.Text = "Systema";
            f.MdiParent = this;
            f.Show();
        }

        private void generaPeriodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sys.frmGeneraPeriodos f = new Sys.frmGeneraPeriodos();
            f.Text = "Generación Periodos";
            f.MdiParent = this;
            f.Show();
        }

        private void hojaDeRutaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sociosDeServicioMedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CargaEstadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargaEstados f = new frmCargaEstados();
            f.Text = "Carga Estados";
            f.MdiParent = this;
            f.Show();
        }

        private void conveniosMoratoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuracion.frmGestionMoratorias f = new Configuracion.frmGestionMoratorias();
            f.Text = "Configuracion Convenios/Moratorias";
            f.MdiParent = this;
            f.Show();
        }

        private void refacturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturacion.frmReFacturar f = new Facturacion.frmReFacturar();
            f.MdiParent = this;
            f.Show();
        }

        private void busquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buscadores.frmBuscar f = new Buscadores.frmBuscar();
            f.MdiParent = this;
            f.Show();
        }

        private void resumenDeFacturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturacion.frmResumenFacturacion f = new Facturacion.frmResumenFacturacion();
            f.MdiParent = this;
            f.Show();
        }

        private void intimacionesDeudaConvenioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administracion.frmAsistenteIntimacionesPorDeuda f = new Administracion.frmAsistenteIntimacionesPorDeuda();
            f.MdiParent = this;
            f.Show();
        }

        private void sociosConConveniosCaídosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSociosEnProcesoJudicial f = new frmSociosEnProcesoJudicial();
            f.MdiParent = this;
            f.Show();
        }

        private void avisosVariosASociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAvisosVariosASocios f = new frmAvisosVariosASocios();
            f.MdiParent = this;
            f.Show();
        }

        private void sociosEnCODENEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSociosCodene f = new frmSociosCodene();
            f.MdiParent = this;
            f.Show();
        }

        private void sociosIntimadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSociosIntimados f = new frmSociosIntimados();
            f.MdiParent = this;
            f.Show();
        }

        private void sociosEnSituacionEspecialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSociosEnSituacionEspecial f = new frmSociosEnSituacionEspecial();
            f.MdiParent = this;
            f.Show();
        }

        private void resumenDeConveniosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmResumenConveniosPagosFirmados f = new frmResumenConveniosPagosFirmados();
            f.MdiParent = this;
            f.Show();
        }

        private void preAutorizaciónCobroSinInterésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPreautorizacionCobroSinInteres f = new frmPreautorizacionCobroSinInteres();
            f.MdiParent = this;
            f.Show();
        }

        private void padrónGeneralDeSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPadronGeneralSocios f = new frmPadronGeneralSocios();
            f.MdiParent = this;
            f.Show();
        }

        private void padrónDeSociosPorDistritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPadronDeSociosPorDistrito f = new frmPadronDeSociosPorDistrito();
            f.MdiParent = this;
            f.Show();
        }

        private void cobranzaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Cobranza.frmCobranza f = new Cobranza.frmCobranza();
            f.MdiParent = this;
            f.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((bool)_USUARIO.administracion)
            {
                Seguridad.frmUsuarios f = new Seguridad.frmUsuarios();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                MessageBox.Show("USUARIO NO AUTORIZADO.");
            }
        }

        private void terminalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((bool)_USUARIO.administracion)
            {

                Seguridad.frmTerminales f = new Seguridad.frmTerminales();
                f.MdiParent = this;
                f.Show();
            }
            else {
                MessageBox.Show("USUARIO NO AUTORIZADO.");
            }
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            _frmLoginParam.Close();
        }

        private void emisiónDeHojasDeRutasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rutas.frmImprimirHojaRuta f = new Rutas.frmImprimirHojaRuta();
            f.MdiParent = this;
            f.Show();
        }

        private void imprimirFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturacion.frmImprimirFactura f = new Facturacion.frmImprimirFactura();
            f.MdiParent = this;
            f.Show();
        }

        private void controlDeRecaudaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cobranza.frmRecaudacion f = new Cobranza.frmRecaudacion();
            f.MdiParent = this;
            f.Show();
        }

        private void cerrarCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cobranza.frmCierreCajas f = new Cobranza.frmCierreCajas();
            f.MdiParent = this;
            f.Show();
        }

        private void resuménDiarioDeCobranzasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cobranza.frmResumenDiario f = new Cobranza.frmResumenDiario();
            f.MdiParent = this;
            f.Show();

        }

        private void listadoDeudoresGeneralesconvenioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cobranza.frmListadoGralDeudores f = new Cobranza.frmListadoGralDeudores();
            f.MdiParent = this;
            f.Show();
        }

        private void listadoDeSociosSinDeudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cobranza.frmListadoGralSocioSinDeuda f = new Cobranza.frmListadoGralSocioSinDeuda();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Cobranza.frmListadoDeudoresRecientes f = new Cobranza.frmListadoDeudoresRecientes();
            f.MdiParent = this;
            f.Show();
        }

        private void listadoDeCobranzasParaAFIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cobranza.frmListadoCobranzasAFIP f = new Cobranza.frmListadoCobranzasAFIP();
            f.MdiParent = this;
            f.Show();
        }

        private void cobranzasDeConceptosParticularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cobranza.frmCobranzasConceptosParticulares f = new Cobranza.frmCobranzasConceptosParticulares();
            f.MdiParent = this;
            f.Show();
        }

        private void facturaciónCobranzasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cobranza.frmAnalisisFacturacion f = new Cobranza.frmAnalisisFacturacion();
            f.MdiParent = this;
            f.Show();
        }

        private void usuariosSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cobranza.frmAnalisisUsuariosSocios f = new Cobranza.frmAnalisisUsuariosSocios();
            f.MdiParent = this;
            f.Show();
        }

        private void evoluciónMensualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cobranza.frmAnalisisEvolucionMensual f = new Cobranza.frmAnalisisEvolucionMensual();
            f.MdiParent = this;
            f.Show();
        }

        private void cobranzasEnMesesPosterioresALaFacturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cobranza.frmAnalisisCobranzasPosteriores f = new Cobranza.frmAnalisisCobranzasPosteriores();
            f.MdiParent = this;
            f.Show();
        }

        private void cambioDeEstadoDeudorDeSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cobranza.frmAnalisisDeudor f = new Cobranza.frmAnalisisDeudor();
            f.MdiParent = this;
            f.Show();
        }

  

  

  
    }
}
