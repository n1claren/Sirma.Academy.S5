int[] inputArray = Console.ReadLine().Split(',').Select(x => int.Parse(x)).ToArray();

int sum = 0;

foreach (int item in inputArray)
{
    if (item % 2 == 0)
    {
        sum += item;
    }
}

Console.WriteLine(sum);