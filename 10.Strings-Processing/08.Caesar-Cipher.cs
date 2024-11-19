string input = Console.ReadLine();

string encryptedText = "";

for (int i = 0; i < input.Length; i++)
{
    char encryptedChar = (char)(input[i] + 3);
    encryptedText += encryptedChar;
}

Console.WriteLine(encryptedText);