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
    public class ProvinciaImplement
    {
        public void Save(cod_provincias oProvincia)
        {

            cooperativaEntities bd = new cooperativaEntities();
            bd.cod_provincias.AddObject(oProvincia);
            bd.SaveChanges();

        }

        public void Update(cod_provincias oProvincia)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var editar = (from p in bd.cod_provincias
                              where p.id_provincia == oProvincia.id_provincia
                              select p).Single();
                editar.id_provincia = oProvincia.id_provincia;
                editar.provincia = oProvincia.provincia;
                bd.SaveChanges();
            }
        }


        public List<cod_provincias> Buscar(string nombre)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var buscar = (from p in bd.cod_provincias
                              where p.provincia.StartsWith(nombre)
                              select p).ToList();

                return buscar;
            }
        }



        public cod_provincias Get(int id)
        {
            cod_provincias oProvincia = new cod_provincias();

            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.cod_provincias
                             where p.id_provincia == id
                             select p).Single();

                oProvincia.id_provincia = regis.id_provincia;
                oProvincia.provincia = regis.provincia;

                return oProvincia;
            }
        }

        public List<cod_provincias> GetAll()
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var buscar = (from p in bd.cod_provincias
                              select p).ToList();

                return buscar;
            }
        }

        public void CargarCombo(ComboBox combo, string InsertaFila)
        {
            IList ListarProvincias = GetAll();
            cod_provincias oProvincia = new cod_provincias();
            oProvincia.id_provincia = 0;
            oProvincia.provincia = InsertaFila;

            ListarProvincias.Insert(0, oProvincia);
            combo.DisplayMember = "provincia";
            combo.ValueMember = "id_provincia";
            combo.DataSource = ListarProvincias;
        }

        public DataTable GetByProvinciaDT(string Provincia)
        {
            try
            {
                using (cooperativaEntities bd = new cooperativaEntities())
                {
                    var Listar = (from p in bd.cod_provincias
                                  where p.provincia.StartsWith(Provincia)
                                  select p).ToList();
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
