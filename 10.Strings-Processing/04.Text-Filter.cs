string[] bannedWords = Console.ReadLine().Split(", ");

string text = Console.ReadLine();

for (int i = 0; i < bannedWords.Length; i++)
{
    string currentWord = bannedWords[i];

    while (text.Contains(currentWord))
    {
        text = text.Replace(currentWord, new string('*', currentWord.Length));
    }
}

Console.WriteLine(text);