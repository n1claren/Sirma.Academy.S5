int age = int.Parse(Console.ReadLine());

int ticketPrice = 0;

if (age >= 0 && age <= 12)
{
    ticketPrice = 5;
}
else if (age >= 13 && age <= 19)
{
    ticketPrice = 8;  
}
else if (age >= 20)
{
    ticketPrice = 10; 
}

Console.WriteLine($"${ticketPrice}");