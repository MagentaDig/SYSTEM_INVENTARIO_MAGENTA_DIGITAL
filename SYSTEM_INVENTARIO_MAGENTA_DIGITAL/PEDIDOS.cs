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
            //RDN_Salidas reglsSalida = new RDN_Salidas();

            //lstSalidas = reglsSalida.capSalidas(int.Parse(txt_Cantidad.Text));

            List<MMaterialSelect> lstMateriales = new List<MMaterialSelect>();
            //MMateriales objMaterial = new MMateriales();

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

            //foreach (MMateriales datoM in lstMateriales)
            //{
            //    indexDt = dataGrid_MaterialPed.Rows.Add();
            //    dataGrid_MaterialPed.Rows[indexDt].Cells[0].Value = datoM.Nombre;
            //    foreach (MSalidas sal in lstSalidas)
            //    {
            //        MSalidas capSalida = new MSalidas();

            //        dataGrid_MaterialPed.Rows[indexDt].Cells[1].Value = sal.Cantidad;

            //        capSalida.Cantidad = sal.Cantidad;
            //        capSalida.FechaSalida = sal.FechaSalida;
            //        copia_lstSalidas.Add(capSalida);
            //    }
            //}
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
                        //MMateriales Material = new MMateriales();
                        //Material.IdMaterial = dato.IdMaterial;
                        MatSelect.Add(mat);
                    }
                } 
            }
            return MatSelect;
        }

        //private List<MSalidas> capSalidas()
        //{
        //    MSalidas Salidas = new MSalidas();
        //    Salidas.Cantidad = int.Parse(txt_Cantidad.Text);
        //    Salidas.FechaSalida = DateTime.Now;
        //    SalidasMaterial.Add(Salidas);

        //    return SalidasMaterial;
        //}

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

            int IdPedido = reglaPedido.IdPedido(Pedido);

            foreach (MMaterialSelect mat in MaterialSelect)
            {
                int idMatSelect = reglaMatSelec.IdMaterial(mat, IdPedido, this.idCateg);
                lstIdMatSelect.Add(idMatSelect);


            }

            dtosSal.RegSalida(lstIdMatSelect);
        }
    }
}
