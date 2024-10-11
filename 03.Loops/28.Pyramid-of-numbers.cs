int number = int.Parse(Console.ReadLine());

int counter = 0;
int rowCounter = 1;

while (counter < number)
{
    for (int i = 1; i <= rowCounter; i++)
    {
        if (counter + 1 > number)
        {
            break;
        }

        Console.Write($"{counter + 1} ");
        counter++;
    }

    Console.WriteLine();

    rowCounter++;
}