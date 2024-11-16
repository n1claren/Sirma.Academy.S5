string text = Console.ReadLine();

Dictionary<char, int> counter = new Dictionary<char, int>();

for (int i = 0; i < text.Length; i++)
{
    if (text[i] == ' ')
    {
        continue;
    }

    if (counter.ContainsKey(text[i]))
    {
        counter[text[i]]++;
    }
    else
    {
        counter[text[i]] = 1;
    }
}

foreach (var kvp in counter)
{
    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
}