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
    public class AccionImplement
    {
        public int Save(acciones oAccion)
        {
            try
            {
                cooperativaEntities bd = new cooperativaEntities();
                bd.acciones.AddObject(oAccion);
                bd.SaveChanges();
                return oAccion.id_accion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(acciones oAccion)
        {
            try
            {
                using (cooperativaEntities bd = new cooperativaEntities())
                {
                    var editar = (from p in bd.acciones
                                  where p.id_accion == oAccion.id_accion
                                  select p).Single();
                    editar.cuotas = oAccion.cuotas;
                    editar.facturadas = oAccion.facturadas;
                    editar.fecha = oAccion.fecha;
                   
                    editar.finalizado = oAccion.finalizado;
                    editar.id_accion = oAccion.id_accion;
                    editar.id_socio = oAccion.id_socio;
                    editar.importe = oAccion.importe;
                    editar.pendientes = oAccion.pendientes;
                    editar.valor_cuota = oAccion.valor_cuota;
                    bd.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int idAccion)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.acciones
                             where p.id_accion == idAccion
                             select p).Single();

                bd.DeleteObject(regis);
                bd.SaveChanges();

            }
        }

        public acciones Get(int id)
        {
            try{

                acciones oAccion = new acciones();
            
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.acciones
                             where p.id_accion == id
                             select p).Single();
                oAccion.cuotas = regis.cuotas;
                oAccion.facturadas = regis.facturadas;
                oAccion.fecha = regis.fecha;
                oAccion.finalizado = regis.finalizado;
                oAccion.id_accion = regis.id_accion;
                oAccion.id_socio = regis.id_socio;
                oAccion.importe = regis.importe;
                oAccion.pendientes = regis.pendientes;
                oAccion.valor_cuota = regis.valor_cuota;
                return oAccion;
            }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public acciones GetByIdSocio(int idSocio)
        {
            try
            {

                acciones oAccion = new acciones();
                
                using (cooperativaEntities bd = new cooperativaEntities())
                {
                    int cant = (from p in bd.acciones
                                where p.id_socio == idSocio
                                select p).Count();
                    if (cant > 0)
                    {
                        var regis = (from p in bd.acciones
                                     where p.id_socio == idSocio
                                     select p).FirstOrDefault();
                        oAccion.cuotas = regis.cuotas;
                        oAccion.facturadas = regis.facturadas;
                        oAccion.fecha = regis.fecha;
                        oAccion.finalizado = regis.finalizado;
                        oAccion.id_accion = regis.id_accion;
                        oAccion.id_socio = regis.id_socio;
                        oAccion.importe = regis.importe;
                        oAccion.pendientes = regis.pendientes;
                        oAccion.valor_cuota = regis.valor_cuota;
                    }
                    else
                    {
                        oAccion = null;
                    }
                    return oAccion;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<acciones> GetAll()
        {
            try{
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var Listar = (from p in bd.acciones
                              select p).ToList();

                return Listar;
            }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable CargarAcciones(int idSocio)
        {

            try
            {
                using (cooperativaEntities bd = new cooperativaEntities())
                {
                    var _Lista = (from p in bd.acciones
                                  where p.id_socio == idSocio
                                  orderby p.fecha
                                  select new 
                                  {
                                    p.id_accion,
                                    p.fecha,
                                    p.importe,
                                    p.cuotas,
                                    p.valor_cuota,
                                    p.facturadas,
                                    p.pendientes,
                                    p.finalizado
                                  }
                                  ).ToList();

                    Commons oCommons = new Commons();
                    return oCommons.convertToTable(_Lista);
                }
            }
            catch (Exception)
            {
                return null;
            }
        }


    }
}

