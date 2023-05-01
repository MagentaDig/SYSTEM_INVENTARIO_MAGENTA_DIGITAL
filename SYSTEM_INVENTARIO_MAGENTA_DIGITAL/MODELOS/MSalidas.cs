using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSTEM_INVENTARIO_MAGENTA_DIGITAL.MODELOS
{
    class MSalidas
    {
        public int IdSalida { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaSalida { get; set; }
        public dynamic MaterialSelec { get; set; }
    }
}
