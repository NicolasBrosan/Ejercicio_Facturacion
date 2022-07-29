using EjercicioDePOO_Nico.contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDePOO_Nico
{
    public abstract class Factura : IFactura
    {
        public Cliente Cliente { get; set; }

        public List<DetalleFactura> Detalles { get; set; }       

        public int CantidadItems()
        {
            var result = 0;
            foreach (var detalle in Detalles)
            {
                result+=detalle.Cantidad;
            }
            return result;
        }

        public double Total()
        {
            var result = 0d;

            foreach (var detalle in Detalles)
            {
                result += detalle.SubTotal();
            }
            result *= 1.21;

            return result;
        }
               
       
    }
}
