string input = "";

Queue<string> printerQ = new Queue<string>();

while ((input = Console.ReadLine()) != "print")
{
    if (input == "cancel")
    {
        if (printerQ.Count == 0)
        {
            Console.WriteLine("StandBy");
        }
        else
        {
            Console.WriteLine($"Canceled {printerQ.Dequeue()}");
        }
    }
    else
    {
        printerQ.Enqueue(input);
    }
}