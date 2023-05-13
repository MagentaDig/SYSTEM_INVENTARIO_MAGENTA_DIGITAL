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
    public partial class MATERIALES_INACTIVOS : Form
    {
        public int IdCateg;
        public MATERIALES_INACTIVOS(int Categ)
        {
            InitializeComponent();
            this.IdCateg = Categ;
            CargarTabla();
        }

        public void CargarTabla()
        {
            DatosMateriales funcionMateriales = new DatosMateriales();

            List<MMateriales> lstMateriales = funcionMateriales.MaterialesInactivos();

            int index;

            foreach (MMateriales datos in lstMateriales)
            {
                index = dataGridView_MatInac.Rows.Add();
                dataGridView_MatInac.Rows[index].Cells[0].Value = datos.IdMaterial;
                dataGridView_MatInac.Rows[index].Cells[1].Value = datos.NoSerie;
                dataGridView_MatInac.Rows[index].Cells[2].Value = datos.Nombre;

            }
        }

        int idMaterial;
        private void dataGridView_MatInac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DatosMateriales funcoinMateriales = new DatosMateriales();
            
            if (dataGridView_MatInac.Columns[e.ColumnIndex].Name == "habilitar")
            {
                idMaterial = int.Parse((dataGridView_MatInac.CurrentRow.Cells["id"].Value.ToString()));
                funcoinMateriales.EstatusMaterial(idMaterial,1);
                this.Hide();
            }
        }

        public void recargarPantalla()
        {
            this.Hide();
            MODIFICAR formModificar = new MODIFICAR(this.IdCateg);
            formModificar.Show();
        }
    }
}
