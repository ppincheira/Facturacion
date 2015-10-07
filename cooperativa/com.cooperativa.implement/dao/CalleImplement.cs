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
    public class CalleImplement
    {

        public  void Save(cod_calles oCalle)
        {
 
            cooperativaEntities bd = new cooperativaEntities();
            bd.cod_calles.AddObject(oCalle);
            bd.SaveChanges();
           
        }

        public void Update(cod_calles oCalle)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var editar = (from p in bd.cod_calles
                              where p.id_calle == oCalle.id_calle
                              select p).Single();

                editar.calle = oCalle.calle;
                editar.normalizado = oCalle.normalizado;
                bd.SaveChanges();
            }
        }


        public List<cod_calles> Buscar(string nombre)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var buscar = (from p in bd.cod_calles
                              where p.calle.StartsWith(nombre)
                              select p).ToList();

                return buscar;
            }
        }

        public cod_calles Get(int id)
        {
            cod_calles oCalle = new cod_calles();
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.cod_calles
                             where p.id_calle == id
                             select p).Single();
                oCalle.id_calle = regis.id_calle;
                oCalle.calle = regis.calle;
                oCalle.normalizado = regis.normalizado;
                return oCalle;
            }
        }


        public List<cod_calles> GetAll()
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var buscar = (from p in bd.cod_calles
                              select p).ToList();
                return buscar;
            }
        }

        public void CargarCombo(ComboBox combo, string InsertaFila)
        {
            IList ListaCalles = GetAll();
            cod_calles oCalle = new cod_calles();
            oCalle.id_calle = 0;
            oCalle.normalizado = InsertaFila;
            ListaCalles.Insert(0, oCalle);
            combo.DisplayMember = "normalizado";
            combo.ValueMember = "id_calle";
            combo.DataSource = ListaCalles;
        }


        public DataTable GetByNombreDT(string nombre)
        {
            try
            {
                using (cooperativaEntities bd = new cooperativaEntities())
                {
                    var Listar = (from p in bd.cod_calles
                                  where p.calle.StartsWith(nombre)
                                  select new
                                  {
                                    Codigo = p.id_calle,
                                    p.calle,
                                    p.normalizado
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
