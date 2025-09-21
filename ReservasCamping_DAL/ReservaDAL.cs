using ReservasCamping.BE.entidades;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace ReservasCamping_DAL
{
    public class ReservaDAL
    {
        private readonly ConnectionDAL.Acceso _acceso;

        public ReservaDAL(ConnectionDAL.Acceso acceso)
        {
            _acceso = acceso;
        }

        public List<Reserva> GetAll()
        {
            var lista = new List<Reserva>();
            using (var conn = _acceso.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT * FROM Reservas", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Reserva
                    {
                        IdReserva = (int)reader["IdReserva"],
                        IdHuesped = (int)reader["IdHuesped"],
                        IdParcela = (int)reader["IdParcela"],
                        FechaInicio = (System.DateTime)reader["FechaInicio"],
                        FechaFin = (System.DateTime)reader["FechaFin"],
                        CantidadPersonas = (int)reader["CantidadPersonas"],
                        MontoTotal = reader["MontoTotal"] as decimal?,
                        Estado = reader["Estado"].ToString()
                    });
                }
            }
            return lista;
        }

        public void Insert(Reserva reserva)
        {
            using (var conn = _acceso.GetConnection())
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                var cmd = new SqlCommand(
                    "INSERT INTO Reservas (IdHuesped, IdParcela, FechaInicio, FechaFin, CantidadPersonas, MontoTotal, Estado) " +
                    "VALUES (@IdHuesped, @IdParcela, @FechaInicio, @FechaFin, @CantidadPersonas, @MontoTotal, @Estado)", conn);

                cmd.Parameters.AddWithValue("@IdHuesped", reserva.IdHuesped);
                cmd.Parameters.AddWithValue("@IdParcela", reserva.IdParcela);
                cmd.Parameters.AddWithValue("@FechaInicio", reserva.FechaInicio);
                cmd.Parameters.AddWithValue("@FechaFin", reserva.FechaFin);
                cmd.Parameters.AddWithValue("@CantidadPersonas", reserva.CantidadPersonas);
                cmd.Parameters.AddWithValue("@MontoTotal", (object)reserva.MontoTotal);
                cmd.Parameters.AddWithValue("@Estado", reserva.Estado);

                cmd.ExecuteNonQuery();
            }
        }
    }

}
