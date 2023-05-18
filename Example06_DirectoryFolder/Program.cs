// Как посмотреть содержимое папки

string path = "D:/Документы/GB_Example/Example003_Sum";
DirectoryInfo dir = new DirectoryInfo(path);
CatalogInfo(path);
System.Console.WriteLine(dir.CreationTime); // время создания папки

FileInfo[] fi = dir.GetFiles(); // просмотр фалов
for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}

void CatalogInfo(string path, string indent = "") // string indent = "" <- позволяет делать отступы
{
    DirectoryInfo catalog = new DirectoryInfo(path);
    
    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }
    FileInfo[] files = catalog.GetFiles();
    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}
