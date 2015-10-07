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
    public class MoratoriasImplement
    {
        public int Save(moratorias oMoratorias)
        {
            int i;
            cooperativaEntities bd = new cooperativaEntities();
            bd.moratorias.AddObject(oMoratorias);
            bd.SaveChanges();
            i = oMoratorias.idmoratorias;
            return i;
        }

        public void Update(moratorias oMoratorias)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var editar = (from p in bd.moratorias
                              where p.idmoratorias == oMoratorias.idmoratorias
                              select p).Single();
                editar.vigencia_desde = oMoratorias.vigencia_desde;
                editar.vigencia_hasta = oMoratorias.vigencia_hasta;
                editar.cantidad_cuotas_max = oMoratorias.cantidad_cuotas_max;
                editar.limitar = oMoratorias.limitar;
                bd.SaveChanges();
            }
        }

        public void Delete(int idMoratoria)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.moratorias
                             where p.idmoratorias == idMoratoria
                             select p).Single();

                bd.DeleteObject(regis);
                bd.SaveChanges();
            }
        }

        public moratorias Get(int id)
        {
            moratorias oMoratorias = new moratorias();
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.moratorias
                             where p.idmoratorias == id
                             select p).Single();
                oMoratorias.idmoratorias=regis.idmoratorias;
                oMoratorias.vigencia_desde = regis.vigencia_desde;
                oMoratorias.vigencia_hasta = regis.vigencia_hasta;
                oMoratorias.cantidad_cuotas_max = regis.cantidad_cuotas_max;
                oMoratorias.limitar = regis.limitar;
                return oMoratorias;
            }
        }

        public List<moratorias> GetAll()
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var listado = (from p in bd.moratorias
                               select p).ToList();

                return listado;
            }
        }

        public DataTable GetAllByAnioDT(string anio)
        {
            DateTime fechaAnioIni;
            DateTime fechaAnioFin;
            if (anio != "Seleccione...")
            {
                fechaAnioIni = new DateTime(int.Parse(anio), 1, 1);
                fechaAnioFin = new DateTime(int.Parse(anio), 12, 31);
            }
            else {
                fechaAnioIni = new DateTime(1900, 1, 1);
                fechaAnioFin = new DateTime(2500, 12, 31);
            }
            DataTable dt = new DataTable();
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var listado = (from p in bd.moratorias
                               where p.vigencia_desde>=fechaAnioIni && p.vigencia_desde<=fechaAnioFin
                               select p).ToList();

                Commons oCommons = new Commons();
                dt = oCommons.convertToTable(listado);

                return dt;
            }
        }


        public bool ExisteMoratoria(DateTime fechaInicio, DateTime fechaFin, int idMoratoria)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.moratorias
                             where 
                                   (fechaInicio>=p.vigencia_desde && fechaInicio<=p.vigencia_hasta)
                                   |(fechaFin>=p.vigencia_desde && fechaFin<=p.vigencia_hasta)
                                   |(fechaInicio<=p.vigencia_desde && fechaFin>=p.vigencia_hasta)
                             //((p.vigencia_desde >= fechaInicio && p.vigencia_hasta <= fechaFin)
                             //   | (p.vigencia_hasta <= fechaFin && p.vigencia_hasta >= fechaInicio))
                                && p.idmoratorias != idMoratoria
                             select p).Count();

                if (int.Parse(regis.ToString()) > 0)
                    return true;
                else
                    return false;
            }
        }

        public DataTable GetTablaCuotasConvenioMoratoria(int maxCanCuotas, DateTime fecha, decimal importeTotalSinInteres, decimal importeTotalIntereses)
        {
            moratorias oMoratoria = new moratorias();
            DataTable _dtCuotasMoratoria = new DataTable();
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.moratorias
                             where (p.vigencia_desde <= fecha && p.vigencia_hasta >= fecha)
                             select p).Single();

                oMoratoria.idmoratorias =regis.idmoratorias;
                oMoratoria.vigencia_desde=regis.vigencia_desde;
                oMoratoria.vigencia_hasta=regis.vigencia_hasta;
                oMoratoria.cantidad_cuotas_max=regis.cantidad_cuotas_max;
                oMoratoria.limitar=regis.limitar;

                int cantidadCuotas = 1;
                if ((maxCanCuotas > oMoratoria.cantidad_cuotas_max) | ((bool)oMoratoria.limitar))
                {
                    cantidadCuotas = (int)oMoratoria.cantidad_cuotas_max;
                }
                else {
                    cantidadCuotas = maxCanCuotas;
                }

                var regisD = (from d in bd.detalles_moratoria
                             where d.idmoratoria== oMoratoria.idmoratorias
                              select d).ToList();
              
                Commons oCommons = new Commons();
                DataTable detallesMoratoria = oCommons.convertToTable(regisD);
                
                _dtCuotasMoratoria.Columns.AddRange(new DataColumn[5] { new DataColumn("Cuotas", typeof(int)),  
                            new DataColumn("PorcDesc",typeof(decimal)),  
                            new DataColumn("Descuento",typeof(decimal)),
                            new DataColumn("TotalConDescuento",typeof(decimal)),
                            new DataColumn("ValorCuota",typeof(decimal))});
                foreach (DataRow dr in detallesMoratoria.Rows)
                {
                    int cuotaDesde = int.Parse(dr["cuota_desde"].ToString());
                    int cuotaHasta = int.Parse(dr["cuota_hasta"].ToString());
                    for (int i=cuotaDesde; i<=cuotaHasta; i++)
                    {
                        if (i <= cantidadCuotas)
                        {
                            decimal porcDescuento =decimal.Parse(dr["descuento"].ToString());
                            decimal descuento = Math.Round(importeTotalIntereses * (porcDescuento / 100), 2);
                            decimal totalConDescuento = Math.Round(importeTotalSinInteres+(importeTotalIntereses * ((100 - porcDescuento) / 100)), 2);
                            decimal valorCuota = Math.Round(totalConDescuento/i, 2);
                            _dtCuotasMoratoria.Rows.Add(i, porcDescuento, descuento, totalConDescuento, valorCuota);
                        }
                    }
                }
            }
            return _dtCuotasMoratoria;
        }


        public bool TieneConvenios(int idMoratoria)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                moratorias oMoratoria = new moratorias();
                oMoratoria = Get(idMoratoria);

                var regis = (from p in bd.convenios
                             where (p.fecha_convenio >= oMoratoria.vigencia_desde && p.fecha_convenio <= oMoratoria.vigencia_hasta)
                                && ((bool)p.moratoria)
                             select p).Count();

                if (int.Parse(regis.ToString()) > 0)
                    return true;
                else
                    return false;
            }
        }
    }
}
