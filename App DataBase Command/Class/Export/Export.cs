using Microsoft.Data.SqlClient;

namespace App_DataBase_Command.Class.Export
{
    public class Export
    {
        private static DataBase _dataBase;

        public Export(DataBase dataBase) 
        {
            _dataBase = dataBase;
        }

        public void DataExport(string fileNameLBL, DataGridView dataFile)
        {
            try
            {
                CrearTabla(fileNameLBL, dataFile);
                InsertarDatos(fileNameLBL, dataFile);

                MessageBox.Show("Datos exportados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CrearTabla(string fileNameLBL, DataGridView dataFile)
        {
            string nombreTabla = fileNameLBL;
            string connectionString = _dataBase.GetConnection();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "CREATE TABLE " + nombreTabla + " (";

                foreach (DataGridViewColumn columna in dataFile.Columns)
                {
                    query += "[" + columna.HeaderText + "] " + ObtenerTipoDato(columna.ValueType) + ",";
                }

                query = query.TrimEnd(',') + ")";

                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
        }

        private string ObtenerTipoDato(Type tipo)
        {
            if (tipo == null)
                return "NVARCHAR(MAX)";
            else if (tipo == typeof(int))
                return "INT";
            else if (tipo == typeof(string))
                return "NVARCHAR(MAX)";
            else
                throw new ArgumentException("Tipo de dato no compatible: " + tipo.Name);
        }

        private void InsertarDatos(string fileNameLBL, DataGridView dataFile)
        {
            string nombreTabla = fileNameLBL;
            string connectionString = _dataBase.GetConnection();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                foreach (DataGridViewRow fila in dataFile.Rows)
                {
                    if (!fila.IsNewRow)
                    {
                        string query = "INSERT INTO " + nombreTabla + " VALUES (";
                        foreach (DataGridViewCell celda in fila.Cells)
                        {
                            query += "'" + celda.Value.ToString() + "',";
                        }
                        query = query.TrimEnd(',') + ")";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
