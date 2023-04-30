using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SYSTEM_INVENTARIO_MAGENTA_DIGITAL.DATOS;
using SYSTEM_INVENTARIO_MAGENTA_DIGITAL.MODELOS;
using System.Data.SqlClient;

namespace SYSTEM_INVENTARIO_MAGENTA_DIGITAL
{
    public partial class REGISTRARMATERIAL : Form
    {
        public int idCateg;
        public REGISTRARMATERIAL(int idCateg)
        {
            InitializeComponent();
            this.idCateg = idCateg;

            MostrarDataGrid();
        }

        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        
        private void iconoregresarmenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            INICIO inic = new INICIO(this.idCateg);
            inic.Show();
        }

        private void iconocerrar2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconominimizar2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_guardarmat_Click(object sender, EventArgs e)
        {
            MMateriales Material = new MMateriales();
            MStock Stock = new MStock();
            DatosMateriales funcionAgr = new DatosMateriales();
            DatosStock funcionStock = new DatosStock();

            Material.Nombre = txt_nombre.Text;
            Material.Tamaño = txt_tamaño.Text;
            Material.Metros = decimal.Parse( txt_metros.Text);
            Material.Descripcion = rich_Desc.Text;
            Material.Categoria = this.idCateg;

            SqlDataReader MatAgr = funcionAgr.AgregarMaterial(Material);
            int idMateial = getIdMaterial(MatAgr);


            Stock.Cantidad = int.Parse(txt_cantidad.Text);
            Stock.FechaEntrada = DateTime.Now;
            Stock.Material = idMateial;

            funcionStock.AgregarStock(Stock);
            
            MessageBox.Show("El registro se ah agregado correctamente");

        }

        public int getIdMaterial(SqlDataReader Material)
        {
            int idMaterial = 0;
            if (Material.Read())
            {
                idMaterial = int.Parse(Material[0].ToString());
            }
            return idMaterial;
        }


        public void MostrarDataGrid()
        {
            DatosMateriales datosMateriales = new DatosMateriales();
            List<MMateriales> Materiales = datosMateriales.MostrarMateriales(this.idCateg);


            int index;
            foreach (MMateriales mat in Materiales)
            {
                index = dataGrid_AgrMaterial.Rows.Add();
                dataGrid_AgrMaterial.Rows[index].Cells[0].Value = mat.IdMaterial;
                dataGrid_AgrMaterial.Rows[index].Cells[1].Value = mat.Nombre;
            }
        }

        private void panel_barratitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
