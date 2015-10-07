using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Windows.Forms;
using System.Collections;
using System.Data;
using MySql.Data.MySqlClient;
//using MySql.Data.MySqlClient;

namespace com.cooperativa.implement
{
    public class IntimacionImplement
    {

        public int Save(intimacion oIntimacion)
        {
            int i;
            cooperativaEntities bd = new cooperativaEntities();
            bd.intimacion.AddObject(oIntimacion);
            i = bd.SaveChanges();
            return i;
           
        }

        public void Update(intimacion oIntimacion)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var editar = (from p in bd.intimacion
                              where p.id_intimacion ==oIntimacion.id_intimacion
                              select p).Single();

                editar.fecha = oIntimacion.fecha;
                editar.id_intimacion = oIntimacion.id_intimacion;
                editar.id_socio = oIntimacion.id_socio;
                editar.tipo = oIntimacion.tipo;
                bd.SaveChanges();
            }
        }


        public intimacion Get(int id)
        {
            intimacion oIntimacion = new intimacion();
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.intimacion
                             where p.id_intimacion == id
                             select p).Single();
                oIntimacion.fecha = regis.fecha;
                oIntimacion.id_intimacion = regis.id_intimacion;
                oIntimacion.id_socio = regis.id_socio;
                oIntimacion.tipo = regis.tipo;
                return oIntimacion;
            }
        }


        public List<intimacion> GetAll()
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var buscar = (from p in bd.intimacion
                              select p).ToList();
                return buscar;
            }
        }

        public DataTable GetByidSocioDT(int idSocio)
        {


            try
            {
                DataTable DTIntimaciones = new DataTable();
                MySqlCommand _comando = new MySqlCommand(String.Format(
               " call intimacion_GetByIdSocio('{0}')", idSocio), dbConectorMySql.ObtenerConexion());

                //MySqlDataAdapter _da = new MySqlDataAdapter(_comando);
                //_da.Fill(DTIntimaciones);

                MySqlDataReader _reader = _comando.ExecuteReader();

                DTIntimaciones.Load(_reader);

                return DTIntimaciones;

            }
            catch (Exception)
            {
                return null;
            }
          
        }




        public List<intimacion> GetByidSocio(int idSocio)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var buscar = (from p in bd.intimacion
                              where p.id_socio == idSocio
                              orderby p.fecha
                              select p).ToList();
                return buscar;
            }
        }


        public intimacion GetByIdSocioUltimo(int idSocio)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var Listar = (from p in bd.intimacion
                              where p.id_socio == idSocio
                              orderby p.fecha 
                              select p).Last();
                return Listar;
            }
        }


    }
}

