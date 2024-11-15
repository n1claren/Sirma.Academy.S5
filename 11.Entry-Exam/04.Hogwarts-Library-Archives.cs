string[] records = Console.ReadLine().Split(", ");
string name = Console.ReadLine();

int firstOccurance = -1;
int lastOccurance = -1;

for (int i = 0; i < records.Length; i++)
{
    if (records[i] == name)
    {
        if (firstOccurance < 0)
        {
            firstOccurance = i;
        }

        if (lastOccurance < i)
        {
            lastOccurance = i;
        }
    }
}

if (firstOccurance < 0)
{
    Console.WriteLine("Record not found");
}
else
{
    Console.WriteLine($"First Occurrence: {firstOccurance}");
    Console.WriteLine($"Last Occurrence: {lastOccurance}");
}