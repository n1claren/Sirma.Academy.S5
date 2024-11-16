// what is even the point of this problem? :D

int inputs = int.Parse(Console.ReadLine());

HashSet<string> uniqueUsernames = new HashSet<string>();

for (int i = 0; i < inputs; i++)
{
    uniqueUsernames.Add(Console.ReadLine());
}

foreach (string uniqueUsername in uniqueUsernames)
{
    Console.WriteLine(uniqueUsername);
}