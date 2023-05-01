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
        List<MSalidas> lstSalidas = new List<MSalidas>();
        MSalidas Salidas = new MSalidas();
        List<MMateriales> copia_lstMateriales = new List<MMateriales>();

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
            RDN_Salidas reglsSalida = new RDN_Salidas();
            /*Ya captura la cantidad que saldra del material */
            lstSalidas = reglsSalida.capSalidas(int.Parse(txt_Cantidad.Text));

            List<MMateriales> lstMateriales = new List<MMateriales>();
            MMateriales objMaterial = new MMateriales();

            int index = cb_Materiales.SelectedIndex, indexDt;
            objMaterial.Nombre = cb_Materiales.Items[index].ToString();
            lstMateriales.Add(objMaterial);
            copia_lstMateriales.Add(objMaterial);


            foreach (MMateriales datoM in lstMateriales)
            {
                indexDt = dataGrid_MaterialPed.Rows.Add();
                dataGrid_MaterialPed.Rows[indexDt].Cells[0].Value = datoM.Nombre;
                foreach (MSalidas sal in lstSalidas)
                {
                    dataGrid_MaterialPed.Rows[indexDt].Cells[1].Value = sal.Cantidad;
                }
            }
        }

        private List<MMateriales> idetificarMaterial()
        {
            DatosMateriales funcoinMateriales = new DatosMateriales();
            List<MMateriales> datosMat = funcoinMateriales.MostrarMateriales(this.idCateg);

            
            List<MMateriales> idMaterial = new List<MMateriales>();

            foreach (MMateriales mat in copia_lstMateriales) 
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
            List<MMaterialSelect> idMaterialSelect = new List<MMaterialSelect>();
            RDN_Pedidos reglaPedido = new RDN_Pedidos();
            RDN_MaterialSelect reglaMatSelec = new RDN_MaterialSelect();
            DatosSalidas funcionSalidas = new DatosSalidas();

            MPedidos Pedido = new MPedidos();
            Pedido.DetallePedido = richTextBox_Detalle.Text;
            Pedido.Categoria = this.idCateg;

            int IdPedido = reglaPedido.IdPedido(Pedido);

            foreach (MMateriales mat in copia_lstMateriales)
            {
                MMaterialSelect MatSelec = new MMaterialSelect();
                MatSelec.Material = mat.IdMaterial;
                MatSelec.Pedido = IdPedido;

                int idMatSelec = reglaMatSelec.IdMaterial(MatSelec);
                
                foreach (MSalidas sal in lstSalidas)
                {
                    MSalidas Salidas = new MSalidas();
                    Salidas.Cantidad = sal.Cantidad;
                    Salidas.FechaSalida = sal.FechaSalida;
                    Salidas.MaterialSelec = idMatSelec;

                    funcionSalidas.RegSalida(Salidas);
                }
            }
        }
    }
}
