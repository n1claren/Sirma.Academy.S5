string input = Console.ReadLine();

List<string> words = input.Split(" ").ToList();

Random random = new Random();

while (words.Count > 0)
{
    int indexer = random.Next(words.Count);

    Console.WriteLine(words[indexer]);

    words.RemoveAt(indexer);
}