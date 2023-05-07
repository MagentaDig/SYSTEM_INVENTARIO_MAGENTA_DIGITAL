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

        public List<MStock> ConsultarStock(int IdMaterial)
        {
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "SP_COSULTAR_STOCK";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IdMateria", IdMaterial);

            List<MStock> lstStock = new List<MStock>();

            SqlDataReader stock = cmd.ExecuteReader();
            while (stock.Read())
            {
                MStock Stock = new MStock();
                Stock.idStock = (int)stock["Id_Stock"];
                Stock.Cantidad = (int)stock["Cantidad"];
                Stock.FechaEntrada = (DateTime)stock["FechaEntrada"];
                Stock.Material = (int)stock["Id_Materia"];

                lstStock.Add(Stock);
            }
            conn.CerrarConexion();
            cmd.Parameters.Clear();
            return lstStock;

        }

        public List<MConsultaStock> StockMaterial(int Categoria, int Material)
        {
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "SP_COSULTAR_STOCK_X_MATERIAL";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IdCateg", Categoria);
            cmd.Parameters.AddWithValue("@IdMaterial", Material);

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
            cmd.Parameters.Clear();
            conn.CerrarConexion();

            return lstStock;
        }

        public void ActulizarStock(int nuevoStock, int IdStock)
        {
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "SP_ACTUALIZAR_STOCK";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Stock", nuevoStock);
            cmd.Parameters.AddWithValue("@IdStock", IdStock);


            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conn.CerrarConexion();
        }
    }
}
