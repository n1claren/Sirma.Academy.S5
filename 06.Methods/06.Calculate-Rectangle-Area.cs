int width = int.Parse(Console.ReadLine());
int length  = int.Parse(Console.ReadLine());

CalculateRectangleArea(width, length);

static void CalculateRectangleArea(int a, int b)
{
    Console.WriteLine(a * b);
}