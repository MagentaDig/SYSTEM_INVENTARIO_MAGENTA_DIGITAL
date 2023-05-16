using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SYSTEM_INVENTARIO_MAGENTA_DIGITAL.DATOS;

namespace SYSTEM_INVENTARIO_MAGENTA_DIGITAL
{
    public partial class ENTREGA : Form
    {
        public int IdPedido;
        public ENTREGA(int idPedido)
        {
            InitializeComponent();
            this.IdPedido = idPedido;
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            DateTime fecEntrega = dateTime_FecEntrega.Value;
            int estatus = 1;

            DatosPedidos funcionPedido = new DatosPedidos();
            funcionPedido.EstatusPedido(this.IdPedido, fecEntrega, estatus);

            MessageBox.Show("Se a confirmado la entrega del pedido");
            this.Hide();

        }
    }
}
