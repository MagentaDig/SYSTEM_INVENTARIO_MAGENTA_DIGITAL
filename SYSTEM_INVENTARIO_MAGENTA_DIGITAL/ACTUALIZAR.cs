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
        public int IdCateg;
        public ACTUALIZAR(int Material, int IdCateg)
        {
            InitializeComponent();
            this.idMaterial = Material;
            this.IdCateg = IdCateg;
            MostraDatosMaterial();

            //lbl_Material.Text = Material.ToString();
        }


        public void MostraDatosMaterial()
        {
            DatosStock funcionStock = new DatosStock();
            List<MConsultaStock> lstStock = funcionStock.StockMaterial(this.IdCateg, this.idMaterial);

            foreach (MConsultaStock dato in lstStock)
            {
                lbl_Material.Text = dato.Nombre;
                lbl_StockSAct.Text = dato.Cantidad.ToString();
            }

        }

        private void ACTUALIZAR_Load(object sender, EventArgs e)
        {

        }

        private void btn_Act_Click(object sender, EventArgs e)
        {
            RDN_Stock reglaStock = new RDN_Stock();

            int nuevoStock = int.Parse(txt_NuevoStock.Text);
            reglaStock.ActulizarStock(nuevoStock,this.idMaterial,this.IdCateg);
        }
    }
}
