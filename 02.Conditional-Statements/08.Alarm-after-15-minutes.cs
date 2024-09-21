int hour = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

minutes += 15;

if (minutes >= 60)
{
    int hoursToAdd = minutes / 60;

    minutes = minutes - hoursToAdd * 60;

    hour += hoursToAdd;
}

if (hour > 23)
{
    hour -= 24;
}

if (minutes < 10)
{
    Console.WriteLine($"{hour}:0{minutes}");
}
else
{
    Console.WriteLine($"{hour}:{minutes}");
}