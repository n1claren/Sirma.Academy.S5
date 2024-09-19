double totalWaterForHousehold = double.Parse(Console.ReadLine());
double peopleInHousehold = double.Parse(Console.ReadLine());

double totalWaterPerDay = totalWaterForHousehold / 7;
double waterPerPerson = totalWaterPerDay / peopleInHousehold;

Console.WriteLine($"{waterPerPerson:F2}");