int number = int.Parse(Console.ReadLine());

while (number > 0)
{
    if (number % 10 == 0)
    {
        number /= 10;
        Console.WriteLine("ZERO");
        Console.WriteLine();
        continue;
    }

    int temp = number % 10;

    int asciiTemp = temp + 33;

    for (int i = 0; i < temp; i++)
    {
        Console.Write((char)asciiTemp);
    }

    number /= 10;

    Console.WriteLine();
    Console.WriteLine();
}