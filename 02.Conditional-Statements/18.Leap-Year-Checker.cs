int year = int.Parse(Console.ReadLine());

bool isLeapYear = false;

if (year % 4 == 0)
{
    if (year % 100 == 0)
    {
        if (year % 400 == 0)
        {
            isLeapYear = true;
        }
    }
    else
    {
        isLeapYear = true;
    }
}

if (isLeapYear)
{
    Console.WriteLine("It‘s a leap year!");
}
else
{
    Console.WriteLine("It‘s not a leap year.");
}