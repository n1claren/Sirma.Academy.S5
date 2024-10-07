int n = int.Parse(Console.ReadLine());

int sum = 0;

for (int i = 1; i < int.MaxValue; i++)
{
    if (n == 0)
    {
        break;
    }

    if (i % 2 == 0)
    {
        sum += i;
        n--;
    }
}

Console.WriteLine(sum);