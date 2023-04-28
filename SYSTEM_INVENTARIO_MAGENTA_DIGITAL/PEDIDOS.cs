﻿using System;
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

            SqlDataReader datosMat = Materiales.MostrarMateriales(this.idCateg);

            while (datosMat.Read())
            {
                cb_Materiales.Items.Add(datosMat["Nombre"]);
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

            int index = cb_Materiales.SelectedIndex, indexDt;
            

            objMaterial.Nombre = cb_Materiales.Items[index].ToString();
            objMaterial.Cantidad = int.Parse(txt_Cantidad.Text);
            lstMateriales.Add(objMaterial);

            foreach (MMateriales datoM in lstMateriales)
            {
                indexDt = dataGrid_MaterialPed.Rows.Add();
                dataGrid_MaterialPed.Rows[indexDt].Cells[0].Value = datoM.Nombre;
                dataGrid_MaterialPed.Rows[indexDt].Cells[1].Value = datoM.Cantidad;
            }

        }
    }
}
