string product = Console.ReadLine();
string city = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());

double teaPrice = 0;
double waterPrice = 0;
double juicePrice = 0;
double sweetsPrice = 0;
double chipsPrice = 0;

if (city == "Sofia")
{
    teaPrice = 0.50;
    waterPrice = 0.80;
    juicePrice = 1.20;
    sweetsPrice = 1.45;
    chipsPrice = 1.60;
}
else if (city == "Plovdiv")
{
    teaPrice = 0.40;
    waterPrice = 0.70;
    juicePrice = 1.15;
    sweetsPrice = 1.30;
    chipsPrice = 1.50;
}
else if (city == "Varna")
{
    teaPrice = 0.45;
    waterPrice = 0.70;
    juicePrice = 1.10;
    sweetsPrice = 1.35;
    chipsPrice = 1.55;
}

double receipt = 0;

if (product == "tea")
{
    receipt = quantity * teaPrice;
} 
else if (product == "water")
{
    receipt = quantity * waterPrice;
}
else if (product == "juice")
{
    receipt = quantity * juicePrice;
}
else if (product == "sweets")
{
    receipt = quantity * sweetsPrice;
}
else if (product == "chips")
{
    receipt = quantity * chipsPrice;
}

Console.WriteLine($"{receipt:F2}");