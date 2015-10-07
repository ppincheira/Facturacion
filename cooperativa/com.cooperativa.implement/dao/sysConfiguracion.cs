
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
    public class SysConfigImplement
    {

        public  void Save(sys_configuracion oSysConfig)
        {

            cooperativaEntities bd = new cooperativaEntities();
            bd.sys_configuracion.AddObject(oSysConfig);
            bd.SaveChanges();
           
        }

        public void Update(sys_configuracion oSysConfig)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var editar = (from p in bd.sys_configuracion
                              where p.id_configuracion == oSysConfig.id_configuracion
                              select p).Single();

                editar.nombre = oSysConfig.nombre;
                editar.observacion = oSysConfig.observacion;
                editar.valor = oSysConfig.valor;
                bd.SaveChanges();
            }
        }


        public List<sys_configuracion> Buscar(string nombre)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var buscar = (from p in bd.sys_configuracion
                              where p.nombre.StartsWith(nombre)
                              select p).ToList();

                return buscar;
            }
        }


        public sys_configuracion Get(int id)
        {
            sys_configuracion oSysConfig = new sys_configuracion();

            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.sys_configuracion
                             where p.id_configuracion == id
                             select p).Single();

                oSysConfig.id_configuracion = regis.id_configuracion;
                oSysConfig.nombre = regis.nombre;
                oSysConfig.observacion = regis.observacion;
                oSysConfig.valor = regis.valor;

                return oSysConfig;
            }
        }
        public sys_configuracion GetByNombre(string nombre)
        {
            sys_configuracion oSysConfig = new sys_configuracion();
            
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.sys_configuracion
                             where p.nombre == nombre
                             select p).Single();

                oSysConfig.id_configuracion = regis.id_configuracion;
                oSysConfig.nombre = regis.nombre;
                oSysConfig.observacion = regis.observacion;
                oSysConfig.valor = regis.valor;

                return oSysConfig;
            }
        }

        public DataTable GetEncabezadoDT(string nombre)
        {

            try
            {

                using (cooperativaEntities bd = new cooperativaEntities())
                {
                    var Listar = (from p in bd.sys_configuracion
                                  where p.nombre.Contains(nombre)
                                  select p).ToList();
                    //Creo el Data Table
                    DataTable tabla = new DataTable();
                    tabla.Columns.Add("Linea1");
                    tabla.Columns.Add("Linea2");
                    tabla.Columns.Add("Linea3");
                    DataRow row = tabla.NewRow();
                    int i = 1;
                    foreach(sys_configuracion prop in Listar) {
                       
                        row["Linea"+i.ToString()] = prop.valor;
                        i++;
                    }
                    tabla.Rows.Add(row);
                    return tabla;
                }

            }
            catch (Exception)
            {
                return null;
            }


        }
    }
}
