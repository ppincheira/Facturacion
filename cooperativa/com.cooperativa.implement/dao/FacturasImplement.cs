
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Windows.Forms;
using System.Collections;
using System.Data;
using MySql.Data.MySqlClient;
using com.cooperativa.services;

namespace com.cooperativa.implement
{
    public class FacturasImplement
    {

        public int Save(facturas oFactura)
        {

            cooperativaEntities bd = new cooperativaEntities();
            bd.facturas.AddObject(oFactura);
            bd.SaveChanges();
            return oFactura.id_factura;
        }

        public void Update(facturas oFactura)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var editar = (from p in bd.facturas
                              where p.id_factura == oFactura.id_factura
                              select p).Single();

                editar.id_periodo = oFactura.id_periodo;
                editar.id_socio = oFactura.id_socio;
                editar.id_medicion = oFactura.id_medicion;
                editar.id_estadoPago = oFactura.id_estadoPago;
                editar.id_tarifa = oFactura.id_tarifa;
                editar.id_convenio = oFactura.id_convenio;
                editar.fechaPago = oFactura.fechaPago;
                editar.cobrado = oFactura.cobrado;
                editar.neto1 = oFactura.neto1;
                editar.neto2 = oFactura.neto2;
                editar.importeNeto = oFactura.importeNeto;
                editar.importeTotal = oFactura.importeTotal;
                bd.SaveChanges();
            }
        }

        public facturas Get(int id)
        {
            facturas oFactura = new facturas();
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.facturas
                             where p.id_factura == id
                             select p).Single();
                oFactura.id_factura = regis.id_factura;
                oFactura.id_periodo = regis.id_periodo;
                oFactura.id_socio = regis.id_socio;
                oFactura.id_medicion = regis.id_medicion;
                oFactura.id_estadoPago = regis.id_estadoPago;
                oFactura.id_tarifa = regis.id_tarifa;
                oFactura.id_convenio = regis.id_convenio;
                oFactura.fechaPago = regis.fechaPago;
                oFactura.cobrado = regis.cobrado;
                oFactura.neto1 = regis.neto1;
                oFactura.neto2 = regis.neto2;
                oFactura.importeNeto = regis.importeNeto;
                oFactura.importeTotal = regis.importeTotal;
                return oFactura;
            }
        }

        public DataTable GetFacturasCuerpoDT(int idSocio)
        { 
            try
            {
                using (cooperativaEntities bd = new cooperativaEntities())
                {
                    var listar = (from f in bd.facturas
                                 where f.id_socio == idSocio
                                 select f).ToList();
                    Commons oCommons = new Commons();
                    return oCommons.convertToTable(listar);
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable GetByIdSocioDT(int idSocio, int mostrarImpagas, int mostrarValoresActualizados)
        {
            try
            {
                int controlImpagas = 0;
                if (mostrarImpagas == 1)
                {
                    controlImpagas = 3;
                }

                DataTable FacturasDetalles = new DataTable();
                MySqlCommand _comando = new MySqlCommand(String.Format(
               " call facturas_GetByIdSocio('{0}', '{1}')", idSocio, controlImpagas), dbConectorMySql.ObtenerConexion());

                //MySqlDataAdapter _da = new MySqlDataAdapter(_comando);
                //_da.Fill(DTIntimaciones);

                MySqlDataReader _reader = _comando.ExecuteReader();

                FacturasDetalles.Load(_reader);



                using (cooperativaEntities bd = new cooperativaEntities())
                {


                 
                    #region
                    //new DataTable("FacturasBySocio");

                    //DataColumn FacturasBySocioCol = FacturasBySocio.Columns.Add("Periodo");
                    //FacturasBySocio.Columns.Add("Factura");
                    //FacturasBySocio.Columns.Add("Estado");
                    //FacturasBySocio.Columns.Add("Total");
                    //FacturasBySocio.Columns.Add("Neto");
                    //FacturasBySocio.Columns.Add("IVA");
                    //FacturasBySocio.Columns.Add("Recargo");
                    //FacturasBySocio.Columns.Add("IVARecargo");
                    //FacturasBySocio.Columns.Add("Descuento");
                    //FacturasBySocio.Columns.Add("IVADescuento");
                    //FacturasBySocio.Columns.Add("Cobrado");
                    //FacturasBySocio.Columns.Add("Consumo");
                    //FacturasBySocio.Columns.Add("Lectura");
                    //FacturasBySocio.Columns.Add("LecturaAnt");
                    
                    //var facturasConsulta = (from fac in bd.facturas
                    //                        where fac.id_socio == idSocio
                    //                        select fac).ToList();
                    //DataTable facturasDT = oCommons.convertToTable(facturasConsulta);

                    //var detallesConsulta = (from d in bd.facturas_detalles
                    //                        join fasd in bd.facturas on d.id_factura equals fasd.id_factura
                    //                        where fasd.id_socio == idSocio
                    //                        select d).ToList();
                    //DataTable detallesDT = oCommons.convertToTable(detallesConsulta);

                    //foreach (DataRow row in facturasDT.Rows)
                    //{
                    //    DataRow rowaux =  FacturasBySocio.NewRow();
                 
                    //    rowaux["Periodo"] =row["id_periodo"];
                    //    rowaux["Factura"] =row["id_factura"];
                    //    EstadosPagoImplement oEstadosPagoImplement = new EstadosPagoImplement();

                    //    rowaux["Estado"] = oEstadosPagoImplement.Get(int.Parse(row["id_estadoPago"].ToString())).estado_pago;
                    //    rowaux["Total"] =row["importeTotal"];
                    //    rowaux["Neto"] =row["importeNeto"];

                    //    foreach (DataRow rowD in detallesDT.Rows)
                    //    {
                    //        if (int.Parse(rowD["id_concepto"].ToString()) == 2)
                    //        {
                    //            rowaux["IVA"] = decimal.Parse(rowD["importe"].ToString());
                    //        }
                    //        if (int.Parse(rowD["id_concepto"].ToString()) == 2)
                    //        {
                    //            rowaux["Recargo"] = decimal.Parse(rowD["importe"].ToString());
                    //        }
                    //        if (int.Parse(rowD["id_concepto"].ToString()) == 2)
                    //        {
                    //            rowaux["IVARecargo"] = decimal.Parse(rowD["importe"].ToString());
                    //        }
                    //        if (int.Parse(rowD["id_concepto"].ToString()) == 2)
                    //        {
                    //            rowaux["Descuento"] = decimal.Parse(rowD["importe"].ToString());
                    //        }
                    //        if (int.Parse(rowD["id_concepto"].ToString()) == 2)
                    //        {
                    //            rowaux["IVADescuento"] = decimal.Parse(rowD["importe"].ToString());
                    //        }
                    //    }
                  
                      
                    //    rowaux["Cobrado"] =row["cobrado"];

                    //    SocioMedicionImplement oSocioMedicionImplement = new SocioMedicionImplement();


                    //    rowaux["Consumo"] = oSocioMedicionImplement.Get(int.Parse(row["id_medicion"].ToString())).consumo;

                    //    rowaux["Lectura"] = oSocioMedicionImplement.Get(int.Parse(row["id_medicion"].ToString())).lectura;

                    //    DateTime? pepe = oSocioMedicionImplement.Get(int.Parse(row["id_medicion"].ToString())).fecha_lectura;
                    //    if (pepe != null)
                    //    {
                    //        rowaux["LecturaAnt"] = (from f2 in bd.facturas
                    //                                join sm2 in bd.socios_mediciones on f2.id_medicion equals sm2.id_medicion
                    //                                where f2.id_socio == idSocio & sm2.fecha_lectura < pepe
                    //                                orderby sm2.fecha_lectura descending
                    //                                select new
                    //                                {
                    //                                    sm2.lectura
                    //                                }).Single().lectura;
                    //    }
                    //    FacturasBySocio.Rows.Add(rowaux);
                    //}

                    //return FacturasBySocio;

                    #endregion 
                    #region viejo EF
                    /*
                    var Listar = (from f in bd.facturas

                                  join e in bd.cod_estados_pago on f.id_estadoPago equals e.id_estado_pago
                                  join m in bd.socios_mediciones on f.id_medicion equals m.id_medicion
                                  join pr in bd.periodos on f.id_periodo equals pr.id_periodo
                                  #region
                                  join detalle1 in
                                      (from d in bd.facturas_detalles
                                       where d.id_concepto == 23  //IVA
                                       select new
                                       {
                                           d.id_factura,
                                           d.importe,
                                           importea = d != null ? (int?)d.importe : null
                                       }) on f.id_factura equals detalle1.id_factura
                                  into temp
                                  from i in temp.DefaultIfEmpty()

                                  join detalle2 in
                                      (from d in bd.facturas_detalles
                                       where d.id_concepto == 18  //Recargo
                                       select new
                                       {
                                           d.id_factura,
                                           d.importe
                                       }) on f.id_factura equals detalle2.id_factura
                                  into temp2
                                  from r in temp2.DefaultIfEmpty()

                                  join detalle3 in
                                      (from d in bd.facturas_detalles
                                       where d.id_concepto == 20  //IVARECARGO
                                       select new
                                       {
                                           d.id_factura,
                                           d.importe
                                       }) on f.id_factura equals detalle3.id_factura
                                  into temp3
                                  from ir in temp3.DefaultIfEmpty()

                                  join detalle4 in
                                      (from d in bd.facturas_detalles
                                       where d.id_concepto == 21  //DESCUENTO
                                       select new
                                       {
                                           d.id_factura,
                                           d.importe
                                       }) on f.id_factura equals detalle4.id_factura
                                  into temp4
                                  from desc in temp4.DefaultIfEmpty()

                                  join detalle5 in
                                      (from d in bd.facturas_detalles
                                       where d.id_concepto == 22   //IVADESCUENTO
                                       select new
                                       {
                                           d.id_factura,
                                           d.importe
                                       }) on f.id_factura equals detalle5.id_factura
                                  into temp5
                                  from idesc in temp5.DefaultIfEmpty()

                                  join yr in
                                      (from fx in bd.facturas
                                       join mx in bd.socios_mediciones on fx.id_medicion equals mx.id_medicion

                                       where fx.id_socio == idSocio 
                                       orderby fx.id_factura descending
                                       select new
                                       {
                                           fx.id_factura,
                                           mx.lectura,
                                           fx.id_socio
                                       }) on idSocio equals yr.id_socio
                                    into tempo
                                  from df in tempo.Take(1).DefaultIfEmpty()

                                  #endregion
                                  where f.id_socio == idSocio && (f.id_estadoPago < controlImpagas | controlImpagas == 0)
                                  select new
                                  {
                                      Periodo = f.id_periodo,
                                      Factura = f.id_factura,
                                      FechaFact = f.fechaPago,
                                      FechaVenc = pr.fecha_primer_venc,
                                      idEstado = e.id_estado_pago,
                                      Estado = e.estado_pago,
                                      Total = f.importeTotal,
                                      Neto = f.importeNeto,
                                      IVA = (Decimal?)i.importe,

                                      Recargo = (Decimal?)r.importe,

                                      IVARecargo = (Decimal?)ir.importe,

                                      Descuento = (Decimal?)desc.importe,

                                      IVADescuento = (Decimal?)idesc.importe,

                                      Cobrado = f.cobrado,
                                      Consumo = m.consumo,
                                      Lectura = m.lectura,

                                      LecturaAnt = (Int32?)df.lectura,
                                      DiasVenc = 0

                                  }).ToList();

                    Commons oCommons = new Commons();
                    DataTable FacturasDetalles = oCommons.convertToTable(Listar);*/
                    #endregion
                    
                    foreach (DataRow rowFactDet in FacturasDetalles.Rows)
                    {
                        CalculosFactura oCalculosFactura = new CalculosFactura();
                        int idFactura = int.Parse(rowFactDet["Factura"].ToString());
                        if (int.Parse(rowFactDet["idEstado"].ToString()) == 3)
                        {
                            //paga muestro lo de la fact. como lo hice al principio
                            /*Decimal rec= oCalculosFactura.CalcularRecargo(idFactura);
                            rowFactDet["Recargo"] = rec;
                            rowFactDet["IVARecargo"] = oCalculosFactura.CalcularIVARecargoNuevo(rec, idSocio);*/
                        }
                        else
                        { 
                            //calculo

                           // rowFactDet["IVA"] = oCalculosFactura.CalcularIVA(idFactura);

                            if (mostrarValoresActualizados == 1)
                            {
                                Decimal rec = oCalculosFactura.CalcularRecargo(idFactura);
                                rowFactDet["Recargo"] = rec;
                                rowFactDet["IVARecargo"] = oCalculosFactura.CalcularIVARecargoNuevo(rec, idSocio);
                                rowFactDet["Total"] = decimal.Parse(rowFactDet["Total"].ToString()) + decimal.Parse(rowFactDet["Recargo"].ToString()) + decimal.Parse(rowFactDet["IVARecargo"].ToString());
                            }
                            else {
                                rowFactDet["Recargo"] =0;
                                rowFactDet["IVARecargo"] = 0;
                            }
                            
                            rowFactDet["Descuento"] = oCalculosFactura.CalcularDescuento(idFactura);
                            rowFactDet["IVADescuento"] = oCalculosFactura.CalcularIVADescuento(idFactura);

                        }
                        
                        rowFactDet["LecturaAnt"] = oCalculosFactura.ObtenerLecturaAnterior(idFactura);

                        //rowFactDet["FechaVenc"] = oCalculosFactura.ObtenerFechaVenc(idFactura);

                        //rowFactDet["DiasVenc"] = oCalculosFactura.ObtenerDiasDeVencimientoNuevo(DateTime.Parse(rowFactDet["FechaVenc"].ToString()));
                    }
                    return FacturasDetalles;
                }

            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable GetByIdFacturaDT(int idFactura)
        {
            try
            {
                int controlImpagas = 0;
               
                using (cooperativaEntities bd = new cooperativaEntities())
                {

                    var Listar = (from f in bd.facturas

                                  join e in bd.cod_estados_pago on f.id_estadoPago equals e.id_estado_pago
                                  join m in bd.socios_mediciones on f.id_medicion equals m.id_medicion
                                  join pr in bd.periodos on f.id_periodo equals pr.id_periodo
                                  #region
                                  join detalle1 in
                                      (from d in bd.facturas_detalles
                                       where d.id_concepto == 23  //IVA
                                       select new
                                       {
                                           d.id_factura,
                                           d.importe,
                                           importea = d != null ? (int?)d.importe : null
                                       }) on f.id_factura equals detalle1.id_factura
                                  into temp
                                  from i in temp.DefaultIfEmpty()

                                  join detalle2 in
                                      (from d in bd.facturas_detalles
                                       where d.id_concepto == 18  //Recargo
                                       select new
                                       {
                                           d.id_factura,
                                           d.importe
                                       }) on f.id_factura equals detalle2.id_factura
                                  into temp2
                                  from r in temp2.DefaultIfEmpty()

                                  join detalle3 in
                                      (from d in bd.facturas_detalles
                                       where d.id_concepto == 20  //IVARECARGO
                                       select new
                                       {
                                           d.id_factura,
                                           d.importe
                                       }) on f.id_factura equals detalle3.id_factura
                                  into temp3
                                  from ir in temp3.DefaultIfEmpty()

                                  join detalle4 in
                                      (from d in bd.facturas_detalles
                                       where d.id_concepto == 21  //DESCUENTO
                                       select new
                                       {
                                           d.id_factura,
                                           d.importe
                                       }) on f.id_factura equals detalle4.id_factura
                                  into temp4
                                  from desc in temp4.DefaultIfEmpty()

                                  join detalle5 in
                                      (from d in bd.facturas_detalles
                                       where d.id_concepto == 22   //IVADESCUENTO
                                       select new
                                       {
                                           d.id_factura,
                                           d.importe
                                       }) on f.id_factura equals detalle5.id_factura
                                  into temp5
                                  from idesc in temp5.DefaultIfEmpty()


                                  join detalle6 in
                                      (from d in bd.facturas_detalles
                                       where d.id_concepto == 5   //CONVENIOS
                                       select new
                                       {
                                           d.id_factura,
                                           d.importe
                                       }) on f.id_factura equals detalle6.id_factura
                                  into temp6
                                  from fconv in temp6.DefaultIfEmpty()

                                  join detalle7 in
                                      (from d in bd.facturas_detalles
                                       where d.id_concepto == 4   //ACCIONES
                                       select new
                                       {
                                           d.id_factura,
                                           d.importe
                                       }) on f.id_factura equals detalle7.id_factura
                                 into temp7
                                  from facc in temp7.DefaultIfEmpty()

                                  join yr in
                                      (from fx in bd.facturas
                                       join mx in bd.socios_mediciones on fx.id_medicion equals mx.id_medicion

                                       where fx.id_socio == idFactura
                                       orderby fx.id_factura descending
                                       select new
                                       {
                                           fx.id_factura,
                                           mx.lectura,
                                           fx.id_socio
                                       }) on idFactura equals yr.id_factura
                                    into tempo
                                  from df in tempo.Take(1).DefaultIfEmpty()

                                  #endregion
                                  where f.id_factura == idFactura
                                  select new
                                  {
                                      Periodo = f.id_periodo,
                                      Factura = f.id_factura,
                                      FechaFact = f.fechaPago,
                                      FechaVenc = pr.fecha_primer_venc,
                                      idEstado = e.id_estado_pago,
                                      Estado = e.estado_pago,
                                      Total = f.importeTotal,
                                      Neto = f.importeNeto,
                                      IVA = (Decimal?)i.importe,

                                      Recargo = (Decimal?)r.importe,

                                      IVARecargo = (Decimal?)ir.importe,

                                      Descuento = (Decimal?)desc.importe,

                                      IVADescuento = (Decimal?)idesc.importe,

                                      Cobrado = f.cobrado,
                                      Consumo = m.consumo,
                                      Lectura = m.lectura,

                                      LecturaAnt = (Int32?)df.lectura,
                                      DiasVenc = 0,

                                      // Status = aa == null ? (bool?)null : aa.Online;
                                      Convenio = (Decimal?)fconv.importe==null? 0 :(Decimal?)fconv.importe,
                                      Acciones = (Decimal?)facc.importe == null ? 0 : (Decimal?)facc.importe

                                  }).ToList();

                    Commons oCommons = new Commons();
                    DataTable FacturasDetalles = oCommons.convertToTable(Listar);

                    foreach (DataRow rowFactDet in FacturasDetalles.Rows)
                    {
                        CalculosFactura oCalculosFactura = new CalculosFactura();
                       
                        if (int.Parse(rowFactDet["idEstado"].ToString()) == 3)
                        {
                            //paga muestro lo de la fact. como lo hice al principio

                        }
                        else
                        {
                            rowFactDet["Recargo"] = oCalculosFactura.CalcularRecargo(idFactura);
                            rowFactDet["IVARecargo"] = oCalculosFactura.CalcularIVARecargo(idFactura);
                            rowFactDet["Total"] = decimal.Parse(rowFactDet["Total"].ToString()) + decimal.Parse(rowFactDet["Recargo"].ToString()) + decimal.Parse(rowFactDet["IVARecargo"].ToString());

                            rowFactDet["Descuento"] = oCalculosFactura.CalcularDescuento(idFactura);
                            rowFactDet["IVADescuento"] = oCalculosFactura.CalcularIVADescuento(idFactura);
                        }

                        rowFactDet["LecturaAnt"] = oCalculosFactura.ObtenerLecturaAnterior(idFactura);

                        rowFactDet["FechaVenc"] = oCalculosFactura.ObtenerFechaVenc(idFactura);

                        rowFactDet["DiasVenc"] = oCalculosFactura.ObtenerDiasDeVencimiento(idFactura);
                    }
                    return FacturasDetalles;
                }

            }
            catch (Exception)
            {
                return null;
            }
        }


        public DataTable GetByIdSocioSinConvenioDT(int idSocio, int mostrarImpagas, int mostrarValoresActualizados)
        {
            try
            {
                int controlImpagas = 0;
                if (mostrarImpagas == 1)
                {
                    controlImpagas = 3;
                }
                DataTable FacturasDetalles = new DataTable();
                MySqlCommand _comando = new MySqlCommand(String.Format(
               " call facturas_GetByIdSocio('{0}', '{1}')", idSocio, controlImpagas), dbConectorMySql.ObtenerConexion());

                //MySqlDataAdapter _da = new MySqlDataAdapter(_comando);
                //_da.Fill(DTIntimaciones);

                MySqlDataReader _reader = _comando.ExecuteReader();

                FacturasDetalles.Load(_reader);

                using (cooperativaEntities bd = new cooperativaEntities())
                {
                //    var Listar = (from f in bd.facturas

                //                  join e in bd.cod_estados_pago on f.id_estadoPago equals e.id_estado_pago
                //                  join m in bd.socios_mediciones on f.id_medicion equals m.id_medicion
                //                  join pr in bd.periodos on f.id_periodo equals pr.id_periodo
                //                  #region
                //                  join detalle1 in
                //                      (from d in bd.facturas_detalles
                //                       where d.id_concepto == 23  //IVA
                //                       select new
                //                       {
                //                           d.id_factura,
                //                           d.importe,
                //                           importea = d != null ? (int?)d.importe : null
                //                       }) on f.id_factura equals detalle1.id_factura
                //                  into temp
                //                  from i in temp.DefaultIfEmpty()

                //                  join detalle2 in
                //                      (from d in bd.facturas_detalles
                //                       where d.id_concepto == 18  //Recargo
                //                       select new
                //                       {
                //                           d.id_factura,
                //                           d.importe
                //                       }) on f.id_factura equals detalle2.id_factura
                //                  into temp2
                //                  from r in temp2.DefaultIfEmpty()

                //                  join detalle3 in
                //                      (from d in bd.facturas_detalles
                //                       where d.id_concepto == 20  //IVARECARGO
                //                       select new
                //                       {
                //                           d.id_factura,
                //                           d.importe
                //                       }) on f.id_factura equals detalle3.id_factura
                //                  into temp3
                //                  from ir in temp3.DefaultIfEmpty()

                //                  join detalle4 in
                //                      (from d in bd.facturas_detalles
                //                       where d.id_concepto == 21  //DESCUENTO
                //                       select new
                //                       {
                //                           d.id_factura,
                //                           d.importe
                //                       }) on f.id_factura equals detalle4.id_factura
                //                  into temp4
                //                  from desc in temp4.DefaultIfEmpty()

                //                  join detalle5 in
                //                      (from d in bd.facturas_detalles
                //                       where d.id_concepto == 22   //IVADESCUENTO
                //                       select new
                //                       {
                //                           d.id_factura,
                //                           d.importe
                //                       }) on f.id_factura equals detalle5.id_factura
                //                  into temp5
                //                  from idesc in temp5.DefaultIfEmpty()

                //                  join yr in
                //                      (from fx in bd.facturas
                //                       join mx in bd.socios_mediciones on fx.id_medicion equals mx.id_medicion

                //                       where fx.id_socio == idSocio
                //                       orderby fx.id_factura descending
                //                       select new
                //                       {
                //                           fx.id_factura,
                //                           mx.lectura,
                //                           fx.id_socio
                //                       }) on idSocio equals yr.id_socio
                //                    into tempo
                //                  from df in tempo.Take(1).DefaultIfEmpty()

                //                  #endregion
                //                  where f.id_socio == idSocio && (f.id_estadoPago < controlImpagas | controlImpagas == 0)
                //                  && (f.id_convenio==0 | f.id_convenio ==null)
                //                  select new
                //                  {
                //                      Periodo = f.id_periodo,
                //                      Factura = f.id_factura,
                //                      FechaFact = f.fechaPago,
                //                      FechaVenc = pr.fecha_primer_venc,
                //                      idEstado = e.id_estado_pago,
                //                      Estado = e.estado_pago,
                //                      Total = f.importeTotal,
                //                      Neto = f.importeNeto,
                //                      IVA = (Decimal?)i.importe,

                //                      Recargo = (Decimal?)r.importe,

                //                      IVARecargo = (Decimal?)ir.importe,

                //                      Descuento = (Decimal?)desc.importe,

                //                      IVADescuento = (Decimal?)idesc.importe,

                //                      Cobrado = f.cobrado,
                //                      Consumo = m.consumo,
                //                      Lectura = m.lectura,

                //                      LecturaAnt = (Int32?)df.lectura,
                //                      DiasVenc = 0

                //                  }).ToList();

                //    Commons oCommons = new Commons();
                //    DataTable FacturasDetalles = oCommons.convertToTable(Listar);

                    foreach (DataRow rowFactDet in FacturasDetalles.Rows)
                    {
                        CalculosFactura oCalculosFactura = new CalculosFactura();
                        int idFactura = int.Parse(rowFactDet["Factura"].ToString());
                        if (int.Parse(rowFactDet["idEstado"].ToString()) == 3)
                        {
                            //paga muestro lo de la fact. como lo hice al principio

                        }
                        else
                        {
                            //calculo

                            // rowFactDet["IVA"] = oCalculosFactura.CalcularIVA(idFactura);
                            if (mostrarValoresActualizados == 1)
                            {
                                Decimal rec = oCalculosFactura.CalcularRecargo(idFactura);
                                rowFactDet["Recargo"] = rec;
                                rowFactDet["IVARecargo"] = oCalculosFactura.CalcularIVARecargoNuevo(rec, idSocio);
                                rowFactDet["Total"] = decimal.Parse(rowFactDet["Total"].ToString()) + decimal.Parse(rowFactDet["Recargo"].ToString()) + decimal.Parse(rowFactDet["IVARecargo"].ToString());
                            }
                            else
                            {
                                rowFactDet["Recargo"] = 0;
                                rowFactDet["IVARecargo"] = 0;
                            }

                            rowFactDet["Descuento"] = oCalculosFactura.CalcularDescuento(idFactura);
                            rowFactDet["IVADescuento"] = oCalculosFactura.CalcularIVADescuento(idFactura);


                        }

                        rowFactDet["LecturaAnt"] = oCalculosFactura.ObtenerLecturaAnterior(idFactura);

                        rowFactDet["FechaVenc"] = oCalculosFactura.ObtenerFechaVenc(idFactura);

                        rowFactDet["DiasVenc"] = oCalculosFactura.ObtenerDiasDeVencimiento(idFactura);
                    }
                    return FacturasDetalles;
                }

            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable GetConceptosByIdFactDT(int idFactura)
        {

            try
            {
                using (cooperativaEntities bd = new cooperativaEntities())
                {

                    var Listar = (from f in bd.facturas
                                  join fd in bd.facturas_detalles on f.id_factura equals fd.id_factura
                                  join c in bd.cod_conceptos on fd.id_concepto equals c.id_concepto
                                  where f.id_factura == idFactura
                                  select new
                                  {
                                     c.id_concepto,
                                     c.concepto,
                                     fd.importe
                                  }).ToList();

                    Commons oCommons = new Commons();
                    return oCommons.convertToTable(Listar);
                }

            }
            catch (Exception)
            {
                return null;
            }
        }

        public Boolean ExisteFactura(int idSocio, string periodo)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.facturas
                             where (p.id_socio == idSocio) && (p.id_periodo == periodo)

                             select p).ToList();
                return (regis.Count > 0);
            }
        }

        public Boolean ExisteFactura(int idFactura)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.facturas
                             where (p.id_factura == idFactura)
                                && (p.id_estadoPago!=3)
                             select p).ToList();
                return (regis.Count > 0);
            }
        }

        public Boolean ExisteCobranza(int idFactura)
        {
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.cobranzas
                             where (p.id_factura == idFactura)
                               
                             select p).ToList();
                return (regis.Count > 0);
            }
        }

        public int GetCountFacturasBySocio(int idSocio, int mostrarImpagas)
        {
            int cantFacturas = 0;
            int controlImpagas = 0;
            if (mostrarImpagas == 1)
            {
                controlImpagas = 3;
            }
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.facturas
                             where p.id_socio == idSocio && (p.id_estadoPago < controlImpagas | controlImpagas == 0)
                             select p).Count();

                cantFacturas = int.Parse(regis.ToString());
                return cantFacturas;
            }
        }
        
        public decimal GetTotalFacturasBySocio(int idSocio, int mostrarImpagas)
        {
            decimal totalFacturas = 0;
            int controlImpagas = 0;
            if (mostrarImpagas == 1)
            {
                controlImpagas = 3;
            }

            
            MySqlCommand _comando = new MySqlCommand(String.Format(
           " call GetTotalFacturasBySocio('{0}', '{1}')", idSocio, controlImpagas), dbConectorMySql.ObtenerConexion());

            //MySqlDataAdapter _da = new MySqlDataAdapter(_comando);
            //_da.Fill(DTIntimaciones);

           MySqlDataReader _reader = _comando.ExecuteReader();
           DataTable FacturaTotal = new DataTable();
           FacturaTotal.Load(_reader);

           totalFacturas= decimal.Parse(FacturaTotal.Rows[0][0].ToString());
           
            //using (cooperativaEntities bd = new cooperativaEntities())
            //{
            //    var regis = (from p in bd.facturas
            //                 where p.id_socio == idSocio && (p.id_estadoPago < controlImpagas | controlImpagas == 0)
            //                 group p by p.id_socio into g
            //                 select new { total = g.Sum(p => p.importeTotal) }).Single();

            //    totalFacturas = decimal.Parse(regis.total.ToString());
                
            //}
            return totalFacturas;
        }

        public Decimal? GetTotalRecargoBySocio(int idSocio, int mostrarImpagas)
        {
            decimal totalRecargo = 0;
            Commons oCommons = new Commons();
            int controlImpagas = 0;
            if (mostrarImpagas == 1)
            {
                controlImpagas = 3;
            }

            MySqlCommand _comando = new MySqlCommand(String.Format(
            "call GetIdFactBySocio('{0}', '{1}')", idSocio, controlImpagas), dbConectorMySql.ObtenerConexion());

            MySqlDataReader _reader = _comando.ExecuteReader();
            DataTable detallesCalc = new DataTable();
            detallesCalc.Load(_reader);

            /*using (cooperativaEntities bd = new cooperativaEntities())
            {
                var detallesByFact = (from fac in bd.facturas

                                      where fac.id_socio == idSocio && (fac.id_estadoPago < controlImpagas | controlImpagas == 0)
                                      select new
                                      {
                                          fac.id_factura
                                      }).ToList();
                

                DataTable detallesCalc = oCommons.convertToTable(detallesByFact);
                CalculosFactura oCalculosFactura = new CalculosFactura();
                foreach (DataRow rowDet in detallesCalc.Rows)
                {
                    totalRecargo = totalRecargo + oCalculosFactura.CalcularRecargo(int.Parse(rowDet["id_factura"].ToString()));
                }

                return totalRecargo;
              
            }*/
            CalculosFactura oCalculosFactura = new CalculosFactura();
            /*foreach (DataRow rowDet in detallesCalc.Rows)
            {
                totalRecargo = totalRecargo + oCalculosFactura.CalcularRecargo(int.Parse(rowDet[0].ToString()));
            }*/

            return totalRecargo;
        }

        public Decimal? GetTotalIVARecargoBySocio(int idSocio, int mostrarImpagas)
        {
            decimal totalIVARecargo = 0;
            Commons oCommons = new Commons();
            int controlImpagas = 0;
            if (mostrarImpagas == 1)
            {
                controlImpagas = 3;
            }
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var detallesByFact = (from fac in bd.facturas

                                      where fac.id_socio == idSocio && (fac.id_estadoPago < controlImpagas | controlImpagas == 0)
                                      select new
                                      {
                                          fac.id_factura
                                      }).ToList();


                DataTable detallesCalc = oCommons.convertToTable(detallesByFact);
                CalculosFactura oCalculosFactura = new CalculosFactura();
                foreach (DataRow rowDet in detallesCalc.Rows)
                {
                    totalIVARecargo = totalIVARecargo + oCalculosFactura.CalcularIVARecargo(int.Parse(rowDet["id_factura"].ToString()));
                }

                return totalIVARecargo;

            }
        }

        public string GetUltimoPeriodoFacturadoBySocio(int idSocio)
        {
            facturas oFactura = new facturas();
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.facturas
                             where p.id_socio==idSocio
                             & p.id_estadoPago==3
                             orderby int.Parse(p.id_periodo) descending
                             select new {
                                 p.id_periodo 
                                
                             }).Single();
               
                return regis.id_periodo;
            }
        }

        public facturas GetUltimaFactura(int idSocio)
        {
            facturas oFactura = new facturas();
            using (cooperativaEntities bd = new cooperativaEntities())
            {
                var regis = (from p in bd.facturas
                             where p.id_socio == idSocio
                             orderby p.id_periodo descending
                             select p).FirstOrDefault();
                oFactura.id_factura = regis.id_factura;
                oFactura.id_periodo = regis.id_periodo;
                oFactura.id_socio = regis.id_socio;
                oFactura.id_medicion = regis.id_medicion;
                oFactura.id_estadoPago = regis.id_estadoPago;
                oFactura.id_tarifa = regis.id_tarifa;
                oFactura.id_convenio = regis.id_convenio;
                oFactura.fechaPago = regis.fechaPago;
                oFactura.cobrado = regis.cobrado;
                oFactura.neto1 = regis.neto1;
                oFactura.neto2 = regis.neto2;
                oFactura.importeNeto = regis.importeNeto;
                oFactura.importeTotal = regis.importeTotal;
                return oFactura;
            }
        }


        public DataTable GetByIdSocio(int idSocio)
        {
            try
            {
                using (cooperativaEntities bd = new cooperativaEntities())
                {

                    var Listar = (from f in bd.facturas
                                  where f.id_socio == idSocio
                                  select new
                                  {
                                      f.id_periodo,
                                      f.id_factura,
                                      f.importeTotal,
                                      f.importeNeto,
                                      iva="",
                                      FechaFacturacion= "",
                                      consumo=""
                                  }).ToList();

                    Commons oCommons = new Commons();
                    return oCommons.convertToTable(Listar);
                }

            }
            catch (Exception)
            {
                return null;
            }
        }
        #region << Reportes >>

        public DataTable GetResumenFacturacionPorConcepto(string Periodo, int socioHasta)
        {

            try
            {
                string consulta;
                consulta = "CALL resumenFacturacionXconcepto('" + Periodo + "'," + socioHasta.ToString() + ")";
                DataTable dt = new DataTable();
                string query;
                query = consulta;
                MySqlCommand cmd = new MySqlCommand(query, dbConectorMySql.ObtenerConexion());
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                adap.Fill(dt);
                return dt;


            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable GetResumenFacturacionPorTarifas(string Periodo, int socioHasta)
        {

            try
            {
                string consulta;
                consulta = "CALL resumenFacturacionXTarifa('" + Periodo + "'," + socioHasta.ToString() + ")";
                DataTable dt = new DataTable();
                string query;
                query = consulta;
                MySqlCommand cmd = new MySqlCommand(query, dbConectorMySql.ObtenerConexion());
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                adap.Fill(dt);
                return dt;


            }
            catch (Exception)
            {
                return null;
            }
        }


        public DataTable GetResumenFacturacionPorBarrios(string Periodo, int socioHasta)
        {

            try
            {
                string consulta;
                consulta = "CALL resumenFacturacionXBarrio('" + Periodo + "'," + socioHasta.ToString() + ")";
                DataTable dt = new DataTable();
                string query;
                query = consulta;
                MySqlCommand cmd = new MySqlCommand(query, dbConectorMySql.ObtenerConexion());
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                adap.Fill(dt);
                return dt;


            }
            catch (Exception)
            {
                return null;
            }
        }


        public DataTable GetResumenFacturacionSubDiarios(string Periodo)
        {

            try
            {
                string consulta;
                consulta = "CALL resumenFacturacionSubDiario('" + Periodo + "')";
                DataTable dt = new DataTable();
                string query;
                query = consulta;
                MySqlCommand cmd = new MySqlCommand(query, dbConectorMySql.ObtenerConexion());
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                adap.Fill(dt);
                return dt;


            }
            catch (Exception)
            {
                return null;
            }
        }


        public DataTable GetResumenFacturacionPorConceptoPorBarrios(string Periodo, int socioHasta, int idBarrio)
        {

            try
            {
                string consulta;
                consulta = "CALL resumenFacturacionXconceptoXBarrio('" + Periodo + "'," + socioHasta.ToString() + ","+idBarrio.ToString()+")";
                DataTable dt = new DataTable();
                string query;
                query = consulta;
                MySqlCommand cmd = new MySqlCommand(query, dbConectorMySql.ObtenerConexion());
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                adap.Fill(dt);
                return dt;

            }
            catch (Exception)
            {
                return null;
            }
        }



        public DataTable GetResumenFacturacionPorBarriosPorZonas(string Periodo,int idBarrio, int idZona)
        {

            try
            {
                string consulta;
                consulta = "CALL resumenFacturacionXBarrioXZona('" + Periodo + "',"+idBarrio.ToString()+","+idZona.ToString()+")";
                DataTable dt = new DataTable();
                string query;
                query = consulta;
                MySqlCommand cmd = new MySqlCommand(query, dbConectorMySql.ObtenerConexion());
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                adap.Fill(dt);
                return dt;

            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion
    }
}
