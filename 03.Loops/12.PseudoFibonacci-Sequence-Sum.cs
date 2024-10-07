int n = int.Parse(Console.ReadLine());

int first = 1, second = 1, sum = 0;

for (int i = 1; i <= n; i++)
{
    if (i == 1 || i == 2)
    {
        sum += 1;
    }
    else
    {
        int next = first + second;
        sum += next;  
        first = second;
        second = next;
    }
}

Console.WriteLine(sum);