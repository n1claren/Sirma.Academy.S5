int totalMinutes = int.Parse(Console.ReadLine());

int hours = totalMinutes / 60;
int minutes = totalMinutes % 60;

if (hours < 10 && minutes < 10)
{
    Console.WriteLine($"0{hours}:0{minutes}");
}
else if (hours >= 10 && minutes < 10)
{
    Console.WriteLine($"{hours}:0{minutes}");
}
else if (hours >= 10 && minutes >= 10)
{
    Console.WriteLine($"{hours}:{minutes}");
}
else
{
    Console.WriteLine($"0{hours}:{minutes}");
}