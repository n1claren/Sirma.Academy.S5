int n = int.Parse(Console.Readline());

for (int i = 1; i <= 1000; i++)
{
    if (i % 10 == n)
    {
        Console.WriteLine(i);
    }
}