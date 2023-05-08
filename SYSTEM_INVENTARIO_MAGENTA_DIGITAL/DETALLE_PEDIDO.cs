using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SYSTEM_INVENTARIO_MAGENTA_DIGITAL.MODELOS;
using SYSTEM_INVENTARIO_MAGENTA_DIGITAL.DATOS;

namespace SYSTEM_INVENTARIO_MAGENTA_DIGITAL
{
    public partial class DETALLE_PEDIDO : Form
    {
        public int IdPedido, idCateg;
        public string NomberPed;
        public DETALLE_PEDIDO(int Pedido, int Categ, string NomPedido)
        {
            InitializeComponent();
            this.IdPedido = Pedido;
            this.idCateg = Categ;
            this.NomberPed = NomPedido;
            MostrarDatos();

            lbl_noPedido.Text = this.IdPedido.ToString();
            lbl_NomPedido.Text = this.NomberPed;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGrid_detllePedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGrid_detllePedido.Columns[e.ColumnIndex].Name == "stock")
            {
                
            }
        }

        public void MostrarDatos()
        {
            DatosPedidos funcionPedido = new DatosPedidos();

            List<MDetallePedido> lstDellePd = funcionPedido.ConsultarDetallePedido(this.idCateg, this.IdPedido);

            int indesDP;
            foreach (MDetallePedido datos in lstDellePd)
            {
                indesDP = dataGrid_detllePedido.Rows.Add();
                dataGrid_detllePedido.Rows[indesDP].Cells[0].Value = datos.NoSerie;
                dataGrid_detllePedido.Rows[indesDP].Cells[1].Value = datos.NomMaterial;
                dataGrid_detllePedido.Rows[indesDP].Cells[2].Value = datos.Cantidad;

            }
        }
    }
}
