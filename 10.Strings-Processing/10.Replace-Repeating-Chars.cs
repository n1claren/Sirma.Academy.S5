string input = Console.ReadLine();

string result = "";

for (int i = 0; i < input.Length; i++)
{
    if (result.Length == 0 || result[result.Length - 1] != input[i])
    {
        result += input[i];
    }
}

Console.WriteLine(result);