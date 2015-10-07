using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.cooperativa.services;
using com.cooperativa.implement.dao;
using System.Collections;

namespace com.cooperativa.implement.calculos
{
    public class CalculosFacturacionFormulas
    {
        public facturas_detalles getDetalle(int idSocio, decimal cargoFijo, decimal abono, decimal valorM3, cod_conceptos oConcepto, facturas oFactura, conceptos_particulares oConceptoParticular)
        {

                                    SocioMedicionImplement oSocioMedicionImpl = new SocioMedicionImplement();
                                    socios_mediciones oSocioMedicion = new socios_mediciones();
                                    if (oFactura.id_medicion.Value!=0)
                                        oSocioMedicion = oSocioMedicionImpl.Get(oFactura.id_medicion.Value);
                                    acciones oAccion = new acciones();
                                    AccionImplement oAccionesImplement = new AccionImplement();
                                    
                                    facturas_detalles oDetalle = new facturas_detalles();
                                    oDetalle.idOrden = oConcepto.orden_concepto;
                                    oDetalle.id_concepto = oConcepto.id_concepto;
                                    oDetalle.idTipo = 0;
                                    oDetalle.id_factura = oFactura.id_factura;
                                 

                                    ConvenioImplement oConvenioImplement = new ConvenioImplement();
                                    switch (oConcepto.id_formula)
                                    {
                                        case 0:
                                           
                                            oDetalle.importe = cargoFijo;
                                            
                                            break;
                                        case 1:

                                            if (cargoFijo> 0)
                                            {
                                                oDetalle.importe = cargoFijo * oConcepto.variable.Value;
                                            }
                                            else
                                            {
                                                if (oFactura.id_medicion.Value != 0)
                                                {//revisar
                                                    if ((oSocioMedicion.consumo - abono) <= 0)
                                                    {
                                                        // Si no hubo consumo excedente ...
                                                        oDetalle.importe = abono * valorM3 * oConcepto.variable.Value;
                                                    }
                                                    else
                                                    {
                                                        //  Si hubo consumo excedente ...
                                                        decimal uno = (abono * valorM3);
                                                        decimal dos = ((oSocioMedicion.consumo.Value - abono) * valorM3);
                                                        oDetalle.importe = (uno + dos) * oConcepto.variable.Value;
                                                    }
                                                }
                                                else
                                                {
                                                    //Por que no tiene medidor usa el abono
                                                    oDetalle.importe = abono * valorM3 * oConcepto.variable.Value;
                                                }
                                            }
                                            break;
                                        case 2:
                                            // Consumo excedente por ValorM3
                                            // (Facturas.Consumo - Socios.Tarifa->Abono) *
                                            // Socios.Tarifa->ValorM3
                                         
                                               
                                              if (oFactura.id_medicion.Value != 0)
                                                {
                                                    oSocioMedicion = oSocioMedicionImpl.Get(oFactura.id_medicion.Value);
                                                if ((oSocioMedicion.consumo.Value - abono) > 0)
                                                {
                                                    //        ' Calcula sólo sobre el consumo excedente
                                                    oDetalle.importe = (oSocioMedicion.consumo.Value - abono) * valorM3;

                                                }
                                                else
                                                {
                                                    //  No hubo consumo excedente
                                                    oDetalle.importe = 0;
                                                }
                                                }else
                                                  oDetalle.importe = 0;
                                            
                                            break;
                                        case 3:
                                            //  ' Abono por ValorM3
                                            //' Socios.Tarifa->Abono * Socios.Tarifa->ValorM3
                                            oDetalle.importe = abono * valorM3;
                                            break;
                                        case 4:

                                            //' Consumo por ValorM3 por Variable
                                            //' Facturas.Consumo * Socios.Tarifa->ValorM3 * Conceptos.Variable
                                            if (oFactura.id_medicion.Value != 0)
                                            oDetalle.importe = oSocioMedicion.consumo.Value * valorM3 * oConcepto.variable.Value;
                                            else
                                                oDetalle.importe = 0;
                                            break;

                                        case 5:

                                            oAccion = oAccionesImplement.GetByIdSocio(idSocio);
                                            if (oAccion != null)
                                            {
                                                if (oAccion.cuotas > oAccion.facturadas)
                                                {
                                                    oAccion.facturadas = oAccion.facturadas + 1;
                                                    oAccionesImplement.Update(oAccion);
                                                    oDetalle.importe = oAccion.valor_cuota;
                                                }
                                                else { oDetalle.importe = 0; }
                                            }
                                            else { oDetalle.importe = 0; }

                                            break;
                                        case 6:
                                            // Variable por Cuota Acciones
                                            // Acciones.ValorCuota * Conceptos.Variable
                                            // Buscar Acciones
                                            oAccion = oAccionesImplement.GetByIdSocio(idSocio);
                                            // Si encuentra un registro
                                            if (oAccion != null)
                                            {
                                                // Pregunta si no está finalizado
                                                if (oAccion.cuotas > oAccion.facturadas)
                                                {
                                                    //Si no ha finalizado se factura una cuota más
                                                    oAccion.facturadas = oAccion.facturadas + 1;
                                                    oAccionesImplement.Update(oAccion);
                                                    oDetalle.importe = oAccion.valor_cuota * oConcepto.variable.Value;
                                                }
                                                else { oDetalle.importe = 0; }
                                            }
                                            else { oDetalle.importe = 0; }
                                            break;
                                        case 7:

                                            // Cuota Convenio de pago
                                            // Convenios.ValorCuota
                                            decimal ImporteConvenios = 0;
                                            // Inicializa el campo en cero
                                            oDetalle.importe = 0;
                                            // Buscar Convenio
                                            IList ListConvenios = oConvenioImplement.GetAllBySocio(idSocio);
                                            foreach (convenios oConvenio in ListConvenios)
                                            {
                                                //  Verifica que no se trate de un convenio judicial
                                                if (!oConvenio.convenio_judicial.Value)
                                                {
                                                    //Pregunta si no está finalizado   
                                                    if (oConvenio.cuotas > oConvenio.facturadas)
                                                    {
                                                        //Si no ha finalizado se factura una cuota más
                                                        oConvenio.facturadas = oConvenio.facturadas + 1;
                                                        if (oConvenio.cuotas == oConvenio.facturadas) { oConvenio.finalizado = true; }
                                                        oConvenioImplement.Update(oConvenio);
                                                        ImporteConvenios = ImporteConvenios + oConvenio.valor_cuota;
                                                    }
                                                }
                                            }
                                            oDetalle.importe = ImporteConvenios;
                                            break;
                                        case 8:
                                            // Variable por Cuota Convenio
                                            // Convenios.ValorCuota * Conceptos.Variable
                                            // Buscar Convenio
                                            IList ListaConvenios = oConvenioImplement.GetAllBySocio(idSocio);
                                            //Si encuentra un registro
                                            oDetalle.importe = 0;
                                            foreach (convenios oConvenio in ListaConvenios)
                                            {
                                                //  Verifica que no se trate de un convenio judicial
                                                if (!oConvenio.convenio_judicial.Value)
                                                {
                                                    //Pregunta si no está finalizado   
                                                    if (oConvenio.cuotas > oConvenio.facturadas)
                                                    {
                                                        oConvenio.facturadas = oConvenio.facturadas + 1;
                                                        oConvenioImplement.Update(oConvenio);
                                                        oDetalle.importe = oConvenio.valor_cuota * oConcepto.variable.Value;
                                                    }
                                                    else
                                                    {
                                                        oDetalle.importe = 0;
                                                    }
                                                }
                                                else { oDetalle.importe = 0; }
                                            }

                                            break;
                                        case 9:
                                            //Importe fijo según concepto
                                            // Conceptos.Variable
                                            oDetalle.importe = oConcepto.variable.Value;
                                            break;
                                        case 10:
                                            // Importe variable que se calcula en el momento
                                            // (NO IMPLEMENTADO)
                                            break;
                                        case 11:
                                            // Importe fijo según Conceptos Particulares
                                            // ConceptosPartic.Importe
                                            oDetalle.importe = oConceptoParticular.importe;
                                            break;
                                    }

                                    return oDetalle;
        }
    
    
    
    
    }
}
