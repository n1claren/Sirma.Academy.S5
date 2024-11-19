string[] input = Console.ReadLine().Split(" ");

string result = "";

for (int i = 0; i < input.Length; i++)
{
    string repeatedString = String.Concat(Enumerable.Repeat(input[i], input[i].Length));

    result += repeatedString;
}

Console.WriteLine(result);