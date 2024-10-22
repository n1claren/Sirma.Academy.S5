int number = int.Parse(Console.ReadLine());

MultiplyEvenByOdd(number);

static void MultiplyEvenByOdd(int number)
{
    int evenSum = 0;
    int oddSum = 0;

    while (number != 0)
    {
        int digit = number % 10;

        if (digit % 2 == 0)
        {
            evenSum += digit;
        }
        else
        {
            oddSum += digit;
        }

        number /= 10;
    }

    Console.WriteLine(evenSum * oddSum);
}