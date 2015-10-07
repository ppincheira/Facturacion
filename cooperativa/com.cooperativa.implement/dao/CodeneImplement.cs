using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Collections;
using System.Windows.Forms;
using com.cooperativa.implement;

namespace com.cooperativa.implement
{
    public class CodeneImplement
    {

        public  void Save(codene oCodene)
        {

            cooperativaEntities bd = new cooperativaEntities();
            bd.codene.AddObject(oCodene);
            bd.SaveChanges();
           
        }

        public void Update(codene oCodene)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var editar = (from p in bd.codene
                              where p.id_codene == oCodene.id_codene
                              select p).Single();

                editar.fechaAlta = oCodene.fechaAlta;
                editar.FechaBaja = oCodene.FechaBaja;
                editar.id_socio = oCodene.id_socio;
                editar.id_codene = oCodene.id_codene;
                bd.SaveChanges();
            }
        }

        public void Delete(int idCodene)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.codene
                             where p.id_codene == idCodene
                             select p).Single();

                bd.DeleteObject(regis);
                bd.SaveChanges();
                
            }
        }

        public List<codene> GetAll()
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var listar = (from p in bd.codene
                              select p).ToList();
                return listar;
            }
        }

        public List<codene> GetByIdSocio(int idSocio)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var listar = (from p in bd.codene
                              where p.id_socio==idSocio
                              orderby p.fechaAlta descending
                              select p).ToList();
                return listar;
            }
        }


        public codene Get(int id)
        {
            codene oCodene = new codene();
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.codene
                             where p.id_codene == id
                             select p).Single();
                oCodene.id_codene = regis.id_codene;
                oCodene.id_socio = regis.id_socio;
                oCodene.fechaAlta = regis.fechaAlta;
                oCodene.FechaBaja = regis.FechaBaja;
                return oCodene;
            }
        }

    }
}

