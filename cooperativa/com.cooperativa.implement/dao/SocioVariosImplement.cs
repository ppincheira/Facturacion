using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Windows.Forms;
using System.Collections;

namespace com.cooperativa.implement
{
    public class SocioVariosImplement
    {

        public  int Save(socios_varios oSocioVarios)
        {
            int i;
            cooperativaEntities bd = new cooperativaEntities();
            bd.socios_varios.AddObject(oSocioVarios);
            i=bd.SaveChanges();
            return i;
        }

        public void Update(socios_varios oSocioVarios)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var editar = (from p in bd.socios_varios
                              where p.id_socio == oSocioVarios.id_socio
                              select p).Single();
                editar.id_socio = oSocioVarios.id_socio;
                editar.profesion = oSocioVarios.profesion;
                editar.conyuge_nombre = oSocioVarios.conyuge_nombre;
                editar.conyuge_tipo_documento = oSocioVarios.conyuge_tipo_documento;
                editar.conyuge_documento = oSocioVarios.conyuge_documento;
                editar.id_coop_luz = oSocioVarios.id_coop_luz;
                editar.fecha_convenio_coop_luz = oSocioVarios.fecha_convenio_coop_luz;
                editar.situacion_especial = oSocioVarios.situacion_especial;
                editar.intimado = oSocioVarios.intimado;
               
                bd.SaveChanges();
            }
        }



        public socios_varios Get(int id)
        {
            socios_varios oSocioVarios = new socios_varios();

            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.socios_varios
                             where p.id_socio == id
                             select p).Single();
                oSocioVarios.id_socio = regis.id_socio;
                oSocioVarios.profesion = (regis.profesion == null) ? "" : regis.profesion;
                oSocioVarios.conyuge_nombre = (regis.conyuge_nombre == null) ? "" : regis.conyuge_nombre;
                oSocioVarios.conyuge_tipo_documento = (regis.conyuge_tipo_documento == null) ? 0 : regis.conyuge_tipo_documento;
                oSocioVarios.conyuge_documento = (regis.conyuge_documento==null)?0:regis.conyuge_documento;
                oSocioVarios.id_coop_luz = (regis.id_coop_luz == null) ? "" : regis.id_coop_luz;
                oSocioVarios.fecha_convenio_coop_luz = (regis.fecha_convenio_coop_luz==null)?"":regis.fecha_convenio_coop_luz;
                oSocioVarios.situacion_especial = (regis.situacion_especial == null) ? 0 : regis.situacion_especial;
                
                return oSocioVarios;
            }

        }


        public List<socios_varios> GetAll()
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var Listar = (from p in bd.socios_varios
                              select p).ToList();

                return Listar;
            }
        }


       

    }
}

