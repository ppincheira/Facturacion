using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data;
using com.cooperativa.services;
using MySql.Data.MySqlClient;

namespace com.cooperativa.implement.dao
{
    public class PeriodosImplement
    {

        public void Save(periodos oPeriodo)
        {

            cooperativaEntities bd = new cooperativaEntities();
            bd.periodos.AddObject(oPeriodo);
            bd.SaveChanges();

        }

        public periodos Get(string id)
        {
            periodos oPeriodo = new periodos();
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.periodos
                             where p.id_periodo == id
                             select p).Single();
                oPeriodo.id_periodo = regis.id_periodo;
                oPeriodo.fecha_facturacion = regis.fecha_facturacion;
                oPeriodo.fecha_primer_venc = regis.fecha_primer_venc;
                oPeriodo.fecha_segundo_venc = regis.fecha_segundo_venc;
                oPeriodo.fecha_tercer_venc = regis.fecha_tercer_venc;
                oPeriodo.facturado = regis.facturado;
                return oPeriodo;
            }
        }

        public List<periodos> GetAll()
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                    var listar = (from p in bd.periodos
                                  orderby p.id_periodo descending
                                  select p).ToList();

                    return listar;
            }
        }

        public DataTable GetAllDT()
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var listar = (from p in bd.periodos
                              orderby p.id_periodo descending
                              select new
                              {
                                  p.id_periodo,
                                  periodo = p.id_periodo.Substring(4, 5) + "/" + p.id_periodo.Substring(0, 4)
                              }).ToList();

                Commons oCommons = new Commons();
                return oCommons.convertToTable(listar);
            }
        }

        public string GetUltimoPeriodo()
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                int count = 0;
                count = (from p in bd.periodos
                         orderby p.id_periodo descending
                         select p.id_periodo).Count();
                string result = "";
                
                if (count > 0)
                {
                    var listar = (from p in bd.periodos
                              orderby p.id_periodo descending
                              select p.id_periodo);
                    result = listar.First();
                }
                return result;
            }
        }

        public void CargarCombo(ref ComboBox combo, string InsertaFila)
        {
            DataTable ListaDocumentos = GetAllDT();
            periodos oPeriodos = new periodos();

            combo.DataSource = ListaDocumentos;
            combo.DisplayMember = "periodo";
            combo.ValueMember = "id_periodo";
        }

        public void CargarComboUltimosPeriodos(ref ComboBox combo, string InsertaFila)
        {
            DataTable ListaDocumentos = GetUltimosPeriodos();
            combo.DataSource = ListaDocumentos;
            combo.DisplayMember = "id_periodo";
            combo.ValueMember = "id_periodo";
        }

        public DataTable GetAnios()
        {
            DataTable dt = new DataTable();
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var listar = (from p in bd.periodos
                              orderby p.id_periodo descending
                              select new
                              {
                                  periodo = p.id_periodo.Substring(0, 4)
                              }).ToList().Distinct().ToList();

                Commons oCommons = new Commons();
                return oCommons.convertToTable(listar);
            }
        }



        public DataTable GetUltimosPeriodos()
        {

            try
            {
                string consulta;
                consulta = "CALL periodos_GetUltimosPeriodos()";
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
