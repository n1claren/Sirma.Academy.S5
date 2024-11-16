string input = "";

Dictionary<string, string> phonebook = new Dictionary<string, string>();

while ((input = Console.ReadLine()) != "stop") 
{
    if (input == "search")
    {
        continue;
    }

    if (input.Contains('-'))
    {
        string name = input.Split("-")[0];
        string number = input.Split("-")[1];

        phonebook[name] = number;
    }
    else
    {
        if (phonebook.ContainsKey(input))
        {
            Console.WriteLine($"{input} -> {phonebook[input]}");
        }
        else
        {
            Console.WriteLine($"Contact {input} does not exist.");
        }
    }
}