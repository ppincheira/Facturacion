using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace com.cooperativa.implement.dao
{
    public class UsuariosImplement
    {
        public void Save(usuario oUsuario)
        {

            cooperativaEntities bd = new cooperativaEntities();
            bd.usuario.AddObject(oUsuario);
            bd.SaveChanges();

        }

        public void Update(usuario oUsuario)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var editar = (from p in bd.usuario
                              where p.id_usuario == oUsuario.id_usuario
                              select p).Single();
                editar.nombre = oUsuario.nombre;
                editar.login = oUsuario.login;
                editar.password = oUsuario.password;
                editar.modificarDatos = oUsuario.modificarDatos;
                editar.facturacion_anulacion = oUsuario.facturacion_anulacion;
                editar.impresion_reimpresion = oUsuario.impresion_reimpresion;
                editar.cobranza_cierreCaja = oUsuario.cobranza_cierreCaja;
                editar.listados_reportes = oUsuario.listados_reportes;
                editar.avisosDeuda_listadosCortes=oUsuario.avisosDeuda_listadosCortes;
                editar.reparar_optimizar_respaldo = oUsuario.reparar_optimizar_respaldo;
                editar.configurar = oUsuario.configurar;
                editar.administracion = oUsuario.administracion;
                editar.autorizarCobroSI = oUsuario.autorizarCobroSI;
                editar.autorizarConvenios = oUsuario.autorizarConvenios;
                editar.listados_padrones = oUsuario.listados_padrones;
                editar.judicial_codene = oUsuario.judicial_codene;
                editar.mantenimiento = oUsuario.mantenimiento;
                editar.activo = oUsuario.activo;
                bd.SaveChanges();
            }
        }

        public usuario Get(int id)
        {
            usuario oUsuario = new usuario();
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.usuario
                             where p.id_usuario == id
                             select p).Single();
                oUsuario.id_usuario = regis.id_usuario;
                oUsuario.nombre = regis.nombre;
                oUsuario.login = regis.login;
                oUsuario.password = regis.password;
                oUsuario.modificarDatos = regis.modificarDatos;
                oUsuario.facturacion_anulacion = regis.facturacion_anulacion;
                oUsuario.impresion_reimpresion = regis.impresion_reimpresion;
                oUsuario.cobranza_cierreCaja = regis.cobranza_cierreCaja;
                oUsuario.listados_reportes = regis.listados_reportes;
                oUsuario.avisosDeuda_listadosCortes = regis.avisosDeuda_listadosCortes;
                oUsuario.reparar_optimizar_respaldo = regis.reparar_optimizar_respaldo;
                oUsuario.configurar = regis.configurar;
                oUsuario.administracion = regis.administracion;
                oUsuario.autorizarCobroSI = regis.autorizarCobroSI;
                oUsuario.autorizarConvenios = regis.autorizarConvenios;
                oUsuario.listados_padrones = regis.listados_padrones;
                oUsuario.judicial_codene = regis.judicial_codene;
                oUsuario.mantenimiento = regis.mantenimiento;
                oUsuario.activo = oUsuario.activo;
                return oUsuario;
            }
        }


        public List<usuario> GetAll()
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var Listar = (from p in bd.usuario
                              select p).ToList();
                return Listar;
            }
        }

        public void CargarLista(ListBox lst)
        {
            IList ListarUsuarios = GetAll();
            lst.DisplayMember = "nombre";
            lst.ValueMember = "id_usuario";
            lst.DataSource = ListarUsuarios;
        }

        public bool ExisteUsuario(string _login)
        { 
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.usuario
                             where (p.login == _login) 

                             select p).ToList();
                return (regis.Count > 0);
            }
        }

        public usuario GetByUserName(string _login)
        {
            usuario oUsuario = new usuario();
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.usuario
                             where (p.login == _login)

                             select p).Single();
                oUsuario.id_usuario = regis.id_usuario;
                oUsuario.nombre = regis.nombre;
                oUsuario.login = regis.login;
                oUsuario.password = regis.password;
                oUsuario.modificarDatos = regis.modificarDatos;
                oUsuario.facturacion_anulacion = regis.facturacion_anulacion;
                oUsuario.impresion_reimpresion = regis.impresion_reimpresion;
                oUsuario.cobranza_cierreCaja = regis.cobranza_cierreCaja;
                oUsuario.listados_reportes = regis.listados_reportes;
                oUsuario.avisosDeuda_listadosCortes = regis.avisosDeuda_listadosCortes;
                oUsuario.reparar_optimizar_respaldo = regis.reparar_optimizar_respaldo;
                oUsuario.configurar = regis.configurar;
                oUsuario.administracion = regis.administracion;
                oUsuario.autorizarCobroSI = regis.autorizarCobroSI;
                oUsuario.autorizarConvenios = regis.autorizarConvenios;
                oUsuario.listados_padrones = regis.listados_padrones;
                oUsuario.judicial_codene = regis.judicial_codene;
                oUsuario.mantenimiento = regis.mantenimiento;
                oUsuario.activo = oUsuario.activo;
                return oUsuario;
            }
        }

        public bool EsValido(string usuario, string password)
        { 
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.usuario
                             where (p.login == usuario) && (p.password==password) 

                             select p).ToList();
                return (regis.Count > 0);
            }
        }
    }
}
