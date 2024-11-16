string input = Console.ReadLine();

SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();

for (int i = 0; i < input.Length; i++)
{
    char current = input[i];

    if (symbols.ContainsKey(current))
    {
        symbols[current]++;
    }
    else
    {
        symbols[current] = 1;
    }
}

foreach (var kvp in symbols)
{
    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
}