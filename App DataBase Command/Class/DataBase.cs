using Microsoft.Data.SqlClient;
using System.Data;

namespace App_DataBase_Command.Class
{
    public class DataBase
    {
        public static string Usuario { get; set; }
        public static string Contraseña { get; set; }
        private static SqlConnection _connection;
        private string connectionString;

        public DataBase(string usuario, string contraseña)
        {
            Usuario = usuario;
            Contraseña = contraseña;
        }

        public string GetConnection()
        {
            connectionString = "";
            connectionString = $"Server=ISRAELMONCADA\\SQLEXPRESS;Database=Prueba;User Id={Usuario};Password={Contraseña};TrustServerCertificate=true;";

            return connectionString;
        }

        public bool Connect()
        {
            try
            {
                _connection = new SqlConnection(GetConnection());
                _connection.Open();
                Console.Beep();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void Disconnect()
        {
            _connection.Close();
        }

        public void ExecuteQuery(string query)
        {
            if (Connect())
            {
                return;
            }

            SqlCommand command = new SqlCommand(query, _connection);
            command.ExecuteNonQuery();
            Disconnect();
        }

        public DataTable GetDataTable(string query)
        {
            if (!Connect())
            {
                return null;
            }
            
            SqlCommand command = new SqlCommand(query, _connection);
            DataTable dataTable = new DataTable();
            dataTable.Load(command.ExecuteReader());
            Disconnect();
            Console.Beep();
            return dataTable;
        }
    }
}
