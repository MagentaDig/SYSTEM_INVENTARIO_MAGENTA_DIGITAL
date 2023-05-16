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
using System.Globalization;

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
        public dynamic Categoria;
        public PEDIDOS(int idCateg, dynamic nomCateg)
        {
            InitializeComponent();
            this.idCateg = idCateg;
            this.Categoria = nomCateg;


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
            INICIO formInicio = new INICIO(this.idCateg, this.Categoria);
            formInicio.lbl_categoriaSelect.Text = this.Categoria;
            formInicio.Show();
        }

        private void btn_AgrMat_Click(object sender, EventArgs e)
        {
            MMaterialSelect Material = new MMaterialSelect();
            List<MMaterialSelect> lstMateriales = new List<MMaterialSelect>();


            if (cb_Materiales.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un material");
            }
            else
            {
                if (string.IsNullOrEmpty(txt_Cantidad.Text))
                {
                    MessageBox.Show("Debe ingresar la cantidad del material para proceder a agregarlo");
                }
                else
                {
                    if (cb_Materiales.SelectedIndex == -1 && string.IsNullOrEmpty(txt_Cantidad.Text))
                    {
                        MessageBox.Show("Debe seleccionar un material y ingresar la cantidad");
                    }
                    else
                    {
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
                            //if (copia_lstMateriales.Count != 0)
                            //{
                            //    foreach (MMaterialSelect Mat in copia_lstMateriales)
                            //    {
                            //        if (Mat.NomMaterial == Material.NomMaterial)
                            //        {
                            //            MessageBox.Show("El material seleccionado ya esta dentro de la lista");
                            //        }
                            //        else
                            //        {
                            //            lstMateriales.Add(Material);
                            //            copia_lstMateriales.Add(Material);
                            //            foreach (MMaterialSelect datoM in lstMateriales)
                            //            {
                            //                indexDt = dataGrid_MaterialPed.Rows.Add();
                            //                dataGrid_MaterialPed.Rows[indexDt].Cells[0].Value = datoM.NomMaterial;
                            //                dataGrid_MaterialPed.Rows[indexDt].Cells[1].Value = datoM.Cantidad;
                            //            }
                            //        }
                            //    }
                            //}
                            //else
                            //{
                            //    lstMateriales.Add(Material);
                            //    copia_lstMateriales.Add(Material);
                            //    foreach (MMaterialSelect datoM in lstMateriales)
                            //    {
                            //        indexDt = dataGrid_MaterialPed.Rows.Add();
                            //        dataGrid_MaterialPed.Rows[indexDt].Cells[0].Value = datoM.NomMaterial;
                            //        dataGrid_MaterialPed.Rows[indexDt].Cells[1].Value = datoM.Cantidad;
                            //    }
                            //}
                        }
                }
            }
        }

        private List<MMaterialSelect> idetificarMaterial()
        {
            DatosMateriales funcoinMateriales = new DatosMateriales();
            List<MMateriales> datosMat = funcoinMateriales.TablaMateriales(this.idCateg);


            List<MMaterialSelect> MatSelect = new List<MMaterialSelect>();

            foreach (MMaterialSelect mat in copia_lstMateriales)
            {
                foreach (MMateriales dato in datosMat)
                {
                    if (mat.NomMaterial == dato.Nombre)
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

            List<MMaterialSelect> MaterialSelect = idetificarMaterial();
            RDN_Pedidos reglaPedido = new RDN_Pedidos();
            RDN_MaterialSelect reglaMatSelec = new RDN_MaterialSelect();
            MPedidos Pedido = new MPedidos();
            if (MaterialSelect.Count != 0)
            {
                if (string.IsNullOrEmpty(txt_NomPedido.Text))
                {
                    MessageBox.Show("Debe ingresar un nombre para el pedido");
                }
                else
                {

                    Pedido.DetallePedido = richTextBox_Detalle.Text;
                    Pedido.Categoria = this.idCateg;
                    Pedido.NomPedido = txt_NomPedido.Text;
                    Pedido.FechaPedido = DateTime.Now;
                    Pedido.FechaEntrega = DateTime.Now; ;
                    Pedido.IsEntregado = 0;

                    int IdPedido = reglaPedido.IdPedido(Pedido);

                    foreach (MMaterialSelect mat in MaterialSelect)
                    {
                        reglaMatSelec.IdMaterial(mat, IdPedido, mat.Cantidad);

                    }

                    recargarPantalla();
                }

            }
            else
            {
                MessageBox.Show("No se han seleccionado materiales para el peedido");
            }

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
                dataGrid_Pedidos.Rows[index].Cells[2].Value = datos.FechaPedido;
                dataGrid_Pedidos.Rows[index].Cells[3].Value = datos.FechaEntrega;

                if (datos.IsEntregado == 1)
                {
                    dataGrid_Pedidos.Rows[index].Cells[4].Value = "Entregado";
                }
                else
                {
                    dataGrid_Pedidos.Rows[index].Cells[4].Value = "En proceso";
                }



            }
        }

        public void recargarPantalla()
        {
            this.Hide();
            PEDIDOS formPedido = new PEDIDOS(this.idCateg, this.Categoria);
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
            MODIFICAR formModificar = new MODIFICAR(this.idCateg, this.Categoria);
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
                DatosPedidos funcionPedidp = new DatosPedidos();
                idPed = Convert.ToInt32(dataGrid_Pedidos.CurrentRow.Cells["id_pedido"].Value.ToString());

                List<MPedidos> Pedidos = funcionPedidp.consultarPedidos(this.idCateg, idPed);


                foreach (MPedidos Ped in Pedidos)
                {
                    if (Ped.IsEntregado == 0)
                    {
                        RDN_Stock reglaStock = new RDN_Stock();
                        reglaStock.RestaurarStock(idPed, this.idCateg);

                        MessageBox.Show("El pedido se elimino correctamente");
                        recargarPantalla();
                    }
                    else
                    {
                        MessageBox.Show("Ya se registro la entrega del pedido, \nno se puede proceder a elimnarlo");
                    }
                }



            }
            else if (dataGrid_Pedidos.Columns[e.ColumnIndex].Name == "entregado")
            {
                DatosPedidos funcionPedidp = new DatosPedidos();
                idPed = Convert.ToInt32(dataGrid_Pedidos.CurrentRow.Cells["id_pedido"].Value.ToString());

                List<MPedidos> Pedidos = funcionPedidp.consultarPedidos(this.idCateg, idPed);

                foreach (MPedidos Ped in Pedidos)
                {
                    if (Ped.IsEntregado == 0)
                    {
                        ENTREGA formEntrega = new ENTREGA(idPed);
                        formEntrega.ShowDialog();
                        recargarPantalla();
                    }
                    else
                    {
                        MessageBox.Show("Ya se registro la entrega de este pedido");
                    }
                }


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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            INICIO formInicio = new INICIO(this.idCateg, this.Categoria);
            formInicio.lbl_categoriaSelect.Text = this.Categoria;
            formInicio.Show();
        }

        private void pictureBox_Buscar_Click(object sender, EventArgs e)
        {
            DatosPedidos funcionPedidp = new DatosPedidos();
            int idPedido = int.Parse(textBox_Idpedido.Text.ToString());

            List<MPedidos> Pedidos = funcionPedidp.consultarPedidos(this.idCateg, idPedido);

            int index;
            dataGrid_Pedidos.Rows.Clear();
            foreach (MPedidos datos in Pedidos)
            {
                index = dataGrid_Pedidos.Rows.Add();
                dataGrid_Pedidos.Rows[index].Cells[0].Value = datos.IdPedido;
                dataGrid_Pedidos.Rows[index].Cells[1].Value = datos.NomPedido;
                dataGrid_Pedidos.Rows[index].Cells[2].Value = datos.FechaPedido;
                dataGrid_Pedidos.Rows[index].Cells[3].Value = datos.FechaEntrega;

                if (datos.IsEntregado == 1)
                {
                    dataGrid_Pedidos.Rows[index].Cells[4].Value = "Entregado";
                }
                else
                {
                    dataGrid_Pedidos.Rows[index].Cells[4].Value = "En proceso";
                }

            }
        }

        private void pictureBox_Reset_Click(object sender, EventArgs e)
        {
            textBox_Idpedido.Clear();
            dataGrid_Pedidos.Rows.Clear();
            mostrarPedido();
        }

        private void pictureBox_limpiar_Click(object sender, EventArgs e)
        {
            dataGrid_MaterialPed.Rows.Clear();
            copia_lstMateriales.Clear();
        }
    }
}
