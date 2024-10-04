string timeOfDay = Console.ReadLine();
string environment = Console.ReadLine();
string item = Console.ReadLine();

if (timeOfDay == "day")
{
    if (environment == "forest")
    {
        if (item == "knife")
        {
            Console.WriteLine("Hunt for food");
        }
        else if (item == "container")
        {
            Console.WriteLine("Collect berries");
        }
        else
        {
            Console.WriteLine("Explore");
        }
    }
    else if (environment == "desert")
    {
        if (item == "hat")
        {
            Console.WriteLine("Search for water");
        }
        else
        {
            Console.WriteLine("Find shade");
        }
    }
}
else if (timeOfDay == "night")
{
    if (environment == "forest")
    {
        if (item == "firestarter")
        {
            Console.WriteLine("Make a campfire");
        }
        else
        {
            Console.WriteLine("Climb a tree");
        }
    }
    else if (environment == "desert")
    {
        if (item == "blanket")
        {
            Console.WriteLine("Sleep");
        }
        else
        {
            Console.WriteLine("Keep moving to stay warm");
        }
    }
}