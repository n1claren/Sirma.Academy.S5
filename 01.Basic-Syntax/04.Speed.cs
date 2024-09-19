int distanceInMeters = int.Parse(Console.ReadLine());
int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());
int seconds = int.Parse(Console.ReadLine());

int totalSeconds = (hours * 60 * 60) + (minutes * 60) + seconds;

double metersPerSeconds = (double)distanceInMeters / (double)totalSeconds;

Console.WriteLine(Math.Round(metersPerSeconds, 6));