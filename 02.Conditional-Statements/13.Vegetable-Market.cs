string vegetable = Console.ReadLine();
string day = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());

bool error = false;
double price = 0;

if (day != "Monday" && 
    day != "Tuesday" && 
    day != "Wednesday" && 
    day != "Thursday" && 
    day != "Friday" &&
    day != "Saturday" &&
    day != "Sunday")
{
    error = true;
}

if (vegetable != "tomato" &&
    vegetable != "onion" &&
    vegetable != "lettuce" &&
    vegetable != "cucumber" &&
    vegetable != "pepper")
{
    error = true;
}

double tomatoPrice = 0;
double onionPrice = 0;
double lettucePrice = 0;
double cucumberPrice = 0;
double pepperPrice = 0;

if (day == "Saturday" ||  day == "Sunday")
{
    tomatoPrice = 2.80;
    onionPrice = 1.30;
    lettucePrice = 0.85;
    cucumberPrice = 1.75;
    pepperPrice = 3.50;
} 
else
{
    tomatoPrice = 2.50;
    onionPrice = 1.20;
    lettucePrice = 0.85;
    cucumberPrice = 1.45;
    pepperPrice = 5.50;
}

if (error)
{
    Console.WriteLine("Error");
}
else
{
    if (vegetable == "tomato")
    {
        price = tomatoPrice * quantity;
        Console.WriteLine($"{price:F2}");
    }
    else if (vegetable == "onion")
    {
        price = onionPrice * quantity;
        Console.WriteLine($"{price:F2}");
    }
    else if (vegetable == "lettuce")
    {
        price = lettucePrice * quantity;
        Console.WriteLine($"{price:F2}");
    }
    else if (vegetable == "cucumber")
    {
        price = cucumberPrice * quantity;
        Console.WriteLine($"{price:F2}");
    }
    else if (vegetable == "pepper")
    {
        price = pepperPrice * quantity;
        Console.WriteLine($"{price:F2}");
    }
}