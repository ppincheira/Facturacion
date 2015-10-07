using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.cooperativa.implement
{
    public class EstadosPagoImplement
    {
        public cod_estados_pago Get(int id)
        {
            cod_estados_pago oEstado = new cod_estados_pago();
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.cod_estados_pago
                             where p.id_estado_pago == id
                             select p).Single();
                oEstado.id_estado_pago = regis.id_estado_pago;
                oEstado.estado_pago = regis.estado_pago;
                return oEstado;
            }
        }
    }
}
