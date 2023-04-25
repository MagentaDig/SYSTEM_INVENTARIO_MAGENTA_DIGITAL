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

namespace SYSTEM_INVENTARIO_MAGENTA_DIGITAL
{
    public partial class REGISTRARMATERIAL : Form
    {
        public int idCateg;
        public REGISTRARMATERIAL(int idCateg)
        {
            InitializeComponent();
            this.idCateg = idCateg;
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
            Material.Nombre = txt_nombre.Text;
            Material.Tamaño = txt_tamaño.Text;
            Material.Metros = decimal.Parse( txt_metros.Text);
            Material.Cantidad = int.Parse(txt_cantidad.Text);
            Material.Descripcion = rich_Desc.Text;
            Material.Categoria = this.idCateg;

            DatosMateriales funcionAgr = new DatosMateriales();
            funcionAgr.AgregarMaterial(Material);

            MessageBox.Show("El registro se ah agregado correctamente");

        }
    }
}
