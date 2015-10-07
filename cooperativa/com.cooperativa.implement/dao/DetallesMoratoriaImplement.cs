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
    public class DetallesMoratoriaImplement
    {
        public void Save(detalles_moratoria oDetallesMoratoria)
        {

            cooperativaEntities bd = new cooperativaEntities();
            bd.detalles_moratoria.AddObject(oDetallesMoratoria);
            bd.SaveChanges();

        }

        public void Update(detalles_moratoria oDetallesMoratoria)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var editar = (from p in bd.detalles_moratoria
                              where p.iddetalles_moratoria == oDetallesMoratoria.iddetalles_moratoria
                              select p).Single();
                editar.idmoratoria = oDetallesMoratoria.idmoratoria;
                editar.cuota_desde = oDetallesMoratoria.cuota_desde;
                editar.cuota_hasta = oDetallesMoratoria.cuota_hasta;
                editar.descuento = oDetallesMoratoria.descuento;
                bd.SaveChanges();
            }
        }

        public void Delete(int idDetallesMoratoria)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.detalles_moratoria
                             where p.iddetalles_moratoria == idDetallesMoratoria
                             select p).Single();

                bd.DeleteObject(regis);
                bd.SaveChanges();
            }
        }

        public void DeleteByIdMoratoria(int idMoratoria)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var lista = (from p in bd.detalles_moratoria
                             where p.idmoratoria == idMoratoria
                             select p).ToList();

                foreach(detalles_moratoria d in lista)
                {
                    bd.DeleteObject(d);
                    bd.SaveChanges();
                }
                
            }
        }
        
        public List<detalles_moratoria> GetAll()
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var listado = (from p in bd.detalles_moratoria
                               select p).ToList();

                return listado;
            }
        }

        public DataTable GetAllByIdMoratoria(int idmoratoria)
        {
            DataTable dt = new DataTable();
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var listado = (from p in bd.detalles_moratoria
                               where p.idmoratoria == idmoratoria
                               select p).ToList();

                Commons oCommons = new Commons();
                dt = oCommons.convertToTable(listado);

                return dt;
            }
        }
    }
}
