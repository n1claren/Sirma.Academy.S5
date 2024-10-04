int year = int.Parse(Console.ReadLine());

string material = Console.ReadLine();

if (year < 500 && material == "stone")
{
    Console.WriteLine("Ancient");
}
else if (year >= 500 && year <= 1500 && material == "stone")
{
    Console.WriteLine("Medieval");
}
else if (year >= 1500 && year < 1800 && material == "wood")
{
    Console.WriteLine("Colonial");
}
else if (year >= 1800 && year < 1900 && material == "steel")
{
    Console.WriteLine("Industrial");
}
else if (year > 1900 && material == "steel")
{
    Console.WriteLine("Modern");
}
else
{
    Console.WriteLine("Uncertain");
}