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
        public int StockDisp { get; set; }
    }

    class MConsultaStock
    {
        public int IdMaterial { get; set; }
        public dynamic Nombre { get; set; }
        public decimal Metros { get; set; }
        public dynamic Tamaño { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaEntrada { get; set; }
    }
}
