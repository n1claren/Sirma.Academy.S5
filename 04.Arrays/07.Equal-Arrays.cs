int[] firstArray = Console.ReadLine().Split(',').Select(x => int.Parse(x)).ToArray();
int[] secondArray = Console.ReadLine().Split(',').Select(x => int.Parse(x)).ToArray();

int differenceIndex = 0;
bool areEqual = true;

for (int i = 0; i < firstArray.Length; i++)
{
    if (firstArray[i] != secondArray[i])
    {
        differenceIndex = i;
        areEqual = false;
        break;
    }
}

if (!areEqual)
{
    Console.WriteLine($"Arrays are not identical. Found difference at {differenceIndex} index");
}
else
{
    int sum = 0;

    foreach (int item in firstArray)
    {
        sum += item;
    }

    Console.WriteLine($"Arrays are identical. Sum: {sum}");
}