using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYSTEM_INVENTARIO_MAGENTA_DIGITAL.DB_CONEXION
{
    public class Conexion
    {

        //CADENDA DE CONEXION HACIA LA BASE DE DATOS
        //  - La base de datos esta alojado en un servidor de Azure
        SqlConnection conn = new SqlConnection("Server=tcp:magentaserver.database.windows.net,1433;Initial Catalog=DB_MAGENTA;Persist Security Info=False;User ID=servermg;Password=Magenta2023*;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");

        // METODO PÁRA ABRIR LA CONEXION
        public SqlConnection AbrirConexion()
        {

            // Almacenamos la conexion en una variable
            SqlConnection AbrirConn = conn;
            try
            {
                AbrirConn.Open();
                //MessageBox.Show("Conexion existosa");
            }
            catch (SqlException e)
            {
                MessageBox.Show("NO se pudo estableder la conexion" + e.ToString());
            }
            return AbrirConn;
        }

        public SqlConnection CerrarConexion()
        {
            SqlConnection CerrarConn = conn;
            CerrarConn.Close();

            return CerrarConn;
        }
    }
}
