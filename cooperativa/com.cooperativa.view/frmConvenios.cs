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
    public partial class frmConvenios : Form
    {
        #region << PROPIEDADES >>
        int _idSocio;
        int _idConvenio;
        int _facturadasOriginal=0;
        #endregion

        #region <<EVENTOS>>
        public frmConvenios(int idSocio)
        {
            InitializeComponent();
            _idSocio = idSocio;
        }

        private void frmConvenios_Load(object sender, EventArgs e)
        {
            CargarSocio();
            CargarConveniosBySocio();
            foreach (DataGridViewRow dr in dgvConvenio.Rows)
            {
                dr.ReadOnly = true;
            }

        }

        private void btnNuevoConvenio_Click(object sender, EventArgs e)
        {
            frmConvenioNuevo f = new frmConvenioNuevo(_idSocio);
            f.Text = "Convenio Nuevo";
            if (f.ShowDialog() == DialogResult.OK)
            {
                CargarConveniosBySocio();
            }
        }

        private void btnModificarConvenio_Click(object sender, EventArgs e)
        {
            convenios oConvenios = new convenios();
            ConvenioImplement oConvenioImplement = new ConvenioImplement();
            DataGridViewRow row = this.dgvConvenio.CurrentRow;
            
            if (btnModificarConvenio.Text == "&Modificar Convenio")
            {
                if (row != null)
                {
                    row.ReadOnly = false;
                    row.Cells[0].ReadOnly = true;
                    row.Cells[1].ReadOnly = true;
                    row.Cells[2].ReadOnly = true;
                    row.Cells[3].ReadOnly = true;
                    row.Cells[4].ReadOnly = true;
                    row.Cells[5].ReadOnly = true;
                    row.Cells[7].ReadOnly = true;
                    _facturadasOriginal = Convert.ToInt32(row.Cells[6].Value);
                    _idConvenio = Convert.ToInt32(row.Cells[1].Value);
                    oConvenios = oConvenioImplement.Get(_idConvenio);
                    btnModificarConvenio.Text="&Terminar Modificacion";
                }
            }
            else {
                if (row != null)
                {
                    int _facturadasNuevas=Convert.ToInt32(row.Cells[6].Value);
                    int _cuotas = Convert.ToInt32(row.Cells[5].Value);
                    if (_facturadasNuevas >= _facturadasOriginal && _facturadasNuevas <= _cuotas)
                    {
                        _idConvenio = Convert.ToInt32(row.Cells[1].Value);
                        oConvenios = oConvenioImplement.Get(_idConvenio);
                        oConvenios.fecha_convenio = Convert.ToDateTime(row.Cells[2].Value);
                        oConvenios.importe_total = Convert.ToDecimal(row.Cells[3].Value);
                        oConvenios.cuotas = Convert.ToInt32(row.Cells[5].Value);
                        oConvenios.valor_cuota = Convert.ToDecimal(row.Cells[4].Value);
                        oConvenios.facturadas = Convert.ToInt32(row.Cells[6].Value);
                        if (oConvenios.cuotas == oConvenios.facturadas)
                        {
                            //if (row.Cells[7].Value == "Si")
                            oConvenios.finalizado = true;
                        }
                        else
                            oConvenios.finalizado = false;
                        oConvenioImplement.Update(oConvenios);
                        btnModificarConvenio.Text = "&Modificar Convenio";
                        frmConvenios_Load(sender, e);
                    }
                    else
                    {
                        frmVentanaInformativa f = new frmVentanaInformativa("Cantidad facturadas incorrecta.");
                        f.ShowDialog();
                    }
                    
                }
            }
        }

        private void btnEliminarConvenio_Click(object sender, EventArgs e)
        {
            convenios oConvenios = new convenios();
            ConvenioImplement oConvenioImplement = new ConvenioImplement();
            DataGridViewRow row = this.dgvConvenio.CurrentRow;
            if (row != null)
            {
                int _facturadas = Convert.ToInt32(row.Cells[6].Value);
                if (_facturadas == 0)
                {
                    _idConvenio = Convert.ToInt32(row.Cells[1].Value);
                    //limpio facturas
                    oConvenioImplement.Delete(_idConvenio);
                    CargarConveniosBySocio();
                }
                else {
                    frmVentanaInformativa f = new frmVentanaInformativa("No se puede eliminar convenio si hay cuotas facturadas.");
                    f.ShowDialog();
                }
            }
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            convenios oConvenios = new convenios();
            ConvenioImplement oConvenioImplement = new ConvenioImplement();
            DataGridViewRow row = this.dgvConvenio.CurrentRow;
            if (row != null)
            {


                int _idConvenio = Convert.ToInt32(row.Cells[1].Value);
                Buscadores.frmBuscarSocio f = new Buscadores.frmBuscarSocio();
                f.Text = "Facturas Seleccion";
                int _idSocioATransferir = 0;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    _idSocioATransferir = f.ValorIdRetorno;
                    if (_idSocioATransferir > 0)
                    {
                        oConvenios = oConvenioImplement.Get(_idConvenio);
                        oConvenios.id_socio = _idSocioATransferir;
                        oConvenioImplement.Update(oConvenios);
                        CargarConveniosBySocio();
                    }
                    else
                    {
                        frmVentanaInformativa frmInfo = new frmVentanaInformativa("No se selecciono ningun socio.");
                        frmInfo.ShowDialog();
                    }
                }
            }
        }

     
        #endregion

        #region <<METODOS>>

        private void CargarSocio()
        {
            socios oSocio = new socios();
            SocioImplement oSocioImplement = new SocioImplement();
            oSocio = oSocioImplement.Get(_idSocio);
            this.mtxtNumero.Text = oSocio.codigo_socio + oSocio.subcodigo_socio;
            this.txtNombre.Text = oSocio.nombre;
        }

        private void CargarConveniosBySocio()
        {
            ConvenioImplement oConvenioImplement = new ConvenioImplement();
            DataTable dtConvenios = oConvenioImplement.GetConveniosBySocioDT(_idSocio);

            this.dgvConvenio.DataSource = dtConvenios;
        }

        #endregion

      
     

    }
}
