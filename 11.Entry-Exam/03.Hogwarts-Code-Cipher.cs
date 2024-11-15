string encryptedMessage = Console.ReadLine();
int cypher = int.Parse(Console.ReadLine());

string decryptedMessage = "";

for (int i = 0; i < encryptedMessage.Length; i++)
{
    char temp = encryptedMessage[i];

    decryptedMessage += (char)(temp - cypher);
}

Console.WriteLine(decryptedMessage);