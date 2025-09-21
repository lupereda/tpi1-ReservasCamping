using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasCamping.BE.entidades
{
    public class Reserva
    {
        public int IdReserva { get; set; }
        public int IdHuesped { get; set; }
        public int IdParcela { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int CantidadPersonas { get; set; }
        public decimal? MontoTotal { get; set; }
        public string Estado { get; set; }

        // Navegación
        public Huesped Huesped { get; set; }
        public Parcela Parcela { get; set; }

        public override string ToString()
        {
            return $"Reserva {IdReserva} - {Estado}";
        }
    }
}
