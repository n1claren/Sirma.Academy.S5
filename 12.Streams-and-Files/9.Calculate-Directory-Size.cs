string directoryPath = @"C:\Users\n1c\Desktop\Sirma.Academy.S5";

long totalSize = CalculateDirectorySize(directoryPath);

Console.WriteLine($"Total size: {totalSize} bytes");

static long CalculateDirectorySize(string directoryPath)
{
    long size = 0;

    FileInfo[] files = new DirectoryInfo(directoryPath).GetFiles();

    foreach (FileInfo file in files)
    {
        size += file.Length;
    }

    DirectoryInfo[] subDirectories = new DirectoryInfo(directoryPath).GetDirectories();

    foreach (DirectoryInfo dir in subDirectories)
    {
        size += CalculateDirectorySize(dir.FullName);
    }

    return size;
}