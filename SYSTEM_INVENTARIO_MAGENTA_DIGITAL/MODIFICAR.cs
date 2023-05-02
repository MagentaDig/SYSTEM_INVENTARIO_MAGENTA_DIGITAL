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
using SYSTEM_INVENTARIO_MAGENTA_DIGITAL.MODELOS;

namespace SYSTEM_INVENTARIO_MAGENTA_DIGITAL
{
    public partial class MODIFICAR : Form
    {
        public int idCateg;
        public MODIFICAR(int Categ)
        {
            InitializeComponent();
            this.idCateg = Categ;
            MostrarStock();
        }

        public void MostrarStock()
        {
            DatosStock funcionStock = new DatosStock();
            List<MConsultaStock> lstStock = funcionStock.ConsultarStock(this.idCateg);

            int index;

            foreach (MConsultaStock datos in lstStock)
            {
                index = dataGrid_Stock.Rows.Add();
                dataGrid_Stock.Rows[index].Cells[0].Value = datos.IdMaterial;
                dataGrid_Stock.Rows[index].Cells[1].Value = datos.Nombre;
                dataGrid_Stock.Rows[index].Cells[2].Value = datos.Metros;
                dataGrid_Stock.Rows[index].Cells[3].Value = datos.Tamaño;
                dataGrid_Stock.Rows[index].Cells[4].Value = datos.Cantidad;
                dataGrid_Stock.Rows[index].Cells[5].Value = datos.FechaEntrada;
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            INICIO formInicio = new INICIO(this.idCateg);
            formInicio.Show();
        }

        int idMat;
        private void dataGrid_Stock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGrid_Stock.Columns[e.ColumnIndex].Name == "ACTUALIZAR")
            {
                idMat = Convert.ToInt32(dataGrid_Stock.CurrentRow.Cells["Id_Materia"].Value.ToString());
                ACTUALIZAR formActu = new ACTUALIZAR(idMat, this.idCateg);
                formActu.ShowDialog();
            }
        }
    }
}
