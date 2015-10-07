using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Windows.Forms;
using System.Collections;

namespace com.cooperativa.implement
{
    public class SocioLoteImplement
    {

        public  int Save(socios_lote oSocioLote)
        {
            int i;
            cooperativaEntities bd = new cooperativaEntities();
            bd.socios_lote.AddObject(oSocioLote);
            i=bd.SaveChanges();
            return oSocioLote.id_Socio;
        }

        public void Update(socios_lote oSocioLote)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var editar = (from p in bd.socios_lote 
                              where p.id_Socio == oSocioLote.id_Socio
                              select p).Single();
                editar.id_Socio = oSocioLote.id_Socio;
                editar.barrio=oSocioLote.barrio;
                editar.manzana = oSocioLote.manzana = editar.manzana;
                editar.lote = oSocioLote.lote;
                editar.calle = oSocioLote.calle;
                editar.calle_altura=oSocioLote.calle_altura;
                editar.piso = oSocioLote.piso;
                editar.dpto = oSocioLote.dpto;
                editar.nomenclatura = oSocioLote.nomenclatura;
                editar.ruta_reparto = oSocioLote.ruta_reparto;
                editar.orden_reparto = oSocioLote.orden_reparto;
                editar.cp=oSocioLote.cp;
                editar.localidad = oSocioLote.localidad;
                editar.provincia = oSocioLote.provincia;
                editar.adic_domicilio = oSocioLote.adic_domicilio;
                
                bd.SaveChanges();
            }
        }



        public socios_lote Get(int id)
        {
            socios_lote oSocioLote = new socios_lote();

            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.socios_lote
                             where p.id_Socio == id
                             select p).Single();

                oSocioLote.id_Socio = (regis.id_Socio == null) ? 0 : regis.id_Socio;
                oSocioLote.barrio = (regis.barrio==null)?0:regis.barrio;
                oSocioLote.manzana = (regis.manzana == null) ? "" : regis.manzana;
                oSocioLote.lote = (regis.lote == null) ? "" : regis.lote;
                oSocioLote.calle = (regis.calle == null) ? 0 : regis.calle;
                oSocioLote.calle_altura = (regis.calle_altura==null)?"":regis.calle_altura;
                oSocioLote.piso = (regis.piso == null) ? "" : regis.piso;
                oSocioLote.dpto = (regis.dpto == null) ? "" : regis.dpto;
                oSocioLote.nomenclatura = (regis.nomenclatura == null) ? "" : regis.nomenclatura;
                oSocioLote.ruta_reparto = (regis.ruta_reparto == null) ? 0 : regis.ruta_reparto;
                oSocioLote.orden_reparto = (regis.orden_reparto == null) ? 0 : regis.orden_reparto;
                oSocioLote.cp = (regis.cp==null)?"":regis.cp;
                oSocioLote.localidad = (regis.localidad == null) ? 0 : regis.localidad;
                oSocioLote.provincia = (regis.provincia == null) ? 0 : regis.provincia;
                oSocioLote.adic_domicilio = (regis.adic_domicilio == null) ? "" : regis.adic_domicilio;
                return oSocioLote;
            }

        }

        public List<socios_lote> GetAll()
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var Listar = (from p in bd.socios_lote
                              select p).ToList();

                return Listar;
            }
        }


       

    }
}

