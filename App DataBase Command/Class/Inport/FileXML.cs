using System.Data;
using System.Xml;

static class FileXML
{
    static public void OpenFile(ref string filePath, DataGridView ListFilesData)
    {
        var dataSet = new DataSet();

        dataSet.ReadXml(filePath);

        if (dataSet.Tables.Count > 0)
        {
            DataTable dataTable = dataSet.Tables[0];

            foreach (DataColumn column in dataTable.Columns)
            {
                ListFilesData.Columns.Add(column.ColumnName, column.ColumnName);
            }

            foreach (DataRow row in dataTable.Rows)
            {
                ListFilesData.Rows.Add(row.ItemArray);
            }

            MessageBox.Show("Datos cargados desde el archivo XML correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    static public void SaveFile(ref string filePath, DataGridView ListFilesData)
    {
        XmlDocument xmlDoc = new XmlDocument();
        XmlDeclaration xmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
        xmlDoc.AppendChild(xmlDeclaration);

        XmlElement rootElement = xmlDoc.CreateElement("Datos");
        xmlDoc.AppendChild(rootElement);

        for (int i = 0; i < ListFilesData.Rows.Count; i++)
        {
            XmlElement rowElement = xmlDoc.CreateElement("Fila");

            for (int j = 0; j < ListFilesData.Columns.Count; j++)
            {
                string columnName = ListFilesData.Columns[j].HeaderText;

                string xmlElementName = GetValidXmlElementName(columnName);

                string cellValue = Convert.ToString(ListFilesData.Rows[i].Cells[j].Value);

                XmlElement cellElement = xmlDoc.CreateElement(xmlElementName);
                cellElement.InnerText = cellValue;

                rowElement.AppendChild(cellElement);
            }

            rootElement.AppendChild(rowElement);
        }

        xmlDoc.Save(filePath);

        MessageBox.Show("Datos guardados como archivo XML correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    static private string GetValidXmlElementName(string input)
    {
        string validName = input.Replace(' ', '_');

        validName = new string(validName.Where(c => char.IsLetterOrDigit(c) || c == '_').ToArray());

        if (char.IsDigit(validName[0]))
        {
            validName = "_" + validName;
        }

        return validName;
    }
}
