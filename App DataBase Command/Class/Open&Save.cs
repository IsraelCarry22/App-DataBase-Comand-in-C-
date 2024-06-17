static class GetFileExtencion
{
    static public void ForOpen(ref string filePath, DataGridView ListFilesData)
    {
        switch (Path.GetExtension(filePath).ToLower())
        {
            case ".csv":
                FileCSV.OpenFile(ref filePath, ListFilesData);
                break;
            case ".xml":
                FileXML.OpenFile(ref filePath, ListFilesData);
                break;
            case ".json":
                FileJSON.OpenFile(ref filePath, ListFilesData);
                break;
        }
    }

    static public void ForSave(ref string filePath, DataGridView ListFilesData)
    {
        switch (Path.GetExtension(filePath).ToLower())
        {
            case ".csv":
                FileCSV.SaveFile(ref filePath, ListFilesData);
                break;
            case ".xml":
                FileXML.SaveFile(ref filePath, ListFilesData);
                break;
            case ".json":
                FileJSON.SaveFile(ref filePath, ListFilesData);
                break;
        }
    }
}
