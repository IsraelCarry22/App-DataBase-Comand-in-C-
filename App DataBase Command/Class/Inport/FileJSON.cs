static class FileJSON
{
    static public void OpenFile(ref string filePath, DataGridView ListFilesData)
    {
        string jsonDatos = File.ReadAllText(filePath);

        var listaObjetos = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(jsonDatos);

        if (listaObjetos != null && listaObjetos.Count > 0)
        {
            foreach (string clave in listaObjetos[0].Keys)
            {
                ListFilesData.Columns.Add(clave, clave);
            }

            foreach (var objetoFila in listaObjetos)
            {
                object[] valores = objetoFila.Values.ToArray();

                ListFilesData.Rows.Add(valores);
            }

            MessageBox.Show("Datos cargados desde el archivo JSON correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    static public void SaveFile(ref string filePath, DataGridView ListFilesData)
    {
        var listaObjetos = new List<object>();

        foreach (DataGridViewRow fila in ListFilesData.Rows)
        {
            if (!fila.IsNewRow)
            {
                var objetoFila = new Dictionary<string, object>();

                foreach (DataGridViewCell celda in fila.Cells)
                {
                    string nombreColumna = ListFilesData.Columns[celda.ColumnIndex].HeaderText;

                    objetoFila[nombreColumna] = celda.Value;
                }

                listaObjetos.Add(objetoFila);
            }
        }

        string jsonDatos = Newtonsoft.Json.JsonConvert.SerializeObject(listaObjetos, Newtonsoft.Json.Formatting.Indented);

        File.WriteAllText(filePath, jsonDatos);

        MessageBox.Show("Datos guardados como archivo JSON correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
