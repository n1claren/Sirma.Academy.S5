int[] inputNumbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

Stack<int> stack = new Stack<int>();

foreach (var number in inputNumbers)
{
    stack.Push(number);
}

while (stack.Count > 0)
{
    Console.Write(stack.Pop() + " ");
}