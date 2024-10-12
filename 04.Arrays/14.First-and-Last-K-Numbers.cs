int count = int.Parse(Console.ReadLine());

int[] inputArray = Console.ReadLine().Split(',').Select(x => int.Parse(x)).ToArray();

int[] firstSequence = new int[count];
int[] lastSequence = new int[count];

for (int i = 0; i < count; i++)
{
    firstSequence[i] = inputArray[i];
}

int reCount = 0;

for (int i = inputArray.Length - 1; i >= 0; i--)
{
    if (count == reCount)
    {
        break;
    }

    lastSequence[reCount] = inputArray[i];
    reCount++;
}

Array.Reverse(lastSequence);

Console.WriteLine(string.Join(" ", firstSequence));
Console.WriteLine(string.Join(" ", lastSequence));