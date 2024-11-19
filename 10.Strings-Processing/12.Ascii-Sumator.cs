char firstChar = Console.ReadLine()[0];

char secondChar = Console.ReadLine()[0];

string randomString = Console.ReadLine();

int start = Math.Min(firstChar, secondChar);
int end = Math.Max(firstChar, secondChar);
int sum = 0;

foreach (char ch in randomString)
{
    if (ch > start && ch < end)
    {
        sum += ch;
    }
}

Console.WriteLine(sum);