using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasCamping.BE.entidades
{
    public class Parcela
    {
        public int IdParcela { get; set; }
        public string Numero { get; set; }
        public int IdTipo { get; set; }
        public string Ubicacion { get; set; }
        public string Estado { get; set; }

        // Navegación
        public TipoParcela TipoParcela { get; set; }

        public override string ToString()
        {
            return $"Parcela {Numero} - {Estado}";
        }
    }
}
