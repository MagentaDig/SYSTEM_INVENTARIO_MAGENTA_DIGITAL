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
using System.Data.SqlClient;

namespace SYSTEM_INVENTARIO_MAGENTA_DIGITAL
{
    public partial class PEDIDOS : Form
    {

        List<MMateriales> materialesAgr = new List<MMateriales>();
        public int idCateg;
        public PEDIDOS(int idCateg)
        {
            InitializeComponent();
            this.idCateg = idCateg;

            mostrarMaterialesCB();
        }

        private void txt_Cantidad_TextChanged(object sender, EventArgs e)
        {

        }


        public void mostrarMaterialesCB()
        {

            DatosMateriales Materiales = new DatosMateriales();

            List<MMateriales> datosMat = Materiales.MostrarMateriales(this.idCateg);

            foreach (MMateriales Mat in datosMat)
            {
                cb_Materiales.Items.Add(Mat.Nombre);
            }
        }

        private void btnReegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            INICIO formInicio = new INICIO(this.idCateg);
            formInicio.Show();
        }

        private void btn_AgrMat_Click(object sender, EventArgs e)
        {
            List<MMateriales> lstMateriales = new List<MMateriales>();
            MMateriales objMaterial = new MMateriales();
            MSalidas objSalida = new MSalidas();

            int index = cb_Materiales.SelectedIndex, indexDt;
            

            objMaterial.Nombre = cb_Materiales.Items[index].ToString();
            objSalida.Cantidad = int.Parse(txt_Cantidad.Text);
            lstMateriales.Add(objMaterial);
            materialesAgr.Add(objMaterial);

            foreach (MMateriales datoM in lstMateriales)
            {
                indexDt = dataGrid_MaterialPed.Rows.Add();
                dataGrid_MaterialPed.Rows[indexDt].Cells[0].Value = datoM.Nombre;
                dataGrid_MaterialPed.Rows[indexDt].Cells[1].Value = objSalida.Cantidad;
            }

        }

        private List<MMateriales> idetificarMaterial()
        {
            DatosMateriales funcoinMateriales = new DatosMateriales();
            List<MMateriales> datosMat = funcoinMateriales.MostrarMateriales(this.idCateg);

            
            List<MMateriales> idMaterial = new List<MMateriales>();

            foreach (MMateriales mat in materialesAgr) 
            {
                foreach(MMateriales dato in datosMat)
                {
                    if(mat.Nombre == dato.Nombre)
                    {
                        MMateriales Material = new MMateriales();
                        Material.IdMaterial = dato.IdMaterial;
                        idMaterial.Add(Material);
                    }
                    
                }
                
            }
            return idMaterial;
        }

        private void btnAgrPedido_Click(object sender, EventArgs e)
        {
            idetificarMaterial();
        }
    }
}
