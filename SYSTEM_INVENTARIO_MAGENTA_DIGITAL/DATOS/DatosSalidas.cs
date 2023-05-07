using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SYSTEM_INVENTARIO_MAGENTA_DIGITAL.DB_CONEXION;
using SYSTEM_INVENTARIO_MAGENTA_DIGITAL.MODELOS;
using System.Data.SqlClient;
using System.Data;

namespace SYSTEM_INVENTARIO_MAGENTA_DIGITAL.DATOS
{
    class DatosSalidas
    {
        Conexion conn = new Conexion();
        SqlCommand cmd = new SqlCommand();

        public void RegSalida(MSalidas Salida)
        {
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "SP_REG_SALIDAS";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@FechaSaida", Salida.FechaSalida);
            cmd.Parameters.AddWithValue("@Id_DP", Salida.MaterialSelec);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();

            conn.CerrarConexion();
        }
    }
}
