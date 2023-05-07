using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SYSTEM_INVENTARIO_MAGENTA_DIGITAL.MODELOS;
using SYSTEM_INVENTARIO_MAGENTA_DIGITAL.DATOS;
using System.Data.SqlClient;

namespace SYSTEM_INVENTARIO_MAGENTA_DIGITAL.RDN
{
    class RDN_MaterialSelect
    {
        RDN_Stock Stock = new RDN_Stock();
        public int IdMaterial(MMaterialSelect Material, int Pedido, int cantidad)
        {
            DatosMatSelect MatSelect = new DatosMatSelect();
            SqlDataReader datosMateSelect = MatSelect.agreMateSelect(Material, Pedido);
            Stock.ActulizarStock(cantidad, Material.idMaterial);

            int IdMatSeelct = 0;

            if (datosMateSelect.Read())
            {
                IdMatSeelct = int.Parse(datosMateSelect[0].ToString());
            }
            return IdMatSeelct;
        }
    }
}
