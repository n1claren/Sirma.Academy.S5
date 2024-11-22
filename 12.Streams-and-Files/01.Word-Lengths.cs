string filePath = "C:\\Users\\n1c\\Desktop\\input.txt";

StreamReader sr = new StreamReader(filePath);

List<int> wordLengths = new List<int>();

using (sr)
{
    string line = null;

    while ((line = sr.ReadLine()) != null)
    {
        string[] words = line.Split(' ');

        foreach (string word in words)
        {
            wordLengths.Add(word.Length);
        }
    }   
}

Console.WriteLine(String.Join(", ", wordLengths));