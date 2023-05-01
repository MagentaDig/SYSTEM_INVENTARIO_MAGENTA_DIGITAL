using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SYSTEM_INVENTARIO_MAGENTA_DIGITAL.MODELOS;
using SYSTEM_INVENTARIO_MAGENTA_DIGITAL.DB_CONEXION;
using SYSTEM_INVENTARIO_MAGENTA_DIGITAL.DATOS;
using System.Data.SqlClient;

namespace SYSTEM_INVENTARIO_MAGENTA_DIGITAL.RDN
{
    class RDN_Pedidos
    {
        public int IdPedido(MPedidos Pedido)
        {
            DatosPedidos funcionPedidos = new DatosPedidos();
            SqlDataReader datos = funcionPedidos.regPedido(Pedido);

            int IdPedido = 0;
            if (datos.Read())
            {
                IdPedido = int.Parse(datos[0].ToString());
            }
            return IdPedido;
        }
    }
}
