using ReservasCamping.BE.Abstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservasCamping.BE.entidades
{
   public class Huesped:Persona
    {
        //atributos
        public int IdHuesped { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        //constructor
        public Huesped() { }
        public Huesped(string nombre, string apellido, string dni, string telefono, string email)
            : base(nombre, apellido, dni)
        {
            Telefono = telefono;
            Email = email;
        }
        //metodos
        public override string ToString()
        {
            return $"{GetNombreCompleto()} - DNI: {DNI} - Tel: {Telefono} - Email: {Email}";
        }
        public bool ValidarEmail()
        {
            return !string.IsNullOrWhiteSpace(Email) && Email.Contains("@");
        }
    }

}
