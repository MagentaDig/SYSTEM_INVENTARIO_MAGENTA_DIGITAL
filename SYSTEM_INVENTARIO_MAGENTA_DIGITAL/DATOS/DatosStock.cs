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
            cmd.Parameters.Clear();
        }

        public List<MConsultaStock> ConsultarStock(int Categoria)
        {
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "SP_COSULTAR_STOCK";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IdCateg", Categoria);

            List<MConsultaStock> lstStock = new List<MConsultaStock>();

            SqlDataReader stock = cmd.ExecuteReader();
            while (stock.Read())
            {
                MConsultaStock Stock = new MConsultaStock();
                Stock.IdMaterial = (int)stock["Id_Materia"];
                Stock.Nombre = (string)stock["Nombre"];
                Stock.Metros = (decimal)stock["Metros"];
                Stock.Tamaño = (dynamic)stock["Tamaño"];
                Stock.Cantidad = (int)stock["Cantidad"];
                Stock.FechaEntrada = (DateTime)stock["FechaEntrada"];
                lstStock.Add(Stock);
            }
            conn.CerrarConexion();
            cmd.Parameters.Clear();
            return lstStock;

        }

        public List<MConsultaStock> StockMaterial(int Categoria)
        {
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "SP_COSULTAR_STOCK";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IdCateg", Categoria);
            cmd.Parameters.AddWithValue("@IdMaterial", Categoria);

            List<MConsultaStock> lstStock = new List<MConsultaStock>();

            SqlDataReader stock = cmd.ExecuteReader();
            if (stock.Read())
            {
                MConsultaStock Stock = new MConsultaStock();
                Stock.IdMaterial = (int)stock["Id_Materia"];
                Stock.Nombre = (string)stock["Nombre"];
                Stock.Metros = (int)stock["Metros"];
                Stock.Tamaño = (dynamic)stock["Tamaño"];
                Stock.Cantidad = (int)stock["Cantidad"];
                Stock.FechaEntrada = (DateTime)stock["FechaEntrada"];
            }
            cmd.Parameters.Clear();
            conn.CerrarConexion();

            return lstStock;
        }

        public void ActulizarStock(int nuevoStock, int IdMaterial)
        {
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "SP_ACTUALIZAR_STOCK";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Stock", nuevoStock);
            cmd.Parameters.AddWithValue("@IdMaterial", IdMaterial);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conn.CerrarConexion();
        }
    }
}
