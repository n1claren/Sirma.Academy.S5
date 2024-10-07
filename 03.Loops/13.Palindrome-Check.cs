string word = Console.ReadLine();

string reversedWord = "";

for (int i = word.Length - 1; i >= 0; i--)
{
    reversedWord += word[i];
}

if (reversedWord == word)
{
    Console.WriteLine("TRUE");
}
else
{
    Console.WriteLine("FALSE");
}