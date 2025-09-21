using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasCamping.BE.Abstractas
{
public abstract class Persona
{
        //atributos
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }

        //constructor
        public Persona() { }
        protected Persona(string nombre, string apellido, string dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
        }
        //metodos
        public virtual string GetNombreCompleto()
        {
            return $"{Nombre} {Apellido}";
        }

        public virtual bool ValidarDNI()
        {
            return !string.IsNullOrWhiteSpace(DNI) && DNI.Length >= 7;
        }
    }

}