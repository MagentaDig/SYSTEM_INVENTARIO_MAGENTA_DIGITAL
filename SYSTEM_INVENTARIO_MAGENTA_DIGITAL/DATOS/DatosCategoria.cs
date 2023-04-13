using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SYSTEM_INVENTARIO_MAGENTA_DIGITAL.DB_CONEXION;
using SYSTEM_INVENTARIO_MAGENTA_DIGITAL.MODELOS;

namespace SYSTEM_INVENTARIO_MAGENTA_DIGITAL.DATOS
{
    public class Categoria
    {
        Conexion conexion = new Conexion();
        SqlCommand cmd = new SqlCommand();
        public SqlDataReader Categorias()
        {
            cmd.Connection = conexion.AbrirConexion();
            cmd.CommandText = "SP_LISTAR_CATEGORIAS";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader categorias = cmd.ExecuteReader();

            return categorias;

        }

        public List<MCategoria> DatosCategoria()
        {
            List<MCategoria> categorias = new List<MCategoria>();
            SqlDataReader sql_Categorias = Categorias();

            while (sql_Categorias.Read())
            {
                MCategoria categ = new MCategoria();
                categ.IdCategoria = (int)sql_Categorias["Id_Categ"];
                categ.NomCategoria = (string)sql_Categorias["Categoria"];
                categorias.Add(categ);
            }
            return categorias;

        }
    }
}
