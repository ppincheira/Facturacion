using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Windows.Forms;
using System.Collections;

namespace com.cooperativa.implement
{
    public class EstadoPJImplement
    {

        public  void Save(cod_estados_pj oEstadosPJ)
        {
 
            cooperativaEntities bd = new cooperativaEntities();
            bd.cod_estados_pj.AddObject(oEstadosPJ);
            bd.SaveChanges();
           
        }

        public void Update(cod_estados_pj oEstadosPJ)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var editar = (from p in bd.cod_estados_pj
                              where p.id_cod_estado_pj == oEstadosPJ.id_cod_estado_pj
                              select p).Single();

                editar.descripcion = oEstadosPJ.descripcion;
                bd.SaveChanges();
            }
        }


        public List<cod_estados_pj> Buscar(string nombre)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var buscar = (from p in bd.cod_estados_pj
                              where p.descripcion.StartsWith(nombre)
                              select p).ToList();

                return buscar;
            }
        }

        public cod_estados_pj Get(int id)
        {
            cod_estados_pj oEstadoPJ = new cod_estados_pj();
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.cod_estados_pj
                             where p.id_cod_estado_pj == id
                             select p).Single();
                oEstadoPJ.id_cod_estado_pj = regis.id_cod_estado_pj;
                oEstadoPJ.descripcion= regis.descripcion;
                return oEstadoPJ;
            }
        }


        public List<cod_estados_pj> GetAll()
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var buscar = (from p in bd.cod_estados_pj
                              select p).ToList();
                return buscar;
            }
        }

        public void CargarCombo(ComboBox combo, string InsertaFila)
        {
            IList ListaEstados = GetAll();
            cod_estados_pj oEstadosPJ = new cod_estados_pj();
            oEstadosPJ.id_cod_estado_pj = 0;
            oEstadosPJ.descripcion = InsertaFila;
            ListaEstados.Insert(0, oEstadosPJ);
            combo.DisplayMember = "descripcion";
            combo.ValueMember = "id_cod_estado_pj";
            combo.DataSource = ListaEstados;
        }
    }
}
