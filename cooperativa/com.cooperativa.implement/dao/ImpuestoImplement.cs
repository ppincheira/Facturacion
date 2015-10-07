using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Windows.Forms;
using System.Collections;

namespace com.cooperativa.implement
{
    public class ImpuestoImplement
    {

        public  void Save(cod_impuestos oImpuesto)
        {

            cooperativaEntities bd = new cooperativaEntities();
            bd.cod_impuestos.AddObject(oImpuesto);
            bd.SaveChanges();
           
        }

        public void Update(cod_impuestos oImpuesto)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var editar = (from p in bd.cod_impuestos
                              where p.id_impuesto ==oImpuesto.id_impuesto
                              select p).Single();

                editar.impuesto = oImpuesto.impuesto;
                editar.porcentaje = oImpuesto.porcentaje;
                editar.vigencia_desde = oImpuesto.vigencia_desde;
                editar.vigencia_hasta = oImpuesto.vigencia_hasta;
                editar.credito_fiscal = oImpuesto.credito_fiscal;
                editar.activo = oImpuesto.activo;
                bd.SaveChanges();
            }
        }


        public List<cod_impuestos> Buscar(string nombre)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var buscar = (from p in bd.cod_impuestos
                              where p.impuesto.StartsWith(nombre)
                              select p).ToList();

                return buscar;
            }
        }

        public cod_impuestos Get(int id)
        {
            cod_impuestos oImpuesto = new cod_impuestos();
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.cod_impuestos
                             where p.id_impuesto == id
                             select p).Single();
                oImpuesto.id_impuesto = regis.id_impuesto;
                oImpuesto.impuesto = regis.impuesto;
                oImpuesto.porcentaje = regis.porcentaje;
                oImpuesto.vigencia_desde = regis.vigencia_desde;
                oImpuesto.vigencia_hasta = regis.vigencia_hasta;
                oImpuesto.credito_fiscal = regis.credito_fiscal;
                oImpuesto.activo = regis.activo;
                return oImpuesto;
            }
        }


        public List<cod_impuestos> GetAll()
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var buscar = (from p in bd.cod_impuestos
                              select p).ToList();
                return buscar;
            }
        }

        public void CargarCombo(ComboBox combo, string InsertaFila)
        {
            IList ListarImpuestos = GetAll();
            cod_impuestos oImpuesto = new cod_impuestos();
            oImpuesto.id_impuesto = 0;
            oImpuesto.impuesto = InsertaFila;
            oImpuesto.porcentaje = 0;
            oImpuesto.vigencia_desde = DateTime.Now;
            oImpuesto.vigencia_hasta = DateTime.Now;
            oImpuesto.credito_fiscal = false;
            oImpuesto.activo = false;
            ListarImpuestos.Insert(0, oImpuesto);
            combo.DisplayMember = "impuesto";
            combo.ValueMember = "id_impuesto";
            combo.DataSource = ListarImpuestos;
        }
    }
}

