string[] input = Console.ReadLine().Split(" ");

Dictionary<string, int> occurances = new Dictionary<string, int>();

for (int i = 0; i < input.Length; i++)
{
    string current = input[i].ToLower();

    if (occurances.ContainsKey(current))
    {
        occurances[current]++;
    }
    else
    {
        occurances[current] = 1;
    }
}

List<string> oddOccuringElements = new List<string>();

foreach (var kvp in occurances)
{
    if (kvp.Value % 2 != 0)
    {
        oddOccuringElements.Add(kvp.Key);
    }
}

Console.WriteLine(String.Join(", ", oddOccuringElements));