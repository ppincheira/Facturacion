using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Windows.Forms;
using System.Collections;

namespace com.cooperativa.implement
{
    public class LocalidadImplement
    {

        public  void Save(cod_localidades oLocalidad)
        {
 
            cooperativaEntities bd = new cooperativaEntities();
            bd.cod_localidades.AddObject(oLocalidad);
            bd.SaveChanges();
           
        }

        public void Update(cod_localidades oLocalidad)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var editar = (from p in bd.cod_localidades
                              where p.id_localidad == oLocalidad.id_localidad
                              select p).Single();

                editar.localidad = oLocalidad.localidad;
                editar.codigoPostal = oLocalidad.codigoPostal;
                bd.SaveChanges();
            }
        }


        public List<cod_localidades> Buscar(string nombre)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var buscar = (from p in bd.cod_localidades
                              where p.localidad.StartsWith(nombre)
                              select p).ToList();

                return buscar;
            }
        }

        public cod_localidades Get(int id)
        {
            cod_localidades oLocalidad = new cod_localidades();
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.cod_localidades
                             where p.id_localidad == id
                             select p).Single();
                oLocalidad.id_localidad = regis.id_localidad;
                oLocalidad.localidad = regis.localidad;
                oLocalidad.codigoPostal = regis.codigoPostal;
                return oLocalidad;
            }
        }


        public List<cod_localidades> GetAll()
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var buscar = (from p in bd.cod_localidades
                              select p).ToList();
                return buscar;
            }
        }

        public void CargarCombo(ComboBox combo, string InsertaFila)
        {
            IList ListaLocalidades = GetAll();
            cod_localidades oLocalidad = new cod_localidades();
            oLocalidad.id_localidad = 0;
            oLocalidad.codigoPostal = "";
            oLocalidad.localidad= InsertaFila;
            ListaLocalidades.Insert(0, oLocalidad);
            combo.DisplayMember = "localidad";
            combo.ValueMember = "id_localidad";
            combo.DataSource = ListaLocalidades;
        }
    }
}
