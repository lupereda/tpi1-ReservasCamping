using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasCamping.BE.entidades
{
    public class TipoParcela
    {
        public int IdTipo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioPorNoche { get; set; }
        public int CapacidadMaxima { get; set; }

        public TipoParcela() { }

        public override string ToString()
        {
            return $"{Nombre} - ${PrecioPorNoche}";
        }
    }
}
