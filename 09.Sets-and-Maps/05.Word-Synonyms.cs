int inputs = int.Parse(Console.ReadLine());

SortedDictionary<string, List<string>> words = new SortedDictionary<string, List<string>>();

for (int i = 0; i < inputs; i++)
{
    string word = Console.ReadLine();
    string synonym = Console.ReadLine();

    if (!words.ContainsKey(word))
    {
        words[word] = new List<string>();
    }

    words[word].Add(synonym);
}

foreach (var kvp in words)
{
    Console.WriteLine($"{kvp.Key} - {String.Join(", ", kvp.Value)}");
}