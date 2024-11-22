string filePath = "C:\\Users\\n1c\\Desktop\\input.txt";

FileInfo fileInfo = new FileInfo(filePath);

string fileName = Path.GetFileNameWithoutExtension(filePath);
string fileExtension = Path.GetExtension(filePath).TrimStart('.');
long fileSize = fileInfo.Length;

Console.WriteLine($"File name: {fileName}");
Console.WriteLine($"File extension: {fileExtension}");
Console.WriteLine($"File size: {fileSize} bytes");