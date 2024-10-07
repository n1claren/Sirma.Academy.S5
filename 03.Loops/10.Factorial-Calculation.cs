int n = int.Parse(Console.ReadLine());

int sum = 1;

for (int i = n; i > 0; i--)
{
    sum *= i;
}

Console.WriteLine(sum);