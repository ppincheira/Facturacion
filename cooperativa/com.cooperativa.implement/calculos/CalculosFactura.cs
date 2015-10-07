using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using com.cooperativa.services;
using com.cooperativa.implement.dao;
using MySql.Data.MySqlClient;

namespace com.cooperativa.implement
{
    public class CalculosFactura
    {
        public decimal CalcularIVA(int idFactura)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                Commons oCommons = new Commons();
                var detallesByFact = (from d in bd.facturas_detalles
                                      join c in bd.cod_conceptos on d.id_concepto equals c.id_concepto
                                      where d.id_factura == idFactura
                                      select new
                                      {
                                          d.id_factura,
                                          d.id_detalle,
                                          d.id_concepto,
                                          d.idOrden,
                                          d.idTipo,
                                          d.importe,
                                          c.id_formula,
                                          c.orden_concepto,
                                          c.tipo_signo,
                                          c.variable,
                                          c.activo,
                                          c.aplicar_descuento,
                                          c.aplicar_iva,
                                          c.aplicar_recargo,
                                          c.concepto
                                      }).ToList();
                DataTable detallesCalc = oCommons.convertToTable(detallesByFact);
                decimal IVA = 0;
                foreach (DataRow rowDet in detallesCalc.Rows)
                {
                    if(bool.Parse(rowDet["aplicar_iva"].ToString()))
                        IVA = IVA + decimal.Parse(rowDet["importe"].ToString());
                }
                int idSocio = 0;
                FacturasImplement oFacturasImplement = new FacturasImplement();
                idSocio = (int)oFacturasImplement.Get(idFactura).id_socio;
                socios oSocio = new socios();
                SocioImplement oSocioImplement = new SocioImplement();
                oSocio = oSocioImplement.Get(idSocio);
                IVA = IVA * (decimal.Parse(oSocio.iva.ToString())/100);

