int decimalNumber = int.Parse(Console.ReadLine());

if (decimalNumber == 0)
{
    Console.WriteLine(0);
    return;
}

Stack<int> stack = new Stack<int>();

while (decimalNumber > 0)
{
    int remainder = decimalNumber % 2;

    stack.Push(remainder);

    decimalNumber /= 2;
}

while (stack.Count > 0)
{
    Console.Write(stack.Pop());
}