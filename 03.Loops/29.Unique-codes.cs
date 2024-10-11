int upperLimitFirst = int.Parse(Console.ReadLine());
int upperLimitSecond = int.Parse(Console.ReadLine());
int upperLimitThird = int.Parse(Console.ReadLine());

for (int firstDigit = 2; firstDigit <= upperLimitFirst; firstDigit += 2)
{
    for (int secondDigit = 2; secondDigit <= upperLimitSecond; secondDigit++)
    {
        if (secondDigit == 2 || secondDigit == 3 || secondDigit == 5 || secondDigit == 7)
        {
            for (int thirdDigit = 2; thirdDigit <= upperLimitThird; thirdDigit += 2) 
            {
                Console.WriteLine($"{firstDigit} {secondDigit} {thirdDigit}");
            }
        }
    }
}