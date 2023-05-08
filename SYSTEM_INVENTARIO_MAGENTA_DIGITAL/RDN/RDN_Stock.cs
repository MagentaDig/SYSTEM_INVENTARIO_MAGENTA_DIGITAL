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
                if(stock.Cantidad >= stockEnFila)
                {
                    int newStock = stock.Cantidad - stockEnFila;
                    funcionStock.ActulizarStock(newStock,stock.idStock);
                    break;
                }
                else
                {
                    int newStock = stockEnFila - stock.Cantidad;
                    int stockRest = stock.Cantidad - stock.Cantidad;
                    funcionStock.ActulizarStock(stockRest, stock.idStock);
                    stockEnFila = newStock;
                }
            }
        }

        public void RestaurarStock(int idPedido, int categ)
        {
            DatosPedidos  funcionPedidos = new DatosPedidos();
            DatosStock funcionStock = new DatosStock();

            List<MDetallePedido> lstDP = funcionPedidos.ConsultarDetallePedido(categ, idPedido);
            List<MStock> lstStock = new List<MStock>();
            foreach (MDetallePedido dp in lstDP)
            {
                MStock objStock = new MStock();
                objStock.Cantidad = dp.Cantidad;
                objStock.Material = dp.Material;
                lstStock.Add(objStock);
            }
        }
    }
}
