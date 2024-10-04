string firstIngredient = Console.ReadLine();
string secondIngredient = Console.ReadLine();

if (firstIngredient == "herbs" || secondIngredient == "herbs")
{
    if (firstIngredient == "water" || secondIngredient == "water")
    {
        Console.WriteLine("Health potion");
    }
    else if (firstIngredient == "oil" || secondIngredient == "oil")
    {
        Console.WriteLine("Stealth potion");
    }
    else
    {
        Console.WriteLine("Minor stamina potion");
    }
}
else if (firstIngredient == "berries" || secondIngredient == "berries")
{
    if (firstIngredient == "sugar" || secondIngredient == "sugar")
    {
        Console.WriteLine("Speed potion");
    }
    else
    {
        Console.WriteLine("Minor energy potion");
    }
}
else
{
    Console.WriteLine("No potion");
}