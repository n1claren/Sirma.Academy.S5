string filePath = "C:\\Users\\n1c\\Desktop\\input.txt";

StreamReader sr = new StreamReader(filePath);

Dictionary<char, int> map = new Dictionary<char, int>();

using (sr)
{
    string line = null;

    while ((line = sr.ReadLine()) != null)
    {
        for (int i = 0; i < line.Length; i++)
        {
            char currentChar = line[i];

            if (!map.ContainsKey(currentChar))
            {
                map[currentChar] = 1;
            }

            map[currentChar]++;
        }
    }
}

foreach (var kvp in map)
{
    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
}