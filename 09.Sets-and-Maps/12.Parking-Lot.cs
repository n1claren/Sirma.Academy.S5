string input = "";

HashSet<string> parkedCars = new HashSet<string>();

while ((input = Console.ReadLine()) != "END")
{
    string action = input.Split(", ")[0];
    string license = input.Split(", ")[1];

    if (action == "IN")
    {
        parkedCars.Add(license);
    }
    else if (action == "OUT")
    {
        parkedCars.Remove(license);
    }
}

if (parkedCars.Count == 0)
{
    Console.WriteLine("Parking Lot is Empty");
}
else
{
    foreach (var car in parkedCars)
    {
        Console.WriteLine(car);
    }
}