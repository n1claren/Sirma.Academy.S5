int number = int.Parse(Console.ReadLine());
int power = int.Parse(Console.ReadLine());

RaiseToPower(number, power);

static void RaiseToPower(int number, int power)
{
    int result = number;

    for (int i = 1; i < power; i++)
    {
        result = result * number;
    }

    Console.WriteLine(result);
}