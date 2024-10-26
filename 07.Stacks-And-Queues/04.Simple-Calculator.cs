string[] inputs = Console.ReadLine().Split(" ").ToArray();

Stack<string> stack = new Stack<string>();

inputs = inputs.Reverse().ToArray();

foreach (var input in inputs)
{
    stack.Push(input);
}

int result = 0;
string currentSign = null;

while (stack.Count > 0)
{
    string temp = stack.Pop();

    if (temp == "+" || temp == "-")
    {
        currentSign = temp;
    }
    else
    {
        int number = int.Parse(temp);

        if (currentSign == "+" || currentSign == null)
        {
            result += number;
        }
        else
        {
            result -= number;
        }
    }
}

Console.WriteLine(result);