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
    public partial class INGRESO : Form
    {
        public INGRESO()
        {
            InitializeComponent();
            datosComboBox();
        }

        private void cb_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        void datosComboBox()
        {
            Categoria eventoCateg = new Categoria();
            List<MCategoria> lstcategorias = eventoCateg.DatosCategoria();

            foreach (MCategoria datoCateg in lstcategorias)
            {
                cb_categoria.Items.Add(datoCateg.NomCategoria.ToString());
            }
        }
    }
}
