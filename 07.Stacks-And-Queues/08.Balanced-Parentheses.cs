string input = Console.ReadLine();

Stack<char> stack = new Stack<char>();

bool isBalanced = true;

foreach (char ch in input)
{
    if (ch == '(' || ch == '{' || ch == '[')
    {
        stack.Push(ch);
    }
    else if (ch == ')' || ch == '}' || ch == ']')
    {
        if (stack.Count == 0)
        {
            isBalanced = false;
            break;
        }

        char top = stack.Pop();

        if ((ch == ')' && top != '(') ||
            (ch == '}' && top != '{') ||
            (ch == ']' && top != '['))
        {
            isBalanced = false;
            break;
        }
    }
}

if (isBalanced && stack.Count == 0)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}