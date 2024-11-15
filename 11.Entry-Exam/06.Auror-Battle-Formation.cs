List<int> formation = Console.ReadLine().Split(", ").Select(x => int.Parse(x)).ToList();

string command = "";

while ((command = Console.ReadLine()) != "end")
{
    string[] arguments = command.Split(" ");

    string action = arguments[0];

    switch (action)
    {
        case "destroy":
            int index = int.Parse(arguments[1]);

            if (index >= 0 && index < formation.Count)
            {
                formation.RemoveAt(index);

                Console.WriteLine(String.Join(" ", formation));
            }
            break;

        case "swap":
            int firstIndex = int.Parse(arguments[1]);
            int secondIndex = int.Parse(arguments[2]);

            if (firstIndex >= 0 &&
                secondIndex >= 0 &&
                firstIndex < formation.Count &&
                secondIndex < formation.Count &&
                firstIndex != secondIndex)
            {
                int temp = formation[secondIndex];

                formation[secondIndex] = formation[firstIndex];
                formation[firstIndex] = temp;

                Console.WriteLine(String.Join(" ", formation));
            }
            break;

        case "add":
            int newAuror = int.Parse(arguments[1]);

            formation.Add(newAuror);

            Console.WriteLine(String.Join(" ", formation));
            break;

        case "insert":
            int insertingAuror = int.Parse(arguments[1]);
            int insertIndex = int.Parse(arguments[2]);

            if (insertIndex >= 0 && insertIndex < formation.Count)
            {
                formation.Insert(insertIndex, insertingAuror);

                Console.WriteLine(String.Join(" ", formation));
            }
            break;

        case "center":
            if (formation.Count % 2 == 0)
            {
                int firstMidElement = formation[formation.Count / 2 - 1];
                int secondMidElement = formation[formation.Count / 2];

                Console.WriteLine($"{firstMidElement} {secondMidElement}");
            }
            else
            {
                int midElement = formation[formation.Count / 2];

                Console.WriteLine(midElement);
            }
            break;

        default:
            Console.WriteLine("Unknown command");
            break;
    }
}