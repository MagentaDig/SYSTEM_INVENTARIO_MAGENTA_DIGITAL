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
        List<MSalidas> copia_SalidasMaterial = new List<MSalidas>();
        List<MSalidas> SalidasMaterial = new List<MSalidas>();
        public List<MSalidas> capSalidas(int cantidad)
        {
            MSalidas Salidas = new MSalidas();
            Salidas.Cantidad = cantidad;
            Salidas.FechaSalida = DateTime.Now;
            SalidasMaterial.Add(Salidas);

            return SalidasMaterial;
        }

        //public int regSalida()
        //{
        //    datos
        //}
    }
}
