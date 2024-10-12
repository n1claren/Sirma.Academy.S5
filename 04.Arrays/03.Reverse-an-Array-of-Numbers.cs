int n = int.Parse(Console.ReadLine());
string arrayInput = Console.ReadLine();

int[] resultArray = new int[n];

int[] inputArray = arrayInput.Split(',').Select(x => int.Parse(x)).ToArray();

for (int i = 0; i < resultArray.Length; i++)
{
    resultArray[i] = inputArray[i];
}

Array.Reverse(resultArray);

foreach (int item in resultArray)
{
    Console.Write(item + " ");
}