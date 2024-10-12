string[] inputArray = Console.ReadLine().Split(',');

int step = int.Parse(Console.ReadLine());

for (int i = 0; i < inputArray.Length; i+=step)
{
    Console.Write(inputArray[i] + " ");
}