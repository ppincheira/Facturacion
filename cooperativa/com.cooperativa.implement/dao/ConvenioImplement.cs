using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Windows.Forms;
using System.Collections;
using com.cooperativa.services;
using System.Data;

namespace com.cooperativa.implement
{
    public class ConvenioImplement
    {

        public  int Save(convenios oConvenio)
        {
            int i;
            cooperativaEntities bd = new cooperativaEntities();
            bd.convenios.AddObject(oConvenio);
            i=bd.SaveChanges();
            return i;
        }

        public void Update(convenios oConvenio)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var editar = (from p in bd.convenios
                              where p.id_convenio == oConvenio.id_convenio
                              select p).Single();
                editar.convenio_judicial = oConvenio.convenio_judicial;
                editar.cuota_iva = oConvenio.cuota_iva;
                editar.cuotas = oConvenio.cuotas;
                editar.facturadas = oConvenio.facturadas;
                editar.fecha_convenio = oConvenio.fecha_convenio;
                editar.fecha_registro = oConvenio.fecha_registro;
                editar.finalizado = oConvenio.finalizado;
                editar.id_convenio = oConvenio.id_convenio;
                editar.id_socio = oConvenio.id_socio;
                editar.id_terminal = oConvenio.id_terminal;
                editar.id_usuario = oConvenio.id_usuario;
                editar.importe_descuento_recargo = oConvenio.importe_descuento_recargo;
                editar.importe_total = oConvenio.importe_total;
                editar.iva_facturas = oConvenio.iva_facturas;
                editar.pendientes = oConvenio.pendientes;
                editar.porcentaje_descuento_recargo = oConvenio.porcentaje_descuento_recargo;
                editar.tipo_descuento_recargo = oConvenio.tipo_descuento_recargo;
                editar.valor_cuota = oConvenio.valor_cuota;
                bd.SaveChanges();
            }
        }

        public bool ConvenioVolcado(int idSocio) {

            return true;
        }


        public convenios Get(int id)
        {
            convenios oConvenio = new convenios();

            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.convenios
                             where p.id_convenio == id
                             select p).Single();
                oConvenio.convenio_judicial = regis.convenio_judicial;
                oConvenio.cuota_iva = regis.cuota_iva;
                oConvenio.cuotas = regis.cuotas;
                oConvenio.facturadas = regis.facturadas;
                oConvenio.fecha_convenio = regis.fecha_convenio;
                oConvenio.fecha_registro = regis.fecha_registro;
                oConvenio.finalizado = regis.finalizado;
                oConvenio.id_convenio = regis.id_convenio;
                oConvenio.id_socio = regis.id_socio;
                oConvenio.id_terminal = regis.id_terminal;
                oConvenio.id_usuario = regis.id_usuario;
                oConvenio.importe_descuento_recargo = regis.importe_descuento_recargo;
                oConvenio.importe_total = regis.importe_total;
                oConvenio.iva_facturas = regis.iva_facturas;
                oConvenio.pendientes = regis.pendientes;
                oConvenio.porcentaje_descuento_recargo = regis.porcentaje_descuento_recargo;
                oConvenio.tipo_descuento_recargo = regis.tipo_descuento_recargo;
                oConvenio.valor_cuota = regis.valor_cuota;
                return oConvenio;
            }

        }


        public List<convenios> GetAll()
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var Listar = (from p in bd.convenios
                              select p).ToList();

                return Listar;
            }
        }

        public List<convenios> GetAllBySocio(int idSocio)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var Listar = (from p in bd.convenios
                              where p.id_socio==idSocio && p.finalizado==false
                              select p).ToList();

                return Listar;
            }
        }

        public DataTable GetConveniosBySocioDT(int idSocio)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var Listar = (from p in bd.convenios
                              where p.id_socio==idSocio
                              orderby p.id_convenio ascending
                              select new
                              {
                                  p.id_convenio,
                                  //p.id_socio,
                                  p.fecha_convenio,
                                  p.importe_total,
                                  p.valor_cuota,
                                  p.cuotas,
                                  p.facturadas,
                                  //p.pendientes,
                                  finalizado = (bool)p.finalizado? "Si":"No",
                                  //p.iva_facturas,
                                  //p.cuota_iva,
                                  //p.convenio_judicial,
                                  //p.porcentaje_descuento_recargo,
                                  //p.importe_descuento_recargo,
                                  //p.tipo_descuento_recargo,
                                  //p.id_usuario,
                                  //p.id_terminal,
                                  //p.fecha_registro
                              }).ToList();

                Commons oCommons = new Commons();
                return oCommons.convertToTable(Listar);
            }
        }

        public void CancelarAdeudado(int idSocio)
        {
            List<convenios> listConveniosBySocio = GetAllBySocio(idSocio);
            foreach (convenios oConvenio in listConveniosBySocio)
            {
                oConvenio.finalizado = true;
                Update(oConvenio);
            }
        }


        public void Delete(int idConvenio)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                DataTable dtFacturas = new DataTable();
                FacturasImplement oFacturasImplement = new FacturasImplement();
                var listar = (from f in bd.facturas
                              where f.id_convenio == idConvenio
                                select f).ToList();
                Commons oCommons = new Commons();
                dtFacturas=oCommons.convertToTable(listar);
               
                foreach(DataRow dr in dtFacturas.Rows)
                {
                    int idFactura = int.Parse(dr["id_factura"].ToString());
                    facturas oFacturas = new facturas();
                    oFacturas = oFacturasImplement.Get(idFactura);
                    oFacturas.id_convenio = 0;
                    oFacturasImplement.Update(oFacturas);
                }

                var regis = (from p in bd.convenios
                             where p.id_convenio == idConvenio
                             select p).Single();

                bd.DeleteObject(regis);
                bd.SaveChanges();
            }
        }

    }
}

