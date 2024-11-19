string input = "";

List<string> output = new List<string>();

while ((input = Console.ReadLine()) != "end")
{
    string reversedString = ReverseString(input);

    output.Add($"{input} = {reversedString}");
}

static string ReverseString(string input)
{
    string reversed = new string(input.Reverse().ToArray());

    return reversed;
}

foreach (var str in output) 
{
    Console.WriteLine(str);
}