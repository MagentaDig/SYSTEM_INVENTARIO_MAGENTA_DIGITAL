using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SYSTEM_INVENTARIO_MAGENTA_DIGITAL.MODELOS;
using SYSTEM_INVENTARIO_MAGENTA_DIGITAL.DATOS;

namespace SYSTEM_INVENTARIO_MAGENTA_DIGITAL.RDN
{
    class RDN_Stock
    {
        public void ModificarStock(MMaterialSelect MaterialAct, int Categ)
        {
            DatosStock funcionStock = new DatosStock();
            List<MConsultaStock> lStStock = funcionStock.ConsultarStock(Categ);

            foreach (MConsultaStock stock in lStStock)
            {
                if (stock.IdMaterial == MaterialAct.idMaterial)
                {
                    int calculoStock = stock.Cantidad - MaterialAct.Cantidad;
                    funcionStock.ActulizarStock(calculoStock, MaterialAct.idMaterial);
                }
            }
        }

        public void ActulizarStock (int NuevoStock, int Material, int Categ)
        {
            DatosStock funcionStock = new DatosStock();
            List<MConsultaStock> lstStock = funcionStock.StockMaterial(Categ,Material);

            foreach (MConsultaStock dato in lstStock)
            {
                MStock Stock = new MStock();
                int CantAct = dato.Cantidad + NuevoStock;

                Stock.Cantidad = CantAct;
                Stock.FechaEntrada = DateTime.Now;
                Stock.Material = Material;
                funcionStock.AgregarStock(Stock);

            }
        }
    }
}
