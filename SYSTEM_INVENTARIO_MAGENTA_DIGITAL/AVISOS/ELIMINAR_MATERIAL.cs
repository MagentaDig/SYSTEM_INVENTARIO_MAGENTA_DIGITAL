using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SYSTEM_INVENTARIO_MAGENTA_DIGITAL.RDN;
using SYSTEM_INVENTARIO_MAGENTA_DIGITAL;

namespace SYSTEM_INVENTARIO_MAGENTA_DIGITAL.AVISOS
{
    public partial class ELIMINAR_MATERIAL : Form
    {
        int IdMaterial;
        int idCateg;
        dynamic Categoria;
        public ELIMINAR_MATERIAL(int id_Material, int Id_Categ, dynamic nomCateg)
        {
            InitializeComponent();
            this.IdMaterial = id_Material;
            this.idCateg = Id_Categ;
            this.Categoria= nomCateg;
        }

        private void btn_Si_Click(object sender, EventArgs e)
        {
            RDN_MATERIALES reglaMateriales = new RDN_MATERIALES();
            reglaMateriales.ElimnarMaterial(this.IdMaterial,0);

            MessageBox.Show("El material se elimino correctamente");
            this.Hide();
        }

        private void btn_No_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void recargarPantalla()
        {
            this.Hide();
            MODIFICAR formModificar = new MODIFICAR(this.idCateg, this.Categoria);
            formModificar.Show();
        }
    }
}
