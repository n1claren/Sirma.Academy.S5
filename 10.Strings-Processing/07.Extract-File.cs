string filePath = Console.ReadLine();

string fileNameWithExtension = Path.GetFileName(filePath);

string fileName = Path.GetFileNameWithoutExtension(filePath);
string fileExtension = Path.GetExtension(filePath).TrimStart('.');

Console.WriteLine($"File name: {fileName}");
Console.WriteLine($"File extension: {fileExtension}");