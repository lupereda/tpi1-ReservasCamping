using ReservasCamping_DAL;
using ReservasCamping.BE.entidades;
using System.Collections.Generic;

namespace ReservasCamping_BLL
{
    public class ReservaBLL
    {
        private readonly ReservaDAL _reservaDAL;

        public ReservaBLL(ConnectionDAL.Acceso acceso)
        {
            _reservaDAL = new ReservaDAL(acceso);
        }

        public List<Reserva> ObtenerReservas()
        {
            // agregar validaciones o reglas de negocio
            return _reservaDAL.GetAll();
        }

        public void AgregarReserva(Reserva reserva)
        {
            if (reserva.FechaFin <= reserva.FechaInicio)
                throw new System.ArgumentException("La fecha de fin debe ser posterior a la fecha de inicio.");

            _reservaDAL.Insert(reserva);
        }

        // Otros métodos de negocio (Actualizar, Eliminar, etc.)
    }
}