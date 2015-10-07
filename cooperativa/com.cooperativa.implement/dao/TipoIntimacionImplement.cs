using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Windows.Forms;
using System.Collections;

namespace com.cooperativa.implement
{
    public class TipoIntimacionImplement
    {

        public  int Save(cod_intimaciones oTipoIntimacion)
        {
            int i;
            cooperativaEntities bd = new cooperativaEntities();
            bd.cod_intimaciones.AddObject(oTipoIntimacion);
            i = bd.SaveChanges();
            return i;
           
        }

        public void Update(cod_intimaciones oTipoIntimacion)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var editar = (from p in bd.cod_intimaciones
                              where p.id_intimacion ==oTipoIntimacion.id_intimacion
                              select p).Single();

                editar.id_intimacion = oTipoIntimacion.id_intimacion;
                editar.intimacion = oTipoIntimacion.intimacion;
                bd.SaveChanges();
            }
        }


        public List<cod_intimaciones> Buscar(string nombre)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var buscar = (from p in bd.cod_intimaciones
                              where p.intimacion.StartsWith(nombre)
                              select p).ToList();

                return buscar;
            }
        }

        public cod_intimaciones Get(int id)
        {
            cod_intimaciones oTipoIntimacion = new cod_intimaciones();
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.cod_intimaciones
                             where p.id_intimacion == id
                             select p).Single();
                oTipoIntimacion.id_intimacion = regis.id_intimacion;
                oTipoIntimacion.intimacion = regis.intimacion;
                return oTipoIntimacion;
            }
        }


        public List<cod_intimaciones> GetAll()
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var buscar = (from p in bd.cod_intimaciones
                              select p).ToList();
                return buscar;
            }
        }

        public void CargarCombo(ComboBox combo, string InsertaFila)
        {
            IList ListarIntimaciones = GetAll();
            cod_intimaciones oTipoIntimacion = new cod_intimaciones();
            oTipoIntimacion.id_intimacion = 0;
            oTipoIntimacion.intimacion = InsertaFila;

            ListarIntimaciones.Insert(0, oTipoIntimacion);
            combo.DisplayMember = "intimacion";
            combo.ValueMember = "id_intimacion";
            combo.DataSource = ListarIntimaciones;
        }
    }
}

