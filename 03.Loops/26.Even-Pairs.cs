int firstPairInitialValue = int.Parse(Console.ReadLine());
int secondPairInitialValue = int.Parse(Console.ReadLine());

int firstPairDifference = int.Parse(Console.ReadLine());
int secondPairDifference = int.Parse(Console.ReadLine());

int firstPairFinal = firstPairInitialValue + firstPairDifference;
int secondPairFinal = secondPairInitialValue + secondPairDifference;

for (int firstPair = firstPairInitialValue; firstPair <= firstPairFinal; firstPair++)
{
    bool isFirstPairPrime = true;

    if (firstPair < 2)
    {
        isFirstPairPrime = false;
    }
    else
    {
        for (int i = 2; i <= Math.Sqrt(firstPair); i++)
        {
            if (firstPair % i == 0)
            {
                isFirstPairPrime = false;
                break;
            }
        }
    }

    if (isFirstPairPrime)
    {
        for (int secondPair = secondPairInitialValue; secondPair <= secondPairFinal; secondPair++)
        {
            bool isSecondPairPrime = true;

            if (secondPair < 2)
            {
                isSecondPairPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(secondPair); i++)
                {
                    if (secondPair % i == 0)
                    {
                        isSecondPairPrime = false;
                        break;
                    }
                }
            }

            if (isSecondPairPrime)
            {
                Console.WriteLine($"{firstPair}{secondPair}");
            }
        }
    }
}