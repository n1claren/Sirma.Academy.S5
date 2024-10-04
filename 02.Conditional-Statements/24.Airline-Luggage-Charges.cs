double luggageWeight = double.Parse(Console.ReadLine());

double totalDimensions = double.Parse(Console.ReadLine());

double charge = 0;

bool isOverweight = false;
bool isSlightlyOversize = false;
bool isOversize = false;
bool isMegaOversize = false;

if (luggageWeight > 50)
{
    charge += 100;
    isOverweight = true;
}

if (totalDimensions > 158 && totalDimensions <= 178)
{
    charge += 50;
    isSlightlyOversize = true;
}
else if (totalDimensions > 178 && totalDimensions <= 208)
{
    charge += 100;
    isOversize = true;

    if (isOverweight)
    {
        charge += 50;
    }
}
else if (totalDimensions > 208)
{
    charge += 200;
    isMegaOversize = true;

    if (isOverweight)
    {
        charge += 50;
    }
}

if (isSlightlyOversize)
{
    if (isOverweight)
    {
        Console.WriteLine($"${charge} (Overweight + Slightly oversize)");
    }
    else
    {
        Console.WriteLine($"${charge} (Slightly oversize)");
    }
}
else if (isOversize)
{
    if (isOverweight)
    {
        Console.WriteLine($"${charge} (Overweight + Oversize + Handling)");
    }
    else
    {
        Console.WriteLine($"${charge} (Oversize)");
    }
}
else if (isMegaOversize)
{
    if (isOverweight)
    {
        Console.WriteLine($"${charge} (Overweight + Oversize + Handling)");
    }
    else
    {
        Console.WriteLine($"${charge} (Oversize)");
    }
}