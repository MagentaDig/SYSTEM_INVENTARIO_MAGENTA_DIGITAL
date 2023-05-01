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
    }
}
