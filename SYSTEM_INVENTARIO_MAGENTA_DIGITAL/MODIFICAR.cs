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
using SYSTEM_INVENTARIO_MAGENTA_DIGITAL.AVISOS;

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
            DatosMateriales funcionMateriales = new DatosMateriales();
            List<MMateriales> lstMateriales = funcionMateriales.TablaMateriales(this.idCateg);

            int index;

            foreach (MMateriales datos in lstMateriales)
            {
                index = dataGrid_Stock.Rows.Add();
                dataGrid_Stock.Rows[index].Cells[0].Value = datos.IdMaterial;
                dataGrid_Stock.Rows[index].Cells[1].Value = datos.Nombre;
                dataGrid_Stock.Rows[index].Cells[2].Value = datos.NoSerie;
                dataGrid_Stock.Rows[index].Cells[3].Value = datos.Metros;
                dataGrid_Stock.Rows[index].Cells[4].Value = datos.Tamaño;

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
            if (dataGrid_Stock.Columns[e.ColumnIndex].Name == "stock")
            {
                idMat = Convert.ToInt32(dataGrid_Stock.CurrentRow.Cells["Id_Materia"].Value.ToString());
                ACTUALIZAR formActu = new ACTUALIZAR(idMat, this.idCateg);
                formActu.ShowDialog();
                recargarPantalla();
            }
            else if (dataGrid_Stock.Columns[e.ColumnIndex].Name == "ELIMINAR")
            {
                idMat = Convert.ToInt32(dataGrid_Stock.CurrentRow.Cells["Id_Materia"].Value.ToString());
                ELIMINAR_MATERIAL formElimanrMat = new ELIMINAR_MATERIAL(idMat, this.idCateg);
                formElimanrMat.ShowDialog();
                recargarPantalla();
            }
        }

        public void recargarPantalla()
        {
            this.Hide();
            MODIFICAR fomModificar = new MODIFICAR(this.idCateg);
            fomModificar.Show();
        }
    }
}
