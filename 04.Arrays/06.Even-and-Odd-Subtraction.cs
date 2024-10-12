int[] inputArray = Console.ReadLine().Split(',').Select(x => int.Parse(x)).ToArray();

int evenSum = 0;
int oddSum = 0;

foreach (int item in inputArray)
{
    if (item % 2 == 0)
    {
        evenSum += item;
    }
    else
    {
        oddSum += item;
    }
}

Console.WriteLine(evenSum - oddSum);