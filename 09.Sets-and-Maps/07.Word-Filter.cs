// where's the dictionary in this problem :?

string[] input = Console.ReadLine().Split(" ");

for  (int i = 0; i < input.Length; i++)
{
    if (input[i].Length % 2 == 0)
    {
        Console.WriteLine(input[i]);
    }
}