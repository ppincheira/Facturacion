using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Windows.Forms;
using System.Collections;
using System.Data;
using MySql.Data.MySqlClient;
using com.cooperativa.services;

namespace com.cooperativa.implement
{
    public class SocioImplement
    {

        public int Save(socios oSocio)
        {
            try
            {
                cooperativaEntities bd = new cooperativaEntities();
                bd.socios.AddObject(oSocio);
                bd.SaveChanges();
                return oSocio.id_socio;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(socios oSocio)
        {
            try
            {
                using (cooperativaEntities bd = new cooperativaEntities())
                {
                    var editar = (from p in bd.socios
                                  where p.id_socio == oSocio.id_socio
                                  select p).Single();
                    editar.codigo_socio = oSocio.codigo_socio;
                    editar.subcodigo_socio = oSocio.subcodigo_socio;
                    editar.nombre = oSocio.nombre;
                    editar.tipo_documento = oSocio.tipo_documento;
                    editar.documento = oSocio.documento;
                    editar.fecha_alta = oSocio.fecha_alta;
                    editar.estado = oSocio.estado;
                    editar.fin_estado = oSocio.fin_estado;
                    editar.tarifa = oSocio.tarifa;
                    editar.fin_tarifa = oSocio.fin_tarifa;
                    editar.iva = oSocio.iva;
                    editar.cuit = oSocio.cuit;
                    editar.categoria = oSocio.categoria;
                    editar.observaciones = oSocio.observaciones;
                    
                    bd.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<socios> Buscar(string nombre)
        {
            try{
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var buscar = (from p in bd.socios
                              where p.nombre.StartsWith(nombre)
                              select p).ToList();

                return buscar;
            }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public socios Get(int id)
        {
            try{
            socios oSocio = new socios();
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.socios
                             where p.id_socio == id
                             select p).Single();

                oSocio.id_socio = regis.id_socio;
                oSocio.codigo_socio = regis.codigo_socio;
                oSocio.subcodigo_socio = regis.subcodigo_socio;
                oSocio.nombre = regis.nombre;
                oSocio.tipo_documento = regis.tipo_documento;
                oSocio.documento = regis.documento;
                if (regis.fecha_alta != null)
                    oSocio.fecha_alta = regis.fecha_alta;
                else
                    oSocio.fecha_alta = DateTime.Parse("01/01/1900");
                oSocio.estado = regis.estado;
                oSocio.fin_estado = regis.fin_estado;
                oSocio.tarifa = regis.tarifa;
                oSocio.fin_tarifa = regis.fin_tarifa;
                oSocio.iva = regis.iva;
                oSocio.cuit = regis.cuit;
                oSocio.categoria = regis.categoria;
                oSocio.observaciones = regis.observaciones;
                return oSocio;
            }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



        public List<socios> GetAll()
        {
            try{
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var Listar = (from p in bd.socios
                              select p).ToList();

                return Listar;
            }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable CargarSocios()
        {

            try
            {
                string consulta;
                consulta = "select * from socios; ";
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

        public List<string> GetAllCustomer()
        {

            try
            {
                using (cooperativaEntities bd = new cooperativaEntities())
                {
                    var _Lista = from p in bd.socios
                                  orderby p.nombre
                                  select 

                                      p.nombre
                                  ;
                                  


                    return _Lista.ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int ObtenerIdSocioByFilter(string filtroBuscar)
        {
            int idSocio = 0;
           
            using (cooperativaEntities bd = new cooperativaEntities())
            {

                var cant = (from p in bd.socios
                             where (p.codigo_socio.Contains(filtroBuscar) || p.nombre.Contains(filtroBuscar))
                             select p).Count();

                if (cant > 0)
                {
                    var regis = (from p in bd.socios
                                 where (p.codigo_socio.Contains(filtroBuscar) || p.nombre.Contains(filtroBuscar))
                                 select p).First();

                    idSocio = regis.id_socio;
                }
            }
            return idSocio;
        }

        public DataTable GetAllCampos()
        {
            try
            {
                string consulta = "USE information_schema; " +
                " SELECT * FROM COLUMNS WHERE TABLE_SCHEMA = 'cooperativa' AND TABLE_NAME = 'socios' " +
                " union " +
                " SELECT * FROM COLUMNS WHERE TABLE_SCHEMA = 'cooperativa' AND TABLE_NAME = 'socios_lote' " +
                " union  " +
                " SELECT * FROM COLUMNS WHERE TABLE_SCHEMA = 'cooperativa' AND TABLE_NAME = 'socios_Conexion' " +
                " union " +
                " SELECT * FROM COLUMNS WHERE TABLE_SCHEMA = 'cooperativa' AND TABLE_NAME = 'socios_varios';" +
                " USE cooperativa;";

                DataTable dt = new DataTable();
                string query = consulta;
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


        // Retorna una DT de Socios 
        public DataTable SocioGetByFilter()
        {

            try
            {
                using (cooperativaEntities bd = new cooperativaEntities())
                {

                    var Listar = (from s in bd.socios
                                  join sc in bd.socios_conexion on s.id_socio equals sc.id_Socio
                                  join ces in bd.cod_estados_socios on s.estado equals ces.id_estado_socio
                                  join ci in bd.cod_impuestos on s.iva equals ci.id_impuesto
                                  join t in bd.tarifas on s.tarifa equals t.id_tarifa
                                  where ces.facturar == true


                                  select new
                                  {
                                      s.id_socio,
                                      s.nombre,
                                      sc.medidor,
                                      t.cargo_fijo,
                                      t.abono,
                                      t.valor_m3

                                  }
                                  ).ToList();

                    Commons oCommons = new Commons();
                    return oCommons.convertToTable(Listar);
                }

            }
            catch (Exception)
            {
                return null;
            }
        }


      
        public string ObtenerCampo(int campo) {
            string rtdo="";
            switch (campo)
            {
                case 1:
                    rtdo =  "s.codigo_socio";
                    break;
                case 2:
                    rtdo =  "s.subcodigo_socio";
                    break;
                case 3:
                    rtdo =  "s.nombre";
                    break;
                case 4:
                    rtdo =  "s.documento";
                    break;
                case 5:
                    rtdo =  "sc.zona";
                    break;
                case 6:
                    rtdo =  "sl.manzana";
                    break;
                case 7:
                    rtdo =  "sl.lote";
                    break;
                case 8:
                    rtdo =  "sc.calle";
                    break;
                case 9:
                    rtdo =  " sc.calle_altura";
                    break;
                case 10:
                    rtdo =  "sl.ruta_reparto";
                    break;
                case 11:
                    rtdo =  "sl.orden_reparto";
                    break;
                case 12:
                    rtdo =  "sl.nomenclatura";
                    break;
                case 13:
                    rtdo =  "sc.medidor";
                    break;
                case 14:
                    rtdo =  "s.cuit";
                    break;
                case 15:
                     rtdo =  "s.observaciones";
                    break;
            }
            return rtdo;
        
        }
        public DataTable SocioGetAllByOrder(int accion, int campo, string texto )
        {
            try
            {
                string consulta;
                consulta = " select s.id_socio, s.codigo_socio, s.subcodigo_socio, s.nombre, "+
                " s.documento,sc.barrio, sc.zona, "+
                " sl.manzana, sl.lote,sc.calle, "+
                " sc.calle_altura, sl.ruta_reparto,sl.orden_reparto, "+
                " sl.nomenclatura,sc.medidor,s.cuit,s.observaciones from socios s "+
                " inner join socios_conexion sc on s.id_socio=sc.id_Socio "+
                " inner join socios_lote sl on s.id_socio=sl.id_Socio "+
                " inner join cod_estados_socios ces on s.estado=ces.id_estado_socio "+ 
                " inner join cod_impuestos ci on s.iva=ci.id_impuesto "+
                " inner join tarifas t on s.tarifa=t.id_tarifa "+
                " where ces.facturar =true ";
                switch (accion)
                {
                    case 1:
                        consulta = consulta + " and " + ObtenerCampo(campo) + " like '%" + texto + "%'";
                        break;
                    case 2:
                        consulta = consulta + " and " + ObtenerCampo(campo) + " like '" + texto + "%'";
                        
                        break;
                    default:
                        consulta = consulta + " and " + ObtenerCampo(campo) + " like '%" + texto + "'";
                        break;
                }
                consulta = consulta + " order by " + ObtenerCampo(campo);

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


        public DataTable SociosGetByFilters(string IVAs, string Categorias, string EstadosConexion, string SituacionEspecial, string Tarifas, string ZonaFacturacion,
            string CodigoSocio, string SubCodigoSocio,  string Nombre, string Documento, string Cuit, string Fecha, string Barrios, string Calles, string Provincias,
            string BarriosLegal, string CallesLegal, string Localidad, string Entidades, string DistElectoral, string Numero, string CodigoPostal, string NumeroLegal,
            string Nomenclatura, string Manzana, string Lote, string NroMedidor)
        {
            try
            {
                string consulta;

                consulta = " select s.id_socio, s.codigo_socio, s.subcodigo_socio, s.nombre, " +
                " s.documento,sc.barrio, sc.zona, " +
                " sl.manzana, sl.lote,sc.calle, " +
                " sc.calle_altura, sl.ruta_reparto,sl.orden_reparto, " +
                " sl.nomenclatura,sc.medidor,s.cuit,s.observaciones from socios s " +
                " inner join socios_conexion sc on s.id_socio=sc.id_Socio " +
                " inner join socios_lote sl on s.id_socio=sl.id_Socio " +
                " inner join cod_estados_socios ces on s.estado=ces.id_estado_socio " +
                " inner join cod_impuestos ci on s.iva=ci.id_impuesto " +
                " inner join tarifas t on s.tarifa=t.id_tarifa " +
                " inner join socios_varios sv on sv.id_socio= s.id_socio " +
                " left join cod_situacion_especial sp on sp.id_situacion_especial = sv.situacion_especial " +
                " inner join cod_zonas cz on cz.id_zona = sc.zona " +
                " inner join cod_categorias cc on cc.id_categoria = s.categoria " +
                " inner join cod_barrios cb on cb.id_barrio = sc.barrio " + 
                " left join cod_barrios cb2 on cb2.id_barrio = sl.barrio " +
                " left join cod_calles ccl on ccl.id_calle = sc.calle " +
                " left join cod_calles ccl2 on ccl2.id_calle= sl.calle " +
                " left join cod_provincias p on p.id_provincia = sl.provincia " +
                " left join cod_localidades cl on cl.id_localidad = sl.localidad " + 
               // " inner join cod_prestadores cp on cp.id_prestador = "
                " where s.id_socio>0 ";

                #region <<Datos Varios>>
                if (IVAs.Length > 0)
                {
                    IVAs = IVAs.Substring(0, IVAs.Length - 1);
                    consulta = consulta + " and ci.impuesto in (" + IVAs + ") ";
                }

                if (Categorias.Length > 0)
                {
                    Categorias = Categorias.Substring(0, Categorias.Length - 1);
                    consulta = consulta + " and cc.categoria in (" + Categorias + ") ";
                }
                if (EstadosConexion.Length > 0)
                {
                    EstadosConexion = EstadosConexion.Substring(0, EstadosConexion.Length - 1);
                    consulta = consulta + " and ces.estado_socio in (" + EstadosConexion + ") ";
                }
                if (SituacionEspecial.Length > 0)
                {
                    SituacionEspecial = SituacionEspecial.Substring(0, SituacionEspecial.Length - 1);
                    consulta = consulta + " and sp.situacion_especial in (" + SituacionEspecial + ") ";
                }
                if (Tarifas.Length > 0)
                {
                    Tarifas = Tarifas.Substring(0, Tarifas.Length - 1);
                    consulta = consulta + " and t.tarifa in (" + Tarifas + ") ";
                }
                if (ZonaFacturacion.Length > 0)
                {
                    ZonaFacturacion = ZonaFacturacion.Substring(0, ZonaFacturacion.Length - 1);
                    consulta = consulta + " and cz.zona in (" + ZonaFacturacion + ") ";
                }
                if (CodigoSocio.Trim().Length > 0)
                {
                    consulta = consulta + " and s.codigo_socio LIKE '%" + CodigoSocio + "%' ";
                }
                if (SubCodigoSocio.Length > 0)
                {
                    consulta = consulta + " and s.subcodigo_socio LIKE '%" + SubCodigoSocio + "%' ";
                }
                if (Nombre.Length > 0)
                {
                    consulta = consulta + " and s.NOMBRE LIKE '%" + Nombre + "%' ";
                }
                if (Documento.Length > 0)
                {
                    consulta = consulta + " and s.documento LIKE '%" + Documento + "%' ";
                }
                if (Cuit.Replace("-", "").Trim().Length > 0)
                {
                    consulta = consulta + " and s.cuit LIKE '%" + Cuit + "%' ";
                }
                //if (Fecha.Length > 0)
                //{
                //    consulta = consulta + " and s.fecha_alta='" + DateTime.Parse(Fecha).ToUniversalTime() + "' ";
                //}

                #endregion 

                #region <<Datos Varios>>
                if (DistElectoral.Length > 0)
                {
                    consulta = consulta + " and sc.distrito_electoral like '%" + DistElectoral + "%'";
                }

                if (Numero.Length > 0)
                {
                    consulta = consulta + " and sc.calle_altura like '%" + Numero + "%'";
                }

                if (Barrios.Length > 0)
                {
                    Barrios = Barrios.Substring(0, Barrios.Length - 1);
                    consulta = consulta + " and sc.barrio in (" + Barrios + ") ";
                }
                if (Calles.Length > 0)
                {
                    Calles = Calles.Substring(0, Calles.Length - 1);
                    consulta = consulta + " and sc.calle in (" + Calles + ") ";
                }
                if (BarriosLegal.Length > 0)
                {
                    BarriosLegal = BarriosLegal.Substring(0, BarriosLegal.Length - 1);
                    consulta = consulta + " and sl.barrio in (" + BarriosLegal + ") ";
                }
                if (CallesLegal.Length > 0)
                {
                    CallesLegal = CallesLegal.Substring(0, CallesLegal.Length - 1);
                    consulta = consulta + " and sl.calle in (" + CallesLegal + ") ";
                }
                if (Provincias.Length > 0)
                {
                    Provincias = Provincias.Substring(0, Provincias.Length - 1);
                    consulta = consulta + " and sl.provincia in (" + Provincias + ") ";
                }
                if (Localidad.Length > 0)
                {
                    Localidad = Localidad.Substring(0, Localidad.Length - 1);
                    consulta = consulta + " and sl.localidad in (" + Localidad + ") ";
                }

                if (CodigoPostal.Length > 0)
                {
                    consulta = consulta + " and sl.cp like '%" + CodigoPostal + "%'";
                }

                if (NumeroLegal.Length > 0)
                {
                    consulta = consulta + " and sl.calle_altura like '%" + NumeroLegal + "%'";
                }

                if (Nomenclatura.Replace("-", "").Trim().Length > 0)
                {
                    consulta = consulta + " and sl.nomenclatura LIKE '%" + Nomenclatura + "%' ";
                }
                if (Manzana.Length > 0)
                {
                    consulta = consulta + " and sl.manzana LIKE '%" + Manzana + "%' ";
                }
                if (Lote.Length > 0)
                {
                    consulta = consulta + " and sl.lote LIKE '%" + Lote + "%' ";
                }
                if (NroMedidor.Length > 0)
                {
                    consulta = consulta + " and sc.medidor LIKE '%" + NroMedidor + "%' ";
                }
                #endregion

                #region <<Datos Catastral>>

                #endregion

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

