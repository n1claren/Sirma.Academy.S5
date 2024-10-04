double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

string destination = "";
string typeOfHoliday = "";
double amountSpent = 0;

if (budget <= 100)
{
    destination = "Bulgaria";

    if (season == "summer")
    {
        typeOfHoliday = "Camp";
        amountSpent = budget * 0.30;
    }
    else if (season == "winter")
    {
        typeOfHoliday = "Hotel";
        amountSpent = budget * 0.70;
    }
}
else if (budget <= 1000)
{
    destination = "Europe";

    if (season == "summer")
    {
        typeOfHoliday = "Camp";
        amountSpent = budget * 0.40;
    }
    else if (season == "winter")
    {
        typeOfHoliday = "Hotel";
        amountSpent = budget * 0.80;
    }
}
else
{
    destination = "Asia";
    typeOfHoliday = "Hotel";
    amountSpent = budget * 0.90;
}

Console.WriteLine($"Somewhere in {destination}");
Console.WriteLine($"{typeOfHoliday} – {amountSpent:F2}");