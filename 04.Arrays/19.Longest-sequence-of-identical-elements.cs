int[] inputArray = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

int maxLength = 1; 
int currentLength = 1; 
int indexer = inputArray[0];

for (int i = inputArray.Length - 1; i > 0; i--)
{
    if (inputArray[i] == inputArray[i - 1])
    {
        currentLength++;
    }
    else
    {
        currentLength = 1;
    }

    if (currentLength >= maxLength)
    {
        maxLength = currentLength;
        indexer = inputArray[i];
    }
}

for (int i = 0; i < maxLength; i++)
{
    Console.Write(indexer + " ");
}