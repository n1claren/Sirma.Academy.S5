int[] inputArray = Console.ReadLine().Split(',').Select(x => int.Parse(x)).ToArray();

for (int i = inputArray.Length - 1; i >= 0; i--)
{
    if (i % 2 != 0 && i != 0)
    {
        Console.Write(inputArray[i] * 2 + " ");
    }
}