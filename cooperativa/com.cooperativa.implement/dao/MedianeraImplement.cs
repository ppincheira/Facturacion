using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Windows.Forms;
using System.Collections;

namespace com.cooperativa.implement
{
    public class MedianeraImplement
    {


        public void Save(cod_medianeras oMedianera)
        {

            cooperativaEntities bd = new cooperativaEntities();
            bd.cod_medianeras.AddObject(oMedianera);
            bd.SaveChanges();
        }

        public void Update(cod_medianeras oMedianera)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var editar = (from p in bd.cod_medianeras
                              where p.id_medianera == oMedianera.id_medianera
                              select p).Single();

                editar.id_medianera = oMedianera.id_medianera;
                editar.medianera = oMedianera.medianera;
                bd.SaveChanges();
            }
        }


        public List<cod_medianeras> Buscar(string nombre)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var buscar = (from p in bd.cod_medianeras
                              where p.medianera.StartsWith(nombre)
                              select p).ToList();

                return buscar;
            }
        }

        public List<cod_medianeras> GetAll()
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var listar = (from p in bd.cod_medianeras
                              select p).ToList();

                return listar;
            }
        }
        public cod_medianeras Get(int id)
        {
            cod_medianeras oMedianera = new cod_medianeras();
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.cod_medianeras
                             where p.id_medianera == id
                             select p).Single();
                oMedianera.id_medianera = regis.id_medianera;
                oMedianera.medianera = regis.medianera;
                return oMedianera;
            }
        }

        public void CargarCombo(ComboBox combo, string InsertaFila)
        {
            IList ListaMedianeras = GetAll();
            cod_medianeras oMedianera = new cod_medianeras();
            oMedianera.id_medianera= 0;
            oMedianera.medianera = InsertaFila;
            ListaMedianeras.Insert(0, oMedianera);
            combo.DisplayMember = "medianera";
            combo.ValueMember = "id_medianera";
            combo.DataSource = ListaMedianeras;
        }

    }
}
