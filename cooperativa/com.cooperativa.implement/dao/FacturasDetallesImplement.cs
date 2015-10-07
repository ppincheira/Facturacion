using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using com.cooperativa.services;

namespace com.cooperativa.implement
{
    public class FacturasDetallesImplement
    {

        public int Save(facturas_detalles oFacturaDetalle)
        {

            cooperativaEntities bd = new cooperativaEntities();
            bd.facturas_detalles.AddObject(oFacturaDetalle);
            bd.SaveChanges();
            return oFacturaDetalle.id_detalle;
        }
        public DataTable GetByIdFacturaDT(int idFactura)
        {

            try
            {
                using (cooperativaEntities bd = new cooperativaEntities())
                {

                    var Listar = (from fd in bd.facturas_detalles

                                  join c in bd.cod_conceptos on fd.id_concepto equals c.id_concepto
                                  where fd.id_factura == idFactura
                                  select new
                                  {
                                      c.concepto,
                                      valor=fd.importe

                                  }).ToList();

                    Commons oCommons = new Commons();
                    return oCommons.convertToTable(Listar);
                }

            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable GetAllByIdFacturaDT(int idFactura)
        {

            try
            {
                using (cooperativaEntities bd = new cooperativaEntities())
                {

                    var Listar = (from fd in bd.facturas_detalles

                                  join c in bd.cod_conceptos on fd.id_concepto equals c.id_concepto
                                  where fd.id_factura == idFactura
                                  select fd).ToList();
                                  
                    Commons oCommons = new Commons();
                    return oCommons.convertToTable(Listar);
                }

            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
