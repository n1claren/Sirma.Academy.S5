int[] NSX = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

int numberOfElementsToPush = NSX[0];
int numberOfElementsToPop = NSX[1];
int numberToCheck = NSX[2];

int[] inputNumbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

Stack<int> stack = new Stack<int>();

for (int i = 0; i < inputNumbers.Length; i++)
{
    if (numberOfElementsToPush == 0)
    {
        break;
    }

    stack.Push(inputNumbers[i]);

    numberOfElementsToPush--;
}

for (int i = 0; i < numberOfElementsToPop; i++)
{
    stack.Pop();
}

if (!stack.Contains(numberToCheck))
{
    Console.WriteLine(stack.Min());
}
else
{
    Console.WriteLine("True");
}