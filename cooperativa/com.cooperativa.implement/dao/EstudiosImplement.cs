using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Windows.Forms;
using System.Collections;

namespace com.cooperativa.implement
{
    public class EstudioImplement
    {

        public  void Save(cod_estudios oEstudio)
        {
 
            cooperativaEntities bd = new cooperativaEntities();
            bd.cod_estudios.AddObject(oEstudio);
            bd.SaveChanges();
           
        }

        public void Update(cod_estudios oEstudio)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var editar = (from p in bd.cod_estudios
                              where p.id_estudio == oEstudio.id_estudio
                              select p).Single();
                editar.telefono = oEstudio.telefono;
                editar.contacto = oEstudio.contacto;
                editar.descripcion = oEstudio.descripcion;
                editar.direccion = oEstudio.direccion;
                bd.SaveChanges();
            }
        }


        public List<cod_estudios> Buscar(string nombre)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var buscar = (from p in bd.cod_estudios
                              where p.descripcion.StartsWith(nombre)
                              select p).ToList();

                return buscar;
            }
        }

        public cod_estudios Get(int id)
        {
            cod_estudios oEstudio = new cod_estudios();
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.cod_estudios
                             where p.id_estudio == id
                             select p).Single();
                oEstudio.id_estudio = regis.id_estudio;
                oEstudio.contacto = regis.contacto;
                oEstudio.descripcion = regis.descripcion;
                oEstudio.direccion = regis.direccion;
                oEstudio.telefono = regis.telefono;
                return oEstudio;
            }
        }


        public List<cod_estudios> GetAll()
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var Listar = (from p in bd.cod_estudios
                              select p).ToList();
                return Listar;
            }
        }

        public void CargarCombo(ComboBox combo, string InsertaFila)
        {
            IList ListarEstudio = GetAll();
            cod_estudios oEstudio = new cod_estudios();
            oEstudio.id_estudio = 0;
            oEstudio.descripcion = InsertaFila;
            ListarEstudio.Insert(0, oEstudio);
            combo.DisplayMember = "descripcion";
            combo.ValueMember = "id_estudio";
            combo.DataSource = ListarEstudio;
        }
    }
}
