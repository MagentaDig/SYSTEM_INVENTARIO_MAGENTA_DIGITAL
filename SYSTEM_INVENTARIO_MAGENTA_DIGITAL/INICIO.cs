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
using SYSTEM_INVENTARIO_MAGENTA_DIGITAL.MODELOS;
using SYSTEM_INVENTARIO_MAGENTA_DIGITAL.DATOS;

namespace SYSTEM_INVENTARIO_MAGENTA_DIGITAL
{
    public partial class INICIO : Form
    {
        private int idCateg;

        public INICIO(int id)
        {
            InitializeComponent();
            this.idCateg = id;

            CargarTablaMateriales();
        }

        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnslide_Click(object sender, EventArgs e)
        {
            if (panelmenuvertical.Width == 250)
            {
                panelmenuvertical.Width = 70;
            }
            else
                panelmenuvertical.Width = 250;
        }

        private void iconocerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconomaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconorestaurar.Visible = true;
            iconomaximizar.Visible = false;
        }

        private void iconorestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconorestaurar.Visible = false;
            iconominimizar.Visible = true;
        }

        private void iconominimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel_barratitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_barratitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

            
        }

        //private void AbrirFormInPanel(object FormHijo) 
        //{
           // if (this.panelContenedor.Controls.Count > 0)
             //   this.panelContenedor.Controls.RemoveAt(0);
            //Form fh = FormHijo as Form;
            //fh.TopLevel = false;
            //fh.Dock = DockStyle.Fill;
            //this.panelContenedor.Controls.Add(fh);
            //this.panelContenedor.Tag = fh;
            //fh.Show();
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            REGISTRARMATERIAL regMaterial = new REGISTRARMATERIAL(this.idCateg);
            regMaterial.Show();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Pedido_Click(object sender, EventArgs e)
        {
            this.Hide();
            PEDIDOS formPedidos = new PEDIDOS(this.idCateg);
            formPedidos.Show();
        }

        private void btm_Modificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MODIFICAR formModificar = new MODIFICAR(this.idCateg);
            formModificar.Show();
        }

        private void link_cambiarCateg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            INGRESO formIngreso = new INGRESO();
            formIngreso.Show();
        }

        public void CargarTablaMateriales()
        {
            DatosMateriales funcionMateriales = new DatosMateriales();

            List<MMateriales> lstMateriañes = funcionMateriales.MaterialesInicio(this.idCateg);

            int index;
            foreach (MMateriales mat in lstMateriañes)
            {
                index = dataGridView_MaterialesInicio.Rows.Add();
                dataGridView_MaterialesInicio.Rows[index].Cells[0].Value = mat.Nombre;
                dataGridView_MaterialesInicio.Rows[index].Cells[1].Value = mat.Tamaño;
                dataGridView_MaterialesInicio.Rows[index].Cells[2].Value = mat.Metros;
                dataGridView_MaterialesInicio.Rows[index].Cells[3].Value = mat.Cantidad;
            }
        }
    }
}
