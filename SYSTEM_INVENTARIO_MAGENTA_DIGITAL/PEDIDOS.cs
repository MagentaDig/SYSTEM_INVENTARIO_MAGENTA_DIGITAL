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
using SYSTEM_INVENTARIO_MAGENTA_DIGITAL.RDN;
using System.Data.SqlClient;

namespace SYSTEM_INVENTARIO_MAGENTA_DIGITAL
{
    public partial class PEDIDOS : Form
    {
        /* Listas globales */
        List<MMaterialSelect> lst_MatSelec = new List<MMaterialSelect>();
        List<MSalidas> lstSalidas = new List<MSalidas>();
        List<MSalidas> copia_lstSalidas = new List<MSalidas>();
        List<MMaterialSelect> copia_lstMateriales = new List<MMaterialSelect>();

        /* Istancias de objetos */
        MSalidas Salidas = new MSalidas();
       

        /* Variables globales */
        public int idCateg;
        public int IdPedido;
        public PEDIDOS(int idCateg)
        {
            InitializeComponent();
            this.idCateg = idCateg;

            mostrarMaterialesCB();
            //mostrarPedido();
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
            MMaterialSelect Material = new MMaterialSelect();
            List<MMaterialSelect> lstMateriales = new List<MMaterialSelect>();

            int index = cb_Materiales.SelectedIndex, indexDt;
            Material.NomMaterial = cb_Materiales.Items[index].ToString();
            Material.Cantidad = int.Parse(txt_Cantidad.Text.ToString());
            lstMateriales.Add(Material);
            copia_lstMateriales.Add(Material);

            foreach (MMaterialSelect datoM in lstMateriales)
            {
                indexDt = dataGrid_MaterialPed.Rows.Add();
                dataGrid_MaterialPed.Rows[indexDt].Cells[0].Value = datoM.NomMaterial;
                dataGrid_MaterialPed.Rows[indexDt].Cells[1].Value = datoM.Cantidad;
            }
        }

        private List<MMaterialSelect> idetificarMaterial()
        {
            DatosMateriales funcoinMateriales = new DatosMateriales();
            List<MMateriales> datosMat = funcoinMateriales.MostrarMateriales(this.idCateg);

            
            List<MMaterialSelect> MatSelect = new List<MMaterialSelect>();

            foreach (MMaterialSelect mat in copia_lstMateriales) 
            {
                foreach(MMateriales dato in datosMat)
                {
                    if(mat.NomMaterial == dato.Nombre)
                    {
                        mat.idMaterial = dato.IdMaterial;
                        MatSelect.Add(mat);
                    }
                } 
            }
            return MatSelect;
        }

        private void btnAgrPedido_Click(object sender, EventArgs e)
        {
            List<int> lstIdMatSelect = new List<int>();
            List<MMaterialSelect> MaterialSelect = idetificarMaterial();
            RDN_Pedidos reglaPedido = new RDN_Pedidos();
            RDN_MaterialSelect reglaMatSelec = new RDN_MaterialSelect();
            RDN_Salidas reglaSalidas = new RDN_Salidas();
            MPedidos Pedido = new MPedidos();
            DatosSalidas dtosSal = new DatosSalidas();

            Pedido.DetallePedido = richTextBox_Detalle.Text;
            Pedido.Categoria = this.idCateg;
            Pedido.NomPedido = txt_NomPedido.Text;
            Pedido.FechaPedido = DateTime.Now;

            int IdPedido = reglaPedido.IdPedido(Pedido);

            foreach (MMaterialSelect mat in MaterialSelect)
            {
                int idMatSelect = reglaMatSelec.IdMaterial(mat, IdPedido, this.idCateg);
                reglaSalidas.capSalidas(idMatSelect);
            }

            recargarPantalla();
        }

        public void mostrarPedido()
        {
            DatosPedidos funcionPedidos = new DatosPedidos();
            List<MPedidos> Pedidos = funcionPedidos.MostrarPedido(this.idCateg); ;

            int index;

            foreach (MPedidos datos in Pedidos)
            {
                index = dataGrid_Pedidos.Rows.Add();
                dataGrid_Pedidos.Rows[index].Cells[1].Value = datos.IdPedido;
                dataGrid_Pedidos.Rows[index].Cells[2].Value = datos.NomPedido;
                dataGrid_Pedidos.Rows[index].Cells[3].Value = datos.DetallePedido;
                dataGrid_Pedidos.Rows[index].Cells[4].Value = datos.FechaPedido;
            }
        }

        public void recargarPantalla()
        {
            this.Hide();
            PEDIDOS formPedido = new PEDIDOS(this.idCateg);
            formPedido.Show();
        }

        private void cb_Materiales_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cb_Materiales_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatosMateriales funcionMateriales = new DatosMateriales();

            List<MMateriales> lstMateriales = funcionMateriales.MostrarMateriales(this.idCateg);

            int index = cb_Materiales.SelectedIndex;
            dynamic material = cb_Materiales.Items[index].ToString();

            foreach (MMateriales Material in lstMateriales)
            {
                if (Material.Nombre == material)
                {
                    lbl_cantidadDisp.Text = Material.Cantidad.ToString();
                    break;
                }
            }
        }
    }
}
