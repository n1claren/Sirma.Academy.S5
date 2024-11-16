var firstPlayerCards = new Queue<int>(Console.ReadLine()
                                             .Split(' ')
                                             .Select(x => int.Parse(x))
                                             .Distinct());

var secondPlayerCards = new Queue<int>(Console.ReadLine()
                                              .Split(' ')
                                              .Select(x => int.Parse(x))
                                              .Distinct());

for (int i = 0; i < 50; i++)
{
    if (firstPlayerCards.Count == 0 || secondPlayerCards.Count == 0)
        break;

    int firstCard = firstPlayerCards.Dequeue();
    int secondCard = secondPlayerCards.Dequeue();

    if (firstCard > secondCard)
    {
        firstPlayerCards.Enqueue(firstCard);
        firstPlayerCards.Enqueue(secondCard);
    }
    else if (secondCard > firstCard)
    {
        secondPlayerCards.Enqueue(secondCard);
        secondPlayerCards.Enqueue(firstCard);
    }
}

if (firstPlayerCards.Count > secondPlayerCards.Count)
{
    Console.WriteLine("First player wins!");
}
else if (secondPlayerCards.Count > firstPlayerCards.Count)
{
    Console.WriteLine("Second player wins!");
}
else
{
    Console.WriteLine("Draw!");
}