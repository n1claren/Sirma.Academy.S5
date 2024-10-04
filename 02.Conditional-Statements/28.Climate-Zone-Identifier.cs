double latitude = double.Parse(Console.ReadLine());

string hemisphere = Console.ReadLine();

if (latitude < -90 || latitude > 90)
{
    Console.WriteLine("Invalid latitude.");
    return;
}

if (hemisphere != "N" && hemisphere != "S")
{
    Console.WriteLine("Invalid hemisphere.");
    return;
}

if (latitude == 0)
{
    Console.WriteLine("Equator");
}
else if (hemisphere == "N")
{
    if (latitude > 66.5)
    {
        Console.WriteLine("Arctic Zone");
    }
    else if (latitude > 23.5)
    {
        Console.WriteLine("Temperate Zone");
    }
    else if (latitude >= 0)
    {
        Console.WriteLine("Tropic Zone");
    }
}
else if (hemisphere == "S")
{
    if (latitude < -66.5)
    {
        Console.WriteLine("Arctic Zone");
    }
    else if (latitude > -23.5)
    {
        Console.WriteLine("Temperate Zone");
    }
    else if (latitude <= 0)
    {
        Console.WriteLine("Tropic Zone");
    }
}