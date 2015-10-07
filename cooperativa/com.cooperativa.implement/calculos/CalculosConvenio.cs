using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace com.cooperativa.implement
{
    public class CalculosConvenio
    {
        public Decimal ObtenerImporteConvenioAdeudado(int idSocio)
        {
            Decimal Importe = 0;
            ConvenioImplement oConvenioImplement = new ConvenioImplement();
            DataTable dtConveniosBySocio = oConvenioImplement.GetConveniosBySocioDT(idSocio);
            foreach(DataRow dr in dtConveniosBySocio.Rows)
            {
                if (dr["finalizado"].ToString()=="No")
                { 
                    Importe = Importe + 
                        (decimal.Parse(dr["importe_total"].ToString()) - 
                        (decimal.Parse(dr["valor_cuota"].ToString()) * decimal.Parse(dr["facturadas"].ToString())));
                }
            }
            return Importe;
        }

    }
}
