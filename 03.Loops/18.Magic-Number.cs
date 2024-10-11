int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());
int magicNumber = int.Parse(Console.ReadLine());

if (start > end)
{
    Console.WriteLine("ERROR: Your starting point is bigger than the end point!");
    Environment.Exit(0);
}

int combinations = 0;
bool noCombination = true;

for (int i = start; i <= end; i++)
{
    combinations++;

    int temp = start + i;

    if (temp == magicNumber)
    {
        Console.WriteLine($"Combination {combinations} - ({start} + {i} = {magicNumber})");
        noCombination = false;
        break;
    }
}

if (noCombination)
{
    Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");
}