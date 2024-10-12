int[] inputArray = Console.ReadLine().Split(',').Select(x => int.Parse(x)).ToArray();

string[] result = new string[inputArray.Length];

int prependIndex = 0; 
int appendIndex = inputArray.Length - 1;

for (int i = 0; i < inputArray.Length; i++)
{
    if (inputArray[i] < 0)
    {
        result[prependIndex] = inputArray[i].ToString();
        prependIndex++;
    }
    else
    {
        result[appendIndex] = inputArray[i].ToString();
        appendIndex--;
    }
}

for (int i = prependIndex - 1; i >= 0; i--)
{
    Console.WriteLine(result[i]);
}

for (int i = result.Length - 1; i > appendIndex; i--)
{
    Console.WriteLine(result[i]);
}