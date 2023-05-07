using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;
using SYSTEM_INVENTARIO_MAGENTA_DIGITAL.DB_CONEXION;
using SYSTEM_INVENTARIO_MAGENTA_DIGITAL.MODELOS;

namespace SYSTEM_INVENTARIO_MAGENTA_DIGITAL.DATOS
{
    class DatosMatSelect
    {
        Conexion conn = new Conexion();
        SqlCommand cmd = new SqlCommand();

        public SqlDataReader agreMateSelect(MMaterialSelect MaterialSelec, int IdPedido)
        {
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "SP_DETALLE_PEDIDO";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IdMaterial", MaterialSelec.idMaterial);
            cmd.Parameters.AddWithValue("@IdPedido", IdPedido);
            cmd.Parameters.AddWithValue("@Cantidad", MaterialSelec.Cantidad);

            SqlDataReader insertMat = cmd.ExecuteReader();
            cmd.Parameters.Clear();
            return insertMat;
        }
    }
}
