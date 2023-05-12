using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SYSTEM_INVENTARIO_MAGENTA_DIGITAL.DATOS;
using System.Windows.Forms;


namespace SYSTEM_INVENTARIO_MAGENTA_DIGITAL.RDN
{
    class RDN_MATERIALES
    {
        public void ElimnarMaterial (int IdMaterial, int Estatus)
        {
            DatosMateriales funcionMateriales = new DatosMateriales();

            funcionMateriales.EstatusMaterial(IdMaterial, Estatus);
        }
    }
}
