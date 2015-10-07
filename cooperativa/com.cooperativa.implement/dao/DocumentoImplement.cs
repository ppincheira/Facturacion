using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Windows.Forms;
using System.Collections;
namespace com.cooperativa.implement
{
    public class DocumentoImplement
    {

        public  void Save(cod_documentos oDocumento)
        {

            cooperativaEntities bd = new cooperativaEntities();
            bd.cod_documentos.AddObject(oDocumento);
            bd.SaveChanges();
           
        }

        public void Update(cod_documentos oDocumento)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var editar = (from p in bd.cod_documentos
                              where p.id_documento == oDocumento.id_documento
                              select p).Single();

                editar.documento = oDocumento.documento;
                bd.SaveChanges();
            }
        }


        public List<cod_documentos> Buscar(string nombre)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var buscar = (from p in bd.cod_documentos
                              where p.documento.StartsWith(nombre)
                              select p).ToList();

                return buscar;
            }
        }

        public List<cod_documentos> GetAll()
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var listado = (from p in bd.cod_documentos
                              select p ).ToList();

                return listado;
            }
        }

        public void CargarCombo ( ref ComboBox combo,string InsertaFila){
            IList ListaDocumentos=GetAll();
            cod_documentos oDocumento=new cod_documentos();
            oDocumento.id_documento = 0;
            oDocumento.documento = InsertaFila;
            ListaDocumentos.Insert(0, oDocumento);
            combo.DataSource = ListaDocumentos;
            combo.DisplayMember = "documento";
            combo.ValueMember = "id_documento";
        }

        public void CargarCheckList(ref CheckedListBox combo, string InsertaFila)
        {
            IList ListaDocumentos = GetAll();
            cod_documentos oDocumento = new cod_documentos();
            //oDocumento.id_documento = 0;
            //oDocumento.documento = InsertaFila;
            //ListaDocumentos.Insert(0, oDocumento);
            combo.DataSource = ListaDocumentos;
            combo.DisplayMember = "documento";
            combo.ValueMember = "id_documento";
        }
        



        public cod_documentos Get(int id)
        {
            cod_documentos oDocumento = new cod_documentos();
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.cod_documentos
                             where p.id_documento == id
                             select p).Single();
                oDocumento.id_documento = regis.id_documento;
                oDocumento.documento = regis.documento;
                return oDocumento;
            }
        }



    }
}

