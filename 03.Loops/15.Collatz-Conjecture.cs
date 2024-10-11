int n = int.Parse(Console.ReadLine());

Console.Write(n + " ");

while (n > 1)
{
    if (n % 2 == 0)
    {
        n /= 2;
    }
    else
    {
        n = (n * 3) + 1;
    }

    Console.Write(n + " ");
}