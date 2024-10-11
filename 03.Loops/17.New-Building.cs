int floors = int.Parse(Console.ReadLine());
int rooms = int.Parse(Console.ReadLine());

for (int i = floors; i >= 1; i--)
{
    for (int z = 0; z < rooms; z++)
    {
        if (i == floors)
        {
            Console.Write($"L{i}{z} ");
        }
        else if (i % 2 == 0)
        {
            Console.Write($"O{i}{z} ");
        }
        else
        {
            Console.Write($"A{i}{z} ");
        }
    }

    Console.WriteLine();
}