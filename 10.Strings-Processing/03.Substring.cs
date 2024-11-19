string partString = Console.ReadLine();
string fullString = Console.ReadLine();

while (fullString.Contains(partString))
{
    fullString = fullString.Replace(partString, string.Empty);
}

Console.WriteLine(fullString);