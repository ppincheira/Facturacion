using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Collections;
using System.Windows.Forms;

namespace com.cooperativa.implement
{
    public class ZonaImplement
    {


        public void Save(cod_zonas oZona)
        {

            cooperativaEntities bd = new cooperativaEntities();
            bd.cod_zonas.AddObject(oZona);
            bd.SaveChanges();

        }

        public void Update(cod_zonas oZona)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var editar = (from p in bd.cod_zonas
                              where p.id_zona == oZona.id_zona
                              select p).Single();

                editar.zona = oZona.zona;
                editar.imprimir = oZona.imprimir;
                bd.SaveChanges();
            }
        }


        public List<cod_zonas> Buscar(string nombre)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var buscar = (from p in bd.cod_zonas
                              where p.zona.StartsWith(nombre)
                              select p).ToList();

                return buscar;
            }
        }

        public cod_zonas Get(int id)
        {
            cod_zonas oZona = new cod_zonas();
            
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.cod_zonas
                             where p.id_zona == id
                             select p).Single();

                oZona.id_zona = regis.id_zona;
                oZona.zona = regis.zona;
                oZona.imprimir = regis.imprimir;
                return oZona;
            }
        }


        public List<cod_zonas> GetAll()
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var Listar = (from p in bd.cod_zonas
                              select p).ToList();

                return Listar;
            }
        }

        public void CargarCombo(ComboBox combo, string InsertaFila)
        {
            IList ListarZonas = GetAll();
            cod_zonas oZona = new cod_zonas();
            oZona.id_zona = 0;
            oZona.zona = InsertaFila;
            ListarZonas.Insert(0, oZona);

            combo.DisplayMember = "zona";
            combo.ValueMember = "id_zona";
            combo.DataSource = ListarZonas;
        }

    }
}
