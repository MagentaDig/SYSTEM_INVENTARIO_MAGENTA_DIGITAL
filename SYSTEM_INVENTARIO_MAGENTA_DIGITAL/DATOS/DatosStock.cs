using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SYSTEM_INVENTARIO_MAGENTA_DIGITAL.DB_CONEXION;
using SYSTEM_INVENTARIO_MAGENTA_DIGITAL.MODELOS;

namespace SYSTEM_INVENTARIO_MAGENTA_DIGITAL.DATOS
{
    class DatosStock
    {
        Conexion conn = new Conexion();
        SqlCommand cmd = new SqlCommand();

        public void AgregarStock(MStock Stock)
        {
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "AGREGAR_STOCK";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Cantidad", Stock.Cantidad);
            cmd.Parameters.AddWithValue("@FechaEntrada", Stock.FechaEntrada);
            cmd.Parameters.AddWithValue("@Id_Materia", Stock.Material);

            cmd.ExecuteNonQuery();
        }
    }
}
