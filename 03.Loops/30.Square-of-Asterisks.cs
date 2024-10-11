int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    for (int z = 0; z < n; z++)
    {
        if (z != n - 1)
        {
            Console.Write("* ");
        } 
        else
        {
            Console.Write("*");
        }
    }

    Console.WriteLine();
}