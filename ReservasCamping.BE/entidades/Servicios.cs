using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasCamping.BE.entidades
{
    public class Servicios
    {
        public int IdServicio { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public override string ToString()
        {
            return $"Servicio {IdServicio} - {Descripcion}: ${Precio}";
        }
    }
}
