string[] inputArray = Console.ReadLine().Split(',').ToArray();

Array.Reverse(inputArray);

foreach (string item in inputArray)
{
    Console.Write(item + " ");
}