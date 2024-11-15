int initialCount = int.Parse(Console.ReadLine());
int increaseInCount = int.Parse(Console.ReadLine());
int numberOfHours = int.Parse(Console.ReadLine());

int total = 0;

for (int i = 0; i < numberOfHours; i++)
{
    total += initialCount + increaseInCount * i;
}

Console.WriteLine(total);