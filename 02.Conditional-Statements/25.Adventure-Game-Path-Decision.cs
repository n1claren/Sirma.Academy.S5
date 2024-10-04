string rightHand = Console.ReadLine();
string leftHand = Console.ReadLine();

if (rightHand == "sword" || leftHand == "sword")
{
    if (rightHand == "shield" || leftHand == "shield")
    {
        Console.WriteLine("Path to the castle");
    }
    else
    {
        Console.WriteLine("Path to the forest");
    }
}
else if (rightHand == "map" || leftHand == "map")
{
    if (rightHand == "coins" || leftHand == "coins")
    {
        Console.WriteLine("Go to the town");
    }
    else
    {
        Console.WriteLine("Camp");
    }
}
else
{
    Console.WriteLine("Wander aimlessly");
}