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

namespace com.cooperativa.view.Seguridad
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void Inicializar()
        {
            CargarUsuarios();

        }

        private void CargarUsuarios()
        {
            UsuariosImplement oUsuariosImplement = new UsuariosImplement();
            oUsuariosImplement.CargarLista(lstBUsuarios);
        }

        private void lstBUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idUsuario = (int)lstBUsuarios.SelectedValue;
            UsuariosImplement oUsuariosImplement = new UsuariosImplement();
            usuario oUsuario = new usuario();
            oUsuario = oUsuariosImplement.Get(idUsuario);
            txtID.Text = lstBUsuarios.SelectedValue.ToString();
            txtNombre.Text = oUsuario.nombre;
            txtLogin.Text = oUsuario.login;
            txtPassword.Text = oUsuario.password;

            chkUsuarioHabilitado.Checked = (oUsuario.activo == null) ? false : (bool)oUsuario.activo;
            chkAdministracionSeguridad.Checked = (bool)oUsuario.administracion;
            chkAutorizarCobroSI.Checked = (bool)oUsuario.autorizarCobroSI;
            chkAutorizarConvenios.Checked = (bool)oUsuario.autorizarConvenios;
            chkAvisosDeudaListadosCorte.Checked = (bool)oUsuario.avisosDeuda_listadosCortes;
            chkCobranzas.Checked = (bool)oUsuario.cobranza_cierreCaja;
            chkConfigurar.Checked = (bool)oUsuario.configurar;
            chkFacturacionAnulacion.Checked = (bool)oUsuario.facturacion_anulacion;
            chkImpresion.Checked = (bool)oUsuario.impresion_reimpresion;
            chkJudicialCodene.Checked = (bool)oUsuario.judicial_codene;
            chkListadosPadrones.Checked = (bool)oUsuario.listados_padrones;
            chkListadosReportesCobranza.Checked = (bool)oUsuario.listados_reportes;
            chkOpcionesMantenimiento.Checked = (bool)oUsuario.mantenimiento;
            chkRepararOptimizar.Checked = (bool)oUsuario.reparar_optimizar_respaldo;
            chkModificarDatos.Checked = (bool)oUsuario.modificarDatos;

        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Length > 0)
            {
                lstBUsuarios.Enabled = false;
                txtNombre.Enabled = true;
                //txtLogin.Enabled = true;
                txtPassword.Enabled = true;

                chkAdministracionSeguridad.Enabled = true;
                chkAutorizarCobroSI.Enabled = true;
                chkAutorizarConvenios.Enabled = true;
                chkAvisosDeudaListadosCorte.Enabled = true;
                chkCobranzas.Enabled = true;
                chkConfigurar.Enabled = true;
                chkFacturacionAnulacion.Enabled = true;
                chkImpresion.Enabled = true;
                chkJudicialCodene.Enabled = true;
                chkListadosPadrones.Enabled = true;
                chkListadosReportesCobranza.Enabled = true;
                chkModificarDatos.Enabled = true;
                chkOpcionesMantenimiento.Enabled = true;
                chkRepararOptimizar.Enabled = true;
                chkUsuarioHabilitado.Enabled = true;

                btnAnularCambios.Enabled = true;
                btnGuardarCambios.Enabled = true;
                btnNuevoUsuario.Enabled = false;
                btnModificarUsuario.Enabled = false;
            }
         
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            habilitar();
            lstBUsuarios.Enabled = false;
            chkAdministracionSeguridad.Checked = false;
            chkAutorizarCobroSI.Checked = false;
            chkAutorizarConvenios.Checked = false;
            chkAvisosDeudaListadosCorte.Checked = false;
            chkCobranzas.Checked = false;
            chkConfigurar.Checked = false;
            chkFacturacionAnulacion.Checked = false;
            chkImpresion.Checked = false;
            chkJudicialCodene.Checked = false;
            chkListadosPadrones.Checked = false;
            chkListadosReportesCobranza.Checked = false;
            chkModificarDatos.Checked = false;
            chkOpcionesMantenimiento.Checked = false;
            chkRepararOptimizar.Checked = false;
            chkUsuarioHabilitado.Checked = false;
        }

        private void habilitar()
        {
            txtNombre.Enabled = true;
            txtLogin.Enabled = true;
            txtPassword.Enabled = true;

            txtID.Text = "";
            txtNombre.Text = "";
            txtLogin.Text = "";
            txtPassword.Text = "";
            chkAdministracionSeguridad.Enabled = true;
            chkAutorizarCobroSI.Enabled = true;
            chkAutorizarConvenios.Enabled = true;
            chkAvisosDeudaListadosCorte.Enabled = true;
            chkCobranzas.Enabled = true;
            chkConfigurar.Enabled = true;
            chkFacturacionAnulacion.Enabled = true;
            chkImpresion.Enabled = true;
            chkJudicialCodene.Enabled = true;
            chkListadosPadrones.Enabled = true;
            chkListadosReportesCobranza.Enabled = true;
            chkModificarDatos.Enabled = true;
            chkOpcionesMantenimiento.Enabled = true;
            chkRepararOptimizar.Enabled = true;
            chkUsuarioHabilitado.Enabled = true;

            btnAnularCambios.Enabled = true;
            btnGuardarCambios.Enabled = true;
            btnNuevoUsuario.Enabled = false;
            btnModificarUsuario.Enabled = false;
        }

        private void deshabilitar()
        {
            txtNombre.Enabled = false;
            txtLogin.Enabled = false;
            txtPassword.Enabled = false;

            txtID.Text = "";
            txtNombre.Text = "";
            txtLogin.Text = "";
            txtPassword.Text = "";
            chkAdministracionSeguridad.Enabled = false;
            chkAutorizarCobroSI.Enabled = false;
            chkAutorizarConvenios.Enabled = false;
            chkAvisosDeudaListadosCorte.Enabled = false;
            chkCobranzas.Enabled = false;
            chkConfigurar.Enabled = false;
            chkFacturacionAnulacion.Enabled = false;
            chkImpresion.Enabled = false;
            chkJudicialCodene.Enabled = false;
            chkListadosPadrones.Enabled = false;
            chkListadosReportesCobranza.Enabled = false;
            chkModificarDatos.Enabled = false;
            chkOpcionesMantenimiento.Enabled = false;
            chkRepararOptimizar.Enabled = false;
            chkUsuarioHabilitado.Enabled = false;

            chkAdministracionSeguridad.Checked = false;
            chkAutorizarCobroSI.Checked = false;
            chkAutorizarConvenios.Checked = false;
            chkAvisosDeudaListadosCorte.Checked = false;
            chkCobranzas.Checked = false;
            chkConfigurar.Checked = false;
            chkFacturacionAnulacion.Checked = false;
            chkImpresion.Checked = false;
            chkJudicialCodene.Checked = false;
            chkListadosPadrones.Checked = false;
            chkListadosReportesCobranza.Checked = false;
            chkModificarDatos.Checked = false;
            chkOpcionesMantenimiento.Checked = false;
            chkRepararOptimizar.Checked = false;
            chkUsuarioHabilitado.Checked = false;


            btnAnularCambios.Enabled = false;
            btnGuardarCambios.Enabled = false;
            btnNuevoUsuario.Enabled = true;
            btnModificarUsuario.Enabled = true;
        }


        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            UsuariosImplement oUsuariosImplement = new UsuariosImplement();
            if (!oUsuariosImplement.ExisteUsuario(txtLogin.Text) & txtLogin.Text.Length > 0 & txtNombre.Text.Length > 0 & txtPassword.Text.Length > 0)
            {
                usuario oUsuario = new usuario();
                oUsuario.nombre = txtNombre.Text;
                oUsuario.login = txtLogin.Text;
                oUsuario.password = txtPassword.Text;
                oUsuario.activo = chkUsuarioHabilitado.Checked;
                oUsuario.administracion = chkAdministracionSeguridad.Checked;
                oUsuario.autorizarCobroSI = chkAutorizarCobroSI.Checked;
                oUsuario.autorizarConvenios = chkAutorizarConvenios.Checked;
                oUsuario.avisosDeuda_listadosCortes = chkAvisosDeudaListadosCorte.Checked;
                oUsuario.cobranza_cierreCaja = chkCobranzas.Checked;
                oUsuario.configurar = chkConfigurar.Checked;
                oUsuario.facturacion_anulacion = chkFacturacionAnulacion.Checked;
                oUsuario.impresion_reimpresion = chkImpresion.Checked;
                oUsuario.judicial_codene = chkJudicialCodene.Checked;
                oUsuario.listados_padrones = chkListadosPadrones.Checked;
                oUsuario.listados_reportes = chkListadosReportesCobranza.Checked;
                oUsuario.mantenimiento = chkOpcionesMantenimiento.Checked;
                oUsuario.reparar_optimizar_respaldo = chkRepararOptimizar.Checked;
                oUsuario.modificarDatos = chkModificarDatos.Checked;

                oUsuariosImplement.Save(oUsuario);

                CargarUsuarios();


            }
            else {
                if (txtID.Text.Length>0 & txtLogin.Text.Length > 0 & txtNombre.Text.Length > 0 & txtPassword.Text.Length > 0)
                {
                    usuario oUsuario = new usuario();
                    oUsuario = oUsuariosImplement.Get(int.Parse(txtID.Text));
                    oUsuario.nombre = txtNombre.Text;
                    oUsuario.password = txtPassword.Text;
                    oUsuario.activo = chkUsuarioHabilitado.Checked;
                    oUsuario.administracion = chkAdministracionSeguridad.Checked;
                    oUsuario.autorizarCobroSI = chkAutorizarCobroSI.Checked;
                    oUsuario.autorizarConvenios = chkAutorizarConvenios.Checked;
                    oUsuario.avisosDeuda_listadosCortes = chkAvisosDeudaListadosCorte.Checked;
                    oUsuario.cobranza_cierreCaja = chkCobranzas.Checked;
                    oUsuario.configurar = chkConfigurar.Checked;
                    oUsuario.facturacion_anulacion = chkFacturacionAnulacion.Checked;
                    oUsuario.impresion_reimpresion = chkImpresion.Checked;
                    oUsuario.judicial_codene = chkJudicialCodene.Checked;
                    oUsuario.listados_padrones = chkListadosPadrones.Checked;
                    oUsuario.listados_reportes = chkListadosReportesCobranza.Checked;
                    oUsuario.mantenimiento = chkOpcionesMantenimiento.Checked;
                    oUsuario.reparar_optimizar_respaldo = chkRepararOptimizar.Checked;
                    oUsuario.modificarDatos = chkModificarDatos.Checked;

                    oUsuariosImplement.Update(oUsuario);
                }
            }
            deshabilitar();
            lstBUsuarios.Enabled = true;

        }

        private void btnAnularCambios_Click(object sender, EventArgs e)
        {
            deshabilitar();
            lstBUsuarios.Enabled = true;
        }
    }
}
