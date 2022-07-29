using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDePOO_Nico
{
    public class DetalleFactura
    {
        public int Cantidad { get; set; }

        public Producto Producto { get; set; }

        public DetalleFactura(int cantidad, Producto producto)//"ctor - TAB TAB"
        {
            this.Cantidad = cantidad;
            this.Producto = producto;
        }

        public double SubTotal()
        {
            return Producto.Precio * Cantidad;
        }

    }
       
}
