int age = int.Parse(Console.ReadLine());

string hasMembership = Console.ReadLine();

double discount = 0;

if (age < 18)
{
    discount = 10;
}
else if (age >= 18 && age <= 64)
{
    if (hasMembership == "Yes")
    {
        discount = 20; 
    }
    else
    {
        discount = 10; 
    }
}
else
{
    discount = 30; 
}

Console.WriteLine($"{discount}% discount");