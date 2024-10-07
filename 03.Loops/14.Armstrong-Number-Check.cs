int number = int.Parse(Console.ReadLine());

int copyNumber = number;
int digitsCount = 0;

while (copyNumber != 0)
{
    copyNumber /= 10;
    digitsCount++;
}

copyNumber = number; 
int sum = 0;

while (copyNumber != 0)
{
    int digit = copyNumber % 10;
    int power = 1;

    for (int i = 0; i < digitsCount; i++)
    {
        power *= digit;
    }

    sum += power;
    copyNumber /= 10;
}

if (sum == number)
{
    Console.WriteLine("TRUE");
}
else
{
    Console.WriteLine("FALSE");
}