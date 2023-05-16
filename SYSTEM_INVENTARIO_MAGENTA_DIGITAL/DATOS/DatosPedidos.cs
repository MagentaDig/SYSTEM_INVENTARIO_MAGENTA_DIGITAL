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
            cmd.Parameters.AddWithValue("@Estatus", Pedido.IsEntregado);
            cmd.Parameters.AddWithValue("@FecEntrega", Pedido.FechaEntrega);

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
                Pedido.DetallePedido = (dynamic)DatosPedidos["Detalle"];
                Pedido.FechaPedido = (DateTime)DatosPedidos["FechaPedido"];
                Pedido.FechaEntrega = (DateTime)DatosPedidos["FecEntrega"];
                Pedido.IsEntregado = (int)DatosPedidos["IsEntregado"];
                lstpedidos.Add(Pedido);
            }
            cmd.Parameters.Clear();
            conn.CerrarConexion();
            return lstpedidos;
        }

        public List<MDetallePedido> ConsultarDetallePedido(int Categ, int IdPedido)
        {
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "SP_CONSULTAR_DETALLE_PEDIDO";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IdPedido", IdPedido);
            cmd.Parameters.AddWithValue("@IdCateg", Categ);

            SqlDataReader datosDp = cmd.ExecuteReader();

            List<MDetallePedido> lstDetallePed = new List<MDetallePedido>();

            while (datosDp.Read())
            {
                MDetallePedido DP = new MDetallePedido();
                DP.idPedido = (int)datosDp["IdPedido"];
                DP.NomPedido = (dynamic)datosDp["NomPedido"];
                DP.Material = (int)datosDp["Id_Materia"];
                DP.NomMaterial = (dynamic)datosDp["Nombre"];
                DP.NoSerie = (dynamic)datosDp["NoSerie"];
                DP.Cantidad = (int)datosDp["Cantidad"];
                lstDetallePed.Add(DP);
            }
            cmd.Parameters.Clear();
            conn.CerrarConexion();
            return lstDetallePed;
        }

        public void EliminarDp (int id_Pedido)
        {
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "SP_ELIMAR_DP";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id_Pedido", id_Pedido);
            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            conn.CerrarConexion();
        }

        public void EliminarPedido(int id_Pedido)
        {
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "SP_ELIMAR_PEDIDO";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id_Pedido", id_Pedido);
            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            conn.CerrarConexion();
        }

        public void EstatusPedido(int IdPedido, DateTime FecEntrega, int Estatus)
        {
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "SP_ESTATUS_PEDIDO";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Estatus",Estatus);
            cmd.Parameters.AddWithValue("@FecEntrega",FecEntrega);
            cmd.Parameters.AddWithValue("@IdPedido",IdPedido);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conn.CerrarConexion();
        }

        public List<MPedidos> consultarPedidos (int Categ, int Pedido)
        {
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "SP_BUSCAR_PEDIDO";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IdPedido", Pedido);
            cmd.Parameters.AddWithValue("@IdCateg", Categ);

            SqlDataReader datos = cmd.ExecuteReader();
            List<MPedidos> lstPedidos = new List<MPedidos>();
            while (datos.Read())
            {
                MPedidos Ped = new MPedidos();
                Ped.IdPedido = (int)datos["IdPedido"];
                Ped.NomPedido = (dynamic)datos["NomPedido"];
                Ped.DetallePedido = (dynamic)datos["Detalle"];
                Ped.FechaPedido = (DateTime)datos["FechaPedido"];
                Ped.FechaEntrega = (DateTime)datos["FecEntrega"];
                Ped.IsEntregado = (int)datos["IsEntregado"];
                lstPedidos.Add(Ped);
            }
            return lstPedidos;
        }
    }
}
