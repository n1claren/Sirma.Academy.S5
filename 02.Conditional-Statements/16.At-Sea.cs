int daysToStay = int.Parse(Console.ReadLine());

string roomType = Console.ReadLine();

string assessment = Console.ReadLine();

int nights = daysToStay - 1;

double pricePerNight = 0;

if (roomType == "single room")
{
    pricePerNight = 25.00;
}
else if (roomType == "apartment")
{
    pricePerNight = 50.00;
}
else if (roomType == "president apartment")
{
    pricePerNight = 100.00;
}

double totalPrice = pricePerNight * nights;

if (roomType == "apartment")
{
    if (nights < 10)
    {
        totalPrice *= 0.70;  
    }
    else if (nights <= 15)
    {
        totalPrice *= 0.65; 
    }
    else
    {
        totalPrice *= 0.50; 
    }
}
else if (roomType == "president apartment")
{
    if (nights < 10)
    {
        totalPrice *= 0.90;  
    }
    else if (nights <= 15)
    {
        totalPrice *= 0.85;  
    }
    else
    {
        totalPrice *= 0.80;
    }
}

if (assessment == "positive")
{
    totalPrice *= 1.25;
}
else if (assessment == "negative")
{
    totalPrice *= 0.90; 
}

Console.WriteLine($"Total price: {totalPrice:F2} BGN");