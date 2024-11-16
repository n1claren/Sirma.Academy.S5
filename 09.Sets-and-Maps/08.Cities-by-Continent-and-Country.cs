int inputs = int.Parse(Console.ReadLine());

Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();

for (int i = 0; i < inputs; i++)
{
    var data = Console.ReadLine().Split(' ');

    string continent = data[0];
    string country = data[1];
    string city = data[2];

    if (!continents.ContainsKey(continent))
    {
        continents[continent] = new Dictionary<string, List<string>>();
    }

    if (!continents[continent].ContainsKey(country))
    {
        continents[continent][country] = new List<string>();
    }

    continents[continent][country].Add(city);
}

foreach (var kvp in continents)
{
    Console.WriteLine($"{kvp.Key}:");

    foreach (var country in kvp.Value)
    {
        Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
    }
}