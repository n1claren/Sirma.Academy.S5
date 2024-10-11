double budget = double.Parse(Console.ReadLine());
int students = int.Parse(Console.ReadLine());
double lightsaberPrice = double.Parse(Console.ReadLine());
double robePrice = double.Parse(Console.ReadLine());
double beltPrice = double.Parse(Console.ReadLine());

double lightsabersSpending = Math.Ceiling(students * 1.1) * lightsaberPrice;
double robesSpending = students * robePrice;
double beltsSpending = 0;

for (int i = 1; i <= students; i++)
{
    if (i % 6 == 0)
    {
        beltsSpending += 0;
    } 
    else
    {
        beltsSpending += beltPrice;
    }
}

double totalSpending = lightsabersSpending + robesSpending + beltsSpending;

if (budget > totalSpending)
{
    Console.WriteLine($"The money is enough - it would cost {totalSpending:F2}lv.");
}
else
{
    Console.WriteLine($"George Lucas will need {totalSpending - budget:F2}lv more.");
}