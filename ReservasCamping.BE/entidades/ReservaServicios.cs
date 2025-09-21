using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasCamping.BE.entidades
{
    public class ReservaServicios
    {
        public int IdReservaServicio { get; set; }
        public int IdReserva { get; set; }
        public int IdServicio { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }
        public Reserva Reserva { get; set; }
        public Servicios Servicio { get; set; }
        public override string ToString()
        {
            return $"ReservaServicio {IdReservaServicio} - Reserva ID: {IdReserva}, Servicio ID: {IdServicio}, Cantidad: {Cantidad}, Subtotal: ${Subtotal}";
        }
    }
}
