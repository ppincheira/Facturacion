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
    public partial class frmFacturasSeleccion : Form
    {
        #region << PROPIEDADES >>
        int _idSocio;
        int _idAccion;
        int _idFactura;
        bool _bandera = false;
        bool _bandera2 = false;
        bool _cerrar=false;
        bool _cargando = false;


        public Decimal TotalFacturasImporte { get; set; }

        public Decimal CanonMunicipal { get; set; }

        public Decimal ImporteSinInteres { get; set; }

        public Decimal ImporteRecargos { get; set; }

        public List<int> rowSeleccion { get; set; }
     
        #endregion

        #region << EVENTOS >>
        public frmFacturasSeleccion(int idSocio)
        {
            InitializeComponent();
            _idSocio = idSocio;
            rowSeleccion = new List<int>();
            TotalFacturasImporte = 0;
            CanonMunicipal = 0;
            ImporteSinInteres = 0;
            ImporteRecargos = 0;
        }
         
        private void frmFacturasSeleccion_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void frmFacturasSeleccion_VisibleChanged(object sender, EventArgs e)
        {
            if(!_cerrar){
                seleccionarTodo();
            }
            _cargando = false;
        }

        //private void dgvFacturas_SelectionChanged(object sender, EventArgs e  )                   
        //{
        //    CargarSeleccionFactura();
        //}

        private void btnSeleccionarTodas_Click(object sender, EventArgs e)
        {
            _bandera = true;
            foreach (DataGridViewRow dr in dgvFacturas.Rows)
            {
                dr.Selected = true;
                //dr.DefaultCellStyle.BackColor = Color.DodgerBlue;
                if (!rowSeleccion.Contains((int)dr.Cells[1].Value))
                {
                    rowSeleccion.Add((int)dr.Cells[1].Value);
                }
            }
            txtSelec.Text = ObtenerCantSeleccionadas().ToString();
            CargarTotales();
            _bandera = false;
        }

        private void btnDeseleccionarTodas_Click(object sender, EventArgs e)
        {
            _bandera = true;
            foreach (DataGridViewRow dr in dgvFacturas.Rows)
            {
                //dr.Selected = false;
                //dr.DefaultCellStyle.BackColor = Color.White;
                if(dr.Selected)
                    dr.Selected= false;
            }
            rowSeleccion.Clear();
            txtSelec.Text = ObtenerCantSeleccionadas().ToString();
            CargarTotales();
            _bandera = false;
        }

        private void btnInvertirSeleccion_Click(object sender, EventArgs e)
        {
            _bandera = true;
            foreach (DataGridViewRow dr in dgvFacturas.Rows)
            {
                if (rowSeleccion.Contains((int)dr.Cells[1].Value))
                {
                
                       // dr.DefaultCellStyle.BackColor = Color.White;
                        rowSeleccion.Remove((int)dr.Cells[1].Value);
            
                    dr.Selected = false;
                }
                else
                {
                    //dr.DefaultCellStyle.BackColor = Color.DodgerBlue;
                    rowSeleccion.Add((int)dr.Cells[1].Value);
                    dr.Selected = true;
                }

            }
            txtSelec.Text = ObtenerCantSeleccionadas().ToString();
            CargarTotales();
            _bandera = false;
        }

        private void dgvFacturas_SelectionChanged(object sender, EventArgs e)
        {
            if (!_cargando)
            {
                if (!_bandera)
                {
                    txtSelec.Text = ObtenerCantSeleccionadas().ToString();
                    CargarTotales();
                }
                if (!_bandera2)
                {
                    foreach (DataGridViewRow dr in dgvFacturas.Rows)
                    {
                        if (dr.Selected)
                        {
                            //if (rowSeleccion.Contains((int)dr.Cells[1].Value))
                            //{
                            if (!rowSeleccion.Contains((int)dr.Cells[1].Value))
                            {
                                rowSeleccion.Add((int)dr.Cells[1].Value);
                                //dr.DefaultCellStyle.BackColor = Color.DodgerBlue;
                            }
                        }
                        else
                        {
                            if (rowSeleccion.Contains((int)dr.Cells[1].Value))
                            {
                                rowSeleccion.Remove((int)dr.Cells[1].Value);
                                //dr.DefaultCellStyle.BackColor = Color.White;
                            }
                        }
                    }
                }
            }
            
            //facturas oFacturas = new facturas();
            //FacturasImplement oFacturasImplement = new FacturasImplement();
            //DataGridViewRow row = this.dgvFacturas.CurrentRow;
            //if (rowSeleccion.Contains(row))
            //{
            //    rowSeleccion.Remove(row);
            //    row.Selected = false;
            //}
            //else
            //{
            //    rowSeleccion.Add(row);
            //    row.Selected = true;
            //}
        }

        #endregion

        #region << METODOS >>

        private void Inicializar()
        {
            socios oSocio = new socios();
            SocioImplement oSocioImplement = new SocioImplement();
            SocioConexionImplement oSocioConexionImplement = new SocioConexionImplement();
            oSocio = oSocioImplement.Get(_idSocio);
            this.txtCodigo.Text = oSocio.codigo_socio;
            this.txtSubCodigo.Text = oSocio.subcodigo_socio;
            this.txtNombre.Text = oSocio.nombre;
           
            
         //   _bandera = true;
         //   _bandera2 = true;
            
            _cargando = true;
            CargarGrilla();
            
          
        //    _bandera = false;
        //    _bandera2 = false;
            //CargarTotales();

        }

        private void CargarTotales()
        {
            int mostrarImpagas = 1;
            FacturasImplement oFacturasImplement = new FacturasImplement();

            decimal _recargo =0;
            decimal _srecargo = 0;

            CalculosFactura oCalculosFactura = new CalculosFactura();
            facturas oFacturas = new facturas();
            foreach (DataGridViewRow dr in dgvFacturas.Rows)
            {
                if (dr.Selected)
                {
                    int id_factura = (int)dr.Cells[1].Value;
                    decimal recargoTemp = oCalculosFactura.CalcularRecargo(id_factura);
                    decimal ivaRecTemp = oCalculosFactura.CalcularIVARecargoNuevo(recargoTemp, _idSocio);
                    _recargo = _recargo + recargoTemp + ivaRecTemp;
                    _srecargo = _srecargo + (decimal)oFacturasImplement.Get(id_factura).importeTotal;
                    CanonMunicipal = CanonMunicipal + oCalculosFactura.ObtenerCanonMunicipal(id_factura);

                }
            }

            ImporteRecargos = Math.Round(_recargo, 2);
            txtRecargo.Text = ImporteRecargos.ToString();
            ImporteSinInteres = Math.Round(_srecargo, 2);
            txtSRecargo.Text = ImporteSinInteres.ToString();

            TotalFacturasImporte = (decimal.Parse(txtSRecargo.Text) + decimal.Parse(txtRecargo.Text));
            txtTotalImporte.Text = TotalFacturasImporte.ToString();
            
            txtTotalFacturas.Text = oFacturasImplement.GetCountFacturasBySocio(_idSocio, mostrarImpagas).ToString();

            ConceptoImplement oConceptoImplement = new ConceptoImplement();
           
            txtRecargoDiario.Text = oConceptoImplement.Get(18).variable.ToString();
            
            txtSelec.Text = ObtenerCantSeleccionadas().ToString();
        }

        private void CargarGrilla()
        {
            FacturasImplement oFacturasImplement = new FacturasImplement();
            DataTable dtFacturas = oFacturasImplement.GetByIdSocioSinConvenioDT(_idSocio, 1, 1);

            Decimal valorTotal = 0;
            foreach (DataRow dr in dtFacturas.Rows)
            {
                #region <Control Valores Vacios>
                decimal Neto = 0;
                decimal IVA = 0;
                decimal Cobrado = 0;
                decimal Recargo = 0;
                decimal IVARecargo = 0;
                if (dr["Neto"] == null | dr["Neto"].ToString() == "")
                    Neto = 0;
                else
                    Neto = decimal.Parse(dr["Neto"].ToString());
                if (dr["IVA"] == null | dr["IVA"].ToString() == "")
                    IVA = 0;
                else
                    IVA = decimal.Parse(dr["IVA"].ToString());
                if (dr["Cobrado"] == null | dr["Cobrado"].ToString() == "")
                    Cobrado = 0;
                else
                    Cobrado = decimal.Parse(dr["Cobrado"].ToString());
                if (dr["Recargo"] == null | dr["Recargo"].ToString() == "")
                    Recargo = 0;
                else
                    Recargo = decimal.Parse(dr["Recargo"].ToString());
                if (dr["IVARecargo"] == null | dr["IVARecargo"].ToString() == "")
                    IVARecargo = 0;
                else
                    IVARecargo = decimal.Parse(dr["IVARecargo"].ToString());
                #endregion

                valorTotal = valorTotal + (Neto + IVA - Cobrado)
                        + Recargo + IVARecargo;

            }
          
            this.dgvFacturas.DataSource = dtFacturas;
          
        }

        private void seleccionarTodo()
        {
            int indice = 0;
            int cant = dgvFacturas.Rows.Count;
            for(int i=0; i<cant; i++)
            {
                //dgvFacturas.Rows[i].DefaultCellStyle.BackColor = Color.DodgerBlue;
                dgvFacturas.Rows[i].Selected=true;
                indice = int.Parse(dgvFacturas.Rows[i].Cells[1].Value.ToString());
                if (!rowSeleccion.Contains(indice))
                {
                    rowSeleccion.Add(indice);
                }
            }
           
            //foreach (DataGridViewRow dr in dgvFacturas.Rows)
            //{
            //    dr.Selected = true;
            //    indice = int.Parse(dr.Cells[1].Value.ToString());
            //    if (!rowSeleccion.Contains(indice))
            //    {
            //        rowSeleccion.Add(indice);
            //    }
            //}
        }

        private int ObtenerCantSeleccionadas()
        {
            int Cantidad = 0;
            foreach (DataGridViewRow dr in dgvFacturas.Rows)
            {
                if (dr.Selected)
                {
                    Cantidad = Cantidad + 1;
                }
            }
            return Cantidad;
        }
        

        #endregion

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            _cerrar = true;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        

        

    }
}
