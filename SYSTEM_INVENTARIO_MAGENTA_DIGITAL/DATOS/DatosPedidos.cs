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

        public List<MPedidos> regPedido (MPedidos Pedido)
        {
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "SP_REG_PEDIDO";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Detalle", Pedido.DetallePedido);
            cmd.Parameters.AddWithValue("@IdCateg", Pedido.Categoria);
            cmd.Parameters.AddWithValue("@NomPedido", Pedido.NomPedido);
            cmd.Parameters.AddWithValue("@FechaPedido", Pedido.FechaPedido);

            SqlDataReader insertPedido = cmd.ExecuteReader();

            List<MPedidos> lstPedido = new List<MPedidos>();

           
            if (insertPedido.Read())
            {
                MPedidos IdPedido = new MPedidos();
                IdPedido.IdPedido = int.Parse(insertPedido[0].ToString());
                lstPedido.Add(IdPedido);
            }
            cmd.Parameters.Clear();
            conn.CerrarConexion();
            return lstPedido;
        }

        public List<MPedidos> MostrarPedido(int Categ)
        {
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "SP_MOSTRAR_PEDIDOS";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IdCateg", Categ);

            SqlDataReader DatosPedidos = cmd.ExecuteReader();
            List<MPedidos> lstpedidos = new List<MPedidos>();

            while (DatosPedidos.Read())
            {
                MPedidos Pedido = new MPedidos();
                Pedido.IdPedido = (int)DatosPedidos["IdPedido"];
                Pedido.NomPedido = (dynamic)DatosPedidos["NomPedido"];
                Pedido.DetallePedido = (dynamic)DatosPedidos["DetallePedido"];
                Pedido.FechaPedido = (DateTime)DatosPedidos["FechaPedido"];
                lstpedidos.Add(Pedido);
            }
            cmd.Parameters.Clear();
            conn.CerrarConexion();
            return lstpedidos;
        }
    }
}
