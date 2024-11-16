int inputs = int.Parse(Console.ReadLine());

SortedDictionary<string, string> registrations = new SortedDictionary<string, string>();

for (int i = 0; i < inputs; i++)
{
    string[] data = Console.ReadLine().Split(" ");

    string command = data[0];
    string name = "";
    string license = "";

    if (command.ToLower() == "register")
    {
        name = data[1];
        license = data[2];

        if (registrations.ContainsKey(name))
        {
            Console.WriteLine($"ERROR: already registered with plate number {registrations[name]}");
        }
        else
        {
            registrations.Add(name, license);

            Console.WriteLine($"{name} registered {license} successfully.");
        }
    }

    if (command.ToLower() == "unregister")
    {
        name = data[1];

        if (registrations.ContainsKey(name))
        {
            registrations.Remove(name);

            Console.WriteLine($"{name} unregistered successfully.");
        }
        else
        {
            Console.WriteLine($"ERROR: user {name} not found");
        }
    }
}

foreach (var kvp in registrations)
{
    Console.WriteLine($"{kvp.Key} => {kvp.Value}");
}