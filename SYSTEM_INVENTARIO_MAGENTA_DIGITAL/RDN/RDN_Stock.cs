using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SYSTEM_INVENTARIO_MAGENTA_DIGITAL.MODELOS;
using SYSTEM_INVENTARIO_MAGENTA_DIGITAL.DATOS;
using System.Windows.Forms;

namespace SYSTEM_INVENTARIO_MAGENTA_DIGITAL.RDN
{
    class RDN_Stock
    {
        public void ModificarStock(MMaterialSelect MaterialAct, int Categ)
        {
            //DatosStock funcionStock = new DatosStock();
            //List<MConsultaStock> lStStock = funcionStock.ConsultarStock(Categ);

            //foreach (MConsultaStock stock in lStStock)
            //{
            //    if (stock.IdMaterial == MaterialAct.idMaterial)
            //    {
            //        int calculoStock = stock.Cantidad - MaterialAct.Cantidad;
            //        funcionStock.ActulizarStock(calculoStock, MaterialAct.idMaterial);
            //    }
            //}
        }

        public void ActulizarStock (int NuevoStock, int Material)
        {
            int stockEnFila = NuevoStock;
            DatosStock funcionStock = new DatosStock();
            List<MStock> lstStock = funcionStock.ConsultarStock(Material);
            foreach (MStock stock in lstStock)
            {
                if(stock.StockDisp >= stockEnFila)
                {
                    int newStock = stock.StockDisp - stockEnFila;
                    funcionStock.ActulizarStock(newStock,stock.idStock);
                    break;
                }
                else
                {
                    int newStock = stockEnFila - stock.StockDisp;
                    int stockRest = stock.StockDisp - stock.StockDisp;
                    funcionStock.ActulizarStock(stockRest, stock.idStock);
                    stockEnFila = newStock;
                }
            }
        }

        public void RestaurarStock(int idPedido, int categ)
        {
            DatosPedidos  funcionPedidos = new DatosPedidos();

            List<MDetallePedido> lstDP = funcionPedidos.ConsultarDetallePedido(categ, idPedido);
            IdentificarMaterial(lstDP);
            funcionPedidos.EliminarPedido(idPedido);
        }

        public void IdentificarMaterial (List<MDetallePedido> DetallePedido)
        {
            DatosStock funcionStock = new DatosStock();
            DatosPedidos funcionPedidos = new DatosPedidos();

            foreach (MDetallePedido dp in DetallePedido)
            {
                int stockAct = dp.Cantidad;
                int stockEnFila;
                List<MStock> lstStock = funcionStock.ConsultarStock(dp.Material);
                foreach (MStock stock in lstStock)
                { 
                    if (dp.Material == stock.Material)
                    {
                        stockEnFila = stockAct + stock.StockDisp;
                        if(stockEnFila <= stock.Cantidad)
                        {
                            funcionStock.ActulizarStock(stockEnFila, stock.idStock);
                            funcionPedidos.EliminarDp(dp.idPedido);
                            break;
                        }
                        else
                        {
                            int stockRestante = stockAct - stock.Cantidad;
                            stockEnFila = stockAct - stockRestante;
                            funcionStock.ActulizarStock(stockEnFila, stock.idStock);
                            stockAct = stockRestante;
                        }
                    }
                }
            }
        }
    }
}
