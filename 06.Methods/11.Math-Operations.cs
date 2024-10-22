double firstNumber = double.Parse(Console.ReadLine());

char operation = char.Parse(Console.ReadLine());

double secondNumber = double.Parse(Console.ReadLine());

Console.WriteLine(Calculate(firstNumber, operation, secondNumber));

static double Calculate(double firstNumber, char operation, double secondNumber)
{
    double result = 0;

    switch (operation)
    {
        case '+':
            result = firstNumber + secondNumber;
            break;

        case '-':
            result = firstNumber - secondNumber;
            break;

        case '*':
            result = firstNumber * secondNumber;
            break;

        case '/':
            if (secondNumber != 0) 
            {
                result = firstNumber / secondNumber;
            }
            else
            {
                Console.WriteLine("Division by zero is not allowed!");
                return double.NaN;
            }
            break;

        default:
            Console.WriteLine("Invalid operator.");
            return double.NaN;
    }

    return result;
}