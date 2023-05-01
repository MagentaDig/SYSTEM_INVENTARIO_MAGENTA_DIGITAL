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

        public SqlDataReader agreMateSelect(MMaterialSelect MaterialSelec)
        {
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "SP_AGR_MAT_SELEC";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IdMaterial", MaterialSelec.Material);
            cmd.Parameters.AddWithValue("@IdPedido", MaterialSelec.Pedido);

            SqlDataReader insertMat = cmd.ExecuteReader();

            return insertMat;
        }
    }
}
