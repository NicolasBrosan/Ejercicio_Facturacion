using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDePOO_Nico
{
    public class Cliente
    {
        public int Documento { get; set; }
        public string NombreCompleto { get; set; }
        public int NumeroCliente { get; set; }

        public Cliente(int documento, string nombreCompleto, int numeroCliente)
        {
            Documento = documento;
            NombreCompleto = nombreCompleto;
            NumeroCliente = numeroCliente;
        }
    }
}
