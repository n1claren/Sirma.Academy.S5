int oneLevCoins = int.Parse(Console.ReadLine());
int twoLevCoins = int.Parse(Console.ReadLine());
int fiveLevBanknotes = int.Parse(Console.ReadLine());
int totalSum = int.Parse(Console.ReadLine());

for (int oneLvCount = 0; oneLvCount <= oneLevCoins; oneLvCount++)
{
    for (int twoLvCount = 0; twoLvCount <= twoLevCoins; twoLvCount++)
    {
        for (int fiveLvCount = 0; fiveLvCount <= fiveLevBanknotes; fiveLvCount++)
        {
            int total = oneLvCount * 1 + twoLvCount * 2 + fiveLvCount * 5;

            if (total == totalSum)
            {
                Console.WriteLine($"{oneLvCount} * 1 lv. + {twoLvCount} * 2 lv. + {fiveLvCount} * 5 lv. = {total} lv.");
            }
        }
    }
}