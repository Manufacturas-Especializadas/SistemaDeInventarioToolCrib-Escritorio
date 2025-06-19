using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeInventariosToolCrib.Connection
{
    public static class ConnectionToDataBase
    {
        private static string connectionString = "Server=WIN-PVPAQO25113;Database=SistemaDeInventarioLinea10;User Id=MESINNO03;Password=M3s@.dm1n!;MultipleActiveResultSets=true;Pooling=true;Integrated Security=false;Trust Server Certificate=true; Connect Timeout=300;";

        public static async Task <SqlConnection> GetConnectionAsync()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {                
                await Task.Run(() => conn.Open());
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar a la base de datos: {ex.Message}");

                return null!;
            }
        }
    }
}