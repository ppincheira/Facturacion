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
    public class TarifaImplement
    {
        public void Save(tarifas oTarifa)
        {

            cooperativaEntities bd = new cooperativaEntities();
            bd.tarifas.AddObject(oTarifa);
            bd.SaveChanges();
           
        }

        public void Update(tarifas oTarifa)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var editar = (from p in bd.tarifas
                              where p.id_tarifa == oTarifa.id_tarifa
                              select p).Single();

                editar.tarifa = oTarifa.tarifa;
                editar.abreviatura = oTarifa.abreviatura;
                editar.cargo_fijo = oTarifa.cargo_fijo;
                editar.valor_m3 = oTarifa.valor_m3;
                editar.abono = oTarifa.abono;
                editar.usuario_residencial = oTarifa.usuario_residencial;
                editar.bonificacion = oTarifa.bonificacion;
                editar.recargo_minimo = oTarifa.recargo_minimo;
                editar.requiere_fin = oTarifa.requiere_fin;
                editar.meses_venc = oTarifa.meses_venc;
                editar.activa = oTarifa.activa;
                bd.SaveChanges();
            }
        }

        public void Delete(int idTarifa)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.tarifas
                             where p.id_tarifa == idTarifa
                             select p).Single();

                bd.DeleteObject(regis);
                bd.SaveChanges();
            }
        }

        public List<tarifas> Buscar(string nombre)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var buscar = (from p in bd.tarifas
                              where p.tarifa.StartsWith(nombre)
                              select p).ToList();

                return buscar;
            }
        }

        public tarifas Get(int id)
        {           
            try
            {
                tarifas oTarifa = new tarifas();
                using (cooperativaEntities bd = new cooperativaEntities())
                {
                    var regis = (from p in bd.tarifas
                                 where p.id_tarifa == id
                                 select p).Single();

                    oTarifa.id_tarifa = regis.id_tarifa;
                    oTarifa.tarifa = regis.tarifa;
                    oTarifa.abreviatura = regis.abreviatura;
                    oTarifa.cargo_fijo = regis.cargo_fijo;
                    oTarifa.valor_m3 = regis.valor_m3;
                    oTarifa.abono = regis.abono;
                    oTarifa.usuario_residencial = regis.usuario_residencial;
                    oTarifa.bonificacion = regis.bonificacion;
                    oTarifa.recargo_minimo = regis.recargo_minimo;
                    oTarifa.requiere_fin = regis.requiere_fin;
                    oTarifa.meses_venc = regis.meses_venc;
                    oTarifa.activa = regis.activa;

                    return oTarifa;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

       
        public List<tarifas> GetAll()
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var buscar = (from p in bd.tarifas
                              select p).ToList();

                return buscar;
            }
        }

        public void CargarCombo(ComboBox combo, string InsertaFila)
        {
            IList ListarTarifas = GetAll();
            tarifas oTarifa = new tarifas();
            oTarifa.id_tarifa = 0;
            oTarifa.tarifa = InsertaFila;
            
            ListarTarifas.Insert(0, oTarifa);

            combo.DisplayMember = "tarifa";
            combo.ValueMember = "id_tarifa";
            combo.DataSource = ListarTarifas;
        }

        public DataTable GetByTarifaDT(string Tarifa)
        {
            try
            {
                using (cooperativaEntities bd = new cooperativaEntities())
                {
                    var Listar = (from p in bd.tarifas
                                  where p.tarifa.StartsWith(Tarifa)
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

