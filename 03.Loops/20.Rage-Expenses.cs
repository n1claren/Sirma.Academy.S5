// LMAO as a MOBA player myself i FULLY understand the topic of this problem XD

int gamesLost = int.Parse(Console.ReadLine());
double headsetPrice = double.Parse(Console.ReadLine());
double mousePrice = double.Parse(Console.ReadLine());
double keyboardPrice = double.Parse(Console.ReadLine());
double monitorPrice = double.Parse(Console.ReadLine());

double rageExpenses = 0;
int trashedKeyboards = 0;

for (int i = 1; i <= gamesLost; i++)
{
    if (i % 2 == 0 && i % 3 == 0)
    {
        rageExpenses += headsetPrice;
        rageExpenses += mousePrice;
        rageExpenses += keyboardPrice;

        trashedKeyboards++;

        if (trashedKeyboards % 2 == 0)
        {
            rageExpenses += monitorPrice;
        }
    }
    else if (i % 2 == 0)
    {
        rageExpenses += headsetPrice;
    }
    else if (i % 3 == 0)
    {
        rageExpenses += mousePrice;
    }
}

Console.WriteLine($"Rage expenses: {rageExpenses:F2} lv");