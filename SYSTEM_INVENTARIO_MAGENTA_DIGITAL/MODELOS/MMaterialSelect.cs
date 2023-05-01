using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSTEM_INVENTARIO_MAGENTA_DIGITAL.MODELOS
{
    class MMaterialSelect
    {
        public int id_MS { get; set; }
        public int idMaterial { get; set; }
        public dynamic NomMaterial { get; set; }
        public int Cantidad { get; set; }
        public int Pedido { get; set; }
    }
}
