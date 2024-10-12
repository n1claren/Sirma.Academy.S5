string[] week = {
    "Monday",
    "Tuesday",
    "Wednesday",
    "Thursday",
    "Friday",
    "Saturday",
    "Sunday"
};

int dayNumber = int.Parse(Console.ReadLine());

if (dayNumber > 7 || dayNumber < 1)
{
    Console.WriteLine("Invalid day!");
}
else
{
    Console.WriteLine(week[dayNumber - 1]);
}