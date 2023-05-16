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
using SYSTEM_INVENTARIO_MAGENTA_DIGITAL.AVISOS;

namespace SYSTEM_INVENTARIO_MAGENTA_DIGITAL
{
    public partial class MODIFICAR : Form
    {
        public int idCateg;
        public dynamic Categoria;
        public MODIFICAR(int Categ, dynamic nomCateg)
        {
            InitializeComponent();
            this.idCateg = Categ;
            this.Categoria = nomCateg;
            MostrarStock();
            MaterialesCB();
        }

        public void MostrarStock()
        {
            DatosMateriales funcionMateriales = new DatosMateriales();
            List<MMateriales> lstMateriales = funcionMateriales.TablaMateriales(this.idCateg);

            int index;
            dataGrid_Stock.Rows.Clear();
            foreach (MMateriales datos in lstMateriales)
            {
                index = dataGrid_Stock.Rows.Add();
                dataGrid_Stock.Rows[index].Cells[0].Value = datos.IdMaterial;
                dataGrid_Stock.Rows[index].Cells[1].Value = datos.Nombre;
                dataGrid_Stock.Rows[index].Cells[2].Value = datos.NoSerie;
                dataGrid_Stock.Rows[index].Cells[3].Value = datos.Metros;
                dataGrid_Stock.Rows[index].Cells[4].Value = datos.Tamaño;

            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            INICIO formInicio = new INICIO(this.idCateg, this.Categoria);
            formInicio.lbl_categoriaSelect.Text = this.Categoria;
            formInicio.Show();
        }

        int idMat;
        private void dataGrid_Stock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGrid_Stock.Columns[e.ColumnIndex].Name == "stock")
            {
                idMat = Convert.ToInt32(dataGrid_Stock.CurrentRow.Cells["Id_Materia"].Value.ToString());
                ACTUALIZAR formActu = new ACTUALIZAR(idMat, this.idCateg);
                formActu.ShowDialog();
                recargarPantalla();
            }
            else if (dataGrid_Stock.Columns[e.ColumnIndex].Name == "ELIMINAR")
            {
                idMat = Convert.ToInt32(dataGrid_Stock.CurrentRow.Cells["Id_Materia"].Value.ToString());
                ELIMINAR_MATERIAL formElimanrMat = new ELIMINAR_MATERIAL(idMat, this.idCateg, this.Categoria);
                formElimanrMat.ShowDialog();
                recargarPantalla();
            }
        }

        public void recargarPantalla()
        {
            this.Hide();
            MODIFICAR fomModificar = new MODIFICAR(this.idCateg, this.Categoria);
            fomModificar.Show();
        }

        private void link_MaterialesInac_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MATERIALES_INACTIVOS formMaterialesInac = new MATERIALES_INACTIVOS(this.idCateg, this.Categoria);
            formMaterialesInac.ShowDialog();
            recargarPantalla();
        }

        public void MaterialesCB()
        {
            DatosMateriales funcionMateriales = new DatosMateriales();

            List<MMateriales> lstMateriales = funcionMateriales.MostrarMateriales(this.idCateg);

            foreach (MMateriales material in lstMateriales)
            {
                cb_materialesBusc.Items.Add(material.Nombre);
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            DatosMateriales funcionMateriales = new DatosMateriales();
            if(cb_materialesBusc.SelectedIndex != -1)
            {
                int index = cb_materialesBusc.SelectedIndex;
                dynamic material = cb_materialesBusc.Items[index].ToString();
                dynamic noSerie = txt_noSerie.Text;

                List<MMateriales> lstMateriales = funcionMateriales.BusquedaMateriales(this.idCateg, material, noSerie);

                int indexTable;
                dataGrid_Stock.Rows.Clear();
                foreach (MMateriales datos in lstMateriales)
                {
                    indexTable = dataGrid_Stock.Rows.Add();
                    dataGrid_Stock.Rows[indexTable].Cells[0].Value = datos.IdMaterial;
                    dataGrid_Stock.Rows[indexTable].Cells[1].Value = datos.Nombre;
                    dataGrid_Stock.Rows[indexTable].Cells[2].Value = datos.NoSerie;
                    dataGrid_Stock.Rows[indexTable].Cells[3].Value = datos.Metros;
                    dataGrid_Stock.Rows[indexTable].Cells[4].Value = datos.Tamaño;

                }
            }
            else
            {
                dynamic noSerie = txt_noSerie.Text;

                List<MMateriales> lstMateriales = funcionMateriales.BusquedaMateriales(this.idCateg, "", noSerie);

                int indexTable;
                dataGrid_Stock.Rows.Clear();
                foreach (MMateriales datos in lstMateriales)
                {
                    indexTable = dataGrid_Stock.Rows.Add();
                    dataGrid_Stock.Rows[indexTable].Cells[0].Value = datos.IdMaterial;
                    dataGrid_Stock.Rows[indexTable].Cells[1].Value = datos.Nombre;
                    dataGrid_Stock.Rows[indexTable].Cells[2].Value = datos.NoSerie;
                    dataGrid_Stock.Rows[indexTable].Cells[3].Value = datos.Metros;
                    dataGrid_Stock.Rows[indexTable].Cells[4].Value = datos.Tamaño;
                }
            }
            
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {

            txt_noSerie.Clear();
            MostrarStock();

        }

        private void pictureBox_Reg_Click(object sender, EventArgs e)
        {
            this.Hide();
            INICIO formInicio = new INICIO(this.idCateg, this.Categoria);
            formInicio.lbl_categoriaSelect.Text = this.Categoria;
            formInicio.Show();
        }
    }
}
