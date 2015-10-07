using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using com.cooperativa.services;

namespace com.cooperativa.implement.dao
{
    public class CajasImplement
    {
        public void Save(cod_cajas oCaja)
        {

            cooperativaEntities bd = new cooperativaEntities();
            bd.cod_cajas.AddObject(oCaja);
            bd.SaveChanges();

        }

        public void Update(cod_cajas oCaja)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var editar = (from p in bd.cod_cajas
                              where p.id_caja == oCaja.id_caja
                              select p).Single();

                editar.caja = oCaja.caja;
                editar.fecha_cobro_distinta = oCaja.fecha_cobro_distinta;
                editar.caja_activa = oCaja.caja_activa;
                editar.cobro_manual = oCaja.cobro_manual;
                bd.SaveChanges();
            }
        }

        public void Delete(int idCaja)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.cod_cajas
                             where p.id_caja == idCaja
                             select p).Single();

                bd.DeleteObject(regis);
                bd.SaveChanges();
            }
        }

        public List<cod_cajas> Buscar(string nombre)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var buscar = (from p in bd.cod_cajas
                              where p.caja.StartsWith(nombre)
                              select p).ToList();

                return buscar;
            }
        }

        public cod_cajas Get(int id)
        {
            cod_cajas oCaja = new cod_cajas();
            try
            {
                using (cooperativaEntities bd = new cooperativaEntities())
                {
                    var regis = (from p in bd.cod_cajas
                                 where p.id_caja == id
                                 select p).Single();

                    oCaja.id_caja = regis.id_caja;
                    oCaja.caja = regis.caja;
                    oCaja.fecha_cobro_distinta = regis.fecha_cobro_distinta;
                    oCaja.caja_activa = regis.caja_activa;
                    oCaja.cobro_manual = regis.cobro_manual;

                    return oCaja;
                }

            }
            catch (Exception ex)
            {
                return oCaja;
            }
        }

        public List<cod_cajas> GetAll()
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var buscar = (from p in bd.cod_cajas
                              select p).ToList();
                return buscar;
            }
        }


        public List<cod_cajas> GetAllActivas()
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var buscar = (from p in bd.cod_cajas
                              where p.caja_activa==true
                              select p).ToList();
                return buscar;
            }
        }

        public List<cod_cajas> GetAllByConvenio()
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var buscar = (from p in bd.cod_cajas
                              where p.id_caja==4 | p.id_caja==5 | p.id_caja==6 | p.id_caja==7
                              select p).ToList();
                return buscar;
            }
        }

        public void CargarCombo(ref ComboBox combo, string InsertaFila)
        {
            IList ListaCajas = GetAll();
            cod_cajas oCaja = new cod_cajas();
            oCaja.id_caja = 0;
            oCaja.caja = InsertaFila;
            ListaCajas.Insert(0, oCaja);
            combo.DisplayMember = "caja";
            combo.ValueMember = "id_caja";
            combo.DataSource = ListaCajas;
        }

        public void CargarComboConvenio(ref ComboBox combo, string InsertaFila)
        {
            IList ListaCajas = GetAllByConvenio();
            cod_cajas oCaja = new cod_cajas();
            oCaja.id_caja = 0;
            oCaja.caja = InsertaFila;
            ListaCajas.Insert(0, oCaja);
            combo.DisplayMember = "caja";
            combo.ValueMember = "id_caja";
            combo.DataSource = ListaCajas;
        }

    }
}
