int score = int.Parse(Console.ReadLine());

if (score >= 90 && score <= 100)
{
    Console.WriteLine("A");
}
else if (score >= 80 && score < 90)
{
    Console.WriteLine("B");
}
else if (score >= 70 && score < 80)
{
    Console.WriteLine("C");
}
else if (score >= 60 && score < 70)
{
    Console.WriteLine("D");
}
else if (score >= 0 && score < 60)
{
    Console.WriteLine("F");
}
else
{
    Console.WriteLine("Invalid input. Please enter a score between 0 and 100.");
}