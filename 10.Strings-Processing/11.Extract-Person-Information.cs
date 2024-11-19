int inputs = int.Parse(Console.ReadLine());

List<string> outputs = new List<string>();

for (int i = 0; i < inputs; i++)
{
    string currentInput = Console.ReadLine();

    string name = ExtractSubstring(currentInput, '@', '|');
    string age = ExtractSubstring(currentInput, '#', '*');

    if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(age))
    {
        outputs.Add($"{name} is {age} years old.");
    }
}

Console.WriteLine(String.Join("\n", outputs));

static string ExtractSubstring(string input, char startChar, char endChar)
{
    int startIndex = input.IndexOf(startChar);
    int endIndex = input.IndexOf(endChar);

    if (startIndex != -1 && endIndex != -1 && endIndex > startIndex)
    {
        return input.Substring(startIndex + 1, endIndex - startIndex - 1);
    }

    return string.Empty;
}