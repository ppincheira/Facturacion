using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Windows.Forms;
using System.Collections;

namespace com.cooperativa.implement
{
    public class PrestadorImplement
    {

        public  void Save(cod_prestador oPrestador)
        {
 
            cooperativaEntities bd = new cooperativaEntities();
            bd.cod_prestador.AddObject(oPrestador);
            bd.SaveChanges();
           
        }

        public void Update(cod_prestador oPrestador)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var editar = (from p in bd.cod_prestador
                              where p.id_prestador == oPrestador.id_prestador
                              select p).Single();

                editar.prestador = oPrestador.prestador;
                bd.SaveChanges();
            }
        }


        public List<cod_prestador> Buscar(string nombre)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var buscar = (from p in bd.cod_prestador
                              where p.prestador.StartsWith(nombre)
                              select p).ToList();

                return buscar;
            }
        }

        public cod_prestador Get(int id)
        {
            cod_prestador oPrestador = new cod_prestador();
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.cod_prestador
                             where p.id_prestador == id
                             select p).Single();
                oPrestador.id_prestador = regis.id_prestador;
                oPrestador.prestador = regis.prestador;
                return oPrestador;
            }
        }


        public List<cod_prestador> GetAll()
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var Listar = (from p in bd.cod_prestador
                              select p).ToList();
                return Listar;
            }
        }

        public void CargarCombo(ComboBox combo, string InsertaFila)
        {
            IList ListaPrestador = GetAll();
            cod_prestador oPrestador = new cod_prestador();
            oPrestador.id_prestador = 0;
            oPrestador.prestador = InsertaFila;
            ListaPrestador.Insert(0, oPrestador);
            combo.DisplayMember = "prestador";
            combo.ValueMember = "id_prestador";
            combo.DataSource = ListaPrestador;
        }
    }
}
