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

namespace SYSTEM_INVENTARIO_MAGENTA_DIGITAL
{

    public partial class ACTUALIZAR : Form
    {
        public int idMaterial;
        public int Categ;
        public ACTUALIZAR(int Material, int IdCateg)
        {
            InitializeComponent();
            this.idMaterial = Material;
            this.Categ = IdCateg;
            MostraDatosMaterial();
            MostrarDatosStock();

            //lbl_Material.Text = Material.ToString();
        }


        public void MostraDatosMaterial()
        {
            //DatosStock funcionStock = new DatosStock();
            //List<MConsultaStock> lstStock = funcionStock.StockMaterial(this.IdCateg, this.idMaterial);

            //foreach (MConsultaStock dato in lstStock)
            //{
            //    lbl_Material.Text = dato.Nombre;
            //    lbl_StockSAct.Text = dato.Cantidad.ToString();
            //}

        }

        private void ACTUALIZAR_Load(object sender, EventArgs e)
        {

        }

        private void btn_Act_Click(object sender, EventArgs e)
        {
            DatosStock funcionStock = new DatosStock();

            MStock Stock = new MStock();
            Stock.Cantidad = int.Parse(txt_NuevoStock.Text);
            Stock.FechaEntrada = DateTime.Now;
            Stock.Material = this.idMaterial;
            Stock.StockDisp = int.Parse(txt_NuevoStock.Text);

            funcionStock.AgregarStock(Stock);

            MessageBox.Show("Los datos se actualizaron correctamente");
            this.Close();
        }

        public void MostrarDatosStock()
        {
            datosLabel();
            DatosStock funcionStock = new DatosStock();
            List<MStock> lstStock = funcionStock.ConsultarStock(this.idMaterial);

            int index;

            foreach (MStock datos in lstStock)
            {
                index = dataGrid_Stock.Rows.Add();
                dataGrid_Stock.Rows[index].Cells[0].Value = datos.idStock;
                dataGrid_Stock.Rows[index].Cells[1].Value = datos.Cantidad;
                dataGrid_Stock.Rows[index].Cells[2].Value = datos.StockDisp;
                dataGrid_Stock.Rows[index].Cells[3].Value = datos.FechaEntrada;
            }
        }

        public void datosLabel()
        {
            DatosMateriales funcionMateriales = new DatosMateriales();

            List<MMateriales> lstMateriales = funcionMateriales.TablaMateriales(this.Categ);

            foreach (MMateriales material in lstMateriales)
            {
                if(material.IdMaterial == this.idMaterial)
                {
                    lbl_Material.Text = material.Nombre;
                    lbl_noSerie.Text = material.NoSerie;
                    break;
                }
                
            }
        }
    }


}
