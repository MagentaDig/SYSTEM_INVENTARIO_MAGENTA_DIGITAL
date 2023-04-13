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

        public void datosComboBox()
        {
            Categoria eventoCateg = new Categoria();
            List<MCategoria> lstcategorias = eventoCateg.DatosCategoria();

            foreach (MCategoria datoCateg in lstcategorias)
            {
                cb_categoria.Items.Add(datoCateg.NomCategoria.ToString());

            }
        }

        public MCategoria categoriaSeleccionada()
        {
            Categoria eventoCateg = new Categoria();
            List<MCategoria> lstcategorias = eventoCateg.DatosCategoria();

            int index = cb_categoria.SelectedIndex;
            string categoria = cb_categoria.Items[index].ToString();

            MCategoria categ = new MCategoria();
            foreach (MCategoria datoCateg in lstcategorias)
            {
                if (categoria == datoCateg.NomCategoria.ToString())
                {
                    
                    categ.IdCategoria = datoCateg.IdCategoria;
                    categ.NomCategoria = datoCateg.NomCategoria;
                }
                
            }
            return categ;


        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            MCategoria categSelect = categoriaSeleccionada();

            this.Hide();
            INICIO FormInicio = new INICIO(categSelect.IdCategoria);
            FormInicio.lbl_categoriaSelect.Text = categSelect.NomCategoria.ToString();
            FormInicio.Show();
            
        }
    }
}
