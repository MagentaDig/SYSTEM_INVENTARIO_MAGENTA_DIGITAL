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
    internal class DatosMateriales
    {
        Conexion conn = new Conexion();
        SqlCommand cmd = new SqlCommand();

        public void AgregarMaterial (MMateriales Material)
        {
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "SP_AGREGAR_MATERIAL";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Descripcion", Material.Descripcion);
            cmd.Parameters.AddWithValue("@Id_Categ", Material.Categoria);
            cmd.Parameters.AddWithValue("@Nombre", Material.Nombre);
            cmd.Parameters.AddWithValue("@Tamaño", Material.Tamaño);
            cmd.Parameters.AddWithValue("@Metros", Material.Metros);
            cmd.Parameters.AddWithValue("@Cantidad", Material.Cantidad);

            cmd.ExecuteNonQuery();
        }

        public SqlDataReader MostrarMateriales (int Categoria)
        {
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "SP_MOSTRAR_MATERIALES";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idCategoria", Categoria);

            SqlDataReader datosMateriales = cmd.ExecuteReader();

            return datosMateriales;
        }
    }
}
