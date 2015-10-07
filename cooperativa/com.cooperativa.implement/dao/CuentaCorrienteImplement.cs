
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Windows.Forms;
using System.Collections;
using System.Data;
using MySql.Data.MySqlClient;
using com.cooperativa.services;

namespace com.cooperativa.implement
{
    public class CuentaCorrienteImplement
    {


        public int Save(cuentas_corrientes oCuentaCorriente)
        {
            try
            {
                cooperativaEntities bd = new cooperativaEntities();
                bd.cuentas_corrientes.AddObject(oCuentaCorriente);
                bd.SaveChanges();
                return oCuentaCorriente.id_cuenta_corriente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(cuentas_corrientes oCuentaCorriente)
        {
            try
            {
                using (cooperativaEntities bd = new cooperativaEntities())
                {
                    var editar = (from p in bd.cuentas_corrientes
                                  where p.id_cuenta_corriente == oCuentaCorriente.id_cuenta_corriente
                                  select p).Single();
                    editar.fecha = oCuentaCorriente.fecha;
                    editar.id_cobranza = oCuentaCorriente.id_cobranza;
                    editar.id_cuenta_corriente = oCuentaCorriente.id_cuenta_corriente;
                    editar.id_factura = oCuentaCorriente.id_factura;
                    editar.id_movimiento = oCuentaCorriente.id_movimiento;
                    editar.id_socio = oCuentaCorriente.id_socio;
                    editar.importe_credito = oCuentaCorriente.importe_credito;
                    editar.importe_debito = oCuentaCorriente.importe_debito;
                    editar.importe_saldo = oCuentaCorriente.importe_saldo;
                    bd.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        public cuentas_corrientes Get(int id)
        {
            try
            {
                cuentas_corrientes oCuentaCorriente = new cuentas_corrientes();
                using (cooperativaEntities bd = new cooperativaEntities())
                {
                    var regis = (from p in bd.cuentas_corrientes
                                 where p.id_cuenta_corriente == id
                                 select p).Single();
                    oCuentaCorriente.fecha = regis.fecha;
                    oCuentaCorriente.id_cobranza = regis.id_cobranza;
                    oCuentaCorriente.id_cuenta_corriente = regis.id_cuenta_corriente;
                    oCuentaCorriente.id_factura = regis.id_factura;
                    oCuentaCorriente.id_movimiento = regis.id_movimiento;
                    oCuentaCorriente.id_socio = regis.id_socio;
                    oCuentaCorriente.importe_credito = regis.importe_credito;
                    oCuentaCorriente.importe_debito = regis.importe_debito;
                    oCuentaCorriente.importe_saldo = regis.importe_saldo;
                    return oCuentaCorriente;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<cuentas_corrientes> GetAll()
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var Listar = (from p in bd.cuentas_corrientes
                              select p).ToList();

                return Listar;
            }
        }

        public DataTable GetByIdSocio(int idSocio)
        {

            try
            {
                //string consulta = "call cuentas_corrientes_GetByIdSocio("+idSocio.ToString() +")";

                //DataTable dt = new DataTable();
                //string query = consulta;
                //MySqlCommand cmd = new MySqlCommand(query, dbConectorMySql.ObtenerConexion());
                //MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                //adap.Fill(dt);
                //return dt;

                using (cooperativaEntities bd = new cooperativaEntities())
                {     
                    //from p in bd.proceso_judicial
                    //          join pj in bd.cod_estados_pj on p.estado equals pj.id_cod_estado_pj
                    //          where p.id_Socio==idSocio 
                    //          orderby p.fechaAlta,p.estado
                    //          select p).ToList();
                    var Listar = (from p in bd.cuentas_corrientes 
                                  join cu in bd.cod_movimientos on p.id_movimiento equals cu.id_movimiento
                                  where p.id_socio == idSocio 
                                  select new
                                  {
                                      p.id_socio,
                                      p.id_cuenta_corriente,
                                      p.id_cobranza,
                                      p.id_factura,
                                      p.fecha,
                                      cu.movimiento,
                                      debito=p.importe_debito,
                                      credito=p.importe_credito,
                                      saldo=p.importe_saldo

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

    }
}
