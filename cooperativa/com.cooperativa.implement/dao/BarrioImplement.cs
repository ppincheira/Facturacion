using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Windows.Forms;
using System.Collections;
using System.Data;
using com.cooperativa.services;
using MySql.Data.MySqlClient;

namespace com.cooperativa.implement
{
    public class BarrioImplement
    {
        public void Save(cod_barrios oBarrio)
        {

            cooperativaEntities bd = new cooperativaEntities();
            bd.cod_barrios.AddObject(oBarrio);
            bd.SaveChanges();

        }

        public void Update(cod_barrios oBarrio)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var editar = (from p in bd.cod_barrios
                              where p.id_barrio == oBarrio.id_barrio
                              select p).Single();

                editar.barrio = oBarrio.barrio;
                bd.SaveChanges();
            }
        }
      
        public void Delete(int idBarrio)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.cod_barrios
                             where p.id_barrio == idBarrio
                             select p).Single();

                bd.DeleteObject(regis);
                bd.SaveChanges();
            }
        }

        public List<cod_barrios> Buscar(string nombre)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var buscar = (from p in bd.cod_barrios
                              where p.barrio.StartsWith(nombre)
                              select p).ToList();

                return buscar;
            }
        }

        public cod_barrios Get(int id)
        {
            cod_barrios oBarrio = new cod_barrios();
            try
            {
                using (cooperativaEntities bd = new cooperativaEntities())
                {
                    var regis = (from p in bd.cod_barrios
                                 where p.id_barrio == id
                                 select p).Single();

                    oBarrio.id_barrio = regis.id_barrio;
                    oBarrio.barrio = regis.barrio;

                    return oBarrio;
                }
            }
            catch (Exception ex)
            {
                return oBarrio;
            }
        }

        public List<cod_barrios> GetAll()
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var buscar = (from p in bd.cod_barrios
                              select p).ToList();
                return buscar;
            }
        }

        public void CargarCombo(ComboBox combo, string InsertaFila)
        {
            IList ListaBarrios = GetAll();
            cod_barrios oBarrio = new cod_barrios();
            oBarrio.id_barrio = 0;
            oBarrio.barrio = InsertaFila;
            ListaBarrios.Insert(0, oBarrio);
            combo.DisplayMember = "barrio";
            combo.ValueMember = "id_barrio";
            combo.DataSource = ListaBarrios;
        }

        public void CargarComboRutas(ComboBox combo, int idBarrio)
        {
            
            

            combo.DisplayMember = "ruta";
            combo.ValueMember = "ruta";
            combo.DataSource = GetRutasByIdBarrio(idBarrio);
        }

        public DataTable GetByBarrioDT(string Barrio)
        {
            try
            {
                using (cooperativaEntities bd = new cooperativaEntities())
                {
                    var Listar = (from p in bd.cod_barrios
                                  where p.barrio.StartsWith(Barrio)
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
        public DataTable GetRutasByIdBarrio(int idBarrio)
        {

            try
            {
                string consulta;
                consulta = "CALL Socios_lote_GetRutasByIdBarrio(" + idBarrio.ToString() +")";
                DataTable dt = new DataTable();
                string query;
                query = consulta;
                MySqlCommand cmd = new MySqlCommand(query, dbConectorMySql.ObtenerConexion());
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                adap.Fill(dt);
                return dt;

            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
