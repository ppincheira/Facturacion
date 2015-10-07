using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Windows.Forms;
using System.Collections;
using System.Data;
using com.cooperativa.services;

namespace com.cooperativa.implement
{
    public class SocioMedicionImplement
    {

        public int Save(socios_mediciones oSocioMedicion)
        {
            int i;
            cooperativaEntities bd = new cooperativaEntities();
            bd.socios_mediciones.AddObject(oSocioMedicion);
            i = bd.SaveChanges();
            return i;
        }

        public void Update(socios_mediciones oSocioMedicion)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var editar = (from p in bd.socios_mediciones
                              where p.id_medicion == oSocioMedicion.id_medicion
                              select p).Single();
                editar.id_socio = oSocioMedicion.id_socio;
                editar.consumo = oSocioMedicion.consumo;
                editar.fecha_lectura = oSocioMedicion.fecha_lectura;
                editar.id_medicion = oSocioMedicion.id_medicion;
                editar.lectura = oSocioMedicion.lectura;
                bd.SaveChanges();
            }
        }


        public List<socios_mediciones> GetByIdSocio(int idSocio)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var buscar = (from p in bd.socios_mediciones
                              where p.id_socio == idSocio
                              orderby p.fecha_lectura
                              select p).ToList();

                return buscar;
            }
        }

        public socios_mediciones Get(int id)
        {
            socios_mediciones oSocioMedicion = new socios_mediciones();
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.socios_mediciones
                             where p.id_medicion == id
                             select p).Single();
                oSocioMedicion.id_medicion = regis.id_medicion;
                oSocioMedicion.consumo = regis.consumo;
                oSocioMedicion.fecha_lectura = regis.fecha_lectura;
                oSocioMedicion.id_socio = regis.id_socio;
                oSocioMedicion.lectura = regis.lectura;
                return oSocioMedicion;
            }
        }

        public socios_mediciones ultimaMedicion(int idSocio)
        {
            socios_mediciones oSocioMedicion = new socios_mediciones();
            try
            {
                using (cooperativaEntities bd = new cooperativaEntities())
                {
                    var regis = (from p in bd.socios_mediciones
                                 where p.id_socio == idSocio
                                 orderby p.fecha_lectura descending
                                 select p).FirstOrDefault();
                    if (regis != null)
                    {
                        oSocioMedicion.id_medicion = regis.id_medicion;
                        oSocioMedicion.consumo = regis.consumo;
                        oSocioMedicion.fecha_lectura = regis.fecha_lectura;
                        oSocioMedicion.id_socio = regis.id_socio;
                        oSocioMedicion.lectura = regis.lectura;
                        return oSocioMedicion;
                    }
                    else
                        return regis;

                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<socios_mediciones> GetAll()
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var Listar = (from p in bd.socios_mediciones
                              select p).ToList();

                return Listar;
            }
        }

        public DataTable GetByIdSocioDT(int idSocio)
        {

            try
            {

                using (cooperativaEntities bd = new cooperativaEntities())
                {
                    var Listar = (from f in bd.facturas
                                  join sm in bd.socios_mediciones on f.id_medicion equals sm.id_medicion
                                  where f.id_socio == idSocio
                                  select new
                                  {
                                      f.id_periodo,
                                      sm.fecha_lectura,
                                      sm.consumo,
                                      sm.lectura,
                                      fechaAnt = (from f2 in bd.facturas
                                                  join sm2 in bd.socios_mediciones on f2.id_medicion equals sm2.id_medicion
                                                  where f2.id_socio == idSocio & sm2.fecha_lectura < sm.fecha_lectura
                                                  orderby sm2.fecha_lectura descending
                                                  select new
                                                  {
                                                      sm2.fecha_lectura
                                                  }).First(),
                                      lecturaAnt = (from f2 in bd.facturas
                                                    join sm2 in bd.socios_mediciones on f2.id_medicion equals sm2.id_medicion
                                                    where f2.id_socio == idSocio & sm2.fecha_lectura < sm.fecha_lectura
                                                    orderby sm2.fecha_lectura descending
                                                    select new
                                                    {
                                                        sm2.lectura
                                                    }).First()

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


        public DataTable GetByFilterDT(int idBarrio, Boolean SinEstadoActual, int ordenarBy)
        {
            try
            {
                using (cooperativaEntities bd = new cooperativaEntities())
                {
                    var Listar = (from f in bd.facturas
                                  join sm in bd.socios_mediciones on f.id_medicion equals sm.id_medicion
                                  join s in bd.socios on f.id_socio equals s.id_socio
                                 //faltan barrio y demas datos
                                 
                                  select new
                                  {
                                      f.id_periodo,
                                      f.id_socio,
                                      s.codigo_socio,
                                      s.nombre,
                                      sm.fecha_lectura,
                                      sm.consumo,
                                      sm.lectura,
                                      fechaAnt = String.Empty,                                   
                                      lecturaAnt = Decimal.Zero

                                  }).ToList();
                    Commons oCommons = new Commons();
                    return oCommons.convertToTable(Listar);
                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}

