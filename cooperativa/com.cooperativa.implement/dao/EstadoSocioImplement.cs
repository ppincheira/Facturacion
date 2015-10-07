using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Collections;
using System.Windows.Forms;

namespace com.cooperativa.implement
{
    public class EstadoSocioImplement
    {

        public  void Save(cod_estados_socios oEstadoSocio)
        {

            cooperativaEntities bd = new cooperativaEntities();
            bd.cod_estados_socios.AddObject(oEstadoSocio);
            bd.SaveChanges();
           
        }

        public void Update(cod_estados_socios oEstadoSocio)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var editar = (from p in bd.cod_estados_socios
                              where p.id_estado_socio == oEstadoSocio.id_estado_socio
                              select p).Single();

                editar.estado_socio = oEstadoSocio.estado_socio;
                editar.facturar = oEstadoSocio.facturar;
                editar.requiere_fin = oEstadoSocio.requiere_fin;
                editar.seleccionable = oEstadoSocio.seleccionable;
                editar.duracion_meses = oEstadoSocio.duracion_meses;
                bd.SaveChanges();
            }
        }


        public List<cod_estados_socios> Buscar(string nombre)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var buscar = (from p in bd.cod_estados_socios
                              where p.estado_socio.StartsWith(nombre)
                              select p).ToList();
                return buscar;
            }
        }

        public cod_estados_socios Get(int id)
        {
            cod_estados_socios oEstadoSocio = new cod_estados_socios();
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.cod_estados_socios
                             where p.id_estado_socio == id
                             select p).Single();
                oEstadoSocio.id_estado_socio = regis.id_estado_socio;
                oEstadoSocio.estado_socio = regis.estado_socio;
                oEstadoSocio.facturar = regis.facturar;
                oEstadoSocio.requiere_fin = regis.requiere_fin;
                oEstadoSocio.seleccionable = regis.seleccionable;
                oEstadoSocio.duracion_meses = regis.duracion_meses;
                return oEstadoSocio;
            }
        }

        public List<cod_estados_socios> GetBySeleccionable()
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var buscar = (from p in bd.cod_estados_socios
                              where p.seleccionable.Value
                              select p).ToList();
                return buscar;
            }
        }

        public List<cod_estados_socios> GetAll()
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var buscar = (from p in bd.cod_estados_socios
                              select p).ToList();
                return buscar;
            }
        }

        public void CargarCombo(ComboBox combo, string InsertaFila)
        {
            IList ListarEstadoSocios = GetBySeleccionable();
            cod_estados_socios oEstadoSocio = new cod_estados_socios();
            oEstadoSocio.id_estado_socio = 0;
            oEstadoSocio.facturar = false;
            oEstadoSocio.requiere_fin = false;
            oEstadoSocio.duracion_meses = 0;
            oEstadoSocio.seleccionable = false;
            oEstadoSocio.estado_socio = InsertaFila;
            ListarEstadoSocios.Insert(0, oEstadoSocio);
            combo.DisplayMember = "estado_socio";
            combo.ValueMember = "id_estado_socio";
            combo.DataSource = ListarEstadoSocios;
        }
    }
}
