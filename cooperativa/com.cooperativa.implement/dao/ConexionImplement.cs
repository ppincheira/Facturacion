using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Windows.Forms;
using System.Collections;

namespace com.cooperativa.implement
{
    public class ConexionImplement
    {

        public  void Save(cod_conexiones oConexion)
        {

            cooperativaEntities bd = new cooperativaEntities();
            bd.cod_conexiones.AddObject(oConexion);
            bd.SaveChanges();
           
        }

        public void Update(cod_conexiones oConexion)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var editar = (from p in bd.cod_conexiones
                              where p.id_conexion == oConexion.id_conexion
                              select p).Single();

                editar.conexion = oConexion.conexion;
                bd.SaveChanges();
            }
        }


        public List<cod_conexiones> Buscar(string nombre)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var buscar = (from p in bd.cod_conexiones
                              where p.conexion.StartsWith(nombre)
                              select p).ToList();

                return buscar;
            }
        }

        public cod_conexiones Get(int id)
        {
            cod_conexiones oConexion = new cod_conexiones();
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.cod_conexiones
                             where p.id_conexion == id
                             select p).Single();
                oConexion.id_conexion = regis.id_conexion;
                oConexion.conexion = regis.conexion;
                return oConexion;
            }
        }
        public List<cod_conexiones> GetAll()
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var buscar = (from p in bd.cod_conexiones
                              select p).ToList();

                return buscar;
            }
        }

        public void CargarCombo(ComboBox combo, string InsertaFila)
        {
            IList ListarConexiones = GetAll();
            cod_conexiones oConexion = new cod_conexiones();
            oConexion.id_conexion = 0;
            oConexion.conexion= InsertaFila;
            ListarConexiones.Insert(0, oConexion);
            combo.DisplayMember = "conexion";
            combo.ValueMember = "id_conexion";
            combo.DataSource = ListarConexiones;
        }
    }
}
