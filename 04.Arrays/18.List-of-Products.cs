string[] inputArray = Console.ReadLine().Split(',');

Array.Sort(inputArray);

for (int i = 0; i < inputArray.Length; i++)
{
    Console.WriteLine($"{i + 1}.{inputArray[i]}");
}