using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data;
using com.cooperativa.services;

namespace com.cooperativa.implement.dao
{
    public class conceptosParticularesImplement
    {
        public void Save(conceptos_particulares oConceptos_Particulares)
        {

            cooperativaEntities bd = new cooperativaEntities();
            bd.conceptos_particulares.AddObject(oConceptos_Particulares);
            bd.SaveChanges();

        }

        public void Update(conceptos_particulares oConceptos_Particulares)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var editar = (from p in bd.conceptos_particulares
                              where p.id_concepto_particular == oConceptos_Particulares.id_concepto_particular
                              select p).Single();

                editar.id_socio = oConceptos_Particulares.id_socio;
                editar.id_periodo = oConceptos_Particulares.id_periodo;
                editar.id_concepto = oConceptos_Particulares.id_concepto;
                editar.importe = oConceptos_Particulares.importe;
                editar.facturado = oConceptos_Particulares.facturado;
                editar.id_factura = oConceptos_Particulares.id_factura;
                editar.detalles = oConceptos_Particulares.detalles;
                bd.SaveChanges();
            }
        }

        public void Delete(int idConceptoParticular)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.conceptos_particulares
                             where p.id_concepto_particular == idConceptoParticular
                             select p).Single();

                bd.DeleteObject(regis);
                bd.SaveChanges();
            }
        }
        //public List<conceptos_particulares> Buscar(string nombre)
        //{
        //    using (cooperativaEntities bd = new cooperativaEntities())
        //    {
        //        var buscar = (from p in bd.cod_conceptos
        //                      where p.concepto.StartsWith(nombre)
        //                      select p).ToList();

        //        return buscar;
        //    }
        //}

        public conceptos_particulares Get(int id)
        {
            conceptos_particulares oConceptos_Particulares = new conceptos_particulares();
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.conceptos_particulares
                             where p.id_concepto_particular == id
                             select p).Single();
                oConceptos_Particulares.id_concepto_particular = regis.id_concepto_particular;
                oConceptos_Particulares.id_socio = regis.id_socio;
                oConceptos_Particulares.id_periodo = regis.id_periodo;
                oConceptos_Particulares.id_concepto = regis.id_concepto;
                oConceptos_Particulares.importe = regis.importe;
                oConceptos_Particulares.facturado = regis.facturado;
                oConceptos_Particulares.id_factura = regis.id_factura;
                oConceptos_Particulares.detalles = regis.detalles;

                return oConceptos_Particulares;
            }
        }

        public List<conceptos_particulares> GetAll()
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var Listar = (from p in bd.conceptos_particulares
                              
                              select p).ToList();
                return Listar;
            }
        }

        //public void CargarCombo(ComboBox combo, string InsertaFila)
        //{
        //    IList ListarConceptosParticulares = GetAll();
        //    conceptos_particulares oConceptos_Particulares = new conceptos_particulares();

        //    oConceptos_Particulares.id_concepto_particular = 0;
        //    oConceptos_Particulares.detalles = InsertaFila;
        //    ListarConceptos.Insert(0, oConcepto);
        //    combo.DisplayMember = "concepto";
        //    combo.ValueMember = "id_concepto";
        //    combo.DataSource = ListarConceptos;
        //}

        public List<conceptos_particulares> GetByIdSocio(int idSocio)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var listar = (from p in bd.conceptos_particulares
                              where p.id_socio == idSocio
                              select p).ToList();
                return listar;
            }
        }

        public conceptos_particulares GetByFilter(int idSocio, int idConcepto, string idPeriodo)
        {
                conceptos_particulares oConceptos_Particulares = new conceptos_particulares();
                using (cooperativaEntities bd = new cooperativaEntities())
                {
                    var regis = (from p in bd.conceptos_particulares
                                 where((p.id_socio == idSocio) &&(p.id_periodo==idPeriodo)&&(p.id_concepto==idConcepto))
                                 select p).SingleOrDefault();
                    if (regis != null)
                    {
                        oConceptos_Particulares.id_concepto_particular = regis.id_concepto_particular;
                        oConceptos_Particulares.id_socio = regis.id_socio;
                        oConceptos_Particulares.id_periodo = regis.id_periodo;
                        oConceptos_Particulares.id_concepto = regis.id_concepto;
                        oConceptos_Particulares.importe = regis.importe;
                        oConceptos_Particulares.facturado = regis.facturado;
                        oConceptos_Particulares.id_factura = regis.id_factura;
                        oConceptos_Particulares.detalles = regis.detalles;
                    }
                    else
                        oConceptos_Particulares = null;
                    return oConceptos_Particulares;
                }
            
        }

        public DataTable GetByIdSocioDT(int idSocio)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var Listar = (from p in bd.conceptos_particulares
                              where p.id_socio == idSocio
                              select new
                              {
                                  p.id_concepto_particular,
                                  concepto=p.detalles,
                                  p.importe,
                                  p.id_periodo
                              }).ToList();

                Commons oCommons = new Commons();
                return oCommons.convertToTable(Listar);
            }
        }

    }
}
