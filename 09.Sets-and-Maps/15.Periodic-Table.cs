int inputs = int.Parse(Console.ReadLine());

HashSet<string> uniqueElements = new HashSet<string>();

for (int i = 0; i < inputs; i++)
{
    string[] input = Console.ReadLine().Split(" ");

    foreach (string s in input)
    {
        uniqueElements.Add(s);
    }
}

var sorted = uniqueElements.OrderBy(x => x).ToList();

Console.WriteLine(String.Join(" ", sorted));