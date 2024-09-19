double distanceTravelled = double.Parse(Console.ReadLine());
double hoursTravelled = double.Parse(Console.ReadLine());

double averageSpeed = distanceTravelled / hoursTravelled;

Console.WriteLine($"{averageSpeed:F2}");