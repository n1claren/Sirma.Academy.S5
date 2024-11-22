string filePath = "C:\\Users\\n1c\\Desktop\\input.txt";

StreamReader sr = new StreamReader(filePath);

int lines = 0;
int words = 0;
int chars = 0;

using (sr)
{
    string line = null;

    while ((line = sr.ReadLine()) != null)
    {
        string[] wordsCount = line.Split(' ');

        lines++;
        chars += line.Length;
        words += wordsCount.Length;
    }
}

Console.WriteLine($"Lines: {lines}");
Console.WriteLine($"Words: {words}");
Console.WriteLine($"Characters: {chars}");