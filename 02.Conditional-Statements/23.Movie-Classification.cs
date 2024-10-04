int age = int.Parse(Console.ReadLine());

if (age < 13)
{
    Console.WriteLine("U-rated movies");
}
else if (age >= 13 && age <= 17)
{
    Console.WriteLine("U and PG-13 rated movies");
}
else
{
    Console.WriteLine("All movies");
}