string[] hotPotatoMembers = Console.ReadLine().Split(" ").ToArray();

Queue<string> circle = new Queue<string>();

int rotation = int.Parse(Console.ReadLine());

int tempRotation = rotation;

foreach (string member in hotPotatoMembers)
{
    circle.Enqueue(member);
}

while (circle.Count > 1)
{
    tempRotation--;

    if (tempRotation == 0)
    {
        Console.WriteLine($"Remove {circle.Dequeue()}");
        tempRotation = rotation;
        continue;
    }

    string tempPerson = circle.Dequeue();

    circle.Enqueue(tempPerson);
}

Console.WriteLine($"Last is {circle.Dequeue()}");