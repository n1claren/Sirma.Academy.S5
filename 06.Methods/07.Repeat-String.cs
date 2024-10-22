string repeating = Console.ReadLine();

int repeatingTimes = int.Parse(Console.ReadLine());

RepeatString(repeating, repeatingTimes);

static void RepeatString(string text, int n)
{
    string result = "";

    for (int i = 0; i < n; i++)
    {
        result += text;
    }

    Console.WriteLine(result);
}