string input = "";

string currentURL = null;

Stack<string> history = new Stack<string>();

while ((input = Console.ReadLine()) != "Home")
{
    if (input == "back")
    {
        if (history.Count == 0)
        {
            Console.WriteLine("no previous URLs");
        }
        else
        {
            currentURL = history.Pop();
            Console.WriteLine(currentURL);
        }
    }

    if (input != "back")
    {
        if (currentURL != null)
        {
            history.Push(currentURL);
        }

        currentURL = input;

        Console.WriteLine(currentURL);
    }
}