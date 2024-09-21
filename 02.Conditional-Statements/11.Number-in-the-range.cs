int number = int.Parse(Console.ReadLine());

if (number != 0)
{
    if (number >= -100 && number <= 100)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}
else
{
    Console.WriteLine("No");
}