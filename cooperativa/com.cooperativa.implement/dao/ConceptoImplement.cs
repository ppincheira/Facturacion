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
    public class ConceptoImplement
    {


        public void Save(cod_conceptos oConcepto)
        {
            
            cooperativaEntities bd = new cooperativaEntities();
            bd.cod_conceptos.AddObject(oConcepto);
            bd.SaveChanges();

        }

        public void Update(cod_conceptos oConcepto)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                //var editar = (from p in bd.cod_conceptos
                //              where p.id_concepto == oConcepto.id_concepto
                //              select p).Single();

                //editar.id_formula = oConcepto.id_formula;
                //editar.concepto = oConcepto.concepto;
                //editar.orden_concepto = oConcepto.orden_concepto;
                //editar.activo = oConcepto.activo;
                //editar.id_formula = oConcepto.id_formula;
                //editar.variable = oConcepto.variable;
                //editar.tipo_signo = oConcepto.tipo_signo;
                //editar.concepto_particular = oConcepto.concepto_particular;
                //editar.aplicar_iva = oConcepto.aplicar_iva;
                //editar.aplicar_recargo = oConcepto.aplicar_recargo;
                //editar.aplicar_descuento = oConcepto.aplicar_descuento; 
                //bd.SaveChanges();
            }
        }


        public List<cod_conceptos> Buscar(string nombre)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var buscar = (from p in bd.cod_conceptos
                              where p.concepto.StartsWith(nombre)
                              select p).ToList();

                return buscar;
            }
        }

        public cod_conceptos Get(int id)
        {
            cod_conceptos oConcepto = new cod_conceptos();
            try
            {
                using (cooperativaEntities bd = new cooperativaEntities())
                {
                    var regis = (from p in bd.cod_conceptos
                                 where p.id_concepto == id
                                 select p).Single();
                    oConcepto.id_concepto = regis.id_concepto;
                    oConcepto.concepto = regis.concepto;
                    oConcepto.orden_concepto = regis.orden_concepto;
                    oConcepto.activo = regis.activo;
                    oConcepto.id_formula = regis.id_formula;
                    oConcepto.variable = regis.variable;
                    oConcepto.tipo_signo = regis.tipo_signo;
                    oConcepto.aplicacion = regis.aplicacion;
                    oConcepto.concepto_particular = regis.concepto_particular;
                    oConcepto.aplicar_iva = regis.aplicar_iva;
                    oConcepto.aplicar_recargo = regis.aplicar_recargo;
                    oConcepto.aplicar_descuento = regis.aplicar_descuento;

                    return oConcepto;
                }
            }
            catch (Exception ex)
            {
                return oConcepto;
            }
        }       


        public List<cod_conceptos> GetActivosAll()
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var Listar = (from p in bd.cod_conceptos
                              where p.activo.Value & p.aplicacion!=2
                              select p).ToList();

                return Listar;
            }
        }

        public List<cod_conceptos> GetAll()
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var Listar = (from p in bd.cod_conceptos
                              where p.activo.Value
                              select p).ToList();

                return Listar;
            }
        }



        public DataTable GetAllDT()
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var Listar = (from p in bd.cod_conceptos
                              where p.activo.Value
                              select new 
                              {
                                p.id_concepto,
                                p.concepto,
                                p.variable
                              }).ToList();

                Commons oCommons = new Commons();
                return oCommons.convertToTable(Listar);
            }
        }

        public void CargarCombo(ComboBox combo, string InsertaFila)
        {
            IList ListarConceptos = GetAll();
            cod_conceptos oConcepto = new cod_conceptos();

            oConcepto.id_concepto = 0;
            oConcepto.concepto = InsertaFila;
            ListarConceptos.Insert(0, oConcepto);
            combo.DisplayMember = "concepto";
            combo.ValueMember = "id_concepto";
            combo.DataSource = ListarConceptos;
        }

        public void CargarCheckListBox( CheckedListBox CheckList )
        {
            IList ListarConceptos = GetAll();
            ((ListBox)CheckList).DataSource = ListarConceptos;
            ((ListBox)CheckList).DisplayMember = "concepto";
            ((ListBox)CheckList).ValueMember = "id_concepto";
            
        }

    }
}
