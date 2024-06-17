using App_DataBase_Command.Class;
using App_DataBase_Command.Class.Export;
using Microsoft.Data.SqlClient;
using System.Data;

namespace App_DataBase_Command
{
    public partial class QueryDataBase : Form
    {
        private DataBase _dataBase;
        public string filePath = string.Empty;
        public string selectetNameTable;

        public QueryDataBase(DataBase dataBase)
        {
            InitializeComponent();
            _dataBase = dataBase;
        }

        public bool OpenDialog(ref string filePath, string filter)
        {
            dataFile.Rows.Clear();
            dataFile.Columns.Clear();

            var fileDialog = new OpenFileDialog
            {
                Filter = filter
            };

            if (fileDialog.ShowDialog() != DialogResult.OK)
            {
                return true;
            }

            filePath = fileDialog.FileName;

            fileNameLBL.Text = Path.GetFileNameWithoutExtension(fileDialog.FileName);

            return false;
        }

        public bool SaveDialog(ref string filePath, string filter)
        {
            if (dataFile.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            var saveFileTem = new SaveFileDialog
            {
                Filter = filter
            };

            if (saveFileTem.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show($"Datos no guardados desde el archivo {Path.GetFileName(saveFileTem.FileName)} incorrectamente.", "Operación cancelada", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                return true;
            }

            filePath = saveFileTem.FileName;

            fileNameLBL.Text = Path.GetFileNameWithoutExtension(saveFileTem.FileName);

            return false;
        }

        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenDialog(ref filePath, "Archivos CSV (*.csv)|*.csv|Archivos XML (*.xml)|*.xml|Archivos JSON (*.json)|*.json"))
            {
                return;
            }

            GetFileExtencion.ForOpen(ref filePath, dataFile);
        }

        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                if (SaveDialog(ref filePath, "Archivos CSV (*.csv)|*.csv|Archivos XML (*.xml)|*.xml|Archivos JSON (*.json)|*.json"))
                {
                    return;
                }

                GetFileExtencion.ForSave(ref filePath, dataFile);
            }
            else
            {
                GetFileExtencion.ForSave(ref filePath, dataFile);
            }
        }

        private void SaveHowMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveDialog(ref filePath, "Archivos CSV (*.csv)|*.csv|Archivos XML (*.xml)|*.xml|Archivos JSON (*.json)|*.json"))
            {
                return;
            }

            GetFileExtencion.ForSave(ref filePath, dataFile);
        }

        private void ExportMenuItemExport_Click(object sender, EventArgs e)
        {
            Export export = new Export(_dataBase);

            export.DataExport(fileNameLBL.Text, dataFile);
        }

        private void ShowMenuItem_Click(object sender, EventArgs e)
        {
            dataFile.Rows.Clear();
            dataFile.Columns.Clear();

            string query = $"SELECT * FROM dbo.{selectetNameTable};";
            DataTable dataTable = _dataBase.GetDataTable(query);
            dataFile.DataSource = dataTable;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectetNameTable = comboBox1.SelectedItem.ToString();
        }

        public string GetSelectedItem()
        {
            return selectetNameTable;
        }

        private void QueryBtm_Click(object sender, EventArgs e)
        {
            dataFile.Rows.Clear();
            dataFile.Columns.Clear();

            string query = QueryTxb.Text;
            DataTable dataTable = _dataBase.GetDataTable(query);
            dataFile.DataSource = dataTable;
        }

        private void QueryDataBase_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(_dataBase.GetConnection()))
            {
                try
                {
                    connection.Open();

                    DataTable schema = connection.GetSchema("Tables");

                    foreach (DataRow row in schema.Rows)
                    {
                        if (row["TABLE_TYPE"].ToString() == "BASE TABLE")
                        {
                            comboBox1.Items.Add(row["TABLE_NAME"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las tablas: " + ex.Message);
                }
            }
        }
    }
}
