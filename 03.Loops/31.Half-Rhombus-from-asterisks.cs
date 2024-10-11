int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    for (int z = 0; z < i; z++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}

for (int i = n-1; i >= 1; i--)
{
    for (int z = 0; z < i; z++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}