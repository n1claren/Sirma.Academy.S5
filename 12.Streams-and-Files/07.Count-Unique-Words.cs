string filePath = "C:\\Users\\n1c\\Desktop\\input.txt";

StreamReader sr = new StreamReader(filePath);

HashSet<string> uniqueWords = new HashSet<string>();

using (sr)
{
    string line = null;

    while ((line = sr.ReadLine()) != null)
    {
        string[] words = line.Split(' ', '.', StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            uniqueWords.Add(word);
        }
    }
}

Console.WriteLine($"Unique words: {uniqueWords.Count}");