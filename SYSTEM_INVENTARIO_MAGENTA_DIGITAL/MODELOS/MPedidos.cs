using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSTEM_INVENTARIO_MAGENTA_DIGITAL.MODELOS
{
    class MPedidos
    {
        public int IdPedido { get; set; }
        public dynamic DetallePedido { get; set; }
        public dynamic Categoria { get; set; }
        public dynamic NomPedido { get; set; }
        public DateTime FechaPedido { get; set; }
    }

    class MDetallePedido
    {
        public int idPedido { get; set; }
        public dynamic NomPedido { get; set; }
        public int Material { get; set; }
        public dynamic NomMaterial { get; set; }
        public dynamic NoSerie { get; set; }
        public int Cantidad { get; set; }
    }
}
