int[] inputArray = Console.ReadLine().Split(',').Select(x => int.Parse(x)).ToArray();

int smallestNumber = int.MaxValue;
int secondSmallestNumber = int.MaxValue;
int smallestNumberIndex = 0;

for (int i = 0; i < inputArray.Length; i++)
{
    if (smallestNumber > inputArray[i])
    {
        smallestNumber = inputArray[i];
        smallestNumberIndex = i;
    }
}

for (int i = 0; i < inputArray.Length; i++)
{
    if (secondSmallestNumber > inputArray[i] && i != smallestNumberIndex)
    {
        secondSmallestNumber = inputArray[i];
    }
}

Console.WriteLine($"{smallestNumber} {secondSmallestNumber}");