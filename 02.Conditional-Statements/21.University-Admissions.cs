int score = int.Parse(Console.ReadLine());

int extracurriculars = int.Parse(Console.ReadLine());

if (score >= 90)
{
    Console.WriteLine("Admitted");
}
else if (score >= 80 && score <= 89)
{
    if (extracurriculars >= 2)
    {
        Console.WriteLine("Admitted");
    }
    else
    {
        Console.WriteLine("Not admitted");
    }
}
else
{
    Console.WriteLine("Not admitted");
}