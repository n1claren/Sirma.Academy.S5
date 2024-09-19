double unitsConsumed = double.Parse(Console.ReadLine());
double ratePerUnit = double.Parse(Console.ReadLine());

double bill =  unitsConsumed * ratePerUnit + 10;

Console.WriteLine($"{bill:F2}");