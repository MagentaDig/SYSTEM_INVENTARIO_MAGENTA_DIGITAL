using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSTEM_INVENTARIO_MAGENTA_DIGITAL.MODELOS
{
    class MStock
    {
        public int idStock { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaEntrada { get; set; }
        public dynamic Material { get; set; }
    }
}
