string[] votes = Console.ReadLine().Split(", ");

int votesFor = 0;
int votesAgainst = 0;

foreach (string vote in votes)
{
    if (vote.ToLower() == "yes")
    {
        votesFor++;
    }
    else if (vote.ToLower() == "no")
    {
        votesAgainst++;
    }
}

if (votesFor > votesAgainst)
{
    Console.WriteLine("Yes");
}
else if (votesAgainst > votesFor)
{
    Console.WriteLine("No");
}
else if (votesAgainst == 0 && votesFor == 0)
{
    Console.WriteLine("Abstain");
}
else
{
    Console.WriteLine("Tie");
}