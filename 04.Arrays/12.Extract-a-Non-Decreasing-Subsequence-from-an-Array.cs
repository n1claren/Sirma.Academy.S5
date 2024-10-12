int[] inputArray = Console.ReadLine().Split(',').Select(x => int.Parse(x)).ToArray();

int currentBiggestNumber = 0;

for (int i = 0; i < inputArray.Length; i++)
{
    if (inputArray[i] > currentBiggestNumber)
    {
        currentBiggestNumber = inputArray[i];
        
        Console.Write(inputArray[i] + " ");
    }
}