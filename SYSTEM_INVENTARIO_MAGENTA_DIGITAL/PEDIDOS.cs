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
            mostrarPedido();
            
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
            //bool canValida = validarCantidad();
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
            List<MMateriales> datosMat = funcoinMateriales.TablaMateriales(this.idCateg);

            
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
            //List<int> lstIdMatSelect = new List<int>();
            List<MMaterialSelect> MaterialSelect = idetificarMaterial();
            RDN_Pedidos reglaPedido = new RDN_Pedidos();
            RDN_MaterialSelect reglaMatSelec = new RDN_MaterialSelect();
            //RDN_Salidas reglaSalidas = new RDN_Salidas();
            MPedidos Pedido = new MPedidos();
            //DatosSalidas dtosSal = new DatosSalidas();

            Pedido.DetallePedido = richTextBox_Detalle.Text;
            Pedido.Categoria = this.idCateg;
            Pedido.NomPedido = txt_NomPedido.Text;
            Pedido.FechaPedido = DateTime.Now;

            int IdPedido = reglaPedido.IdPedido(Pedido);

            foreach (MMaterialSelect mat in MaterialSelect)
            {
                reglaMatSelec.IdMaterial(mat, IdPedido, mat.Cantidad);
                //reglaSalidas.capSalidas(idMatSelect);
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
                dataGrid_Pedidos.Rows[index].Cells[0].Value = datos.IdPedido;
                dataGrid_Pedidos.Rows[index].Cells[1].Value = datos.NomPedido;
                dataGrid_Pedidos.Rows[index].Cells[2].Value = datos.DetallePedido;
                dataGrid_Pedidos.Rows[index].Cells[3].Value = datos.FechaPedido;
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
                    lbl_noSerie.Text = Material.NoSerie;
                    if (lbl_cantidadDisp.Text == "0")
                    {
                        btnAgrPedido.Enabled = false;
                    }
                    else
                    {
                        btnAgrPedido.Enabled = true;
                    }
                    break;
                }
            }
        }

        private void link_AgrStock_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            MODIFICAR formModificar = new MODIFICAR(this.idCateg);
            formModificar.Show();

        }

        public void validarCantidad()
        {
            //bool cantValida = true;
            //btn_AgrMat.Enabled = true;
            //if (int.Parse(txt_Cantidad.Text.ToString()) > int.Parse(lbl_cantidadDisp.Text.ToString()))
            //{
            //    btn_AgrMat.Enabled = false;
            //    cantValida = false;
            //}

            //return cantValida;
        }

        private void dataGrid_Pedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idPed = 0;
            if (dataGrid_Pedidos.Columns[e.ColumnIndex].Name == "verPedido")
            {
                idPed = Convert.ToInt32(dataGrid_Pedidos.CurrentRow.Cells["id_pedido"].Value.ToString());
                string nomPed = (dataGrid_Pedidos.CurrentRow.Cells["nomPedido"].Value.ToString());
                
                DETALLE_PEDIDO formDp = new DETALLE_PEDIDO(idPed, this.idCateg, nomPed);
                formDp.ShowDialog();
            }
            else if (dataGrid_Pedidos.Columns[e.ColumnIndex].Name == "eliminarPed")
            {
                idPed = Convert.ToInt32(dataGrid_Pedidos.CurrentRow.Cells["id_pedido"].Value.ToString());
                RDN_Stock reglaStock = new RDN_Stock();
                reglaStock.RestaurarStock(idPed,this.idCateg);

                MessageBox.Show("El pedido se elimino correctamente");
                recargarPantalla();
            }
        }

        private void txt_Cantidad_Validated(object sender, EventArgs e)
        {
            btnAgrPedido.Enabled = true;
            btn_AgrMat.Enabled = true;
            if (int.Parse(txt_Cantidad.Text.ToString()) > int.Parse(lbl_cantidadDisp.Text.ToString()))
            {
                btn_AgrMat.Enabled = false;
                btnAgrPedido.Enabled = false;
                MessageBox.Show("La cantidad ingresada no es valida. \nEs mayor al Stock disponible.");
            }
        }

        private void dataGrid_Pedidos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGrid_Pedidos.Columns[e.ColumnIndex].Name == "entregado")
            {
                
            }
        }

        private void dataGrid_Pedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridViewCheckBoxCell celdaCheck = (DataGridViewCheckBoxCell)dataGrid_Pedidos.Rows[e.RowIndex].Cells["entregado"].Value;
            //DataGridViewImageCell celdaIMg = (DataGridViewImageCell)dataGrid_Pedidos.Rows[e.RowIndex].Cells["eliminarPed"].Value;
        }
    }
}
