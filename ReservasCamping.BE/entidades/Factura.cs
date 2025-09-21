using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasCamping.BE.entidades
{
    public class Factura

    {
        public int IdFactura { get; set; }
        public int IdReserva { get; set; }
        public DateTime FechaFactura { get; set; }
        public decimal Total { get; set; } 

        public Reserva Reserva { get; set; }
        public override string ToString()
        {
            return $"Factura {IdFactura} - Total: ${Total}";
        }
    }
}
