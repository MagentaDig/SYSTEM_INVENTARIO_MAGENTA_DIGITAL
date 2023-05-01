using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SYSTEM_INVENTARIO_MAGENTA_DIGITAL.DB_CONEXION;
using System.Data.SqlClient;
using System.Data;
using SYSTEM_INVENTARIO_MAGENTA_DIGITAL.MODELOS;

namespace SYSTEM_INVENTARIO_MAGENTA_DIGITAL.DATOS
{
    class DatosPedidos
    {
        Conexion conn = new Conexion();
        SqlCommand cmd = new SqlCommand();

        public SqlDataReader regPedido (MPedidos Pedido)
        {
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "SP_REG_PEDIDO";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Detalle", Pedido.DetallePedido);
            cmd.Parameters.AddWithValue("@IdCateg", Pedido.Categoria);

            SqlDataReader insertPedido = cmd.ExecuteReader();

            return insertPedido;
        }
    }
}
