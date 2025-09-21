using ReservasCamping.BE.entidades;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ReservasCamping_DAL
{
    public class HuespedDAL
    {
        private readonly ConnectionDAL.Acceso _acceso;

        public HuespedDAL(ConnectionDAL.Acceso acceso)
        {
            _acceso = acceso;
        }

        public List<Huesped> GetAll()
        {
            var lista = new List<Huesped>();
            using (var conn = _acceso.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT * FROM Huespedes", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Huesped
                    {
                        IdHuesped = (int)reader["IdHuesped"],
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        DNI = reader["DNI"].ToString(),
                        Telefono = reader["Telefono"].ToString(),
                        Email = reader["Email"].ToString()
                    });
                }
            }
            return lista;
        }
    }
}
