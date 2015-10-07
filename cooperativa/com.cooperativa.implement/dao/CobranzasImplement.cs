using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Windows.Forms;
using System.Collections;
using System.Data;
using com.cooperativa.services;

namespace com.cooperativa.implement.dao
{
    public class CobranzasImplement
    {
        public void Save(cobranzas oCobranza)
        {
            cooperativaEntities bd = new cooperativaEntities();
            bd.cobranzas.AddObject(oCobranza);
            bd.SaveChanges();
        }

        public void Update(cobranzas oCobranza)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var editar = (from p in bd.cobranzas
                              where p.id_cobranza == oCobranza.id_cobranza
                              select p).Single();

                editar.id_caja = oCobranza.id_caja;
                editar.id_factura = oCobranza.id_factura;
                editar.id_recibo = oCobranza.id_recibo;
                editar.id_socio = oCobranza.id_socio;
                editar.importe = oCobranza.importe;
                editar.descuento_convenio = oCobranza.descuento_convenio;
                editar.iva_descuento_convenio = oCobranza.iva_descuento_convenio;
                editar.fecha_cobro = oCobranza.fecha_cobro;
                editar.id_usuario = oCobranza.id_usuario;
                editar.id_terminal = oCobranza.id_terminal;
                editar.fecha_registro = oCobranza.fecha_registro;
                bd.SaveChanges();
            }
        }

        public void Delete(int idCobranza)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.cobranzas
                             where p.id_cobranza == idCobranza
                             select p).Single();

                bd.DeleteObject(regis);
                bd.SaveChanges();
            }
        }

        public cobranzas Get(int id)
        {
            try
            {
                cobranzas oCobranzas = new cobranzas();
                using (cooperativaEntities bd = new cooperativaEntities())
                {
                    var regis = (from p in bd.cobranzas
                                 where p.id_cobranza == id
                                 select p).Single();

                    oCobranzas.id_cobranza = regis.id_cobranza;
                    oCobranzas.id_caja = regis.id_caja;
                    oCobranzas.id_factura = regis.id_factura;
                    oCobranzas.id_recibo = regis.id_recibo;
                    oCobranzas.id_socio = regis.id_socio;
                    oCobranzas.importe = regis.importe;
                    oCobranzas.descuento_convenio = regis.descuento_convenio;
                    oCobranzas.iva_descuento_convenio = regis.iva_descuento_convenio;
                    oCobranzas.fecha_cobro = regis.fecha_cobro;
                    oCobranzas.id_usuario = regis.id_usuario;
                    oCobranzas.id_terminal = regis.id_terminal;
                    oCobranzas.fecha_registro = regis.fecha_registro;

                    return oCobranzas;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public cobranzas GetByIdFactura(int idFactura)
        {
            try
            {
                cobranzas oCobranzas = new cobranzas();
                using (cooperativaEntities bd = new cooperativaEntities())
                {
                    var regis = (from p in bd.cobranzas
                                 where p.id_factura == idFactura
                                 select p).FirstOrDefault();

                    oCobranzas.id_cobranza = regis.id_cobranza;
                    oCobranzas.id_caja = regis.id_caja;
                    oCobranzas.id_factura = regis.id_factura;
                    oCobranzas.id_recibo = regis.id_recibo;
                    oCobranzas.id_socio = regis.id_socio;
                    oCobranzas.importe = regis.importe;
                    oCobranzas.descuento_convenio = regis.descuento_convenio;
                    oCobranzas.iva_descuento_convenio = regis.iva_descuento_convenio;
                    oCobranzas.fecha_cobro = regis.fecha_cobro;
                    oCobranzas.id_usuario = regis.id_usuario;
                    oCobranzas.id_terminal = regis.id_terminal;
                    oCobranzas.fecha_registro = regis.fecha_registro;

                    return oCobranzas;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int GetFacturas(DateTime _fecha)
        {
            try
            {
                cobranzas oCobranzas = new cobranzas();
                using (cooperativaEntities bd = new cooperativaEntities())
                {
                    int count = (from p in bd.cobranzas
                                 where p.fecha_cobro == _fecha
                                 select p).Count();



                    return count;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
