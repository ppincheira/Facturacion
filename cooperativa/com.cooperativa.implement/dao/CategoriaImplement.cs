using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Collections;
using System.Windows.Forms;
using com.cooperativa.implement;
using com.cooperativa.services;
using System.Data;

namespace com.cooperativa.implement
{
    public class CategoriaImplement
    {

        public  void Save(cod_categorias oCategoria)
        {

            cooperativaEntities bd = new cooperativaEntities();
            bd.cod_categorias.AddObject(oCategoria);
            bd.SaveChanges();
           
        }

        public void Update(cod_categorias oCategoria)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var editar = (from p in bd.cod_categorias
                              where p.id_categoria == oCategoria.id_categoria
                              select p).Single();

                editar.categoria = oCategoria.categoria;
                bd.SaveChanges();
            }
        }


        public List<cod_categorias> Buscar(string nombre)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var buscar = (from p in bd.cod_categorias
                              where p.categoria.StartsWith(nombre)
                              select p).ToList();

                return buscar;
            }
        }

        public List<cod_categorias> GetAll()
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var listar = (from p in bd.cod_categorias
                              select p).ToList();

                return listar;
            }
        }

        public cod_categorias Get(int id)
        {
            cod_categorias oCategoria = new cod_categorias();

            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.cod_categorias
                             where p.id_categoria == id
                             select p).Single();
                oCategoria.id_categoria = regis.id_categoria;
                oCategoria.categoria = regis.categoria;
                return oCategoria;
            }
        }


        public void Delete(int id)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.cod_categorias
                             where p.id_categoria == id
                             select p).Single();

                bd.DeleteObject(regis);
                bd.SaveChanges();
            }
        }

        public void CargarCombo(ref ComboBox combo, string InsertaFila)
        {
            IList ListaCategorias = GetAll();
            
            cod_categorias oCategoria = new cod_categorias();
            oCategoria.id_categoria = 0;
            oCategoria.categoria = InsertaFila;
            ListaCategorias.Insert(0, oCategoria);
            combo.DisplayMember = "categoria";
            combo.ValueMember = "id_categoria";
            combo.DataSource = ListaCategorias;
            
        }

        public DataTable GetByCategoriaDT(string categoria)
        {
            try
            {
                using (cooperativaEntities bd = new cooperativaEntities())
                {
                    var Listar = (from p in bd.cod_categorias
                                  where p.categoria.StartsWith(categoria)
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

