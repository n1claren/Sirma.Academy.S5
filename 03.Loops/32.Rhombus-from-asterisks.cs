int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    for (int z = 1; z <= n - i; z++)
    {
        Console.Write(" ");
    }

    for (int k = 1; k <= i; k++)
    {
        Console.Write("* ");
    }

    Console.WriteLine(); 
}

for (int i = n - 1; i >= 1; i--)
{
    for (int z = 1; z <= n - i; z++)
    {
        Console.Write(" ");
    }

    for (int k = 1; k <= i; k++)
    {
        Console.Write("* ");
    }

    Console.WriteLine();
}