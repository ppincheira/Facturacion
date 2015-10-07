using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Windows.Forms;
using System.Collections;
namespace com.cooperativa.implement
{
    public class SituacionEspecialImplement
    {

        public  void Save(cod_situacion_especial oSituacion)
        {

            cooperativaEntities bd = new cooperativaEntities();
            bd.cod_situacion_especial.AddObject(oSituacion);
            bd.SaveChanges();
           
        }

        public void Update(cod_situacion_especial oSituacion)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var editar = (from p in bd.cod_situacion_especial
                              where p.id_situacion_especial == oSituacion.id_situacion_especial
                              select p).Single();

                editar.situacion_especial = oSituacion.situacion_especial;
                bd.SaveChanges();
            }
        }


        public List<cod_situacion_especial> Buscar(string nombre)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var buscar = (from p in bd.cod_situacion_especial
                              where p.situacion_especial.StartsWith(nombre)
                              select p).ToList();

                return buscar;
            }
        }

        public cod_situacion_especial Get(int id)
        {
            cod_situacion_especial oSituacion = new cod_situacion_especial();
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.cod_situacion_especial
                             where p.id_situacion_especial == id
                             select p).Single();
                oSituacion.id_situacion_especial = regis.id_situacion_especial;
                oSituacion.situacion_especial = regis.situacion_especial;
                return oSituacion;
            }
        }

        public List<cod_situacion_especial> GetAll()
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var listado = (from p in bd.cod_situacion_especial
                               select p).ToList();

                return listado;
            }
        }

        public void CargarCombo(ComboBox combo, string InsertaFila)
        {
            IList ListaSituaciones = GetAll();
            cod_situacion_especial oSituacion = new cod_situacion_especial();
            oSituacion.id_situacion_especial = 0;
            oSituacion.situacion_especial = InsertaFila;
            ListaSituaciones.Insert(0, oSituacion);
            combo.DisplayMember = "situacion_especial";
            combo.ValueMember = "id_situacion_especial";
            combo.DataSource = ListaSituaciones;
        }
        

    }
}

