using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SYSTEM_INVENTARIO_MAGENTA_DIGITAL.MODELOS;
using SYSTEM_INVENTARIO_MAGENTA_DIGITAL.DATOS;

namespace SYSTEM_INVENTARIO_MAGENTA_DIGITAL.RDN
{
    class RDN_Salidas
    {
        DatosSalidas funcionSalidas = new DatosSalidas();
        public void capSalidas(int IdMatSelec)
        {
            DatosSalidas funcionSalidas = new DatosSalidas();

            MSalidas Salidas = new MSalidas();
            Salidas.MaterialSelec = IdMatSelec;
            Salidas.FechaSalida = DateTime.Now;
            funcionSalidas.RegSalida(Salidas);
        }
    }
}
