using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDePOO_Nico
{
    public class Producto
    {
        public string Descripcion { get; set; }
        public int Id { get; set; }
        public int Precio { get; set; }

        public Producto(string descripcion, int id, int precio)
        {
            Descripcion = descripcion;
            Id = id;
            Precio = precio;
        }
    }
}
