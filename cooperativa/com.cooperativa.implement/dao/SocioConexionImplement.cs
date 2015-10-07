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
    public class SocioConexionImplement
    {

        public  int Save(socios_conexion oSocioConexion)
        {
            try
            {
                int i;
                cooperativaEntities bd = new cooperativaEntities();
                bd.socios_conexion.AddObject(oSocioConexion);
                i = bd.SaveChanges();
                return i;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(socios_conexion oSocioConexion)
        {
            try{
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var editar = (from p in bd.socios_conexion 
                              where p.id_Socio == oSocioConexion.id_Socio
                              select p).Single();
                editar.id_Socio = oSocioConexion.id_Socio;
                editar.ubicacion_servicio = oSocioConexion.ubicacion_servicio;
                editar.medianera = oSocioConexion.medianera;
                editar.tipo_conexion = oSocioConexion.tipo_conexion;
                editar.distancia_a_red = oSocioConexion.distancia_a_red;
                editar.profundidad_red = oSocioConexion.profundidad_red;
                editar.tipo_material = oSocioConexion.tipo_material;
                editar.diametro_red = oSocioConexion.diametro_red;
                editar.medidor = oSocioConexion.medidor;
                editar.marca_medidor = oSocioConexion.marca_medidor;
                editar.barrio = oSocioConexion.barrio;
                editar.calle = oSocioConexion.calle;
                editar.calle_altura = oSocioConexion.calle_altura;
                editar.piso = oSocioConexion.piso;
                editar.dpto = oSocioConexion.dpto;
                editar.distrito_electoral = oSocioConexion.distrito_electoral;
                editar.zona = oSocioConexion.zona;
                editar.adic_domicilio = oSocioConexion.adic_domicilio;
                
                bd.SaveChanges();
            }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public socios_conexion Get(int id)
        {
            try{
            socios_conexion oSocioConexion = new socios_conexion();
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.socios_conexion
                             where p.id_Socio == id
                             select p).Single();
                oSocioConexion.id_Socio = regis.id_Socio;
                oSocioConexion.ubicacion_servicio = (regis.ubicacion_servicio == null) ? 0 : regis.ubicacion_servicio;
                oSocioConexion.medianera = (regis.medianera == null) ? 0 : regis.medianera;
                oSocioConexion.tipo_conexion = (regis.tipo_conexion == null) ? 0 : regis.tipo_conexion;
                oSocioConexion.distancia_a_red = (regis.distancia_a_red == null) ? 0 : regis.distancia_a_red;
                oSocioConexion.profundidad_red = (regis.profundidad_red == null) ? 0 : regis.profundidad_red;
                oSocioConexion.tipo_material = (regis.tipo_material == null) ? 0 : regis.tipo_material;
                oSocioConexion.diametro_red = (regis.diametro_red == null) ? 0 : regis.diametro_red;
                oSocioConexion.medidor = (regis.medidor == null) ? "" : regis.medidor;
                oSocioConexion.marca_medidor = (regis.marca_medidor == null) ? "" : regis.marca_medidor;
                oSocioConexion.barrio = (regis.barrio == null) ? 0 : regis.barrio;
                oSocioConexion.calle = (regis.calle == null) ? 0 : regis.calle;
                oSocioConexion.calle_altura=(regis.calle_altura==null)?"":regis.calle_altura;
                oSocioConexion.piso = (regis.piso == null) ? "" : regis.piso;
                oSocioConexion.dpto = (regis.dpto == null) ? "" : regis.dpto;
                if (regis.distrito_electoral != null) oSocioConexion.distrito_electoral = regis.distrito_electoral;
                oSocioConexion.zona = (regis.zona == null) ? 0 : regis.zona;
                oSocioConexion.adic_domicilio = (regis.adic_domicilio == null) ? "" : regis.adic_domicilio;
                return oSocioConexion;
            }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public string ChequeaInformacionFaltante(int idSocio) {
            try{
            string msj="";
            socios_conexion oSocioConexion = new socios_conexion();
            oSocioConexion = Get(idSocio);
            if (oSocioConexion.calle_altura == "") msj = msj + "Falta ingresar la Altura " + System.Environment.NewLine;
            
            return msj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<socios_conexion> GetAll()
        {
            try{
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var Listar = (from p in bd.socios_conexion
                              select p).ToList();

                return Listar;
            }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Retorna una DT de Socios con los medidores no cargados
        public DataTable GetEstadosMedidores()
        {

            try
            {
                using (cooperativaEntities bd = new cooperativaEntities())
                {

                    var Listar = (from s in bd.socios
                                  join sc in bd.socios_conexion on s.id_socio equals sc.id_Socio
                                  join sm in bd.socios_mediciones on s.id_socio equals sm.id_socio
                                  join ces in bd.cod_estados_socios on s.estado equals ces.id_estado_socio
                                  where (sc.medidor != "") && ces.facturar == true && sm.lectura == 0
                                  select new
                                  {
                                      s.id_socio,
                                      s.nombre,
                                      sm.lectura

                                  }).ToList();

                    Commons oCommons = new Commons();
                    return oCommons.convertToTable(Listar);
                }

            }
            catch (Exception)
            {
                return null;
            }
        }

        // Retorna una DT de Socios con los medidores no cargados
        //public DataTable GetSociosAFacturar ( string periodo)
        //{

        //    try
        //    {
        //        using (cooperativaEntities bd = new cooperativaEntities())
        //        {

        //            var Listar = (from s in bd.socios
        //                          join sc in bd.socios_conexion on s.id_socio equals sc.id_Socio
        //                          join ces in bd.cod_estados_socios on s.estado equals ces.id_estado_socio
        //                          join ci in bd.cod_impuestos on s.iva equals ci.id_impuesto
        //                          join t in bd.tarifas on s.tarifa equals t.id_tarifa
        //                          where ces.facturar == true && (p.id_periodo == periodo)


        //                          select new
        //                          {
        //                              s.id_socio,
        //                              s.nombre,
        //                              sc.medidor,
        //                              t.cargo_fijo,
        //                              t.abono,
        //                              t.valor_m3,
        //                              s.iva
                                      
        //                          }
        //                          ).ToList();

        //            Commons oCommons = new Commons();
        //            return oCommons.convertToTable(Listar);
        //        }

        //    }
        //    catch (Exception)
        //    {
        //        return null;
        //    }
        //}
    public DataTable GetSociosAFacturar ( string periodo)
    {
    try
    {
        string consulta;
        consulta = "select "+
        "   s.id_socio, "+
"	s.nombre, "+
"	sc.medidor, "+
"	t.cargo_fijo, "+
"	t.abono, "+
"	t.valor_m3, "+
"	s.iva "+
" from socios s "+
" inner join cod_estados_socios ces on ces.id_estado_socio=s.estado "+
" inner join socios_conexion sc on sc.id_socio=s.id_socio "+
" inner join cod_impuestos ci on ci.id_impuesto=s.iva "+
" inner join tarifas t on t.id_tarifa=s.tarifa "+
" where s.id_socio not in "+
" (select s2.id_Socio from socios s2 "+
" inner join facturas f on s2.id_socio=f.id_socio " +
" and f.id_periodo='"+periodo+"') and ces.facturar=1";

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

    public DataTable GetSociosAFacturar(string periodo, int idSocio)
    {
        try
        {
            string consulta;
            consulta = "select " +
            "   s.id_socio, " +
    "	s.nombre, " +
    "	sc.medidor, " +
    "	t.cargo_fijo, " +
    "	t.abono, " +
    "	t.valor_m3, " +
    "	s.iva " +
    " from socios s " +
    " inner join cod_estados_socios ces on ces.id_estado_socio=s.estado " +
    " inner join socios_conexion sc on sc.id_socio=s.id_socio " +
    " inner join cod_impuestos ci on ci.id_impuesto=s.iva " +
    " inner join tarifas t on t.id_tarifa=s.tarifa " +
    " where s.id_socio not in " +
    " (select s2.id_Socio from socios s2 " +
    " inner join facturas f on s2.id_socio=f.id_socio " +
    " and f.id_periodo='" + periodo + "') and ces.facturar=1 and s.id_socio=" + idSocio.ToString() ;

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