                return IVA;
            }
        }

        public decimal CalcularRecargo(int idFactura)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                Commons oCommons = new Commons();


                MySqlCommand _comando = new MySqlCommand(String.Format(
                "call GetTotalRecargoByFactura('{0}')", idFactura), dbConectorMySql.ObtenerConexion());

                MySqlDataReader _reader = _comando.ExecuteReader();
                DataTable detallesCalc = new DataTable();
                detallesCalc.Load(_reader);
                decimal Recargo = 0;
                Recargo = decimal.Parse(detallesCalc.Rows[0][0].ToString());

                /*var detallesByFact = (from d in bd.facturas_detalles
                                      join c in bd.cod_conceptos on d.id_concepto equals c.id_concepto
                                      where d.id_factura == idFactura
                                      select new
                                      {
                                          d.id_factura,
                                          d.id_detalle,
                                          d.id_concepto,
                                          d.idOrden,
                                          d.idTipo,
                                          d.importe,
                                          c.id_formula,
                                          c.orden_concepto,
                                          c.tipo_signo,
                                          c.variable,
                                          c.activo,
                                          c.aplicar_descuento,
                                          c.aplicar_iva,
                                          c.aplicar_recargo,
                                          c.concepto
                                      }).ToList();
                DataTable detallesCalc = oCommons.convertToTable(detallesByFact);
                
                foreach (DataRow rowDet in detallesCalc.Rows)
                {
                    if (bool.Parse(rowDet["aplicar_recargo"].ToString()))
                        Recargo = Recargo + decimal.Parse(rowDet["importe"].ToString());
                }*/
               /* periodos oPeriodo = new periodos();
                PeriodosImplement oPeriososImplement = new PeriodosImplement();
             

                FacturasImplement oFacturasImplement = new FacturasImplement();
                oPeriodo = oPeriososImplement.Get(oFacturasImplement.Get(idFactura).id_periodo.ToString());*/
                TimeSpan diferencia;
                DateTime fecha_primer_venc=new DateTime();
                fecha_primer_venc = DateTime.Parse(detallesCalc.Rows[0][1].ToString());
                if (fecha_primer_venc < DateTime.Today)
                {
                    diferencia = DateTime.Today - DateTime.Parse(fecha_primer_venc.ToString());
                }
                else {
                    diferencia = DateTime.Today - DateTime.Today;
                }
                cod_conceptos oCod_conceptos = new cod_conceptos();
                ConceptoImplement oConceptoImplement = new ConceptoImplement();
                oCod_conceptos = oConceptoImplement.Get(18);

                decimal? days = diferencia.Days*oCod_conceptos.variable;
                decimal resultado = 0;
                if (days >= 0) {
                    resultado = (decimal)days;
                }

                int idSocio = 0;
                idSocio = int.Parse(detallesCalc.Rows[0][2].ToString());
                socios oSocio = new socios();
                SocioImplement oSocioImplement = new SocioImplement();
                oSocio = oSocioImplement.Get(idSocio);

                tarifas oTarifa = new tarifas();
                TarifaImplement oTarifaImplement = new TarifaImplement();
                oTarifa = oTarifaImplement.Get(oSocio.id_socio);

                Recargo = Recargo * resultado;
                DateTime fecha_segundo_venc = new DateTime();
                fecha_segundo_venc = DateTime.Parse(detallesCalc.Rows[0][3].ToString());
                if (fecha_segundo_venc > DateTime.Today)
                {
                    if (oTarifa.cargo_fijo > Recargo) //esto lo hago segun la marca en recargo en tabla tarifas?
                    {
                        Recargo = (decimal)oTarifa.cargo_fijo;
                    }
                }
                return Recargo;
            }
        }

        public decimal CalcularIVARecargo(int idFactura)
        {
            #region
            /*
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                Commons oCommons = new Commons();
                var detallesByFact = (from d in bd.facturas_detalles
                                      join c in bd.cod_conceptos on d.id_concepto equals c.id_concepto
                                      where d.id_factura == idFactura
                                      select new
                                      {
                                          d.id_factura,
                                          d.id_detalle,
                                          d.id_concepto,
                                          d.idOrden,
                                          d.idTipo,
                                          d.importe,
                                          c.id_formula,
                                          c.orden_concepto,
                                          c.tipo_signo,
                                          c.variable,
                                          c.activo,
                                          c.aplicar_descuento,
                                          c.aplicar_iva,
                                          c.aplicar_recargo,
                                          c.concepto
                                      }).ToList();
                DataTable detallesCalc = oCommons.convertToTable(detallesByFact);
                decimal IVARecargo = 0;
                foreach (DataRow rowDet in detallesCalc.Rows)
                {
                    if (bool.Parse(rowDet["aplicar_iva"].ToString()) && bool.Parse(rowDet["aplicar_recargo"].ToString()))
                        IVARecargo = IVARecargo + decimal.Parse(rowDet["importe"].ToString());
                }
                int idSocio = 0;
                FacturasImplement oFacturasImplement = new FacturasImplement();
                idSocio = (int)oFacturasImplement.Get(idFactura).id_socio;
                socios oSocio = new socios();
                SocioImplement oSocioImplement = new SocioImplement();
                oSocio = oSocioImplement.Get(idSocio);
                
                IVARecargo = IVARecargo * (decimal.Parse(oSocio.iva.ToString()) / 100);
                
                return IVARecargo;
            }
            */
            #endregion
            decimal _IvaRecargo = 0;
            decimal _recargo = 0;
            _recargo = CalcularRecargo(idFactura);
            int idSocio = 0;
            FacturasImplement oFacturasImplement = new FacturasImplement();
            idSocio = (int)oFacturasImplement.Get(idFactura).id_socio;
            socios oSocio = new socios();
            SocioImplement oSocioImplement = new SocioImplement();
            oSocio = oSocioImplement.Get(idSocio);
            _IvaRecargo = _recargo * (decimal.Parse(oSocio.iva.ToString()) / 100);
            return _IvaRecargo;
        }

        public decimal CalcularIVARecargoNuevo(decimal _recargo, int idSocio)
        {
            decimal _IvaRecargo = 0;
            socios oSocio = new socios();
            SocioImplement oSocioImplement = new SocioImplement();
            oSocio = oSocioImplement.Get(idSocio);
            _IvaRecargo = _recargo * (decimal.Parse(oSocio.iva.ToString()) / 100);
            return _IvaRecargo;
        }

        public decimal CalcularDescuento(int idFactura)
        {
            return 0;
        }

        public decimal CalcularIVADescuento(int idFactura)
        {
            return 0;
        }

        public int ObtenerLecturaAnterior(int idFactura)
        {
            int _LectAnt = 0;
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                Commons oCommons = new Commons();

                FacturasImplement oFacturasImplement = new FacturasImplement();
                facturas oFactura = new facturas();

                oFactura = oFacturasImplement.Get(idFactura);
                        

                var facturaAnterior = (from f in bd.facturas
                                       join m in bd.socios_mediciones on f.id_medicion equals m.id_medicion
                                       where f.id_factura < idFactura && f.id_socio == oFactura.id_socio
                                       orderby f.id_factura descending
                                       select new
                                       {
                                           f.id_factura,
                                           m.lectura
                                       }).Take(1).ToList();

                if (facturaAnterior.Count>0)
                    _LectAnt = (int)facturaAnterior[0].lectura;
              
            
            }
            return _LectAnt;
        }

        public DateTime? ObtenerFechaVenc(int idFactura)
        {
            periodos oPeriodo = new periodos();
            PeriodosImplement oPeriososImplement = new PeriodosImplement();


            FacturasImplement oFacturasImplement = new FacturasImplement();
            oPeriodo = oPeriososImplement.Get(oFacturasImplement.Get(idFactura).id_periodo.ToString());
            return oPeriodo.fecha_primer_venc;
        }

        public int ObtenerDiasDeVencimiento(int idFactura)
        {
            periodos oPeriodo = new periodos();
            PeriodosImplement oPeriososImplement = new PeriodosImplement();
            FacturasImplement oFacturasImplement = new FacturasImplement();
            oPeriodo = oPeriososImplement.Get(oFacturasImplement.Get(idFactura).id_periodo.ToString());
            TimeSpan diferencia;
            if (oPeriodo.fecha_primer_venc < DateTime.Today)
            {
                diferencia = DateTime.Today - DateTime.Parse(oPeriodo.fecha_primer_venc.ToString());
            }
            else
            {
                diferencia = DateTime.Today - DateTime.Today;
            }

            return diferencia.Days;
        }

        public int ObtenerDiasDeVencimientoNuevo(DateTime fechavenc)
        {

            TimeSpan diferencia;
            if (fechavenc < DateTime.Today)
            {
                diferencia = DateTime.Today - DateTime.Parse(fechavenc.ToString());
            }
            else
            {
                diferencia = DateTime.Today - DateTime.Today;
            }

            return diferencia.Days;
        }

        public decimal ObtenerCanonMunicipal(int idFactura)
        {
            decimal canonMunicipal = 0;
            int idConceptoCanonMunicipal = 14;
            int cantidad = 0;
            string consulta1;
            consulta1 = "select " +
                        " Count(importe) " +
                        " from facturas_detalles where " +
                        " id_factura=" + idFactura.ToString() + " and id_concepto=" + idConceptoCanonMunicipal.ToString();

            DataTable dt1 = new DataTable();
            string query1;
            query1 = consulta1;
            MySqlCommand cmd1 = new MySqlCommand(query1, dbConectorMySql.ObtenerConexion());
            MySqlDataAdapter adap1 = new MySqlDataAdapter(cmd1);
            adap1.Fill(dt1);
            if (dt1.Rows.Count > 0)
            {
                cantidad=int.Parse(dt1.Rows[0][0].ToString());
            }
            if (cantidad > 0)
            {
                string consulta;
                consulta = "select " +
                            " sum(importe) " +
                            " from facturas_detalles where " +
                            " id_factura=" + idFactura.ToString() + " and id_concepto=" + idConceptoCanonMunicipal.ToString();

                DataTable dt = new DataTable();
                string query;
                query = consulta;
                MySqlCommand cmd = new MySqlCommand(query, dbConectorMySql.ObtenerConexion());
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                adap.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return decimal.Parse(dt.Rows[0][0].ToString());
                }
                else {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
            //using (cooperativaEntities bd = new cooperativaEntities())
            //{
            //    var regis = (from p in bd.facturas_detalles
            //                 where p.id_factura == idFactura && p.id_concepto == idConceptoCanonMunicipal
            //                 group p by p.id_factura into g
            //                 select new { total = g.Sum(p => p.importe) }).Single();

            //    canonMunicipal = decimal.Parse(regis.total.ToString());
            //    return canonMunicipal;
            //}

        }
        public DataTable GetFacturasDetalles(int idFactura)
        {

            try
            {
                string consulta;
                consulta = "select " +
                    //f.id_factura, " +
                    // " f.id_periodo, fd.id_detalle, fd.id_concepto, " +
                " c.concepto, fd.importe, f.importeTotal " +
                " from facturas_detalles fd " +
                " inner join facturas f on fd.id_factura=f.id_factura " +
                " inner join cod_estados_pago ep on ep.id_estado_pago=f.id_estadoPago " +
                " inner join socios_mediciones sm on sm.id_medicion=f.id_medicion " +
                " inner join periodos p on p.id_periodo=f.id_periodo " +
                " inner join cod_conceptos c on c.id_concepto=fd.id_concepto " +
                " where f.id_factura=" + idFactura.ToString();
                DataTable dt = new DataTable();
                string query;
                query = consulta;
                MySqlCommand cmd = new MySqlCommand(query, dbConectorMySql.ObtenerConexion());
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                adap.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
