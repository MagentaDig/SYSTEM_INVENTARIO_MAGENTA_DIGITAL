using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYSTEM_INVENTARIO_MAGENTA_DIGITAL.ACCESO
{
    class Login
    {
        private dynamic usuario = "usAdmin";
        private dynamic contraseña = "Passw0rd";
        /**/
        public bool validarLogin(dynamic user, dynamic pass)
        {
            bool login = false;
            if (user == usuario)
            {
                if (pass == contraseña)
                {
                    login = true;
                }
                else
                {
                    MessageBox.Show("La contaseña ingresada es incorrecta");
                }
            }
            else
            {
                MessageBox.Show("El usuario ingresado es incorrecto");
            }

            return login;
        }
    }
}
