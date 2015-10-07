using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace com.cooperativa.implement.dao
{
    public class TerminalesImplement
    {
        public void Save(seg_terminales oseg_terminales)
        {

            cooperativaEntities bd = new cooperativaEntities();
            bd.seg_terminales.AddObject(oseg_terminales);
            bd.SaveChanges();

        }

        public void Update(seg_terminales oseg_terminales)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var editar = (from p in bd.seg_terminales
                              where p.id_terminal == oseg_terminales.id_terminal
                              select p).Single();
                editar.terminal = oseg_terminales.terminal;
                editar.habilitada = oseg_terminales.habilitada;
                editar.bloqueada = oseg_terminales.bloqueada;
                editar.intento_nro = oseg_terminales.intento_nro;
                editar.fecha_bloqueo = oseg_terminales.fecha_bloqueo;
                bd.SaveChanges();
            }
        }

        public seg_terminales Get(int id)
        {
            seg_terminales oseg_terminales = new seg_terminales();
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.seg_terminales
                             where p.id_terminal == id
                             select p).Single();
                oseg_terminales.id_terminal = regis.id_terminal;
                oseg_terminales.terminal = regis.terminal;
                oseg_terminales.habilitada = regis.habilitada;
                oseg_terminales.bloqueada = regis.bloqueada;
                oseg_terminales.intento_nro = regis.intento_nro;
                oseg_terminales.fecha_bloqueo = regis.fecha_bloqueo;
                return oseg_terminales;
            }
        }


        public List<seg_terminales> GetAll()
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var Listar = (from p in bd.seg_terminales
                              select p).ToList();
                return Listar;
            }
        }

        public void CargarLista(ListBox lst)
        {
            IList ListarTerminales = GetAll();
            lst.DisplayMember = "terminal";
            lst.ValueMember = "id_terminal";
            lst.DataSource = ListarTerminales;
        }

        public void Delete(int idTerminal)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.seg_terminales
                             where p.id_terminal == idTerminal
                             select p).Single();

                bd.DeleteObject(regis);
                bd.SaveChanges();

            }
        }
    }
}
