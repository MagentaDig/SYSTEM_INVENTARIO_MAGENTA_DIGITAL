using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SYSTEM_INVENTARIO_MAGENTA_DIGITAL.ACCESO;

namespace SYSTEM_INVENTARIO_MAGENTA_DIGITAL
{
    public partial class INGRESOUSUARIO : Form
    {
        public INGRESOUSUARIO()
        {
            InitializeComponent();
        }

        private void lbl_categoria_Click(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {

        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            Login log = new Login();

            dynamic usuario = txt_usuario.Text;
            dynamic pass = txt_contraseña.Text;

            bool acceso = log.validarLogin(usuario, pass);

            if (acceso)
            {
                this.Hide();
                INGRESO formIngreso = new INGRESO();
                formIngreso.Show();
            }
        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_contraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
