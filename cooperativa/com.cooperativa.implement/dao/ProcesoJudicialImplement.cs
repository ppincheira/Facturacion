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
    public class ProcesoJudicialImplement
    {

        public  void Save(proceso_judicial oProceso)
        {
 
            cooperativaEntities bd = new cooperativaEntities();
            bd.proceso_judicial.AddObject(oProceso);
            bd.SaveChanges();
           
        }

        public void Update(proceso_judicial oProceso)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var editar = (from p in bd.proceso_judicial
                              where p.id_proceso_judicial == oProceso.id_proceso_judicial
                              select p).Single();
                editar.estado = oProceso.estado;
                editar.id_Estudio = oProceso.id_Estudio;
                editar.fechaAlta = oProceso.fechaAlta;
                editar.fechaResolucion = oProceso.fechaResolucion;
                editar.id_proceso_judicial = oProceso.id_proceso_judicial;
                editar.id_Socio = oProceso.id_Socio;
                bd.SaveChanges();
            }
        }

        public void Delete(int idProcesoJudicial)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.proceso_judicial
                             where p.id_proceso_judicial == idProcesoJudicial
                             select p).Single();
               
                bd.DeleteObject(regis);
                bd.SaveChanges();
            }
        }

        public proceso_judicial Get(int id)
        {
            proceso_judicial oProceso = new proceso_judicial();
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.proceso_judicial
                             where p.id_proceso_judicial== id
                             select p).Single();
                oProceso.estado = regis.estado;
                oProceso.fechaAlta = regis.fechaAlta;
                oProceso.fechaResolucion = regis.fechaResolucion;
                oProceso.id_Estudio = regis.id_Estudio;
                oProceso.id_proceso_judicial = regis.id_proceso_judicial;
                oProceso.id_Socio = regis.id_Socio;
                return oProceso;
            }
        }

     
        public List<proceso_judicial> GetAll()
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var Listar = (from p in bd.proceso_judicial
                              select p).ToList();
                return Listar;
            }
        }

        public bool Estado(int idSocio) {
            try
            {
                using (cooperativaEntities bd = new cooperativaEntities())
                {
                    var Listar = (from p in bd.proceso_judicial
                                  where p.id_Socio == idSocio
                                  orderby p.fechaAlta, p.estado
                                  select p).ToList();
                    bool band = false;
                    if ((Listar != null)&&(Listar.Count!=0))
                        band = (Listar[Listar.Count - 1].estado != 3);
                    return band;
                }
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public List<proceso_judicial> GetByIdSocio(int idSocio)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var Listar = (from p in bd.proceso_judicial
                              join pj in bd.cod_estados_pj on p.estado equals pj.id_cod_estado_pj
                              where p.id_Socio==idSocio 
                              orderby p.fechaAlta,p.estado
                              select p).ToList();
                return Listar;
            }
        }

        public DataTable GetByIdSocioDT(int idSocio)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var _Lista = (from p in bd.proceso_judicial
                              join pj in bd.cod_estados_pj on p.estado equals pj.id_cod_estado_pj
                              join es in bd.cod_estudios on p.id_Estudio equals es.id_estudio
                              where p.id_Socio == idSocio
                              orderby p.fechaAlta, p.estado
                              select new 
                              {
                                p.id_proceso_judicial,
                                p.id_Socio,
                                p.id_Estudio,
                                estado = pj.descripcion,
                                p.fechaAlta,
                                p.fechaResolucion,
                                estudio = es.descripcion
                              }                           
                              ).ToList();

                Commons oCommons = new Commons();
                return oCommons.convertToTable(_Lista);
            }
        }
    }
}
