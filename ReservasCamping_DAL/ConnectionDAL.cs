using System;
using System.Data.SqlClient;
using System.Data;

namespace ReservasCamping_DAL
{
    public  class ConnectionDAL
    {
        
    public class Acceso
    {
            //declaro el objeto conexion
            private SqlConnection _connection;
            //creo el metodo abrir ,le paso la cadena de conexion
            public void Abrir()
            {
            _connection = new SqlConnection();
                //le paso el connection string
                _connection.ConnectionString = @"Data Source=DESKTOP-4KJH6H4\SQLEXPRESS;Initial Catalog=ReservasCamping;Integrated Security=True";
                _connection.Open();
            }
            //creo el metodo cerrar
            public void Cerrar()
            {
                _connection.Close();
                _connection.Dispose();
                _connection = null;
                GC.Collect();
            }
            //pruebo la conexion
            public string ProbarConexion()
            {
                try
                {
                    using (var conn = new SqlConnection())
                    {
                        conn.ConnectionString = @"Data Source=DESKTOP-4KJH6H4\SQLEXPRESS;Initial Catalog=ReservasCamping;Integrated Security=True";
                        conn.Open();
                        return "Conexión exitosa.";
                    }
                }
                catch (Exception ex)
                {
                    return $"Error de conexión: {ex.Message}";
                }
            }
            public SqlConnection GetConnection()
        {
            return _connection;
            }
        }
    }
}