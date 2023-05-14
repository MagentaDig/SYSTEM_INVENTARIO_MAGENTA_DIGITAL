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
            cmd.Parameters.AddWithValue("@NoSerie", Material.NoSerie);
            cmd.Parameters.AddWithValue("@Estatus", Material.Estatus);

            cmd.ExecuteReader();
            cmd.Parameters.Clear();
            conn.CerrarConexion();
        }

        public List<MMateriales> MostrarMateriales (int Categoria)
        {
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "SP_MOSTRAR_MATERIALES";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idCategoria", Categoria);

            SqlDataReader datosMateriales = cmd.ExecuteReader();

            List<MMateriales> Materiales = new List<MMateriales>();

            while (datosMateriales.Read())
            {
                MMateriales Material = new MMateriales();
                Material.NoSerie = (dynamic)datosMateriales["NoSerie"];
                Material.Nombre = (dynamic)datosMateriales["Nombre"];
                Material.Cantidad = (int)datosMateriales["Total Material"];
                Materiales.Add(Material);

            }
            cmd.Parameters.Clear();
            conn.CerrarConexion();
            return Materiales;
        }

        public bool ValidarNoSerie(dynamic noSerie)
        {
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "SP_VALIDAR_NOSERIE";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@NoSerie", noSerie);

            SqlDataReader datoNoSerie = cmd.ExecuteReader();

            bool isDisponible = true;
            if (datoNoSerie.Read())
            {
                isDisponible = false; ;
            }
            cmd.Parameters.Clear();
            conn.CerrarConexion();
            return isDisponible;
        }

        public List<MMateriales> TablaMateriales(int Categ)
        {
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "SP_MOSTRAR_TABLA_MATERIALES";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IdCateg", Categ);

            SqlDataReader materiales = cmd.ExecuteReader();

            List<MMateriales> lstMateriales = new List<MMateriales>();
            while (materiales.Read())
            {
                MMateriales Mat = new MMateriales();
                Mat.IdMaterial = (int)materiales["Id_Materia"];
                Mat.Nombre = (dynamic)materiales["Nombre"];
                Mat.Metros = (decimal)materiales["Metros"];
                Mat.Tamaño = (dynamic)materiales["Tamaño"];
                Mat.NoSerie = (dynamic)materiales["NoSerie"];
                lstMateriales.Add(Mat);
            }
            conn.CerrarConexion();
            return lstMateriales;
        }

        public List<MMateriales> MaterialesInicio (int Categ)
        {
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "SP_MATERIALES_INICIO";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IdCateg", Categ);

            SqlDataReader datos = cmd.ExecuteReader();

            List<MMateriales> lstMateriales = new List<MMateriales>();
            while (datos.Read())
            {
                MMateriales Materiales = new MMateriales();
                Materiales.Nombre = (dynamic)datos["Nombre"];
                Materiales.Tamaño = (dynamic)datos["Tamaño"];
                Materiales.Metros = (decimal)datos["Metros"];
                Materiales.Cantidad = (int)datos["Total Material"];
                lstMateriales.Add(Materiales);            
            }
            cmd.Parameters.Clear();
            conn.CerrarConexion();
            return lstMateriales;
        }

        public void EliminarMaterial(int idMaterial)
        {
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "SP_ELIMINAR_MATERIAL";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IdMaterial", idMaterial);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conn.CerrarConexion();
        }

        public void EstatusMaterial(int IdMaterial, int Estatus)
        {
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "SP_CAMBIAR_ESTATUS_MATERIAL";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IdMaterial",IdMaterial);
            cmd.Parameters.AddWithValue("@Estatus", Estatus);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conn.CerrarConexion();
        }

        public List<MMateriales> MaterialesInactivos()
        {
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "SP_MATERIALES_INACTIVOS";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader datos = cmd.ExecuteReader();
            List<MMateriales> lstMateriales = new List<MMateriales>();

            while (datos.Read())
            {
                MMateriales Materiales = new MMateriales();
                Materiales.IdMaterial = (int)datos["Id_Materia"];
                Materiales.Nombre = (dynamic)datos["Nombre"];
                Materiales.NoSerie = (dynamic)datos["NoSerie"];
                Materiales.Estatus = (int)datos["Estatus"];
                lstMateriales.Add(Materiales);
            }
            conn.CerrarConexion();
            return lstMateriales;
        }

        public List<MMateriales> BusquedaMateriales (int idCateg, dynamic NomMaterial, dynamic NoSerie)
        {
            cmd.Connection = conn.AbrirConexion();
            cmd.CommandText = "SP_BUSQUEDA_MATERIAL";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IdCateg", idCateg);
            cmd.Parameters.AddWithValue("@NomMaterial", NomMaterial);
            cmd.Parameters.AddWithValue("@NoSerie", NoSerie);

            SqlDataReader datos = cmd.ExecuteReader();

            List<MMateriales> lstMateriales = new List<MMateriales>();

            while (datos.Read())
            {
                MMateriales Material = new MMateriales();

                Material.IdMaterial = (int)datos["Id_Materia"];
                Material.Nombre = (dynamic)datos["Nombre"];
                Material.Metros = (decimal)datos["Metros"];
                Material.Tamaño = (dynamic)datos["Tamaño"];
                Material.NoSerie = (dynamic)datos["NoSerie"];
                lstMateriales.Add(Material);
            }
            conn.CerrarConexion();
            return lstMateriales;
        }
    }
}
