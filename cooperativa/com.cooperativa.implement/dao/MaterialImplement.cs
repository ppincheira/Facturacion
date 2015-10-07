using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Windows.Forms;
using System.Collections;

namespace com.cooperativa.implement
{
    public class MaterialImplement
    {

        public  void Save(cod_materiales oMaterial)
        {

            cooperativaEntities bd = new cooperativaEntities();
            bd.cod_materiales.AddObject(oMaterial);
            bd.SaveChanges();
           
        }

        public void Update(cod_materiales oMaterial)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var editar = (from p in bd.cod_materiales
                              where p.id_material == oMaterial.id_material
                              select p).Single();

                editar.material = oMaterial.material;
                bd.SaveChanges();
            }
        }


        public List<cod_materiales> Buscar(string nombre)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var buscar = (from p in bd.cod_materiales
                              where p.material.StartsWith(nombre)
                              select p).ToList();

                return buscar;
            }
        }

        public cod_materiales Get(int id)
        {
            cod_materiales oMaterial = new cod_materiales();

            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.cod_materiales
                             where p.id_material == id
                             select p).Single();
                oMaterial.id_material = regis.id_material;
                oMaterial.material = regis.material;
                return oMaterial;
            }
        }


        public List<cod_materiales> GetAll()
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var Listar = (from p in bd.cod_materiales
                              select p).ToList();

                return Listar;
            }
        }


        public void CargarCombo(ComboBox combo, string InsertaFila)
        {
            IList ListaMateriales = GetAll();

            cod_materiales oMaterial = new cod_materiales();
            oMaterial.id_material = 0;
            oMaterial.material = InsertaFila;

            ListaMateriales.Insert(0, oMaterial);
            combo.DisplayMember = "material";
            combo.ValueMember = "id_material";
            combo.DataSource = ListaMateriales;
        }

    }
}

