var countries = new Dictionary<string, Dictionary<string, long>>();

string input = "";

while ((input = Console.ReadLine()) != "report")
{
    var inputData = input.Split('|');

    string city = inputData[0];
    string country = inputData[1];
    long population = long.Parse(inputData[2]);

    if (!countries.ContainsKey(country))
    {
        countries[country] = new Dictionary<string, long>();
    }

    if (!countries[country].ContainsKey(city))
    {
        countries[country][city] = 0;
    }

    countries[country][city] += population;
}

var sortedCountries = countries
    .Select(c => new
    {
        Country = c.Key,
        TotalPopulation = c.Value.Values.Sum(),
        Cities = c.Value.OrderByDescending(city => city.Value).ToList()
    })
    .OrderByDescending(c => c.TotalPopulation)
    .ToList();

foreach (var country in sortedCountries)
{
    Console.WriteLine($"{country.Country} (total population: {country.TotalPopulation})");

    foreach (var city in country.Cities)
    {
        Console.WriteLine($"=>{city.Key}: {city.Value}");
    }
}