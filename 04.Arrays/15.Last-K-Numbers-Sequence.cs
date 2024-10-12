int n = int.Parse(Console.ReadLine()); 
int k = int.Parse(Console.ReadLine()); 

int[] result = new int[n];

result[0] = 1;

for (int i = 1; i < result.Length; i++) 
{
    int boundChecker = n - (result.Length - i);

    if (boundChecker > k)
    {
        boundChecker = k;
    }

    int temp = 0;

    for (int z = 1; z <= boundChecker; z++)
    {
        temp += result[i - z];
    }

    result[i] = temp;
}

Console.WriteLine(string.Join(" ", result));